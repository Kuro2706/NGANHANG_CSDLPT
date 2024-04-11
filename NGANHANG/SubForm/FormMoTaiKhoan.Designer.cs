
namespace NGANHANG.SubForm
{
    partial class FormMoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbSTK = new System.Windows.Forms.Label();
            this.lbSoDu = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.78151F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(193, 183);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(77, 23);
            this.lbCMND.TabIndex = 1;
            this.lbCMND.Text = "CMND:";
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTK.Location = new System.Drawing.Point(192, 238);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(121, 23);
            this.lbSTK.TabIndex = 2;
            this.lbSTK.Text = "Số tài khoản:";
            // 
            // lbSoDu
            // 
            this.lbSoDu.AutoSize = true;
            this.lbSoDu.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDu.Location = new System.Drawing.Point(192, 295);
            this.lbSoDu.Name = "lbSoDu";
            this.lbSoDu.Size = new System.Drawing.Size(65, 23);
            this.lbSoDu.TabIndex = 3;
            this.lbSoDu.Text = "Số dư:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(399, 177);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Size = new System.Drawing.Size(234, 30);
            this.txtCMND.TabIndex = 4;
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(399, 232);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTK.Properties.Appearance.Options.UseFont = true;
            this.txtSTK.Size = new System.Drawing.Size(234, 30);
            this.txtSTK.TabIndex = 5;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(399, 292);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDu.Properties.Appearance.Options.UseFont = true;
            this.txtSoDu.Size = new System.Drawing.Size(234, 30);
            this.txtSoDu.TabIndex = 6;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.Location = new System.Drawing.Point(155, 370);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(195, 38);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(438, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(195, 38);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(193, 126);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(101, 23);
            this.lbChiNhanh.TabIndex = 17;
            this.lbChiNhanh.Text = "Chi nhánh:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(399, 122);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(234, 30);
            this.cmbChiNhanh.TabIndex = 18;
            // 
            // FormMoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 511);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.lbChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lbSoDu);
            this.Controls.Add(this.lbSTK);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.label1);
            this.Name = "FormMoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMoTaiKhoan";
            this.Load += new System.EventHandler(this.FormMoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.Label lbSoDu;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}