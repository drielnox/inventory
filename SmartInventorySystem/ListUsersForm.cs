using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        // variable declarations 
        public static TextBox tb;
        
        private void View_Users_Load(object sender, EventArgs e)
        {
            try
            {
                tb = txtpid2;
                
                Load_Users();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "View Users Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Users()
        {
            var users = new List<ViewUserViewModel>();

            try
            {
                using (var ctx = new InventoryModel())
                {
                    users = ctx.Users
                        .Select(x => new ViewUserViewModel { FirstName = x.FirstName, LastName = x.LastName, UserName = x.UserName, Role = x.Role, Phone = x.Phone, Email = x.Email })
                        .ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "ViewUser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bsViewUser.DataSource = users;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtpid2.Text = dr.Cells[2].Value.ToString();
                ChangePassForm user_pass = new ChangePassForm();
                user_pass.ShowDialog();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
