namespace quanly_hocsinh_tieuhoc
{
    partial class nhapdiemthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhapdiemthi));
            this.dtgvNhapdiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMadiem = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.cmdXemdiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiemtb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuCSDL = new System.Windows.Forms.Button();
            this.btnNhapExcel = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMonhoc = new System.Windows.Forms.TextBox();
            this.txtTenlop = new System.Windows.Forms.ComboBox();
            this.txtMahocsinh = new System.Windows.Forms.ComboBox();
            this.cbDiem1 = new System.Windows.Forms.ComboBox();
            this.cbDiem2 = new System.Windows.Forms.ComboBox();
            this.cbDiemTB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapdiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvNhapdiem
            // 
            this.dtgvNhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhapdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtgvNhapdiem.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvNhapdiem.Location = new System.Drawing.Point(12, 232);
            this.dtgvNhapdiem.Name = "dtgvNhapdiem";
            this.dtgvNhapdiem.Size = new System.Drawing.Size(1067, 427);
            this.dtgvNhapdiem.TabIndex = 11111;
            this.dtgvNhapdiem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvNhapdiem_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ma_diem_thi";
            this.Column1.HeaderText = "Mã điểm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ten_lop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ma_hoc_sinh";
            this.Column3.HeaderText = "Mã học sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ho_ten";
            this.Column4.HeaderText = "Họ tên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "ma_mon_hoc";
            this.Column5.HeaderText = "Mã môn học";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "mon_hoc";
            this.Column6.HeaderText = "Môn học";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "nam_hoc";
            this.Column7.HeaderText = "Năm học";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "diem_hk1";
            this.Column8.HeaderText = "Điểm HK1";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "diem_hk2";
            this.Column9.HeaderText = "Điểm HK2";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "diem_tb";
            this.Column10.HeaderText = "Điểm TB môn";
            this.Column10.Name = "Column10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ và Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(338, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Môn học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(336, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Năm học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(336, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Điểm HK1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(336, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Điểm HK2";
            // 
            // txtMadiem
            // 
            this.txtMadiem.Enabled = false;
            this.txtMadiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMadiem.Location = new System.Drawing.Point(112, 24);
            this.txtMadiem.Name = "txtMadiem";
            this.txtMadiem.Size = new System.Drawing.Size(161, 23);
            this.txtMadiem.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHoten.Location = new System.Drawing.Point(112, 146);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(161, 23);
            this.txtHoten.TabIndex = 4;
            // 
            // txtDiem1
            // 
            this.txtDiem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiem1.Location = new System.Drawing.Point(424, 107);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(161, 23);
            this.txtDiem1.TabIndex = 8;
            this.txtDiem1.TextChanged += new System.EventHandler(this.txtDiem1_TextChanged);
            // 
            // txtDiem2
            // 
            this.txtDiem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiem2.Location = new System.Drawing.Point(424, 148);
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(161, 23);
            this.txtDiem2.TabIndex = 9;
            this.txtDiem2.TextChanged += new System.EventHandler(this.txtDiem2_TextChanged);
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdThem.Location = new System.Drawing.Point(12, 123);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(98, 37);
            this.cmdThem.TabIndex = 10;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdXoa.Location = new System.Drawing.Point(126, 123);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(98, 37);
            this.cmdXoa.TabIndex = 12;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = false;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClear.Location = new System.Drawing.Point(12, 72);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(98, 37);
            this.cmdClear.TabIndex = 13;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdThoat.Location = new System.Drawing.Point(126, 72);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(98, 37);
            this.cmdThoat.TabIndex = 14;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = false;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdXemdiem
            // 
            this.cmdXemdiem.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdXemdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXemdiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdXemdiem.Location = new System.Drawing.Point(12, 22);
            this.cmdXemdiem.Name = "cmdXemdiem";
            this.cmdXemdiem.Size = new System.Drawing.Size(212, 36);
            this.cmdXemdiem.TabIndex = 15;
            this.cmdXemdiem.Text = "Xem bảng điểm";
            this.cmdXemdiem.UseVisualStyleBackColor = false;
            this.cmdXemdiem.Click += new System.EventHandler(this.cmdXemdiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(336, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Điểm TB";
            // 
            // txtDiemtb
            // 
            this.txtDiemtb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiemtb.Location = new System.Drawing.Point(424, 189);
            this.txtDiemtb.Name = "txtDiemtb";
            this.txtDiemtb.Size = new System.Drawing.Size(161, 23);
            this.txtDiemtb.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuuCSDL);
            this.groupBox1.Controls.Add(this.btnNhapExcel);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.cmdThem);
            this.groupBox1.Controls.Add(this.cmdSua);
            this.groupBox1.Controls.Add(this.cmdXoa);
            this.groupBox1.Controls.Add(this.cmdXemdiem);
            this.groupBox1.Controls.Add(this.cmdClear);
            this.groupBox1.Controls.Add(this.cmdThoat);
            this.groupBox1.Location = new System.Drawing.Point(608, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 178);
            this.groupBox1.TabIndex = 11112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // btnLuuCSDL
            // 
            this.btnLuuCSDL.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLuuCSDL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuuCSDL.Location = new System.Drawing.Point(361, 125);
            this.btnLuuCSDL.Name = "btnLuuCSDL";
            this.btnLuuCSDL.Size = new System.Drawing.Size(93, 35);
            this.btnLuuCSDL.TabIndex = 18;
            this.btnLuuCSDL.Text = "Lưu CSDL";
            this.btnLuuCSDL.UseVisualStyleBackColor = false;
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNhapExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhapExcel.Location = new System.Drawing.Point(361, 74);
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.Size = new System.Drawing.Size(93, 35);
            this.btnNhapExcel.TabIndex = 17;
            this.btnNhapExcel.Text = "Nhập Excel";
            this.btnNhapExcel.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXuatExcel.Location = new System.Drawing.Point(361, 23);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(93, 35);
            this.btnXuatExcel.TabIndex = 16;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSua.Location = new System.Drawing.Point(248, 23);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(93, 35);
            this.cmdSua.TabIndex = 11;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = false;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(424, 65);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(161, 24);
            this.cbNamHoc.TabIndex = 11113;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(112, 186);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(161, 24);
            this.cbMonHoc.TabIndex = 11114;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // txtMonhoc
            // 
            this.txtMonhoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMonhoc.Location = new System.Drawing.Point(424, 24);
            this.txtMonhoc.Name = "txtMonhoc";
            this.txtMonhoc.Size = new System.Drawing.Size(161, 23);
            this.txtMonhoc.TabIndex = 6;
            // 
            // txtTenlop
            // 
            this.txtTenlop.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTenlop.FormattingEnabled = true;
            this.txtTenlop.Location = new System.Drawing.Point(112, 64);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(161, 24);
            this.txtTenlop.TabIndex = 11115;
            this.txtTenlop.SelectedIndexChanged += new System.EventHandler(this.txtTenlop_SelectedIndexChanged);
            // 
            // txtMahocsinh
            // 
            this.txtMahocsinh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMahocsinh.FormattingEnabled = true;
            this.txtMahocsinh.Location = new System.Drawing.Point(112, 105);
            this.txtMahocsinh.Name = "txtMahocsinh";
            this.txtMahocsinh.Size = new System.Drawing.Size(161, 24);
            this.txtMahocsinh.TabIndex = 11116;
            this.txtMahocsinh.SelectedIndexChanged += new System.EventHandler(this.txtMahocsinh_SelectedIndexChanged);
            // 
            // cbDiem1
            // 
            this.cbDiem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiem1.FormattingEnabled = true;
            this.cbDiem1.Items.AddRange(new object[] {
            "T",
            "H",
            "C"});
            this.cbDiem1.Location = new System.Drawing.Point(424, 105);
            this.cbDiem1.Name = "cbDiem1";
            this.cbDiem1.Size = new System.Drawing.Size(161, 24);
            this.cbDiem1.TabIndex = 11117;
            // 
            // cbDiem2
            // 
            this.cbDiem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiem2.FormattingEnabled = true;
            this.cbDiem2.Items.AddRange(new object[] {
            "T",
            "H",
            "C"});
            this.cbDiem2.Location = new System.Drawing.Point(424, 149);
            this.cbDiem2.Name = "cbDiem2";
            this.cbDiem2.Size = new System.Drawing.Size(161, 24);
            this.cbDiem2.TabIndex = 11118;
            // 
            // cbDiemTB
            // 
            this.cbDiemTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiemTB.FormattingEnabled = true;
            this.cbDiemTB.Items.AddRange(new object[] {
            "T",
            "H",
            "C"});
            this.cbDiemTB.Location = new System.Drawing.Point(424, 189);
            this.cbDiemTB.Name = "cbDiemTB";
            this.cbDiemTB.Size = new System.Drawing.Size(161, 24);
            this.cbDiemTB.TabIndex = 11119;
            // 
            // nhapdiemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1091, 671);
            this.Controls.Add(this.cbDiemTB);
            this.Controls.Add(this.cbDiem2);
            this.Controls.Add(this.cbDiem1);
            this.Controls.Add(this.txtMahocsinh);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDiemtb);
            this.Controls.Add(this.txtDiem2);
            this.Controls.Add(this.txtDiem1);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMonhoc);
            this.Controls.Add(this.txtMadiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvNhapdiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nhapdiemthi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nhapdiemthi_FormClosing);
            this.Load += new System.EventHandler(this.nhapdiemthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapdiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhapdiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMadiem;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtDiem2;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.Button cmdXemdiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiemtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.TextBox txtMonhoc;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.ComboBox txtTenlop;
        private System.Windows.Forms.ComboBox txtMahocsinh;
        private System.Windows.Forms.Button btnLuuCSDL;
        private System.Windows.Forms.Button btnNhapExcel;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.ComboBox cbDiem1;
        private System.Windows.Forms.ComboBox cbDiem2;
        private System.Windows.Forms.ComboBox cbDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}