
namespace QL_TiemBanh
{
    partial class Baocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 14);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rpvBaoCao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 520);
            this.panel2.TabIndex = 1;
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(789, 520);
            this.rpvBaoCao.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBaoCao);
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.dtpNgaySX);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 56);
            this.panel3.TabIndex = 2;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.Image = global::QL_TiemBanh.Properties.Resources.search;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(426, 15);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(128, 27);
            this.btnBaoCao.TabIndex = 33;
            this.btnBaoCao.Text = "Tạo báo cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_thoat.Image = global::QL_TiemBanh.Properties.Resources.exit;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(692, 6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(85, 44);
            this.btn_thoat.TabIndex = 32;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(296, 17);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(130, 22);
            this.dtpNgaySX.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày sản xuất báo cáo: ";
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(789, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.Load += new System.EventHandler(this.Baocao_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label label3;
    }
}