using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_hocsinh_tieuhoc
{
    public partial class nhapdiemthi : Form
    {
        string monhoc;
        string lophoc;
        string loaimonhoc;
        string mahocsinh;
        string tenhocsinh;
        string user_id = "", password = "", phan_quyen = "";

        public nhapdiemthi()
        {
            InitializeComponent();
        }
        public nhapdiemthi(string user_id, string password, string phan_quyen)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
        }

        private void nhapdiemthi_Load(object sender, EventArgs e)
        {
            if (phan_quyen == "1")
            {
                cmdSua.Enabled = true;
            }
            if (phan_quyen == "2")
            {
                cmdSua.Enabled = true;
            }
            else
            {
                cmdSua.Enabled = false;
                cmdSua.BackColor = Color.Gray;
            }
            string showDslop = "SELECT * FROM DIEM_THI";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showDslop);
            dtgvNhapdiem.DataSource = dt;
            //////////
            DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            txtTenlop.DataSource = cblop;
            txtTenlop.DisplayMember = "ma_lop";
            txtTenlop.ValueMember = "ma_lop";
            /////////////////////////
            DataTable cbmahocsinh = DatabaseService.DatabaseService.getDataTable("select * from HOC_SINH");
            txtMahocsinh.DataSource = cbmahocsinh;
            txtMahocsinh.DisplayMember = "ma_hoc_sinh";
            txtMahocsinh.ValueMember = "ma_hoc_sinh";
            ////////
            DataTable cbnam = DatabaseService.DatabaseService.getDataTable("select * from DS_NAMHOC");
            cbNamHoc.DataSource = cbnam;
            cbNamHoc.DisplayMember = "nam_hoc";
            cbNamHoc.ValueMember = "ma_nam_hoc";
            //////////////////////////////////////
            ///
            DataTable cbmamon = DatabaseService.DatabaseService.getDataTable("select * from DS_MONHOC");
            cbMonHoc.DataSource = cbmamon;
            cbMonHoc.DisplayMember = "ma_mon_hoc";
            cbMonHoc.ValueMember = "ma_mon_hoc";
            //////////////////////////////////////


        }
        void Load_data()
        {
            string sql = "select * from DIEM_THI";
            dtgvNhapdiem.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }
        void clear_data()
        {
            txtMadiem.Text = "";
            txtTenlop.Text = "";
            txtMahocsinh.Text = "";
            txtHoten.Text = "";
            cbMonHoc.Text = "";
            txtMonhoc.Text = "";
            cbNamHoc.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
        }

        private void dtgvNhapdiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvNhapdiem.Rows[e.RowIndex];
                txtMadiem.Text = row.Cells[0].Value.ToString();
                txtTenlop.Text = row.Cells[1].Value.ToString();
                txtMahocsinh.Text = row.Cells[2].Value.ToString();
                txtHoten.Text = row.Cells[3].Value.ToString();
                cbMonHoc.Text = row.Cells[4].Value.ToString();
                txtMonhoc.Text = row.Cells[5].Value.ToString();
                cbNamHoc.Text = row.Cells[6].Value.ToString();
                txtDiem1.Text = row.Cells[7].Value.ToString();
                txtDiem2.Text = row.Cells[8].Value.ToString();
                txtDiemtb.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmdXemdiem_Click(object sender, EventArgs e)
        {
            diemthi xemdiem = new diemthi();
            xemdiem.Show();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (loaimonhoc == "Văn hóa")
            {
                try
                {
                    string add = @"INSERT INTO DIEM_THI(ten_lop,ma_hoc_sinh,ho_ten,ma_mon_hoc,mon_hoc,nam_hoc,diem_hk1,diem_hk2,diem_tb) VALUES(N'" + txtTenlop.Text + "',N'" + txtMahocsinh.Text + "',N'" + txtHoten.Text + "',N'" + cbMonHoc.Text + "',N'" + txtMonhoc.Text + "',N'" + cbNamHoc.Text + "',N'" + float.Parse(txtDiem1.Text) + "',N'" + float.Parse(txtDiem2.Text) + "','" + float.Parse(txtDiemtb.Text) + "')";
                    DatabaseService.DatabaseService.executeQuery(add);
                    Load_data();
                    clear_data();
                }
                catch
                {
                    MessageBox.Show("Chưa nhập đúng định dạng điểm");
                    clear_data();
                }
            }
            if (loaimonhoc == "Đánh giá")
            {
                try
                {
                    string add = @"INSERT INTO DIEM_THI(ten_lop,ma_hoc_sinh,ho_ten,ma_mon_hoc,mon_hoc,nam_hoc,diem_hk1,diem_hk2,diem_tb) VALUES(N'" + txtTenlop.Text + "',N'" + txtMahocsinh.Text + "',N'" + txtHoten.Text + "',N'" + cbMonHoc.Text + "',N'" + txtMonhoc.Text + "',N'" + cbNamHoc.Text + "',N'" + cbDiem1.Text + "',N'" + cbDiem2.Text + "','" + cbDiemTB.Text + "')";
                    DatabaseService.DatabaseService.executeQuery(add);
                    Load_data();
                    clear_data();
                }
               catch
                {
                    MessageBox.Show("Chưa nhập đúng định dạng điểm");
                    clear_data();
                }
            }
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            int r = dtgvNhapdiem.CurrentCell.RowIndex;
            string ID = dtgvNhapdiem.Rows[r].Cells[0].Value.ToString();
            string UpdateNhapdiem = "UPDATE DIEM_THI set ma_diem_thi=N'" + txtMadiem.Text + "',ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + txtDiem1.Text + "',diem_hk2='" + txtDiem2.Text + "',diem_tb ='" + txtDiemtb.Text + "' WHERE ma_diem_thi='" + ID + "'";

            string UpdateNhapdiemChu = "UPDATE DIEM_THI set ma_diem_thi=N'" + txtMadiem.Text + "',ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + cbDiem1.Text + "',diem_hk2='" + cbDiem2.Text + "',diem_tb ='" + cbDiemTB.Text + "' WHERE ma_diem_thi='" + ID + "'";

            try
            {
                if (loaimonhoc == "Văn hóa")
                {
                    DatabaseService.DatabaseService.executeQuery(UpdateNhapdiem);
                    Load_data();
                    clear_data();
                }
                if (loaimonhoc == "Đánh giá")
                {
                    DatabaseService.DatabaseService.executeQuery(UpdateNhapdiemChu);
                    Load_data();
                    clear_data();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể cập nhật!", "Thông báo");
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvNhapdiem.CurrentCell.RowIndex;
            string ID = dtgvNhapdiem.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM DIEM_THI WHERE ma_diem_thi='" + ID + "'";
            if (MessageBox.Show("Bạn có muốn Xóa hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                try
                {
                    DatabaseService.DatabaseService.executeQuery(delete);
                    Load_data();
                    clear_data();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Không xóa được!", "Thông báo");
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtMadiem.Text = "";
            txtTenlop.Text = "";
            txtMahocsinh.Text = "";
            txtHoten.Text = "";
            cbMonHoc.Text = "";
            txtMonhoc.Text = "";
            cbNamHoc.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhapdiemthi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không ?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select * from DS_MONHOC WHERE ma_mon_hoc = '" + cbMonHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                monhoc = dr["mon_hoc"].ToString();
                loaimonhoc = dr["loai_mon_hoc"].ToString();
                txtMonhoc.Text = monhoc;
                if (loaimonhoc == "Văn hóa")
                {
                    txtDiem1.Visible = true;
                    cbDiem1.Visible = false;
                    ///
                    txtDiem2.Visible = true;
                    cbDiem2.Visible = false;
                    ///
                    txtDiemtb.Visible = true;
                    cbDiemTB.Visible = false;
                }
                if (loaimonhoc == "Đánh giá")
                {
                    txtDiem1.Visible = false;
                    cbDiem1.Visible = true;
                    ///
                    txtDiem2.Visible = false;
                    cbDiem2.Visible = true;
                    ///
                    txtDiemtb.Visible = false;
                    cbDiemTB.Visible = true;
                }
            }

        }

        private void txtTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select * from HOC_SINH WHERE ma_lop = '" + txtTenlop.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                mahocsinh = dr["ma_hoc_sinh"].ToString();
                lophoc = dr["ma_lop"].ToString();
                txtMahocsinh.Text = mahocsinh;
            }
        }

        private void txtMahocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select * from HOC_SINH WHERE ma_hoc_sinh = '" + txtMahocsinh.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tenhocsinh = dr["ho_ten"].ToString();
                txtHoten.Text = tenhocsinh;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            frmXuatDiem xd = new frmXuatDiem(monhoc, lophoc);
            xd.Show();
        }

        private void txtDiem1_TextChanged(object sender, EventArgs e)
        {
            if (loaimonhoc == "Đánh giá")
            {
                cbDiemTB.Text = cbDiem2.Text;
            }
        }

        private void txtDiem2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaimonhoc == "Văn hóa")
                {
                    float hk1, hk2, dtb;
                    hk1 = float.Parse(txtDiem1.Text);
                    hk2 = float.Parse(txtDiem2.Text);
                    dtb = (hk1 + hk2) / 2;
                    txtDiemtb.Text = dtb.ToString();
                }
                if (loaimonhoc == "Đánh giá")
                {
                    cbDiemTB.Text = cbDiem2.Text;
                }
            }
            catch
            {

            }
        }
    }
}
