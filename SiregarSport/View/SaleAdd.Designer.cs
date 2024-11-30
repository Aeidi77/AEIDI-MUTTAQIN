namespace SiregarSport.View
{
    partial class SaleAdd
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
            this.dateTimeTanggalSale = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBoxImageSale = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxClear = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtIdSale = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPenjualanAdd = new System.Windows.Forms.Label();
            this.cbIdCustomer = new System.Windows.Forms.ComboBox();
            this.cbIdItem = new System.Windows.Forms.ComboBox();
            this.saleData = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggalPembelian
            // 
            this.lblTanggalPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTanggalPembelian.AutoSize = true;
            this.lblTanggalPembelian.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggalPembelian.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPembelian.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTanggalPembelian.Location = new System.Drawing.Point(36, 404);
            this.lblTanggalPembelian.Name = "lblTanggalPembelian";
            this.lblTanggalPembelian.Size = new System.Drawing.Size(296, 24);
            this.lblTanggalPembelian.TabIndex = 152;
            this.lblTanggalPembelian.Text = "Tanggal Penjualan :";
            // 
            // dateTimeTanggalSale
            // 
            this.dateTimeTanggalSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimeTanggalSale.Checked = true;
            this.dateTimeTanggalSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimeTanggalSale.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimeTanggalSale.Location = new System.Drawing.Point(36, 435);
            this.dateTimeTanggalSale.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeTanggalSale.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeTanggalSale.Name = "dateTimeTanggalSale";
            this.dateTimeTanggalSale.Size = new System.Drawing.Size(467, 43);
            this.dateTimeTanggalSale.TabIndex = 151;
            this.dateTimeTanggalSale.Value = new System.DateTime(2024, 11, 19, 23, 57, 15, 522);
            this.dateTimeTanggalSale.ValueChanged += new System.EventHandler(this.dateTimeTanggalSale_ValueChanged);
            // 
            // pictureBoxImageSale
            // 
            this.pictureBoxImageSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImageSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageSale.Image = global::SiregarSport.Properties.Resources.moneysale;
            this.pictureBoxImageSale.ImageRotate = 0F;
            this.pictureBoxImageSale.Location = new System.Drawing.Point(58, 160);
            this.pictureBoxImageSale.Name = "pictureBoxImageSale";
            this.pictureBoxImageSale.Size = new System.Drawing.Size(421, 219);
            this.pictureBoxImageSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageSale.TabIndex = 149;
            this.pictureBoxImageSale.TabStop = false;
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
            // PictureBoxAdd
            // 
            this.PictureBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxAdd.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxAdd.Image = global::SiregarSport.Properties.Resources.icons8_add_96__1_;
            this.PictureBoxAdd.ImageRotate = 0F;
            this.PictureBoxAdd.Location = new System.Drawing.Point(515, 448);
            this.PictureBoxAdd.Name = "PictureBoxAdd";
            this.PictureBoxAdd.Size = new System.Drawing.Size(50, 56);
            this.PictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAdd.TabIndex = 147;
            this.PictureBoxAdd.TabStop = false;
            this.PictureBoxAdd.UseTransparentBackground = true;
            this.PictureBoxAdd.Click += new System.EventHandler(this.PictureBoxAdd_Click);
            // 
            // txtIdSale
            // 
            this.txtIdSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdSale.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdSale.DefaultText = "";
            this.txtIdSale.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSale.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdSale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSale.Location = new System.Drawing.Point(36, 486);
            this.txtIdSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdSale.Name = "txtIdSale";
            this.txtIdSale.PasswordChar = '\0';
            this.txtIdSale.PlaceholderText = "Id Sale";
            this.txtIdSale.SelectedText = "";
            this.txtIdSale.Size = new System.Drawing.Size(221, 43);
            this.txtIdSale.TabIndex = 146;
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
            // txtIdCustomer
            // 
            this.txtIdCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCustomer.DefaultText = "";
            this.txtIdCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer.Location = new System.Drawing.Point(282, 486);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.PasswordChar = '\0';
            this.txtIdCustomer.PlaceholderText = "Id Customer";
            this.txtIdCustomer.SelectedText = "";
            this.txtIdCustomer.Size = new System.Drawing.Size(221, 43);
            this.txtIdCustomer.TabIndex = 143;
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
            // lblPenjualanAdd
            // 
            this.lblPenjualanAdd.AutoSize = true;
            this.lblPenjualanAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblPenjualanAdd.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenjualanAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPenjualanAdd.Location = new System.Drawing.Point(146, 14);
            this.lblPenjualanAdd.Name = "lblPenjualanAdd";
            this.lblPenjualanAdd.Size = new System.Drawing.Size(325, 58);
            this.lblPenjualanAdd.TabIndex = 140;
            this.lblPenjualanAdd.Text = "Add Sale";
            // 
            // cbIdCustomer
            // 
            this.cbIdCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIdCustomer.FormattingEnabled = true;
            this.cbIdCustomer.Location = new System.Drawing.Point(402, 494);
            this.cbIdCustomer.Name = "cbIdCustomer";
            this.cbIdCustomer.Size = new System.Drawing.Size(96, 28);
            this.cbIdCustomer.TabIndex = 153;
            // 
            // cbIdItem
            // 
            this.cbIdItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIdItem.FormattingEnabled = true;
            this.cbIdItem.Location = new System.Drawing.Point(154, 545);
            this.cbIdItem.Name = "cbIdItem";
            this.cbIdItem.Size = new System.Drawing.Size(96, 28);
            this.cbIdItem.TabIndex = 154;
            // 
            // saleData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.saleData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.saleData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.saleData.ColumnHeadersHeight = 28;
            this.saleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleData.DefaultCellStyle = dataGridViewCellStyle3;
            this.saleData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleData.Location = new System.Drawing.Point(595, 128);
            this.saleData.Name = "saleData";
            this.saleData.RowHeadersVisible = false;
            this.saleData.RowHeadersWidth = 62;
            this.saleData.RowTemplate.Height = 28;
            this.saleData.Size = new System.Drawing.Size(647, 562);
            this.saleData.TabIndex = 171;
            this.saleData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.saleData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.saleData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.saleData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.saleData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.saleData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saleData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleData.ThemeStyle.HeaderStyle.Height = 28;
            this.saleData.ThemeStyle.ReadOnly = false;
            this.saleData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.saleData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.saleData.ThemeStyle.RowsStyle.Height = 28;
            this.saleData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.saleData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SaleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiregarSport.Properties.Resources.Backfinis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 718);
            this.Controls.Add(this.saleData);
            this.Controls.Add(this.cbIdItem);
            this.Controls.Add(this.cbIdCustomer);
            this.Controls.Add(this.lblTanggalPembelian);
            this.Controls.Add(this.dateTimeTanggalSale);
            this.Controls.Add(this.pictureBoxImageSale);
            this.Controls.Add(this.PictureBoxClear);
            this.Controls.Add(this.PictureBoxAdd);
            this.Controls.Add(this.txtIdSale);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtIdItem);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblPenjualanAdd);
            this.Name = "SaleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleAdd";
            this.Load += new System.EventHandler(this.SaleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggalPembelian;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeTanggalSale;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImageSale;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxClear;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtIdSale;
        private Guna.UI2.WinForms.Guna2TextBox txtSum;
        private Guna.UI2.WinForms.Guna2TextBox txtIdItem;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCustomer;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblPenjualanAdd;
        private System.Windows.Forms.ComboBox cbIdCustomer;
        private System.Windows.Forms.ComboBox cbIdItem;
        private Guna.UI2.WinForms.Guna2DataGridView saleData;
    }
}