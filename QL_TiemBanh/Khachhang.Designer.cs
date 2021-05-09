
namespace QL_TiemBanh
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.tb_khachhang = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 12);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_diachi);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.txt_tenkh);
            this.panel2.Controls.Add(this.txt_makh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 374);
            this.panel2.TabIndex = 11;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Image = global::QL_TiemBanh.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(293, 283);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 27);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.txt_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Image = global::QL_TiemBanh.Properties.Resources.delete16x16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(206, 283);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 27);
            this.btn_xoa.TabIndex = 40;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sua.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Image = global::QL_TiemBanh.Properties.Resources.edit16x16;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(119, 283);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 27);
            this.btn_sua.TabIndex = 39;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_them.Image = global::QL_TiemBanh.Properties.Resources.add16x16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(32, 283);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 27);
            this.btn_them.TabIndex = 38;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(136, 147);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(238, 76);
            this.txt_diachi.TabIndex = 35;
            this.txt_diachi.Text = "";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(136, 235);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(239, 23);
            this.txt_sdt.TabIndex = 37;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(137, 112);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(238, 23);
            this.txt_tenkh.TabIndex = 33;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(137, 77);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(238, 23);
            this.txt_makh.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 28);
            this.label10.TabIndex = 29;
            this.label10.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.btn_timkiem);
            this.panel3.Controls.Add(this.txt_timkiem);
            this.panel3.Controls.Add(this.tb_khachhang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(395, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 374);
            this.panel3.TabIndex = 12;
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_thoat.Image = global::QL_TiemBanh.Properties.Resources.exit;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(461, 3);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 44);
            this.btn_thoat.TabIndex = 29;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_timkiem.Image = global::QL_TiemBanh.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(75, 46);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(107, 27);
            this.btn_timkiem.TabIndex = 31;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(188, 48);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(273, 23);
            this.txt_timkiem.TabIndex = 30;
            this.txt_timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyDown);
            // 
            // tb_khachhang
            // 
            this.tb_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_khachhang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tb_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.diachi,
            this.sdt});
            this.tb_khachhang.Location = new System.Drawing.Point(15, 77);
            this.tb_khachhang.Name = "tb_khachhang";
            this.tb_khachhang.RowTemplate.Height = 25;
            this.tb_khachhang.Size = new System.Drawing.Size(531, 285);
            this.tb_khachhang.TabIndex = 10;
            this.tb_khachhang.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_khachhang_RowHeaderMouseDoubleClick);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MAKH";
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "TENKH";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.Name = "tenkh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DIACHI";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "DIENTHOAI";
            this.sdt.HeaderText = "Số Điện thoại";
            this.sdt.Name = "sdt";
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(953, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tb_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}