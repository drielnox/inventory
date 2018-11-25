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
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        // variable declarations 
        public static TextBox tb;

        string connectionString;
        MySqlDataReader dr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataSet ds1, ds;

        private void View_Users_Load(object sender, EventArgs e)
        {
            try
            {
                tb = txtpid2;

                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

                Load_Users();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Users Record");  
            }
            
        }

        private void Load_Users()
        {
            try
            {

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select first_name, last_name, Username, user_role, phone, email from users";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "users");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }

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
                Change_Pass user_pass = new Change_Pass();
                user_pass.ShowDialog();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users");  
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
