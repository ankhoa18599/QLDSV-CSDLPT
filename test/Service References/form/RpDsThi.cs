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
    public partial class RpDsThi : DevExpress.XtraEditors.XtraForm
    {
        public RpDsThi()
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
                        btnIN.Enabled = false;

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

        private void RpDsThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            
            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(comboBox1, Program.Bds_Dspm);
            comboBox1.SelectedIndex = Program.mKhoa;

            if (Program.mGroup.Equals("Khoa")) comboBox1.Enabled = false;

            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            lookUpEdit1.EditValue = lookUpEdit2.EditValue = dateNgayThi.EditValue= null;
            btnIN.Enabled = false;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            edtLOP.Text = lookUpEdit1.EditValue.ToString();
            if(lookUpEdit1.EditValue != null & lookUpEdit2.EditValue !=null && dateNgayThi.EditValue != null)
            {
                btnIN.Enabled = true;
            }
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null & lookUpEdit2.EditValue != null && dateNgayThi.EditValue != null)
            {
                btnIN.Enabled = true;
            }
        }

        private void dateNgayThi_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null & lookUpEdit2.EditValue != null && dateNgayThi.EditValue != null)
            {
                btnIN.Enabled = true;
            }
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            string mlop = edtLOP.Text;
            string monhoc = lookUpEdit2.Text;
            string ngaythi = dateNgayThi.Text;
            int lanthi = (int)numLanThi.Value;
            DsThi rpt = new DsThi(mlop);
            rpt.xrLTenLop.Text = lookUpEdit1.Text.ToString();
            rpt.xrLMonHoc.Text = monhoc;
            rpt.xrLNgayThi.Text = ngaythi;
            rpt.xrlLanThi.Text = lanthi.ToString();
            //ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}