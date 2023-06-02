namespace quanly_hocsinh_tieuhoc
{
    partial class frmXuatNLPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatNLPC));
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtXuat2 = new System.Windows.Forms.RadioButton();
            this.rbtXuat1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            this.label3.UseMnemonic = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXuatExcel.Location = new System.Drawing.Point(141, 134);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(98, 37);
            this.btnXuatExcel.TabIndex = 17;
            this.btnXuatExcel.Text = "Xác nhận";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // rbtXuat2
            // 
            this.rbtXuat2.AutoSize = true;
            this.rbtXuat2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtXuat2.Location = new System.Drawing.Point(36, 93);
            this.rbtXuat2.Name = "rbtXuat2";
            this.rbtXuat2.Size = new System.Drawing.Size(107, 23);
            this.rbtXuat2.TabIndex = 15;
            this.rbtXuat2.TabStop = true;
            this.rbtXuat2.Text = "Chỉ xuất môn";
            this.rbtXuat2.UseVisualStyleBackColor = true;
            // 
            // rbtXuat1
            // 
            this.rbtXuat1.AutoSize = true;
            this.rbtXuat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtXuat1.Location = new System.Drawing.Point(36, 58);
            this.rbtXuat1.Name = "rbtXuat1";
            this.rbtXuat1.Size = new System.Drawing.Size(246, 23);
            this.rbtXuat1.TabIndex = 14;
            this.rbtXuat1.TabStop = true;
            this.rbtXuat1.Text = "Toàn bộ năng lực phẩm chất của lớp";
            this.rbtXuat1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bạn muốn xuất file Excel ?";
            // 
            // frmXuatNLPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtXuat2);
            this.Controls.Add(this.rbtXuat1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatNLPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Năng lực phẩm chất";
            this.Load += new System.EventHandler(this.frmXuatNLPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtXuat2;
        private System.Windows.Forms.RadioButton rbtXuat1;
        private System.Windows.Forms.Label label1;
    }
}