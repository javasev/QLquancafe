namespace QLQuanCaphe.FORM
{
    partial class ucHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDon));
            this.panelHoaDon = new Guna.UI2.WinForms.Guna2Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btChuyenBan = new System.Windows.Forms.Button();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btInHoaDon = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.cbDanhMucMon = new System.Windows.Forms.ComboBox();
            this.numDemMon = new System.Windows.Forms.NumericUpDown();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panelHoaDon.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDemMon)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.AutoSize = true;
            this.panelHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHoaDon.Controls.Add(this.panel12);
            this.panelHoaDon.Controls.Add(this.panel4);
            this.panelHoaDon.Controls.Add(this.flpTable);
            this.panelHoaDon.Controls.Add(this.panel23);
            this.panelHoaDon.Controls.Add(this.panel24);
            this.panelHoaDon.Controls.Add(this.panel20);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(920, 742);
            this.panelHoaDon.TabIndex = 27;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.numericUpDown1);
            this.panel12.Controls.Add(this.label16);
            this.panel12.Controls.Add(this.btChuyenBan);
            this.panel12.Controls.Add(this.cbChuyenBan);
            this.panel12.Controls.Add(this.btInHoaDon);
            this.panel12.Controls.Add(this.btThanhToan);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.txtTotalPrice);
            this.panel12.Controls.Add(this.numGiamGia);
            this.panel12.Location = new System.Drawing.Point(0, 663);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(916, 81);
            this.panel12.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(456, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Giảm giá (%):";
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btChuyenBan.Location = new System.Drawing.Point(13, 14);
            this.btChuyenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.Size = new System.Drawing.Size(104, 30);
            this.btChuyenBan.TabIndex = 12;
            this.btChuyenBan.Text = "Chuyển bàn";
            this.btChuyenBan.UseVisualStyleBackColor = false;
            this.btChuyenBan.Click += new System.EventHandler(this.btChuyenBan_Click);
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(13, 46);
            this.cbChuyenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(104, 24);
            this.cbChuyenBan.TabIndex = 11;
            // 
            // btInHoaDon
            // 
            this.btInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btInHoaDon.Image")));
            this.btInHoaDon.Location = new System.Drawing.Point(347, 6);
            this.btInHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInHoaDon.Name = "btInHoaDon";
            this.btInHoaDon.Size = new System.Drawing.Size(95, 71);
            this.btInHoaDon.TabIndex = 10;
            this.btInHoaDon.Text = "In hóa đơn";
            this.btInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInHoaDon.UseVisualStyleBackColor = false;
            this.btInHoaDon.Click += new System.EventHandler(this.btInHoaDon_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.Location = new System.Drawing.Point(832, 11);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(65, 66);
            this.btThanhToan.TabIndex = 9;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tổng tiền: ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(591, 46);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(229, 22);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.Tag = "";
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(591, 12);
            this.numGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(80, 22);
            this.numGiamGia.TabIndex = 4;
            this.numGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.cbMonAn);
            this.panel4.Controls.Add(this.btThemMon);
            this.panel4.Controls.Add(this.cbDanhMucMon);
            this.panel4.Controls.Add(this.numDemMon);
            this.panel4.Location = new System.Drawing.Point(448, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 78);
            this.panel4.TabIndex = 8;
            // 
            // cbMonAn
            // 
            this.cbMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(27, 41);
            this.cbMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(244, 24);
            this.cbMonAn.TabIndex = 2;
            // 
            // btThemMon
            // 
            this.btThemMon.BackColor = System.Drawing.Color.White;
            this.btThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemMon.Location = new System.Drawing.Point(296, 11);
            this.btThemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(77, 53);
            this.btThemMon.TabIndex = 1;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.UseVisualStyleBackColor = false;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // cbDanhMucMon
            // 
            this.cbDanhMucMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMucMon.FormattingEnabled = true;
            this.cbDanhMucMon.Location = new System.Drawing.Point(27, 12);
            this.cbDanhMucMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDanhMucMon.Name = "cbDanhMucMon";
            this.cbDanhMucMon.Size = new System.Drawing.Size(244, 24);
            this.cbDanhMucMon.TabIndex = 0;
            this.cbDanhMucMon.SelectedIndexChanged += new System.EventHandler(this.cbDanhMucMon_SelectedIndexChanged);
            // 
            // numDemMon
            // 
            this.numDemMon.Location = new System.Drawing.Point(397, 27);
            this.numDemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDemMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numDemMon.Name = "numDemMon";
            this.numDemMon.Size = new System.Drawing.Size(52, 22);
            this.numDemMon.TabIndex = 4;
            this.numDemMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(5, 90);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(437, 567);
            this.flpTable.TabIndex = 9;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Controls.Add(this.label24);
            this.panel23.Location = new System.Drawing.Point(449, 6);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(467, 79);
            this.panel23.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(69, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(355, 37);
            this.label24.TabIndex = 1;
            this.label24.Text = "HÓA ĐƠN ĐẶT MÓN";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.Controls.Add(this.label23);
            this.panel24.Location = new System.Drawing.Point(5, 6);
            this.panel24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(437, 79);
            this.panel24.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(45, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(355, 37);
            this.label23.TabIndex = 0;
            this.label23.Text = "DANH SÁCH BÀN ĂN";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.lvHoaDon);
            this.panel20.Location = new System.Drawing.Point(448, 171);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(467, 487);
            this.panel20.TabIndex = 6;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMon,
            this.Soluong,
            this.Dongia,
            this.Thanhtien});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(466, 487);
            this.lvHoaDon.TabIndex = 1;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 130;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số lượng";
            this.Soluong.Width = 65;
            // 
            // Dongia
            // 
            this.Dongia.Text = "Đơn giá";
            this.Dongia.Width = 70;
            // 
            // Thanhtien
            // 
            this.Thanhtien.Text = "Thành tiền";
            this.Thanhtien.Width = 120;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(628, 14);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(8, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(920, 742);
            this.panelHoaDon.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDemMon)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHoaDon;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btChuyenBan;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button btInHoaDon;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.ComboBox cbDanhMucMon;
        private System.Windows.Forms.NumericUpDown numDemMon;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.ColumnHeader Dongia;
        private System.Windows.Forms.ColumnHeader Thanhtien;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
