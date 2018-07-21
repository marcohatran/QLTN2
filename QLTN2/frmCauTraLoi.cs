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
    public partial class frmCauTraLoi : Form
    {
        public frmCauTraLoi()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmCauTraLoi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            taMonHoc.Connection.ConnectionString += ";password=123456";
            taBoDe.Connection.ConnectionString += taLop.Connection.ConnectionString += ";password=123456";
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.taBoDe.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.taMonHoc.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.dS.LOP);

            cmbTenLop.DataSource = bdsLop;
            cmbTenLop.DisplayMember = "TENLOP";
            cmbTenLop.ValueMember = "MALOP";

            cmbTenMH.DataSource = bdsMonHoc;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";

            cmbTrinhDo.DataSource = bdsMonHoc;
            cmbTrinhDo.DisplayMember = "TENMH";
            cmbTrinhDo.ValueMember = "MAMH";

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy việc in ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
