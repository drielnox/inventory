using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Smart_Inventory_System
{
    public partial class Change_Pass : Form
    {
        public Change_Pass()
        {
            InitializeComponent();
        }

        // variable declarations 
        string connectionString;
        MySqlDataReader dr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataSet ds1, ds;

        private void Change_Pass_Load(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Change User Password"); //excep.GetType().ToString() 
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {

            string a = frmViewUsers.tb.Text;

            if (txtPassConfirm.Text == txtPassword.Text)
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE users SET password=@password WHERE username = '" + a + "' ;";

                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password changed successfully");
                this.Close();

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
            this.Close(); 
        }
    }
}
