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

namespace quanly_hocsinh_tieuhoc
{
    public partial class nlpc : Form
    {
        public nlpc()
        {
            InitializeComponent();
        }
        void Load_data()
        {
            string sql = "select * from NLPC";
            dtgvDiemthi.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }

        private void diemthi_Load(object sender, EventArgs e)
        {
            DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ten_lop";
            cbLop.ValueMember = "ma_lop";
            ///////////////////////////////////////
            DataTable cbnam = DatabaseService.DatabaseService.getDataTable("select * from DS_NAMHOC");
            cbNamhoc.DataSource = cbnam;
            cbNamhoc.DisplayMember = "nam_hoc";
            cbNamhoc.ValueMember = "ma_nam_hoc";
            //////////////////////////////////////
            DataTable cbmamon = DatabaseService.DatabaseService.getDataTable("select * from DS_MONHOC WHERE loai_mon_hoc = N'Phẩm chất'");
            comboBox1.DataSource = cbmamon;
            comboBox1.DisplayMember = "mon_hoc";
            comboBox1.ValueMember = "ma_mon_hoc";
            //////////////////////////////////////
        }

        private void cmdXemdiem_Click(object sender, EventArgs e)
        {
            string xemdiem = "Select * from NLPC where nam_hoc ='" + cbNamhoc.Text + "' and ten_lop =N'" + cbLop.Text + "'";
            if (cbLop.Text == "" || cbNamhoc.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo!");
            }
            else
            {
                try
                {
                    DataTable dt = DatabaseService.DatabaseService.getDataTable(xemdiem);
                    dtgvDiemthi.DataSource = dt;
                    
                }
                catch (Exception)
                { }
            }
        }

        void reloaddiem1()
        {
            txtDiemhk1.Text = "";
        }
        void reloaddiem2()
        {
            txtDiemhk2.Text = "";
        }


        private void dtgvDiemthi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvDiemthi.Rows[e.RowIndex];
                txtDiemhk1.Text = row.Cells[7].Value.ToString();
                txtDiemhk2.Text = row.Cells[8].Value.ToString();

            }
            catch (Exception)
            { }
        }

        private void cmdXuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            excelApp.Columns.ColumnWidth = 25;

            // Add label to worksheet
            worksheet.Cells[1, 1] = "THÔNG TIN NĂNG LỰC PHẨM CHẤT";
            Excel.Range labelRange = worksheet.Range["A1:F1"];
            labelRange.Merge();
            labelRange.Font.Bold = true;
            labelRange.Font.Size = 20;
            labelRange.Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;


            // Copy DataGridView contents to worksheet
            for (int i = 0; i < dtgvDiemthi.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvDiemthi.Rows[i];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = row.Cells[j].Value.ToString();
                }
            }

            // Add header text to worksheet
            foreach (DataGridViewColumn column in dtgvDiemthi.Columns)
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

        private void diemthi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không ?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtTimhs_TextChanged(object sender, EventArgs e)
        {
            string searchname = "Select * from NLPC where ho_ten like N'%" + txtTimhs.Text + "%' AND nam_hoc='" + cbNamhoc.Text + "' AND ten_lop = '" + cbLop.Text + "' AND mon_hoc = N'" + comboBox1.Text + "'";
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable(searchname);
                dtgvDiemthi.DataSource = dt;
            }
            catch (Exception)
            { }
        }
    }
}
