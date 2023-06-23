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
using Excel = Microsoft.Office.Interop.Excel;

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
            string UpdateNhapdiem = "UPDATE NLPC set ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + txtDiem1.Text + "',diem_hk2='" + txtDiem2.Text + "',diem_cuoi_ki='" + txtDiemtb.Text + "' WHERE ma_diem_nlpc='" + ID + "'";
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

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelToSQLServer(filePath);
            }
        }

        private void txtDiem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiemtb.Text = txtDiem2.Text;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            frmXuatNLPC xd = new frmXuatNLPC(monhoc, lophoc,phan_quyen);
            xd.Show();
        }

        private void ImportExcelToSQLServer(string filePath)
        {
            string connectionString = "Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Import data from Excel to the SQL Server table
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.Sheets[1]; // Assuming the data is in the first worksheet

                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                for (int row = 3; row <= rowCount; row++) // Assuming the data starts from the second row
                {
                    string column1Value = worksheet.Cells[row, 1].Value.ToString();
                    string column2Value = worksheet.Cells[row, 2].Value.ToString();
                    string column3Value = worksheet.Cells[row, 3].Value.ToString();
                    string column4Value = worksheet.Cells[row, 4].Value.ToString();
                    string column5Value = worksheet.Cells[row, 5].Value.ToString();
                    string column6Value = worksheet.Cells[row, 6].Value.ToString();
                    string column7Value = worksheet.Cells[row, 7].Value.ToString();
                    string column8Value = worksheet.Cells[row, 8].Value.ToString();
                    string column9Value = worksheet.Cells[row, 9].Value.ToString();
                    string column10Value = worksheet.Cells[row, 10].Value.ToString();


                    string selectQuery = $"SELECT COUNT(*) FROM NLPC WHERE ma_diem_nlpc = @ma_diem_nlpc";

                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@ma_diem_nlpc", column1Value);

                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        // Data already exists, perform update
                        string updateQuery = $"UPDATE NLPC SET ten_lop = @ten_lop, ma_hoc_sinh = @ma_hoc_sinh , ho_ten=@ho_ten," +
                            $"ma_mon_hoc =@ma_mon_hoc, mon_hoc =@mon_hoc, nam_hoc =@nam_hoc ,diem_hk1 =@diem_hk1, diem_hk2=@diem_hk2, diem_cuoi_ki=@diem_cuoi_ki WHERE ma_diem_nlpc = @ma_diem_nlpc"; // Replace with your table name and column names

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@ma_diem_nlpc", column1Value);
                        updateCommand.Parameters.AddWithValue("@ten_lop", column2Value);
                        updateCommand.Parameters.AddWithValue("@ma_hoc_sinh", column3Value);
                        updateCommand.Parameters.AddWithValue("@ho_ten", column4Value);
                        updateCommand.Parameters.AddWithValue("@ma_mon_hoc", column5Value);
                        updateCommand.Parameters.AddWithValue("@mon_hoc", column6Value);
                        updateCommand.Parameters.AddWithValue("@nam_hoc", column7Value);
                        updateCommand.Parameters.AddWithValue("@diem_hk1", column8Value);
                        updateCommand.Parameters.AddWithValue("@diem_hk2", column9Value);
                        updateCommand.Parameters.AddWithValue("@diem_cuoi_ki", column10Value);

                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        // Data doesn't exist, perform insert
                        string insertQuery = $"INSERT INTO NLPC ( ten_lop,ma_hoc_sinh,ho_ten,ma_mon_hoc, mon_hoc," +
                            $" nam_hoc, diem_hk1, diem_hk2, diem_cuoi_ki) VALUES ( @ten_lop, @ma_hoc_sinh, @ho_ten, @ma_mon_hoc, @mon_hoc" +
                            $",@nam_hoc,@diem_hk1,@diem_hk2,@diem_cuoi_ki )";

                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@ma_diem_nlpc", column1Value);
                        insertCommand.Parameters.AddWithValue("@ten_lop", column2Value);
                        insertCommand.Parameters.AddWithValue("@ma_hoc_sinh", column3Value);
                        insertCommand.Parameters.AddWithValue("@ho_ten", column4Value);
                        insertCommand.Parameters.AddWithValue("@ma_mon_hoc", column5Value);
                        insertCommand.Parameters.AddWithValue("@mon_hoc", column6Value);
                        insertCommand.Parameters.AddWithValue("@nam_hoc", column7Value);
                        insertCommand.Parameters.AddWithValue("@diem_hk1", column8Value);
                        insertCommand.Parameters.AddWithValue("@diem_hk2", column9Value);
                        insertCommand.Parameters.AddWithValue("@diem_cuoi_ki", column10Value);

                        insertCommand.ExecuteNonQuery();
                    }
                }

                // Clean up Excel objects
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                connection.Close();
            }
        }


    }
}
