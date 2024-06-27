using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.ReportForm
{
    public partial class Xrpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SaoKeGiaoDichCua1TaiKhoanTrong1KhoanThoiGian(String SOTK, DateTime NgayBD, DateTime NgayKT)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = SOTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NgayBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = NgayKT;
            this.sqlDataSource1.Fill();
        }

    }
}
