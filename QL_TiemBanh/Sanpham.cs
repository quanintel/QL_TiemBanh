using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_TiemBanh
{
    public partial class Sanpham : Form
    {
        public static string value_cb_mact = "";
        public static string value_cb_ten = "";
        public Sanpham()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void LoadDataGridView1()
        {
            string sql;
            sql = "SELECT * FROM SANPHAM";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_sanpham.DataSource = dataTable; //Nguồn dữ liệu            
            tb_sanpham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_sanpham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void LoadDataGridView3()
        {
            string sql;
            sql = "SELECT NGUYENLIEU.TENNL,CHITIETCONGTHUC.SL,CHITIETCONGTHUC.DV FROM ((CHITIETCONGTHUC INNER JOIN CONGTHUC ON CHITIETCONGTHUC.MACT=CONGTHUC.MACT)INNER JOIN NGUYENLIEU ON CHITIETCONGTHUC.MANL=NGUYENLIEU.MANL) WHERE CHITIETCONGTHUC.MACT = '0'";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_congthuc.DataSource = dataTable; //Nguồn dữ liệu            
            tb_congthuc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_congthuc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void LoadDataGridView2()
        {
            string sql;
            sql = "SELECT NGUYENLIEU.TENNL,CHITIETCONGTHUC.SL,CHITIETCONGTHUC.DV FROM ((CHITIETCONGTHUC INNER JOIN CONGTHUC ON CHITIETCONGTHUC.MACT=CONGTHUC.MACT)INNER JOIN NGUYENLIEU ON CHITIETCONGTHUC.MANL=NGUYENLIEU.MANL) WHERE CHITIETCONGTHUC.MACT = '"+cb_tenct.SelectedValue.ToString()+"'";
            dataTable = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            tb_congthuc.DataSource = dataTable; //Nguồn dữ liệu            
            tb_congthuc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            tb_congthuc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void FillCongThuc()
        {
            string sql;
            sql = "SELECT * FROM CONGTHUC";
            Functions.FillCombo(sql, cb_tenct, "MACT", "TENCT");
        }
        private void Sanpham_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            ResetValue();
            txt_masp.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView1();
        }
        private void cb_tenct_DropDown(object sender, EventArgs e)
        {
            FillCongThuc();
        }
        private void cb_tenct_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView2();
        }
        private void btn_themct_Click(object sender, EventArgs e)
        {
            if (cb_tenct.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql; //Lưu lệnh sql
            if (cb_tenct.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công thức", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenct.Focus();
                return;
            }
            sql = "SELECT TENCT FROM CONGTHUC WHERE TENCT=N'" + cb_tenct.Text.ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Tên công thức này đã có, mời bạn nhập tên khác !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_tenct.Focus();
                return;
            }
            sql = "INSERT INTO CONGTHUC VALUES (N'" + cb_tenct.Text.ToString() + "')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            FillCongThuc();
        }
        private void btn_suact_Click(object sender, EventArgs e)
        {
            if (cb_tenct.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            value_cb_mact = cb_tenct.SelectedValue.ToString();
            value_cb_ten = cb_tenct.Text.ToString();
            Chitietcongthuc formChitietconthuc = new Chitietcongthuc();
            formChitietconthuc.ShowDialog();
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            if (cb_tenct.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                LoadDataGridView2();
            }
        }
        private void Btn_xoaCT_Click(object sender, EventArgs e)
        {
            string sql;
            if (cb_tenct.Text.ToString() == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE CONGTHUC WHERE MACT=N'" + cb_tenct.SelectedValue.ToString() + "'";
                Functions.RunSqlDel(sql);
                FillCongThuc();
            }
        }
        private void ResetValueALL()
        {
            ResetValue();
            txt_masp.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            LoadDataGridView1(); //Hiển thị bảng tblChatLieu
        }
        private void ResetValue()
        {
            txt_masp.Text = "";
            txt_tensp.Text = "";
            cb_tenct.Text = "";
            txt_soluong.Text = "0";
            txt_giaban.Text = "";
            txt_ghichu.Text = "";
            view_anh.Image = null;
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                view_anh.Image = Image.FromFile(dlgOpen.FileName);
                txt_pic.Text = dlgOpen.FileName;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            sql = "SELECT TENSP FROM SANPHAM WHERE TENSP = N'" + txt_tensp.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Nguyên liệu này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensp.Focus();
                return;
            }
            if (txt_tensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên cho sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            if (cb_tenct.Text.ToString() == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn công thức", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_pic.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_open.Focus();
                return;
            }
            sql = "INSERT INTO SANPHAM VALUES(N'" + txt_tensp.Text + "',N'"+ cb_tenct.SelectedValue.ToString() + "',N'"+txt_soluong.Value+ "',N'" + txt_giaban.Text.ToString() + "',N'" + txt_nsx.Value.ToString("yyyy-MM-dd") + "',N'" + txt_hsd.Value.ToString("yyyy-MM-dd") + "',N'" + txt_pic.Text.ToString() + "',N'"+txt_ghichu.Text.ToString()+"')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView1(); //Nạp lại DataGridView
            ResetValue();
            ResetValueALL();
        }
        private void tb_sanpham_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_masp.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            ResetValue();
            txt_masp.Text = tb_sanpham.CurrentRow.Cells["MASP"].Value.ToString();
            txt_tensp.Text = tb_sanpham.CurrentRow.Cells["TENSP"].Value.ToString();
            FillCongThuc();
            cb_tenct.SelectedValue = tb_sanpham.CurrentRow.Cells["MACT"].Value.ToString();
            LoadDataGridView2();
            txt_soluong.Text = tb_sanpham.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_giaban.Text = tb_sanpham.CurrentRow.Cells["GIABAN"].Value.ToString();
            txt_nsx.Text = tb_sanpham.CurrentRow.Cells["NSX"].Value.ToString();
            txt_hsd.Text = tb_sanpham.CurrentRow.Cells["HSD"].Value.ToString();
            txt_ghichu.Text = tb_sanpham.CurrentRow.Cells["GHICHU"].Value.ToString();
            txt_pic.Text = tb_sanpham.CurrentRow.Cells["ANH"].Value.ToString();
            view_anh.Image = Image.FromFile(txt_pic.Text);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (tb_sanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT TENSP FROM SANPHAM WHERE TENSP = N'" + txt_tensp.Text.Trim() + "'";
            if (Functions.CheckKey1(sql))
            {
                MessageBox.Show("Nguyên liệu này đã có !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensp.Focus();
                return;
            }
            if (txt_tensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên cho sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            if (cb_tenct.Text.ToString() == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn công thức", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_pic.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_open.Focus();
                return;
            }
            sql = "UPDATE SANPHAM SET TENSP=N'" + txt_tensp.Text.Trim().ToString() +
                "',MACT=N'" + cb_tenct.SelectedValue.ToString() +
                "',SL=" + txt_soluong.Text +
                ",GIABAN='" + txt_giaban.Text + "',NGAYSX=N'" + txt_nsx.Value.ToString("yyyy-MM-dd") + "',HSD=N'" + txt_hsd.Value.ToString("yyyy-MM-dd") + "',ANH=N'" + txt_pic.Text + "',GHICHU=N'" + txt_ghichu.Text + "' WHERE MASP=N'" + txt_masp.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView1();
            LoadDataGridView3();
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
                sql = "DELETE SANPHAM WHERE MASP=N'" + txt_masp.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView3();
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
            sql = "SELECT * FROM SANPHAM WHERE MASP LIKE N'%" + txt_timkiem.Text + "%' OR TENSP LIKE N'%" + txt_timkiem.Text + "%'";
            dataTable = Functions.GetDataToTable(sql);
            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //MessageBox.Show("Có " + dataTable.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_sanpham.DataSource = dataTable;
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
            LoadDataGridView1();
            LoadDataGridView3();
            ResetValue();
            ResetValueALL();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
