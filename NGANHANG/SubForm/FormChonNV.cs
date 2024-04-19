using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.SubForm
{
    public partial class FormChonNV : DevExpress.XtraEditors.XtraForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormChonNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonNV_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            cmbChiNhanh.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
            }
            if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNhanVien.Current));
            string manv = drv["MANV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoten = ho + " " + ten;
            string diachi = drv["DIACHI"].ToString().Trim();

            Program.manvduocchon = manv;
            Program.hoten = hoten;
            Program.diachi = diachi;

            this.Close();
        }
    }
}