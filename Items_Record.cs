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
    public partial class frmItems_Record : Form
    {
        public frmItems_Record()
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

        // connect to database on formload
        private void frmItems_Record_Load(object sender, EventArgs e)
        {
            try {
            connectionString = "Server=127.0.0.1;Database=smart_inventory;Uid=pharm;Pwd=password;";
            con = new MySqlConnection(connectionString);
            con.Open();

            txtDateAmend.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");  
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
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");  
            }
        }

        // display data of selected record onto item record textboxes
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtItemid.Text = dr.Cells[0].Value.ToString();

            Load_ItemsRecord();
            tabControl1.Visible = true;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");  
            }

        }


        // a method to be called for loading details of selected drug from the seach result
        private void Load_ItemsRecord()
        {
            try {

            string a = txtItemid.Text ;

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from items_record where item_id = '" + a + "' ";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtItemid.Text = Convert.ToString(dr[0]);
                txtCode.Text = Convert.ToString(dr[1]);
                txtItemName.Text = Convert.ToString(dr[2]);
                txtDesc.Text = Convert.ToString(dr[3]);
                txtAlterName.Text = Convert.ToString(dr[4]);
                txtManuf.Text = Convert.ToString(dr[5]);
                txtMajSupplier.Text = Convert.ToString(dr[6]);
                txtPackSize.Text = Convert.ToString(dr[7]);
                txtPackDesc.Text = Convert.ToString(dr[8]);
                txtIssQuantity.Text = Convert.ToString(dr[9]);
                txtAlterItem.Text = Convert.ToString(dr[10]);
                txtEOQ.Text = Convert.ToString(dr[11]);
                txtPurchase.Text = Convert.ToString(dr[12]);
                //txtMarkup.Text = Convert.ToString(dr[13]);
                txtSelling.Text = Convert.ToString(dr[14]);
                txtStockLevel.Text = Convert.ToString(dr[15]);
                txtMin.Text = Convert.ToString(dr[16]);
                txtReorder.Text = Convert.ToString(dr[17]);                
                txtMax.Text = Convert.ToString(dr[18]);
                txtLead.Text = Convert.ToString(dr[19]);
                txtExpiry.Text = Convert.ToString(dr[24]);
         
                dr.Close();

            }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Drugs / Items Record");  
            }
        }

        // update database with new data on form textboxes 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPurchase.Text == "")
                {
                    txtPurchase.Text = "0.00";
                }
                
                else if (txtSelling.Text == "")
                {
                    txtSelling.Text = "0.00";
                }
                else if (txtStockLevel.Text == "")
                {
                    txtStockLevel.Text = "0";
                }
                else if (txtMin.Text == "")
                {
                    txtMin.Text = "0";
                }
                else if (txtMax.Text == "")
                {
                    txtMax.Text = "0";
                }
                else if (txtMax.Text == "")
                {
                    txtMax.Text = "0";
                }
                else if (txtReorder.Text == "")
                {
                    txtReorder.Text = "0";
                }
                else if (txtLead.Text == "")
                {
                    txtLead.Text = "0";
                }

                //Markup_value();

                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE items_record SET item_code=@item_code, item_name=@item_name, description=@description, alternative_name=@alternative_name, manufacturer=@manufacturer, major_supplier=@major_supplier, pack_quantity=@pack_quantity, pack_description=@pack_description, alternative_item=@alternative_item, standard_issue_qty=@standard_issue_qty, economic_order_qty=@economic_order_qty, purchase_price=@purchase_price, selling_price=@selling_price, stock_level=@stock_level, minimum_level=@minimum_level, reorder_level=@reorder_level, maximum_level=@maximum_level, lead_days=@lead_days, date_amended=@date_amended, user_amended=@user_amended, expiry_date=@expiry_date WHERE item_id= '" + txtItemid.Text + "' ;";
                              
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
                    cmd.Parameters.AddWithValue("@purchase_price", float.Parse(txtPurchase.Text));
                    //cmd.Parameters.AddWithValue("@markup_percent", float.Parse(txtMarkup.Text));
                    cmd.Parameters.AddWithValue("@selling_price", float.Parse(txtSelling.Text));
                    cmd.Parameters.AddWithValue("@stock_level", int.Parse(txtStockLevel.Text));                
                    cmd.Parameters.AddWithValue("@minimum_level", int.Parse(txtMin.Text));
                    cmd.Parameters.AddWithValue("@reorder_level", int.Parse(txtReorder.Text));
                    cmd.Parameters.AddWithValue("@maximum_level", int.Parse(txtMax.Text));
                    cmd.Parameters.AddWithValue("@lead_days", int.Parse(txtLead.Text));
                    cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);
                    cmd.Parameters.AddWithValue("@user_amended", txtUserAmend.Text);

                    cmd.Parameters.AddWithValue("@expiry_date", txtExpiry.Text);
                    
                    cmd.ExecuteNonQuery();

                    
                
                        MessageBox.Show("Drugs / Items Record Updated Successfully");
                        tabControl1.Visible = false;
                        btnUpdate.Visible = false;
                        btnCancel.Visible = false; 
                }
                        
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "Update Drugs / Items Record");  
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }
    
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtExpiry.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
        }
        }
    
        }
    


