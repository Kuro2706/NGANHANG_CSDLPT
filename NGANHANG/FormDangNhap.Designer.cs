
namespace NGANHANG
{
    partial class frmDangNhap
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKHDN = new System.Windows.Forms.CheckBox();
            this.hide = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.lbNganHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbKHDN);
            this.panelControl1.Controls.Add(this.hide);
            this.panelControl1.Controls.Add(this.show);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnDangNhap);
            this.panelControl1.Controls.Add(this.txtMatKhau);
            this.panelControl1.Controls.Add(this.txtTaiKhoan);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.lbMK);
            this.panelControl1.Controls.Add(this.lbTK);
            this.panelControl1.Controls.Add(this.lbChiNhanh);
            this.panelControl1.Controls.Add(this.lbNganHang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(798, 511);
            this.panelControl1.TabIndex = 6;
            // 
            // cbKHDN
            // 
            this.cbKHDN.AutoSize = true;
            this.cbKHDN.Location = new System.Drawing.Point(542, 400);
            this.cbKHDN.Name = "cbKHDN";
            this.cbKHDN.Size = new System.Drawing.Size(101, 21);
            this.cbKHDN.TabIndex = 19;
            this.cbKHDN.Text = "Khách Hàng";
            this.cbKHDN.UseVisualStyleBackColor = true;
            this.cbKHDN.CheckedChanged += new System.EventHandler(this.cbKHKN_CheckedChanged);
            // 
            // hide
            // 
            this.hide.Image = global::NGANHANG.Properties.Resources.hide;
            this.hide.Location = new System.Drawing.Point(599, 341);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(30, 30);
            this.hide.TabIndex = 18;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // show
            // 
            this.show.Image = global::NGANHANG.Properties.Resources.show;
            this.show.Location = new System.Drawing.Point(599, 341);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(30, 30);
            this.show.TabIndex = 17;
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label4
            // 
            this.label4.Image = global::NGANHANG.Properties.Resources.bank_icon;
            this.label4.Location = new System.Drawing.Point(349, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 130);
            this.label4.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(448, 439);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(195, 38);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Blue;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Location = new System.Drawing.Point(166, 439);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(195, 38);
            this.btnDangNhap.TabIndex = 14;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(429, 338);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(202, 34);
            this.txtMatKhau.TabIndex = 13;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(429, 279);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(202, 34);
            this.txtTaiKhoan.TabIndex = 12;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(429, 213);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(202, 34);
            this.cmbChiNhanh.TabIndex = 11;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(205, 345);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(137, 27);
            this.lbMK.TabIndex = 10;
            this.lbMK.Text = "MẬT KHẨU";
            this.lbMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(205, 282);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(142, 27);
            this.lbTK.TabIndex = 9;
            this.lbTK.Text = "TÀI KHOẢN";
            this.lbTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(205, 216);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(144, 27);
            this.lbChiNhanh.TabIndex = 8;
            this.lbChiNhanh.Text = "CHI NHÁNH";
            this.lbChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNganHang
            // 
            this.lbNganHang.AutoSize = true;
            this.lbNganHang.Font = new System.Drawing.Font("Times New Roman", 24.20168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganHang.Location = new System.Drawing.Point(277, 143);
            this.lbNganHang.Name = "lbNganHang";
            this.lbNganHang.Size = new System.Drawing.Size(268, 45);
            this.lbNganHang.TabIndex = 7;
            this.lbNganHang.Text = "NGÂN HÀNG";
            this.lbNganHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 511);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Label lbNganHang;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.CheckBox cbKHDN;
    }
}