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
using System.Data.SqlClient;

namespace quanly_hocsinh_tieuhoc
{
    public partial class frmXuatNLPC : Form
    {
        string monhoc = "", lophoc = "", phan_quyen ="";
        public frmXuatNLPC()
        {
            InitializeComponent();
        }

        public frmXuatNLPC(string monhoc, string lophoc, string phanquyen)
        {
            InitializeComponent();
            this.monhoc = monhoc;
            this.lophoc = lophoc;
            this.phan_quyen = phanquyen;
        }

        private void frmXuatNLPC_Load(object sender, EventArgs e)
        {
            switch (phan_quyen)
            {
                case "1":
                    label3.Text = lophoc;
                    break;
                case "2":
                    label3.Text = lophoc;
                    break;
                case "3":
                    label3.Text = lophoc;
                    break;
                case "4":
                    label3.Text = lophoc;
                    break;
            }
            label2.Text = monhoc;

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (rbtXuat1.Checked == true)
            {
                //Xuất excel tất cả các môn của lớp
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

                // Lấy tên các sheet
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT mon_hoc FROM DS_MONHOC WHERE loai_mon_hoc = N'Phẩm chất'", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Thêm sheet
                while (reader.Read())
                {
                    Excel.Worksheet worksheet1 = (Excel.Worksheet)workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
                    worksheet1.Name = reader["mon_hoc"].ToString();

                    // Fill sheet with information
                    Excel.Worksheet worksheet = null;

                    // Connect to SQL Server database
                    string connectionString = "Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    worksheet = workbook.ActiveSheet;
                    // Add label to worksheet
                    worksheet.Cells[1, 1] = "THÔNG TIN NĂNG LỰC PHẨM CHẤT HỌC SINH";
                    Excel.Range labelRange = worksheet.Range["A1:J1"];
                    labelRange.Merge();
                    labelRange.Font.Bold = true;
                    labelRange.Font.Size = 20;
                    labelRange.Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;

                    // Get data from SQL Server database
                    string query = "SELECT ma_hoc_sinh, ho_ten,ma_lop FROM HOC_SINH";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader rdr = command.ExecuteReader();

                    // Add data to worksheet

                    worksheet.Cells[2, 1] = "Mã học sinh";
                    worksheet.Cells[2, 2] = "Họ và tên";
                    worksheet.Cells[2, 3] = "Lớp học";
                    worksheet.Cells[2, 4] = "Điểm học kì 1";
                    worksheet.Cells[2, 5] = "Điểm học kì 2";
                    worksheet.Cells[2, 6] = "Điểm cuối năm";

                    int row = 3;
                    while (rdr.Read())
                    {
                        worksheet.Cells[row, 1] = rdr["ma_hoc_sinh"].ToString();
                        worksheet.Cells[row, 2] = rdr["ho_ten"].ToString();
                        worksheet.Cells[row, 3] = rdr["ma_lop"].ToString();
                        row++;
                    }
                    // Auto-fit columns and rows
                    worksheet.Columns.AutoFit();
                    worksheet.Rows.AutoFit();

                    // Set border of all cells which has information
                    Excel.Range usedRange = worksheet.UsedRange;
                    usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                }

                reader.Close();
                conn.Close();

                // Lưu
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog1.Title = "Save an Excel Workbook";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    workbook.SaveAs(saveFileDialog1.FileName);
                    workbook.Close();
                    excel.Quit();
                }
            }
            if (rbtXuat2.Checked == true)
            {
                //Xuất excel 1 môn đang chọn
                //Xuất excel tất cả các môn của lớp
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);


                // Fill sheet with information
                Excel.Worksheet worksheet = null;

                // Connect to SQL Server database
                string connectionString = "Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                worksheet = workbook.ActiveSheet;
                // Add label to worksheet
                worksheet.Cells[1, 1] = "THÔNG TIN NĂNG LỰC PHẨM CHẤT HỌC SINH";
                Excel.Range labelRange = worksheet.Range["A1:J1"];
                labelRange.Merge();
                labelRange.Font.Bold = true;
                labelRange.Font.Size = 20;
                labelRange.Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;

                // Get data from SQL Server database
                string query = "SELECT * FROM NLPC WHERE ten_lop='" + lophoc.ToString() + "' AND mon_hoc= '" + monhoc.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader rdr = command.ExecuteReader();

                // Add data to worksheet

                worksheet.Cells[2, 1] = "Mã điểm NLPC";
                worksheet.Cells[2, 2] = "Lớp học";
                worksheet.Cells[2, 3] = "Mã học sinh";
                worksheet.Cells[2, 4] = "Họ và tên";
                worksheet.Cells[2, 5] = "Mã môn học";
                worksheet.Cells[2, 6] = "Môn học";
                worksheet.Cells[2, 7] = "Năm học";
                worksheet.Cells[2, 8] = "Điểm kì 1";
                worksheet.Cells[2, 9] = "Điểm kì 2";
                worksheet.Cells[2, 10] = "Điểm cuối năm";

                int row = 3;
                while (rdr.Read())
                {
                    worksheet.Cells[row, 1] = rdr["ma_diem_nlpc"].ToString();
                    worksheet.Cells[row, 2] = rdr["ten_lop"].ToString();
                    worksheet.Cells[row, 3] = rdr["ma_hoc_sinh"].ToString();
                    worksheet.Cells[row, 4] = rdr["ho_ten"].ToString();
                    worksheet.Cells[row, 5] = rdr["ma_mon_hoc"].ToString();
                    worksheet.Cells[row, 6] = rdr["mon_hoc"].ToString();
                    worksheet.Cells[row, 7] = rdr["nam_hoc"].ToString();
                    worksheet.Cells[row, 8] = rdr["diem_hk1"].ToString();
                    worksheet.Cells[row, 9] = rdr["diem_hk2"].ToString();
                    worksheet.Cells[row, 10] = rdr["diem_cuoi_ki"].ToString();
                    row++;
                }
                // Auto-fit columns and rows
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();

                // Set border of all cells which has information
                Excel.Range usedRange = worksheet.UsedRange;
                usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;


                // Lưu
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog1.Title = "Save an Excel Workbook";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    workbook.SaveAs(saveFileDialog1.FileName);
                    workbook.Close();
                    excel.Quit();
                }
            }
            this.Close();
        }
    }
}
