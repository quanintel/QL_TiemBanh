using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MouveForm;

namespace QL_TiemBanh
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NHANVIEN";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_nhanvien.DataSource = dataTable; //Nguồn dữ liệu            
            tb_nhanvien.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            txt_manv.Enabled = false;
            txt_user.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView();
        }
        private void tb_nhanvien_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_manv.Enabled = false;
            txt_user.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            ResetValue();
            txt_manv.Text = tb_nhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_tennv.Text = tb_nhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
            txt_user.Text = tb_nhanvien.CurrentRow.Cells["USERNAME"].Value.ToString();
            txt_pass.Text = tb_nhanvien.CurrentRow.Cells["PASSWORD"].Value.ToString();
            txt_quyen.Text = tb_nhanvien.CurrentRow.Cells["ROLE"].Value.ToString();
            txt_gioitinh.Text = tb_nhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txt_sdt.Text = tb_nhanvien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            txt_ngaysinh.Text = tb_nhanvien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_diachi.Text = tb_nhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txt_tennv.Text.Trim().Length == 0) // Chưa nhập tên
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return;
            }
            if (txt_user.Text.Trim().Length == 0) //Chưa nhập username
            {
                MessageBox.Show("Bạn chưa nhập tài khoản cho nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user.Focus();
                return;
            }
            if (txt_pass.Text.Trim().Length == 0) //Chưa nhập pass
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass.Focus();
                return;
            }
            if (txt_pass.Text.Trim().Length < 8) //Chưa nhập pass
            {
                MessageBox.Show("Bạn mật khẩu không đủ mạnh !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pass.Focus();
                return;
            }
            if (txt_quyen.Text.Trim().Length == 0) //Chưa chọn quyền
            {
                MessageBox.Show("Bạn chưa chọn quyền cho nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_quyen.Focus();
                return;
            }
            if (txt_gioitinh.Text == "") //Chưa chọn quyền
            {
                MessageBox.Show("Bạn giới tính cho nhân viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_gioitinh.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length < 11) //Chưa chọn quyền
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_gioitinh.Focus();
                return;
            }
            sql = "SELECT USERNAME FROM NHANVIEN WHERE USERNAME='" + txt_user.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Tài khoản này đã có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_user.Focus();
                return;
            }
            sql =   "INSERT INTO NHANVIEN VALUES (N'" + txt_tennv.Text + "',N'" + txt_user.Text + "',N'"+txt_pass.Text+ "',N'" + txt_quyen.Text + "',N'" + txt_gioitinh.Text + "',N'" + txt_sdt.Text + "','" + txt_ngaysinh.Value.ToString("yyyy-MM-dd") + "',N'" + txt_diachi.Text + "')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            ResetValueALL();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (txt_tennv.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_user.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập Username cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql =   "UPDATE NHANVIEN " +
                    "SET TENNV=N'" + txt_tennv.Text.ToString() + "', PASSWORD=N'" + txt_pass.Text.ToString() + "', ROLE=N'" + txt_quyen.Text.ToString() + "', GIOITINH=N'" + txt_gioitinh.Text.ToString() + "', DIENTHOAI=N'" + txt_sdt.Text.ToString() + "', NGAYSINH='" + txt_ngaysinh.Value.ToString("yyyy-MM-dd") + "', DIACHI=N'" + txt_diachi.Text.ToString() + "'" +
                    "WHERE MANV='" + txt_manv.Text + "'";
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
            if (txt_manv.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NHANVIEN WHERE MANV=N'" + txt_manv.Text + "'";
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
            sql = "SELECT * FROM NHANVIEN WHERE TENNV LIKE N'%" + txt_timkiem.Text + "%' OR MANV LIKE N'%" + txt_timkiem.Text + "%'";
            dataTable = Functions.GetDataToTable(sql);
            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //MessageBox.Show("Có " + dataTable.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_nhanvien.DataSource = dataTable;
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
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetValueALL();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ResetValueALL()
        {
            ResetValue();
            txt_manv.Enabled = false;
            txt_user.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void ResetValue()
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_user.Text = "";
            txt_pass.Text = "";
            txt_quyen.SelectedIndex = -1;
            txt_sdt.Text = "";
            txt_ngaysinh.Text = "";
            txt_gioitinh.SelectedIndex = -1;
            txt_diachi.Text = "";
        }
        private void tb_nhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
