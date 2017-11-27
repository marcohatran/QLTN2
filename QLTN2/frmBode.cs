using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmBode : Form
    {
        int current;
        private Boolean isThem = false, isSua = false;
        private  DataRowView drv;
        private ViewColumnFilterInfo filterInfo;

        public frmBode()
        {
            InitializeComponent();
        }


        private void frmBode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            taBode.Connection.ConnectionString = Program.connstr;
            this.taBode.Fill(this.DS.BODE);



        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
