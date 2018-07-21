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
    public partial class frmDKThi : Form
    {
        private Boolean isThem, isSua = false, isLoi = false;
        private String cMALOP, cMAMH, cTRINHDO;
        private Decimal cLan, cSCT, cTG;
        private DateTime cNT;
        private int current;
        private DataRowView drv;
        private DateTime minDate;
        private ViewColumnFilterInfo filterInfo;
        public frmDKThi()
        {
            InitializeComponent();
        }



        private void frmDKThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            taGVDK.Connection.ConnectionString = Program.connstr;
            taLop.Connection.ConnectionString = taGVDK.Connection.ConnectionString;
            taMH.Connection.ConnectionString = taGVDK.Connection.ConnectionString;
            this.taLop.Fill(this.DS.LOP);
            this.taMH.Fill(this.DS.MONHOC);
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            cmbTrinhdo.Items.AddRange(Program.strTrinhdo);
            cmbCS.DataSource = Program.bds_dspm;
            cmbCS.DisplayMember = "COSO";
            cmbCS.ValueMember = "TENSERVER";
            cmbCS.SelectedIndex = 1;
            cmbCS.SelectedIndex = Program.mCoso;
            this.cmbCS.SelectedIndexChanged += new System.EventHandler(this.cmbCS_SelectedIndexChanged);

            cmbMALOP.DataSource = bdsLop;
            cmbMALOP.DisplayMember = "MALOP";
            cmbMALOP.ValueMember = "MALOP";

            cmbMAMH.DataSource = bdsMH;
            cmbMAMH.DisplayMember = "MAMH";
            cmbMAMH.ValueMember = "MAMH";

            String strFilter = "Contains([MAGV], '" + Program.username + "')";
            filterInfo = new ViewColumnFilterInfo(gridView1.Columns["MAGV"], new ColumnFilterInfo(strFilter));
            minDate = DateTime.Now.Date;
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnSua.Enabled =btnXoa.Enabled= false;
                cmbCS.Enabled = true;
                return;
            }
            if (Program.mGroup == "COSO")
            {
                btnXoa.Enabled = true;
            }

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            current = bdsGVDK.Position;
            cmbTrinhdo.SelectedIndex = cmbMALOP.SelectedIndex = cmbMAMH.SelectedIndex = 0;
            cTRINHDO = cmbTrinhdo.SelectedItem.ToString();
            cMAMH = cmbMAMH.SelectedValue.ToString();
            cMALOP = cmbMALOP.SelectedValue.ToString();
            cLan = spnLan.Properties.MinValue;
            cTG = spnTG.Properties.MinValue;
            cSCT = spnSCT.Properties.MinValue;
            cNT = minDate;
            gIAOVIEN_DANGKYGridControl.Enabled = false;
            groupBox1.Enabled = isThem  = btnBack.Enabled = true;
            them();
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (deNT.DateTime.Date < minDate)
            {
                MessageBox.Show("Ngày thi không hợp lệ !!");
                return;
            }
            String strLenh = "Exec SP_KIEMTRA_SOCAUHOI '" + cmbTrinhdo.SelectedItem.ToString() + "','"
                + cmbMAMH.SelectedValue.ToString() + "','" + spnSCT.Value + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) { MessageBox.Show("Loi"); return; }
            myReader.Read();
            int kiemtra = myReader.GetInt32(0);
            myReader.Close();
            if (kiemtra == 0)
            {
                MessageBox.Show("Số lượng câu hỏi trong bộ đề của môn học này không đủ.\nXin bổ sung thêm trước khi đăng kí","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                bdsGVDK.EndEdit();
                taGVDK.Update(DS.GIAOVIEN_DANGKY);
                bdsGVDK.ResetCurrentItem();
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
                sua();
                gIAOVIEN_DANGKYGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isThem)
            {
                spnLan.Value = cLan;
                spnSCT.Value = cSCT;
                spnTG.Value = cTG;
                deNT.DateTime = cNT;
                cmbTrinhdo.SelectedItem = cmbMAMH.SelectedIndex =cmbMALOP.SelectedIndex = 0;
            }
            else
            {
                hoiPhuc();
                gIAOVIEN_DANGKYGridControl.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCS.SelectedValue.ToString();
            }
            catch { return; }
            int cs = cmbCS.SelectedIndex;
            if(cs != Program.mCoso)
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
                return;
            taGVDK.Connection.ConnectionString = Program.connstr;
            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
        }

        private void spnSCT_KeyUp(object sender, KeyEventArgs e)
        {
            if (spnSCT.Value > spnSCT.Properties.MaxValue) {
                spnSCT.Value = spnSCT.Properties.MaxValue;
                return;
            }
            if(spnSCT.Value < spnSCT.Properties.MinValue)
                spnSCT.Value = spnSCT.Properties.MinValue;
        }

        private void spnTG_KeyUp(object sender, KeyEventArgs e)
        {
            if (spnTG.Value > spnTG.Properties.MaxValue)
            {
                spnTG.Value = spnTG.Properties.MaxValue;
                return;
            }
            if (spnTG.Value < spnTG.Properties.MinValue)
                spnTG.Value = spnTG.Properties.MinValue;
        }



        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa đợt thi này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            try
            {
                bdsGVDK.EndEdit();
                bdsGVDK.RemoveCurrent();
                taGVDK.Update(DS.GIAOVIEN_DANGKY);
            }
            catch { }

        }

        private void spnLan_KeyUp(object sender, KeyEventArgs e)
        {
            if (spnLan.Value > spnLan.Properties.MaxValue)
            {
                spnLan.Value = spnLan.Properties.MaxValue;
                return;
            }
            if (spnLan.Value < spnLan.Properties.MinValue)
                spnLan.Value = spnLan.Properties.MinValue;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            gridView1.ActiveFilter.Add(filterInfo);
            colMAGV.OptionsFilter.AllowFilter = false;
            isSua = true;
            btnBack.Enabled = true;
            btnXoa.Enabled = btnSua.Enabled = btnThem.Enabled = false;
            if(Program.mGroup == "GIANGVIEN")
                cmbMALOP.Enabled = cmbMAMH.Enabled = cmbTrinhdo.Enabled = false;
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cMAMH != null && (deNT.DateTime != cNT || spnSCT.Value != cSCT || spnTG.Value != cTG || spnLan.Value != cLan))
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
            if (isSua)
            {
                gridView1.ActiveFilter.Clear();
                colMAGV.OptionsFilter.AllowFilter = true;
            }
            if (Program.mGroup == "GIANGVIEN")
                cmbMALOP.Enabled = cmbMAMH.Enabled = cmbTrinhdo.Enabled = true;
            gIAOVIEN_DANGKYGridControl.Enabled = true;
            isThem = isSua = groupBox1.Enabled = btnBack.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLammoi.Enabled = true;
            bdsGVDK.Position = current;
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (isSua)
            {
                sua();
            }
        }

        private void them()
        {
            bdsGVDK.AddNew();
            cmbTrinhdo.SelectedIndex = cmbMALOP.SelectedIndex = cmbMAMH.SelectedIndex = 1;
            cmbTrinhdo.SelectedIndex = cmbMALOP.SelectedIndex = cmbMAMH.SelectedIndex = 0;
            deNT.DateTime = cNT;
            txtMAGV.Text = Program.username;
            spnLan.Value = cLan;
            spnTG.Value = cTG;
            spnSCT.Value = cSCT;
        }
        private void sua()
        {
            drv = (DataRowView)bdsGVDK.Current;
            cMALOP = drv["MALOP"].ToString();
            cMAMH = drv["MAMH"].ToString();
            cTRINHDO = drv["TRINHDO"].ToString();
            cLan = Convert.ToDecimal(drv["LAN"]);
            cTG = Convert.ToDecimal(drv["THOIGIAN"]);
            cSCT = Convert.ToDecimal(drv["SOCAUTHI"]);
            cNT = Convert.ToDateTime(drv["NGAYTHI"]);
            gIAOVIEN_DANGKYGridControl.Enabled = false;
            groupBox1.Enabled = true;

        }

        private void hoiPhuc()
        {
            if (isSua)
            {
                if (isLoi)
                {

                    isLoi = false;
                    return;
                }
                bdsGVDK.CancelEdit();
                bdsGVDK.ResetCurrentItem();
            }
            else
            {
                bdsGVDK.RemoveCurrent();
            }


        }
    }
}


