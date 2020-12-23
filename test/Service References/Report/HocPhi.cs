using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace test.Report
{
    public partial class HocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public HocPhi(string malop, string nienkhoa, int hocki)
        {
            InitializeComponent();
            this.sP_ReportHPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportHPTableAdapter.Fill(qldsvDataSet11.SP_ReportHP, malop,nienkhoa,hocki);
            xrLTSSV.Text = qldsvDataSet11.SP_ReportHP.Rows.Count.ToString();
            xrLabel6.Text = Program.mHoten + " - " + Program.mGroup;
        }

    }
}
