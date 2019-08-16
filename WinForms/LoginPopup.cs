using SmartInventorySystem.DataAccess;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartInventorySystem.WinForms
{
    public partial class LoginPopup : Form
    {
        public LoginPopup()
        {
            InitializeComponent();
        }

        // connect to database
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool existUser = false;

            try
            {
                using (var ctx = new InventoryModel())
                {
                    existUser = ctx.Users
                        .Where(x => x.UserName == txtUsername.Text)
                        .Where(x => x.Password == txtPassword.Text)
                        .Any();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (existUser)
            {
                MessageBox.Show(this, "Login Granted", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Invalid Login Details! Try Again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}