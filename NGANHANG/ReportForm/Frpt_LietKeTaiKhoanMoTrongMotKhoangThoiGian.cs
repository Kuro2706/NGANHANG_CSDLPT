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
    public partial class Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian : DevExpress.XtraEditors.XtraForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian()
        {
            InitializeComponent();
        }
        private void Frpt_LietKeTaiKhoanMoTrongMotKhoangThoiGian_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);

            cmbChiNhanh.SelectedIndex = 0;
            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = false;
        }
        
        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String MACN = "";
            if (cmbChiNhanh.Text == "TÂN ĐỊNH")
            {
                MACN = "TANDINH";
            }
            if (cmbChiNhanh.Text == "BẾN THÀNH")
            {
                MACN = "BENTHANH";
            }
            if (cmbChiNhanh.Text == "CẢ 2 CHI NHÁNH")
            {
                MACN = "HAICN";
            }

            /*String NgayBD = dtPickTGBD.Text;
            String NgayKT = dtPickTGKT.Text;*/
            DateTime NgayBD = dtPickTGBD.Value;
            DateTime NgayKT = dtPickTGKT.Value;
            Console.WriteLine(MACN);
            Console.WriteLine(NgayBD.ToString());
            Console.WriteLine(NgayKT.ToString());
            Xprt_LietKeTaiKhoanMoTrongMotKhoangThoiGian report = new Xprt_LietKeTaiKhoanMoTrongMotKhoangThoiGian(MACN,NgayBD,NgayKT);
            report.lbTieuDe.Text = "DANH SÁCH TÀI KHOẢN MỞ TẠI " + cmbChiNhanh.Text;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}