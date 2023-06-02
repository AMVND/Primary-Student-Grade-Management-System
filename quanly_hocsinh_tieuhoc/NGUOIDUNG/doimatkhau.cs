using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanly_hocsinh_tieuhoc
{
    public partial class doimatkhau : Form
    {
        string user_id = "", password = "", phan_quyen = "";
        public doimatkhau()
        {
            InitializeComponent();
        }
        public doimatkhau(string user_id, string password, string phan_quyen)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            
            txtTendangnhap.Enabled = false;
            switch (phan_quyen)
            {
                case "1":
                    txtTendangnhap.Text = user_id;
                    break;
                case "2":
                    txtTendangnhap.Text = user_id;
                    break;
                case "3":
                    txtTendangnhap.Text = user_id;
                    break;
                case "4":
                    txtTendangnhap.Text = user_id;
                    break;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            string update = "update TAI_KHOAN set password='" + txtMatkhaumoi.Text + "' where(user_id=N'" + txtTendangnhap.Text + "' and password='" + txtMatkhaucu.Text + "')";
            string ten = txtTendangnhap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtMatkhaucu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtMatkhaumoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtXacnhan.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if ((txtMatkhaumoi.Text == txtXacnhan.Text) && txtMatkhaucu.Text == password )
                            {
                                try
                                {
                                    DatabaseService.DatabaseService.executeQuery(update);
                                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                    this.Close();
                                }
                                catch (Exception)
                                { }
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }
    }
}
