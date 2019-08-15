using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnItemsRecord_Click(object sender, EventArgs e)
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

        private void btnUpdateStock_Click(object sender, EventArgs e)
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

        private void btnDispense_Click(object sender, EventArgs e)
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

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNew_Item new_item = new frmNew_Item();
                new_item.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewSupplier new_supp = new frmNewSupplier();
                new_supp.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Supplier");
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuppliersRecord supp_record = new frmSuppliersRecord();
                supp_record.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Suppliers");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewUser new_user = new frmNewUser();
                new_user.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewUsers view_user = new frmViewUsers();
                view_user.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmStockSheet stock = new frmStockSheet();
                stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock");
            }
        }

        private void btnDispenseSheet_Click(object sender, EventArgs e)
        {
            try
            {
                frmDispenseSheet dispense = new frmDispenseSheet();
                dispense.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dispense");
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            txtToday.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtExpiryAlert.Text = DateTime.Now.AddDays(90).ToString("yyyy/MM/dd");

            LoadExpiry();

        }


        private void LoadExpiry()
        {
            var expiredItems = new List<ItemExpiredViewModel>();
            var parseExpiryDate = DateTime.Parse(txtExpiryAlert.Text);

            try
            {
                using (var ctx = new InventoryModel())
                {
                    expiredItems = ctx.Items
                        .Where(x => x.Expire <= parseExpiryDate)
                        .Select(x => new ItemExpiredViewModel { Name = x.Name, Expire = x.CreatedAt })
                        .ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bsExpiredItems.DataSource = expiredItems;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

