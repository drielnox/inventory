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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        // variable declarations 
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

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
                
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO users(first_name, last_name, Username, Password, user_role, email, phone)VALUES(@first_name, @last_name, @username, @password, @user_role, @email, @phone)";
            cmd.Parameters.AddWithValue("@first_name", txtFName.Text);
            cmd.Parameters.AddWithValue("@last_name", txtLName.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@user_role", txtProfile.Text);
                
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                
            cmd.ExecuteNonQuery();

            MessageBox.Show("New User Created");
            this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New User");  
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

