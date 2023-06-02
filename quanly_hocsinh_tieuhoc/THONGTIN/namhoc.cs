using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace quanly_hocsinh_tieuhoc
{
    public partial class namhoc : Form
    {
        public namhoc()
        {
            InitializeComponent();
        }

        private void namhoc_Load(object sender, EventArgs e)
        {
            string shownamhoc = "SELECT * FROM DS_NAMHOC";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(shownamhoc);
            dtgvNamhoc.DataSource = dt;
        }
        void Load_data()
        {
            string sql = "select * from DS_NAMHOC";
            dtgvNamhoc.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }
        void cleartext()
        {
            txtManam.Text = "";
            txtNamhoc.Text = "";
        }

        private void dtgvNamhoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvNamhoc.Rows[e.RowIndex];
                txtManam.Text = row.Cells[0].Value.ToString();
                txtNamhoc.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            string add = @"INSERT INTO DS_NAMHOC(ma_nam_hoc,nam_hoc) VALUES('" + txtManam.Text + "','" + txtNamhoc.Text + "')";
            DatabaseService.DatabaseService.executeQuery(add);
            Load_data();
            cleartext();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvNamhoc.CurrentCell.RowIndex;
            string ID = dtgvNamhoc.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM DS_NAMHOC WHERE ma_nam_hoc = '" + ID + "'";
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

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            int r = dtgvNamhoc.CurrentCell.RowIndex;
            string ID = dtgvNamhoc.Rows[r].Cells[0].Value.ToString();
            string updatelop = "UPDATE DS_NAMHOC set ma_nam_hoc='" + txtManam.Text + "',nam_hoc='" + txtNamhoc.Text + "' WHERE ma_nam_hoc ='" + ID + "'";
            try
            {
                DatabaseService.DatabaseService.executeQuery(updatelop);
                Load_data();
                cleartext();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể cập nhật!", "Thông báo");
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtManam.Text = "";
            txtNamhoc.Text = "";
        }

        private void namhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không ?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void exprotExcel(DataGridView g, string path, string fileName)
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
            obj.ActiveWorkbook.SaveCopyAs(path + fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }
        private void cmdXuatexcel_Click(object sender, EventArgs e)
        {
            exprotExcel(dtgvNamhoc, @"D:\", "danhsachnamhoc");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\");
            else if (dialog == DialogResult.No)
            {
                //
            }
        }
    }
}
