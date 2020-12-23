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
    public partial class RpPDCN : DevExpress.XtraEditors.XtraForm
    {
        string masv = "";
        public RpPDCN()
        {
            InitializeComponent();
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
            qLDSVDataSet.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);


        }

        private void RpPDCN_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            
            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(comboBox1, Program.Bds_Dspm);
            load();
            comboBox1.SelectedIndex = Program.mKhoa;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);

            if (Program.mGroup.Equals("Khoa"))
                comboBox1.Enabled = false;
        }

        private void cmbSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                masv = cmbSV.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (cmbSV.Items.Count == 0)
            {
              MessageBox.Show("Lớp chưa có sinh viên", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            string msv = cmbSV.Text;
            DIEM_CANHAN rpt = new DIEM_CANHAN(msv);
            rpt.xrLabel2.Text = cmbSV.Text.Trim();
            rpt.xrLabel3.Text = edtHo.Text + " " + edtTen.Text;
            rpt.xrLabel7.Text = lOPComboBox.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }

        private void lOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}