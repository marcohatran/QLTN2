using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLTN2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();
            //Application.Run(frmChinh);
            Application.Run(new fromGV());
        }
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String servername = "";
        public static String username = "";
        public static String password = "";
        public static String login = "";

        public static String database = "QLTN";
        public static String remotelogin = "SUPPORT_CONNECT";
        public static String remotepassword = "123";
        public static String mGroup = "";
        public static String mHoten = "";
        public static String mlogin = "";
        public static String mpassword = "";
        public static int mCoso = -1;

        public static BindingSource bds_dspm;
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + 
                      Program.database + ";User ID=" + 
                      Program.login + ";password=" + Program.password;
                Program.conn.ConnectionString = connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\nBạn xem lại username và password.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String strLenh)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        public static int ExecSqlNonQuery(String strLenh, String strLoi)
        {
            int count = 0;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlCommand sqlcmd = Program.conn.CreateCommand();
            try
            {
                sqlcmd.CommandText = strLenh;
                count = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SqlException sqle = (SqlException)ex;
                if (sqle.Number == 2627)
                    MessageBox.Show(strLoi, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }

            public static int ExecSqlNonQuery(String strLenh)
            {
                int count = 0;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                SqlCommand sqlcmd = Program.conn.CreateCommand();
                try
                {
                    sqlcmd.CommandText = strLenh;
                    count = sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return count;
            }
        }
    }

