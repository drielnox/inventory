using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.Model;
using SmartInventorySystem.ViewModel;
using SmartInventorySystem.DataAccess;

namespace SmartInventorySystem.WinForms
{
    public partial class DispenseItemForm : Form
    {
        public DispenseItemForm()
        {
            InitializeComponent();
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
            try
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("No item or drug search requested");
                }
                else
                {
                    var items = new List<ItemViewModel>();
                    int parsedId;
                    int.TryParse(txtSearch.Text, out parsedId);

                    using (var ctx = new InventoryModel())
                    {
                        items = ctx.Items
                            .Where(x => x.Name.StartsWith(txtSearch.Text)
                                        || x.Code == txtSearch.Text
                                        || x.Identifier == parsedId)
                            .Select(x => new ItemViewModel
                            {
                                Identifier = x.Identifier,
                                Code = x.Code,
                                Name = x.Name,
                                Description = x.Description,
                                AlternativeName = x.AlternativeName,
                                Manufacturer = x.Manufacturer,
                                MajorSupplier = x.MajorSupplier,
                                PackQuantity = x.PackQuantity,
                                PackDescription = x.PackDescription,
                                AlternativeItem = x.AlternativeItem,
                                StandardIssueQuantity = x.StandardIssueQuantity,
                                EconomicOrderQuantity = x.EconomicOrderQuantity,
                                PurchasePrice = x.PurchasePrice,
                                MarkupPercent = x.MarkupPercent,
                                SellingPrice = x.SellingPrice,
                                StockLevel = x.StockLevel,
                                MinimumLevel = x.MinimumLevel,
                                ReOrderLevel = x.ReOrderLevel,
                                MaximumLevel = x.MaximumLevel,
                                LeadDays = x.LeadDays,
                            })
                            .ToList();
                    }

                    bsItem.DataSource = items;

                    txtSearch.Clear();
                    panel3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");
            }
        }

        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try
            {
                var selectedItem = bsItem.Current as ItemViewModel;

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
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtItemid.Text = dr.Cells[0].Value.ToString();

                Load_ItemsRecord();
                panel1.Visible = true;
                panel3.Visible = false;

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

            panel2.Visible = true;
            panel1.Visible = false;
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

            panel2.Visible = true;
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
            panel2.Visible = false;

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
    }
}

