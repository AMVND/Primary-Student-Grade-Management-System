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
    public partial class frmMain : Form
    {
        string user_id = "", password = "", phan_quyen = "", ma_lop="";
        private bool isCollapse;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string user_id, string password, string phan_quyen, string ma_lop)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
            this.ma_lop = ma_lop;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        ///HỌC SINH
        private void timerHocSinh_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panelHocSinh.Height += 10;
                if(panelHocSinh.Size == panelHocSinh.MaximumSize)
                {
                    timerHocSinh.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panelHocSinh.Height -= 10;
                if (panelHocSinh.Size == panelHocSinh.MinimumSize)
                {
                    timerHocSinh.Stop();
                    isCollapse = true;
                }
            }
        }
        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            timerHocSinh.Start();
        }
        ///Submenu HỌC SINH

        private void btnHocSinhTT_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN WHERE phan_quyen = '"+phan_quyen.ToString()+"'");
                {
                    Form dshocsinh = new ds_hocsinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    openChildForm(dshocsinh);
                }
            }
            catch (Exception) { }
        }
        private void btnHocSinhDiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN");
                {
                    Form nhapdiem = new nhapdiemthi(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    openChildForm(nhapdiem);
                }
            }
            catch (Exception) { }
        }
        private void btnNLPC_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN");
                {
                    Form nhapnlpc = new nanglucphamchat(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    openChildForm(nhapnlpc);
                }
            }
            catch (Exception) { }
        }



        ///THÔNG TIN
        private void timerThongTin_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panelThongTin.Height += 10;
                if (panelThongTin.Size == panelThongTin.MaximumSize)
                {
                    timerThongTin.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panelThongTin.Height -= 10;
                if (panelThongTin.Size == panelThongTin.MinimumSize)
                {
                    timerThongTin.Stop();
                    isCollapse = true;
                }
            }
        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            timerThongTin.Start();
        }
        ///Submenu THÔNG TIN

        private void btnThongTinNH_Click(object sender, EventArgs e)
        {
            openChildForm(new namhoc());
        }

        private void btnThongTinLop_Click(object sender, EventArgs e)
        {
            openChildForm(new ds_lop());
        }

        private void btnThongTinMon_Click(object sender, EventArgs e)
        {
            openChildForm(new ds_monhoc());
        }


        ///BÁO CÁO
        private void timerBaoCao_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panelBaoCao.Height += 10;
                if (panelBaoCao.Size == panelBaoCao.MaximumSize)
                {
                    timerBaoCao.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panelBaoCao.Height -= 10;
                if (panelBaoCao.Size == panelBaoCao.MinimumSize)
                {
                    timerBaoCao.Stop();
                    isCollapse = true;
                }
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            timerBaoCao.Start();
        }
        ///Submenu BÁO CÁO


        private void btnBaoCaoTTHS_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBC_HS());
        }

        private void btnBaoCaoDiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN");
                {
                    Form BCDiem = new frmBC_Diem(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    openChildForm(BCDiem);
                }
            }
            catch (Exception) { }
        }

        private void btnBCNLPC_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable("Select * from TAI_KHOAN");
                {
                    Form BCnlpc = new frmBC_NLPC(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    openChildForm(BCnlpc);
                }
            }
            catch (Exception) { }
        }

        private void btnBaoCaoTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHocBa());
        }

        ///NGƯỜI DÙNG
        private void timerNguoiDung_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panelNguoiDung.Height += 10;
                if (panelNguoiDung.Size == panelNguoiDung.MaximumSize)
                {
                    timerNguoiDung.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panelNguoiDung.Height -= 10;
                if (panelNguoiDung.Size == panelNguoiDung.MinimumSize)
                {
                    timerNguoiDung.Stop();
                    isCollapse = true;
                }
            }
        }
        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            timerNguoiDung.Start();
        }

        ///Submenu NGƯỜI DÙNG

        private void btnNguoiDungMK_Click(object sender, EventArgs e)
        {
            openChildForm(new doimatkhau(user_id,password, phan_quyen));
        }
        //Phân quyền
        private void frmMain_Load(object sender, EventArgs e)
        {
            switch (phan_quyen)
            {
                case "1":
                    lbl1.Text = "Quyền ban giám hiệu";
                    lbl2.Text = user_id;
                    break;
                case "2":
                    lbl1.Text = "Quyền giáo viên chủ nhiệm";
                    lbl2.Text = user_id;
                    btnNguoiDungTK.Enabled = false;
                    break;
                case "3":
                    lbl1.Text = "Quyền giáo viên bộ môn";
                    lbl2.Text = user_id;
                    btnNguoiDungTK.Enabled = false;
                    break;
                case "4":
                    lbl1.Text = "Quyền quản trị";
                    lbl2.Text = user_id;
                    break;
            }
        }

        private void btnNguoiDungTK_Click(object sender, EventArgs e)
        {
            openChildForm(new taikhoan());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                login fm = new login();
                fm.Show();
            }
        }
    }
}
