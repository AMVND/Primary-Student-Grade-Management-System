using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Reporting.WinForms;
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

namespace quanly_hocsinh_tieuhoc
{
    public partial class frmHocBa : Form
    {
        string gvcn;
        string namhoc;
        public frmHocBa()
        {
            InitializeComponent();
        }

        private void frmHocBa_Load(object sender, EventArgs e)
        {
            System.Data.DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ma_lop";
            cbLop.ValueMember = "ma_lop";
            ////
            System.Data.DataTable cbnam = DatabaseService.DatabaseService.getDataTable("select * from DS_NAMHOC");
            cbNam.DataSource = cbnam;
            cbNam.DisplayMember = "nam_hoc";
            cbNam.ValueMember = "ma_nam_hoc";
            ///
            this.rpvBaoCao.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "select * from diembangso where ten_lop='" + cbLop.Text + "' order by ma_hoc_sinh";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=QLHSTH;Integrated Security=True";


                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);


                rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

                rpvBaoCao.LocalReport.ReportPath = "rpHocBa.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "diembangso";
                    rds.Value = ds.Tables[0];

                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);

                    rpvBaoCao.RefreshReport();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Không có thông tin hiển thị", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            

        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select * from DS_NAMHOC WHERE ma_nam_hoc = '" + cbNam.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                namhoc = dr["nam_hoc"].ToString();
               
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select * from DSACH_LOP WHERE ma_lop = '" + cbLop.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gvcn = dr["user_id"].ToString();
                txtGVCN.Text = gvcn;
            }
        }
    }
}
