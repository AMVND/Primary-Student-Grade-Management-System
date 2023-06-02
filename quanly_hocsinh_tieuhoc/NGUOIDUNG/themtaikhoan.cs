using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_hocsinh_tieuhoc
{
    public partial class themtaikhoan : Form
    {
        public themtaikhoan()
        {
            InitializeComponent();
        }
        void clear_data()
        {
            txtMatkhau.Text = "";
            txtTendangnhap.Text = "";
        }

        private void cmdDangky_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa điền dữ liệu!","Thông báo");
            }
            else if (txtMatkhau.TextLength < 6)
            {
                MessageBox.Show("Độ dài mật khẩu phải hơn 6 ký tự","Thông báo");
                txtMatkhau.Text = "";
            }
            else
            {
                try
                {
                    string add = @"INSERT INTO TAI_KHOAN(user_id,password,phan_quyen,ma_lop) VALUES('" + txtTendangnhap.Text + "',N'" + txtMatkhau.Text + "',N'" + cbPhanquyen.Text + "',N'" + cbLop.Text + "')";
                    DatabaseService.DatabaseService.executeQuery(add);
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    clear_data();
                }
                catch (Exception)
                { }
            }
            
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Hide();
            else if (dialog == DialogResult.No)
            {
                //
            }
        }
    }
}
