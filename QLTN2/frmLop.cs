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
using System.Data.SqlClient;

namespace QLTN2
{
    public partial class frmLop : Form
    {
        int vitri = 0;
        private Boolean isThem = false, isHieuChinh = false;
        private DataRowView drv;
        String cMALOP, cTENLOP, cKHOA;
        private int cs;

        public frmLop()
        {
            InitializeComponent();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch { return; }
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.mlogin;
                Program.password = Program.mpassword;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taLop.Fill(this.DS.LOP);

            }
        }


        private void frmLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.taKhoa.Connection.ConnectionString = Program.connstr;
            this.taGVDK.Connection.ConnectionString = Program.connstr;
            this.taLop.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.taKhoa.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.DS.LOP);
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "COSO";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);

            cmbMaKH.DataSource = bdsKhoa;
            cmbMaKH.DisplayMember = "MAKH";
            cmbMaKH.ValueMember = "MAKH";
            cmbMaKH.SelectedIndex = 0;

            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
                cmbCoSo.Enabled = true;
            }
            else
                cmbCoSo.Enabled = false;


        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Xác nhận",
                         MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.taLop.Fill(this.DS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsLop.CancelEdit();
            if (btnThem.Enabled == false)
                bdsLop.Position = vitri;
            gcLop.Enabled = true;
            gbLop.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác trên Lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            if (isThem)
            {
                txtMaLop.Text = txtTenLop.Text = "";
                cmbMaKH.SelectedIndex = 0;
                bdsLop.Position = vitri;
            }
            else
            {
                txtTenLop.Text = cTENLOP;
                txtMaLop.Text = cMALOP;
                cmbMaKH.SelectedValue = cKHOA;
            }
            isThem = isHieuChinh = false;
            gcLop.Enabled = true;
            gbLop.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsLop.Position;
            gbLop.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled
            = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
            isThem = true;
            them();
        }
        
        private void them()
        {
            bdsLop.AddNew();
            txtMaLop.Focus();
            cmbMaKH.SelectedIndex = 1;
            cmbMaKH.SelectedIndex = 0;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã Lớp không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên lớp không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
          
            try
            {
                String strktr = "exec SP_KIEMTRALOP '" + txtMaLop.Text + "'";
                SqlDataReader Reader;
                Reader = Program.ExecSqlDataReader(strktr);
                if (Reader == null) return;
                Reader.Read();
                int valid = Reader.GetInt32(0);
                Reader.Close();
                if (valid == 1)
                {
                    if (isHieuChinh == true)
                    {
                        try
                        {
                            bdsLop.EndEdit();
                            bdsLop.ResetCurrentItem();
                            taLop.Update(DS.LOP);
                            MessageBox.Show("Hiệu chỉnh Lớp thành công!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // return;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                            MessageBox.Show("Lỗi ghi lớp.\n" , "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã lớp đã tồn tại !\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    taLop.Update(DS.LOP);
                    MessageBox.Show("Ghi lớp thành công!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLop.Enabled = true;
            gbLop.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = true;

    }

    private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gbLop.Enabled = true;
            vitri = bdsLop.Position;
            gcLop.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            btnUndo.Enabled = true;
            //malop.OptionsFilter.AllowFilter = false;
            isHieuChinh = true;
            hieuchinh();
        }
        private void hieuchinh()
        {
            drv = (DataRowView)bdsLop.Current;
            cMALOP = drv["MALOP"].ToString().Trim();
            cTENLOP = drv["TENLOP"].ToString().Trim();
            cKHOA = drv["MAKH"].ToString().Trim();
          
            cmbMaKH.SelectedIndex = 0;
            gbLop.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa Lớp này vì đã có GVDK", "",
                       MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa Lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // masv = int.Parse(((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();
                    this.taLop.Connection.ConnectionString = Program.connstr;
                    this.taLop.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.taLop.Fill(this.DS.LOP);
                    //  bdsSinhVien.Position = bdsSinhVien.Find("MASV", masv);
                    return;
                }
            }
        }
    }
}
