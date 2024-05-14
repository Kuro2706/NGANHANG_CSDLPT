using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.ReportForm
{
    public partial class Xrpt_LietKeKhachHangTheoChiNhanh : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LietKeKhachHangTheoChiNhanh()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
