﻿// <copyright file="MyApplicationContext.cs" company="Open Source">
// Copyright (c) Open Source. All rights reserved.
// </copyright>

using System;
using System.Windows.Forms;

namespace SmartInventorySystem.WinForms
{
    class MyApplicationContext : ApplicationContext
    {
        private Form _mainForm;

        public MyApplicationContext()
        {
            try
            {
                var login = new LoginPopup();
                login.ShowDialog();
                if ((bool)login.Tag)
                {
                    login.Close();

                    _mainForm = new DashboardForm();
                    _mainForm.FormClosed += _mainForm_FormClosed;
                    _mainForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to show the application." +
                                "The error is:" + ex.ToString());
                
                ExitThread();
            }
        }

        private void _mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitThread();
        }
    }
}
