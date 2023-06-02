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
    public partial class taikhoan : Form
    {
        public taikhoan()
        {
            InitializeComponent();
        }

        private void taikhoan_Load(object sender, EventArgs e)
        {
            string showtaikhoan = "SELECT * FROM TAI_KHOAN order by ma_lop";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showtaikhoan);
            dtgvTaikhoan.DataSource = dt;
            ///
            DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from TAI_KHOAN");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ma_lop";
            cbLop.ValueMember = "ma_lop";
        }
        void load_data()
        {
            string showtaikhoan = "SELECT * FROM TAI_KHOAN order by ma_lop";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showtaikhoan);
            dtgvTaikhoan.DataSource = dt;
        }

        private void cmdPhanquyen_Click(object sender, EventArgs e)
        {
            string _PhanQuyen = "";
            if (cbPhanquyen.Text == "Quản Trị")
                _PhanQuyen = "1";
            if (cbPhanquyen.Text == "Ban giám hiệu")
                _PhanQuyen = "2";
            if (cbPhanquyen.Text == "Giáo viên chủ nhiệm")
                _PhanQuyen = "3";
            if (cbPhanquyen.Text == "Giáo viên bộ môn Tiếng Anh")
                _PhanQuyen = "4";
            if (cbPhanquyen.Text == "Giáo viên bộ môn Tin")
                _PhanQuyen = "5";
            if (cbPhanquyen.Text == "Giáo viên bộ môn Mỹ Thuật")
                _PhanQuyen = "6";
            if (cbPhanquyen.Text == "Giáo viên bộ môn Âm Nhạc")
                _PhanQuyen = "7";
            string update = "update TAI_KHOAN set phan_quyen = N'" + _PhanQuyen + "' , ma_lop = '"+cbLop.Text+"' where (user_id = N'" + txtTaikhoan.Text + "')";
            DatabaseService.DatabaseService.executeQuery(update);
            load_data();
        }

        private void dtgvTaikhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvTaikhoan.Rows[e.RowIndex];
                txtTaikhoan.Text = row.Cells[0].Value.ToString();
                txtMatkhau.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchname = "Select * from TAI_KHOAN where user_id like N'%" + txtTimkiem.Text + "%'";
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable(searchname);
                dtgvTaikhoan.DataSource = dt;
            }
            catch (Exception)
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themtaikhoan themmoi = new themtaikhoan();
            themmoi.Show();
        }
    }
}
