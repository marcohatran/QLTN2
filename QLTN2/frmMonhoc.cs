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
    public partial class frmMonhoc : Form
    {
        int current;
        private Boolean isThem = false, isSua = false;
        private Boolean isLoi = false;
        private String cMAMH, cTENMH;
        DataRowView drv;

        public frmMonhoc()
        {
            InitializeComponent();
        }


        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            taMonhoc.Connection.ConnectionString= taGVDK.Connection.ConnectionString= taBode.Connection.ConnectionString= taBangdiem.Connection.ConnectionString = Program.connstr;
            this.taMonhoc.Fill(this.DS.MONHOC);
            // TODO: This line of code loads data into the 'qLTN_CS1_DataSet.BODE' table. You can move, or remove it, as needed.
            this.taBode.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'qLTN_CS1_DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            this.taBangdiem.Fill(this.DS.BANGDIEM);
            groupBox1.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cMAMH = "";
            cTENMH = "";
            groupBox1.Enabled = btnBack.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLammoi.Enabled = false;
            current = bdsMonhoc.Position;
            mONHOCGridControl.Enabled = false;
            isThem = true;
            them();
        }
        private void them()
        {
            bdsMonhoc.AddNew();
            txtMAMH.Focus();

        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMAMH.Text.Trim() != cMAMH || txtTENMH.Text.Trim() != cTENMH)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn bỏ thông tin đang cập nhật ??\nNếu có dữ liệu sẽ khôi phục lại ban đầu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
            }
            bdsMonhoc.CancelEdit();
            if (isThem)
            {
                bdsMonhoc.RemoveCurrent();
                bdsMonhoc.Position = current;
            }
            else
                {
                if (isLoi)
                {
                    txtMAMH.Text = cMAMH;
                    txtTENMH.Text = cTENMH;
                    bdsMonhoc.EndEdit();
                    taMonhoc.Update(DS.MONHOC);
                }
                bdsMonhoc.ResetCurrentItem();
            }
            mONHOCGridControl.Enabled = true;
            isThem = isSua = isLoi = groupBox1.Enabled = btnBack.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLammoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = btnBack.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = mONHOCGridControl.Enabled = btnLammoi.Enabled= false;
            isSua = true;
            sua();
        }

        private void sua()
        {
            current = bdsMonhoc.Position;
            drv = (DataRowView)bdsMonhoc.Current;
            cMAMH = drv["MAMH"].ToString().Trim();
            cTENMH = drv["TENMH"].ToString().Trim();
            groupBox1.Enabled = true;
            mONHOCGridControl.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                txtMAMH.Text = txtTENMH.Text = "";
                txtMAMH.Focus();
            }
            else
            {
                bdsMonhoc.CancelEdit();
                bdsMonhoc.ResetCurrentItem();
                mONHOCGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isSua)
            {
                sua();
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBode.Count != 0 || bdsGVDK.Count != 0 || bdsBangdiem.Count != 0)
            {
                MessageBox.Show("Không thể xóa môn học này.\nMôn học đang được sử dụng ở bảng khác.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muôn xóa môn học này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
                bdsMonhoc.RemoveCurrent();
                try
                {
                    taMonhoc.Update(DS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            if (bdsMonhoc.Position == current && isSua)
            {
                sua();
            }
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taMonhoc.Fill(this.DS.MONHOC);
            this.taBode.Fill(this.DS.BODE);
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            this.taBangdiem.Fill(this.DS.BANGDIEM);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMAMH.Text == "")
            {
                lbKiemtra.Text = "Mã môn học không được để trống.";
                txtMAMH.Focus();
                return;
            }
            if (txtTENMH.Text == "")
            {
                lbKiemtra.Text = "Tên môn học không được để trống.";
                txtMAMH.Focus();
                return;
            }

            bdsMonhoc.EndEdit();
            bdsMonhoc.ResetCurrentItem();
            try
            {
                taMonhoc.Update(DS.MONHOC);
            }
            catch (Exception ex)
            {
                SqlException sqle = (SqlException)ex;
                if (sqle.Number == 2627)
                    MessageBox.Show("mã môn học hoặc tên môn học bận cập nhật đã tồn tại.\n Xin kiểm tra lại", "Phi phạm ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLoi = true;
                return;
            }
            if (isThem)
            {
                them();
                return;
            }
            if (isSua)
            {
                mONHOCGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }

        }
        }


    }

