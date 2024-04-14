using DevExpress.XtraEditors;
using NGANHANG.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.MenuForm
{
    public partial class FormTK : DevExpress.XtraEditors.XtraForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public FormTK()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormTK_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
                this.btnLamMoi.Enabled = true;
                this.btnMoTaiKhoan.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTHOAT.Enabled = true;
            }

            if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnMoTaiKhoan.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
                this.gcTaiKhoan.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnMoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormMoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormMoTaiKhoan form = new FormMoTaiKhoan();
                form.Show();
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTaiKhoan.Count == 0)
            {
                this.btnXoa.Enabled = false;
            }
            if (bdsGDGoiRut.Count > 0)
            {
                MessageBox.Show("Không thể xóa tài khoản đã phát sinh giao dịch", "Thông báo", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Xoá khách hàng này?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsTaiKhoan.RemoveCurrent();

                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Update(this.dataSet.TaiKhoan);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
                    return;
                }
            }
        }
    }
}