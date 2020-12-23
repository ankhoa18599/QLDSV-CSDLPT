using System;
using System.Data;
using System.Windows.Forms;

namespace test.form
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLDSVDataSet1.GIANGVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            string kn = "Data Source=KHOA-PC;Initial Catalog=" + Program.database + ";Integrated Security=True";
            Program.conn.ConnectionString = kn;
            DataTable data = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            data = Program.ExecSqlDataTable("SELECT * FROM v_ds_PhanManh");
            Program.Bds_Dspm.DataSource = data;
            //// cất dt vào biến toàn cục Bds_Dspm
            Program.Bds_Dspm.Sort = "TENCN ASC";
            // đoạn code liên kết giữa bds với combobox 
            func.BindingDataToComBo(cb, data);
            //cb.DroppedDown = true;


        }

        public void loadAgain()
        {
            cb.SelectedItem = Program.mKhoa;
            Program.servername = cb.SelectedValue.ToString();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorPro.Clear();
            bool check = Validated();
            if (check == false)
            {
                return;
            }
            Program.servername = cb.SelectedValue.ToString();
            Program.servername_main = cb.SelectedValue.ToString();
            Program.mKhoa = cb.SelectedIndex;
            Program.mlogin = edtTaiKhoan.Text;
            Program.password = edtMatKhau.Text;

            if (Program.KetNoi() == 0) return;
            MessageBox.Show("Đăng nhập thành công");
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tên đăng nhập không có quyền truy cập dữ liệu.\nBạn xem lại Tên đăng nhập và Mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.myReader.Close();

            Program.formMain = new formMain();
            Program.login.Visible = false;
            //Program.login.Close();

            Program.formMain.Show();



        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cb.SelectedValue.ToString();
            }
            catch
            {
                return;
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            if (Program.login != null)
                Program.login.Close();
            Close();
        }

        private void edtTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void edtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            errorPro.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }

        }

        private void edtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            errorPro.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
        private bool Validated()
        {
            errorPro.Clear();
            bool check = true;
            if (edtTaiKhoan.Text == "")
            {
                this.errorPro.SetError(this.edtTaiKhoan, "Vui lòng nhập tài khoản");
                check = false;

            }
            if (edtMatKhau.Text == "")
            {
                this.errorPro.SetError(this.edtMatKhau, "Vui lòng nhập mật khẩu");
                check = false;
            }
            return check;
        }

        private void PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (PassWord.Checked)
            {
                edtMatKhau.Properties.UseSystemPasswordChar= false;
            }
            else
            {
                edtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
