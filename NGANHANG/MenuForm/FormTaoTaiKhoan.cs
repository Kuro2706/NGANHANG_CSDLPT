using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NGANHANG.SubForm;

namespace NGANHANG.MenuForm
{
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private string taikhoan = "";
        private string matkhau = "";
        private string manv = "";
        private string vaitro = "";

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNV form = new FormChonNV();
            form.ShowDialog();

            txtMANV.Text = Program.manvduocchon;
        }

        private void FormTaoTaiKhoan_Load(Object sender, EventArgs e)
        {
            if(Program.mGroup == "NGANHANG")
            {
                vaitro = "NGANHANG";
                rbNganHang.Checked = true;
                rbChiNhanh.Visible = false;
            }
            else
            {
                vaitro = "CHINHANH";
                rbNganHang.Visible = false;
                rbChiNhanh.Checked = true;
            }
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên tài khoản", "Thông báo", MessageBoxButtons.OK);
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTenTaiKhoan.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Tên tài khoản chỉ được chứa chữ cái và số, không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenTaiKhoan.Focus();
                return false;
            }

            if (txtTenTaiKhoan.Text.Length > 50)
            {
                MessageBox.Show("Tên tài khoản không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenTaiKhoan.Focus();
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMatKhau.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Mật khẩu chỉ được chứa chữ cái và số, không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return false;
            }
            if (txtMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return false;
            }


            if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                txtXacNhanMatKhau.Focus();
                return false;
            }
            if (Regex.IsMatch(txtXacNhanMatKhau.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Mật khẩu xác nhận chỉ được chứa chữ cái và số, không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtXacNhanMatKhau.Focus();
                return false;
            }
            if (txtXacNhanMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu xác nhận không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtXacNhanMatKhau.Focus();
                return false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            taikhoan = txtTenTaiKhoan.Text.Trim();
            matkhau = txtMatKhau.Text.Trim();
            manv = Program.manvduocchon;
            vaitro = (rbChiNhanh.Checked == true) ? "CHINHANH" : "NGANHANG";

            Console.WriteLine(taikhoan);
            Console.WriteLine(matkhau);
            Console.WriteLine(manv);
            Console.WriteLine(vaitro);
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + taikhoan + "' , '" + matkhau + "', '"
                    + manv + "', '" + vaitro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taikhoan + "\nMật khẩu: " + matkhau + "\n Mã Nhân Viên: " + manv + "\n Vai Trò: " + vaitro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
