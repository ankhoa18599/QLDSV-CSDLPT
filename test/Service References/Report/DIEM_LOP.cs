using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace test.Report
{
    public partial class DIEM_LOP : DevExpress.XtraReports.UI.XtraReport
    {
        public DIEM_LOP(String malop, String mmh, int lan)
        {
            InitializeComponent();
            this.sP_ReportPDMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportPDMHTableAdapter.Fill(BDMH.SP_ReportPDMH, malop, mmh, lan);
            xrLabel6.Text = Program.mHoten + " - " + Program.mGroup;
            //this.sP_ReportPDMHTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sP_ReportPDMHTableAdapter.Fill((QLDSVDataSet1.SP_ReportPDMHDataTable)ds, malop,mmh,lan);
        }

    }
}
