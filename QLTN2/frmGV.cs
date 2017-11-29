using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class frmGV : Form
    {
        int current;
        private Boolean isThem = false, isSua = false;
        private String cMAGV, cHo, cTen, cHV, cMAKH;
        private Boolean isLoi = false;
        private DataRowView drv;
        private ViewColumnFilterInfo filterInfo;
        public frmGV()
        {
            InitializeComponent();
        }


        private void fromGV_Load(object sender, EventArgs e)
        {
            taBode.Connection.ConnectionString += ";password=123";
            this.taGV.Connection.ConnectionString += ";password=123";
            this.taGVDK.Connection.ConnectionString += ";password=123";
            taKhoa.Connection.ConnectionString += ";password=123";

            this.taKhoa.Fill(this.DS.KHOA);
            cmbMAKH.DataSource = bdsKhoa;
            cmbMAKH.DisplayMember = "MAKH";
            cmbMAKH.ValueMember = "MAKH";

            String strFilter = "";
            int count = cmbMAKH.Items.Count;
            for (int i = 0; i < count-1; i++)
            {
                cmbMAKH.SelectedIndex = i;
                strFilter += "[MAKH] = '" + cmbMAKH.SelectedValue +"'OR ";
            }
            cmbMAKH.SelectedIndex = count - 1;
            strFilter += "[MAKH] = '" + cmbMAKH.SelectedValue +"'";
            filterInfo = new ViewColumnFilterInfo(gridView1.Columns["MAKH"], new ColumnFilterInfo (strFilter));
            
            this.taGV.Fill(this.DS.GIAOVIEN);
            this.taBode.Fill(this.DS.BODE);
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMAGV.Text == "")
            {
                //lbKiemtra.Text = "Mã môn học không được để trống.";
                txtMAGV.Focus();
                return;
            }
            if (txtHo.Text == "")
            {
                //lbKiemtra.Text = "Tên môn học không được để trống.";
                txtHo.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                return;
            }
            if (txtHV.Text == "")
            {
                return;
            }

            bdsGV.EndEdit();
            try
            {
                taGV.Update(DS.GIAOVIEN);
                bdsGV.ResetCurrentItem();
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
                gIAOVIENGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                txtMAGV.Text = txtHo.Text = txtTen.Text = txtHV.Text = "";
                cmbMAKH.SelectedIndex = 0;
            }
            else
            {
                hoiPhuc();
                gIAOVIENGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbMAKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cMAGV = cHo = cTen = cHV = "";
            cmbMAKH.SelectedIndex = 0;
            groupBox1.Enabled = btnBack.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLammoi.Enabled = false;
            current = bdsGV.Position;
            gIAOVIENGridControl.Enabled = false;
            isThem = true;
            cMAKH = cmbMAKH.SelectedValue.ToString();
            them();
        }
        private void them()
        {
            bdsGV.AddNew();
            txtMAGV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbMAKH.DropDownStyle = ComboBoxStyle.DropDownList;
            gridView1.ActiveFilter.Add(filterInfo);
            MAKH.OptionsFilter.AllowFilter = false;
            isSua = true;
            btnBack.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLammoi.Enabled = false;
        }

        private void sua()
        {
            drv = (DataRowView)bdsGV.Current;
            cMAGV = drv["MAGV"].ToString().Trim();
            cHo = drv["HO"].ToString().Trim();
            cTen = drv["TEN"].ToString().Trim();
            cHV = drv["HOCVI"].ToString().Trim();
            cMAKH = drv["MAKH"].ToString().Trim();
            groupBox1.Enabled = true;
            gIAOVIENGridControl.Enabled = false;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isSua && e.KeyCode == Keys.Enter)
            {
                sua();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (isSua)
            {
                sua();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBode.Count != 0 || bdsGVDK.Count != 0)
            {
                MessageBox.Show("Không thể xóa môn học này.\nMôn học đang được sử dụng ở bảng khác.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muôn xóa môn học này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
                bdsGV.RemoveCurrent();
                try
                {
                    taGV.Update(DS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taGV.Fill(this.DS.GIAOVIEN);
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cMAGV !=null &&(txtMAGV.Text.Trim() != cMAGV || txtHo.Text.Trim() != cHo || txtTen.Text.Trim() != cTen 
                || txtHV.Text.Trim() != cHV || cmbMAKH.SelectedValue.ToString().Trim() != cMAKH))
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn bỏ thông tin đang cập nhật ??\nNếu có dữ liệu sẽ khôi phục lại ban đầu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
            }
            hoiPhuc();
            cmbMAKH.DropDownStyle = ComboBoxStyle.DropDown;
            isThem = isSua = groupBox1.Enabled = btnBack.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLammoi.Enabled = true;
            bdsGV.Position = current;
            gIAOVIENGridControl.Enabled = true;
            gridView1.ActiveFilter.Clear();
            MAKH.OptionsFilter.AllowFilter = true;

        }

        public void hoiPhuc()
        {
            if (isSua)
            {
                if (isLoi)
                {
                    txtMAGV.Text = cMAGV; txtHo.Text = cHo; txtTen.Text = cTen; txtHV.Text = cHV;
                    bdsGV.EndEdit();
                    taGV.Update(DS.GIAOVIEN);
                    bdsGV.ResetCurrentItem();
                    isLoi = false;
                }
                else
                {
                    bdsGV.CancelEdit();
                    bdsGV.ResetCurrentItem();
                }
            }
            else
            {
                bdsGV.EndEdit();
                bdsGV.RemoveCurrent();
            }
        }
    }
}
