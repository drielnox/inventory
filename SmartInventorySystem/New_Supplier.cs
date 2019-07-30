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
    public partial class frmNewSupplier : Form
    {
        public frmNewSupplier()
        {
            InitializeComponent();
        }

        // variable declarations 
        string connectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
                
        //connect to database on form load event        
        private void frmNewSupplier_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "New Drug / Item");  
            }
        }

        // save form data into database 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO suppliers(supplier_name,contact_person,office_address,email,phone,date_created,user_created)VALUES(@supplier_name,@contact_person,@office_address,@email,@phone,@date_created,@user_created)";
                                               
                cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName.Text);                
                cmd.Parameters.AddWithValue("@contact_person", txtContactPerson.Text);
                cmd.Parameters.AddWithValue("@office_address", txtOfficeAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@date_created", txtDateCreated.Text);
                cmd.Parameters.AddWithValue("@user_created", txtUserCreated.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("New Supplier Successfully Added to System");
                //this.Close(); 
                                
                txtSupplierName.Text = "";
                txtContactPerson.Text = "";
                txtOfficeAddress.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Supplier");  
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
