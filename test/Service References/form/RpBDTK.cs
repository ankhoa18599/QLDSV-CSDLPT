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
    public partial class RpBDTK : DevExpress.XtraEditors.XtraForm
    {
        public RpBDTK()
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

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);

        }

        private void btnIN_Click(object sender, EventArgs e)
        {

            string mlop = edtLOP.Text;
            BDTK rpt = new BDTK(mlop);
            rpt.ShowPreviewDialog();
        }

        private void RpDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(comboBox1, Program.Bds_Dspm);
            load();
            comboBox1.SelectedIndex = Program.mKhoa;

            if (Program.mGroup.Equals("Khoa"))
                comboBox1.Enabled = false;

            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);


        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

        }

        private void tENLOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void edtLOP_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}