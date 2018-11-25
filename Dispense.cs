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
    public partial class frmDispense : Form
    {
        public frmDispense()
        {
            InitializeComponent();
        }

        // variable declarations 
        string connectionString;
        MySqlDataReader dr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap, adap1;
        DataSet ds1, ds, ds2;

        private void frmDispense_Load(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
                con = new MySqlConnection(connectionString);
                con.Open();

                txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                txtgroupDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

                generateRandom();
                txtSearch.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }
        }
                
        private void UpdateQty_Amt()
        {
            try
            {

                int level, deduct, balance;
                float unit, amountSub;
                level = int.Parse(txtStockLevel.Text);
                deduct = int.Parse(txtDispenseQty.Text);

                if (level < 1)
                {
                    MessageBox.Show("Stock level of this item is Empty. Please refill stock before dispensing");
                    //txtDispenseQty.Text = "0";
                    //txtAmountSub.Text = "0";
                    //txtStockLevel.Focus();
                }
                else if (deduct > level)
                {
                    MessageBox.Show("Stock level is lower than dispense quantity. Please refill stock or dispense a lower quantity value");
                    //txtDispenseQty.Text = "0";
                    //txtStockBal.Text = txtStockLevel.Text;
                    //txtStockLevel.Focus();
                }

                else
                {
                    balance = level - deduct;
                    txtStockBal.Text = balance.ToString();

                    unit = float.Parse(txtUnitPrice.Text);
                    amountSub = deduct * unit;
                    txtAmountSub.Text = amountSub.ToString();

                    //txtAmountSub.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
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
                panel3.Visible = true;
                               
            }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
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
                    txtUnitPrice.Text = Convert.ToString(dr[14]);
                    txtStockLevel.Text = Convert.ToString(dr[15]);

                    dr.Close();

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
            panel3.Visible = false; 

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Update");  
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

        // summary log of single item dispensary 
        private void Summary_Dispensary()
        {
            try
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }                
                else if (txtVat.Text == "")
                {
                    txtVat.Text = "0.00";
                }

                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO dispense_summary(group_id,group_date,sub_amount,discount,vat,total,date_dispensed,user_dispensed)VALUES(@group_id,@group_date,@sub_amount,@discount,@vat,@total,@date_dispensed,@user_dispensed)";

                cmd.Parameters.AddWithValue("@group_id", txtRandom.Text);
                cmd.Parameters.AddWithValue("@group_date", txtgroupDate.Text);
                cmd.Parameters.AddWithValue("@sub_amount", float.Parse(txtAmountTotal.Text));
                cmd.Parameters.AddWithValue("@discount", float.Parse(txtDiscount.Text));
                cmd.Parameters.AddWithValue("@vat", float.Parse(txtVat.Text));
                cmd.Parameters.AddWithValue("@total", float.Parse(txtTotalFinal.Text));
                cmd.Parameters.AddWithValue("@date_dispensed", txtDateAmend.Text);
                cmd.Parameters.AddWithValue("@user_dispensed", txtUserAmend.Text);
                                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item successfully dispensed");
                //this.Close(); 
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }

        }


        // save single item dispensary 
        private void Save_Dispensary()
        {
            try
            {
            int level, qty, bal;
            level = int.Parse(txtStockLevel.Text);
            qty = int.Parse(txtDispenseQty.Text);
            bal = int.Parse(txtStockBal.Text);
            bal = level - qty;

            txtStockBal.Text = bal.ToString(); 
                
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO dispense(item_id,group_id,group_date,item_code,item_name,stock_level,unit_price,dispense_quantity,sub_amount,stock_balance,date_dispensed,user_dispensed)VALUES(@item_id,@group_id,@group_date,@item_code,@item_name,@stock_level,@unit_price,@dispense_quantity,@sub_amount,@stock_balance,@date_dispensed,@user_dispensed)";

                cmd.Parameters.AddWithValue("@item_id", txtItemid.Text);
                cmd.Parameters.AddWithValue("@group_id", txtRandom.Text);
                cmd.Parameters.AddWithValue("@group_date", txtgroupDate.Text);                               
                cmd.Parameters.AddWithValue("@item_code", txtCode.Text);
                cmd.Parameters.AddWithValue("@item_name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@stock_level", int.Parse(txtStockLevel.Text));
                cmd.Parameters.AddWithValue("@unit_price", float.Parse(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@dispense_quantity", int.Parse(txtDispenseQty.Text));
                cmd.Parameters.AddWithValue("@sub_amount", float.Parse(txtAmountSub.Text));
                cmd.Parameters.AddWithValue("@stock_balance", int.Parse(txtStockBal.Text));
                cmd.Parameters.AddWithValue("@date_dispensed", txtDateAmend.Text);
                cmd.Parameters.AddWithValue("@user_dispensed", txtUserAmend.Text);

                cmd.ExecuteNonQuery();

           //     MessageBox.Show("Item successfully dispensed");
                //this.Close(); 


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }

        }

        //calculate the total price for all items dispense (including vat and discount)
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //UpdateQty_Amt();
            //Update_Stock();            
            //Save_Dispensary();
            //dispense_sheet();
            //CalcTotal_Amount();

            txtItemid.Clear();
            txtDspid.Clear();
            txtCode.Clear();
            txtItemName.Clear();
            txtStockLevel.Clear();
            txtStockBal.Clear();
            txtUnitPrice.Clear();
            txtDispenseQty.Clear();
            txtAmountSub.Clear();

            panel2.Visible = true;
            panel1.Visible = false;
            btnComputeTotal.Enabled = true;
            btnSave.Enabled = true;
            txtSearch.Focus();
        }

        // display selected item to be dispensed into a grid sheet
        private void dispense_sheet()
    {
        try {
            
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select item_name, dispense_quantity, sub_amount from dispense where group_id = '" + txtRandom.Text + "' && group_date = '" + txtgroupDate.Text  + "'  ";
                adap1 = new MySqlDataAdapter(cmd);
                ds2 = new DataSet();
                adap1.Fill(ds2, "items");
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                //txtSearch.Clear();
                              
            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }
    }

        private void generateRandom()
        {
            // generate a random number between the specified range
            try {
            Random dispGroup = new Random();            
            int num = dispGroup.Next(0, 100000);
            txtRandom.Text = num.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }
        }

        private void CalcTotal_Amount()
        {
            try { 
            float subAmt, totalAmount;
             subAmt= float.Parse(txtAmountSub.Text);
             totalAmount = float.Parse(txtAmountTotal.Text);
             totalAmount = totalAmount + subAmt;

            txtAmountTotal.Text = totalAmount.ToString() ;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            UpdateQty_Amt();
            Update_Stock();            
            Save_Dispensary();
            dispense_sheet();
            CalcTotal_Amount();

            txtItemid.Clear();
            txtDspid.Clear();
            txtCode.Clear();
            txtItemName.Clear();
            txtStockLevel.Clear();
            txtStockBal.Clear();
            txtUnitPrice.Clear();
            txtDispenseQty.Clear();
            txtAmountSub.Clear();

            panel2.Visible = true;
            txtSearch.Focus();
        }

  


        // save outcome of dispensary action (completed or cancelled) 
        private void Dispensary_Outcome()
        {
            try
            {
                txtdispStatus.Text = "YES";

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE dispense SET dispense_completed=@dispense_completed WHERE group_id = '" + txtRandom.Text + "' && group_date = '" + txtgroupDate.Text + "' ;";

                cmd.Parameters.AddWithValue("@dispense_completed", (txtdispStatus.Text));

                cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);
                cmd.Parameters.AddWithValue("@user_amended", txtUserAmend.Text);
                
                cmd.ExecuteNonQuery();
                
                //MessageBox.Show("Stock Level Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispansary");  
            }

        }

        private void btnComputeTotal_Click_1(object sender, EventArgs e)
        {
            try
            {

                float amountSub1, discount, discounted, vat, vatAmount, total;
                amountSub1 = float.Parse(txtAmountTotal.Text);
                discount = float.Parse(txtDiscount.Text);
                vat = float.Parse(txtVat.Text);
                discounted = amountSub1 - discount;
                vatAmount = vat / 100 * discounted;
                //total = float.Parse(txtTotalFinal.Text + ".00");

                total = discounted + vatAmount;
                txtTotalFinal.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dispense Item");  
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            Summary_Dispensary();
            Dispensary_Outcome();
            panel2.Visible = false;
            
            txtAmountTotal.Clear();
            txtDiscount.Clear();
            txtVat.Clear();
            txtTotalFinal.Clear();

            this.Close();
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        }
            
    }

