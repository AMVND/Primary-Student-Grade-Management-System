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
    public partial class frmBC_HS : Form
    {
        string gvcn;
        public frmBC_HS()
        {
            InitializeComponent();
        }

        private void frmBC_HS_Load(object sender, EventArgs e)
        {
            System.Data.DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ma_lop";
            cbLop.ValueMember = "ma_lop";
            ////
            this.rpvBaoCao.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            String sql = "Select * from HOC_SINH WHERE ma_lop='" + cbLop.Text + "'";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=QLHSTH;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            rpvBaoCao.LocalReport.ReportPath = "rpBC_HS.rdlc";

            if (ds.Tables[0].Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HOC_SINH";
                rds.Value = ds.Tables[0];
                rpvBaoCao.LocalReport.DataSources.Clear();
                rpvBaoCao.LocalReport.DataSources.Add(rds);


                ReportParameterCollection nameParameters = new ReportParameterCollection();
                nameParameters.Add(new ReportParameter("nameGVCN", txtGVCN.Text));
                this.rpvBaoCao.LocalReport.SetParameters(nameParameters);


                rpvBaoCao.RefreshReport();
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
