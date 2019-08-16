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
    public partial class frmStock_Update : Form
    {
        public frmStock_Update()
        {
            InitializeComponent();
        }

        private void frmStock_Update_Load(object sender, EventArgs e)
        {
            try
            {

                txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }

        private void txtStockLevel_Leave(object sender, EventArgs e)
        {
            try
            {
                int level, add, deduct, balance;
                level = int.Parse(txtStockLevel.Text);
                add = int.Parse(txtAdd.Text);
                deduct = int.Parse(txtDeduct.Text);
                balance = (level + add) - deduct;
                txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }

        private void txtAdd_Leave(object sender, EventArgs e)
        {
            try
            {
                int level, add, deduct, balance;
                level = int.Parse(txtStockLevel.Text);
                add = int.Parse(txtAdd.Text);
                deduct = int.Parse(txtDeduct.Text);
                balance = (level + add) - deduct;
                txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }

        private void txtDeduct_Leave(object sender, EventArgs e)
        {
            try
            {
                int level, add, deduct, balance;
                level = int.Parse(txtStockLevel.Text);
                add = int.Parse(txtAdd.Text);
                deduct = int.Parse(txtDeduct.Text);
                balance = (level + add) - deduct;
                txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
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

                    bsItemsSearched.DataSource = items;

                    txtSearch.Clear();
                    dataGridView1.Visible = true;
                    btnSelect.Visible = true;

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

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }


        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try
            {
                var selectedItem = bsItemsSearched.Current as ItemViewModel;

                if (selectedItem != null)
                {
                    txtItemid.Text = selectedItem.Identifier.ToString();
                    txtCode.Text = selectedItem.Code;
                    txtItemName.Text = selectedItem.Name;
                    txtStockLevel.Text = selectedItem.StockLevel.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }
        }


        // save stock adjustment data 
        private void Save_StockUpdate()
        {
            try
            {
                if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }
                else if (txtAdd.Text == "")
                {
                    txtAdd.Text = "0";
                }
                else if (txtDeduct.Text == "")
                {
                    txtDeduct.Text = "0";
                }
                else if (txtStockBal.Text == "")
                {
                    txtStockBal.Text = "0";
                }

                var newStockUpdate = new StockUpdate();
                newStockUpdate.ItemId = txtItemid.Text;
                newStockUpdate.ItemCode = txtCode.Text;
                newStockUpdate.ItemName = txtItemName.Text;
                newStockUpdate.StockLevel = int.Parse(txtStockLevel.Text);
                newStockUpdate.QuantityAdded = int.Parse(txtAdd.Text);
                newStockUpdate.QuantityDeducted = int.Parse(txtDeduct.Text);
                newStockUpdate.StockBalance = int.Parse(txtStockBal.Text);
                newStockUpdate.UpdatedAt = DateTime.Now;
                newStockUpdate.UpdatedBy = Environment.UserName;

                using (var ctx = new InventoryModel())
                {
                    ctx.StockUpdates.Add(newStockUpdate);

                    ctx.SaveChanges();
                }

                MessageBox.Show("New Stock Level successfully saved");
                //this.Close(); 


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
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

                txtStockLevel.Text = txtStockBal.Text;

                using (var ctx = new InventoryModel())
                {
                    var aItem = ctx.Items
                        .Single(x => x.Identifier == parsedId);

                    aItem.StockLevel = int.Parse(txtStockLevel.Text);

                    ctx.SaveChanges();
                }

                MessageBox.Show("Stock Level Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");
            }

        }

        private void txtSave_Click(object sender, EventArgs e)
        {

            Update_Stock();
            Save_StockUpdate();
            txtItemName.Clear();
            txtAdd.Text = "0";
            txtDeduct.Text = "0";
            txtStockBal.Text = "0";
            panel1.Visible = false;

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}


