using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
namespace QL_TiemBanh
{
    public partial class Nguyenlieu : Form
    {
        public Nguyenlieu()
        {
            InitializeComponent();

        }
        DataTable dataTable;
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NGUYENLIEU";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_vatlieu.DataSource = dataTable; //Nguồn dữ liệu            
            tb_vatlieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_vatlieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void Vatlieu_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            txt_mavatlieu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void btn_themvl_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txt_tenvatlieu.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenvatlieu.Focus();
                return;
            }
            sql = "SELECT TENNL FROM NGUYENLIEU WHERE TENNL = N'" + txt_tenvatlieu.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Nguyên liệu này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenvatlieu.Focus();
                return;
            }
            sql = "INSERT INTO NGUYENLIEU VALUES(N'" + txt_tenvatlieu.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            ResetValueALL();
        }
        private void tb_vatlieu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_mavatlieu.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            ResetValue();
            txt_mavatlieu.Text = tb_vatlieu.CurrentRow.Cells["MANL"].Value.ToString();
            txt_tenvatlieu.Text = tb_vatlieu.CurrentRow.Cells["TENNL"].Value.ToString();
        }
        private void btn_suavl_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (txt_mavatlieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenvatlieu.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NGUYENLIEU SET TENNL=N'" + txt_tenvatlieu.Text.ToString() + "' WHERE MANL='" + txt_mavatlieu.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            ResetValueALL();
        }
        private void btn_xoavl_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mavatlieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NGUYENLIEU WHERE MANL=N'" + txt_mavatlieu.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
                ResetValueALL();
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
            txt_mavatlieu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void ResetValue()
        {
            txt_mavatlieu.Text = "";
            txt_tenvatlieu.Text = "";
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
            sql = "SELECT * FROM NGUYENLIEU WHERE MANL LIKE N'%" + txt_timkiem.Text + "%' OR TENNL LIKE N'%" + txt_timkiem.Text + "%' OR DIACHI LIKE N'%" + txt_timkiem + "%'";
            dataTable = Functions.GetDataToTable(sql);
            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //MessageBox.Show("Có " + dataTable.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_vatlieu.DataSource = dataTable;
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
    }
}
