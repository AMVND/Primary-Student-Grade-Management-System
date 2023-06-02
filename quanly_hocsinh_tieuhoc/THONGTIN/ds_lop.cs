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
namespace quanly_hocsinh_tieuhoc
{
    public partial class ds_lop : Form
    {
        public ds_lop()
        {
            InitializeComponent();
        }

        private void ds_lop_Load(object sender, EventArgs e)
        {
            string showDslop = "SELECT * FROM DSACH_LOP";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(showDslop);
            dtgvDslop.DataSource = dt;

        }
        void Load_data()
        {
            string sql = "select * from DSACH_LOP";
            dtgvDslop.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }
        void cleartext()
        {
            txtMalop.Text = "";
            txtLop.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtMalop.Text = "";
            txtLop.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgvDslop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dtgvDslop.Rows[e.RowIndex];
                    txtMalop.Text = row.Cells[0].Value.ToString();
                    txtKhoi.Text = row.Cells[2].Value.ToString();
                    txtLop.Text = row.Cells[1].Value.ToString();
                    txtGVCN.Text = row.Cells[3].Value.ToString();
            }
            catch(Exception)
            { 
            }
        }

        private void cmdMoi_Click(object sender, EventArgs e)
        {
            string sql = "select * from DSACH_LOP";
            dtgvDslop.DataSource = DatabaseService.DatabaseService.getDataTable(sql);
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtLop.Text == "" || txtKhoi.Text == "" || txtMalop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo");
            }
            else
            {
                string add = @"INSERT INTO DSACH_LOP(ma_lop,ten_lop,khoi,user_id) VALUES('" + txtMalop.Text + "','" + txtLop.Text + "','" + txtKhoi.Text + "','" + txtGVCN.Text + "')";
                DatabaseService.DatabaseService.executeQuery(add);
                Load_data();
                cleartext();
            }
        }

        private void dtgvDslop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            int r = dtgvDslop.CurrentCell.RowIndex;
            string ID = dtgvDslop.Rows[r].Cells[0].Value.ToString();
            string updatelop = "UPDATE DSACH_LOP set ma_lop='"+ txtMalop.Text +"',ten_lop='"+ txtLop.Text +"',khoi='"+ txtKhoi.Text + "',user_id='"+ txtGVCN.Text +"' WHERE ma_lop='" + ID + "'";
            try
            {
                DatabaseService.DatabaseService.executeQuery(updatelop);
                Load_data();
                cleartext();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể cập nhật!","Thông báo");
            }

        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            int r = dtgvDslop.CurrentCell.RowIndex;
            string ID = dtgvDslop.Rows[r].Cells[0].Value.ToString();
            string delete = "DELETE FROM DSACH_LOP WHERE ma_lop='" + ID + "'";
            if (MessageBox.Show("Bạn có muốn Xóa hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                try
                {
                    DatabaseService.DatabaseService.executeQuery(delete);
                    Load_data();
                }
                catch
                {
                    MessageBox.Show("Không xóa được!", "Thông báo");
                }
            }
        }

        private void ds_lop_FormClosing(object sender, FormClosingEventArgs e)
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
            exprotExcel(dtgvDslop, @"D:\", "danhsachlop");
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
