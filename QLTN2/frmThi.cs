using DevExpress.XtraEditors;
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
    public partial class frmThi : Form
    {
        private DataRowView drv;
        private DataTable tb;
        private int current;
        private int[] luachon;
        private RadioButton[] rbg = new RadioButton[5];
        private int socauthi;
        private String mamh;
        private String lan;
        private DateTime NT;
        int sec = 0, minute = 0;
        private Boolean thi = false;

        public frmThi()
        {
            InitializeComponent();
        }


        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'DS.BAITHI' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            taGVDK.Connection.ConnectionString = Program.connstr;
            taBangdiem.Connection.ConnectionString = Program.connstr;
            taBaithi.Connection.ConnectionString = Program.connstr;

            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            bAITHIGridControl.DataSource = null;
            this.taBaithi.Fill(this.DS.BAITHI);
            if (Program.mGroup == "SINHVIEN")
            {
                String strLenh = "Exec SP_LAY_LOP '" + Program.username + "'";
                SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) { MessageBox.Show("Loi"); return; };
                myReader.Read();
                String MALOP = myReader.GetString(0);
                String TENLOP = myReader.GetString(1);
                lbMALOP.Text = "Mã lớp: " + MALOP;
                lbTENLOP.Text = "Tên lớp: " +TENLOP;
                //bdsGVDK.Filter = "MALOP ='" +MALOP+ "'";
                DateTime temp = DateTime.Today;
                try
                {
                    bdsGVDK.Filter = "MALOP ='" + MALOP + "' And NGAYTHI >= '" + temp + "' And NGAYTHI <'" + temp.AddDays(1) + "'";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Is today([NGAYTHI]);
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsGVDK.Filter = "MAGV ='" + Program.username + "'";
            }


            cmbMAMH.DataSource = bdsGVDK;
            cmbMAMH.DisplayMember = "MAMH";
            cmbMAMH.ValueMember = "MAMH";
            try
            {
                cmbMAMH.SelectedIndex = 0;
            }
            catch { }
            gridView1.OptionsCustomization.AllowFilter = false;
            gridView1.OptionsCustomization.AllowSort = false;
            rbg[1] = A; rbg[2] = B; rbg[3] = C; rbg[4] = D;
            spnCau.Properties.MinValue = 1;

            this.A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.D.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);

        }

        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                drv = ((DataRowView)bdsGVDK.Current);
                NT = Convert.ToDateTime(drv["NGAYTHI"]);
                lan = drv["LAN"].ToString();
                lbNT.Text = "Ngày thi: " + NT.ToShortDateString();
                lbLan.Text = "Lần: " + lan;
            }
            catch { }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                mamh = cmbMAMH.SelectedValue.ToString();
                String strLenh = "Exec SP_KIEMTRA_THI '" + Program.username + "','" + mamh + "','" + lan + "'";
                SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) { MessageBox.Show("Loi"); return; }
                myReader.Read();
                int kiemtra = myReader.GetInt32(0);
                myReader.Close();
                if (kiemtra == 1)
                {
                    MessageBox.Show("Bạn đã thi đợt thi hiện tại của môn học này", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                btnChon.Enabled = false;
                cmbMAMH.Enabled = false;
                String trinhdo = drv["TRINHDO"].ToString();
                String socau = drv["SOCAUTHI"].ToString();
                minute = Convert.ToInt32(drv["THOIGIAN"]);
                socauthi = Convert.ToInt32(socau);
                spnCau.Properties.MaxValue = socauthi;
                lbSocau.Text = "/" + socau;
                strLenh = "EXEC sp_LAYDE '" + trinhdo + "','" + cmbMAMH.SelectedValue + "','" + socau + "'";
                bdsBaithi.Filter = "MASV = '" + Program.username + "' and MAMH = '" + mamh + "' and lan ='" + lan + "'";
                bAITHIGridControl.DataSource = bdsBaithi;
                tb = Program.ExecSqlDataTable(strLenh);
                if (tb == null)
                    return;
                luachon = new int[Convert.ToInt32(socau)];
                foreach (DataRow dr in tb.Rows)
                {
                    bdsBaithi.AddNew();
                    if (Program.mGroup == "SINHVIEN")
                    {
                        DataRowView drView = (DataRowView)bdsBaithi.Current;
                        drView["MASV"] = Program.username;
                        drView["MAMH"] = mamh;
                        drView["MACAUHOI"] = dr["CAUHOI"];
                        drView["LAN"] = lan;
                        bdsBaithi.EndEdit();
                        bdsBaithi.ResetCurrentItem();
                    }
                }
                btnChon.Enabled = false;
                btnThi.Enabled = true;
            }
            catch { }
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Value ==null && e.Column.FieldName == Cau.FieldName)
            {
                e.Value = e.ListSourceRowIndex + 1;
            }
        }

        private void loadCauhoi()
        {
            lbND.Text = "Câu "+(current+1)+" : "+tb.Rows[current]["NOIDUNG"].ToString();
            A.Text = tb.Rows[current]["A"].ToString();
            B.Text = tb.Rows[current]["B"].ToString();
            C.Text = tb.Rows[current]["C"].ToString();
            D.Text = tb.Rows[current]["D"].ToString();
            spnCau.Value = current+1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            if (current == socauthi)
                current = 0;
            bdsBaithi.Position = current;
            loadCauhoi();
            int temp = luachon[current];
            if (temp== 0) uncheck();
            else rbg[temp].Checked = true;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            current--;
            if (current < 0)
                current = socauthi - 1;
            bdsBaithi.Position = current;
            loadCauhoi();
            int temp = luachon[current];
            if (temp == 0) uncheck();
            else rbg[temp].Checked = true;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            current = bdsBaithi.Position;
            loadCauhoi();
            int temp = luachon[current];
            if (temp == 0) uncheck();
            else rbg[temp].Checked = true;
        }
        private void uncheck() {
            A.Checked = B.Checked = C.Checked = D.Checked = false;
        }

        private void A_CheckedChanged(object sender, EventArgs e)
        {
            if(A.Checked && luachon[current] != 1)
            {
                ((DataRowView)bdsBaithi.Current)["CAUTRALOI"] = "A";
                bdsBaithi.EndEdit();
                bdsBaithi.ResetCurrentItem();
                luachon[current] = 1;
            }

        }

        private void B_CheckedChanged(object sender, EventArgs e)
        {
            if (B.Checked && luachon[current] != 2)
            {
                ((DataRowView)bdsBaithi.Current)["CAUTRALOI"] = "B";
                bdsBaithi.EndEdit();
                bdsBaithi.ResetCurrentItem();
                luachon[current] = 2;
            }
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
            if (C.Checked && luachon[current] != 3)
            {
                ((DataRowView)bdsBaithi.Current)["CAUTRALOI"] = "C";
                bdsBaithi.EndEdit();
                bdsBaithi.ResetCurrentItem();
                luachon[current] = 3;
            }
        }

        private void D_CheckedChanged(object sender, EventArgs e)
        {
            if (D.Checked && luachon[current] != 4)
            {
                ((DataRowView)bdsBaithi.Current)["CAUTRALOI"] = "D";
                bdsBaithi.EndEdit();
                bdsBaithi.ResetCurrentItem();
                luachon[current] = 4;
            }
        }

        private void btnDi_Click(object sender, EventArgs e)
        {
            current = Convert.ToInt32(spnCau.Value);
            bdsBaithi.Position = current;
            loadCauhoi();
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            nopBai();
        }
        private void nopBai()
        {
            groupBox3.Enabled = false;
            btnNop.Enabled = false;
            int socaudung = 0;
            for (int i = 0; i < luachon.Length; i++)
            {
                int chon = luachon[i];
                if (chon == 0)
                    continue;
                String dapan = tb.Rows[i]["DAPAN"].ToString();
                if (rbg[chon].Name == dapan)
                    socaudung++;
            }
            double diem = (10.0 / socauthi) * socaudung;
            diem = Math.Round(diem, 2);
            MessageBox.Show("Số câu đúng: "+ socaudung + "/" + socauthi +" câu\nBạn được: "+diem +" điểm");
            thi = false;
            if (Program.mGroup == "SINHVIEN")
            {
                try
                {
                    taBangdiem.Insert(Program.username, mamh, Convert.ToSByte(lan), NT, diem);
                    bdsBaithi.EndEdit();
                    bdsBaithi.ResetCurrentItem();
                    taBaithi.Update(DS.BAITHI);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        private void rb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter )
                {
                    current++;
                    if (current == socauthi)
                        current = 0;
                    bdsBaithi.Position = current;
                    loadCauhoi();
                    int temp = luachon[current];
                    if (temp == 0) uncheck();
                    else rbg[temp].Checked = true;
                    return;
                }
            }
            catch { }
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            thi = true;
            btnThi.Enabled = false;
            bdsBaithi.Position = 0;
            current = 0;
            loadCauhoi();
            bAITHIGridControl.Enabled =groupBox3.Visible = true;
            btnNop.Enabled = true;
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTGThi.Text = fixTime(minute, sec);
            if (sec != 0)
            {
                sec--;
            }
            else
            {
                sec = 59;
                minute--;
            }
            if (minute == 0 && sec == 0)
            {
                timer.Stop();
                lbTGThi.Text = fixTime(minute, sec);
                nopBai();
               
            }
        }

        private void frmThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thi)
            {
                DialogResult rs =MessageBox.Show("Chương trình sẽ ghi lại kết quả thi.\n Bạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.No)
                {
                    //e.Cancel = true;
                    return;
                }
                //nopBai();
            }
        }

        public static String fixTime(int minute, int sec)
        {
            String time = "";
            String phut = "";
            String giay = "";
            if (minute < 9)
                phut = "0" + minute;
            else
                phut = "" + minute;
            if (sec < 9)
                giay = "0" + sec;
            else
                giay = "" + sec;

            time = phut + " : " + giay;
            return time;
        }
    }
}


