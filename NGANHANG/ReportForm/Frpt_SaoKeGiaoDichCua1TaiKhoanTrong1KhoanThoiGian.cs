using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian : DevExpress.XtraEditors.XtraForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian()
        {
            InitializeComponent();
        }
        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Frpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "KHACHHANG")
            {
                loadcbTKKH();
            }
            else
            loadcbTK();
        }

        private void loadcbTKKH()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LAYSTKKHACHHANG '" + Program.username+"'" ;
            Console.WriteLine(cmd);
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cmbSTK.DataSource = bdsNienKhoa;
            cmbSTK.DisplayMember = "SOTK";
            cmbSTK.ValueMember = "SOTK";
        }

        private void loadcbTK()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LAYSOTK" ;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cmbSTK.DataSource = bdsNienKhoa;
            cmbSTK.DisplayMember = "SOTK";
            cmbSTK.ValueMember = "SOTK";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String SOTK = cmbSTK.Text;
            DateTime NgayBD = dtPickTGBD.Value;
            DateTime NgayKT = dtPickTGKT.Value;
            Xrpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian report = new Xrpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian(SOTK, NgayBD, NgayKT);
            report.lbTieuDe.Text = "SAO KÊ GIAO DỊCH CỦA TÀI KHOẢN: " + cmbSTK.Text;

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}