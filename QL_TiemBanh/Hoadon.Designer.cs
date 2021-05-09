
namespace QL_TiemBanh
{
    partial class Hoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            this.cb_masp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_mahd = new System.Windows.Forms.ComboBox();
            this.btn_resetHD = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_xoaHD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_taoHD = new System.Windows.Forms.Button();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.temp_sl = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.tb_chitietHD = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_giasp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chitietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_masp
            // 
            this.cb_masp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_masp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_masp.FormattingEnabled = true;
            this.cb_masp.Location = new System.Drawing.Point(119, 32);
            this.cb_masp.Name = "cb_masp";
            this.cb_masp.Size = new System.Drawing.Size(118, 24);
            this.cb_masp.TabIndex = 7;
            this.cb_masp.SelectedIndexChanged += new System.EventHandler(this.cb_masp_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cb_mahd);
            this.groupBox1.Controls.Add(this.btn_resetHD);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.btn_xoaHD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_taoHD);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ngayban);
            this.groupBox1.Controls.Add(this.cb_makh);
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 209);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_TiemBanh.Properties.Resources.windmill;
            this.pictureBox1.Location = new System.Drawing.Point(507, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // cb_mahd
            // 
            this.cb_mahd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_mahd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_mahd.FormattingEnabled = true;
            this.cb_mahd.Location = new System.Drawing.Point(119, 18);
            this.cb_mahd.Name = "cb_mahd";
            this.cb_mahd.Size = new System.Drawing.Size(228, 24);
            this.cb_mahd.TabIndex = 58;
            this.cb_mahd.DropDown += new System.EventHandler(this.cb_mahd_DropDown);
            this.cb_mahd.SelectedValueChanged += new System.EventHandler(this.cb_mahd_SelectedValueChanged);
            // 
            // btn_resetHD
            // 
            this.btn_resetHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetHD.Image = global::QL_TiemBanh.Properties.Resources.refresh;
            this.btn_resetHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resetHD.Location = new System.Drawing.Point(227, 150);
            this.btn_resetHD.Name = "btn_resetHD";
            this.btn_resetHD.Size = new System.Drawing.Size(83, 30);
            this.btn_resetHD.TabIndex = 57;
            this.btn_resetHD.Text = "Làm mới";
            this.btn_resetHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_resetHD.UseVisualStyleBackColor = true;
            this.btn_resetHD.Click += new System.EventHandler(this.btn_resetHD_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Location = new System.Drawing.Point(507, 110);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(194, 23);
            this.txt_sdt.TabIndex = 37;
            // 
            // btn_xoaHD
            // 
            this.btn_xoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaHD.Image = global::QL_TiemBanh.Properties.Resources.delete16x16;
            this.btn_xoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaHD.Location = new System.Drawing.Point(138, 150);
            this.btn_xoaHD.Name = "btn_xoaHD";
            this.btn_xoaHD.Size = new System.Drawing.Size(83, 30);
            this.btn_xoaHD.TabIndex = 56;
            this.btn_xoaHD.Text = "Xoá HĐ";
            this.btn_xoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaHD.UseVisualStyleBackColor = true;
            this.btn_xoaHD.Click += new System.EventHandler(this.btn_xoaHD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Enabled = false;
            this.txt_diachi.Location = new System.Drawing.Point(507, 80);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(194, 23);
            this.txt_diachi.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Địa chỉ";
            // 
            // btn_taoHD
            // 
            this.btn_taoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taoHD.Image = global::QL_TiemBanh.Properties.Resources.bill;
            this.btn_taoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taoHD.Location = new System.Drawing.Point(49, 150);
            this.btn_taoHD.Name = "btn_taoHD";
            this.btn_taoHD.Size = new System.Drawing.Size(83, 30);
            this.btn_taoHD.TabIndex = 54;
            this.btn_taoHD.Text = "Tạo HĐ";
            this.btn_taoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taoHD.UseVisualStyleBackColor = true;
            this.btn_taoHD.Click += new System.EventHandler(this.btn_taoHD_Click);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Enabled = false;
            this.txt_tenkh.Location = new System.Drawing.Point(507, 49);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(194, 23);
            this.txt_tenkh.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên khách hàng";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Enabled = false;
            this.txt_tennv.Location = new System.Drawing.Point(119, 110);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(228, 23);
            this.txt_tennv.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên nhân viên";
            // 
            // txt_ngayban
            // 
            this.txt_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngayban.Location = new System.Drawing.Point(119, 49);
            this.txt_ngayban.Name = "txt_ngayban";
            this.txt_ngayban.Size = new System.Drawing.Size(228, 23);
            this.txt_ngayban.TabIndex = 2;
            // 
            // cb_makh
            // 
            this.cb_makh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_makh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(507, 18);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(194, 24);
            this.cb_makh.TabIndex = 5;
            this.cb_makh.SelectedIndexChanged += new System.EventHandler(this.cb_makh_SelectedIndexChanged);
            // 
            // cb_manv
            // 
            this.cb_manv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_manv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(119, 79);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(228, 24);
            this.cb_manv.TabIndex = 3;
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã hoá đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xuat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_giamgia);
            this.groupBox2.Controls.Add(this.temp_sl);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.tb_chitietHD);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_giasp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_masp);
            this.groupBox2.Location = new System.Drawing.Point(9, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 302);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các sản phẩm";
            // 
            // btn_xuat
            // 
            this.btn_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xuat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xuat.Image = global::QL_TiemBanh.Properties.Resources.excel;
            this.btn_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuat.Location = new System.Drawing.Point(205, 268);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(81, 27);
            this.btn_xuat.TabIndex = 62;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Image = global::QL_TiemBanh.Properties.Resources.delete16x16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(120, 268);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 27);
            this.btn_xoa.TabIndex = 61;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_them.Image = global::QL_TiemBanh.Properties.Resources.add16x16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(35, 268);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 27);
            this.btn_them.TabIndex = 60;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(119, 62);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(118, 23);
            this.txt_soluong.TabIndex = 58;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(341, 61);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(152, 23);
            this.txt_giamgia.TabIndex = 57;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // temp_sl
            // 
            this.temp_sl.Location = new System.Drawing.Point(243, 3);
            this.temp_sl.Name = "temp_sl";
            this.temp_sl.Size = new System.Drawing.Size(59, 23);
            this.temp_sl.TabIndex = 56;
            this.temp_sl.Visible = false;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(583, 268);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(118, 23);
            this.txt_tongtien.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(506, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Tổng tiền";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(178, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(59, 23);
            this.txt_id.TabIndex = 53;
            this.txt_id.Visible = false;
            // 
            // tb_chitietHD
            // 
            this.tb_chitietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_chitietHD.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tb_chitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_chitietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MASP,
            this.TENSP,
            this.SL,
            this.GIABAN,
            this.GIAMGIA,
            this.THANHTIEN});
            this.tb_chitietHD.Location = new System.Drawing.Point(9, 91);
            this.tb_chitietHD.Name = "tb_chitietHD";
            this.tb_chitietHD.Size = new System.Drawing.Size(702, 172);
            this.tb_chitietHD.TabIndex = 49;
            this.tb_chitietHD.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_chitietHD_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Sản phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "Giảm giá";
            this.GIAMGIA.Name = "GIAMGIA";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(583, 62);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(118, 23);
            this.txt_thanhtien.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(502, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "Thành tiền";
            // 
            // txt_giasp
            // 
            this.txt_giasp.Enabled = false;
            this.txt_giasp.Location = new System.Drawing.Point(583, 32);
            this.txt_giasp.Name = "txt_giasp";
            this.txt_giasp.Size = new System.Drawing.Size(118, 23);
            this.txt_giasp.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Giá bán SP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Giảm giá%";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Enabled = false;
            this.txt_tensp.Location = new System.Drawing.Point(341, 32);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(152, 23);
            this.txt_tensp.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Số lượng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 11);
            this.panel1.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(276, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 28);
            this.label16.TabIndex = 30;
            this.label16.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_thoat.Image = global::QL_TiemBanh.Properties.Resources.exit;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(645, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 44);
            this.btn_thoat.TabIndex = 59;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(744, 592);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chitietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_masp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_ngayban;
        private System.Windows.Forms.ComboBox cb_makh;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tb_chitietHD;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_giasp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_resetHD;
        private System.Windows.Forms.Button btn_xoaHD;
        private System.Windows.Forms.Button btn_taoHD;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.TextBox temp_sl;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.ComboBox cb_mahd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}