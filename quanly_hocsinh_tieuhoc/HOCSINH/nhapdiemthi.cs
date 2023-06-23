using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace quanly_hocsinh_tieuhoc
{
    public partial class nhapdiemthi : Form
    {
        string monhoc;
        string lophoc;
        string lophoc1;
        string loaimonhoc;
        string mahocsinh;
        string tenhocsinh;
        string user_id = "", password = "", phan_quyen = "", ma_lop="";

        public nhapdiemthi()
        {
            InitializeComponent();
        }
        public nhapdiemthi(string user_id, string password, string phan_quyen, string malop)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
            this.ma_lop = malop;
        }

        private void nhapdiemthi_Load(object sender, EventArgs e)
        {
            switch (phan_quyen)
            {
                case "2":
                    cmdSua.Enabled = true;
                    break;
                case "3":
                    cmdSua.Enabled = false;
                    cmdSua.BackColor = System.Drawing.Color.Gray;
                    break;
                case "4":
                    cmdSua.Enabled = false;
                    cmdSua.BackColor = System.Drawing.Color.Gray;
                    break;
            }


            
            string showDslop = "select * from DIEM_THI ";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showDslop);
            dtgvNhapdiem.DataSource = dt;
           
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
            string UpdateNhapdiem = "UPDATE DIEM_THI set ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + txtDiem1.Text + "',diem_hk2='" + txtDiem2.Text + "',diem_tb ='" + txtDiemtb.Text + "' WHERE ma_diem_thi='" + ID + "'";

            string UpdateNhapdiemChu = "UPDATE DIEM_THI set ten_lop=N'" + txtTenlop.Text + "',ma_hoc_sinh=N'" + txtMahocsinh.Text + "',ho_ten=N'" + txtHoten.Text + "',ma_mon_hoc=N'" + cbMonHoc.Text + "',mon_hoc=N'" + txtMonhoc.Text + "',nam_hoc=N'" + cbNamHoc.Text + "',diem_hk1='" + cbDiem1.Text + "',diem_hk2='" + cbDiem2.Text + "',diem_tb ='" + cbDiemTB.Text + "' WHERE ma_diem_thi='" + ID + "'";

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
                lophoc1= dr["ma_lop"].ToString();
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
            frmXuatDiem xd = new frmXuatDiem(monhoc, lophoc1,phan_quyen);
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

        private void btnLuuCSDL_Click(object sender, EventArgs e)
        {
            Load_data();
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


                    string selectQuery = $"SELECT COUNT(*) FROM DIEM_THI WHERE ma_diem_thi = @ma_diem_thi";

                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@ma_diem_thi", column1Value);
                    
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        // Data already exists, perform update
                        string updateQuery = $"UPDATE DIEM_THI SET ten_lop = @ten_lop, ma_hoc_sinh = @ma_hoc_sinh , ho_ten=@ho_ten," +
                            $"ma_mon_hoc =@ma_mon_hoc, mon_hoc =@mon_hoc, nam_hoc =@nam_hoc ,diem_hk1 =@diem_hk1, diem_hk2=@diem_hk2, diem_tb=@diem_tb WHERE ma_diem_thi = @ma_diem_thi"; // Replace with your table name and column names

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@ma_diem_thi", column1Value);
                        updateCommand.Parameters.AddWithValue("@ten_lop", column2Value);
                        updateCommand.Parameters.AddWithValue("@ma_hoc_sinh", column3Value);
                        updateCommand.Parameters.AddWithValue("@ho_ten", column4Value);
                        updateCommand.Parameters.AddWithValue("@ma_mon_hoc", column5Value);
                        updateCommand.Parameters.AddWithValue("@mon_hoc", column6Value);
                        updateCommand.Parameters.AddWithValue("@nam_hoc", column7Value);
                        updateCommand.Parameters.AddWithValue("@diem_hk1", column8Value);
                        updateCommand.Parameters.AddWithValue("@diem_hk2", column9Value);
                        updateCommand.Parameters.AddWithValue("@diem_tb", column10Value);

                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        // Data doesn't exist, perform insert
                        string insertQuery = $"INSERT INTO DIEM_THI ( ten_lop,ma_hoc_sinh,ho_ten,ma_mon_hoc, mon_hoc," +
                            $" nam_hoc, diem_hk1, diem_hk2, diem_tb) VALUES ( @ten_lop, @ma_hoc_sinh, @ho_ten, @ma_mon_hoc, @mon_hoc" +
                            $",@nam_hoc,@diem_hk1,@diem_hk2,@diem_tb )"; 

                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@ma_diem_thi", column1Value);
                        insertCommand.Parameters.AddWithValue("@ten_lop", column2Value);
                        insertCommand.Parameters.AddWithValue("@ma_hoc_sinh", column3Value);
                        insertCommand.Parameters.AddWithValue("@ho_ten", column4Value);
                        insertCommand.Parameters.AddWithValue("@ma_mon_hoc", column5Value);
                        insertCommand.Parameters.AddWithValue("@mon_hoc", column6Value);
                        insertCommand.Parameters.AddWithValue("@nam_hoc", column7Value);
                        insertCommand.Parameters.AddWithValue("@diem_hk1", column8Value);
                        insertCommand.Parameters.AddWithValue("@diem_hk2", column9Value);
                        insertCommand.Parameters.AddWithValue("@diem_tb", column10Value);

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
