using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTN2
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.v_ds_phanmanhTableAdapter.Fill(this.dS_PHANMANH.v_ds_phanmanh);
            Program.bds_dspm = bds_ds_phanmanh;
            frmDangnhap f = new frmDangnhap();
            f.MdiParent = this;
            f.Show();
        }
        
        private void ts_lb1_MouseHover(object sender, EventArgs e)
        {
            lbThoat.Font = new Font(lbThoat.Font.Name, lbThoat.Font.SizeInPoints, FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void ts_lb1_MouseLeave(object sender, EventArgs e)
        {
            lbThoat.Font = new Font(lbThoat.Font.Name, lbThoat.Font.SizeInPoints, FontStyle.Regular);
            this.Cursor = Cursors.Default;
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            lbThoat.Visible= false;
            rbDangnhap.Enabled = true;
            frmDangnhap f = new frmDangnhap();
            f.MdiParent = this;
            f.Show();
            this.MA.Text = "";
            this.HOTEN.Text = "";
            this.NHOM.Text = "";
        }

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangnhap));
            if (f!= null) f.Activate();
            else
            {
                f = new frmDangnhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmMonhoc));
            if (f != null) f.Activate();
            else
            {
                f = new frmMonhoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form f = this.CheckExists(typeof(frmKhoa));
            if (f != null) f.Activate();
            else
            {
                f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmGV));
            if (f != null) f.Activate();
            else
            {
                f = new frmGV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmBode));
            if (f != null) f.Activate();
            else
            {
                f = new frmBode();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
