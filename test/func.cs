
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace test
{
    class func
    {
        public static void BindingDataToComBo(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENCN";
            combo.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.


            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
           combo.SelectedIndex = Program.mKhoa;
        }
        public static string GetMaKhoa()
        {
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();

            dt = Program.ExecSqlDataTable("SELECT MAKH FROM KHOA");
            bds.DataSource = dt;

            return ((DataRowView)bds[0])["MAKH"].ToString();
        }

        // hỗ trợ trong combobox chọn chi nhánh
       

        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        public static void BindingDataToComBo2(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENCN";
            combo.ValueMember = "TENSERVER";
            combo.SelectedIndex = 0;
        }
    }
}
