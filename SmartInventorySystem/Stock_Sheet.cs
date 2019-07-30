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
    public partial class frmStockSheet : Form
    {
        public frmStockSheet()
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

        private void frmStockSheet_Load(object sender, EventArgs e)
        {
            try
            {                
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

                Load_StockSheet();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Stock Sheet");  
            }
        
        }

        private void Load_StockSheet()
        {
            try
            {

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select item_name, description, manufacturer, stock_level, reorder_level, major_supplier, purchase_price, selling_price from items_record";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
