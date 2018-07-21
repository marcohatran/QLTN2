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
using System.Configuration;
using DevExpress.XtraGrid.Views.Base;

namespace QLTN2
{
    public partial class frmSinhVien : Form
    {
        int vitri=0;
     
        string  malop= "";
        string macs = "";
        private Boolean isThem = false, isHieuChinh = false;
        string cMASV, cHo, cTen,cNgaySinh, cDiachi;
        private DataRowView drv;
        private Boolean loi = false;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.COSO' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.

            dS.EnforceConstraints = false;
            this.taLop.Connection.ConnectionString = Program.connstr;
            this.taBangDiem.Connection.ConnectionString = Program.connstr;
            this.taSinhVien.Connection.ConnectionString = Program.connstr;
            this.taLop.Fill(this.dS.LOP);
            this.taBangDiem.Fill(this.dS.BANGDIEM);
            this.taSinhVien.Fill(this.dS.SINHVIEN);

            malop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            cmbMaLop.DataSource = bdsLop;
            cmbMaLop.DisplayMember = "MALOP";
            cmbMaLop.ValueMember = "MALOP";

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "COSO";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // cmbMaLop.SelectedIndex = 1;
            //    cmbMaLop.SelectedIndex = 1;
            int year = DateTime.Now.Year - 17;
            txtNgaySinh.Properties.MaxValue = new DateTime(year, 12, 31);


            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                gbSinhVien.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            }

            else
             cmbCoSo.Enabled = false;
            gbSinhVien.Enabled = false;


            
        }
        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
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
                this.taSinhVien.Connection.ConnectionString = Program.connstr;
                this.taSinhVien.Fill(this.dS.SINHVIEN);
                
            }
        }
            private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                
                    vitri = bdsSinhVien.Position;
                    gbSinhVien.Enabled = true;
                    btnHieuChinh.Enabled  = btnXoa.Enabled
                    = btnReload.Enabled = btnThoat.Enabled = false;
                    btnGhi.Enabled = btnHuy.Enabled = btnUndo.Enabled = true;
                    gcSinhVien.Enabled = false;
                    isThem = true;
                    them();
            
            }
        
        
        private void them()
        {
            bdsSinhVien.AddNew();
            txtMaSV.Focus();
            cmbMaLop.SelectedIndex = 1;
            cmbMaLop.SelectedIndex = 0;
        }
        
        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        { 
            /*
            
            this.taLop.Connection.ConnectionString = Program.connstr;
            this.taLop.Fill(this.dS.LOP);
            this.taSinhVien.Connection.ConnectionString = Program.connstr;
            this.taSinhVien.Fill(this.dS.SINHVIEN);
            this.taBangDiem.Connection.ConnectionString = Program.connstr;
            this.taBangDiem.Fill(this.dS.BANGDIEM);
        
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối ", "", MessageBoxButtons.OK);
            else
            {
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taLop.Fill(this.dS.LOP);
                this.taBangDiem.Connection.ConnectionString = Program.connstr;
                this.taBangDiem.Fill(this.dS.BANGDIEM);
                this.taSinhVien.Connection.ConnectionString = Program.connstr;
                this.taSinhVien.Fill(this.dS.SINHVIEN);
               
                malop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
            */
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Xác nhận",
                          MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
        }

       
        private void btnHuy_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tác trên sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
               // Close();
            if (isThem)
            {
                txtDiaChi.Text = txtHo.Text = txtTen.Text = txtMaSV.Text = "";
                txtNgaySinh.Text = "";
            }
            else
            {
                txtDiaChi.Text = cDiachi; txtHo.Text = cHo;txtMaSV.Text = cMASV;txtTen.Text = cTen;
                txtNgaySinh.Text = cNgaySinh;
                bdsSinhVien.EndEdit();
                bdsSinhVien.ResetCurrentItem();
                if (loi)
                    taSinhVien.Update(dS.SINHVIEN);
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            if (btnThem.Enabled == false)
                bdsSinhVien.Position = vitri;
            gcSinhVien.Enabled = true;
            gbSinhVien.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taSinhVien.Fill(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã sinh viên không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ sinh viên không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên sinh viên không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtNgaySinh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày sinh của sinh viên không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ của sinh viên không được trống !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            try
            {
                String strktr = "exec SP_KIEMTRASINHVIEN '" + txtMaSV.Text + "'";
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
                            bdsSinhVien.EndEdit();
                            bdsSinhVien.ResetCurrentItem();
                            this.taSinhVien.Update(this.dS.SINHVIEN);
                            MessageBox.Show("Hiệu chỉnh sinh viên thành công!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          // return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                            loi = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại !\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();
                    this.taSinhVien.Update(this.dS.SINHVIEN);
                    MessageBox.Show("Ghi sinh viên thành công!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcSinhVien.Enabled = true;
            gbSinhVien.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            // btnUndo.Enabled = false;
            btnUndo.Enabled = true;
        
        }
        
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int masv;
            if (bdsBangDiem.Count >0  )
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có bảng điểm", "",
                       MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                   // masv = int.Parse(((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSinhVien.RemoveCurrent();
                    this.taSinhVien.Connection.ConnectionString = Program.connstr;
                    this.taSinhVien.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.taSinhVien.Fill(this.dS.SINHVIEN);
                  //  bdsSinhVien.Position = bdsSinhVien.Find("MASV", masv);
                    return;
                }
            }

            if (bdsSinhVien.Count == 0) btnXoa.Enabled = false;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gbSinhVien.Enabled = true;
            vitri = bdsSinhVien.Position;
            gcSinhVien.Enabled = false;
            btnThem.Enabled =  btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled= btnHuy.Enabled = true;
            //malop.OptionsFilter.AllowFilter = false;
            isHieuChinh = true;
            hieuchinh();

        }
 /*       private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbMAKH.DropDownStyle = ComboBoxStyle.DropDownList;
            gridView1.ActiveFilter.Add(filterInfo);
            MAKH.OptionsFilter.AllowFilter = false;
            isSua = true;
            btnBack.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLammoi.Enabled = false;
        }*/

        private void hieuchinh()
        {
            drv = (DataRowView)bdsSinhVien.Current;
            cMASV =drv ["MASV"].ToString().Trim();
            cHo = drv["HO"].ToString().Trim();
            cTen = drv["TEN"].ToString().Trim();
            cNgaySinh = drv["NGAYSINH"].ToString().Trim();
            cDiachi = drv["MALOP"].ToString().Trim();
            cmbMaLop.SelectedIndex = 0;
            gbSinhVien.Enabled = true;
           gcSinhVien.Enabled = false;
        }

        private void gbSinhVien_Enter(object sender, EventArgs e)
        {

        }
    }


}
    

