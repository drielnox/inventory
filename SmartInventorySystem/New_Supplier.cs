using System;
using System.Windows.Forms;
using SmartInventorySystem.Model;

namespace SmartInventorySystem
{
    public partial class frmNewSupplier : Form
    {
        public frmNewSupplier()
        {
            InitializeComponent();
        }
       
        //connect to database on form load event        
        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
        }

        // save form data into database 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newSupplier = new Supplier
                {
                    Name = txtSupplierName.Text,
                    ContactPerson = txtContactPerson.Text,
                    Address = txtOfficeAddress.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    CreatedBy = txtUserCreated.Text
                };

                using (var ctx = new InventoryModel())
                {
                    ctx.Suppliers.Add(newSupplier);

                    ctx.SaveChanges();
                }
                MessageBox.Show("New Supplier Successfully Added to System");
                                
                txtSupplierName.Text = "";
                txtContactPerson.Text = "";
                txtOfficeAddress.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Supplier");  
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
