using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace quanly_hocsinh_tieuhoc
{
    public partial class frmXuatDiem : Form
    {
        string monhoc = "", lophoc = "";
        public frmXuatDiem()
        {
            InitializeComponent();
        }

        public frmXuatDiem(string monhoc, string lophoc)
        {
            InitializeComponent();
            this.monhoc = monhoc;
            this.lophoc = lophoc;
        }
        private void frmXuatDiem_Load(object sender, EventArgs e)
        {
            label2.Text = monhoc;
            label3.Text = lophoc;
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
                SqlCommand cmd = new SqlCommand("SELECT mon_hoc FROM DS_MONHOC WHERE loai_mon_hoc = N'Văn hóa' OR loai_mon_hoc= N'Đánh giá'", conn);
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
                    worksheet.Cells[1, 1] = "THÔNG TIN ĐIỂM HỌC SINH";
                    Excel.Range labelRange = worksheet.Range["A1:F1"];
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
            }
            this.Close();
        }


    }
}
