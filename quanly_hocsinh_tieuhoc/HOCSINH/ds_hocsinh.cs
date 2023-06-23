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
using app = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using ClosedXML.Excel;
using System.Data.OleDb;

namespace quanly_hocsinh_tieuhoc
{
    public partial class ds_hocsinh : Form
    {
        string user_id = "", password = "", phan_quyen = "",ma_lop="";
        public ds_hocsinh()
        {
            InitializeComponent();
        }
        public ds_hocsinh(string user_id, string password, string phan_quyen, string ma_lop)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
            this.ma_lop = ma_lop;
        }
        private void ds_hocsinh_Load(object sender, EventArgs e)
        {
            string ShowHS = "SELECT * FROM HOC_SINH";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(ShowHS);
            dtgvHocsinh.DataSource = dt;
        }
        void Load_data()
        {
            string sql = "SELECT * FROM HOC_SINH where ma_lop = (select ma_lop from TAI_KHOAN where  user_id= '" + user_id + "')";
            dtgvHocsinh.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
            
        }
        void cleartext()
        {
            txtMa.Text = "";
            txtHovaten.Text = "";
            txtNgaysinh.Text = "";
            txtNoisinh.Text = "";
            txtDantoc.Text = "";
            txtTongiao.Text = "";
            txtDoituong.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            cbGioitinh.Text = "";
            txtTencha.Text = "";
            txtNghecha.Text = "";
            txtVieccha.Text = "";
            txtTenme.Text = "";
            txtNgheme.Text = "";
            txtViecme.Text = "";
            cbGioitinh.Text = "";
            txtMalop.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Form hocsinh = new ds_hocsinh();
            hocsinh.Show();
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtHovaten.Text == "" || txtNgaysinh.Text == "" || txtNoisinh.Text == "" || txtDantoc.Text == "" || txtTongiao.Text == "" || txtDoituong.Text == "" || txtDiachi.Text == "" || txtDienthoai.Text == "" || cbGioitinh.Text == "" || txtMalop.Text == "" || txtTencha.Text == "" || txtNghecha.Text == "" || txtVieccha.Text == "" || txtTenme.Text == "" || txtNgheme.Text == "" || txtViecme.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo!");
            }
            else
            {
                string add = @"INSERT INTO HOC_SINH(ma_hoc_sinh,ho_ten,ngay_sinh,noi_sinh,dan_toc,ton_giao,doi_tuong,dia_chi,dien_thoai,ten_cha,nghe_nghiep_cha,nam_sinh_cha,ten_me,nghe_nghiep_me,nam_sinh_me,gioi_tinh,ma_lop) VALUES('" + txtMa.Text + "',N'" + txtHovaten.Text + "','" + txtNgaysinh.Text + "',N'" + txtNoisinh.Text + "',N'" + txtDantoc.Text + "',N'" + txtTongiao.Text + "',N'" + txtDoituong.Text + "',N'" + txtDiachi.Text + "','" + txtDienthoai.Text + "',N'" + txtTencha.Text + "',N'" + txtNghecha.Text + "',N'" + txtVieccha.Text + "',N'" + txtTenme.Text + "',N'" + txtNgheme.Text + "',N'" + txtViecme.Text + "',N'" + cbGioitinh.Text + "',N'" + txtMalop.Text + "')";
                try
                {
                    DatabaseService.DatabaseService.executeQuery(add);
                    Load_data();
                    cleartext();
                }
                catch
                {
                    MessageBox.Show("Không thêm được!", "Thông báo");
                }
            }

        }
        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvHocsinh.CurrentCell.RowIndex;
            string ID = dtgvHocsinh.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM HOC_SINH WHERE ma_hoc_sinh=" + ID + "";
            if (MessageBox.Show("Bạn có muốn Xóa hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                try
                {
                    DatabaseService.DatabaseService.executeQuery(delete);
                    Load_data();
                    cleartext();
                }
                catch
                {
                    MessageBox.Show("Không xóa được!", "Thông báo");
                }
            }
        }

        private void txtTongiao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvHocsinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvHocsinh.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtHovaten.Text = row.Cells[1].Value.ToString();
                txtNgaysinh.Text = row.Cells[2].Value.ToString();
                txtNoisinh.Text = row.Cells[3].Value.ToString();
                txtDantoc.Text = row.Cells[4].Value.ToString();
                txtTongiao.Text = row.Cells[5].Value.ToString();
                txtDoituong.Text = row.Cells[6].Value.ToString();
                txtDiachi.Text = row.Cells[7].Value.ToString();
                txtDienthoai.Text = row.Cells[8].Value.ToString();
                txtTencha.Text = row.Cells[9].Value.ToString();
                txtNghecha.Text = row.Cells[10].Value.ToString();
                txtVieccha.Text = row.Cells[11].Value.ToString();
                txtTenme.Text = row.Cells[12].Value.ToString();
                txtNgheme.Text = row.Cells[13].Value.ToString();
                txtViecme.Text = row.Cells[14].Value.ToString();
                cbGioitinh.Text = row.Cells[15].Value.ToString();
                txtMalop.Text = row.Cells[16].Value.ToString();
            }
            catch
            { }

        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            int r = dtgvHocsinh.CurrentCell.RowIndex;
            string ID = dtgvHocsinh.Rows[r].Cells[0].Value.ToString();
            string update = "UPDATE HOC_SINH set ho_ten=N'" + txtHovaten.Text + "',ngay_sinh='" + txtNgaysinh.Text + "',noi_sinh=N'" + txtNoisinh.Text + "',dan_toc=N'" + txtDantoc.Text + "',ton_giao=N'" + txtTongiao.Text + "',doi_tuong=N'" + txtDoituong.Text + "',dia_chi=N'" + txtDiachi.Text + "',dien_thoai='" + txtDienthoai.Text + "',ten_cha=N'"
+ txtTencha.Text + "',nghe_nghiep_cha=N'" + txtNghecha.Text + "',nam_sinh_cha=N'" + txtVieccha.Text + "',ten_me=N'" + txtTenme.Text + "',nghe_nghiep_me=N'" + txtNgheme.Text + "',nam_sinh_me=N'" + txtViecme.Text + "',gioi_tinh =N'" + cbGioitinh.Text + "',ma_lop =N'" + txtMalop.Text + "' WHERE ma_hoc_sinh='" + ID + "'";
            try
            {
                DatabaseService.DatabaseService.executeQuery(update);
                Load_data();
                cleartext();
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật!", "Thông báo");
            }
        }

        private void txtTencha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVieccha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtHovaten.Clear();
            txtNoisinh.Clear();
            txtDantoc.Clear();
            txtDoituong.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtTencha.Clear();
            txtNghecha.Clear();
            txtVieccha.Clear();
            txtTenme.Clear();
            txtNgheme.Clear();
            txtViecme.Clear();
        }
        private void ds_hocsinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không ?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void exprotExcel(DataGridView g, string fileName)
        {

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveAs(fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }

        private void cmdXuatexcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            excelApp.Columns.ColumnWidth = 25;

            // Add label to worksheet
            worksheet.Cells[1, 1] = "THÔNG TIN HỌC SINH";
            Excel.Range labelRange = worksheet.Range["A1:F1"];
            labelRange.Merge();
            labelRange.Font.Bold = true;
            labelRange.Font.Size = 20;
            labelRange.Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;


            // Copy DataGridView contents to worksheet
            for (int i = 0; i < dtgvHocsinh.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvHocsinh.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = row.Cells[j].Value.ToString();
                }
            }

            // Add header text to worksheet
            foreach (DataGridViewColumn column in dtgvHocsinh.Columns)
            {
                worksheet.Cells[3, column.Index + 1] = column.HeaderText;
                Excel.Range headerRange = worksheet.Cells[2, column.Index + 1];
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                headerRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                headerRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }

            // Auto-fit columns and rows
            worksheet.Columns.AutoFit();
            worksheet.Rows.AutoFit();

            // Set border of all cells which has information
            Excel.Range usedRange = worksheet.UsedRange;
            usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            // Save the workbook
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog1.FileName);
            }

            workbook.Close();
            excelApp.Quit();
        }

        private void cmdNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$A3:Z]", connection);
                    using (OleDbDataReader dr = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dtgvHocsinh.DataSource = dt;
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.KeepIdentity,null))
                {
                    bulkCopy.DestinationTableName = "HOC_SINH";
                    bulkCopy.WriteToServer(dtgvHocsinh.DataSource as DataTable);
                }
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            timkiemhs tim = new timkiemhs();
            tim.Show();
        }
    }
}
