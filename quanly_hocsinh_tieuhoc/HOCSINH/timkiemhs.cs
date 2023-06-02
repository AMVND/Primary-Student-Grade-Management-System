using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_hocsinh_tieuhoc
{
    public partial class timkiemhs : Form
    {
        public timkiemhs()
        {
            InitializeComponent();
        }

        private void timkiemhs_Load(object sender, EventArgs e)
        {
            string ShowHS = "select * from HOC_SINH";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(ShowHS);
            dtgvTimkiem.DataSource = dt;
            //////////
            DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ma_lop";
            cbLop.ValueMember = "ma_lop";
            //////////////////////////////////////

        }
        private void timkiemhs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("Bạn có muốn thoát không ?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            string searchname = "Select * from HOC_SINH where ho_ten like N'%" + txtHoten.Text + "%' AND ma_lop = '"+cbLop.Text+"'";
            try
            {
                DataTable dt = DatabaseService.DatabaseService.getDataTable(searchname);
                dtgvTimkiem.DataSource = dt;

            }
            catch (Exception)
            { }
        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonlop = "Select * from HOC_SINH where ma_lop like N'%" + cbLop.Text + "%'";
            DataTable dt = DatabaseService.DatabaseService.getDataTable(chonlop);
            dtgvTimkiem.DataSource = dt;
        }
    }
}
