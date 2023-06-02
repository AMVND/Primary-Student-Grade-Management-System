namespace quanly_hocsinh_tieuhoc
{
    partial class themtaikhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDangky = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.qlhsthDataSet1 = new quanly_hocsinh_tieuhoc.QLHSTHDataSet();
            this.dS_MONHOCTableAdapter1 = new quanly_hocsinh_tieuhoc.QLHSTHDataSetTableAdapters.DS_MONHOCTableAdapter();
            this.dS_NAMHOCTableAdapter1 = new quanly_hocsinh_tieuhoc.QLHSTHDataSetTableAdapters.DS_NAMHOCTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPhanquyen = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhsthDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(148, 43);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(222, 23);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(148, 87);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(222, 23);
            this.txtMatkhau.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.cbPhanquyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.txtTendangnhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký";
            // 
            // cmdDangky
            // 
            this.cmdDangky.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdDangky.Location = new System.Drawing.Point(99, 254);
            this.cmdDangky.Name = "cmdDangky";
            this.cmdDangky.Size = new System.Drawing.Size(129, 42);
            this.cmdDangky.TabIndex = 3;
            this.cmdDangky.Text = "Đăng ký";
            this.cmdDangky.UseVisualStyleBackColor = false;
            this.cmdDangky.Click += new System.EventHandler(this.cmdDangky_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdThoat.Location = new System.Drawing.Point(266, 254);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(129, 42);
            this.cmdThoat.TabIndex = 3;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = false;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // qlhsthDataSet1
            // 
            this.qlhsthDataSet1.DataSetName = "QLHSTHDataSet";
            this.qlhsthDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_MONHOCTableAdapter1
            // 
            this.dS_MONHOCTableAdapter1.ClearBeforeFill = true;
            // 
            // dS_NAMHOCTableAdapter1
            // 
            this.dS_NAMHOCTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phân quyền";
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
            this.cbPhanquyen.Location = new System.Drawing.Point(148, 131);
            this.cbPhanquyen.Name = "cbPhanquyen";
            this.cbPhanquyen.Size = new System.Drawing.Size(222, 24);
            this.cbPhanquyen.TabIndex = 6;
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(148, 175);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(222, 24);
            this.cbLop.TabIndex = 7;
            // 
            // themtaikhoan
            // 
            this.AcceptButton = this.cmdDangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdThoat;
            this.ClientSize = new System.Drawing.Size(481, 328);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdDangky);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "themtaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlhsthDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDangky;
        private System.Windows.Forms.Button cmdThoat;
        private QLHSTHDataSet qlhsthDataSet1;
        private QLHSTHDataSetTableAdapters.DS_MONHOCTableAdapter dS_MONHOCTableAdapter1;
        private QLHSTHDataSetTableAdapters.DS_NAMHOCTableAdapter dS_NAMHOCTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbPhanquyen;
    }
}