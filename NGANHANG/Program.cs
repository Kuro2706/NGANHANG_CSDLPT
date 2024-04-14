using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using NGANHANG.MenuForm;
using NGANHANG.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NGANHANG
{
    static class Program
    {
        public static String connstr = "";
        public static String connstrPublisher = "Data Source=ZEPHYRUS-G15;Initial Catalog=NGANHANG;Integrated Security=true";
        public static SqlDataReader myReader;
        public static SqlConnection conn = new SqlConnection();

        public static String servername = "";
        public static String servernameleft = "";
        public static String username = "";
        public static String loginName = "";
        public static String loginPassword = "";
        public static String database = "NGANHANG";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123456";
        public static String currentLogin = "";
        public static String currentPassword = "";

        public static String mlogin = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChiNhanh = 0;
        public static Dictionary<String, String> DSPM = new Dictionary<String, String>();

        public static string manvduocchon = "";
        public static string hoten = "";
        public static string diachi = "";

        public static frmMain frmMain;
        public static frmDangNhap frmDangNhap;

        public static FormNV formNV;
        public static FormKH formKH;
        public static FormTK formTK;
        public static FormTaoTaiKhoan formTaoTaiKhoan;
        public static FormChuyenTien formChuyenTien;
        public static FormGoiRut formGoiRut;

        public static FormChonNV formChonNV;
        public static FormChonTK formChonTK;
        public static FormChuyenChiNhanh formChuyenChiNhanh;
        public static FormMoTaiKhoan formMoTaiKhoan;

        public static BindingSource bindingSource = new BindingSource();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static BindingSource bds_dspm = new BindingSource(); //giu dspm khi dang nhap
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source =" + Program.servername + "; Initial Catalog = " + Program.database + ";User ID=" + Program.loginName + ";password=" + Program.loginPassword;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) 
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static SqlDataReader ExecSqlDataReaderPublisher(String strLenh)
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            conn = new SqlConnection(connstrPublisher);
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                return sqlcmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                //errstr = ex.Message.ToString();
                conn.Close();
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, bool isPub)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                Console.WriteLine(ex.Message);
                return ex.State;


            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmMain = new frmMain();
            Application.Run(frmMain);
        }
    }
}