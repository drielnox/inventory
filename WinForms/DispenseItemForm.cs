﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.DataAccess;
using SmartInventorySystem.WinForms.View;
using SmartInventorySystem.WinForms.Presenter;
using SmartInventorySystem.ViewModel.Forms;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.WinForms
{
    public partial class DispenseItemForm : Form, IDispenseItemView
    {
        private readonly DispenseItemPresenter _presenter;

        public DispenseItemFormViewModel State { get; protected set; }

        public DispenseItemForm()
        {
            InitializeComponent();

            _presenter = new DispenseItemPresenter(this);

            State = new DispenseItemFormViewModel();

            bsForm.DataSource = State;
        }

        private void frmDispense_Load(object sender, EventArgs e)
        {
            try
            {
                txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                txtgroupDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

                generateRandom();
                txtSearch.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        private void UpdateQty_Amt()
        {
            Program.Logger.Debug("Entering to UpdateQty_Amt()");

            try
            {
                int level, deduct, balance;
                float unit, amountSub;
                level = int.Parse(txtStockLevel.Text);
                deduct = int.Parse(txtDispenseQty.Text);

                if (level < 1)
                {
                    MessageBox.Show("Stock level of this item is Empty. Please refill stock before dispensing");
                    //txtDispenseQty.Text = "0";
                    //txtAmountSub.Text = "0";
                    //txtStockLevel.Focus();
                }
                else if (deduct > level)
                {
                    MessageBox.Show("Stock level is lower than dispense quantity. Please refill stock or dispense a lower quantity value");
                    //txtDispenseQty.Text = "0";
                    //txtStockBal.Text = txtStockLevel.Text;
                    //txtStockLevel.Focus();
                }
                else
                {
                    balance = level - deduct;
                    txtStockBal.Text = balance.ToString();

                    unit = float.Parse(txtUnitPrice.Text);
                    amountSub = deduct * unit;
                    txtAmountSub.Text = amountSub.ToString();

                    //txtAmountSub.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        // search for drug or item using search box
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _presenter.SearchItem();
            _presenter.ClearSearchItemText();

            pnlSearch.Visible = true;
        }

        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try
            {
                var selectedItem = bsSearchedItems.Current as ItemRowViewModel;

                if (selectedItem != null)
                {
                    txtItemid.Text = selectedItem.Identifier.ToString();
                    txtCode.Text = selectedItem.Code;
                    txtItemName.Text = selectedItem.Name;
                    txtUnitPrice.Text = selectedItem.PurchasePrice.ToString();
                    txtStockLevel.Text = selectedItem.StockLevel.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }

        // display data of selected record onto item record textboxes
        private void btnSelect_Click(object sender, EventArgs e)
        {
            _presenter.LoadSelectedItemDetails();
            try
            {
                DataGridViewRow dr = dgvSearchedItem.SelectedRows[0];
                txtItemid.Text = dr.Cells[0].Value.ToString();

                Load_ItemsRecord();
                pnlDispenseItem.Visible = true;
                pnlSearch.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }
        
        // update item records with new stock level 
        private void Update_Stock()
        {
            try
            {
                if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }

                int parsedId;
                int.TryParse(txtItemid.Text, out parsedId);

                using (var ctx = new InventoryModel())
                {
                    var item = ctx.Items.Single(x => x.Identifier == parsedId);

                    item.StockLevel = int.Parse(txtStockBal.Text);

                    ctx.SaveChanges();
                }

                MessageBox.Show("Stock Level Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }

        // summary log of single item dispensary 
        private void Summary_Dispensary()
        {
            try
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }
                else if (txtVat.Text == "")
                {
                    txtVat.Text = "0.00";
                }

                var dis_summ = new DispenseSummary();
                dis_summ.GroupId = txtRandom.Text;
                dis_summ.GroupDate = DateTime.Parse(txtgroupDate.Text);
                dis_summ.SubAmount = float.Parse(txtAmountTotal.Text);
                dis_summ.Discount = float.Parse(txtDiscount.Text);
                dis_summ.Vat = float.Parse(txtVat.Text);
                dis_summ.Total = float.Parse(txtTotalFinal.Text);
                dis_summ.DateDispensed = DateTime.Parse(txtDateAmend.Text);
                dis_summ.UserDispensed = Environment.UserName;

                using (var ctx = new InventoryModel())
                {
                    ctx.DispenseSummaries.Add(dis_summ);

                    ctx.SaveChanges();
                }

                MessageBox.Show("Item successfully dispensed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        // save single item dispensary 
        private void Save_Dispensary()
        {
            try
            {
                int level, qty, bal;
                level = int.Parse(txtStockLevel.Text);
                qty = int.Parse(txtDispenseQty.Text);
                bal = int.Parse(txtStockBal.Text);
                bal = level - qty;

                txtStockBal.Text = bal.ToString();

                var dis = new Dispense();
                dis.ItemId = txtItemid.Text;
                dis.GroupId = txtRandom.Text;
                dis.GroupDate = DateTime.Parse(txtgroupDate.Text);
                dis.ItemCode = txtCode.Text;
                dis.ItemName = txtItemName.Text;
                dis.StockLevel = int.Parse(txtStockLevel.Text);
                dis.UnitPrice = float.Parse(txtUnitPrice.Text);
                dis.DispenseQuantity = int.Parse(txtDispenseQty.Text);
                dis.SubAmount = float.Parse(txtAmountSub.Text);
                dis.StockBalance = int.Parse(txtStockBal.Text);
                dis.DateDispensed = DateTime.Parse(txtDateAmend.Text);
                dis.UserDispensed = Environment.UserName;

                using (var ctx = new InventoryModel())
                {
                    ctx.Dispenses.Add(dis);

                    ctx.SaveChanges();
                }

                MessageBox.Show("Item successfully dispensed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        //calculate the total price for all items dispense (including vat and discount)
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //UpdateQty_Amt();
            //Update_Stock();            
            //Save_Dispensary();
            //dispense_sheet();
            //CalcTotal_Amount();

            txtItemid.Clear();
            txtDspid.Clear();
            txtCode.Clear();
            txtItemName.Clear();
            txtStockLevel.Clear();
            txtStockBal.Clear();
            txtUnitPrice.Clear();
            txtDispenseQty.Clear();
            txtAmountSub.Clear();

            pnlCheckout.Visible = true;
            pnlDispenseItem.Visible = false;
            btnComputeTotal.Enabled = true;
            btnSave.Enabled = true;
            txtSearch.Focus();
        }

        // display selected item to be dispensed into a grid sheet
        private void dispense_sheet()
        {
            try
            {
                var dispenseSheet = new List<DispenseSheetViewModel>();
                var parsedGroupDate = DateTime.Parse(txtgroupDate.Text);

                using (var ctx = new InventoryModel())
                {
                    dispenseSheet = ctx.Dispenses
                        .Where(x => x.GroupId == txtRandom.Text)
                        .Where(x => x.GroupDate == parsedGroupDate)
                        .Select(x => new DispenseSheetViewModel
                        {
                            ItemName = x.ItemName,
                            DispenseQuantity = x.DispenseQuantity,
                            SubAmount = x.SubAmount,
                        })
                        .ToList();
                }

                bsDispenseSheet.DataSource = dispenseSheet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        private void generateRandom()
        {
            // generate a random number between the specified range
            try
            {
                Random dispGroup = new Random();
                int num = dispGroup.Next(0, 100000);
                txtRandom.Text = num.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        private void CalcTotal_Amount()
        {
            try
            {
                float subAmt, totalAmount;
                subAmt = float.Parse(txtAmountSub.Text);
                totalAmount = float.Parse(txtAmountTotal.Text);
                totalAmount = totalAmount + subAmt;

                txtAmountTotal.Text = totalAmount.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            UpdateQty_Amt();
            Update_Stock();
            Save_Dispensary();
            dispense_sheet();
            CalcTotal_Amount();

            txtItemid.Clear();
            txtDspid.Clear();
            txtCode.Clear();
            txtItemName.Clear();
            txtStockLevel.Clear();
            txtStockBal.Clear();
            txtUnitPrice.Clear();
            txtDispenseQty.Clear();
            txtAmountSub.Clear();

            pnlCheckout.Visible = true;
            txtSearch.Focus();
        }
        
        // save outcome of dispensary action (completed or cancelled) 
        private void Dispensary_Outcome()
        {
            try
            {
                txtdispStatus.Text = "YES";

                var parsedGroupDate = DateTime.Parse(txtgroupDate.Text);

                using (var ctx = new InventoryModel())
                {
                    var dis = ctx.Dispenses
                        .Single(x => x.GroupId == txtRandom.Text
                                     && x.GroupDate == parsedGroupDate);

                    dis.DispenseCompleted = txtdispStatus.Text;
                    dis.DateDispensed = DateTime.Parse(txtDateAmend.Text);
                    dis.UserDispensed = Environment.UserName;

                    ctx.SaveChanges();
                }

                MessageBox.Show("Stock Level Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispansary");
            }

        }

        private void btnComputeTotal_Click_1(object sender, EventArgs e)
        {
            try
            {

                float amountSub1, discount, discounted, vat, vatAmount, total;
                amountSub1 = float.Parse(txtAmountTotal.Text);
                discount = float.Parse(txtDiscount.Text);
                vat = float.Parse(txtVat.Text);
                discounted = amountSub1 - discount;
                vatAmount = vat / 100 * discounted;
                //total = float.Parse(txtTotalFinal.Text + ".00");

                total = discounted + vatAmount;
                txtTotalFinal.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            Summary_Dispensary();
            Dispensary_Outcome();
            pnlCheckout.Visible = false;

            txtAmountTotal.Clear();
            txtDiscount.Clear();
            txtVat.Clear();
            txtTotalFinal.Clear();

            Close();
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowInfo(string msg)
        {
            MessageBox.Show(this, msg, "Dispense Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Dispense Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdateFormBindingSource()
        {
            bsForm.ResetBindings(false);
        }

        private void bsItem_CurrentChanged(object sender, EventArgs e)
        {
            State.SelectedItem = bsSearchedItems.Current as ItemRowViewModel;
            _presenter.EnableSelectItem();
        }

        public void SetSelectItemEnable(bool v)
        {
            btnSelectItem.Enabled = v;
        }

        public void SetItemDetailsPanelEnable(bool v)
        {
            pnlDispenseItem.Enabled = v;
        }

        public void LoadItemsDetails(ItemRowViewModel selectedItem)
        {
            txtItemid.Text = selectedItem.Identifier.ToString();
        }
    }
}

