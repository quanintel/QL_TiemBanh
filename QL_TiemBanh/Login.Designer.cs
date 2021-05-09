
namespace QL_TiemBanh
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.lb_pass.Location = new System.Drawing.Point(201, 160);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(64, 16);
            this.lb_pass.TabIndex = 12;
            this.lb_pass.Text = "Mật khẩu";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.lb_user.Location = new System.Drawing.Point(201, 110);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(99, 16);
            this.lb_user.TabIndex = 11;
            this.lb_user.Text = "Tên đăng nhập";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(304, 153);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(208, 23);
            this.txt_pass.TabIndex = 9;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(304, 108);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(208, 23);
            this.txt_user.TabIndex = 8;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Roboto Mono", 13F, System.Drawing.FontStyle.Bold);
            this.lb_login.Location = new System.Drawing.Point(293, 58);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(109, 24);
            this.lb_login.TabIndex = 7;
            this.lb_login.Text = "ĐĂNG NHẬP";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_login.Image = global::QL_TiemBanh.Properties.Resources.login;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(242, 191);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(115, 41);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btn_thoat.Image = global::QL_TiemBanh.Properties.Resources.exit;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(380, 191);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(94, 41);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_TiemBanh.Properties.Resources.coixaygio;
            this.pictureBox1.Location = new System.Drawing.Point(15, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.lb_pass);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 297);
            this.panel1.TabIndex = 15;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(183)))), ((int)(((byte)(26)))));
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(536, 297);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(536, 297);
            this.MinimumSize = new System.Drawing.Size(536, 297);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIỆM BÁNH CỐI XAY GIÓ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Panel panel1;
    }
}

