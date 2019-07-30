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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnItemsRecord_Click(object sender, EventArgs e)
        {
            try
            {
                frmItems_Record items = new frmItems_Record();
                items.ShowDialog();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                frmStock_Update stock = new frmStock_Update();
                stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            try {
            frmDispense dispense = new frmDispense();
            dispense.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            try {
                frmNew_Item new_item = new frmNew_Item();            
            new_item.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            try {
                frmNewSupplier new_supp = new frmNewSupplier();            
            new_supp.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Supplier"); 
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuppliersRecord supp_record = new frmSuppliersRecord();
                supp_record.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Suppliers"); 
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewUsers view_user = new frmViewUsers();
                view_user.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users"); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmStockSheet stock = new frmStockSheet();
                stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock"); 
            }
        }

        private void btnDispenseSheet_Click(object sender, EventArgs e)
        {
            try
            {
                frmDispenseSheet dispense = new frmDispenseSheet();
                dispense.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dispense"); 
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            txtToday.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtExpiryAlert.Text = DateTime.Now.AddDays(90).ToString("yyyy/MM/dd");

            LoadExpiry();
            
        }


        private void LoadExpiry()
        {
            try
            {

                // variable declarations         
                string connectionString;
               // MySqlDataReader dr;
                MySqlConnection con;
                //MySqlCommand cmd;
                MySqlDataAdapter adap;
                DataSet ds1;

                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select item_name, expiry_date from items_record where expiry_date <= '" + txtExpiryAlert.Text + "'";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "stock");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
    }
            
    }

