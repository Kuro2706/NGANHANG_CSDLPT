
namespace NGANHANG.MenuForm
{
    partial class FormChuyenTien
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
            System.Windows.Forms.Label lbSTKChuyen;
            System.Windows.Forms.Label lbSTKNhan;
            System.Windows.Forms.Label lbMANV;
            System.Windows.Forms.Label lbSoTien;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dataSet = new NGANHANG.NGANHANGDataSet();
            this.bdsGDChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.gcGD_ChuyenTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelChuyenTien = new System.Windows.Forms.Panel();
            this.sOTIENSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtSTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtSTKChuyen = new DevExpress.XtraEditors.TextEdit();
            this.btnSTKChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnSTKNhan = new DevExpress.XtraEditors.SimpleButton();
            lbSTKChuyen = new System.Windows.Forms.Label();
            lbSTKNhan = new System.Windows.Forms.Label();
            lbMANV = new System.Windows.Forms.Label();
            lbSoTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGD_ChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelChuyenTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKChuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSTKChuyen
            // 
            lbSTKChuyen.AutoSize = true;
            lbSTKChuyen.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSTKChuyen.Location = new System.Drawing.Point(213, 62);
            lbSTKChuyen.Name = "lbSTKChuyen";
            lbSTKChuyen.Size = new System.Drawing.Size(149, 19);
            lbSTKChuyen.TabIndex = 0;
            lbSTKChuyen.Text = "Số tài khoản chuyển:";
            // 
            // lbSTKNhan
            // 
            lbSTKNhan.AutoSize = true;
            lbSTKNhan.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSTKNhan.Location = new System.Drawing.Point(213, 140);
            lbSTKNhan.Name = "lbSTKNhan";
            lbSTKNhan.Size = new System.Drawing.Size(132, 19);
            lbSTKNhan.TabIndex = 2;
            lbSTKNhan.Text = "Số tài khoản nhận:";
            // 
            // lbMANV
            // 
            lbMANV.AutoSize = true;
            lbMANV.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbMANV.Location = new System.Drawing.Point(781, 144);
            lbMANV.Name = "lbMANV";
            lbMANV.Size = new System.Drawing.Size(103, 19);
            lbMANV.TabIndex = 6;
            lbMANV.Text = "Mã nhân viên:";
            // 
            // lbSoTien
            // 
            lbSoTien.AutoSize = true;
            lbSoTien.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSoTien.Location = new System.Drawing.Point(781, 62);
            lbSoTien.Name = "lbSoTien";
            lbSoTien.Size = new System.Drawing.Size(62, 19);
            lbSoTien.TabIndex = 7;
            lbSoTien.Text = "Số tiền:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.lbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1498, 100);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(243, 39);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(257, 24);
            this.cmbChiNhanh.TabIndex = 1;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(136, 42);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(71, 17);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NGANHANGDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGDChuyenTien
            // 
            this.bdsGDChuyenTien.DataMember = "GD_CHUYENTIEN";
            this.bdsGDChuyenTien.DataSource = this.dataSet;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGD_ChuyenTien
            // 
            this.gcGD_ChuyenTien.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gcGD_ChuyenTien.DataSource = this.bdsGDChuyenTien;
            this.gcGD_ChuyenTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGD_ChuyenTien.Location = new System.Drawing.Point(0, 100);
            this.gcGD_ChuyenTien.MainView = this.gridView1;
            this.gcGD_ChuyenTien.Name = "gcGD_ChuyenTien";
            this.gcGD_ChuyenTien.Size = new System.Drawing.Size(1498, 220);
            this.gcGD_ChuyenTien.TabIndex = 6;
            this.gcGD_ChuyenTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_NHAN,
            this.colMANV});
            this.gridView1.GridControl = this.gcGD_ChuyenTien;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGD.AppearanceCell.Options.UseFont = true;
            this.colMAGD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGD.AppearanceHeader.Options.UseFont = true;
            this.colMAGD.Caption = "Mã giao dịch";
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 25;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.OptionsColumn.ReadOnly = true;
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 93;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK_CHUYEN.AppearanceCell.Options.UseFont = true;
            this.colSOTK_CHUYEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK_CHUYEN.AppearanceHeader.Options.UseFont = true;
            this.colSOTK_CHUYEN.Caption = "Số tài khoản chuyển";
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 25;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.OptionsColumn.ReadOnly = true;
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 93;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYGD.AppearanceCell.Options.UseFont = true;
            this.colNGAYGD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYGD.AppearanceHeader.Options.UseFont = true;
            this.colNGAYGD.Caption = "Ngày giao dịch";
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.OptionsColumn.ReadOnly = true;
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 93;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIEN.AppearanceCell.Options.UseFont = true;
            this.colSOTIEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIEN.AppearanceHeader.Options.UseFont = true;
            this.colSOTIEN.Caption = "Số tiền";
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.OptionsColumn.ReadOnly = true;
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 93;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK_NHAN.AppearanceCell.Options.UseFont = true;
            this.colSOTK_NHAN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK_NHAN.AppearanceHeader.Options.UseFont = true;
            this.colSOTK_NHAN.Caption = "Số tài khoản nhận";
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 25;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.OptionsColumn.ReadOnly = true;
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 4;
            this.colSOTK_NHAN.Width = 93;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANV.AppearanceCell.Options.UseFont = true;
            this.colMANV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANV.AppearanceHeader.Options.UseFont = true;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 93;
            // 
            // panelChuyenTien
            // 
            this.panelChuyenTien.Controls.Add(this.btnSTKNhan);
            this.panelChuyenTien.Controls.Add(this.btnSTKChuyen);
            this.panelChuyenTien.Controls.Add(lbSoTien);
            this.panelChuyenTien.Controls.Add(this.sOTIENSpinEdit);
            this.panelChuyenTien.Controls.Add(lbMANV);
            this.panelChuyenTien.Controls.Add(this.txtMANV);
            this.panelChuyenTien.Controls.Add(lbSTKNhan);
            this.panelChuyenTien.Controls.Add(this.txtSTKNhan);
            this.panelChuyenTien.Controls.Add(lbSTKChuyen);
            this.panelChuyenTien.Controls.Add(this.txtSTKChuyen);
            this.panelChuyenTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChuyenTien.Location = new System.Drawing.Point(0, 320);
            this.panelChuyenTien.Name = "panelChuyenTien";
            this.panelChuyenTien.Size = new System.Drawing.Size(1498, 241);
            this.panelChuyenTien.TabIndex = 7;
            // 
            // sOTIENSpinEdit
            // 
            this.sOTIENSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDChuyenTien, "SOTIEN", true));
            this.sOTIENSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOTIENSpinEdit.Location = new System.Drawing.Point(900, 59);
            this.sOTIENSpinEdit.Name = "sOTIENSpinEdit";
            this.sOTIENSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOTIENSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sOTIENSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOTIENSpinEdit.Size = new System.Drawing.Size(150, 26);
            this.sOTIENSpinEdit.TabIndex = 8;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDChuyenTien, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(900, 137);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Size = new System.Drawing.Size(150, 26);
            this.txtMANV.TabIndex = 7;
            // 
            // txtSTKNhan
            // 
            this.txtSTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDChuyenTien, "SOTK_NHAN", true));
            this.txtSTKNhan.Location = new System.Drawing.Point(368, 137);
            this.txtSTKNhan.Name = "txtSTKNhan";
            this.txtSTKNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTKNhan.Properties.Appearance.Options.UseFont = true;
            this.txtSTKNhan.Size = new System.Drawing.Size(201, 26);
            this.txtSTKNhan.TabIndex = 3;
            // 
            // txtSTKChuyen
            // 
            this.txtSTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDChuyenTien, "SOTK_CHUYEN", true));
            this.txtSTKChuyen.Location = new System.Drawing.Point(368, 55);
            this.txtSTKChuyen.Name = "txtSTKChuyen";
            this.txtSTKChuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTKChuyen.Properties.Appearance.Options.UseFont = true;
            this.txtSTKChuyen.Size = new System.Drawing.Size(201, 26);
            this.txtSTKChuyen.TabIndex = 1;
            // 
            // btnSTKChuyen
            // 
            this.btnSTKChuyen.Location = new System.Drawing.Point(586, 55);
            this.btnSTKChuyen.Name = "btnSTKChuyen";
            this.btnSTKChuyen.Size = new System.Drawing.Size(26, 26);
            this.btnSTKChuyen.TabIndex = 21;
            this.btnSTKChuyen.Text = "...";
            // 
            // btnSTKNhan
            // 
            this.btnSTKNhan.Location = new System.Drawing.Point(586, 137);
            this.btnSTKNhan.Name = "btnSTKNhan";
            this.btnSTKNhan.Size = new System.Drawing.Size(26, 26);
            this.btnSTKNhan.TabIndex = 22;
            this.btnSTKNhan.Text = "...";
            // 
            // FormChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 561);
            this.Controls.Add(this.panelChuyenTien);
            this.Controls.Add(this.gcGD_ChuyenTien);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormChuyenTien";
            this.Text = "FormChuyenTien";
            this.Load += new System.EventHandler(this.FormChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGD_ChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelChuyenTien.ResumeLayout(false);
            this.panelChuyenTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTKChuyen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private NGANHANGDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsGDChuyenTien;
        private NGANHANGDataSetTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGD_ChuyenTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Panel panelChuyenTien;
        private DevExpress.XtraEditors.SpinEdit sOTIENSpinEdit;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtSTKNhan;
        private DevExpress.XtraEditors.TextEdit txtSTKChuyen;
        private DevExpress.XtraEditors.SimpleButton btnSTKChuyen;
        private DevExpress.XtraEditors.SimpleButton btnSTKNhan;
    }
}