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

namespace NGANHANG.MenuForm
{
    public partial class FormKH : DevExpress.XtraEditors.XtraForm
    {
        int ViTri = 0;
        String MACN = "";
        bool DangThemMoi = false;

        Stack undoList = new Stack();

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

            MACN = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnMoTaiKhoan.Enabled = false;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnGhi.Enabled = false;
                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnMoTaiKhoan.Enabled = true;
                this.btnTHOAT.Enabled = true;

                this.panelNhapLieu.Enabled = false;
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
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dataSet.GD_GOIRUT);

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //step 1: lay vi tri hien tai cua con tro
            ViTri = bdsKhachHang.Position;
            this.panelNhapLieu.Enabled = true;
            DangThemMoi = true;

            //step 2: AddNew tu dong nhay xuong 1 dong moi
            bdsKhachHang.AddNew();
            txtMACN.EditValue = MACN;

            //step 3
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = true;
            this.btnMoTaiKhoan.Enabled = false;
            this.btnTHOAT.Enabled = true;

            this.gcKhachHang.Enabled = false;
            this.panelNhapLieu.Enabled = true;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViTri = bdsKhachHang.Position;
            this.panelNhapLieu.Enabled = true;
            this.txtCMND.Enabled = false;
            this.txtMACN.Enabled = false;
            this.deNgayCap.Enabled = false;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = true;
            this.btnMoTaiKhoan.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsKhachHang.Count == 0)
            {
                this.btnXoa.Enabled = false;
            }
            if(bdsTaiKhoan.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng đã có tài khoản", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(bdsGDGoiRut.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng đã có giao dịch", "Thông báo", MessageBoxButtons.OK);
            }
            String undoQuery =
              string.Format("INSERT INTO DBO.KhachHang(CMND,HO,TEN,DIACHI,PHAI,NGAYCAP,SODT,MACN)" +
                "VALUES('{0},N'{1}',N'{2}', N'{3}',N'{4}','{5}','{6}',N'{7})", txtCMND.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(), txtDiaChi.Text.Trim(), txtPhai.Text.Trim(), deNgayCap.Text.Trim(), txtSDT.Text.Trim(), txtMACN.Text.Trim());

            Console.WriteLine(undoQuery);
            undoList.Push(undoQuery);

            if (MessageBox.Show("Xoá khách hàng này?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    ViTri = bdsKhachHang.Position;
                    bdsKhachHang.RemoveCurrent();

                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dataSet.KhachHang);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);
                    bdsKhachHang.Position = ViTri;
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

            String cmnd = txtCMND.Text.Trim();
            DataRowView drv = ((DataRowView)bdsKhachHang[bdsKhachHang.Position]);

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
                          "DELETE DBO.KhachHang " +
                          "WHERE CMND = " + cmnd;
                        drv["CMND"] = cmnd;
                    }
                    else
                    {
                        cmnd = drv["CMND"].ToString();
                        String ho = drv["HO"].ToString();
                        String ten = drv["TEN"].ToString();

                        String diaChi = drv["DIACHI"].ToString();
                        String phai = drv["PHAI"].ToString();


                        DateTime ngayCap = ((DateTime)drv["NGAYCAP"]);

                        String sdt = drv["SODT"].ToString();
                        undoQuery =
                          "UPDATE DBO.KhachHang " +
                          "SET " +
                          "HO = N'" + ho + "'," +
                          "TEN = N'" + ten + "'," +
                          "DIACHI = N'" + diaChi + "'," +
                          "PHAI = '" + phai + "'," +
                          "NGAYCAP = CAST('" + ngayCap.ToString("yyyy-MM-dd") + "' AS DATE)," +
                          "SODT = '" + sdt + "'" +
                          "WHERE CMND = '" + cmnd + "'";
                        ViTri = bdsKhachHang.Position;


                    }
                    Console.WriteLine(undoQuery);
                    undoList.Push(undoQuery);
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                    DangThemMoi = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHoanTac.Enabled = true;
                    btnLamMoi.Enabled = true;
                    btnMoTaiKhoan.Enabled = true;
                    btnTHOAT.Enabled = true;

                    panelNhapLieu.Enabled = false;

                    this.bdsKhachHang.EndEdit();
                    this.khachHangTableAdapter.Update(this.dataSet.KhachHang);
                    this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);
                    this.gcKhachHang.Enabled = true;

                }
                catch (Exception ex)
                {

                    if (DangThemMoi == true)
                    {
                        bdsKhachHang.RemoveCurrent();
                    }
                    MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.bdsKhachHang.Position = ViTri;
            }
        }
        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViTri = bdsKhachHang.Position;
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
                this.btnMoTaiKhoan.Enabled = true;


                this.gcKhachHang.Enabled = true;
                this.panelNhapLieu.Enabled = false;

                bdsKhachHang.CancelEdit();

                bdsKhachHang.RemoveCurrent();
                bdsKhachHang.Position = ViTri - 1;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }
            String undoQuery = undoList.Pop().ToString();
            Console.WriteLine(undoQuery);
            int n = Program.ExecSqlNonQuery(undoQuery);
            bdsKhachHang.Position = ViTri;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);
                this.gcKhachHang.Enabled = true;
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
                txtSDT.Focus();
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
                String cauTruyVan2 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRASDT " +
                  "@SODT ='" + txtSDT.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan2);
                SqlCommand sqlCommand2 = new SqlCommand(cauTruyVan2, Program.conn);
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
                    MessageBox.Show("Số điện thoại đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                    txtSDT.Focus();
                    return false;
                }
                String cauTruyVan3 = "DECLARE @RETURN INT ;" +
                  "EXEC @RETURN  = SP_KIEMTRACMNDKH " +
                  "@CMND ='" + txtCMND.Text.ToString().Trim() + "';" +
                  "SELECT 'RETURN_VALUE' = @RETURN";
                Console.WriteLine(cauTruyVan3);
                SqlCommand sqlCommand3 = new SqlCommand(cauTruyVan3, Program.conn);
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
                    MessageBox.Show("CMND đã được sử dụng", "Thông báo", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}