using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms
{
    partial class DispenseItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockBal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDispenseQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdispStatus = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bsDispenseSheet = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgroupDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDspid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.identifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardIssueQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economicOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtUserAmend = new System.Windows.Forms.TextBox();
            this.txtDateAmend = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispenseSheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(165, 274);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 120;
            this.txtCancel.Text = "Close";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(65, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Stock Balance";
            this.label4.Visible = false;
            // 
            // txtStockBal
            // 
            this.txtStockBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockBal.Location = new System.Drawing.Point(333, 75);
            this.txtStockBal.Name = "txtStockBal";
            this.txtStockBal.ReadOnly = true;
            this.txtStockBal.Size = new System.Drawing.Size(52, 20);
            this.txtStockBal.TabIndex = 117;
            this.txtStockBal.Text = "0";
            this.txtStockBal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Quantity to Dispense";
            // 
            // txtDispenseQty
            // 
            this.txtDispenseQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDispenseQty.Location = new System.Drawing.Point(124, 137);
            this.txtDispenseQty.Name = "txtDispenseQty";
            this.txtDispenseQty.Size = new System.Drawing.Size(120, 20);
            this.txtDispenseQty.TabIndex = 115;
            this.txtDispenseQty.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Unit Price (N)";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(124, 105);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.txtUnitPrice.TabIndex = 113;
            this.txtUnitPrice.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 112;
            this.label15.Text = "Stock Level";
            this.label15.Visible = false;
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockLevel.Location = new System.Drawing.Point(124, 75);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.ReadOnly = true;
            this.txtStockLevel.Size = new System.Drawing.Size(120, 20);
            this.txtStockLevel.TabIndex = 111;
            this.txtStockLevel.Text = "0";
            this.txtStockLevel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(280, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 110;
            this.label12.Text = "DISPENSE ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(124, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Item ID";
            this.label1.Visible = false;
            // 
            // txtItemid
            // 
            this.txtItemid.BackColor = System.Drawing.Color.White;
            this.txtItemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemid.Location = new System.Drawing.Point(362, 11);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(26, 20);
            this.txtItemid.TabIndex = 106;
            this.txtItemid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "Amount (N)";
            this.label5.Visible = false;
            // 
            // txtAmountSub
            // 
            this.txtAmountSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountSub.Location = new System.Drawing.Point(124, 171);
            this.txtAmountSub.Name = "txtAmountSub";
            this.txtAmountSub.Size = new System.Drawing.Size(120, 20);
            this.txtAmountSub.TabIndex = 121;
            this.txtAmountSub.Text = "0";
            this.txtAmountSub.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "VAT (%)";
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Location = new System.Drawing.Point(119, 187);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(60, 20);
            this.txtVat.TabIndex = 123;
            this.txtVat.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 126;
            this.label7.Text = "Sub Total Amount (N)";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountTotal.Location = new System.Drawing.Point(119, 128);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.ReadOnly = true;
            this.txtAmountTotal.Size = new System.Drawing.Size(121, 20);
            this.txtAmountTotal.TabIndex = 125;
            this.txtAmountTotal.Text = "0";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(3, 277);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 23);
            this.btnAddItem.TabIndex = 128;
            this.btnAddItem.Text = "Add to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(119, 277);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(110, 23);
            this.btnCompute.TabIndex = 129;
            this.btnCompute.Text = "Checkout >>";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnComputeTotal);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtTotalFinal);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtdispStatus);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAmountTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtVat);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtCancel);
            this.panel2.Location = new System.Drawing.Point(427, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 303);
            this.panel2.TabIndex = 130;
            this.panel2.Visible = false;
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Enabled = false;
            this.btnComputeTotal.Location = new System.Drawing.Point(119, 240);
            this.btnComputeTotal.Name = "btnComputeTotal";
            this.btnComputeTotal.Size = new System.Drawing.Size(114, 23);
            this.btnComputeTotal.TabIndex = 144;
            this.btnComputeTotal.Text = "Compute Total";
            this.btnComputeTotal.UseVisualStyleBackColor = true;
            this.btnComputeTotal.Click += new System.EventHandler(this.btnComputeTotal_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "Discount (N)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(119, 155);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 142;
            this.txtDiscount.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 141;
            this.label16.Text = "Total (N)";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFinal.Location = new System.Drawing.Point(119, 217);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFinal.TabIndex = 140;
            this.txtTotalFinal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(246, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Dispense Executed";
            this.label14.Visible = false;
            // 
            // txtdispStatus
            // 
            this.txtdispStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdispStatus.Location = new System.Drawing.Point(249, 277);
            this.txtdispStatus.Name = "txtdispStatus";
            this.txtdispStatus.Size = new System.Drawing.Size(26, 20);
            this.txtdispStatus.TabIndex = 139;
            this.txtdispStatus.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.bsDispenseSheet;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(262, 87);
            this.dataGridView2.TabIndex = 127;
            // 
            // bsDispenseSheet
            // 
            this.bsDispenseSheet.AllowNew = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtgroupDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtRandom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDspid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtItemid);
            this.panel1.Controls.Add(this.btnCompute);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStockLevel);
            this.panel1.Controls.Add(this.txtAmountSub);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtStockBal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDispenseQty);
            this.panel1.Location = new System.Drawing.Point(21, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 303);
            this.panel1.TabIndex = 131;
            this.panel1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 138;
            this.label13.Text = "Date";
            this.label13.Visible = false;
            // 
            // txtgroupDate
            // 
            this.txtgroupDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgroupDate.Location = new System.Drawing.Point(362, 270);
            this.txtgroupDate.Name = "txtgroupDate";
            this.txtgroupDate.Size = new System.Drawing.Size(26, 20);
            this.txtgroupDate.TabIndex = 137;
            this.txtgroupDate.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 136;
            this.label11.Text = "Rand";
            this.label11.Visible = false;
            // 
            // txtRandom
            // 
            this.txtRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRandom.Location = new System.Drawing.Point(361, 248);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(26, 20);
            this.txtRandom.TabIndex = 135;
            this.txtRandom.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "Dsp ID";
            this.label9.Visible = false;
            // 
            // txtDspid
            // 
            this.txtDspid.BackColor = System.Drawing.Color.White;
            this.txtDspid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDspid.Location = new System.Drawing.Point(362, 38);
            this.txtDspid.Name = "txtDspid";
            this.txtDspid.ReadOnly = true;
            this.txtDspid.Size = new System.Drawing.Size(26, 20);
            this.txtDspid.TabIndex = 133;
            this.txtDspid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(251, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 132;
            this.label8.Text = "On Save, this will overwrite \r\nthe \"Stock Level\" data";
            this.label8.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 131;
            this.label22.Text = "Item Code";
            this.label22.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(124, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 20);
            this.txtCode.TabIndex = 107;
            this.txtCode.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(12, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(252, 20);
            this.label21.TabIndex = 132;
            this.label21.Text = "Search Drug by Name or Code";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(205, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Location = new System.Drawing.Point(301, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 123);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifierDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.alternativeNameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.majorSupplierDataGridViewTextBoxColumn,
            this.packQuantityDataGridViewTextBoxColumn,
            this.packDescriptionDataGridViewTextBoxColumn,
            this.alternativeItemDataGridViewTextBoxColumn,
            this.standardIssueQuantityDataGridViewTextBoxColumn,
            this.economicOrderQuantityDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.markupPercentDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockLevelDataGridViewTextBoxColumn,
            this.minimumLevelDataGridViewTextBoxColumn,
            this.reOrderLevelDataGridViewTextBoxColumn,
            this.maximumLevelDataGridViewTextBoxColumn,
            this.leadDaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsItem;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(411, 87);
            this.dataGridView1.TabIndex = 111;
            // 
            // identifierDataGridViewTextBoxColumn
            // 
            this.identifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn.Name = "identifierDataGridViewTextBoxColumn";
            this.identifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeNameDataGridViewTextBoxColumn
            // 
            this.alternativeNameDataGridViewTextBoxColumn.DataPropertyName = "AlternativeName";
            this.alternativeNameDataGridViewTextBoxColumn.HeaderText = "AlternativeName";
            this.alternativeNameDataGridViewTextBoxColumn.Name = "alternativeNameDataGridViewTextBoxColumn";
            this.alternativeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // majorSupplierDataGridViewTextBoxColumn
            // 
            this.majorSupplierDataGridViewTextBoxColumn.DataPropertyName = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.HeaderText = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.Name = "majorSupplierDataGridViewTextBoxColumn";
            this.majorSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packQuantityDataGridViewTextBoxColumn
            // 
            this.packQuantityDataGridViewTextBoxColumn.DataPropertyName = "PackQuantity";
            this.packQuantityDataGridViewTextBoxColumn.HeaderText = "PackQuantity";
            this.packQuantityDataGridViewTextBoxColumn.Name = "packQuantityDataGridViewTextBoxColumn";
            this.packQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packDescriptionDataGridViewTextBoxColumn
            // 
            this.packDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PackDescription";
            this.packDescriptionDataGridViewTextBoxColumn.HeaderText = "PackDescription";
            this.packDescriptionDataGridViewTextBoxColumn.Name = "packDescriptionDataGridViewTextBoxColumn";
            this.packDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeItemDataGridViewTextBoxColumn
            // 
            this.alternativeItemDataGridViewTextBoxColumn.DataPropertyName = "AlternativeItem";
            this.alternativeItemDataGridViewTextBoxColumn.HeaderText = "AlternativeItem";
            this.alternativeItemDataGridViewTextBoxColumn.Name = "alternativeItemDataGridViewTextBoxColumn";
            this.alternativeItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // standardIssueQuantityDataGridViewTextBoxColumn
            // 
            this.standardIssueQuantityDataGridViewTextBoxColumn.DataPropertyName = "StandardIssueQuantity";
            this.standardIssueQuantityDataGridViewTextBoxColumn.HeaderText = "StandardIssueQuantity";
            this.standardIssueQuantityDataGridViewTextBoxColumn.Name = "standardIssueQuantityDataGridViewTextBoxColumn";
            this.standardIssueQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economicOrderQuantityDataGridViewTextBoxColumn
            // 
            this.economicOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "EconomicOrderQuantity";
            this.economicOrderQuantityDataGridViewTextBoxColumn.HeaderText = "EconomicOrderQuantity";
            this.economicOrderQuantityDataGridViewTextBoxColumn.Name = "economicOrderQuantityDataGridViewTextBoxColumn";
            this.economicOrderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markupPercentDataGridViewTextBoxColumn
            // 
            this.markupPercentDataGridViewTextBoxColumn.DataPropertyName = "MarkupPercent";
            this.markupPercentDataGridViewTextBoxColumn.HeaderText = "MarkupPercent";
            this.markupPercentDataGridViewTextBoxColumn.Name = "markupPercentDataGridViewTextBoxColumn";
            this.markupPercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockLevelDataGridViewTextBoxColumn
            // 
            this.stockLevelDataGridViewTextBoxColumn.DataPropertyName = "StockLevel";
            this.stockLevelDataGridViewTextBoxColumn.HeaderText = "StockLevel";
            this.stockLevelDataGridViewTextBoxColumn.Name = "stockLevelDataGridViewTextBoxColumn";
            this.stockLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimumLevelDataGridViewTextBoxColumn
            // 
            this.minimumLevelDataGridViewTextBoxColumn.DataPropertyName = "MinimumLevel";
            this.minimumLevelDataGridViewTextBoxColumn.HeaderText = "MinimumLevel";
            this.minimumLevelDataGridViewTextBoxColumn.Name = "minimumLevelDataGridViewTextBoxColumn";
            this.minimumLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reOrderLevelDataGridViewTextBoxColumn
            // 
            this.reOrderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.HeaderText = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.Name = "reOrderLevelDataGridViewTextBoxColumn";
            this.reOrderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximumLevelDataGridViewTextBoxColumn
            // 
            this.maximumLevelDataGridViewTextBoxColumn.DataPropertyName = "MaximumLevel";
            this.maximumLevelDataGridViewTextBoxColumn.HeaderText = "MaximumLevel";
            this.maximumLevelDataGridViewTextBoxColumn.Name = "maximumLevelDataGridViewTextBoxColumn";
            this.maximumLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leadDaysDataGridViewTextBoxColumn
            // 
            this.leadDaysDataGridViewTextBoxColumn.DataPropertyName = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.HeaderText = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.Name = "leadDaysDataGridViewTextBoxColumn";
            this.leadDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsItem
            // 
            this.bsItem.AllowNew = false;
            this.bsItem.DataSource = typeof(SmartInventorySystem.ViewModel.ItemViewModel);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(331, 96);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(83, 23);
            this.btnSelect.TabIndex = 112;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtUserAmend
            // 
            this.txtUserAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAmend.Location = new System.Drawing.Point(619, 12);
            this.txtUserAmend.Name = "txtUserAmend";
            this.txtUserAmend.Size = new System.Drawing.Size(47, 20);
            this.txtUserAmend.TabIndex = 137;
            this.txtUserAmend.Visible = false;
            // 
            // txtDateAmend
            // 
            this.txtDateAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateAmend.Location = new System.Drawing.Point(672, 12);
            this.txtDateAmend.Name = "txtDateAmend";
            this.txtDateAmend.Size = new System.Drawing.Size(46, 20);
            this.txtDateAmend.TabIndex = 136;
            this.txtDateAmend.Visible = false;
            // 
            // DispenseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.txtUserAmend);
            this.Controls.Add(this.txtDateAmend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Name = "DispenseItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dispense";
            this.Load += new System.EventHandler(this.frmDispense_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispenseSheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDispenseQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtUserAmend;
        private System.Windows.Forms.TextBox txtDateAmend;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDspid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgroupDate;
        private System.Windows.Forms.TextBox txtdispStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnComputeTotal;
        private System.Windows.Forms.BindingSource bsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardIssueQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economicOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDispenseSheet;
    }
}