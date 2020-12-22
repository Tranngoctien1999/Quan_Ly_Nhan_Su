namespace QL_NHANSU.GUI
{
    partial class PB
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKP = new System.Windows.Forms.Button();
            this.cbbKey = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ng_NC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.DateNC = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIconTenPhong = new System.Windows.Forms.Label();
            this.lblIconMaPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.BtnDelete,
            this.btnSave,
            this.btnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(572, 63);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(300, 32);
            this.toolStrip2.TabIndex = 95;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::QL_NHANSU.Properties.Resources.Add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 29);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::QL_NHANSU.Properties.Resources._010_x_128;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(68, 29);
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::QL_NHANSU.Properties.Resources._04_download_128;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 29);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::QL_NHANSU.Properties.Resources.Cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 29);
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKP);
            this.groupBox2.Controls.Add(this.cbbKey);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(45, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(476, 127);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnKP
            // 
            this.btnKP.Location = new System.Drawing.Point(333, 94);
            this.btnKP.Name = "btnKP";
            this.btnKP.Size = new System.Drawing.Size(93, 28);
            this.btnKP.TabIndex = 10;
            this.btnKP.Text = "Khôi phục";
            this.btnKP.UseVisualStyleBackColor = true;
            this.btnKP.Click += new System.EventHandler(this.btnKP_Click);
            // 
            // cbbKey
            // 
            this.cbbKey.FormattingEnabled = true;
            this.cbbKey.Items.AddRange(new object[] {
            "Mã PB",
            "Tên PB"});
            this.cbbKey.Location = new System.Drawing.Point(173, 28);
            this.cbbKey.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKey.Name = "cbbKey";
            this.cbbKey.Size = new System.Drawing.Size(240, 24);
            this.cbbKey.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(233, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(173, 66);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(240, 22);
            this.txtKey.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nội Dung Tìm:";
            // 
            // dgvPB
            // 
            this.dgvPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPB,
            this.MaTP,
            this.Ng_NC,
            this.SoNV});
            this.dgvPB.Location = new System.Drawing.Point(572, 132);
            this.dgvPB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPB.MultiSelect = false;
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.ReadOnly = true;
            this.dgvPB.RowHeadersWidth = 51;
            this.dgvPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPB.Size = new System.Drawing.Size(680, 340);
            this.dgvPB.TabIndex = 93;
            this.dgvPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellClick);
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.HeaderText = "MaPB";
            this.MaPB.MinimumWidth = 6;
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            this.MaPB.Width = 125;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.HeaderText = "TenPB";
            this.TenPB.MinimumWidth = 6;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            this.TenPB.Width = 126;
            // 
            // MaTP
            // 
            this.MaTP.DataPropertyName = "MaTP";
            this.MaTP.HeaderText = "MaTP";
            this.MaTP.MinimumWidth = 6;
            this.MaTP.Name = "MaTP";
            this.MaTP.ReadOnly = true;
            this.MaTP.Width = 125;
            // 
            // Ng_NC
            // 
            this.Ng_NC.DataPropertyName = "Ng_NC";
            this.Ng_NC.HeaderText = "Ng_NC";
            this.Ng_NC.MinimumWidth = 6;
            this.Ng_NC.Name = "Ng_NC";
            this.Ng_NC.ReadOnly = true;
            this.Ng_NC.Width = 126;
            // 
            // SoNV
            // 
            this.SoNV.DataPropertyName = "SoNV";
            this.SoNV.HeaderText = "SoNV";
            this.SoNV.MinimumWidth = 6;
            this.SoNV.Name = "SoNV";
            this.SoNV.ReadOnly = true;
            this.SoNV.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTP);
            this.groupBox1.Controls.Add(this.DateNC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblIconTenPhong);
            this.groupBox1.Controls.Add(this.lblIconMaPhong);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(476, 236);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Ban";
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(173, 167);
            this.cbbTP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(240, 24);
            this.cbbTP.TabIndex = 11;
            // 
            // DateNC
            // 
            this.DateNC.Location = new System.Drawing.Point(173, 204);
            this.DateNC.Margin = new System.Windows.Forms.Padding(4);
            this.DateNC.Name = "DateNC";
            this.DateNC.Size = new System.Drawing.Size(240, 22);
            this.DateNC.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày NC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trưởng phòng";
            // 
            // txtSoNV
            // 
            this.txtSoNV.Location = new System.Drawing.Point(173, 129);
            this.txtSoNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNV.Name = "txtSoNV";
            this.txtSoNV.Size = new System.Drawing.Size(240, 22);
            this.txtSoNV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số NV:";
            // 
            // lblIconTenPhong
            // 
            this.lblIconTenPhong.Location = new System.Drawing.Point(423, 86);
            this.lblIconTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconTenPhong.Name = "lblIconTenPhong";
            this.lblIconTenPhong.Size = new System.Drawing.Size(25, 16);
            this.lblIconTenPhong.TabIndex = 4;
            this.lblIconTenPhong.Visible = false;
            // 
            // lblIconMaPhong
            // 
            this.lblIconMaPhong.Location = new System.Drawing.Point(424, 37);
            this.lblIconMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIconMaPhong.Name = "lblIconMaPhong";
            this.lblIconMaPhong.Size = new System.Drawing.Size(25, 16);
            this.lblIconMaPhong.TabIndex = 4;
            this.lblIconMaPhong.Visible = false;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(173, 82);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(240, 22);
            this.txtTenPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng Ban:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(173, 33);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(240, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng Ban:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.dựÁnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // dựÁnToolStripMenuItem
            // 
            this.dựÁnToolStripMenuItem.Name = "dựÁnToolStripMenuItem";
            this.dựÁnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dựÁnToolStripMenuItem.Text = "Dự án";
            this.dựÁnToolStripMenuItem.Click += new System.EventHandler(this.dựÁnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // PB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 487);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPB);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PB";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.DateTimePicker DateNC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIconTenPhong;
        private System.Windows.Forms.Label lblIconMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ng_NC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNV;
        private System.Windows.Forms.Button btnKP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dựÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}
