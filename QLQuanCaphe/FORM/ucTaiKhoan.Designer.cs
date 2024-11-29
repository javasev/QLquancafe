namespace QLQuanCaphe.FORM
{
    partial class ucTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTaiKhoan));
            this.panel30 = new System.Windows.Forms.Panel();
            this.btXemTK = new System.Windows.Forms.Button();
            this.btThemTK = new System.Windows.Forms.Button();
            this.btXoaTK = new System.Windows.Forms.Button();
            this.btSuaTK = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btCaiDatMK = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.panel30.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.btXemTK);
            this.panel30.Controls.Add(this.btThemTK);
            this.panel30.Controls.Add(this.btXoaTK);
            this.panel30.Controls.Add(this.btSuaTK);
            this.panel30.Location = new System.Drawing.Point(30, 798);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(489, 98);
            this.panel30.TabIndex = 20;
            // 
            // btXemTK
            // 
            this.btXemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemTK.Location = new System.Drawing.Point(374, 17);
            this.btXemTK.Name = "btXemTK";
            this.btXemTK.Size = new System.Drawing.Size(102, 63);
            this.btXemTK.TabIndex = 7;
            this.btXemTK.Text = "Làm mới";
            this.btXemTK.UseVisualStyleBackColor = true;
            this.btXemTK.Click += new System.EventHandler(this.btXemTK_Click);
            // 
            // btThemTK
            // 
            this.btThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemTK.Location = new System.Drawing.Point(15, 17);
            this.btThemTK.Name = "btThemTK";
            this.btThemTK.Size = new System.Drawing.Size(102, 63);
            this.btThemTK.TabIndex = 4;
            this.btThemTK.Text = "Thêm";
            this.btThemTK.UseVisualStyleBackColor = true;
            this.btThemTK.Click += new System.EventHandler(this.btThemTK_Click);
            // 
            // btXoaTK
            // 
            this.btXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaTK.Location = new System.Drawing.Point(132, 17);
            this.btXoaTK.Name = "btXoaTK";
            this.btXoaTK.Size = new System.Drawing.Size(102, 63);
            this.btXoaTK.TabIndex = 5;
            this.btXoaTK.Text = "Xóa";
            this.btXoaTK.UseVisualStyleBackColor = true;
            this.btXoaTK.Click += new System.EventHandler(this.btXoaTK_Click);
            // 
            // btSuaTK
            // 
            this.btSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaTK.Location = new System.Drawing.Point(255, 17);
            this.btSuaTK.Name = "btSuaTK";
            this.btSuaTK.Size = new System.Drawing.Size(102, 63);
            this.btSuaTK.TabIndex = 6;
            this.btSuaTK.Text = "Sửa";
            this.btSuaTK.UseVisualStyleBackColor = true;
            this.btSuaTK.Click += new System.EventHandler(this.btSuaTK_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(226, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(611, 40);
            this.label15.TabIndex = 16;
            this.label15.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btCaiDatMK);
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Controls.Add(this.panel27);
            this.panel25.Controls.Add(this.panel28);
            this.panel25.Location = new System.Drawing.Point(550, 177);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(478, 743);
            this.panel25.TabIndex = 19;
            // 
            // btCaiDatMK
            // 
            this.btCaiDatMK.BackColor = System.Drawing.Color.Transparent;
            this.btCaiDatMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCaiDatMK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCaiDatMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCaiDatMK.Location = new System.Drawing.Point(168, 582);
            this.btCaiDatMK.Name = "btCaiDatMK";
            this.btCaiDatMK.Size = new System.Drawing.Size(172, 45);
            this.btCaiDatMK.TabIndex = 18;
            this.btCaiDatMK.Text = "Cài đặt lại MK";
            this.btCaiDatMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCaiDatMK.UseVisualStyleBackColor = false;
            this.btCaiDatMK.Click += new System.EventHandler(this.btCaiDatMK_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtLoaiTK);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(21, 403);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(428, 62);
            this.panel26.TabIndex = 17;
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.BackColor = System.Drawing.Color.White;
            this.txtLoaiTK.Enabled = false;
            this.txtLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTK.Location = new System.Drawing.Point(166, 14);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(242, 28);
            this.txtLoaiTK.TabIndex = 8;
            this.txtLoaiTK.Text = "Staff";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Loại tài khoản:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txtTenNV);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(21, 289);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(428, 62);
            this.panel27.TabIndex = 16;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.White;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(166, 17);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(242, 28);
            this.txtTenNV.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nhân viên:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.txtTenTaiKhoan);
            this.panel28.Controls.Add(this.label14);
            this.panel28.Location = new System.Drawing.Point(21, 174);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(428, 62);
            this.panel28.TabIndex = 15;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(166, 15);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(242, 28);
            this.txtTenTaiKhoan.TabIndex = 6;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tên tài khoản:";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dgvTaiKhoan);
            this.panel29.Location = new System.Drawing.Point(6, 177);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(538, 608);
            this.panel29.TabIndex = 18;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName,
            this.Type});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(4, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(531, 598);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tài khoản";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Tên NV";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại TK";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(447, 3);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(174, 128);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel29);
            this.Controls.Add(this.pictureBox15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(1035, 928);
            this.panel30.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Button btXemTK;
        private System.Windows.Forms.Button btThemTK;
        private System.Windows.Forms.Button btXoaTK;
        private System.Windows.Forms.Button btSuaTK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button btCaiDatMK;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.PictureBox pictureBox15;
    }
}
