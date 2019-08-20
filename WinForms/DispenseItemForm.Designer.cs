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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label21;
            this.txtCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStockBalance = new System.Windows.Forms.TextBox();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemid = new System.Windows.Forms.TextBox();
            this.txtAmountSub = new System.Windows.Forms.TextBox();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.nudVat = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.txtdispStatus = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dispenseQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDispenseSheet = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDispenseItem = new System.Windows.Forms.Panel();
            this.nudDispenseQty = new System.Windows.Forms.NumericUpDown();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.txtgroupDate = new System.Windows.Forms.TextBox();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.txtDspid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bsForm = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dgvSearchedItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSearchedItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.txtUserAmend = new System.Windows.Forms.TextBox();
            this.txtDateAmend = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucDispenseCart = new SmartInventorySystem.WinForms.Controls.DispenseCartControl();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispenseSheet)).BeginInit();
            this.pnlDispenseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDispenseQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearchedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(250, 77);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 13);
            label4.TabIndex = 118;
            label4.Text = "Stock Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 13);
            label3.TabIndex = 116;
            label3.Text = "Quantity to Dispense";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 114;
            label2.Text = "Unit Price (N)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(15, 77);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(64, 13);
            label15.TabIndex = 112;
            label15.Text = "Stock Level";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            label12.Location = new System.Drawing.Point(308, 9);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(146, 20);
            label12.TabIndex = 110;
            label12.Text = "DISPENSE ITEM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(15, 47);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(58, 13);
            label10.TabIndex = 109;
            label10.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(315, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 107;
            label1.Text = "Item ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 13);
            label5.TabIndex = 122;
            label5.Text = "Amount (N)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 189);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 13);
            label6.TabIndex = 124;
            label6.Text = "VAT (%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 130);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 13);
            label7.TabIndex = 126;
            label7.Text = "Sub Total Amount (N)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(10, 157);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(66, 13);
            label17.TabIndex = 143;
            label17.Text = "Discount (N)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(10, 219);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(57, 13);
            label16.TabIndex = 141;
            label16.Text = "Total (N)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(205, 282);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(99, 13);
            label14.TabIndex = 139;
            label14.Text = "Dispense Executed";
            label14.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(315, 272);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(30, 13);
            label13.TabIndex = 138;
            label13.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(315, 250);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(33, 13);
            label11.TabIndex = 136;
            label11.Text = "Rand";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(315, 40);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 13);
            label9.TabIndex = 134;
            label9.Text = "Dsp ID";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(15, 18);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(55, 13);
            label22.TabIndex = 131;
            label22.Text = "Item Code";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label21.Location = new System.Drawing.Point(12, 43);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(252, 20);
            label21.TabIndex = 132;
            label21.Text = "Search Drug by Name or Code";
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(84, 277);
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
            this.btnSave.Location = new System.Drawing.Point(3, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtStockBalance
            // 
            this.txtStockBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockBalance.Location = new System.Drawing.Point(333, 75);
            this.txtStockBalance.Name = "txtStockBalance";
            this.txtStockBalance.ReadOnly = true;
            this.txtStockBalance.Size = new System.Drawing.Size(52, 20);
            this.txtStockBalance.TabIndex = 117;
            this.txtStockBalance.Text = "0";
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
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(124, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 108;
            // 
            // txtItemid
            // 
            this.txtItemid.Location = new System.Drawing.Point(361, 11);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(27, 20);
            this.txtItemid.TabIndex = 106;
            // 
            // txtAmountSub
            // 
            this.txtAmountSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountSub.Location = new System.Drawing.Point(124, 171);
            this.txtAmountSub.Name = "txtAmountSub";
            this.txtAmountSub.ReadOnly = true;
            this.txtAmountSub.Size = new System.Drawing.Size(120, 20);
            this.txtAmountSub.TabIndex = 121;
            this.txtAmountSub.Text = "0";
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
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.nudVat);
            this.pnlCheckout.Controls.Add(this.nudDiscount);
            this.pnlCheckout.Controls.Add(this.btnComputeTotal);
            this.pnlCheckout.Controls.Add(label17);
            this.pnlCheckout.Controls.Add(label16);
            this.pnlCheckout.Controls.Add(this.txtTotalFinal);
            this.pnlCheckout.Controls.Add(label14);
            this.pnlCheckout.Controls.Add(this.txtdispStatus);
            this.pnlCheckout.Controls.Add(this.dataGridView2);
            this.pnlCheckout.Controls.Add(label7);
            this.pnlCheckout.Controls.Add(this.txtAmountTotal);
            this.pnlCheckout.Controls.Add(label6);
            this.pnlCheckout.Controls.Add(this.btnSave);
            this.pnlCheckout.Controls.Add(this.txtCancel);
            this.pnlCheckout.Location = new System.Drawing.Point(418, 321);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(339, 303);
            this.pnlCheckout.TabIndex = 130;
            this.pnlCheckout.Visible = false;
            // 
            // nudVat
            // 
            this.nudVat.DecimalPlaces = 2;
            this.nudVat.Location = new System.Drawing.Point(119, 187);
            this.nudVat.Name = "nudVat";
            this.nudVat.Size = new System.Drawing.Size(120, 20);
            this.nudVat.TabIndex = 146;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(119, 155);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(120, 20);
            this.nudDiscount.TabIndex = 145;
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
            // txtdispStatus
            // 
            this.txtdispStatus.Location = new System.Drawing.Point(310, 279);
            this.txtdispStatus.Name = "txtdispStatus";
            this.txtdispStatus.ReadOnly = true;
            this.txtdispStatus.Size = new System.Drawing.Size(26, 20);
            this.txtdispStatus.TabIndex = 139;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dispenseQuantityDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsDispenseSheet;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(262, 87);
            this.dataGridView2.TabIndex = 127;
            // 
            // dispenseQuantityDataGridViewTextBoxColumn
            // 
            this.dispenseQuantityDataGridViewTextBoxColumn.DataPropertyName = "DispenseQuantity";
            this.dispenseQuantityDataGridViewTextBoxColumn.HeaderText = "DispenseQuantity";
            this.dispenseQuantityDataGridViewTextBoxColumn.Name = "dispenseQuantityDataGridViewTextBoxColumn";
            this.dispenseQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDispenseSheet
            // 
            this.bsDispenseSheet.DataSource = typeof(SmartInventorySystem.ViewModel.DispenseSheetViewModel);
            // 
            // pnlDispenseItem
            // 
            this.pnlDispenseItem.Controls.Add(this.nudDispenseQty);
            this.pnlDispenseItem.Controls.Add(this.nudUnitPrice);
            this.pnlDispenseItem.Controls.Add(label13);
            this.pnlDispenseItem.Controls.Add(this.txtgroupDate);
            this.pnlDispenseItem.Controls.Add(label11);
            this.pnlDispenseItem.Controls.Add(this.txtRandom);
            this.pnlDispenseItem.Controls.Add(label9);
            this.pnlDispenseItem.Controls.Add(this.txtDspid);
            this.pnlDispenseItem.Controls.Add(this.label8);
            this.pnlDispenseItem.Controls.Add(label22);
            this.pnlDispenseItem.Controls.Add(this.txtItemCode);
            this.pnlDispenseItem.Controls.Add(label1);
            this.pnlDispenseItem.Controls.Add(this.txtItemid);
            this.pnlDispenseItem.Controls.Add(this.btnCompute);
            this.pnlDispenseItem.Controls.Add(this.txtItemName);
            this.pnlDispenseItem.Controls.Add(this.btnAddItem);
            this.pnlDispenseItem.Controls.Add(label10);
            this.pnlDispenseItem.Controls.Add(label5);
            this.pnlDispenseItem.Controls.Add(this.txtStockLevel);
            this.pnlDispenseItem.Controls.Add(this.txtAmountSub);
            this.pnlDispenseItem.Controls.Add(label15);
            this.pnlDispenseItem.Controls.Add(label4);
            this.pnlDispenseItem.Controls.Add(this.txtStockBalance);
            this.pnlDispenseItem.Controls.Add(label2);
            this.pnlDispenseItem.Controls.Add(label3);
            this.pnlDispenseItem.Location = new System.Drawing.Point(12, 321);
            this.pnlDispenseItem.Name = "pnlDispenseItem";
            this.pnlDispenseItem.Size = new System.Drawing.Size(400, 303);
            this.pnlDispenseItem.TabIndex = 131;
            this.pnlDispenseItem.Visible = false;
            // 
            // nudDispenseQty
            // 
            this.nudDispenseQty.Location = new System.Drawing.Point(124, 137);
            this.nudDispenseQty.Name = "nudDispenseQty";
            this.nudDispenseQty.Size = new System.Drawing.Size(120, 20);
            this.nudDispenseQty.TabIndex = 140;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(124, 105);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.nudUnitPrice.TabIndex = 139;
            // 
            // txtgroupDate
            // 
            this.txtgroupDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgroupDate.Location = new System.Drawing.Point(362, 270);
            this.txtgroupDate.Name = "txtgroupDate";
            this.txtgroupDate.ReadOnly = true;
            this.txtgroupDate.Size = new System.Drawing.Size(26, 20);
            this.txtgroupDate.TabIndex = 137;
            // 
            // txtRandom
            // 
            this.txtRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRandom.Location = new System.Drawing.Point(361, 248);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.ReadOnly = true;
            this.txtRandom.Size = new System.Drawing.Size(26, 20);
            this.txtRandom.TabIndex = 135;
            // 
            // txtDspid
            // 
            this.txtDspid.Location = new System.Drawing.Point(361, 38);
            this.txtDspid.Name = "txtDspid";
            this.txtDspid.ReadOnly = true;
            this.txtDspid.Size = new System.Drawing.Size(27, 20);
            this.txtDspid.TabIndex = 133;
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
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Location = new System.Drawing.Point(124, 11);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(185, 20);
            this.txtItemCode.TabIndex = 107;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "SearchItemText", true));
            this.txtSearch.Location = new System.Drawing.Point(12, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // bsForm
            // 
            this.bsForm.DataSource = typeof(SmartInventorySystem.ViewModel.Forms.DispenseItemFormViewModel);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(667, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.dgvSearchedItem);
            this.pnlSearch.Controls.Add(this.btnSelectItem);
            this.pnlSearch.Location = new System.Drawing.Point(12, 95);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(749, 123);
            this.pnlSearch.TabIndex = 135;
            this.pnlSearch.Visible = false;
            // 
            // dgvSearchedItem
            // 
            this.dgvSearchedItem.AllowUserToAddRows = false;
            this.dgvSearchedItem.AllowUserToDeleteRows = false;
            this.dgvSearchedItem.AutoGenerateColumns = false;
            this.dgvSearchedItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSearchedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.expireDataGridViewTextBoxColumn});
            this.dgvSearchedItem.DataSource = this.bsSearchedItems;
            this.dgvSearchedItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSearchedItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSearchedItem.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchedItem.MultiSelect = false;
            this.dgvSearchedItem.Name = "dgvSearchedItem";
            this.dgvSearchedItem.ReadOnly = true;
            this.dgvSearchedItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchedItem.Size = new System.Drawing.Size(749, 91);
            this.dgvSearchedItem.TabIndex = 111;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Identifier";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identifier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AlternativeName";
            this.dataGridViewTextBoxColumn5.HeaderText = "AlternativeName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MajorSupplier";
            this.dataGridViewTextBoxColumn7.HeaderText = "MajorSupplier";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 96;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PackQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "PackQuantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 96;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PackDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "PackDescription";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 110;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AlternativeItem";
            this.dataGridViewTextBoxColumn10.HeaderText = "AlternativeItem";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StandardIssueQuantity";
            this.dataGridViewTextBoxColumn11.HeaderText = "StandardIssueQuantity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 139;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EconomicOrderQuantity";
            this.dataGridViewTextBoxColumn12.HeaderText = "EconomicOrderQuantity";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 144;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn13.HeaderText = "PurchasePrice";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MarkupPercent";
            this.dataGridViewTextBoxColumn14.HeaderText = "MarkupPercent";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 105;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SellingPrice";
            this.dataGridViewTextBoxColumn15.HeaderText = "SellingPrice";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 87;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "StockLevel";
            this.dataGridViewTextBoxColumn16.HeaderText = "StockLevel";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 86;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MinimumLevel";
            this.dataGridViewTextBoxColumn17.HeaderText = "MinimumLevel";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 99;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ReOrderLevel";
            this.dataGridViewTextBoxColumn18.HeaderText = "ReOrderLevel";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 98;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "MaximumLevel";
            this.dataGridViewTextBoxColumn19.HeaderText = "MaximumLevel";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 102;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "LeadDays";
            this.dataGridViewTextBoxColumn20.HeaderText = "LeadDays";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 80;
            // 
            // expireDataGridViewTextBoxColumn
            // 
            this.expireDataGridViewTextBoxColumn.DataPropertyName = "Expire";
            this.expireDataGridViewTextBoxColumn.HeaderText = "Expire";
            this.expireDataGridViewTextBoxColumn.Name = "expireDataGridViewTextBoxColumn";
            this.expireDataGridViewTextBoxColumn.ReadOnly = true;
            this.expireDataGridViewTextBoxColumn.Width = 61;
            // 
            // bsSearchedItems
            // 
            this.bsSearchedItems.AllowNew = false;
            this.bsSearchedItems.DataMember = "SearchItemResult";
            this.bsSearchedItems.DataSource = this.bsForm;
            this.bsSearchedItems.CurrentChanged += new System.EventHandler(this.bsItem_CurrentChanged);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectItem.Enabled = false;
            this.btnSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.Location = new System.Drawing.Point(663, 97);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(83, 23);
            this.btnSelectItem.TabIndex = 112;
            this.btnSelectItem.Text = "Select";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtUserAmend
            // 
            this.txtUserAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAmend.Location = new System.Drawing.Point(619, 17);
            this.txtUserAmend.Name = "txtUserAmend";
            this.txtUserAmend.ReadOnly = true;
            this.txtUserAmend.Size = new System.Drawing.Size(47, 20);
            this.txtUserAmend.TabIndex = 137;
            // 
            // txtDateAmend
            // 
            this.txtDateAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateAmend.Location = new System.Drawing.Point(672, 17);
            this.txtDateAmend.Name = "txtDateAmend";
            this.txtDateAmend.ReadOnly = true;
            this.txtDateAmend.Size = new System.Drawing.Size(46, 20);
            this.txtDateAmend.TabIndex = 136;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(label21);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserAmend);
            this.splitContainer1.Panel1.Controls.Add(label12);
            this.splitContainer1.Panel1.Controls.Add(this.txtDateAmend);
            this.splitContainer1.Panel1.Controls.Add(this.pnlCheckout);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDispenseItem);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucDispenseCart);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 636);
            this.splitContainer1.SplitterDistance = 764;
            this.splitContainer1.TabIndex = 138;
            // 
            // ucDispenseCart
            // 
            this.ucDispenseCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDispenseCart.Location = new System.Drawing.Point(0, 0);
            this.ucDispenseCart.Name = "ucDispenseCart";
            this.ucDispenseCart.Size = new System.Drawing.Size(337, 636);
            this.ucDispenseCart.TabIndex = 0;
            // 
            // DispenseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 636);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DispenseItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dispense";
            this.Load += new System.EventHandler(this.frmDispense_Load);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispenseSheet)).EndInit();
            this.pnlDispenseItem.ResumeLayout(false);
            this.pnlDispenseItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDispenseQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearchedItems)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStockBalance;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemid;
        private System.Windows.Forms.TextBox txtAmountSub;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Panel pnlDispenseItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvSearchedItem;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.TextBox txtUserAmend;
        private System.Windows.Forms.TextBox txtDateAmend;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDspid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.TextBox txtgroupDate;
        private System.Windows.Forms.TextBox txtdispStatus;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Button btnComputeTotal;
        private System.Windows.Forms.BindingSource bsSearchedItems;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDispenseSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispenseQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudVat;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudDispenseQty;
        private Controls.DispenseCartControl ucDispenseCart;
    }
}