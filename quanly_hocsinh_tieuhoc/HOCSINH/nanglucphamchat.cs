using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_hocsinh_tieuhoc
{
    public partial class nanglucphamchat : Form
    {

        string monhoc;
        string lophoc;
        string mahocsinh;
        string tenhocsinh;
        string user_id = "", password = "", phan_quyen = "";
        public nanglucphamchat()
        {
            InitializeComponent();
        }

        public nanglucphamchat(string user_id, string password, string phan_quyen)
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
            string showDslop = "SELECT * FROM NLPC";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showDslop);
            dtgvNhapdiem.DataSource = dt;
            ////////
            DataTable cbnam = DatabaseService.DatabaseService.getDataTable("select * from DS_NAMHOC");
            cbNamHoc.DataSource = cbnam;
            cbNamHoc.DisplayMember = "nam_hoc";
            cbNamHoc.ValueMember = "ma_nam_hoc";
            //////////////////////////////////////
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
            DataTable cbmamon = DatabaseService.DatabaseService.getDataTable("select * from DS_MONHOC WHERE loai_mon_hoc = N'Phẩm chất'");
            cbMonHoc.DataSource = cbmamon;
            cbMonHoc.DisplayMember = "ma_mon_hoc";
            cbMonHoc.ValueMember = "ma_mon_hoc";
            //////////////////////////////////////


        }
        void Load_data()
        {
            string sql = "select * from NLPC";
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
            string hk1, hk2;


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
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cmdXemdiem_Click(object sender, EventArgs e)
        {
            nlpc xemnlpc = new nlpc();
            xemnlpc.Show();
        }


        //Thêm mới
        private void cmdThem_Click(object sender, EventArgs e)
        {
            string add = @"INSERT INTO NLPC(ten_lop,ma_hoc_sinh,ho_ten,ma_mon_hoc,mon_hoc,nam_hoc,diem_hk1,diem_hk2,diem_cuoi_ki) VALUES(N'" + txtTenlop.Text + "',N'" + txtMahocsinh.Text + "',N'" + txtHoten.Text + "',N'" + cbMonHoc.Text + "',N'" + txtMonhoc.Text + "',N'" + cbNamHoc.Text + "',N'" + txtDiem1.Text + "',N'" + txtDiem2.Text + "',N'" + txtDiemtb.Text + "')";
            DatabaseService.DatabaseService.executeQuery(add);
            Load_data();
            clear_data();
        }

        //Cập nhật
        private void cmdSua_Click(object sender, EventArgs e)
        {
            int r = dtgvNhapdiem.CurrentCell.RowIndex;
            string ID = dtgvNhapdiem.Rows[r].Cells[0].Value.ToString();
            string UpdateNhapdiem = "UPDATE NLPC set ma_diem_nlpc= N'" + txtMadiem.Text + "',ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + txtDiem1.Text + "',diem_hk2='" + txtDiem2.Text + "',diem_cuoi_ki='" + txtDiemtb.Text + "' WHERE ma_diem_nlpc='" + ID + "'";
            try
            {
                DatabaseService.DatabaseService.executeQuery(UpdateNhapdiem);
                Load_data();
                clear_data();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể cập nhật!", "Thông báo");
            }
        }

        //Xóa
        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvNhapdiem.CurrentCell.RowIndex;
            string ID = dtgvNhapdiem.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM NLPC WHERE ma_diem_nlpc='" + ID + "'";
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
                    MessageBox.Show(delete);
                }
            }
        }
        ///Làm trống
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
                txtMonhoc.Text = monhoc;
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

        private void txtDiem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiemtb.Text = txtDiem2.Text;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            frmXuatNLPC xd = new frmXuatNLPC(monhoc, lophoc);
            xd.Show();
        }
    }
}
