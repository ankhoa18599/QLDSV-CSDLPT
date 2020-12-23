using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace test.Report
{
    public partial class DSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public DSSV(string malopx)
        {
            InitializeComponent();
            qldsvDataSet11.EnforceConstraints = false;
            this.sP_ReportDSSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportDSSVTableAdapter.Fill(qldsvDataSet11.SP_ReportDSSV, malopx);
        }

    }
}
