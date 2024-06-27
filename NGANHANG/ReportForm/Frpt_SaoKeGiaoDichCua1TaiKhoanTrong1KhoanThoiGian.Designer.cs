
namespace NGANHANG.ReportForm
{
    partial class Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian
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
            this.components = new System.ComponentModel.Container();
            this.lbTGBD = new System.Windows.Forms.Label();
            this.lbTGKT = new System.Windows.Forms.Label();
            this.dtPickTGBD = new System.Windows.Forms.DateTimePicker();
            this.dtPickTGKT = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dataSet = new NGANHANG.NGANHANGDataSet();
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.cmbSTK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTGBD
            // 
            this.lbTGBD.AutoSize = true;
            this.lbTGBD.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGBD.Location = new System.Drawing.Point(85, 113);
            this.lbTGBD.Name = "lbTGBD";
            this.lbTGBD.Size = new System.Drawing.Size(154, 22);
            this.lbTGBD.TabIndex = 11;
            this.lbTGBD.Text = "Thời gian bắt đầu:";
            this.lbTGBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTGKT
            // 
            this.lbTGKT.AutoSize = true;
            this.lbTGKT.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGKT.Location = new System.Drawing.Point(85, 179);
            this.lbTGKT.Name = "lbTGKT";
            this.lbTGKT.Size = new System.Drawing.Size(158, 22);
            this.lbTGKT.TabIndex = 13;
            this.lbTGKT.Text = "Thời gian kết thúc:";
            this.lbTGKT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPickTGBD
            // 
            this.dtPickTGBD.CalendarFont = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGBD.CustomFormat = "MM/dd/yyyy";
            this.dtPickTGBD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickTGBD.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickTGBD.Location = new System.Drawing.Point(281, 105);
            this.dtPickTGBD.Name = "dtPickTGBD";
            this.dtPickTGBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickTGBD.Size = new System.Drawing.Size(257, 30);
            this.dtPickTGBD.TabIndex = 14;
            // 
            // dtPickTGKT
            // 
            this.dtPickTGKT.CalendarFont = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGKT.CustomFormat = "MM/dd/yyyy";
            this.dtPickTGKT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickTGKT.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickTGKT.Location = new System.Drawing.Point(281, 171);
            this.dtPickTGKT.Name = "dtPickTGKT";
            this.dtPickTGKT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickTGKT.Size = new System.Drawing.Size(257, 30);
            this.dtPickTGKT.TabIndex = 16;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(150, 245);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(89, 31);
            this.btnPreview.TabIndex = 17;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(356, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(85, 51);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(113, 22);
            this.lbChiNhanh.TabIndex = 19;
            this.lbChiNhanh.Text = "Số tài khoản:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NGANHANGDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTaiKhoan
            // 
            this.bdsTaiKhoan.DataMember = "TaiKhoan";
            this.bdsTaiKhoan.DataSource = this.dataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbSTK
            // 
            this.cmbSTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTaiKhoan, "SOTK", true));
            this.cmbSTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSTK.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSTK.FormattingEnabled = true;
            this.cmbSTK.Location = new System.Drawing.Point(281, 43);
            this.cmbSTK.Name = "cmbSTK";
            this.cmbSTK.Size = new System.Drawing.Size(257, 30);
            this.cmbSTK.TabIndex = 21;
            // 
            // Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 325);
            this.Controls.Add(this.cmbSTK);
            this.Controls.Add(this.lbChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtPickTGKT);
            this.Controls.Add(this.dtPickTGBD);
            this.Controls.Add(this.lbTGKT);
            this.Controls.Add(this.lbTGBD);
            this.Name = "Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian";
            this.Text = "Sao kê giao dịch";
            this.Load += new System.EventHandler(this.Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTGBD;
        private System.Windows.Forms.Label lbTGKT;
        private System.Windows.Forms.DateTimePicker dtPickTGBD;
        private System.Windows.Forms.DateTimePicker dtPickTGKT;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbChiNhanh;
        private NGANHANGDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbSTK;
    }
}