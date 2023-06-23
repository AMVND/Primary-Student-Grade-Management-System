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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                    return;
                }
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN where user_id = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    this.Hide();
                    Form main = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    main.Show();
                }

                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc password!", "Thông báo");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception) {}
        }

        //Hiển thị mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        ///Nút thoát
        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Close();
            } 
        }

        //Quên mật khẩu
        private void lblQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với nhà trường để được hỗ trợ", "Hỗ trợ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
