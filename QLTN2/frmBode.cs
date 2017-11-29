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
    public partial class frmBode : Form
    {
        int current;
        private Boolean isThem = false, isSua = false, isLoi = false;
        private DataRowView drv;
        private ViewColumnFilterInfo filterInfo;
        private String cMAMH,cTD,cND,cA,cB,cC,cD,cDA;
        private int cCauhoi;

        public frmBode()
        {
            InitializeComponent();
        }

        private void frmBode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            taMonhoc.Connection.ConnectionString += ";password=123";
            taBode.Connection.ConnectionString += ";password=123";
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.taBode.Fill(this.DS.BODE);
            this.taMonhoc.Fill(this.DS.MONHOC);
            cmbMAMH.DataSource = bdsMonhoc;
            cmbMAMH.DisplayMember = cmbMAMH.ValueMember = "MAMH";
            String strFilter = "Contains([MAGV], '"+Program.username+"')";
            filterInfo = new ViewColumnFilterInfo(gridView1.Columns["MAGV"], new ColumnFilterInfo(strFilter));
            spnCauhoi.Properties.MinValue = 1;
            spnCauhoi.Properties.MaxValue = 999999;
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            cmbTrinhdo.Items.AddRange(Program.strTrinhdo);
        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            current = bdsBode.Position;
            groupBox1.Enabled = true;
            isThem = true;
            bODEGridControl.Enabled = false;
            btnBack.Enabled = true;
            cmbMAMH.SelectedIndex = 0;
            cMAMH = cmbMAMH.SelectedValue.ToString();
            cND = cA = cB = cC = cD = cDA = "";
            cTD = cmbTrinhdo.Items[0].ToString();
            them();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            gridView1.ActiveFilter.Add(filterInfo);
            colMAGV.OptionsFilter.AllowFilter = false;
            
            isSua = true;
            btnBack.Enabled = true;
            btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = false;
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muôn xóa câu này ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            bdsBode.RemoveCurrent();
            try
            {
                taBode.Update(DS.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void them()
        {
            bdsBode.AddNew();
            cCauhoi = Int32.Parse(((DataRowView)bdsBode[bdsBode.Count - 2])["CAUHOI"].ToString()) + 1;
            spnCauhoi.Value = cCauhoi;
            drv = (DataRowView)bdsBode[bdsBode.Count - 1];
            txtMAGV.Text = Program.username;
            cmbMAMH.Focus();
        }

        private void sua()
        {
            drv = (DataRowView)bdsBode.Current;
            cTD = drv["TRINHDO"].ToString().Trim();
            cND = drv["NOIDUNG"].ToString().Trim();
            cA = drv["A"].ToString().Trim();
            cB = drv["B"].ToString().Trim();
            cC = drv["C"].ToString().Trim();
            cD = drv["D"].ToString().Trim();
            cDA = drv["DAP_AN"].ToString().Trim();
            cCauhoi = int.Parse(drv["CAUHOI"].ToString().Trim());
            bODEGridControl.Enabled = false;
            groupBox1.Enabled = true;
            cMAMH = drv["MAMH"].ToString().Trim();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (isSua)
                sua();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isSua && e.KeyCode == Keys.Enter)
                sua();
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String a = cTD + " " + cND + " " + cA + " " + cB + " " + cC + " " + cD;
            try
            {
                if (cTD !=null && (spnCauhoi.Value != cCauhoi || txtDapan.Text.Trim() != cDA ||
                    cmbTrinhdo.SelectedItem.ToString() != cTD || txtNoidung.Text.Trim() != cND || txtA.Text.Trim() != cA || txtB.Text.Trim() != cB ||
                     txtC.Text.Trim() != cC || txtD.Text.Trim() != cD || cmbMAMH.SelectedValue.ToString() != cMAMH))
                {
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn bỏ thông tin đang cập nhật ??\nNếu có dữ liệu sẽ khôi phục lại ban đầu", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.No)
                        return;
                }
                hoiPhuc();
            }
            catch
            {

            }
            bdsBode.Position = current;
            bODEGridControl.Enabled = true;
            isThem = isSua = groupBox1.Enabled = btnBack.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLammoi.Enabled = true;
            gridView1.ActiveFilter.Clear();
            colMAGV.OptionsFilter.AllowFilter = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtNoidung.Text == "")
            {
                //lbKiemtra.Text = "Tên môn học không được để trống.";
                txtNoidung.Focus();
                return;
            }

            try
            {
                bdsBode.EndEdit();
                taBode.Update(DS.BODE);
                bdsBode.ResetCurrentItem();
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
                bODEGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                txtNoidung.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = txtDapan.Text = "";
                spnCauhoi.Text = cCauhoi.ToString(); 
                cmbTrinhdo.SelectedIndex= cmbMAMH.SelectedIndex = 0;
            }
            else
            {
                hoiPhuc();
                bODEGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }
        private void hoiPhuc()
        {
            if (isSua)
            {
                if (isLoi)
                {
                    cmbMAMH.SelectedValue = cMAMH;
                    cmbTrinhdo.SelectedValue = cTD;
                    spnCauhoi.Text = drv["CAUHOI"].ToString().Trim();
                    txtNoidung.Text = drv["NOIDUNG"].ToString().Trim();
                    txtA.Text = drv["A"].ToString().Trim();
                    txtB.Text = drv["B"].ToString().Trim();
                    txtC.Text = drv["C"].ToString().Trim();
                    txtD.Text = drv["D"].ToString().Trim();
                    txtDapan.Text = drv["TRINHDO"].ToString().Trim();
                    bdsBode.EndEdit();
                    taBode.Update(DS.BODE);
                    bdsBode.ResetCurrentItem();
                    isLoi = false;
                    return;
                }
                    bdsBode.CancelEdit();
                    bdsBode.ResetCurrentItem();
            }
            else
            {
                bdsBode.RemoveCurrent();
            }
        }
    



    }
}
