
namespace NGANHANG.ReportForm
{
    partial class Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.lbTGBD = new System.Windows.Forms.Label();
            this.lbTGKT = new System.Windows.Forms.Label();
            this.dtPickTGBD = new System.Windows.Forms.DateTimePicker();
            this.dtPickTGKT = new System.Windows.Forms.DateTimePicker();
            this.dataSet = new NGANHANG.NGANHANGDataSet();
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(371, 241);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(174, 241);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(89, 31);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Items.AddRange(new object[] {
            "BẾN THÀNH",
            "TÂN ĐỊNH",
            "CẢ 2 CHI NHÁNH"});
            this.cmbChiNhanh.Location = new System.Drawing.Point(303, 40);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(257, 30);
            this.cmbChiNhanh.TabIndex = 7;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(102, 48);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(99, 22);
            this.lbChiNhanh.TabIndex = 6;
            this.lbChiNhanh.Text = "Chi Nhánh:";
            // 
            // lbTGBD
            // 
            this.lbTGBD.AutoSize = true;
            this.lbTGBD.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGBD.Location = new System.Drawing.Point(102, 113);
            this.lbTGBD.Name = "lbTGBD";
            this.lbTGBD.Size = new System.Drawing.Size(154, 22);
            this.lbTGBD.TabIndex = 10;
            this.lbTGBD.Text = "Thời gian bắt đầu:";
            this.lbTGBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTGKT
            // 
            this.lbTGKT.AutoSize = true;
            this.lbTGKT.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGKT.Location = new System.Drawing.Point(102, 178);
            this.lbTGKT.Name = "lbTGKT";
            this.lbTGKT.Size = new System.Drawing.Size(158, 22);
            this.lbTGKT.TabIndex = 12;
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
            this.dtPickTGBD.Location = new System.Drawing.Point(303, 112);
            this.dtPickTGBD.Name = "dtPickTGBD";
            this.dtPickTGBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickTGBD.Size = new System.Drawing.Size(257, 30);
            this.dtPickTGBD.TabIndex = 13;
            // 
            // dtPickTGKT
            // 
            this.dtPickTGKT.CalendarFont = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGKT.CustomFormat = "MM/dd/yyyy";
            this.dtPickTGKT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickTGKT.Font = new System.Drawing.Font("Times New Roman", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickTGKT.Location = new System.Drawing.Point(303, 178);
            this.dtPickTGKT.Name = "dtPickTGKT";
            this.dtPickTGKT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickTGKT.Size = new System.Drawing.Size(257, 30);
            this.dtPickTGKT.TabIndex = 15;
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
            // Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 325);
            this.Controls.Add(this.dtPickTGKT);
            this.Controls.Add(this.dtPickTGBD);
            this.Controls.Add(this.lbTGKT);
            this.Controls.Add(this.lbTGBD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.lbChiNhanh);
            this.Name = "Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian";
            this.Text = "Liệt kê tài khoản";
            this.Load += new System.EventHandler(this.Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Label lbTGBD;
        private System.Windows.Forms.Label lbTGKT;
        private System.Windows.Forms.DateTimePicker dtPickTGBD;
        private System.Windows.Forms.DateTimePicker dtPickTGKT;
        private NGANHANGDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}