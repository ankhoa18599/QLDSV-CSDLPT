using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.form;

namespace test
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            loadStatusBar();
            txtUsername.Text = "Mã giảng viên: " + Program.username;
            txtHoten.Text = "Họ tên: " + Program.mHoten;
            txtGroup.Text = "Nhóm: " + Program.mGroup;
            if (Program.mKhoa == 2)
            {

                btnClass.Enabled = btnStudent.Enabled = btnMark.Enabled = btnSubject.Enabled=barButtonItem4.Enabled = false;
                btnInDSSV.Enabled = btnInDSThi.Enabled = btnInDiem.Enabled = btnInPD.Enabled = btnBDTK.Enabled = false;
            }
            else
            {
                if (Program.mGroup.ToLower() == "user")
                {
                    btnInDSSV.Enabled = btnInDSThi.Enabled = btnInDiem.Enabled = btnInPD.Enabled = btnInHP.Enabled = btnBDTK.Enabled = false;
                    barButtonItem1.Enabled = false;
                }
                btnFee.Enabled = false;
                btnInHP.Enabled = false;
            }
        }

        //load thông tin bên dưới statustrip
        public void loadStatusBar()
        {
            txtUsername.Text = "Mã giảng viên: " + Program.username.Trim() + " ||";
            txtHoten.Text = "Họ tên: " + Program.mHoten.Trim() + " ||";
            txtGroup.Text = "Nhóm: " + Program.mGroup;
        }

        // kiểm tra form có tồn tại hay ko
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        //mở form Lớp
        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Lop));
            if (frm != null) frm.Activate();
            else
            {
                Program.lop = new Lop();
                Program.lop.MdiParent = this;
                Program.lop.Show();
            }
        }

        //mở form Điểm
        private void btnMark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDiem));
            if (frm != null) frm.Activate();
            else
            {
                formDiem f = new formDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        //mở form Sinh viên
        private void btnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //mở form Môn học
        private void btnSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.mh = new formMonHoc();
                Program.mh.MdiParent = this;
                Program.mh.Show();
            }
        }

        //mở form Học phí
        private void btnFee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                formHocPhi f = new formHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                formTaoLogin f = new formTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpBDMH frm = (RpBDMH)CheckExists(typeof(RpBDMH));
            if (frm != null) frm.Activate();
            else
            {
                Program.BDMH = new RpBDMH();

                Program.BDMH.MdiParent = this;

                Program.BDMH.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpDSSV frm = (RpDSSV)CheckExists(typeof(RpDSSV));
            if (frm != null) frm.Activate();
            else
            {
                Program.DSSV = new RpDSSV();

                Program.DSSV.MdiParent = this;

                Program.DSSV.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpHPLop frm = (RpHPLop)CheckExists(typeof(RpHPLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.HPLop = new RpHPLop();

                Program.HPLop.MdiParent = this;

                Program.HPLop.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpDsThi frm = (RpDsThi)CheckExists(typeof(RpDsThi));
            if (frm != null) frm.Activate();
            else
            {
                Program.DsThi = new RpDsThi();

                Program.DsThi.MdiParent = this;

                Program.DsThi.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpPDCN frm = (RpPDCN)CheckExists(typeof(RpPDCN));
            if (frm != null) frm.Activate();
            else
            {
                Program.PDCN = new RpPDCN();

                Program.PDCN.MdiParent = this;

                Program.PDCN.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                Close();
                //MessageBox.Show(Program.mKhoa.ToString());
                //Program.servername = Program.servername_main;
                Program.login.Visible = true;
                Program.Bds_Dspm.RemoveFilter();
                Program.login.loadAgain();
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ChuyenLop));
            if (frm != null) frm.Activate();
            else
            {
                ChuyenLop f = new ChuyenLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RpBDTK frm = (RpBDTK)CheckExists(typeof(RpBDTK));
            if (frm != null) frm.Activate();
            else
            {
                Program.BDTK = new RpBDTK();

                Program.BDTK.MdiParent = this;

                Program.BDTK.Show();
            }
        }
    }
}
