using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QL_TiemBanh
{
    public partial class Baocao : Form
    {
        public Baocao()
        {
            InitializeComponent();
        }
        private void btn_baocao_Click(object sender, EventArgs e)
        {
            //Khai báo câu lệnh SQL
            String sql = "Select * from SANPHAM Where NGAYSX >='" + dtpNgaySX.Value.ToString("yyyy-MM-dd") + "'";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+"\\DATABASE\\COIXAYGIO.mdf;Integrated Security=True;Connect Timeout=30";
            //con.ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=COIXAYGIO;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvBaoCao.LocalReport.ReportPath = "Report_SANPHAM.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Tb_sanpham";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvBaoCao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvBaoCao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvBaoCao.RefreshReport();
            }
        }
        private void Baocao_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            this.rpvBaoCao.RefreshReport();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
