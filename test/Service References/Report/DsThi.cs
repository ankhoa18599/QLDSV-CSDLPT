using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace test.Report
{
    public partial class DsThi : DevExpress.XtraReports.UI.XtraReport
    {
        public DsThi(string malop)
        {
            InitializeComponent();
            this.sP_ReportDsThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportDsThiTableAdapter.Fill(qldsvDataSet11.SP_ReportDsThi, malop);
            xrLabel6.Text = Program.mHoten + " - " + Program.mGroup;
        }

    }
}
