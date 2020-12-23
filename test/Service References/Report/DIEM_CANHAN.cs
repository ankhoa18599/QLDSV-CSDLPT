using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace test.Report
{
    public partial class DIEM_CANHAN : DevExpress.XtraReports.UI.XtraReport
    {
        public DIEM_CANHAN(String msv)
        {
            InitializeComponent();
            PDCN.EnforceConstraints = false;
            this.sP_ReportPDTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportPDTableAdapter.Fill(PDCN.SP_ReportPD, msv);
            xrLabel6.Text = Program.mHoten + " - " + Program.mGroup;
        }

    }
}
