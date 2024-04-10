using DevExpress.XtraEditors;
using System;
using System.Collections;
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

namespace NGANHANG.SubForm
{
    public partial class FormMoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormMoTaiKhoan()
        {
            InitializeComponent();
        }
        private bool kiemTraDuLieuDauVao()
        {
            if(txtCMND.Text == "")
            {
                MessageBox.Show("Không được bỏ trống chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }
            if(Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Chứng minh nhân dân chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }

            if(txtSTK.Text == "")
            {
                MessageBox.Show("Không được bỏ trống số tài khoản", "Thông báo", MessageBoxButtons.OK);
                txtSTK.Focus();
                return false;
            }
            if (Regex.IsMatch(txtSTK.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Tài khoản chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSTK.Focus();
                return false;
            }
            else
            {
                if(txtSTK.Text.Length != 9)
                {
                    MessageBox.Show("Số tài khoản phải đủ 9 số", "Thông báo", MessageBoxButtons.OK);
                }

                String cauTruyVan4 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRASOTAIKHOAN " +
                  "@SOTK ='" + txtSTK.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan4);
                SqlCommand sqlCommand3 = new SqlCommand(cauTruyVan4, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan4);
                    if (Program.myReader == null)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return false;
                }
                Program.myReader.Read();
                int result4 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result4);
                if (result4 == 1)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtSTK.Focus();
                    return false;
                }
            }

            if (Regex.IsMatch(txtSoDu.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số dư chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtSoDu.Focus();
                return false;
            }
            else
            {
                if(Int64.Parse(txtSoDu.Text.ToString()) < 50000)
                {
                    MessageBox.Show("Số dư phải lớn hơn 50000");
                    txtSoDu.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}