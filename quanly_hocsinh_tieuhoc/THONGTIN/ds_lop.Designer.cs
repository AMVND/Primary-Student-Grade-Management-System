namespace quanly_hocsinh_tieuhoc
{
    partial class ds_lop
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
            this.txtLop = new System.Windows.Forms.TextBox();
            this.dtgvDslop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdMoi = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdCapnhat = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhoi = new System.Windows.Forms.ComboBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDslop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khối:";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(94, 64);
            this.txtLop.Multiline = true;
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(167, 24);
            this.txtLop.TabIndex = 2;
            // 
            // dtgvDslop
            // 
            this.dtgvDslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDslop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvDslop.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvDslop.Location = new System.Drawing.Point(14, 198);
            this.dtgvDslop.Name = "dtgvDslop";
            this.dtgvDslop.Size = new System.Drawing.Size(566, 253);
            this.dtgvDslop.TabIndex = 2;
            this.dtgvDslop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDslop_CellContentClick);
            this.dtgvDslop.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDslop_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ma_lop";
            this.Column1.HeaderText = "Mã lớp học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ten_lop";
            this.Column2.HeaderText = "Tên lớp học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "khoi";
            this.Column3.HeaderText = "Khối";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "user_id";
            this.Column4.HeaderText = "Giáo viên chủ nhiệm";
            this.Column4.Name = "Column4";
            // 
            // cmdMoi
            // 
            this.cmdMoi.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdMoi.Location = new System.Drawing.Point(29, 29);
            this.cmdMoi.Name = "cmdMoi";
            this.cmdMoi.Size = new System.Drawing.Size(91, 24);
            this.cmdMoi.TabIndex = 4;
            this.cmdMoi.Text = "Làm mới";
            this.cmdMoi.UseVisualStyleBackColor = false;
            this.cmdMoi.Click += new System.EventHandler(this.cmdMoi_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdThem.Location = new System.Drawing.Point(29, 73);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(91, 24);
            this.cmdThem.TabIndex = 5;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdXoa.Location = new System.Drawing.Point(153, 29);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(91, 24);
            this.cmdXoa.TabIndex = 7;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = false;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdCapnhat
            // 
            this.cmdCapnhat.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdCapnhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCapnhat.Location = new System.Drawing.Point(29, 117);
            this.cmdCapnhat.Name = "cmdCapnhat";
            this.cmdCapnhat.Size = new System.Drawing.Size(91, 24);
            this.cmdCapnhat.TabIndex = 6;
            this.cmdCapnhat.Text = "Cập nhật";
            this.cmdCapnhat.UseVisualStyleBackColor = false;
            this.cmdCapnhat.Click += new System.EventHandler(this.cmdCapnhat_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClear.Location = new System.Drawing.Point(153, 73);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(91, 24);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGVCN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKhoi);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giáo viên:";
            // 
            // txtKhoi
            // 
            this.txtKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtKhoi.FormattingEnabled = true;
            this.txtKhoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtKhoi.Location = new System.Drawing.Point(94, 103);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(167, 21);
            this.txtKhoi.TabIndex = 3;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(94, 25);
            this.txtMalop.Multiline = true;
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(167, 24);
            this.txtMalop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã lớp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdCapnhat);
            this.groupBox2.Controls.Add(this.cmdThem);
            this.groupBox2.Controls.Add(this.cmdMoi);
            this.groupBox2.Controls.Add(this.cmdClear);
            this.groupBox2.Controls.Add(this.cmdXoa);
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 171);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(94, 141);
            this.txtGVCN.Multiline = true;
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(167, 24);
            this.txtGVCN.TabIndex = 5;
            // 
            // ds_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDslop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ds_lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ds_lop_FormClosing);
            this.Load += new System.EventHandler(this.ds_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDslop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.DataGridView dtgvDslop;
        private System.Windows.Forms.Button cmdMoi;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdCapnhat;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtKhoi;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGVCN;
    }
}