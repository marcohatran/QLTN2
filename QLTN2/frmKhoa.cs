using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTN2
{
    public partial class frmKhoa : Form
    {
        int current;
        private Boolean isThem = false, isSua = false;
        private String maCS;
        private String cMAKH, cTENKH;
        private String strLoi = "Mã khoa hoặc tên khoa đã tồn tại.\nXin kiểm tra lại";
        public frmKhoa()
        {
            InitializeComponent();
        }


        private void frmKhoa_Load(object sender, EventArgs e)
        {
            taKhoa.Connection.ConnectionString = this.taGV.Connection.ConnectionString = this.taLop.Connection.ConnectionString = Program.connstr;
            this.taKhoa.Fill(this.DS.KHOA);
            this.taGV.Fill(this.DS.GIAOVIEN);
            this.taLop.Fill(this.DS.LOP);
            cmbCS.DataSource = Program.bds_dspm;
            cmbCS.DisplayMember = "COSO";
            cmbCS.ValueMember = "TENSERVER";
            maCS = ((DataRowView)bdsKhoa[0])["MACS"].ToString().Trim();
            cmbCS.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "SINHVIEN" || Program.mGroup == "GIAOVIEN" || Program.mGroup == "COSO")
            {
                cmbCS.Enabled = false;
            }
            else
            {
                btnBack.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                cmbCS.Enabled = true;
            }


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cMAKH = cTENKH = "";
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            current = bdsKhoa.Position;
            kHOAGridControl.Enabled = false;
            isThem = true;
            them();
        }
        private void them()
        {
            bdsKhoa.AddNew();
            txtMAKH.Focus();
            txtCS.Text = maCS;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            current = bdsKhoa.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = kHOAGridControl.Enabled = false;
            isSua = true;
            cMAKH = ((DataRowView)bdsKhoa[current])["MAKH"].ToString().Trim();
            cTENKH = ((DataRowView)bdsKhoa[current])["TENKH"].ToString().Trim();
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKH.Text.Trim() != cMAKH || txtTENKH.Text.Trim() != cTENKH)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn bỏ dữ liệu đang cập nhật ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
            }
            if (isThem)
            {
                bdsKhoa.EndEdit();
                bdsKhoa.RemoveCurrent();
                bdsKhoa.Position = current;
            }
            else
            {
                bdsKhoa.CancelEdit();
                bdsKhoa.ResetCurrentItem();
            }
            kHOAGridControl.Enabled = true;
            isThem = isSua = groupBox1.Enabled = btnBack.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGV.Count != 0 || bdsLop.Count != 0)
            {
                MessageBox.Show("Không thể xóa môn học này.\nMôn học đang được sử dụng ở bảng khác.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muôn xóa môn học này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
                bdsKhoa.RemoveCurrent();
                try
                {
                    taKhoa.Update(DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taKhoa.Fill(this.DS.KHOA);
            this.taGV.Fill(this.DS.GIAOVIEN);
            this.taLop.Fill(this.DS.LOP);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "")
            {
                //lbKiemtra.Text = "Mã môn học không được để trống.";
                txtMAKH.Focus();
                return;
            }
            if (txtTENKH.Text == "")
            {
                // lbKiemtra.Text = "Tên môn học không được để trống.";
                txtMAKH.Focus();
                return;
            }
            if (isThem)
            {
                String strLenh = "Exec dbo.SP_KHOA_THEM '" + txtMAKH.Text.Trim() + "', N'" + txtTENKH.Text.Trim() + "','" + maCS + "'";
                if (Program.ExecSqlNonQuery(strLenh, strLoi) != 0)
                {
                    them();
                }
                return;
            }
            if (isSua)
            {
                if (txtMAKH.Text.Trim() != cMAKH || txtTENKH.Text.Trim() != cTENKH)
                {
                    String strLenh = "Exec dbo.SP_KHOA_SUA '" + txtMAKH.Text.Trim() + "', N'" + txtTENKH.Text.Trim() + "','" + cMAKH + "'";
                    if (Program.ExecSqlNonQuery(strLenh, strLoi) == 0)
                        return;
                    else
                    {
                        bdsKhoa.EndEdit();
                        bdsKhoa.ResetCurrentItem();
                    }
                }
                groupBox1.Enabled = false;
                kHOAGridControl.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                txtMAKH.Text = txtTENKH.Text = "";
                txtMAKH.Focus();
            }
            else
            {
                bdsKhoa.CancelEdit();
                bdsKhoa.ResetCurrentItem();
                kHOAGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            if (isSua && bdsKhoa.Position == current)
            {
                cMAKH = ((DataRowView)bdsKhoa[current])["MAKH"].ToString().Trim();
                cTENKH = ((DataRowView)bdsKhoa[current])["TENKH"].ToString().Trim();
                groupBox1.Enabled = true;
                kHOAGridControl.Enabled = false;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isSua)
            {
                current = bdsKhoa.Position;
                cMAKH = ((DataRowView)bdsKhoa[current])["MAKH"].ToString().Trim();
                cTENKH = ((DataRowView)bdsKhoa[current])["TENKH"].ToString().Trim();
                groupBox1.Enabled = true;
                kHOAGridControl.Enabled = false;
            }
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
