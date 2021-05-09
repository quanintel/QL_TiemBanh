using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QL_TiemBanh
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        DataTable DataTable;
        private void FillHOADONBAN()
        {
            string sql;
            sql = "SELECT * FROM HOADONBAN";
            Functions.FillCombo(sql, cb_mahd, "MAHD", "MAHD");
        }
        private void FillKHACHHANG()
        {
            string sql;
            sql = "SELECT * FROM KHACHHANG";
            Functions.FillCombo(sql, cb_makh, "MAKH", "MAKH");
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
            MouveForm.Mouve.Go(panel1);
            FillHOADONBAN();
            FillKHACHHANG();
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            txt_soluong.Text = "0";
            txt_giamgia.Text = "0";
            txt_thanhtien.Text = "0";
            Functions.FillCombo("SELECT MAKH, TENKH FROM KHACHHANG", cb_makh, "MAKH", "MAKH");
            cb_makh.SelectedIndex = -1;
            Functions.FillCombo("SELECT MANV, TENNV FROM NHANVIEN", cb_manv, "MANV", "MANV");
            cb_manv.SelectedIndex = -1;
            Functions.FillCombo("SELECT MASP, TENSP FROM SANPHAM", cb_masp, "MASP", "MASP");
            cb_masp.SelectedIndex = -1;
            cb_mahd.SelectedIndex = -1;
            cb_manv.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT CHITIETHOADON.ID ,CHITIETHOADON.MASP, SANPHAM.TENSP, CHITIETHOADON.SL, SANPHAM.GIABAN, CHITIETHOADON.GIAMGIA, CHITIETHOADON.THANHTIEN " +
                "FROM ((CHITIETHOADON INNER JOIN HOADONBAN ON CHITIETHOADON.MAHD=HOADONBAN.MAHD)INNER JOIN SANPHAM ON SANPHAM.MASP=CHITIETHOADON.MASP) " +
                "WHERE CHITIETHOADON.MAHD = HOADONBAN.MAHD AND CHITIETHOADON.MAHD = '"+cb_mahd.Text+"' ";
            DataTable = Functions.GetDataToTable(sql);
            tb_chitietHD.DataSource = DataTable;
            tb_chitietHD.AllowUserToAddRows = false;
            tb_chitietHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            // Cập nhật lại tổng tiền cho hóa đơn bán
            sql = "SELECT SUM(CHITIETHOADON.THANHTIEN) AS TONG " +
                "FROM ((CHITIETHOADON INNER JOIN HOADONBAN ON CHITIETHOADON.MAHD=HOADONBAN.MAHD)INNER JOIN SANPHAM ON SANPHAM.MASP=CHITIETHOADON.MASP) " +
                "WHERE CHITIETHOADON.MAHD = '" + cb_mahd.Text + "'";
            DataTable = Functions.GetDataToTable(sql);
        }
        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (cb_manv.Text == "System.Data.DataRowView")
            {
                txt_tennv.Text = "";
                cb_manv.Text = "";
            }
            sql = "SELECT TENNV FROM NHANVIEN WHERE MANV='" + cb_manv.Text + "'";
            txt_tennv.Text = Functions.GetFieldValues(sql);
        }
        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (cb_makh.Text == "System.Data.DataRowView")
            {
                txt_tenkh.Text = "";
                txt_diachi.Text = "";
                txt_sdt.Text = "";
                cb_makh.Text = "";
            }
            sql = "SELECT TENKH FROM KHACHHANG WHERE MAKH='" + cb_makh.Text + "'";
            txt_tenkh.Text = Functions.GetFieldValues(sql);
            sql = "SELECT DIACHI FROM KHACHHANG WHERE MAKH='" + cb_makh.Text + "'";
            txt_diachi.Text = Functions.GetFieldValues(sql);
            sql = "SELECT DIENTHOAI FROM KHACHHANG WHERE MAKH='" + cb_makh.Text + "'";
            txt_sdt.Text = Functions.GetFieldValues(sql);
        }
        private void cb_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (cb_masp.Text == "System.Data.DataRowView")
            {
                txt_tensp.Text = "";
                txt_giasp.Text = "";
                cb_masp.Text = "";
            }
            sql = "SELECT TENSP FROM SANPHAM WHERE MASP='" + cb_masp.Text + "'";
            txt_tensp.Text = Functions.GetFieldValues(sql);
            sql = "SELECT GIABAN FROM SANPHAM WHERE MASP='" + cb_masp.Text + "'";
            txt_giasp.Text = Functions.GetFieldValues(sql);
            txt_soluong.Text = "0";
            txt_giamgia.Text = "0";
        }
        private void cb_mahd_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql;
            if (cb_mahd.Text == "System.Data.DataRowView")
            {
                cb_manv.Text = "";
                cb_makh.Text = "";
                cb_mahd.Text = "";
            }
            sql = "SELECT MAKH FROM HOADONBAN WHERE MAHD='" + cb_mahd.Text + "'";
            cb_makh.Text = Functions.GetFieldValues(sql);
            sql = "SELECT MANV FROM HOADONBAN WHERE MAHD='" + cb_mahd.Text + "'";
            cb_manv.Text = Functions.GetFieldValues(sql);
            LoadDataGridView();
            sql = "SELECT SUM(CHITIETHOADON.THANHTIEN) AS TONG FROM ((CHITIETHOADON INNER JOIN HOADONBAN ON CHITIETHOADON.MAHD=HOADONBAN.MAHD)INNER JOIN SANPHAM ON SANPHAM.MASP=CHITIETHOADON.MASP) WHERE CHITIETHOADON.MAHD = '" + cb_mahd.Text + "'";
            txt_tongtien.Text = Functions.GetFieldValues(sql);
        }
        private void cb_mahd_DropDown(object sender, EventArgs e)
        {
            FillHOADONBAN();
        }
        private void btn_taoHD_Click(object sender, EventArgs e)
        {
            string sql;
            if (cb_manv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên bán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_manv.Focus();
                return;
            }
            if (cb_makh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng mua !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_makh.Focus();
                return;
            }
            sql = "INSERT INTO HOADONBAN VALUES('"+cb_manv.Text.Trim()+"','"+cb_makh.Text.Trim()+"','"+ txt_ngayban.Value.ToString("yyyy-MM-dd") + "','')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
        }
        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE CHITIETHOADON WHERE MAHD=N'" + cb_mahd.Text + "'";
                Functions.RunSqlDel(sql);
                sql = "DELETE HOADONBAN WHERE MAHD=N'" + cb_mahd.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValue();
            }
        }
        private void btn_resetHD_Click(object sender, EventArgs e)
        {
            ResetValue();
            cb_masp.Text = "";
            txt_soluong.Text = "0";
            txt_giamgia.Text = "0";
        }
        private void tb_chitietHD_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_taoHD.Enabled = false;
            btn_xoaHD.Enabled = false;
            btn_resetHD.Enabled = true;
            cb_mahd.Enabled = false;
            txt_ngayban.Enabled = false;
            cb_manv.Enabled = false;
            cb_makh.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = true;
            cb_masp.Enabled = false;
            txt_id.Text = tb_chitietHD.CurrentRow.Cells["ID"].Value.ToString();
            cb_masp.Text = tb_chitietHD.CurrentRow.Cells["MASP"].Value.ToString();
            txt_soluong.Text = tb_chitietHD.CurrentRow.Cells["SL"].Value.ToString();
            temp_sl.Text = tb_chitietHD.CurrentRow.Cells["SL"].Value.ToString();
            txt_giamgia.Text = tb_chitietHD.CurrentRow.Cells["GIAMGIA"].Value.ToString();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            if (cb_mahd.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã hoá đơn cần thêm sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_mahd.Focus();
                return;
            }
            if (cb_masp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_masp.Focus();
                return;
            }
            if (txt_soluong.Text == "0")
            {
                MessageBox.Show("Vui lòng thêm số lượng số lượng của sản phẩm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return;
            }
            sql = "SELECT SANPHAM.TENSP " +
                "FROM ((CHITIETHOADON INNER JOIN HOADONBAN ON CHITIETHOADON.MAHD=HOADONBAN.MAHD)INNER JOIN SANPHAM ON SANPHAM.MASP=CHITIETHOADON.MASP) " +
                "WHERE CHITIETHOADON.MAHD = '"+ cb_mahd.Text +"' AND CHITIETHOADON.MASP = '"+ cb_masp.Text + "' ";
            if (Functions.CheckKey(sql) == true) {
                MessageBox.Show("Nguyên liệu này đã có trong danh sách !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_masp.Focus();
                return;
            }
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SL FROM SANPHAM WHERE MASP = N'" + cb_masp.Text + "'"));
            if (Convert.ToDouble(txt_soluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Text = "0";
                txt_soluong.Focus();
                return;
            }
            sql = "INSERT INTO CHITIETHOADON VALUES " +
                "('" + cb_mahd.Text + "','" + cb_masp.Text + "','" + txt_soluong.Text + "','" + txt_giasp.Text + "'," +
                "'" + txt_giamgia.Text + "','" + txt_thanhtien.Text + "')";
            Console.WriteLine(sql);
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txt_soluong.Text);
            sql = "UPDATE SANPHAM SET SL =" + SLcon + " WHERE MASP= N'" + cb_masp.Text + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM HOADONBAN WHERE MAHD = N'" + cb_mahd.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txt_thanhtien.Text);
            sql = "UPDATE HOADONBAN SET TONGTIEN =" + Tongmoi + " WHERE MAHD = N'" + cb_mahd.Text + "'";
            Functions.RunSQL(sql);
            txt_tongtien.Text = Tongmoi.ToString();
            //lbBangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            double tong, Tongmoi;
            double backSl;
            backSl = Convert.ToDouble(temp_sl.Text);
            sql = "UPDATE SANPHAM SET SL = SL + " + backSl + " WHERE MASP= N'" + cb_masp.Text + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM HOADONBAN WHERE MAHD = N'" + cb_mahd.Text + "'"));
            Tongmoi = tong - Convert.ToDouble(txt_thanhtien.Text);
            sql = "UPDATE HOADONBAN SET TONGTIEN =" + Tongmoi + " WHERE MAHD = N'" + cb_mahd.Text + "'";
            Functions.RunSQL(sql);
            
            if (DataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE CHITIETHOADON WHERE ID='" + txt_id.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                txt_tongtien.Text = Tongmoi.ToString();
                ResetVIP();
            }
        }
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "TIỆM BÁNH CỐI XAY GIÓ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Phú Diễn - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)65428771";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT HOADONBAN.MAHD,HOADONBAN.NGAYBAN,HOADONBAN.TONGTIEN,KHACHHANG.TENKH,KHACHHANG.DIACHI,KHACHHANG.DIENTHOAI,NHANVIEN.TENNV FROM ((HOADONBAN INNER JOIN NHANVIEN ON NHANVIEN.MANV=HOADONBAN.MANV)INNER JOIN KHACHHANG ON KHACHHANG.MAKH=HOADONBAN.MAKH) WHERE HOADONBAN.MAHD = '"+cb_mahd.Text+"'";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT SANPHAM.TENSP, CHITIETHOADON.SL, SANPHAM.GIABAN, CHITIETHOADON.GIAMGIA, CHITIETHOADON.THANHTIEN FROM ((CHITIETHOADON INNER JOIN HOADONBAN ON CHITIETHOADON.MAHD=HOADONBAN.MAHD)INNER JOIN SANPHAM ON SANPHAM.MASP=CHITIETHOADON.MASP) WHERE CHITIETHOADON.MAHD = HOADONBAN.MAHD AND CHITIETHOADON.MAHD = '"+cb_mahd.Text+"'";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            /*exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + tblThongtinHD.Rows[0][2].ToString();*/
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_giamgia.Text);
            if (txt_giasp.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_giasp.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }
        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            if (txt_giamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_giamgia.Text);
            if (txt_giasp.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_giasp.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_thanhtien.Text = tt.ToString();
        }
        private void ResetVIP()
        {
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            cb_mahd.Enabled = true;
            txt_ngayban.Enabled = true;
            cb_manv.Enabled = true;
            cb_makh.Enabled = true;
            btn_taoHD.Enabled = true;
            btn_xoaHD.Enabled = true;
            btn_resetHD.Enabled = true;
            cb_masp.Enabled = true;
            txt_soluong.Enabled = true;
            txt_giamgia.Enabled = true;
            cb_masp.Text = "";
            txt_soluong.Text = "0";
            txt_giamgia.Text = "0";
            txt_tensp.Text = "";
            txt_giasp.Text = "";
            txt_thanhtien.Text = "";
        }
        private void ResetValue()
        {
            cb_mahd.SelectedIndex = -1;
            txt_ngayban.Text = "";
            cb_manv.SelectedIndex = -1;
            txt_tennv.Text = "";
            cb_makh.SelectedIndex = -1;
            txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_tensp.Text = "";
            txt_giasp.Text = "";
            txt_thanhtien.Text = "";
        }
    }
}
