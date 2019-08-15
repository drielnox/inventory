using System;
using System.Windows.Forms;
using SmartInventorySystem.Model;

namespace SmartInventorySystem
{
    public partial class frmNew_Item : Form
    {
        public frmNew_Item()
        {
            InitializeComponent();
        }

        //connect to database on form load event
        private void frmNew_Item_Load(object sender, EventArgs e)
        {
        }

        // load the Items Record module
        private void itemsRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmItems_Record items = new frmItems_Record();
                items.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        // load the stock record update module
        private void stockRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmStock_Update stock = new frmStock_Update();
                stock.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        // load the dispense module
        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDispense dispense = new frmDispense();
                dispense.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        // save form data into database 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newItem = new Item
                {
                    Code = txtCode.Text,
                    Name = txtItemName.Text,
                    Description = txtDesc.Text,
                    AlternativeName = txtAlterName.Text,
                    Manufacturer = txtManuf.Text,
                    MajorSupplier = txtMajSupplier.Text,
                    PackQuantity = txtPackSize.Text,
                    PackDescription = txtPackDesc.Text,
                    AlternativeItem = txtAlterItem.Text,
                    StandardIssueQuantity = txtIssQuantity.Text,
                    EconomicOrderQuantity = txtEOQ.Text,
                };

                using (var ctx = new InventoryModel())
                {
                    ctx.Items.Add(newItem);

                    ctx.SaveChanges();
                }
                
                MessageBox.Show("New Drug/Item Successfully Added to System");
                
                txtCode.Text = "";
                txtItemName.Text = "";
                txtDesc.Text = "";
                txtAlterName.Text = "";
                txtManuf.Text = "";
                txtMajSupplier.Text = "";
                txtPackSize.Text = "";
                txtPackSize.Text = "";
                txtPackDesc.Text = "";
                txtAlterItem.Text = "";
                txtIssQuantity.Text = "";
                txtEOQ.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
