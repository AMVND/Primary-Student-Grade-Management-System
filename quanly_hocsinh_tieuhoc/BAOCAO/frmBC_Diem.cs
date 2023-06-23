using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmBC_Diem : Form
    {
        string gvcn;
        string user_id = "", password = "", phan_quyen = "";
        public frmBC_Diem()
        {
            InitializeComponent();
        }

        public frmBC_Diem(string user_id, string password, string phan_quyen)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.password = password;
            this.phan_quyen = phan_quyen;
        }
        private void frmBC_Diem_Load(object sender, EventArgs e)
        {
            DataTable cbnam = DatabaseService.DatabaseService.getDataTable("select * from DS_NAMHOC");
            cbNamHoc.DataSource = cbnam;
            cbNamHoc.DisplayMember = "nam_hoc";
            cbNamHoc.ValueMember = "ma_nam_hoc";
            ////
            System.Data.DataTable cblop = DatabaseService.DatabaseService.getDataTable("select * from DSACH_LOP");
            cbLop.DataSource = cblop;
            cbLop.DisplayMember = "ma_lop";
            cbLop.ValueMember = "ma_lop";
            ////
            System.Data.DataTable cbmon = DatabaseService.DatabaseService.getDataTable("select * from DS_MONHOC WHERE loai_mon_hoc = N'Văn hóa' OR loai_mon_hoc = N'Đánh giá'");
            cbMonHoc.DataSource = cbmon;
            cbMonHoc.DisplayMember = "mon_hoc";
            cbMonHoc.ValueMember = "ma_mon_hoc";
            ////
          
            this.rpvBaoCao.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex > -1)
            {
                
                String sql = "Select * from DIEM_THI WHERE ten_lop='" + cbLop.Text + "' AND mon_hoc = N'"+cbMonHoc.Text+"'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=QLHSTH;Integrated Security=True";
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

                rpvBaoCao.LocalReport.ReportPath = "rpBC_Diem.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {

                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DIEM";
                    rds.Value = ds.Tables[0];
                    rpvBaoCao.LocalReport.DataSources.Clear();
                    rpvBaoCao.LocalReport.DataSources.Add(rds);


                    ReportParameterCollection nameParameters = new ReportParameterCollection();
                    nameParameters.Add(new ReportParameter("nameGVCN", txtGVCN.Text));
                    this.rpvBaoCao.LocalReport.SetParameters(nameParameters);
                    rpvBaoCao.RefreshReport();
                } else
                {
                    MessageBox.Show("Không có thông tin để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44NFGRQ;Initial Catalog=QLHSTH;Integrated Security=True");

            conn.Open();
            string q = "select a.ma_hoc_sinh, a.ho_ten,a.mon_hoc,a.diem_hk1,a.diem_hk2,a.diem_tb,c.user_id from DIEM_THI a, DSACH_LOP c WHERE c.ten_lop = '" + cbLop.Text+"' AND a.nam_hoc = '"+cbNamHoc.Text+"'";
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
