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
    public partial class frmStock_Update : Form
    {
        public frmStock_Update()
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

        private void frmStock_Update_Load(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

                txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }

        private void txtStockLevel_Leave(object sender, EventArgs e)
        {
            try {
            int level, add, deduct, balance;
            level = int.Parse(txtStockLevel.Text);
            add = int.Parse(txtAdd.Text);
            deduct = int.Parse(txtDeduct.Text);
            balance = (level + add) - deduct;
            txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }

        private void txtAdd_Leave(object sender, EventArgs e)
        {
            try {
            int level, add, deduct, balance;
            level = int.Parse(txtStockLevel.Text);
            add = int.Parse(txtAdd.Text);
            deduct = int.Parse(txtDeduct.Text);
            balance = (level + add) - deduct;
            txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }

        private void txtDeduct_Leave(object sender, EventArgs e)
        {
            try {
            int level, add, deduct, balance;
            level = int.Parse(txtStockLevel.Text);
            add = int.Parse(txtAdd.Text);
            deduct = int.Parse(txtDeduct.Text);
            balance = (level + add) - deduct;
            txtStockBal.Text = balance.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }

        // search for drug or item using search box
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {

            if (txtSearch.Text == "")
            {
                MessageBox.Show("No item or drug search requested");
            }
           
            else
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from items_record where item_name like '" + txtSearch.Text + "%" + "' or item_code = '" + txtSearch.Text + "' or item_id = '" + txtSearch.Text + "'  ";
                adap = new MySqlDataAdapter(cmd);
                ds1 = new DataSet();
                adap.Fill(ds1, "items");
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                txtSearch.Clear();
                dataGridView1.Visible = true;
                btnSelect.Visible = true; 
                               
            }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }

        }

        // display data of selected record onto item record textboxes
        private void btnSelect_Click(object sender, EventArgs e)
        {            
            try {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtItemid.Text = dr.Cells[0].Value.ToString();
            
            Load_ItemsRecord();
            panel1.Visible = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }


        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try
            {

                string a = txtItemid.Text;

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from items_record where item_id = '" + a + "' ";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtItemid.Text = Convert.ToString(dr[0]);
                    txtCode.Text = Convert.ToString(dr[1]);
                    txtItemName.Text = Convert.ToString(dr[2]);

                    txtStockLevel.Text = Convert.ToString(dr[15]);
                                        
                    dr.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }
        }


        // save stock adjustment data 
        private void Save_StockUpdate()
        {
            try
            {
                if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }
                else if (txtAdd.Text == "")
                {
                    txtAdd.Text = "0";
                }
                else if (txtDeduct.Text == "")
                {
                    txtDeduct.Text = "0";
                }
                else if (txtStockBal.Text == "")
                {
                    txtStockBal.Text = "0";
                }

                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO stock_update(item_id,item_code,item_name,stock_level,qty_added,qty_deducted,stock_balance,date_updated,user_updated)VALUES(@item_id,@item_code,@item_name,@stock_level,@qty_added,@qty_deducted,@stock_balance,@date_updated,@user_updated)";

                cmd.Parameters.AddWithValue("@item_id", txtItemid.Text);
                cmd.Parameters.AddWithValue("@item_code", txtCode.Text);
                cmd.Parameters.AddWithValue("@item_name", txtItemName.Text);

                cmd.Parameters.AddWithValue("@stock_level", txtStockLevel.Text);
                cmd.Parameters.AddWithValue("@qty_added", txtAdd.Text);
                cmd.Parameters.AddWithValue("@qty_deducted", txtDeduct.Text);
                cmd.Parameters.AddWithValue("@stock_balance", txtStockBal.Text);
                cmd.Parameters.AddWithValue("@date_updated", txtDateAmend.Text);

                cmd.Parameters.AddWithValue("@user_updated", txtUserAmend.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("New Stock Level successfully saved");
                //this.Close(); 

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Drug / Item");  
            }

        }


        // update item records with new stock level 
        private void Update_Stock()
        {
            try
            {
                if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }
                txtStockLevel.Text = txtStockBal.Text;
                
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE items_record SET stock_level=@stock_level, date_amended=@date_amended, user_amended=@user_amended WHERE item_id= '" + txtItemid.Text + "' ;";

                cmd.Parameters.AddWithValue("@stock_level", int.Parse(txtStockLevel.Text));

                cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);
                cmd.Parameters.AddWithValue("@user_amended", txtUserAmend.Text);


                cmd.ExecuteNonQuery();

                //MessageBox.Show("Stock Level Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
            }

        }

        private void txtSave_Click(object sender, EventArgs e)
        {

            Update_Stock();
            Save_StockUpdate();
            txtItemName.Clear();
            txtAdd.Text = "0";
            txtDeduct.Text = "0";
            txtStockBal.Text = "0";
            panel1.Visible = false; 

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
    }
}


