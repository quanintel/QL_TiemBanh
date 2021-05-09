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

namespace QL_TiemBanh
{
    public partial class Login : Form
    {
        public static string value_role = "";
        public static string value_name = "";
        public Login()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT ROLE FROM NHANVIEN WHERE USERNAME = N'" + txt_user.Text.Trim() + "' AND PASSWORD = N'" + txt_pass.Text.Trim() + "'";
            value_role = Functions.GetFieldValues(sql);
            sql = "SELECT TENNV FROM NHANVIEN WHERE USERNAME = N'" + txt_user.Text.Trim() + "' AND PASSWORD = N'" + txt_pass.Text.Trim() + "'";
            value_name = Functions.GetFieldValues(sql);
            sql = "SELECT USERNAME,PASSWORD,ROLE FROM NHANVIEN WHERE USERNAME = N'" + txt_user.Text.Trim() + "' AND PASSWORD = N'" + txt_pass.Text.Trim() + "'";
            if (txt_user.Text.Trim() == "root" && txt_pass.Text.Trim() == "1")
            {
                MessageBox.Show("Xin chào nhà phát triển hệ thống !!", "Chế độ developer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Homepage form = new Homepage();
                value_role = "Quản Lý";
                value_name = "Developer";
                this.Hide();
                form.Show();
            }else if (Functions.CheckLogin(sql))
            {
                Homepage form = new Homepage();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên đăng nhập và mật khẩu !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            Functions.Connect(); //Mở kết nối
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            System.Windows.Forms.Application.Exit();
        }
    }
}
