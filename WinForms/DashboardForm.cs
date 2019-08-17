namespace SmartInventorySystem.WinForms
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using ViewModel;
    using DataAccess;

    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadExpiry();
            tsslDomainAndUser.Text = string.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
            tsslSoftwareVersion.Text = string.Format("{0}.{1}.{2}.{3}", Environment.Version.Major, Environment.Version.Minor, Environment.Version.Revision, Environment.Version.Build);
        }

        private void LoadExpiry()
        {
            var expiredItems = new List<ItemExpiredViewModel>();
            var parseExpiryDate = DateTime.Now.AddDays(90);

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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewItemForm new_item = new NewItemForm();
                new_item.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new UpdateItemForm();
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStockForm stock = new UpdateStockForm();
                stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListStockForm stock = new ListStockForm();
                stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock");
            }
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ListDispenseForm dispense = new ListDispenseForm();
                dispense.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dispense");
            }
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                NewSupplierForm new_supp = new NewSupplierForm();
                new_supp.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Supplier");
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

