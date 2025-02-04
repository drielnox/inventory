﻿using SmartInventorySystem.ViewModel;

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
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label22;
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
            this.bsForm = new System.Windows.Forms.BindingSource(this.components);
            this.txtUserAmend = new System.Windows.Forms.TextBox();
            this.txtDateAmend = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucItemDetails = new SmartInventorySystem.WinForms.DispenseItemDetailsUserControl();
            this.ucSearchItem = new SmartInventorySystem.WinForms.Controls.SearchItemControl();
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
            label13 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispenseSheet)).BeginInit();
            this.pnlDispenseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDispenseQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(182, 68);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 13);
            label4.TabIndex = 118;
            label4.Text = "Stock Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 131);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 13);
            label3.TabIndex = 116;
            label3.Text = "Quantity to Dispense";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 114;
            label2.Text = "Unit Price (N)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(16, 69);
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
            label10.Location = new System.Drawing.Point(16, 39);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(58, 13);
            label10.TabIndex = 109;
            label10.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(247, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 107;
            label1.Text = "Item ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 165);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 13);
            label5.TabIndex = 122;
            label5.Text = "Amount (N)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 167);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 13);
            label6.TabIndex = 124;
            label6.Text = "VAT (%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(10, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 13);
            label7.TabIndex = 126;
            label7.Text = "Sub Total Amount (N)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(10, 135);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(66, 13);
            label17.TabIndex = 143;
            label17.Text = "Discount (N)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(10, 197);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(57, 13);
            label16.TabIndex = 141;
            label16.Text = "Total (N)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(247, 188);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(30, 13);
            label13.TabIndex = 138;
            label13.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(247, 166);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(33, 13);
            label11.TabIndex = 136;
            label11.Text = "Rand";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(247, 31);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 13);
            label9.TabIndex = 134;
            label9.Text = "Dsp ID";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(16, 10);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(55, 13);
            label22.TabIndex = 131;
            label22.Text = "Item Code";
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(94, 244);
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
            this.btnSave.Location = new System.Drawing.Point(13, 244);
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
            this.txtStockBalance.Location = new System.Drawing.Point(265, 66);
            this.txtStockBalance.Name = "txtStockBalance";
            this.txtStockBalance.ReadOnly = true;
            this.txtStockBalance.Size = new System.Drawing.Size(52, 20);
            this.txtStockBalance.TabIndex = 117;
            this.txtStockBalance.Text = "0";
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockLevel.Location = new System.Drawing.Point(125, 67);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.ReadOnly = true;
            this.txtStockLevel.Size = new System.Drawing.Size(51, 20);
            this.txtStockLevel.TabIndex = 111;
            this.txtStockLevel.Text = "0";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(125, 34);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(116, 20);
            this.txtItemName.TabIndex = 108;
            // 
            // txtItemid
            // 
            this.txtItemid.Location = new System.Drawing.Point(293, 2);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(27, 20);
            this.txtItemid.TabIndex = 106;
            // 
            // txtAmountSub
            // 
            this.txtAmountSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountSub.Location = new System.Drawing.Point(125, 163);
            this.txtAmountSub.Name = "txtAmountSub";
            this.txtAmountSub.ReadOnly = true;
            this.txtAmountSub.Size = new System.Drawing.Size(51, 20);
            this.txtAmountSub.TabIndex = 121;
            this.txtAmountSub.Text = "0";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountTotal.Location = new System.Drawing.Point(154, 106);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.ReadOnly = true;
            this.txtAmountTotal.Size = new System.Drawing.Size(121, 20);
            this.txtAmountTotal.TabIndex = 125;
            this.txtAmountTotal.Text = "0";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(4, 194);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 23);
            this.btnAddItem.TabIndex = 128;
            this.btnAddItem.Text = "Add to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(120, 194);
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
            this.pnlCheckout.Controls.Add(this.txtdispStatus);
            this.pnlCheckout.Controls.Add(this.dataGridView2);
            this.pnlCheckout.Controls.Add(label7);
            this.pnlCheckout.Controls.Add(this.txtAmountTotal);
            this.pnlCheckout.Controls.Add(label6);
            this.pnlCheckout.Controls.Add(this.btnSave);
            this.pnlCheckout.Controls.Add(this.txtCancel);
            this.pnlCheckout.Location = new System.Drawing.Point(542, 361);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(282, 272);
            this.pnlCheckout.TabIndex = 130;
            this.pnlCheckout.Visible = false;
            // 
            // nudVat
            // 
            this.nudVat.DecimalPlaces = 2;
            this.nudVat.Location = new System.Drawing.Point(154, 165);
            this.nudVat.Name = "nudVat";
            this.nudVat.Size = new System.Drawing.Size(120, 20);
            this.nudVat.TabIndex = 146;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(154, 133);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(120, 20);
            this.nudDiscount.TabIndex = 145;
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Enabled = false;
            this.btnComputeTotal.Location = new System.Drawing.Point(154, 218);
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
            this.txtTotalFinal.Location = new System.Drawing.Point(154, 195);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFinal.TabIndex = 140;
            this.txtTotalFinal.Text = "0";
            // 
            // txtdispStatus
            // 
            this.txtdispStatus.Location = new System.Drawing.Point(249, 246);
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
            this.pnlDispenseItem.Location = new System.Drawing.Point(12, 398);
            this.pnlDispenseItem.Name = "pnlDispenseItem";
            this.pnlDispenseItem.Size = new System.Drawing.Size(328, 226);
            this.pnlDispenseItem.TabIndex = 131;
            this.pnlDispenseItem.Visible = false;
            // 
            // nudDispenseQty
            // 
            this.nudDispenseQty.Location = new System.Drawing.Point(125, 129);
            this.nudDispenseQty.Name = "nudDispenseQty";
            this.nudDispenseQty.Size = new System.Drawing.Size(51, 20);
            this.nudDispenseQty.TabIndex = 140;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(125, 97);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(51, 20);
            this.nudUnitPrice.TabIndex = 139;
            // 
            // txtgroupDate
            // 
            this.txtgroupDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgroupDate.Location = new System.Drawing.Point(294, 186);
            this.txtgroupDate.Name = "txtgroupDate";
            this.txtgroupDate.ReadOnly = true;
            this.txtgroupDate.Size = new System.Drawing.Size(26, 20);
            this.txtgroupDate.TabIndex = 137;
            // 
            // txtRandom
            // 
            this.txtRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRandom.Location = new System.Drawing.Point(293, 164);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.ReadOnly = true;
            this.txtRandom.Size = new System.Drawing.Size(26, 20);
            this.txtRandom.TabIndex = 135;
            // 
            // txtDspid
            // 
            this.txtDspid.Location = new System.Drawing.Point(293, 29);
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
            this.label8.Location = new System.Drawing.Point(183, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 132;
            this.label8.Text = "On Save, this will overwrite \r\nthe \"Stock Level\" data";
            this.label8.Visible = false;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Location = new System.Drawing.Point(125, 3);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(116, 20);
            this.txtItemCode.TabIndex = 107;
            // 
            // bsForm
            // 
            this.bsForm.DataSource = typeof(SmartInventorySystem.ViewModel.Forms.DispenseItemFormViewModel);
            // 
            // txtUserAmend
            // 
            this.txtUserAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAmend.Location = new System.Drawing.Point(725, 12);
            this.txtUserAmend.Name = "txtUserAmend";
            this.txtUserAmend.ReadOnly = true;
            this.txtUserAmend.Size = new System.Drawing.Size(47, 20);
            this.txtUserAmend.TabIndex = 137;
            // 
            // txtDateAmend
            // 
            this.txtDateAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateAmend.Location = new System.Drawing.Point(778, 12);
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
            this.splitContainer1.Panel1.Controls.Add(this.ucItemDetails);
            this.splitContainer1.Panel1.Controls.Add(this.ucSearchItem);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserAmend);
            this.splitContainer1.Panel1.Controls.Add(label12);
            this.splitContainer1.Panel1.Controls.Add(this.txtDateAmend);
            this.splitContainer1.Panel1.Controls.Add(this.pnlCheckout);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDispenseItem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucDispenseCart);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 636);
            this.splitContainer1.SplitterDistance = 827;
            this.splitContainer1.TabIndex = 138;
            // 
            // ucItemDetails
            // 
            this.ucItemDetails.Location = new System.Drawing.Point(12, 244);
            this.ucItemDetails.Name = "ucItemDetails";
            this.ucItemDetails.Size = new System.Drawing.Size(336, 148);
            this.ucItemDetails.TabIndex = 139;
            // 
            // ucSearchItem
            // 
            this.ucSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearchItem.Location = new System.Drawing.Point(12, 43);
            this.ucSearchItem.Name = "ucSearchItem";
            this.ucSearchItem.Size = new System.Drawing.Size(805, 200);
            this.ucSearchItem.TabIndex = 138;
            this.ucSearchItem.OnSelectedItem += new System.EventHandler<SmartInventorySystem.WinForms.Controls.SelectedItemEventArgs>(this.searchItemControl1_OnSelectedItem);
            // 
            // ucDispenseCart
            // 
            this.ucDispenseCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDispenseCart.Location = new System.Drawing.Point(0, 0);
            this.ucDispenseCart.Name = "ucDispenseCart";
            this.ucDispenseCart.Size = new System.Drawing.Size(274, 636);
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
        private System.Windows.Forms.BindingSource bsDispenseSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispenseQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudVat;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudDispenseQty;
        private Controls.DispenseCartControl ucDispenseCart;
        private Controls.SearchItemControl ucSearchItem;
        private DispenseItemDetailsUserControl ucItemDetails;
    }
}