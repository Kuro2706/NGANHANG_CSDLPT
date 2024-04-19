
namespace NGANHANG
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoKeGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnLietKeTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLietKeKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnGDChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnGDGoiRut = new DevExpress.XtraBars.BarButtonItem();
            this.pageDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANHANVIEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem2,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnSaoKeGiaoDich,
            this.btnLietKeTaiKhoan,
            this.btnLietKeKhachHang,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnTaoTaiKhoan,
            this.btnThoat,
            this.btnTaiKhoan,
            this.btnGDChuyenTien,
            this.btnGDGoiRut});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 48;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageDangNhap,
            this.pageQuanLy,
            this.pageNghiepVu,
            this.pageBaoCao});
            this.ribbon.Size = new System.Drawing.Size(1598, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 26;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "NHÂN VIÊN";
            this.btnNhanVien.Id = 27;
            this.btnNhanVien.ImageOptions.Image = global::NGANHANG.Properties.Resources.employee__1_;
            this.btnNhanVien.LargeWidth = 100;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "KHÁCH HÀNG";
            this.btnKhachHang.Id = 29;
            this.btnKhachHang.ImageOptions.Image = global::NGANHANG.Properties.Resources.rating_icon;
            this.btnKhachHang.LargeWidth = 100;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnSaoKeGiaoDich
            // 
            this.btnSaoKeGiaoDich.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnSaoKeGiaoDich.Caption = "SAO KÊ GIAO DỊCH";
            this.btnSaoKeGiaoDich.Id = 30;
            this.btnSaoKeGiaoDich.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoKeGiaoDich.ImageOptions.Image")));
            this.btnSaoKeGiaoDich.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoKeGiaoDich.ImageOptions.LargeImage")));
            this.btnSaoKeGiaoDich.LargeWidth = 100;
            this.btnSaoKeGiaoDich.Name = "btnSaoKeGiaoDich";
            this.btnSaoKeGiaoDich.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLietKeTaiKhoan
            // 
            this.btnLietKeTaiKhoan.Caption = "LIỆT KÊ TÀI KHOẢN";
            this.btnLietKeTaiKhoan.Id = 31;
            this.btnLietKeTaiKhoan.ImageOptions.Image = global::NGANHANG.Properties.Resources.user__1_;
            this.btnLietKeTaiKhoan.LargeWidth = 100;
            this.btnLietKeTaiKhoan.Name = "btnLietKeTaiKhoan";
            this.btnLietKeTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLietKeKhachHang
            // 
            this.btnLietKeKhachHang.Caption = "LIỆT KÊ KHÁCH HÀNG";
            this.btnLietKeKhachHang.Id = 32;
            this.btnLietKeKhachHang.ImageOptions.Image = global::NGANHANG.Properties.Resources.rating_icon;
            this.btnLietKeKhachHang.LargeWidth = 100;
            this.btnLietKeKhachHang.Name = "btnLietKeKhachHang";
            this.btnLietKeKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Id = 33;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.LargeWidth = 100;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 34;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.LargeWidth = 100;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "TẠO TÀI KHOẢN";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 35;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.LargeWidth = 100;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 36;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.LargeWidth = 100;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "TÀI KHOẢN";
            this.btnTaiKhoan.Id = 42;
            this.btnTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaiKhoan.LargeWidth = 100;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiKhoan_ItemClick);
            // 
            // btnGDChuyenTien
            // 
            this.btnGDChuyenTien.Caption = "Chuyển tiền";
            this.btnGDChuyenTien.Id = 44;
            this.btnGDChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGDChuyenTien.ImageOptions.Image")));
            this.btnGDChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGDChuyenTien.ImageOptions.LargeImage")));
            this.btnGDChuyenTien.LargeWidth = 100;
            this.btnGDChuyenTien.Name = "btnGDChuyenTien";
            this.btnGDChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGDChuyenTien_ItemClick);
            // 
            // btnGDGoiRut
            // 
            this.btnGDGoiRut.Caption = "Gởi / Rút";
            this.btnGDGoiRut.Id = 47;
            this.btnGDGoiRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGDGoiRut.ImageOptions.Image")));
            this.btnGDGoiRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGDGoiRut.ImageOptions.LargeImage")));
            this.btnGDGoiRut.LargeWidth = 100;
            this.btnGDGoiRut.Name = "btnGDGoiRut";
            this.btnGDGoiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGDGoiRut_ItemClick);
            // 
            // pageDangNhap
            // 
            this.pageDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageDangNhap.Appearance.Options.UseFont = true;
            this.pageDangNhap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageDangNhap.Name = "pageDangNhap";
            this.pageDangNhap.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // pageQuanLy
            // 
            this.pageQuanLy.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageQuanLy.Appearance.Options.UseFont = true;
            this.pageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageQuanLy.Name = "pageQuanLy";
            this.pageQuanLy.Text = "QUẢN LÝ";
            this.pageQuanLy.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // pageNghiepVu
            // 
            this.pageNghiepVu.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNghiepVu.Appearance.Options.UseFont = true;
            this.pageNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.pageNghiepVu.Name = "pageNghiepVu";
            this.pageNghiepVu.Text = "NGHIỆP VỤ";
            this.pageNghiepVu.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGDChuyenTien);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGDGoiRut);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageBaoCao.Appearance.Options.UseFont = true;
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "BÁO CÁO";
            this.pageBaoCao.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSaoKeGiaoDich);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLietKeTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLietKeKhachHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 825);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1598, 29);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANHANVIEN,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1598, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANHANVIEN
            // 
            this.MANHANVIEN.Name = "MANHANVIEN";
            this.MANHANVIEN.Size = new System.Drawing.Size(115, 20);
            this.MANHANVIEN.Text = "MÃ NHÂN VIÊN";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(62, 20);
            this.HOTEN.Text = "HỌ TÊN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(63, 20);
            this.NHOM.Text = "VAI TRÒ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 854);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "NGÂN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSaoKeGiaoDich;
        private DevExpress.XtraBars.BarButtonItem btnLietKeTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnLietKeKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageDangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANHANVIEN;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnGDChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnGDGoiRut;
    }
}