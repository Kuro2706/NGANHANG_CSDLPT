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
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void FormMoTaiKhoan_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        public FormMoTaiKhoan()
        {
            InitializeComponent();
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Không được bỏ trống chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }
            if (Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Chứng minh nhân dân chỉ nhận số", "Thông báo", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }

            if (txtSTK.Text == "")
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
                if (txtSTK.Text.Length != 9)
                {
                    MessageBox.Show("Số tài khoản phải đủ 9 số", "Thông báo", MessageBoxButtons.OK);
                }

                String cauTruyVan7 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRASOTAIKHOAN " +
                  "@SOTK ='" + txtSTK.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan7);
                SqlCommand sqlCommand7 = new SqlCommand(cauTruyVan7, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan7);
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
                int result7 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result7);
                if (result7 == 1)
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
                if (Int64.Parse(txtSoDu.Text.ToString()) < 50000)
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
            // Kiem tra du lieu
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            DialogResult dr = MessageBox.Show("Ghi thông tin vào database?", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {  
                    String cmnd = txtCMND.Text.Trim();
                    String STK = txtSTK.Text.Trim();
                    String SODU = txtSoDu.Text.Trim();
                    String macn = cmbChiNhanh.Text.Trim();

                    String Query5 = "EXEC SP_LAYMACN" +
                        " @TENCN = N'" + macn + "'";
                    Console.WriteLine(Query5);
                    Program.myReader = Program.ExecSqlDataReader(Query5);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                    Program.myReader.Read();
                    string tencn = Program.myReader.GetValue(0).ToString();
                    Program.myReader.Close();
                    Console.WriteLine(tencn);

                    String Query4 = "DECLARE @return_value int " +
                        "EXEC SP_MOTAIKHOAN" +
                        " @SOTK = '" + STK + "', " +
                        "@CMND = '" + cmnd + "', " +
                        "@SODU = '" + SODU + "', " +
                        "@MACN = N'" + tencn +"'" +
                        "SELECT	'Return Value' = @return_value";

                    Console.WriteLine(Query4);
                    int result6 = Program.ExecSqlNonQuery(Query4);
                    if(result6 == 0)
                    {
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ghi thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
