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
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        // connect to database
        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login"); //excep.GetType().ToString() 
            }



        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { 
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from users where username = '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "' ";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Login Granted");
                dashboard dashpage = new dashboard();
                dashpage.Show();

                this.Visible = false;

                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login Details! Try Again");
                txtUsername.Clear();
                txtPassword.Clear();
                con.Close();
                con.Open();

            }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login"); //excep.GetType().ToString() 
            }
           
        }

        // end the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}