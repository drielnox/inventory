using System;
using System.Windows.Forms;
using SmartInventorySystem.Model;
using SmartInventorySystem.DataAccess;

namespace SmartInventorySystem.WinForms
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            try
            {
                txtDateCreated.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New User");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User
                {
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = txtProfile.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                };

                using (var ctx = new InventoryModel())
                {
                    ctx.Users.Add(newUser);

                    ctx.SaveChanges();
                }
                
                MessageBox.Show("New User Created");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New User");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

