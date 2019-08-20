using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.DataAccess;
using SmartInventorySystem.ViewModel.Forms.Grids;

namespace SmartInventorySystem.WinForms
{
    public partial class UpdateItemForm : Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }

        // connect to database on formload
        private void frmItems_Record_Load(object sender, EventArgs e)
        {
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
                    var items = new List<ItemRowViewModel>();
                    int parsedId;
                    int.TryParse(txtSearch.Text, out parsedId);

                    using (var ctx = new InventoryModel())
                    {
                        items = ctx.Items
                            .Where(x => x.Name.StartsWith(txtSearch.Text)
                                        || x.Code == txtSearch.Text
                                        || x.Identifier == parsedId)
                            .Select(x => new ItemRowViewModel
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
                                Expire = x.Expire
                            })
                            .ToList();
                    }

                    bsItem.DataSource = items;

                    txtSearch.Clear();
                    dataGridView1.Visible = true;
                    btnSelect.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");
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
                tabControl1.Visible = true;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");
            }

        }


        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try
            {
                var selectedItem = bsItem.Current as ItemRowViewModel;

                if (selectedItem != null)
                {
                    txtItemid.Text = selectedItem.Identifier.ToString();
                    txtCode.Text = selectedItem.Code;
                    txtItemName.Text = selectedItem.Name;
                    txtDesc.Text = selectedItem.Description;
                    txtAlterName.Text = selectedItem.AlternativeName;
                    txtManuf.Text = selectedItem.Manufacturer;
                    txtMajSupplier.Text = selectedItem.MajorSupplier;
                    txtPackSize.Text = selectedItem.PackQuantity;
                    txtPackDesc.Text = selectedItem.PackDescription;
                    txtIssQuantity.Text = selectedItem.StandardIssueQuantity;
                    txtAlterItem.Text = selectedItem.AlternativeItem;
                    txtEOQ.Text = selectedItem.EconomicOrderQuantity;
                    txtPurchase.Text = selectedItem.PurchasePrice.ToString();
                    txtMarkup.Text = selectedItem.MarkupPercent.ToString();
                    txtSelling.Text = selectedItem.SellingPrice.ToString();
                    txtStockLevel.Text = selectedItem.StockLevel.ToString();
                    txtMin.Text = selectedItem.MinimumLevel.ToString();
                    txtReorder.Text = selectedItem.ReOrderLevel.ToString();
                    txtMax.Text = selectedItem.MaximumLevel.ToString();
                    txtLead.Text = selectedItem.LeadDays.ToString();
                    txtExpiry.Text = selectedItem.Expire?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");
            }
        }

        // update database with new data on form textboxes 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPurchase.Text == "")
                {
                    txtPurchase.Text = "0.00";
                }

                else if (txtSelling.Text == "")
                {
                    txtSelling.Text = "0.00";
                }
                else if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }
                else if (txtMin.Text == "")
                {
                    txtMin.Text = "0";
                }
                else if (txtMax.Text == "")
                {
                    txtMax.Text = "0";
                }
                else if (txtMax.Text == "")
                {
                    txtMax.Text = "0";
                }
                else if (txtReorder.Text == "")
                {
                    txtReorder.Text = "0";
                }
                else if (txtLead.Text == "")
                {
                    txtLead.Text = "0";
                }

                using (var ctx = new InventoryModel())
                {
                    var id = int.Parse(txtItemid.Text);
                    var item = ctx.Items
                        .Single(x => x.Identifier == id);

                    item.Code = txtCode.Text;
                    item.Name = txtItemName.Text;
                    item.Description = txtDesc.Text;
                    item.Manufacturer = txtManuf.Text;
                    item.MajorSupplier = txtMajSupplier.Text;
                    item.PackQuantity = txtPackSize.Text;
                    item.PackDescription = txtPackDesc.Text;
                    item.AlternativeItem = txtAlterItem.Text;
                    item.StandardIssueQuantity = txtIssQuantity.Text;
                    item.EconomicOrderQuantity = txtEOQ.Text;
                    item.PurchasePrice = float.Parse(txtPurchase.Text);
                    item.MarkupPercent = float.Parse(txtMarkup.Text);
                    item.SellingPrice = float.Parse(txtSelling.Text);
                    item.StockLevel = int.Parse(txtStockLevel.Text);
                    item.MinimumLevel = int.Parse(txtMin.Text);
                    item.ReOrderLevel = int.Parse(txtReorder.Text);
                    item.MaximumLevel = int.Parse(txtMax.Text);
                    item.LeadDays = int.Parse(txtLead.Text);
                    item.Expire = DateTime.Parse(txtExpiry.Text);

                    ctx.SaveChanges();
                }

                MessageBox.Show("Drugs / Items Record Updated Successfully");
                tabControl1.Visible = false;
                btnUpdate.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtExpiry.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
        }
    }
}