using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTN2
{
    public partial class frmBangDiemTheoLop : Form
    {
        public frmBangDiemTheoLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmBangDiemTheoLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            taMonHoc.Connection.ConnectionString += ";password=123456";
            taLop.Connection.ConnectionString += ";password=123456";
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.taMonHoc.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.dS.LOP);
            cmbTenLop.DataSource = bdsLop;
            cmbTenLop.DisplayMember = "TENLOP";
            cmbTenLop.ValueMember= "MALOP";

            cmbTenMH.DataSource = bdsMonHoc;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";





        }

        private void mONHOCBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            BaoCao.rptBangDiemTheoLop obj;
            obj = new BaoCao.rptBangDiemTheoLop();

            string strLenh;
            strLenh = "EXEC SP_RP_BANGDIEMLOP '" + cmbTenLop.SelectedValue.ToString() + "', '" +
                 cmbTenMH.SelectedValue.ToString () + "','" + cmbLan.Text+"'";
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(strLenh);

            obj.SetDataSource(MyTable);
            obj.SetParameterValue("TENLOP", cmbTenLop.Text);
            obj.SetParameterValue("TENMH", cmbTenMH.Text);
            obj.SetParameterValue("LAN", cmbLan.Text);
            crptView.ReportSource = obj;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy việc in ?? ", "Xác nhận",
                      MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
