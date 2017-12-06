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
            taBaithi.Connection.ConnectionString =taBangdiem.Connection.ConnectionString = taGVDK.Connection.ConnectionString ;

            this.taGVDK.Fill(this.DS.GIAOVIEN_DANGKY);
            this.taBaithi.Fill(this.DS.BAITHI);
            if(Program.mGroup == "SINHVIEN")
            {
                String strLenh = "Exec SP_LAY_LOP '" + Program.username + "'";
                SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) { MessageBox.Show("Loi"); return; };
                myReader.Read();
                String MALOP = myReader.GetString(0);
                String TENLOP = myReader.GetString(1);
                lbMALOP.Text = MALOP;
                lbTENLOP.Text = TENLOP;
                bdsGVDK.Filter = "MALOP ='" +MALOP+ "'";
                //bdsGVDK.Filter = "MALOP ='" + MALOP + "' And Is today([NGAYTHI])";
                //Is today([NGAYTHI]);
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsGVDK.Filter = "MAGV ='" + Program.username + "'";
            }



            bdsGVDK.Filter = "MALOP =" + "'D14CN1'";
            cmbMAMH.DataSource = bdsGVDK;
            cmbMAMH.DisplayMember = "MAMH";
            cmbMAMH.ValueMember = "MAMH";
            cmbMAMH.SelectedIndex = 0;
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

        private void btnThi_Click(object sender, EventArgs e)
        {
            btnThi.Enabled = false;
            cmbMAMH.Enabled = false;
            String trinhdo = drv["TRINHDO"].ToString();
            String socau = drv["SOCAUTHI"].ToString();
            socauthi = Convert.ToInt32(socau);
            spnCau.Properties.MaxValue = socauthi;
            lbSocau.Text = "/" + socau;
            String strLenh = "EXEC sp_LAYDE '" + trinhdo + "','" + cmbMAMH.SelectedValue + "','" + socau + "'";
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
                    drView["MACAUHOI"] = dr["CAUHOI"];
                    drView["LAN"] = lan;
                    bdsBaithi.EndEdit();
                    bdsBaithi.ResetCurrentItem();
                }
            }
            bdsBaithi.Position = 0;
            current = 0;
            loadCauhoi();
            groupBox3.Visible = true;
            btnPre.Enabled = false;
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
            lbND.Text = tb.Rows[current]["NOIDUNG"].ToString();
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
            int socaudung = 0;
            for(int i =0;i<luachon.Length;i++)
            {
                int chon = luachon[i];
                if (chon == 0)
                    continue;
                String dapan = tb.Rows[i]["DAPAN"].ToString();
                if (rbg[chon].Name == dapan)
                    socaudung++;
            }
            Double diem = (10.0 / socauthi) * socaudung;
            diem = Math.Round(diem, 2);
            MessageBox.Show(diem.ToString()+" "+socaudung +"/"+socauthi );
            if (Program.mGroup == "SINHVIEN")
            {
                taBaithi.Update(DS.BAITHI);
                taBangdiem.Insert(Program.username, mamh,Convert.ToSByte(lan), NT, diem);
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
    }
}


