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
    public partial class frmThi : Form
    {
        public frmThi()
        {
            InitializeComponent();
        }


        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            taGVDK.Connection.ConnectionString +=";Password =123";
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            bdsGVDK.Filter = "MALOP =" + "'D14CN1'";
            cmbMAMH.DataSource = bdsGVDK;
            cmbMAMH.DisplayMember = "MAMH";
            cmbMAMH.ValueMember = "MAMH";
            cmbMAMH.SelectedIndex = 0;
            A.Parent =B.Parent= C.Parent=D.Parent= rdg;
            
        }

        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(((DataRowView)bdsGVDK.Current)["NGAYTHI"]);
            String lan = ((DataRowView)bdsGVDK.Current)["LAN"].ToString();
            lbNT.Text = "Ngày thi: "+dt.ToShortDateString()  + " Lần thi: " + lan;
        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            fnc_LAYDETableAdapter.Connection.ConnectionString += ";Password =123";
            try
            {
                this.fnc_LAYDETableAdapter.Fill(this.DS.fnc_LAYDE, tRINHDOToolStripTextBox.Text, mAMHToolStripTextBox.Text, ((int)(System.Convert.ChangeType(sOCAUToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void rdg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
