
namespace NGANHANG.MenuForm
{
    partial class FormGoiRut
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
            System.Windows.Forms.Label lbSTK;
            System.Windows.Forms.Label lbLoaiGD;
            System.Windows.Forms.Label lbSoTien;
            System.Windows.Forms.Label lbMANV;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoiRut));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dataSet = new NGANHANG.NGANHANGDataSet();
            this.bdsGDGoiRut = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NGANHANG.NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.gcGDGoiRut = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.btnSTK = new DevExpress.XtraEditors.SimpleButton();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.sOTIENSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTaoGD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXacNhanGDChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            lbSTK = new System.Windows.Forms.Label();
            lbLoaiGD = new System.Windows.Forms.Label();
            lbSoTien = new System.Windows.Forms.Label();
            lbMANV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGDGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSTK.Location = new System.Drawing.Point(226, 51);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new System.Drawing.Size(97, 19);
            lbSTK.TabIndex = 0;
            lbSTK.Text = "Số tài khoản:";
            lbSTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoaiGD
            // 
            lbLoaiGD.AutoSize = true;
            lbLoaiGD.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbLoaiGD.Location = new System.Drawing.Point(226, 129);
            lbLoaiGD.Name = "lbLoaiGD";
            lbLoaiGD.Size = new System.Drawing.Size(111, 19);
            lbLoaiGD.TabIndex = 2;
            lbLoaiGD.Text = "Loại giao dịch:";
            lbLoaiGD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoTien
            // 
            lbSoTien.AutoSize = true;
            lbSoTien.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSoTien.Location = new System.Drawing.Point(705, 51);
            lbSoTien.Name = "lbSoTien";
            lbSoTien.Size = new System.Drawing.Size(62, 19);
            lbSoTien.TabIndex = 4;
            lbSoTien.Text = "Số tiền:";
            // 
            // lbMANV
            // 
            lbMANV.AutoSize = true;
            lbMANV.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbMANV.Location = new System.Drawing.Point(705, 129);
            lbMANV.Name = "lbMANV";
            lbMANV.Size = new System.Drawing.Size(103, 19);
            lbMANV.TabIndex = 6;
            lbMANV.Text = "Mã nhân viên:";
            lbMANV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.lbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1498, 100);
            this.panelControl1.TabIndex = 6;
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
            // bdsGDGoiRut
            // 
            this.bdsGDGoiRut.DataMember = "GD_GOIRUT";
            this.bdsGDGoiRut.DataSource = this.dataSet;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGDGoiRut
            // 
            this.gcGDGoiRut.DataSource = this.bdsGDGoiRut;
            this.gcGDGoiRut.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGDGoiRut.Location = new System.Drawing.Point(0, 129);
            this.gcGDGoiRut.MainView = this.gridView1;
            this.gcGDGoiRut.Name = "gcGDGoiRut";
            this.gcGDGoiRut.Size = new System.Drawing.Size(1498, 220);
            this.gcGDGoiRut.TabIndex = 7;
            this.gcGDGoiRut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gcGDGoiRut;
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
            // colSOTK
            // 
            this.colSOTK.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK.AppearanceCell.Options.UseFont = true;
            this.colSOTK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK.AppearanceHeader.Options.UseFont = true;
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.ReadOnly = true;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 93;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLOAIGD.AppearanceCell.Options.UseFont = true;
            this.colLOAIGD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLOAIGD.AppearanceHeader.Options.UseFont = true;
            this.colLOAIGD.Caption = "Loại giao dịch";
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.OptionsColumn.ReadOnly = true;
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 93;
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
            this.colNGAYGD.VisibleIndex = 3;
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
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 93;
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
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(this.btnSTK);
            this.panelNhapLieu.Controls.Add(lbMANV);
            this.panelNhapLieu.Controls.Add(this.txtMANV);
            this.panelNhapLieu.Controls.Add(lbSoTien);
            this.panelNhapLieu.Controls.Add(this.sOTIENSpinEdit);
            this.panelNhapLieu.Controls.Add(lbLoaiGD);
            this.panelNhapLieu.Controls.Add(this.cmbLoaiGD);
            this.panelNhapLieu.Controls.Add(lbSTK);
            this.panelNhapLieu.Controls.Add(this.txtSTK);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 349);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1498, 185);
            this.panelNhapLieu.TabIndex = 8;
            // 
            // btnSTK
            // 
            this.btnSTK.Location = new System.Drawing.Point(515, 48);
            this.btnSTK.Name = "btnSTK";
            this.btnSTK.Size = new System.Drawing.Size(26, 26);
            this.btnSTK.TabIndex = 22;
            this.btnSTK.Text = "...";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGoiRut, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(820, 122);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Size = new System.Drawing.Size(158, 26);
            this.txtMANV.TabIndex = 7;
            // 
            // sOTIENSpinEdit
            // 
            this.sOTIENSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGoiRut, "SOTIEN", true));
            this.sOTIENSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOTIENSpinEdit.Location = new System.Drawing.Point(820, 48);
            this.sOTIENSpinEdit.Name = "sOTIENSpinEdit";
            this.sOTIENSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOTIENSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sOTIENSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOTIENSpinEdit.Size = new System.Drawing.Size(158, 26);
            this.sOTIENSpinEdit.TabIndex = 5;
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGDGoiRut, "LOAIGD", true));
            this.cmbLoaiGD.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Location = new System.Drawing.Point(349, 126);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(151, 27);
            this.cmbLoaiGD.TabIndex = 3;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGoiRut, "SOTK", true));
            this.txtSTK.Location = new System.Drawing.Point(349, 48);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTK.Properties.Appearance.Options.UseFont = true;
            this.txtSTK.Size = new System.Drawing.Size(151, 26);
            this.txtSTK.TabIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoGD,
            this.btnXacNhanGDChuyenTien,
            this.btnHoanTac,
            this.btnLamMoi,
            this.btnMoTaiKhoan,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoGD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXacNhanGDChuyenTien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMoTaiKhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTaoGD
            // 
            this.btnTaoGD.Caption = "Tạo giao dịch mới";
            this.btnTaoGD.Id = 0;
            this.btnTaoGD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoGD.ImageOptions.SvgImage")));
            this.btnTaoGD.Name = "btnTaoGD";
            this.btnTaoGD.Size = new System.Drawing.Size(140, 0);
            // 
            // btnXacNhanGDChuyenTien
            // 
            this.btnXacNhanGDChuyenTien.Caption = "Xác nhận giao dịch";
            this.btnXacNhanGDChuyenTien.Id = 2;
            this.btnXacNhanGDChuyenTien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXacNhanGDChuyenTien.ImageOptions.SvgImage")));
            this.btnXacNhanGDChuyenTien.Name = "btnXacNhanGDChuyenTien";
            this.btnXacNhanGDChuyenTien.Size = new System.Drawing.Size(140, 0);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn Tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Id = 9;
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1498, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1498, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 505);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1498, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // FormGoiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 561);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcGDGoiRut);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGoiRut";
            this.Text = "FormGoiRut";
            this.Load += new System.EventHandler(this.FormGoiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGDGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOTIENSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private NGANHANGDataSet dataSet;
        private System.Windows.Forms.BindingSource bdsGDGoiRut;
        private NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGDGoiRut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Panel panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.SpinEdit sOTIENSpinEdit;
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraEditors.SimpleButton btnSTK;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTaoGD;
        private DevExpress.XtraBars.BarButtonItem btnXacNhanGDChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnMoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}