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
    public partial class RpHPLop : DevExpress.XtraEditors.XtraForm
    {
        List<string> listNienKhoa = new List<string>();
        private int _position;
        public RpHPLop()
        {
            InitializeComponent();

        }

        private void RpHPLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);

           

            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            string currentyear = datevalue.Year.ToString();
            int oldyear = int.Parse(currentyear) - 10;
            for (int i = 0; i < 13; i++)
            {
                string tmp = oldyear + "-" + (oldyear + 1);
                oldyear = oldyear + 1;
                listNienKhoa.Add(tmp);
            }
            cmbNienKhoa.DataSource = listNienKhoa;
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            cmbNienKhoa.SelectedIndex = 10;
            lookUpEdit1.EditValue = null;

        }

        private void load()
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            string mlop = edtLOP.Text;
            string nienkhoa = cmbNienKhoa.SelectedValue.ToString();
            int hocki = (int)numHocKi.Value;
            HocPhi rpt = new HocPhi(mlop, nienkhoa, hocki);
            rpt.xrLTenLop.Text = lookUpEdit1.Text.ToString();
            rpt.xrLNienKhoa.Text = nienkhoa;
            rpt.xrLHocKi.Text = hocki.ToString();
            //ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }

        private void edtLOP_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            edtLOP.Text = lookUpEdit1.EditValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}