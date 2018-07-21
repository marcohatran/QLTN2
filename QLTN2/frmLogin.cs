using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTN2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "COSO")
            {
                cmbRole.Items.AddRange(new String[] { "COSO", "GIANGVIEN", "SINHVIEN" });
                cmbRole.SelectedItem = 0;
                return;
            }
            cmbRole.Items.Add("TRUONG");
            cmbRole.SelectedItem = 0;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Tên người dùng không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRole.Focus();
                return;
            }
           
           
            if (cmbRole.SelectedItem==null) 
            {
                MessageBox.Show("Bạn phải chọn nhóm cho tài khoản này!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  String strlenh= "exec SP_TAOTAIKHOAN '"+txtLogin.Text +"'   ," + "'"+txtPass.Text+"'    ,'" +txtUserName.Text+"',    '" + cmbRole.SelectedItem.ToString()+"' ";
            int id = Program.ExecCreateLogin(txtLogin.Text, txtPass.Text, txtUserName.Text, cmbRole.SelectedItem.ToString());

            if (id == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                txtUserName.Text = "";
                txtPass.Text = "";
                txtLogin.Text = "";
                cmbRole.SelectedIndex = -1;

            }
            else
                if (id == 2)
            {
                MessageBox.Show("Người này đã có tài khoản.\nChọn UserName khác!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
                    if (id == 1)
            {
                MessageBox.Show("Tài khoản đã có ngưởi sử dụng.\nHãy chọn LOGIN khác!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                      
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        
    }

        
    }

