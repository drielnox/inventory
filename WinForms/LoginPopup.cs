// <copyright file="LoginPopup.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

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

            Tag = existUser;
        }

        private void LoginPopup_Load(object sender, EventArgs e)
        {
#if DEBUG
            txtUsername.Text = "irene";
            txtPassword.Text = "irene";
#endif
        }
    }
}