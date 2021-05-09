using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MouveForm;
namespace QL_TiemBanh
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(grbox_main);
            txt_roleDone.Text = Login.value_role;
            lb_username.Text = Login.value_name;
            if (txt_roleDone.Text == "Nhân Viên")
            {
                btn_nhanvien.Enabled = false;
            }
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_roleDone.Text = "";
                lb_username.Text = "";
                Login form = new Login();
                this.Hide();
                form.Show();
            }
        }
        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            Hoadon form = new Hoadon();
            form.Show();
        }
        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            Sanpham form = new Sanpham();
            form.ShowDialog();
        }
        private void btn_nguyenlieu_Click(object sender, EventArgs e)
        {
            Nguyenlieu form = new Nguyenlieu();
            form.ShowDialog();
        }
        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            Khachhang form = new Khachhang();
            form.ShowDialog();
        }
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Nhanvien form = new Nhanvien();
            form.Show();
        }
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            Baocao form = new Baocao();
            form.ShowDialog();
        }
        private void btn_gioithieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài tập lớn môn Công nghệ .NET do Kiều Anh Quân ĐH8C1 - Đại học Tài nguyên và Môi trường Hà Nội", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
