using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using test.Report;
using DevExpress.XtraReports.UI;

namespace test.form
{
    public partial class RpBDMH : DevExpress.XtraEditors.XtraForm
    {
        public RpBDMH()
        {
            InitializeComponent();
        }

        private void RpBDMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(comboBox1, Program.Bds_Dspm);
            load();
            comboBox1.SelectedIndex = Program.mKhoa;

            if (Program.mGroup.Equals("Khoa"))
                comboBox1.Enabled = false;

            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = comboBox1.SelectedValue.ToString();
                }
                if (comboBox1.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        load();

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }
        private void load()
        {

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);

        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            string mlop = edtLOP.Text;
            string mmh = cmbMonHoc.SelectedValue.ToString();
            int lan = (int)numLanThi.Value;
            DIEM_LOP rpt = new DIEM_LOP(mlop,mmh,lan);
            rpt.xrLTenLop.Text = lOPComboBox.Text;
            rpt.xrLMonHoc.Text = cmbMonHoc.Text;
            rpt.xrlLanThi.Text = lan.ToString();
            //ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}