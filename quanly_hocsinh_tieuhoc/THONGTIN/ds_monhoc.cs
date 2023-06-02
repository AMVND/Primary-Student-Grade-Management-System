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
    public partial class ds_monhoc : Form
    {
        public ds_monhoc()
        {
            InitializeComponent();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtMamon.Text == "" || txtMonhoc.Text == "")
            {
                MessageBox.Show("Bạn chưa điền dữ liệu", "Thông báo");
            }
            else
            {
                string add = @"INSERT INTO DS_MONHOC(ma_mon_hoc,mon_hoc,loai_mon_hoc) VALUES('" + txtMamon.Text + "',N'" + txtMonhoc.Text + "', N'" + cbLoaiMonHoc.Text + "')";
                DatabaseService.DatabaseService.executeQuery(add);
                Load_data();
                cleartext();
            }
        }

        private void ds_monhoc_Load(object sender, EventArgs e)
        {
            string showDsmon = "SELECT * FROM DS_MONHOC";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showDsmon);
            dtgvMonhoc.DataSource = dt;
        }
        void Load_data()
        {
            string sql = "select * from DS_MONHOC";
            dtgvMonhoc.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }
        void cleartext()
        {
            txtMamon.Text = "";
            txtMonhoc.Text = "";
        }

        private void dtgvMonhoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvMonhoc.Rows[e.RowIndex];
                txtMamon.Text = row.Cells[0].Value.ToString();
                txtMonhoc.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvMonhoc.CurrentCell.RowIndex;
            string ID = dtgvMonhoc.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM DS_MONHOC WHERE ma_mon_hoc='" + ID + "'";
            if (MessageBox.Show("Bạn có muốn Xóa hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                try
                {
                    DatabaseService.DatabaseService.executeQuery(delete);
                    Load_data();
                    cleartext();
                }
                catch(Exception)
                {
                    //MessageBox.Show("Không xóa được!", "Thông báo");
                    MessageBox.Show(delete);
                }
            }
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            int r = dtgvMonhoc.CurrentCell.RowIndex;
            string ID = dtgvMonhoc.Rows[r].Cells[0].Value.ToString();
            string updatelop = "UPDATE DS_MONHOC set ma_mon_hoc='" + txtMamon.Text + "',mon_hoc=N'" + txtMonhoc.Text + "' WHERE ma_mon_hoc='" + ID + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            txtMamon.Text = "";
            txtMonhoc.Text = "";
        }

        private void ds_monhoc_FormClosing(object sender, FormClosingEventArgs e)
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
            exprotExcel(dtgvMonhoc, @"D:\", "danhsachmonhoc");
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
