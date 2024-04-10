using DevExpress.XtraEditors;
using NGANHANG.SubForm;
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

namespace NGANHANG.MenuForm
{
    public partial class FormNV : DevExpress.XtraEditors.XtraForm
    {
        int ViTri = 0; //vi tri con tro tren gridview
        String MACN = "";
        bool DangThemMoi = false;
        bool DanhDauXoa = false;
        Stack undoList = new Stack(); //phuc vu cho btnHoanTac chua cac thong tin cua doi tuong bi tac dong

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public FormNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dataSet.GD_CHUYENTIEN);

            MACN = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = false;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = false;
                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dataSet.GD_CHUYENTIEN);
            }
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //step 1: lay vi tri hien tai cua con tro
            ViTri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            DangThemMoi = true;
            //step 2: AddNew tu dong nhay xuong them 1 dong moi
            bdsNhanVien.AddNew();
            txtMACN.EditValue = MACN;

            //step 3

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = true;
            this.btnChuyenChiNhanh.Enabled = false;
            this.btnTHOAT.Enabled = true;
            this.cbTrangThaiXoa.Checked = false;

            this.gcNhanVien.Enabled = false;
            this.panelNhapLieu.Enabled = true;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViTri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            this.txtCMND.Enabled = false;
            this.txtMACN.Enabled = false;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = true;
            this.btnChuyenChiNhanh.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();
            if (maNV == Program.username)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsNhanVien.Count == 0)
            {
                this.btnXoa.Enabled = false;
            }
            if (bdsGDGoiRut.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập giao dịch gởi rút", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsGDChuyenTien.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập giao dịch chuyển tiền", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int trangThai = (cbTrangThaiXoa.Checked == true) ? 1 : 0;

            string undoQuery =
              string.Format("INSERT INTO DBO.NhanVien( MANV,HO,TEN,CMND,DIACHI,PHAI,SODT,MACN,TRANGTHAIXOA)" +
                "VALUES({0},N'{1}',N'{2}', '{3}',N'{4}',N'{5}','{6}',N'{7})", maNV, txtHo.Text.Trim(), txtTen.Text.Trim(), txtCMND.Text.Trim(), txtDiaChi.Text.Trim(), txtPhai.Text.Trim(), txtSDT.Text.Trim(), txtMACN.Text.Trim(), trangThai);

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);

            /*Step 2*/
            if (MessageBox.Show("Xoá nhân viên này?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    ViTri = bdsNhanVien.Position;
                    bdsNhanVien.RemoveCurrent();

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                    DanhDauXoa = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                    bdsNhanVien.Position = ViTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
            this.panelNhapLieu.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiem tra du lieu
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maNhanVien = txtMANV.Text.Trim();
            String cmnd = txtCMND.Text.Trim();
            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);


            String maChiNhanh = drv["MACN"].ToString();
            int trangThai = (cbTrangThaiXoa.Checked == true) ? 1 : 0;
            if (Program.username == maNhanVien)
                if (trangThai == 1)
                {
                    MessageBox.Show("Không được đổi trạng thái xoá của tài khoản đang đăng nhâp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            {
                DialogResult dr = MessageBox.Show("Ghi thông tin vào database?", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    try
                    {
                        String undoQuery = "";
                        if (DangThemMoi == true)
                        {
                            undoQuery = "" +
                              "DELETE DBO.NhanVien " +
                              "WHERE MANV = " + maNhanVien;
                            drv["MANV"] = maNhanVien;
                        }
                        else
                        {
                            String ho = drv["HO"].ToString();
                            String ten = drv["TEN"].ToString();

                            String diaChi = drv["DIACHI"].ToString();

                            String sdt = drv["SODT"].ToString();
                            cmnd = drv["CMND"].ToString();
                            String phai = drv["PHAI"].ToString();
                            undoQuery =
                              "UPDATE DBO.NhanVien " +
                              "SET " +
                              "HO = N'" + ho + "'," +
                              "TEN = N'" + ten + "'," +
                              "CMND = '" + cmnd + "',"+
                              "DIACHI = N'" + diaChi + "'," +
                              "PHAI = '" + phai + "'," +
                              "SODT = '" + sdt + "'," +
                              "TRANGTHAIXOA = " + trangThai + " " +
                              "WHERE MANV = '" + maNhanVien + "'";
                            ViTri = bdsNhanVien.Position;


                        }
                        Console.WriteLine(undoQuery);
                        undoList.Push(undoQuery);
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                        DanhDauXoa = false;
                        DangThemMoi = false;

                        this.txtMANV.Enabled = false;
                        this.txtMACN.Enabled = false;

                        this.btnThem.Enabled = true;
                        this.btnSua.Enabled = true;
                        this.btnXoa.Enabled = true;
                        this.btnGhi.Enabled = false;
                        this.btnHoanTac.Enabled = true;
                        this.btnLamMoi.Enabled = true;
                        this.btnChuyenChiNhanh.Enabled = true;
                        this.btnTHOAT.Enabled = true;

                        this.panelNhapLieu.Enabled = false;

                        this.bdsNhanVien.EndEdit();
                        this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);
                        this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                        this.gcNhanVien.Enabled = true;

                    }
                    catch (Exception ex)
                    {

                        if (DangThemMoi == true)
                        {
                            bdsNhanVien.RemoveCurrent();
                        }
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.bdsNhanVien.Position = ViTri;

                }
            }
        }
        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViTri = bdsNhanVien.Position;
            if (DangThemMoi == true && this.btnThem.Enabled == false)
            {

                DangThemMoi = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = true;
                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnTHOAT.Enabled = true;
                this.btnChuyenChiNhanh.Enabled = true;
                this.cbTrangThaiXoa.Checked = false;

                this.panelNhapLieu.Enabled = false;
                this.gcNhanVien.Enabled = true;

                bdsNhanVien.CancelEdit();
                bdsNhanVien.RemoveCurrent();
                bdsNhanVien.Position = bdsNhanVien.Count - 1;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

            else
            {

                String undoQuery = undoList.Pop().ToString();

                if (DangThemMoi == false && DanhDauXoa == false)
                {
                    this.gcNhanVien.Enabled = true;
                    this.panelNhapLieu.Enabled = true;

                    Console.WriteLine(undoQuery);
                    Program.ExecSqlNonQuery(undoQuery);
                }

                if (DanhDauXoa == true && DangThemMoi == false)
                {
                    Console.WriteLine(undoQuery);
                    DanhDauXoa = false;
                    Program.ExecSqlNonQuery(undoQuery);
                }
                if (undoQuery.Contains("SP_CHUYENCHINHANH"))
                {
                    try
                    {
                        String chiNhanhHienTai = Program.servername;
                        String chiNhanhChuyenToi = Program.servernameleft;

                        Program.servername = chiNhanhChuyenToi;
                        Program.loginName = Program.remoteLogin;
                        Program.loginPassword = Program.remotePassword;

                        if (Program.KetNoi() == 0)
                        {
                            return;
                        }

                        Program.ExecSqlNonQuery(undoQuery);

                        MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK);
                        Program.servername = chiNhanhHienTai;
                        Program.loginName = Program.currentLogin;
                        Program.loginPassword = Program.currentPassword;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chuyển nhân viên thất bại \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    bdsNhanVien.Position = ViTri;

                }
            }
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                this.gcNhanVien.Enabled = true;
                this.panelNhapLieu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        public void ChuyenChiNhanh(String ChiNhanh)
        {
            if(Program.servername == ChiNhanh)
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
            }

            String MaChiNhanhHienTai = "";
            String MaChiNhanhMoi = "";
            int ViTriHienTai = bdsNhanVien.Position;
            String maNhanVien = ((DataRowView)bdsNhanVien[ViTriHienTai])["MANV"].ToString();

            if(ChiNhanh.Contains("1"))
            {
                MaChiNhanhHienTai = "BENTHANH";
                MaChiNhanhMoi = "TANDINH";
            }
            else if (ChiNhanh.Contains("0"))
            {
                MaChiNhanhHienTai = "TANDINH";
                MaChiNhanhMoi = "BENTHANH";
            }
            else
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine("Mã chi nhánh hiện tại: " + MaChiNhanhHienTai);
            Console.WriteLine("Mã chi nhánh mới: " + MaChiNhanhMoi);

            String undoQuery = "EXEC SP_CHUYENCHINHANH " + maNhanVien + ",'" + MaChiNhanhMoi + "'";
            undoList.Push(undoQuery);

            Program.servernameleft = ChiNhanh;
            Console.WriteLine("Tên server còn lại" + Program.servernameleft);

            String Query = "EXEX SP_CHUYENCHINHANH " + maNhanVien + ",'" + MaChiNhanhMoi + "'";
            Console.WriteLine("undoQuery: " + undoQuery);
            Console.WriteLine("Query: " + Query);


            SqlCommand sqlCommand = new SqlCommand(undoQuery, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(Query);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);

                if (Program.myReader == null)
                {
                    return;/*khong co ket qua tra ve thi ket thuc luon*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);
        }
        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChuyenChiNhanh));
            if (f != null)
            {
                f.Activate();
            }
            FormChuyenChiNhanh form = new FormChuyenChiNhanh();
            form.Show();

            int viTriHienTai = bdsNhanVien.Position;
            int TrangThaiXoa = int.Parse(((DataRowView)(bdsNhanVien[viTriHienTai]))["TrangThaiXoa"].ToString());
            String maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString();

            if(maNhanVien == Program.username)
            {
                MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //kiem tra trang thai xoa
            if(TrangThaiXoa == 1)
            {
                MessageBox.Show("Không thể chuyển nhân viên không có ở chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //dong goi ham ChuyenChiNhanh tu formNhanVien dem ve formChuyenChiNhanh de lam viec
            form.branchTransfer = new FormChuyenChiNhanh.MyDelegate(ChuyenChiNhanh);

            //hoan tac
            this.btnHoanTac.Enabled = true;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
        private bool kiemTraDuLieuDauVao()
        {


            if (txtHo.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }

            if (Regex.IsMatch(txtHo.Text, @"^[A-Za-zÀ-ỹ ]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }

            if (txtTen.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTen.Text, @"^[A-Za-zÀ-ỹ ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }


            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (Regex.IsMatch(txtDiaChi.Text, @"^[A-Za-zÀ-ỹ0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không thể lớn hơn 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Không được bỏ trống số điện thoại", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }
            if (Regex.IsMatch(txtSDT.Text, @"^[0-9]{10}$") == false)
            {
                MessageBox.Show("Số điện thoại phải là 10 số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
                return false;
            }

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

            if (DangThemMoi == true)
            {
                String cauTruyVan1 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRASDT " +
                  "@SODT ='" + txtSDT.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan1);
                SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan1, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan1);
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
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result);
                if (result == 1)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return false;
                }

                String cauTruyVan2 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRACMNDNV " +
                  "@CMND ='" + txtCMND.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan2);
                SqlCommand sqlCommand3 = new SqlCommand(cauTruyVan2, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan2);
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
                int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result2);
                if (result2 == 1)
                {
                    MessageBox.Show("CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return false;
                }

                String cauTruyVan3 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRAMANHANVIEN " +
                  "@MANV ='" + txtMANV.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan3);
                SqlCommand sqlCommand4 = new SqlCommand(cauTruyVan3, Program.conn);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan3);
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
                int result3 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                Console.WriteLine(result3);
                if (result3 == 1)
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}