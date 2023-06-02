namespace quanly_hocsinh_tieuhoc
{
    partial class namhoc
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
            this.txtManam = new System.Windows.Forms.TextBox();
            this.txtNamhoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvNamhoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdCapnhat = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNamhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm học";
            // 
            // txtManam
            // 
            this.txtManam.Location = new System.Drawing.Point(109, 20);
            this.txtManam.Name = "txtManam";
            this.txtManam.Size = new System.Drawing.Size(207, 20);
            this.txtManam.TabIndex = 1;
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(109, 61);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(207, 20);
            this.txtNamhoc.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNamhoc);
            this.groupBox1.Controls.Add(this.txtManam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dtgvNamhoc
            // 
            this.dtgvNamhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNamhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvNamhoc.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvNamhoc.Location = new System.Drawing.Point(19, 149);
            this.dtgvNamhoc.Name = "dtgvNamhoc";
            this.dtgvNamhoc.Size = new System.Drawing.Size(421, 177);
            this.dtgvNamhoc.TabIndex = 4;
            this.dtgvNamhoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvNamhoc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ma_nam_hoc";
            this.Column1.HeaderText = "Mã năm học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nam_hoc";
            this.Column2.HeaderText = "Năm học";
            this.Column2.Name = "Column2";
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdThem.Location = new System.Drawing.Point(55, 115);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(73, 31);
            this.cmdThem.TabIndex = 3;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdXoa.Location = new System.Drawing.Point(145, 115);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(73, 31);
            this.cmdXoa.TabIndex = 4;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = false;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdCapnhat
            // 
            this.cmdCapnhat.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdCapnhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCapnhat.Location = new System.Drawing.Point(235, 115);
            this.cmdCapnhat.Name = "cmdCapnhat";
            this.cmdCapnhat.Size = new System.Drawing.Size(73, 31);
            this.cmdCapnhat.TabIndex = 5;
            this.cmdCapnhat.Text = "Cập nhật";
            this.cmdCapnhat.UseVisualStyleBackColor = false;
            this.cmdCapnhat.Click += new System.EventHandler(this.cmdCapnhat_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClear.Location = new System.Drawing.Point(325, 115);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(73, 31);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // namhoc
            // 
            this.AcceptButton = this.cmdThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCapnhat);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.dtgvNamhoc);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "namhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý năm học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.namhoc_FormClosing);
            this.Load += new System.EventHandler(this.namhoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNamhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManam;
        private System.Windows.Forms.TextBox txtNamhoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvNamhoc;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdCapnhat;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}