using SmartInventorySystem.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartInventorySystem.WinForms
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void Change_Pass_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string a = frmViewUsers.tb.Text;

                if (txtPassConfirm.Text == txtPassword.Text)
                {
                    using (var ctx = new InventoryModel())
                    {
                        var user = ctx.Users
                            .SingleOrDefault(x => x.UserName == a);

                        user.Password = txtPassword.Text;

                        ctx.SaveChanges();
                    }

                    MessageBox.Show("Password changed successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("Please confirm Password and Confirm Pasword fields match");
                    txtPassword.Text = "";
                    txtPassConfirm.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change User Password"); //excep.GetType().ToString() 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
