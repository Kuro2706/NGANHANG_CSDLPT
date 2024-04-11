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
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public delegate void MyDelegate(string ChiNhanh);
        public MyDelegate branchTransfer;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OK);
            if(dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbChiNhanh.SelectedValue.ToString());
            }
            this.Dispose();
        }
    }
}