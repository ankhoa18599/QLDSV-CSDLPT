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
    public partial class formMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0;
        bool isEdited = false;
        String oldMMH = null;
        String oldTMH = null;
        public formMonHoc()
        {
            InitializeComponent();
            if(Program.mGroup.ToLower()=="user"|| Program.mGroup.ToLower() == "khoa")
            {
                barBtnThem.Enabled = barBtnXoa.Enabled = barBtnSua.Enabled = barBtnHuy.Enabled = barBtnGhi.Enabled = barBtnUndo.Enabled = false;

            }
            groupBoxMonHoc.Enabled = false;
            
        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

        }

        private void formMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);
            // TODO: This line of code loads data into the 'qLDSVDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet.DIEM);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);

        }

        private void barBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formMonHoc_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void resetView_Click(object sender, EventArgs e)
        {
            formMonHoc_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
            }
            else if (txtTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
            }else{
                try
                {
                    oldMMH = txtMaMonHoc.Text;
                    oldTMH = txtTenMonHoc.Text;
                    if (kiemtraMMH(txtMaMonHoc.Text.Trim(),0)==1){
                        XtraMessageBox.Show("Trùng mã môn học!", "", MessageBoxButtons.OK);
                        txtMaMonHoc.Focus();
                        txtMaMonHoc.Select(txtMaMonHoc.Text.Length, 0);
                        return;
                    }else if(kiemtraMMH(standardString(txtTenMonHoc.Text), 1) == 1)
                    {
                        XtraMessageBox.Show("Trùng tên môn học!", "", MessageBoxButtons.OK);
                        txtTenMonHoc.Focus();
                        return;
                    }
                    mONHOCGridControl.Enabled = true;
                    groupBoxMonHoc.Enabled = false;
                    isEdited = true;
                    
                    this.mONHOCBindingSource.EndEdit();
                    this.mONHOCBindingSource.ResetCurrentItem();
                    this.mONHOCTableAdapter.Update(this.qLDSVDataSet.MONHOC);
                    //this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);

                    XtraMessageBox.Show("Lưu dữ liệu thành công", "", MessageBoxButtons.OK);
                    barBtnHuy.PerformClick();

                }
                catch (Exception ex)
                {
                    mONHOCGridControl.Enabled = false;
                    groupBoxMonHoc.Enabled = true;
                    MessageBox.Show("Lỗi ghi Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    txtMaMonHoc.Text = oldMMH;
                    txtTenMonHoc.Text = oldTMH;
                    txtMaMonHoc.Focus();
                    txtMaMonHoc.Select(txtMaMonHoc.Text.Length, 0);
                    return; 
                }
            }   
        }

        private void mONHOCBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (this.groupBoxMonHoc.Enabled)
            {
                String notifi = " Dữ liệu Môn Học chưa lưu vào Database. \n Bạn có chắc muốn thoát !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
                return;
            }

        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
            groupBoxMonHoc.Enabled = true;
            mONHOCGridControl.Enabled = false;
            mONHOCBindingSource.AddNew();
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            barBtnThem.Enabled
               = barBtnXoa.Enabled
               = barBtnSua.Enabled
               = barBtnUndo.Enabled
               = barBtnLamMoi.Enabled = true;
            groupBoxMonHoc.Enabled = false;
            mONHOCGridControl.Enabled = true;
            formMonHoc_Load(sender, e);
            if (_position > 0)
            {
                mONHOCBindingSource.Position = _position;
            }
        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxMonHoc_Enter(object sender, EventArgs e)
        {

        }

        private void barBtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnThem.Enabled
                = barBtnXoa.Enabled
                = barBtnSua.Enabled
                = barBtnUndo.Enabled
                = barBtnLamMoi.Enabled = false;
            groupBoxMonHoc.Enabled = true;
            mONHOCGridControl.Enabled = false;
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mONHOCBindingSource.Count == 0)
            {
                return;
            }
            else
            {
                if (dIEMBindingSource.Count > 0)
                {
                    MessageBox.Show("Môn học hiện đang có điểm sinh viên, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Môn học ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            mONHOCBindingSource.RemoveCurrent();
                            this.mONHOCTableAdapter.Update(this.qLDSVDataSet.MONHOC);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void barBtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private int kiemtraMMH(string check_str,int type) // kiểm tra xem lớp X môn Y đã có điểm chưa. Miễn là môt người có điểm là cả lớp phải có. 
        {
            //type = 0 check mmh/ =1 check ten mh
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp=null;
            str_sp = type == 0 ? "dbo.SP_CHECKID" : type == 1 ? "dbo.SP_CHECKNAME":"";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            if (type == 0)
            {
                Program.sqlcmd.Parameters.Add("@Ma", SqlDbType.NChar).Value = check_str;
                Program.sqlcmd.Parameters.Add("@Type", SqlDbType.NChar).Value = "MAMONHOC";
            }
            else if (type == 1)
            {
                Program.sqlcmd.Parameters.Add("@Name", SqlDbType.NChar).Value = check_str;
                Program.sqlcmd.Parameters.Add("@Type", SqlDbType.NChar).Value = "TENMONHOC";
            }
            
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có
            }
            else if (ret == "0")
            {
                return 0; //chưa có
            }
            return 0;
        }
        public string standardString(string strSource)
        {
            strSource=strSource.Trim();
            while (strSource.IndexOf("  ") != -1)
            {
                strSource = strSource.Replace("  ", " ");
            }
            return strSource;
        }
    }
}