using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_TiemBanh
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM KHACHHANG";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_khachhang.DataSource = dataTable; //Nguồn dữ liệu            
            tb_khachhang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_khachhang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            txt_makh.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txt_tenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkh.Focus();
                return;
            }
            sql = "INSERT INTO KHACHHANG VALUES (N'" + txt_tenkh.Text + "',N'" + txt_diachi.Text + "',N'" + txt_sdt.Text + "')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            ResetValueALL();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (txt_tenkh.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE KHACHHANG " +
                    "SET TENKH=N'" + txt_tenkh.Text.ToString() + "', DIACHI=N'" + txt_diachi.Text.ToString() + "', DIENTHOAI=N'" + txt_sdt.Text.ToString() + "'" +
                    "WHERE MAKH='" + txt_makh.Text + "'";
            Console.WriteLine(sql);
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            ResetValueALL();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE KHACHHANG WHERE MAKH=N'" + txt_makh.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
                ResetValueALL();
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng này đang phát triển !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string sql;
            if ((txt_timkiem.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM KHACHHANG WHERE MAKH LIKE N'%" + txt_timkiem.Text + "%' OR TENKH LIKE N'%" + txt_timkiem.Text + "%' OR MAKH LIKE N'%" + txt_timkiem + "%' OR DIACHI LIKE N'%" + txt_timkiem + "%'";
            dataTable = Functions.GetDataToTable(sql);
            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //MessageBox.Show("Có " + dataTable.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_khachhang.DataSource = dataTable;
                ResetValue();
            }
        }
        private void txt_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_timkiem_Click(this, new EventArgs());
            }
        }
        private void txt_reset_Click(object sender, EventArgs e)
        {
            ResetValueALL();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tb_khachhang_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_makh.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            ResetValue();
            txt_makh.Text = tb_khachhang.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_tenkh.Text = tb_khachhang.CurrentRow.Cells["TENKH"].Value.ToString();
            txt_diachi.Text = tb_khachhang.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = tb_khachhang.CurrentRow.Cells["SDT"].Value.ToString();
        }
        private void ResetValueALL()
        {
            ResetValue();
            txt_makh.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void ResetValue()
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_timkiem.Text = "";
        }

    }
}
