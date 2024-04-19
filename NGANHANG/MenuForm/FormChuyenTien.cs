using DevExpress.XtraEditors;
using NGANHANG.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.MenuForm
{
    public partial class FormChuyenTien : DevExpress.XtraEditors.XtraForm
    {
        
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public FormChuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGDChuyenTien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChuyenTien_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
            
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dataSet.GD_CHUYENTIEN);

            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            cmbSTKChuyen.DataSource = bdsTaiKhoan;
            cmbSTKChuyen.DisplayMember = "SOTK";
            cmbSTKChuyen.ValueMember = "SOTK";

            BindingSource bdsTaiKhoanNhan = new BindingSource();
            bdsTaiKhoanNhan.DataSource = bdsTaiKhoan;
            cmbSTKNhan.DataSource = bdsTaiKhoanNhan;
            cmbSTKNhan.DisplayMember = "SOTK";
            cmbSTKNhan.ValueMember = "SOTK";




            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
                panelNhapLieu.Enabled = false;

                btnTaoGD.Enabled = false;
                btnXacNhanGDChuyenTien.Enabled = false;
                btnHoanTac.Enabled = false;
                btnLamMoi.Enabled = true;
                btnTHOAT.Enabled = true;
            }
            if(Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;
                panelNhapLieu.Enabled = false;

                btnTaoGD.Enabled = true;
                btnXacNhanGDChuyenTien.Enabled = false;
                btnHoanTac.Enabled = false;
                btnLamMoi.Enabled = true;
                btnTHOAT.Enabled = true;
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

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                /*Do du lieu tu dataSet vao grid Control*/
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dataSet.GD_CHUYENTIEN);
            }
        }

        private void btnTaoGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = true;
            txtMANV.Text = Program.username;
            txtMANV.ReadOnly = true;
            txtSODU.ReadOnly = true;
            

            btnTaoGD.Enabled = btnLamMoi.Enabled = false;
            btnXacNhanGDChuyenTien.Enabled = btnHoanTac.Enabled = btnTHOAT.Enabled = true;
            gcGD_ChuyenTien.Enabled = false;
        }

        private void btnXacNhanGDChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();

           
           /* Type type = sOTIENSpinEdit.Value.GetType();
            Console.WriteLine("Kiểu dữ liệu của biến là: " + type.Name);*/
           
            if (ketQua == false)
                return;
            string strLenh = "EXEC SP_GIAODICHCHUYENTIEN '" + cmbSTKChuyen.SelectedValue + "','" + cmbSTKNhan.SelectedValue + "','" + sOTIENSpinEdit.Value + "','" + txtMANV.Text + "'";
           
            Console.WriteLine(strLenh);
            int result = Program.ExecSqlNonQuery(strLenh);
            if (result != 0)
            {
                MessageBox.Show("Lỗi giao dịch");
                return;
            }

            

            try
            {
                MessageBox.Show("Giao dịch thành công");
                bdsGDChuyenTien.ResetCurrentItem();
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Update(this.dataSet.GD_CHUYENTIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi thông tin giao dịch.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }

            gcGD_ChuyenTien.Enabled = true;
            btnTaoGD.Enabled = btnLamMoi.Enabled = btnTHOAT.Enabled = true;
            btnXacNhanGDChuyenTien.Enabled = btnHoanTac.Enabled = false;
            panelNhapLieu.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = false;
            txtMANV.Text = "";
            cmbSTKChuyen.SelectedValue = cmbSTKNhan.SelectedValue = "";
            sOTIENSpinEdit.Value = 0;

            gcGD_ChuyenTien.Enabled = true;
            btnTaoGD.Enabled = btnLamMoi.Enabled = btnTHOAT.Enabled = true;
            btnHoanTac.Enabled = btnXacNhanGDChuyenTien.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.gD_CHUYENTIENTableAdapter.Fill(this.dataSet.GD_CHUYENTIEN);
                this.gcGD_ChuyenTien.Enabled = true;
                this.panelNhapLieu.Enabled = false;
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

        private bool kiemTraDuLieuDauVao()
        {
            decimal sodu = decimal.Parse(txtSODU.Text.ToString().Trim());
      
            Console.WriteLine(txtSODU.Text.ToString().Trim());
            if (cmbSTKChuyen.SelectedValue == cmbSTKNhan.SelectedValue)
            {
                MessageBox.Show("Tài khoản chuyển không được trùng với tài khoản nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (sOTIENSpinEdit.Value < 10000)
            {
                MessageBox.Show("Số tiền cần chuyển phải từ 10000 đồng trở lên", "Thông báo", MessageBoxButtons.OK);
                sOTIENSpinEdit.Focus();
                return false;
            }
            if (sOTIENSpinEdit.Value > sodu ) 
            {
                MessageBox.Show("Số dư không đủ để thực hiện giao dịch", "Thông báo", MessageBoxButtons.OK);

                sOTIENSpinEdit.Focus();
                return false;
            }          
            return true;
        }
    }
}