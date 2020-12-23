using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using test.form;
using DevExpress.XtraEditors;

namespace test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlcmd = new SqlCommand();
        public static BindingSource Bds_Dspm = new BindingSource();
        public static String connstr;
        public static SqlDataReader myReader;       
        public static String servername = "";
        public static String servername_main= "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static int mKhoa = 0;
        public static String database = "QLDSV";
        public static String remotelogin = "HTKN_QLDSV";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static Main login;
        public static formMain formMain;
        public static Lop lop;
        public static formMonHoc mh;
        public static formHocPhi hp;
        public static int mChinhanh = 0;
        public static RpDSSV DSSV;
        public static RpBDMH BDMH;
        public static RpPDCN PDCN;
        public static RpHPLop HPLop;
        public static RpDsThi DsThi;
        public static RpBDTK BDTK;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Bạn xem lại user name và password.", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.login = new Main();
            Application.Run(Program.login);
        }
    }
}
