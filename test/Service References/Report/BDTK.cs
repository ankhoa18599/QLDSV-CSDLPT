using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace test.Report
{
    public partial class BDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public BDTK()
        {
            InitializeComponent();
        }
        public BDTK(string malop)
        {
            InitializeComponent();
            qldsvDataSet11.EnforceConstraints = false;
            this.sP_ReportBDTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_ReportBDTKTableAdapter.Fill(qldsvDataSet11.SP_ReportBDTK, malop);
        }

    }
}
