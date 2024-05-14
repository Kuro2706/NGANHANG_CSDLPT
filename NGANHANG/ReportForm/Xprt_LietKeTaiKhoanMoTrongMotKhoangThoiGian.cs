using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.ReportForm
{
    public partial class Xprt_LietKeTaiKhoanMoTrongMotKhoangThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public Xprt_LietKeTaiKhoanMoTrongMotKhoangThoiGian(String MACN, DateTime NgayBD, DateTime NgayKT)
        {
            InitializeComponent();
          
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MACN;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = NgayBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = NgayKT;
        
            this.sqlDataSource1.Fill();
        }

    }
}
