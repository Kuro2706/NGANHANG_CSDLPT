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

namespace NGANHANG
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();
        private bool isKhachHang = false;
        private void LayDanhSachPhanManh(string cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);

            connPublisher.Close();
            Program.bindingSource.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bindingSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
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
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
            txtTaiKhoan.Text = "TT";
            txtMatKhau.Text = "123456";
            if (KetNoiDatabaseGoc() == 0)
                return;
            //Lấy 2 cái đầu tiên của danh sách
            LayDanhSachPhanManh("SELECT * FROM v_DanhSachPhanManh");
            cmbChiNhanh.SelectedIndex = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //truoc tien kiem tra tk dang nhap la khach hang hay nhan vien
            if(isKhachHang == false)
            {
                //step 1
                if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Tài khoản & Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                //step 2
                Program.loginName = txtTaiKhoan.Text.Trim();
                Program.loginPassword = txtMatKhau.Text.Trim();

                if (Program.KetNoi() == 0)
                    return;
                //step 3
                Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
                Program.currentLogin = Program.loginName;
                Program.currentPassword = Program.loginPassword;
                //step 4
                String statement = "EXEC SP_DANGNHAP '" + Program.loginName + "'";
                Console.WriteLine(statement);
                Program.myReader = Program.ExecSqlDataReader(statement);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                //step 5
                Program.username = Program.myReader.GetString(0);
                Console.WriteLine(Program.username);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông báo", MessageBoxButtons.OK);
                }

                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();

                Program.frmMain.MANHANVIEN.Text = "MÃ NHÂN VIÊN: " + Program.username;
                Program.frmMain.HOTEN.Text = "HỌ TÊN: " + Program.mHoten;
                Program.frmMain.NHOM.Text = "NHÓM: " + Program.mGroup;

                this.Visible = false;
                Program.frmMain.enableButtons();
                Console.WriteLine(Program.loginName);
                Console.WriteLine(Program.loginPassword);

            }
            else
            {
                if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Loginname và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    Program.loginName = "KHKN";
                    Program.loginPassword = "123456";

                    if (Program.KetNoi() == 0) return;


                    string strlenh1 = "EXEC [dbo].[SP_KHACHHANGDANGNHAP] '" +txtTaiKhoan.Text.Trim()+"'";
                    Console.WriteLine("THIS IS " + strlenh1);
                    SqlDataReader reader = Program.ExecSqlDataReader(strlenh1);

                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("true");
                        MessageBox.Show("Đăng nhập thất bại! \nXem Lại TK và PASSWORD");
                        return;
                    }

                    reader.Read();

                    if (Convert.IsDBNull(Program.username))
                    {
                        MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                        return;
                    }
                    Program.mGroup = "KHACHHANG";
                    Program.mHoten = reader.GetString(1);
                    Program.username = reader.GetString(0);
                    reader.Close();

                    Program.frmMain.MANHANVIEN.Text = "MÃ KHÁCH HÀNG: " + Program.username;
                    Program.frmMain.HOTEN.Text = "HỌ TÊN: " + Program.mHoten;
                    Program.frmMain.NHOM.Text = "NHÓM: " + Program.mGroup;

                    this.Visible = false;
                    Program.frmMain.enableButtonsKH();
                    Console.WriteLine(Program.loginName);
                    Console.WriteLine(Program.loginPassword);

                }
                
            }
            

        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                Console.WriteLine(cmbChiNhanh.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                hide.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                show.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void cbKHKN_CheckedChanged(object sender, EventArgs e)
        {
            isKhachHang = !isKhachHang;
        }
    }
}