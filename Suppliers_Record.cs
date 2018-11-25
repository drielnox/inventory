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
    public partial class frmSuppliersRecord : Form
    {
        public frmSuppliersRecord()
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
        private void frmSuppliersRecord_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Update Suppliers");  
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text == "")
                {
                    MessageBox.Show("No Supplier search requested");
                }

                else
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Select * from suppliers where supplier_name like '" + txtSearch.Text + "%" + "' or email like '" + txtSearch.Text + "%" + "' or phone like '" + txtSearch.Text + "%" + "' or contact_person like '" + txtSearch.Text + "%" + "'  ";
                    adap = new MySqlDataAdapter(cmd);
                    ds1 = new DataSet();
                    adap.Fill(ds1, "suppliers");
                    dataGridView1.DataSource = ds1.Tables[0];
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                    txtSearch.Clear();
                    dataGridView1.Visible = true;
                    btnSelect.Visible = true;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers");  
            }
        }

        
        // a method to be called for loading details of selected drug from the seach result
        private void Load_SuppliersRecord()
        {
            try
            {

                string a = txtSupId.Text;

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from suppliers where supplier_id = '" + a + "' ";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtSupId.Text = Convert.ToString(dr[0]);
                    txtSupplierName.Text = Convert.ToString(dr[1]);
                    txtContactPerson.Text = Convert.ToString(dr[2]);
                    txtOfficeAddress.Text = Convert.ToString(dr[3]);


                    txtEmail.Text = Convert.ToString(dr[4]);
                    txtPhone.Text = Convert.ToString(dr[5]);
                    
                    dr.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }
        }

        // display data of selected record onto item record textboxes
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtSupId.Text = dr.Cells[0].Value.ToString();

                Load_SuppliersRecord();
                panel1.Visible = true;
                txtSave.Visible = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }
        }

        // update database with new data on form textboxes 
        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                          
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE suppliers SET supplier_name=@supplier_name, contact_person=@contact_person, office_address=@office_address, email=@email, phone=@phone, date_amended=@date_amended, user_amended=@user_amended WHERE supplier_id= '" + txtSupId.Text + "' ;";

                cmd.Parameters.AddWithValue("@supplier_name", txtSupplierName.Text);
                cmd.Parameters.AddWithValue("@contact_person", txtContactPerson.Text);
                cmd.Parameters.AddWithValue("@office_address", txtOfficeAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@date_amended", txtDateAmend.Text);
                cmd.Parameters.AddWithValue("@user_amended", txtUserAmend.Text);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Suppliers Record Updated Successfully");
                panel1.Visible = false;
                txtSave.Visible = false;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Suppliers Record");  
            }

        }

        // close this module
        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}

