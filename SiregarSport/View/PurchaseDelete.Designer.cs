﻿namespace SiregarSport.View
{
    partial class PurchaseDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTanggalPembelian = new System.Windows.Forms.Label();
            this.datePurchase = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdPurchase = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdDistributor = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblPembelianDelete = new System.Windows.Forms.Label();
            this.PictureBoxClear = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.purchaseData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBoxImagePurchase = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggalPembelian
            // 
            this.lblTanggalPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTanggalPembelian.AutoSize = true;
            this.lblTanggalPembelian.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggalPembelian.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPembelian.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTanggalPembelian.Location = new System.Drawing.Point(31, 402);
            this.lblTanggalPembelian.Name = "lblTanggalPembelian";
            this.lblTanggalPembelian.Size = new System.Drawing.Size(292, 24);
            this.lblTanggalPembelian.TabIndex = 152;
            this.lblTanggalPembelian.Text = "Tanggal Pembelian :";
            // 
            // datePurchase
            // 
            this.datePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePurchase.Checked = true;
            this.datePurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePurchase.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePurchase.Location = new System.Drawing.Point(36, 435);
            this.datePurchase.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePurchase.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.Size = new System.Drawing.Size(467, 43);
            this.datePurchase.TabIndex = 151;
            this.datePurchase.Value = new System.DateTime(2024, 11, 19, 23, 57, 15, 522);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(595, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(408, 43);
            this.txtSearch.TabIndex = 150;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtIdPurchase
            // 
            this.txtIdPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdPurchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPurchase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPurchase.DefaultText = "";
            this.txtIdPurchase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPurchase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPurchase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPurchase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPurchase.Location = new System.Drawing.Point(36, 486);
            this.txtIdPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPurchase.Name = "txtIdPurchase";
            this.txtIdPurchase.PasswordChar = '\0';
            this.txtIdPurchase.PlaceholderText = "Id Purchase";
            this.txtIdPurchase.SelectedText = "";
            this.txtIdPurchase.Size = new System.Drawing.Size(221, 43);
            this.txtIdPurchase.TabIndex = 146;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSum.DefaultText = "";
            this.txtSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSum.Location = new System.Drawing.Point(282, 538);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSum.Name = "txtSum";
            this.txtSum.PasswordChar = '\0';
            this.txtSum.PlaceholderText = "Sum";
            this.txtSum.SelectedText = "";
            this.txtSum.Size = new System.Drawing.Size(221, 43);
            this.txtSum.TabIndex = 145;
            // 
            // txtIdItem
            // 
            this.txtIdItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdItem.DefaultText = "";
            this.txtIdItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdItem.Location = new System.Drawing.Point(36, 538);
            this.txtIdItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.PasswordChar = '\0';
            this.txtIdItem.PlaceholderText = "Id Item";
            this.txtIdItem.SelectedText = "";
            this.txtIdItem.Size = new System.Drawing.Size(221, 43);
            this.txtIdItem.TabIndex = 144;
            // 
            // txtIdDistributor
            // 
            this.txtIdDistributor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdDistributor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdDistributor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdDistributor.DefaultText = "";
            this.txtIdDistributor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdDistributor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdDistributor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdDistributor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdDistributor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdDistributor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdDistributor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdDistributor.Location = new System.Drawing.Point(282, 486);
            this.txtIdDistributor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDistributor.Name = "txtIdDistributor";
            this.txtIdDistributor.PasswordChar = '\0';
            this.txtIdDistributor.PlaceholderText = "Id Distributor";
            this.txtIdDistributor.SelectedText = "";
            this.txtIdDistributor.Size = new System.Drawing.Size(221, 43);
            this.txtIdDistributor.TabIndex = 143;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 5;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(17, 663);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.White;
            this.btnExit.Size = new System.Drawing.Size(117, 45);
            this.btnExit.TabIndex = 142;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPembelianDelete
            // 
            this.lblPembelianDelete.AutoSize = true;
            this.lblPembelianDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblPembelianDelete.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPembelianDelete.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPembelianDelete.Location = new System.Drawing.Point(140, 11);
            this.lblPembelianDelete.Name = "lblPembelianDelete";
            this.lblPembelianDelete.Size = new System.Drawing.Size(617, 58);
            this.lblPembelianDelete.TabIndex = 140;
            this.lblPembelianDelete.Text = "Delete Purchase";
            // 
            // PictureBoxClear
            // 
            this.PictureBoxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxClear.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxClear.Image = global::SiregarSport.Properties.Resources.icons8_clear_96;
            this.PictureBoxClear.ImageRotate = 0F;
            this.PictureBoxClear.Location = new System.Drawing.Point(510, 518);
            this.PictureBoxClear.Name = "PictureBoxClear";
            this.PictureBoxClear.Size = new System.Drawing.Size(63, 56);
            this.PictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClear.TabIndex = 148;
            this.PictureBoxClear.TabStop = false;
            this.PictureBoxClear.UseTransparentBackground = true;
            this.PictureBoxClear.Click += new System.EventHandler(this.PictureBoxClear_Click);
            // 
            // PictureBoxDelete
            // 
            this.PictureBoxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxDelete.Image = global::SiregarSport.Properties.Resources.icons8_delete_96__1_;
            this.PictureBoxDelete.ImageRotate = 0F;
            this.PictureBoxDelete.Location = new System.Drawing.Point(515, 448);
            this.PictureBoxDelete.Name = "PictureBoxDelete";
            this.PictureBoxDelete.Size = new System.Drawing.Size(50, 56);
            this.PictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDelete.TabIndex = 147;
            this.PictureBoxDelete.TabStop = false;
            this.PictureBoxDelete.UseTransparentBackground = true;
            this.PictureBoxDelete.Click += new System.EventHandler(this.PictureBoxDelete_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::SiregarSport.Properties.Resources._11zon_cropped;
            this.pictureBoxLogo.ImageRotate = 0F;
            this.pictureBoxLogo.Location = new System.Drawing.Point(17, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(130, 124);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 141;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.UseTransparentBackground = true;
            // 
            // purchaseData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.purchaseData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseData.ColumnHeadersHeight = 28;
            this.purchaseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseData.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseData.Location = new System.Drawing.Point(595, 128);
            this.purchaseData.Name = "purchaseData";
            this.purchaseData.RowHeadersVisible = false;
            this.purchaseData.RowHeadersWidth = 62;
            this.purchaseData.RowTemplate.Height = 28;
            this.purchaseData.Size = new System.Drawing.Size(647, 562);
            this.purchaseData.TabIndex = 168;
            this.purchaseData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.purchaseData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.purchaseData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.purchaseData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.purchaseData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purchaseData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.purchaseData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purchaseData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purchaseData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchaseData.ThemeStyle.HeaderStyle.Height = 28;
            this.purchaseData.ThemeStyle.ReadOnly = false;
            this.purchaseData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchaseData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchaseData.ThemeStyle.RowsStyle.Height = 28;
            this.purchaseData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchaseData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseData_CellContentClick_1);
            // 
            // pictureBoxImagePurchase
            // 
            this.pictureBoxImagePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImagePurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagePurchase.Image = global::SiregarSport.Properties.Resources.purchase;
            this.pictureBoxImagePurchase.ImageRotate = 0F;
            this.pictureBoxImagePurchase.Location = new System.Drawing.Point(36, 166);
            this.pictureBoxImagePurchase.Name = "pictureBoxImagePurchase";
            this.pictureBoxImagePurchase.Size = new System.Drawing.Size(467, 213);
            this.pictureBoxImagePurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagePurchase.TabIndex = 169;
            this.pictureBoxImagePurchase.TabStop = false;
            // 
            // PurchaseDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiregarSport.Properties.Resources.Backfinis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 718);
            this.Controls.Add(this.pictureBoxImagePurchase);
            this.Controls.Add(this.purchaseData);
            this.Controls.Add(this.lblTanggalPembelian);
            this.Controls.Add(this.datePurchase);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.PictureBoxClear);
            this.Controls.Add(this.PictureBoxDelete);
            this.Controls.Add(this.txtIdPurchase);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtIdItem);
            this.Controls.Add(this.txtIdDistributor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblPembelianDelete);
            this.Name = "PurchaseDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseDelete";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggalPembelian;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePurchase;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxClear;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPurchase;
        private Guna.UI2.WinForms.Guna2TextBox txtSum;
        private Guna.UI2.WinForms.Guna2TextBox txtIdItem;
        private Guna.UI2.WinForms.Guna2TextBox txtIdDistributor;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblPembelianDelete;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseData;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImagePurchase;
    }
}