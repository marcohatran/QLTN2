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

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDKThi));
            if (f != null) f.Activate();
            else
            {
                f = new frmDKThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmThi));
            if (f != null) f.Activate();
            else
            {
                f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rbMenu.Visible = rbGV.Visible = rbSV.Visible = false;
            rb1.Visible = true;
            rbDangnhap.Enabled = true;
            btnDangnhap.Enabled = true;
            btnDangxuat.Enabled = false;
            frmDangnhap f = new frmDangnhap();
            f.MdiParent = this;
            f.Show();
            this.MA.Text = "";
            this.HOTEN.Text = "";
            this.NHOM.Text = "";
        }
    }
}
