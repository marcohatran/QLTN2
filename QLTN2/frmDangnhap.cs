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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTNDataSet.v_ds_phanmanh' table. You can move, or remove it, as needed.
            try
            {
                cOSOComboBox.DataSource = Program.bds_dspm;
                cOSOComboBox.DisplayMember = "COSO";
                cOSOComboBox.ValueMember = "TENSERVER";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cOSOComboBox.SelectedIndex = 1;
            cOSOComboBox.SelectedIndex = 0;

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtTaikhoan.Focus();
                return;
            }
            Program.login = txtTaikhoan.Text;
            Program.password = txtMatkhau.Text;
            Program.servername = cOSOComboBox.SelectedValue.ToString();
            if (Program.KetNoi() == 0) return;
            SqlDataReader myReader;
            
            String strLenh = "exec SP_DANGNHAP '" + Program.login + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            try
            {
                Program.username = myReader.GetString(0);     // Lay user name
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                    return; }
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MA.Text = "Mã : " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên : " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm : " + Program.mGroup;
            Program.mlogin = Program.login;
            Program.mpassword = Program.password;
            Program.frmChinh.rbDangnhap.Enabled = false;
            Program.mCoso = cOSOComboBox.SelectedIndex;
            Program.frmChinh.btnDangnhap.Enabled = false;
            Program.frmChinh.btnDangxuat.Enabled = true;
            Program.frmChinh.rb1.Visible = false;
            if (Program.mGroup == "SINHVIEN")
                Program.frmChinh.rbSV.Visible = true;
            else
                if (Program.mGroup == "GIAOVIEN")
                    Program.frmChinh.rbGV.Visible = true;
                else
                    Program.frmChinh.rbMenu.Visible = true;
            Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
