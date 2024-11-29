namespace QLQuanCaphe.FORM
{
    partial class ucDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhMuc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.IDCG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btXemDanhMuc = new System.Windows.Forms.Button();
            this.btThemDanhMuc = new System.Windows.Forms.Button();
            this.btXoaDanhMuc = new System.Windows.Forms.Button();
            this.btSuaDanhMuc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtIDDanhmuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picDanhMuc = new System.Windows.Forms.PictureBox();
            this.imageDanhMucText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel35.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel35);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.White;
            this.panel35.Controls.Add(this.label30);
            this.panel35.Location = new System.Drawing.Point(4, 2);
            this.panel35.Margin = new System.Windows.Forms.Padding(2);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(346, 81);
            this.panel35.TabIndex = 15;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(14, 26);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(302, 30);
            this.label30.TabIndex = 0;
            this.label30.Text = "DANH SÁCH DANH MỤC";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvDanhMuc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 87);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 514);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCG,
            this.NameCG,
            this.ImageCategory});
            this.dgvDanhMuc.Location = new System.Drawing.Point(2, 2);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(344, 512);
            this.dgvDanhMuc.TabIndex = 1;
            // 
            // IDCG
            // 
            this.IDCG.DataPropertyName = "ID";
            this.IDCG.FillWeight = 53.47594F;
            this.IDCG.HeaderText = "STT";
            this.IDCG.MinimumWidth = 6;
            this.IDCG.Name = "IDCG";
            this.IDCG.ReadOnly = true;
            // 
            // NameCG
            // 
            this.NameCG.DataPropertyName = "Name";
            this.NameCG.FillWeight = 146.5241F;
            this.NameCG.HeaderText = "Tên danh mục";
            this.NameCG.MinimumWidth = 6;
            this.NameCG.Name = "NameCG";
            this.NameCG.ReadOnly = true;
            // 
            // ImageCategory
            // 
            this.ImageCategory.DataPropertyName = "ImageCategory";
            this.ImageCategory.HeaderText = "Hình ảnh";
            this.ImageCategory.MinimumWidth = 6;
            this.ImageCategory.Name = "ImageCategory";
            this.ImageCategory.ReadOnly = true;
            this.ImageCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageCategory.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.picDanhMuc);
            this.panel2.Controls.Add(this.imageDanhMucText);
            this.panel2.Location = new System.Drawing.Point(350, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 599);
            this.panel2.TabIndex = 13;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btXemDanhMuc);
            this.panel14.Controls.Add(this.btThemDanhMuc);
            this.panel14.Controls.Add(this.btXoaDanhMuc);
            this.panel14.Controls.Add(this.btSuaDanhMuc);
            this.panel14.Location = new System.Drawing.Point(4, 17);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(326, 64);
            this.panel14.TabIndex = 9;
            // 
            // btXemDanhMuc
            // 
            this.btXemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemDanhMuc.Location = new System.Drawing.Point(249, 11);
            this.btXemDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.btXemDanhMuc.Name = "btXemDanhMuc";
            this.btXemDanhMuc.Size = new System.Drawing.Size(68, 41);
            this.btXemDanhMuc.TabIndex = 7;
            this.btXemDanhMuc.Text = "Làm mới";
            this.btXemDanhMuc.UseVisualStyleBackColor = true;
            this.btXemDanhMuc.Click += new System.EventHandler(this.btXemDanhMuc_Click);
            // 
            // btThemDanhMuc
            // 
            this.btThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDanhMuc.Location = new System.Drawing.Point(10, 11);
            this.btThemDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.btThemDanhMuc.Name = "btThemDanhMuc";
            this.btThemDanhMuc.Size = new System.Drawing.Size(68, 41);
            this.btThemDanhMuc.TabIndex = 4;
            this.btThemDanhMuc.Text = "Thêm";
            this.btThemDanhMuc.UseVisualStyleBackColor = true;
            this.btThemDanhMuc.Click += new System.EventHandler(this.btThemDanhMuc_Click);
            // 
            // btXoaDanhMuc
            // 
            this.btXoaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaDanhMuc.Location = new System.Drawing.Point(88, 11);
            this.btXoaDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.btXoaDanhMuc.Name = "btXoaDanhMuc";
            this.btXoaDanhMuc.Size = new System.Drawing.Size(68, 41);
            this.btXoaDanhMuc.TabIndex = 5;
            this.btXoaDanhMuc.Text = "Xóa";
            this.btXoaDanhMuc.UseVisualStyleBackColor = true;
            this.btXoaDanhMuc.Click += new System.EventHandler(this.btXoaDanhMuc_Click);
            // 
            // btSuaDanhMuc
            // 
            this.btSuaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaDanhMuc.Location = new System.Drawing.Point(170, 11);
            this.btSuaDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.btSuaDanhMuc.Name = "btSuaDanhMuc";
            this.btSuaDanhMuc.Size = new System.Drawing.Size(68, 41);
            this.btSuaDanhMuc.TabIndex = 6;
            this.btSuaDanhMuc.Text = "Sửa";
            this.btSuaDanhMuc.UseVisualStyleBackColor = true;
            this.btSuaDanhMuc.Click += new System.EventHandler(this.btSuaDanhMuc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenDanhMuc);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(22, 235);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 40);
            this.panel3.TabIndex = 19;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.BackColor = System.Drawing.Color.White;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(106, 9);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(163, 21);
            this.txtTenDanhMuc.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtIDDanhmuc);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(22, 175);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(291, 40);
            this.panel16.TabIndex = 18;
            // 
            // txtIDDanhmuc
            // 
            this.txtIDDanhmuc.BackColor = System.Drawing.Color.White;
            this.txtIDDanhmuc.Enabled = false;
            this.txtIDDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDanhmuc.Location = new System.Drawing.Point(106, 9);
            this.txtIDDanhmuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDanhmuc.Name = "txtIDDanhmuc";
            this.txtIDDanhmuc.ReadOnly = true;
            this.txtIDDanhmuc.Size = new System.Drawing.Size(163, 21);
            this.txtIDDanhmuc.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID:";
            // 
            // picDanhMuc
            // 
            this.picDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("picDanhMuc.Image")));
            this.picDanhMuc.Location = new System.Drawing.Point(24, 340);
            this.picDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.picDanhMuc.Name = "picDanhMuc";
            this.picDanhMuc.Size = new System.Drawing.Size(289, 186);
            this.picDanhMuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDanhMuc.TabIndex = 17;
            this.picDanhMuc.TabStop = false;
            // 
            // imageDanhMucText
            // 
            this.imageDanhMucText.BackColor = System.Drawing.Color.White;
            this.imageDanhMucText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageDanhMucText.Location = new System.Drawing.Point(23, 384);
            this.imageDanhMucText.Margin = new System.Windows.Forms.Padding(2);
            this.imageDanhMucText.Name = "imageDanhMucText";
            this.imageDanhMucText.ReadOnly = true;
            this.imageDanhMucText.Size = new System.Drawing.Size(288, 21);
            this.imageDanhMucText.TabIndex = 8;
            // 
            // ucDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhMuc";
            this.Size = new System.Drawing.Size(693, 610);
            this.panel1.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCG;
        private System.Windows.Forms.DataGridViewImageColumn ImageCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btXemDanhMuc;
        private System.Windows.Forms.Button btThemDanhMuc;
        private System.Windows.Forms.Button btXoaDanhMuc;
        private System.Windows.Forms.Button btSuaDanhMuc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtIDDanhmuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picDanhMuc;
        private System.Windows.Forms.TextBox imageDanhMucText;
    }
}
