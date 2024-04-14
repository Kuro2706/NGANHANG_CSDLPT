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
    public partial class FormChonTK : DevExpress.XtraEditors.XtraForm
    {
        public FormChonTK()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTaiKhoan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FormChonTK_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dataSet.TaiKhoan);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnChon_Click(object sender, EventArgs e)
        {
            string stk = ((DataRowView)bdsTaiKhoan[bdsTaiKhoan.Position])["SOTK"].ToString();
            /*if (frmMain.CheckExitedForm("FormGoiRut") && Program.formGoiRut.numbtn.Text == "1")
            {

            }*/
        }
    }
}