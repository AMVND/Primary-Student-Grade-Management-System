namespace quanly_hocsinh_tieuhoc
{
    partial class taikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taikhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.cbPhanquyen = new System.Windows.Forms.ComboBox();
            this.cmdPhanquyen = new System.Windows.Forms.Button();
            this.dtgvTaikhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(91, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(91, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phân quyền";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTaikhoan.Location = new System.Drawing.Point(192, 19);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(248, 23);
            this.txtTaikhoan.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatkhau.Location = new System.Drawing.Point(192, 66);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(248, 23);
            this.txtMatkhau.TabIndex = 2;
            // 
            // cbPhanquyen
            // 
            this.cbPhanquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhanquyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbPhanquyen.FormattingEnabled = true;
            this.cbPhanquyen.Items.AddRange(new object[] {
            "Quản trị viên",
            "Ban giám hiệu",
            "Giáo viên chủ nhiệm",
            "Giáo viên bộ môn Tiếng Anh",
            "Giáo viên bộ môn Tin",
            "Giáo viên bộ môn Mỹ Thuật",
            "Giáo viên bộ môn Âm Nhạc"});
            this.cbPhanquyen.Location = new System.Drawing.Point(191, 106);
            this.cbPhanquyen.Name = "cbPhanquyen";
            this.cbPhanquyen.Size = new System.Drawing.Size(248, 24);
            this.cbPhanquyen.TabIndex = 3;
            // 
            // cmdPhanquyen
            // 
            this.cmdPhanquyen.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPhanquyen.Location = new System.Drawing.Point(138, 32);
            this.cmdPhanquyen.Name = "cmdPhanquyen";
            this.cmdPhanquyen.Size = new System.Drawing.Size(97, 34);
            this.cmdPhanquyen.TabIndex = 5;
            this.cmdPhanquyen.Text = "Phân quyền";
            this.cmdPhanquyen.UseVisualStyleBackColor = false;
            this.cmdPhanquyen.Click += new System.EventHandler(this.cmdPhanquyen_Click);
            // 
            // dtgvTaikhoan
            // 
            this.dtgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.ma_lop});
            this.dtgvTaikhoan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvTaikhoan.Location = new System.Drawing.Point(12, 319);
            this.dtgvTaikhoan.Name = "dtgvTaikhoan";
            this.dtgvTaikhoan.Size = new System.Drawing.Size(506, 179);
            this.dtgvTaikhoan.TabIndex = 1111;
            this.dtgvTaikhoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvTaikhoan_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "user_id";
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "password";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "phan_quyen";
            this.Column3.HeaderText = "Phân quyền";
            this.Column3.Name = "Column3";
            // 
            // ma_lop
            // 
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "Lớp học";
            this.ma_lop.Name = "ma_lop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cmdPhanquyen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThem.Location = new System.Drawing.Point(257, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(91, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm tài khoản";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimkiem.Location = new System.Drawing.Point(191, 187);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(248, 23);
            this.txtTimkiem.TabIndex = 2;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(91, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1112;
            this.label5.Text = "Lớp học";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(190, 145);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(248, 24);
            this.cbLop.TabIndex = 1113;
            // 
            // taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 548);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvTaikhoan);
            this.Controls.Add(this.cbPhanquyen);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "taikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.ComboBox cbPhanquyen;
        private System.Windows.Forms.Button cmdPhanquyen;
        private System.Windows.Forms.DataGridView dtgvTaikhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLop;
    }
}