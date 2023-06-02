namespace quanly_hocsinh_tieuhoc
{
    partial class ds_monhoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonhoc = new System.Windows.Forms.TextBox();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdCapnhat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtgvMonhoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_mon_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiMonHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonhoc);
            this.groupBox1.Controls.Add(this.txtMamon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbLoaiMonHoc
            // 
            this.cbLoaiMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLoaiMonHoc.FormattingEnabled = true;
            this.cbLoaiMonHoc.Items.AddRange(new object[] {
            "Văn hóa",
            "Đánh giá",
            "Phẩm chất"});
            this.cbLoaiMonHoc.Location = new System.Drawing.Point(133, 82);
            this.cbLoaiMonHoc.Name = "cbLoaiMonHoc";
            this.cbLoaiMonHoc.Size = new System.Drawing.Size(236, 21);
            this.cbLoaiMonHoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại môn học: ";
            // 
            // txtMonhoc
            // 
            this.txtMonhoc.Location = new System.Drawing.Point(133, 50);
            this.txtMonhoc.Name = "txtMonhoc";
            this.txtMonhoc.Size = new System.Drawing.Size(236, 20);
            this.txtMonhoc.TabIndex = 2;
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(133, 19);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(236, 20);
            this.txtMamon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdThem.Location = new System.Drawing.Point(63, 141);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(86, 29);
            this.cmdThem.TabIndex = 3;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdXoa.Location = new System.Drawing.Point(158, 141);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(86, 29);
            this.cmdXoa.TabIndex = 4;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = false;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdCapnhat
            // 
            this.cmdCapnhat.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdCapnhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCapnhat.Location = new System.Drawing.Point(253, 141);
            this.cmdCapnhat.Name = "cmdCapnhat";
            this.cmdCapnhat.Size = new System.Drawing.Size(86, 29);
            this.cmdCapnhat.TabIndex = 5;
            this.cmdCapnhat.Text = "Cập nhật";
            this.cmdCapnhat.UseVisualStyleBackColor = false;
            this.cmdCapnhat.Click += new System.EventHandler(this.cmdCapnhat_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(348, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgvMonhoc
            // 
            this.dtgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.loai_mon_hoc,
            this.Column2});
            this.dtgvMonhoc.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvMonhoc.Location = new System.Drawing.Point(16, 176);
            this.dtgvMonhoc.Name = "dtgvMonhoc";
            this.dtgvMonhoc.Size = new System.Drawing.Size(466, 277);
            this.dtgvMonhoc.TabIndex = 2;
            this.dtgvMonhoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvMonhoc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ma_mon_hoc";
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.Name = "Column1";
            // 
            // loai_mon_hoc
            // 
            this.loai_mon_hoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loai_mon_hoc.DataPropertyName = "loai_mon_hoc";
            this.loai_mon_hoc.HeaderText = "Loại môn học";
            this.loai_mon_hoc.Name = "loai_mon_hoc";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "mon_hoc";
            this.Column2.HeaderText = "Môn học";
            this.Column2.Name = "Column2";
            // 
            // ds_monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 465);
            this.Controls.Add(this.dtgvMonhoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmdCapnhat);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ds_monhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ds_monhoc_FormClosing);
            this.Load += new System.EventHandler(this.ds_monhoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonhoc;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdCapnhat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgvMonhoc;
        private System.Windows.Forms.ComboBox cbLoaiMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_mon_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}