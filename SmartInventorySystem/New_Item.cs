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
    public partial class frmNew_Item : Form
    {
        public frmNew_Item()
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
        private void frmNew_Item_Load(object sender, EventArgs e)
        {   
            try {
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



        // load the Items Record module
        private void itemsRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
            frmItems_Record items = new frmItems_Record();
            items.ShowDialog();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        // load the stock record update module
        private void stockRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try {
            frmStock_Update stock = new frmStock_Update();
            stock.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        }

        // load the dispense module
        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
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

        // save form data into database 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {

            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO items_record(item_code,item_name,description,alternative_name,manufacturer,major_supplier,pack_quantity,pack_description,alternative_item,standard_issue_qty,economic_order_qty,date_created)VALUES(@item_code,@item_name,@description,@alternative_name,@manufacturer,@major_supplier,@pack_quantity,@pack_description,@alternative_item,@standard_issue_qty,@economic_order_qty,@date_created)";
            cmd.Parameters.AddWithValue("@item_code", txtCode.Text);
            cmd.Parameters.AddWithValue("@item_name", txtItemName.Text);
            cmd.Parameters.AddWithValue("@description", txtDesc.Text);
            cmd.Parameters.AddWithValue("@alternative_name", txtAlterName.Text);
            cmd.Parameters.AddWithValue("@manufacturer", txtManuf.Text);
            cmd.Parameters.AddWithValue("@major_supplier", txtMajSupplier.Text);
            cmd.Parameters.AddWithValue("@pack_quantity", txtPackSize.Text);
            cmd.Parameters.AddWithValue("@pack_description", txtPackDesc.Text);
            cmd.Parameters.AddWithValue("@alternative_item", txtAlterItem.Text);
            cmd.Parameters.AddWithValue("@standard_issue_qty", txtIssQuantity.Text);
            cmd.Parameters.AddWithValue("@economic_order_qty", txtEOQ.Text);
            cmd.Parameters.AddWithValue("@date_created", txtDateCreated.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("New Drug/Item Successfully Added to System");
            //this.Close(); 

            txtCode.Text = "";
            txtItemName.Text = "";
            txtDesc.Text = "";
            txtAlterName.Text = "";
            txtManuf.Text = "";
            txtMajSupplier.Text = "";
            txtPackSize.Text = "";
            txtPackSize.Text = "";
            txtPackDesc.Text = "";
            txtAlterItem.Text = "";
            txtIssQuantity.Text = "";
            txtEOQ.Text = "";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item"); 
            }
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
    }
}
