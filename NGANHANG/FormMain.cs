using DevExpress.XtraBars;
using NGANHANG.MenuForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void enableButtons()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaoTaiKhoan.Enabled = true;
            btnThoat.Enabled = true;

            pageQuanLy.Visible = true;
            pageBaoCao.Visible = true;
            pageKH.Visible = false;
        }

        public void enableButtonsKH()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaoTaiKhoan.Enabled = false;
            btnThoat.Enabled = true;

            pageQuanLy.Visible = false;
            pageBaoCao.Visible = false;
            pageKH.Visible = true;
        }
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }
        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDangNhap form = new frmDangNhap();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();

            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnTaoTaiKhoan.Enabled = false;
            pageQuanLy.Visible = false;
            pageBaoCao.Visible = false;

            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDangNhap form = new frmDangNhap();
                form.Show();
            }

            Program.frmMain.MANHANVIEN.Text = "MÃ NHÂN VIÊN:";
            Program.frmMain.HOTEN.Text = "HỌ TÊN:";
            Program.frmMain.NHOM.Text = "VAI TRÒ:";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNV form = new FormNV();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKH form = new FormKH();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnGiaoDich_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormGD form = new FormGD();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTK form = new FormTK();
                form.MdiParent = this;
                form.Show();
            }
        }
    }   
}