using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TiemBanh
{
    public partial class Chitietcongthuc : Form
    {
        public Chitietcongthuc()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void FillNguyenLieu()
        {
            string sql;
            sql = "SELECT * FROM NGUYENLIEU";
            Functions.FillCombo(sql, cb_manl, "MANL", "TENNL");
        }
        private void Chitietcongthuc_Load(object sender, EventArgs e)
        {
            cb_mact.Text = Sanpham.value_cb_mact;
            txt_tenct.Text = Sanpham.value_cb_ten;
            FillNguyenLieu();
            cb_mact.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT CHITIETCONGTHUC.ID,NGUYENLIEU.TENNL,CHITIETCONGTHUC.SL,CHITIETCONGTHUC.DV FROM ((CHITIETCONGTHUC INNER JOIN CONGTHUC ON CHITIETCONGTHUC.MACT=CONGTHUC.MACT)INNER JOIN NGUYENLIEU ON CHITIETCONGTHUC.MANL=NGUYENLIEU.MANL) WHERE CHITIETCONGTHUC.MACT = '" + cb_mact.Text + "'";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_chitietcongthuc.DataSource = dataTable; //Nguồn dữ liệu            
            tb_chitietcongthuc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_chitietcongthuc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            sql = "SELECT * FROM ((CHITIETCONGTHUC INNER JOIN CONGTHUC ON CHITIETCONGTHUC.MACT=CONGTHUC.MACT)INNER JOIN NGUYENLIEU ON CHITIETCONGTHUC.MANL=NGUYENLIEU.MANL) WHERE CHITIETCONGTHUC.MACT = '" + cb_mact.Text.ToString() + "' AND NGUYENLIEU.MANL = '"+ cb_manl.SelectedValue.ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Nguyên liệu này đã có trong công thức, bạn hãy chọn nguyên liệu khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_manl.Focus();
                return;
            }
            if (txt_soluong.Value == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (cb_donvi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đơn vị cho nguyên liệu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_donvi.Focus();
                return;
            }
            sql = "INSERT INTO CHITIETCONGTHUC VALUES ('" + cb_mact.Text + "',N'" + cb_manl.SelectedValue.ToString() + "','" + txt_soluong.Text + "',N'" + cb_donvi.Text + "')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            ResetValueALL();
        }
        private void tb_chitietcongthuc_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cb_mact.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            ResetValue();
            id_chitiet.Text = tb_chitietcongthuc.CurrentRow.Cells["ID"].Value.ToString();
            cb_manl.Text = tb_chitietcongthuc.CurrentRow.Cells["TENNL"].Value.ToString();
            txt_soluong.Text = tb_chitietcongthuc.CurrentRow.Cells["SL"].Value.ToString();
            cb_donvi.Text = tb_chitietcongthuc.CurrentRow.Cells["DV"].Value.ToString();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            sql = "UPDATE CHITIETCONGTHUC " +
                    "SET MANL='" + cb_manl.SelectedValue.ToString() + "', SL='" + txt_soluong.Text.ToString() + "', DV=N'" + cb_donvi.Text.ToString() + "'" +
                    "WHERE ID='" + id_chitiet.Text.ToString() + "'";
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
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE CHITIETCONGTHUC WHERE ID=N'" + id_chitiet.Text + "'";
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
        private void ResetValueALL()
        {
            ResetValue();
            cb_mact.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatLieu
        }
        private void ResetValue()
        {
            cb_manl.Text = "";
            txt_soluong.Text = "";
            cb_donvi.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Sanpham form = new Sanpham();
            
            this.Hide();
        }
    }
}
