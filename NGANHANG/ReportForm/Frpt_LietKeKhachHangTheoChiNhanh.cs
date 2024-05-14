using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using NGANHANG.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.ReportForm
{
    public partial class Frpt_LietKeKhachHangTheoChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public Frpt_LietKeKhachHangTheoChiNhanh()
        {
            InitializeComponent();
        }
        private void Frpt_LietKeKhachHangTheoChiNhanh_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);

            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = false;
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
                /*Lay du lieu của dataSet*/
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dataSet.KhachHang);
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (cmbChiNhanh.SelectedIndex == Program.mChiNhanh)
            {
                type = 1;
            }
            else if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                type = 2;
            }

            Xrpt_LietKeKhachHangTheoChiNhanh report = new Xrpt_LietKeKhachHangTheoChiNhanh(type);
            report.lbTenChiNhanh.Text = cmbChiNhanh.Text;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }
    }
}