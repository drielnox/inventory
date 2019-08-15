using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms
{
    public partial class frmSuppliersRecord : Form
    {
        public frmSuppliersRecord()
        {
            InitializeComponent();
        }
        
        // connect to database on formload
        private void frmSuppliersRecord_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("No Supplier search requested");
                }
                else
                {
                    var suppliers = new List<SupplierViewModel>();

                    using (var ctx = new InventoryModel())
                    {
                        suppliers = ctx.Suppliers
                            .Where(x => x.Name.StartsWith(txtSearch.Text)
                                        || x.Email.StartsWith(txtSearch.Text)
                                        || x.Phone.StartsWith(txtSearch.Text)
                                        || x.ContactPerson.StartsWith(txtSearch.Text))
                            .Select(x => new SupplierViewModel
                            {
                                Identifier = x.Identifier,
                                Name = x.Name,
                                ContactPerson = x.ContactPerson,
                                Address = x.Address,
                                Phone = x.Phone,
                                Email = x.Email,
                            })
                            .ToList();
                    }
                    
                    bsSupplier.DataSource = suppliers;

                    txtSearch.Clear();
                    dataGridView1.Visible = true;
                    btnSelect.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers");  
            }
        }
        
        // a method to be called for loading details of selected drug from the seach result
        private void Load_SuppliersRecord()
        {
            try
            {
                var selectedSupplier = bsSupplier.Current as SupplierViewModel;
                
                if (selectedSupplier != null)
                {
                    txtSupId.Text = selectedSupplier.Identifier.ToString();
                    txtSupplierName.Text = selectedSupplier.Name;
                    txtContactPerson.Text = selectedSupplier.ContactPerson;
                    txtOfficeAddress.Text = selectedSupplier.Address;
                    txtEmail.Text = selectedSupplier.Email;
                    txtPhone.Text = selectedSupplier.Phone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }
        }

        // display data of selected record onto item record textboxes
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtSupId.Text = dr.Cells[0].Value.ToString();

                Load_SuppliersRecord();
                panel1.Visible = true;
                txtSave.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }
        }

        // update database with new data on form textboxes 
        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSupplier = bsSupplier.Current as SupplierViewModel;

                using (var ctx = new InventoryModel())
                {
                    var supplier = ctx.Suppliers.Single(x => x.Identifier == selectedSupplier.Identifier);

                    supplier.Name = txtSupplierName.Text;
                    supplier.Address = txtContactPerson.Text;
                    supplier.Address = txtOfficeAddress.Text;
                    supplier.Email = txtEmail.Text;
                    supplier.Phone = txtPhone.Text;

                    ctx.SaveChanges();
                }

                MessageBox.Show("Suppliers Record Updated Successfully");
                panel1.Visible = false;
                txtSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }
        }

        // close this module
        private void txtCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}

