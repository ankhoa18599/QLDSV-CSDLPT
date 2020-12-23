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

namespace test.form
{
    public partial class formHocPhi : DevExpress.XtraEditors.XtraForm
    {
        List<string> listNienKhoa = new List<string>();
        private int _position;
        int hocphi;
        int sotiendadong;
        string ngaydong;
        public formHocPhi()
        {
            InitializeComponent();
        }


        private void formHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.SINHVIEN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSVDataSet.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed. 
            this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter1.Fill(this.qLDSVDataSet1.SINHVIEN);
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
            mASVLookUpEdit.EditValue = txtHo.EditValue= txtMaLop.EditValue=null;
            txtSoTienDong.Enabled=btnGhi.Enabled = btnHuy.Enabled= false;
        }

        private void mASVLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            load();
            var selectedSV = mASVLookUpEdit.GetSelectedDataRow() as DataRowView;
            txtHo.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            txtSoTienDong.Text = "0";
            if (selectedSV.Row["NGHIHOC"].ToString().ToLower() == "true")
            {
                XtraMessageBox.Show("Sinh viên đã nghỉ học. Không được đóng học phí", "Thông báo", MessageBoxButtons.OK);
                btnBatDau.Enabled = false;
                return;
            }else
            {
                
                btnBatDau.Enabled = true;
            }
            //XtraMessageBox.Show(selectedSV.Row["NGHIHOC"].ToString(), "Thông báo", MessageBoxButtons.OK);
            //sINHVIENBindingSource.Position = mASVLookUpEdit.ItemIndex;

        }
        private void load()
        {
            // kết nối trước rồi mới fill.
            hocphi = sotiendadong = 0;
            this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter1.Fill(this.qLDSVDataSet1.SINHVIEN);
            this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_HOADONTableAdapter.Fill(qLDSVDataSet.CT_HOADON, mASVLookUpEdit.EditValue.ToString());
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = bdsCT_HoaDon.Count - 1; i >= 0; i--)
            {
                DataRow dr = gridView1.GetDataRow(i);
                if ((dr["NIENKHOA"].ToString().Equals(cmbNienKhoa.Text)) && (dr["HOCKY"].ToString() == numericUpDown1.Value.ToString()))
                {
                   
                    hocphi=int.Parse(dr["HOCPHI"].ToString());
                    if (dr["SOTIENDADONG"].ToString() != "")
                    {
                        sotiendadong = int.Parse(dr["SOTIENDADONG"].ToString());
                    }else
                    {
                        sotiendadong = 0;
                    }
                    
                    continue;
                }
                dr.Delete();

            }
            if (gridView1.DataRowCount == 0)
            {
                XtraMessageBox.Show("Sinh viên không/chưa học học kì này", "Thông báo", MessageBoxButtons.OK);
                btnHuy.PerformClick();
                return;
            }
            cmbNienKhoa.Enabled = numericUpDown1.Enabled= false;
            mASVLookUpEdit.Enabled = cmbNienKhoa.Enabled = numericUpDown1.Enabled = false;
            txtSoTienDong.Enabled= btnHuy.Enabled = true;
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            ngaydong = datevalue.Year.ToString() + "-" + datevalue.Month.ToString() + "-" + datevalue.Day.ToString();


            txtSoTienDong.Text = (hocphi - sotiendadong).ToString();
            if (((hocphi - sotiendadong) == 0) &&(hocphi+sotiendadong !=0))
            {
                MessageBox.Show("Sinh viên đã đóng tiền đầy đủ học kì này", "Thông báo", MessageBoxButtons.OK);
                load();
                btnGhi.Enabled = false;
                txtSoTienDong.Enabled = false;
                return;
            }else
            {
                btnGhi.Enabled = true;
                txtSoTienDong.Enabled = true;
                btnBatDau.Enabled = false;
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int sotiendong = int.Parse(txtSoTienDong.Text);
            if (sotiendong > (hocphi-sotiendadong))
            {
                XtraMessageBox.Show("Số tiền đóng không được lớn hơn học phí !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                int check = kiemtrahocphi(mASVLookUpEdit.EditValue.ToString(), cmbNienKhoa.Text, (int)numericUpDown1.Value, int.Parse(txtSoTienDong.Text.ToString()));
                if ( check == 1)
                {
                    MessageBox.Show("Sinh viên đã đóng tiền ngày hôm nay, vui lòng quay lại vào ngày khác", "Thông báo", MessageBoxButtons.OK);
                    load();
                    btnGhi.Enabled = false;
                    txtSoTienDong.Enabled = false;
                    return;
                }
                else if(check==0)
                {
                    //kiemtrahocphi(mASVLookUpEdit.EditValue.ToString(), cmbNienKhoa.Text, (int)numericUpDown1.Value, int.Parse(txtSoTienDong.ToString()));
                    MessageBox.Show("Đóng học phí thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else if (check == -1)
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }

        }
        private int kiemtrahocphi(string masv, string nienkhoa, int hocki, int sotiendong ) // kiểm tra xem lớp X môn Y đã có điểm chưa. Miễn là môt người có điểm là cả lớp phải có. 
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = "dbo.SP_UPDATE_HOCPHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = masv;
            Program.sqlcmd.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienkhoa;
            Program.sqlcmd.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocki;
            Program.sqlcmd.Parameters.Add("@NGAY", SqlDbType.NChar).Value = ngaydong;
            Program.sqlcmd.Parameters.Add("@SOTIEN", SqlDbType.Int).Value = sotiendong;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1; //hôm nay đã đóng
            }
            else if (ret == "0")
            {
                return 0; //hôm nay chưa đóng
            }
            else if (ret == "-1")
            {
                return -1; //thất bại
            }
            return 0;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
            btnBatDau.Enabled = true;
            mASVLookUpEdit.Enabled = cmbNienKhoa.Enabled = numericUpDown1.Enabled = true;
            btnGhi.Enabled = false;
            txtSoTienDong.Text = "0";
            txtSoTienDong.Enabled= false;
        }
    }
}