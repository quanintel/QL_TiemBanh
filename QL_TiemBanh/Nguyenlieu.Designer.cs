
namespace QL_TiemBanh
{
    partial class Nguyenlieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nguyenlieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenvatlieu = new System.Windows.Forms.TextBox();
            this.txt_mavatlieu = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.tb_vatlieu = new System.Windows.Forms.DataGridView();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 10);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_tenvatlieu);
            this.panel2.Controls.Add(this.txt_mavatlieu);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 398);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_TiemBanh.Properties.Resources.giftest_2;
            this.pictureBox1.Location = new System.Drawing.Point(74, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã nguyên liệu";
            // 
            // txt_tenvatlieu
            // 
            this.txt_tenvatlieu.Location = new System.Drawing.Point(137, 128);
            this.txt_tenvatlieu.Name = "txt_tenvatlieu";
            this.txt_tenvatlieu.Size = new System.Drawing.Size(240, 23);
            this.txt_tenvatlieu.TabIndex = 23;
            // 
            // txt_mavatlieu
            // 
            this.txt_mavatlieu.Location = new System.Drawing.Point(137, 87);
            this.txt_mavatlieu.Name = "txt_mavatlieu";
            this.txt_mavatlieu.Size = new System.Drawing.Size(240, 23);
            this.txt_mavatlieu.TabIndex = 22;
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Image = global::QL_TiemBanh.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(283, 172);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 27);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Image = global::QL_TiemBanh.Properties.Resources.delete16x16;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(196, 172);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 27);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoavl_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sua.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Image = global::QL_TiemBanh.Properties.Resources.edit16x16;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(109, 172);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 27);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_suavl_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_them.Image = global::QL_TiemBanh.Properties.Resources.add16x16;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(22, 172);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 27);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_themvl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_timkiem);
            this.panel3.Controls.Add(this.txt_timkiem);
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.tb_vatlieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(392, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 398);
            this.panel3.TabIndex = 4;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_timkiem.Image = global::QL_TiemBanh.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(32, 32);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(107, 27);
            this.btn_timkiem.TabIndex = 33;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(145, 34);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(183, 23);
            this.txt_timkiem.TabIndex = 32;
            this.txt_timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyDown);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_thoat.Image = global::QL_TiemBanh.Properties.Resources.exit;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(334, 6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 44);
            this.btn_thoat.TabIndex = 31;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // tb_vatlieu
            // 
            this.tb_vatlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_vatlieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tb_vatlieu.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tb_vatlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manl,
            this.tennl});
            this.tb_vatlieu.Location = new System.Drawing.Point(6, 63);
            this.tb_vatlieu.Name = "tb_vatlieu";
            this.tb_vatlieu.RowTemplate.Height = 25;
            this.tb_vatlieu.Size = new System.Drawing.Size(422, 332);
            this.tb_vatlieu.TabIndex = 2;
            this.tb_vatlieu.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_vatlieu_RowHeaderMouseDoubleClick);
            // 
            // manl
            // 
            this.manl.DataPropertyName = "MANL";
            this.manl.HeaderText = "Mã Nguyên Liệu";
            this.manl.Name = "manl";
            // 
            // tennl
            // 
            this.tennl.DataPropertyName = "TENNL";
            this.tennl.HeaderText = "Tên Nguyên Liệu";
            this.tennl.Name = "tennl";
            // 
            // Nguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(823, 408);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nguyenlieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nguyên liệu";
            this.Load += new System.EventHandler(this.Vatlieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vatlieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tb_vatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenvatlieu;
        private System.Windows.Forms.TextBox txt_mavatlieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}