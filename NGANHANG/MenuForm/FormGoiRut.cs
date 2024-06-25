using DevExpress.XtraEditors;
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
    public partial class FormGoiRut : DevExpress.XtraEditors.XtraForm
    {
        String LoaiGD = "";
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormGoiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGDGoiRut.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormGoiRut_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;


            cmbSTK.DataSource = bdsTaiKhoan;
            cmbSTK.DisplayMember = "SOTK";
            cmbSTK.ValueMember = "SOTK";

            cmbLoaiGD.Items.Add("RT");
            cmbLoaiGD.Items.Add("GT");
            
            

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

            if (Program.mGroup == "CHINHANH")
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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);
            }
        }

        private void btnTaoGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = true;
            txtMANV.Text = Program.username;
            txtMANV.ReadOnly = true;
            txtSODU.ReadOnly = true;
            LoaiGD = "RT";
            cmbLoaiGD.SelectedItem = LoaiGD;
            sOTIENSpinEdit.Value = 0;

            btnTaoGD.Enabled = btnLamMoi.Enabled = false;
            btnXacNhanGDChuyenTien.Enabled = btnHoanTac.Enabled = btnTHOAT.Enabled = true;
            gcGD_GoiRut.Enabled = false;
        }

        private void btnXacNhanGDChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;
            
            string strLenh2 = "EXEC SP_GIAODICHGOIRUT '" + cmbSTK.SelectedValue + "','" + cmbLoaiGD.SelectedItem + "','" + sOTIENSpinEdit.Value + "','" + txtMANV.Text + "'";

            Console.WriteLine(strLenh2);

            int result2 = Program.ExecSqlNonQuery(strLenh2);
            if (result2 != 0)
            {
                MessageBox.Show("Lỗi giao dịch", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Giao dịch thành công", "Thông báo", MessageBoxButtons.OK);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);

            bdsGDGoiRut.ResetCurrentItem();

            gcGD_GoiRut.Enabled = true;
            btnTaoGD.Enabled = btnLamMoi.Enabled = btnTHOAT.Enabled = true;
            btnXacNhanGDChuyenTien.Enabled = btnHoanTac.Enabled = false;
            panelNhapLieu.Enabled = false;

            sOTIENSpinEdit.EditValue = 0;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = false;
            txtMANV.Text = "";
            txtSODU.Text = "";
            cmbSTK.SelectedValue = "";
            sOTIENSpinEdit.Value = 0;
            cmbLoaiGD.SelectedIndex = -1;

            gcGD_GoiRut.Enabled = true;
            btnTaoGD.Enabled = btnLamMoi.Enabled = btnTHOAT.Enabled = true;
            btnHoanTac.Enabled = btnXacNhanGDChuyenTien.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);
                this.gcGD_GoiRut.Enabled = true;
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

            if (cmbSTK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (cmbLoaiGD.Text.Trim() == "")
            {
                MessageBox.Show("Loại giao dịch không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (sOTIENSpinEdit.Value < 100000)
            {
                MessageBox.Show("Số tiền phải từ 100.000 đồng trở lên", "Thông báo", MessageBoxButtons.OK);
                sOTIENSpinEdit.Focus();
                return false;
            }
            if (sOTIENSpinEdit.Value > sodu)
            {
                MessageBox.Show("Số dư không đủ để thực hiện giao dịch", "Thông báo", MessageBoxButtons.OK);

                sOTIENSpinEdit.Focus();
                return false;
            }
            return true;
        }

        private void cmbLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiGD.SelectedItem != null)
            {
                // Sử dụng SelectedItem để lấy giá trị của mục được chọn
                string LoaiGD = cmbLoaiGD.SelectedItem.ToString();
                Console.WriteLine("Loại giao dịch được chọn: " + LoaiGD);
            }
        }
    }
}