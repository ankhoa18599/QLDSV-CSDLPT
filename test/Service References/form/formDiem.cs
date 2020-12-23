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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace test.form
{
    public partial class formDiem : DevExpress.XtraEditors.XtraForm
    {
        List<int> checksv = new List<int>();// check sv có điểm hay chưa 
        List<int> soLanThi = new List<int>();
        int lanthi = 0;
        public formDiem()
        {
            InitializeComponent();
            if (Program.mGroup.ToLower() == "user")
            {
                btnGhi.Enabled = btnHuy.Enabled = false;
                gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = false;
            }

        }

        private void formDiem_Load(object sender, EventArgs e)
        {
            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(cmbChonKhoa, Program.Bds_Dspm);
            cmbChonKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup.Equals("Khoa") || Program.mGroup.Equals("User"))
                cmbChonKhoa.Enabled = false;
            // TODO: This line of code loads data into the 'qLDSVDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet.v_DSLOP' table. You can move, or remove it, as needed.
            this.v_DSLOPTableAdapter.Fill(this.qLDSVDataSet.v_DSLOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.v_ds_PhanManh' table. You can move, or remove it, as needed.
            btnBatDau.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
            sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;


        }

        private void ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chonLop_EditValueChanged(object sender, EventArgs e)
        {
            if (chonLop.EditValue != null)
            {
                maLop.Text = chonLop.EditValue.ToString();
            }
            else
            {
                maLop.Text = null;
            }

            if (chonLop.EditValue != null && chonMonHoc.EditValue != null)
            {
                btnBatDau.Enabled = btnGhi.Enabled = btnHuy.Enabled = true;
            }

        }

        private void chonMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (chonLop.EditValue != null && chonMonHoc.EditValue != null)
            {
                btnBatDau.Enabled = btnGhi.Enabled = btnHuy.Enabled = true;
            }
            maMonHoc.Text = chonMonHoc.EditValue.ToString();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.checksv = new List<int>();
            lanthi = (int)numLanThi.Value;
            MessageBox.Show("Mã lớp: " + maLop.Text.Trim() + ", Mã môn học: " + maMonHoc.Text.Trim() + ", Lần thi: " + lanthi,
                                                "Xác nhận", MessageBoxButtons.OK);
            gridView1.Columns["MASV"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["HOTEN"].OptionsColumn.AllowEdit = false;
            if (Program.mGroup.ToLower() != "user")
            { gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = true; }
            try
            {
                if (lanthi == 1)
                {
                    sP_LAYDIEMSINHVIENTableAdapter.Fill(qLDSVDataSet.SP_LAYDIEMSINHVIEN, maLop.Text, maMonHoc.Text, lanthi);
                    if (DiemSV.Count == 0)
                    {
                        XtraMessageBox.Show("Lớp hiện không có sinh viên. Vui lòng chọn lớp khác", "Thông báo !", MessageBoxButtons.OK);
                        btnGhi.Enabled = false;
                        return;
                    }
                    if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 1) == 0 && kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 2) == 1)//lớp chưa ai có điểm
                    {
                        XtraMessageBox.Show("Lỗi dữ liệu", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, lanthi) == 0)//lớp chưa ai có điểm
                    {
                        btnGhi.Enabled = true;// thì cho phép ghi mới
                        //for (int i = 0; i < DiemSV.Count; i++)
                        //{
                        //    ((DataRowView)DiemSV[i])["DIEM"] = 0;
                        //} 
                    }
                    else if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, lanthi) == 1)// ít nhất 1 người có điểm
                    {
                        if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 2) == 0) // lần 2 chưa có điểm
                        {
                            btnGhi.Enabled = true;
                            //gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = true;
                        }
                        else if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 2) == 1)//lần 2 có điểm rồi thì miễn ghi miễn cập nhật
                        {

                            for (int i = 0; i < DiemSV.Count; i++)
                            {
                                if (((DataRowView)DiemSV[i])["DIEM"].ToString() == "")
                                {
                                    ((DataRowView)DiemSV[i])["DIEM"] = 0;
                                }
                            }
                            XtraMessageBox.Show("Điểm lần 2 đã có. Lần 1 không được sửa điểm. Chỉ được xem", "Thông báo !", MessageBoxButtons.OK);

                            gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = false;

                            btnGhi.Enabled = false;
                            //btnCapNhat.Enabled = false;
                            return;
                        }

                    }
                }
                else if (lanthi == 2)
                {
                    //sP_LAYDIEMSINHVIENTableAdapter.Fill(qLDSVDataSet.SP_LAYDIEMSINHVIEN, maLop.Text, maMonHoc.Text, lanthi);
                    if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 1) == 0 && kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 2) == 1)//lớp chưa ai có điểm
                    {
                        XtraMessageBox.Show("Lỗi dữ liệu", "Thông báo !", MessageBoxButtons.OK);
                        gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = false;
                        return;
                    }
                    if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 1) == 0)
                    {
                        MessageBox.Show("Sinh viên chưa có điểm lần 1 cho môn học này. Vui lòng nhập điểm lần 1 cho môn học này !", "Thông báo !", MessageBoxButtons.OK);
                        btnGhi.Enabled = false;
                        gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = false;
                        //btnCapNhat.Enabled = false;
                        return;
                    }
                    else if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, 1) == 1) // lần 1 đã có điểm
                    {
                        if (Program.mGroup.ToLower() != "user")
                        { gridView1.Columns["DIEM"].OptionsColumn.AllowEdit = true; }
                        if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, lanthi) == 0)//lần 2 chưa nhập điểm sv nào
                        {
                            sP_LAYDIEMSINHVIENTableAdapter.Fill(qLDSVDataSet.SP_LAYDIEMSINHVIEN, maLop.Text, maMonHoc.Text, 1);
                            btnGhi.Enabled = true;// thì cho phép ghi mới
                            for (int i = DiemSV.Count - 1; i >= 0; i--)
                            {
                                float checkDiem = 0;
                                DataRow dr = gridView1.GetDataRow(i);
                                if (dr["DIEM"].ToString() != "")
                                {
                                    //checkDiem = float.Parse(gridView1.GetRowCellValue(i, "DIEM").ToString());
                                    checkDiem = float.Parse(dr["DIEM"].ToString());
                                }
                                if (checkDiem > 5)
                                {
                                    dr.Delete();

                                }
                                else
                                {
                                    dr["DIEM"] = DBNull.Value;
                                    //gridView1.SetRowCellValue(i, "DIEM", "");
                                }
                            }
                        }
                        else if (kiemtradiemtheolan(maLop.Text, maMonHoc.Text, lanthi) == 1) // lần 2 có điểm
                        {
                            sP_LAYDIEMSINHVIENTableAdapter.Fill(qLDSVDataSet.SP_LAYDIEMSINHVIEN, maLop.Text, maMonHoc.Text, lanthi);
                            btnGhi.Enabled = true;
                            //.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("NO STUDENTS"))
                {
                    MessageBox.Show("Lớp hiện không có sinh viên. Vui lòng chọn lớp khác", "Thông báo !", MessageBoxButtons.OK);
                    btnGhi.Enabled = false;
                    return;
                }
                MessageBox.Show("Lỗi cập nhật dữ liệu" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                return;
            }
        }
        private int kiemtradiemtheolan(string malop, string mamh, int lan) // kiểm tra xem lớp X môn Y đã có điểm chưa. Miễn là môt người có điểm là cả lớp phải có. 
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = "dbo.SP_KIEMTRADIEMTHEOLAN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = malop;
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = mamh;
            Program.sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lan;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có điểm
            }
            else if (ret == "0")
            {
                return 0; //chưa có điểm
            }
            return 0;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LightPink;
            }
        }

        private void numLanThi_ValueChanged(object sender, EventArgs e)
        {
            lanthi = (int)numLanThi.Value;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = false;
            for (int i = DiemSV.Count - 1; i >= 0; i--)
            {
                DataRow dr = gridView1.GetDataRow(i);
                if (dr["DIEM"].ToString() == "")
                {
                    DialogResult Result = XtraMessageBox.Show("Vẫn còn sinh viên chưa nhập điểm! Đồng ý ghi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result == DialogResult.No)
                    {
                        btnGhi.Enabled = true;
                        return;
                    }
                    else if (Result == DialogResult.Yes)
                    {
                        break;
                    }
                }
            }

            // bắt đầu ghi dữ liệu
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;
            conn.Open();
            tran = conn.BeginTransaction();
            DiemSV.EndEdit();
            try
            {
                for (int i = 0; i < DiemSV.Count; i++)
                {

                    if (gridView1.GetRowCellValue(i, "DIEM").ToString().Trim() != "")
                    {
                        //MessageBox.Show(((DataRowView)DiemSV[i])["DIEM"].ToString() + i, "Thông báo !", MessageBoxButtons.OK);
                        float diem = float.Parse(((DataRowView)DiemSV[i])["DIEM"].ToString());
                        if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                        String str_sp = "dbo.SP_INSERT_DIEM";
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.sqlcmd.CommandText = str_sp;
                        Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)DiemSV[i])["MASV"].ToString();
                        Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMonHoc.Text;
                        Program.sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lanthi;
                        Program.sqlcmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                        Program.sqlcmd.ExecuteNonQuery();
                    }
                    else
                    {
                        continue;
                    }
                    Program.conn.Close();
                }
                tran.Commit();
            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }

            //try
            //{
            //        for (int i = 0; i < DiemSV.Count; i++)
            //        {

            //            if (gridView1.GetRowCellValue(i,"DIEM").ToString().Trim()!="")
            //            {
            //                //MessageBox.Show(((DataRowView)DiemSV[i])["DIEM"].ToString() + i, "Thông báo !", MessageBoxButtons.OK);
            //                float diem = float.Parse(((DataRowView)DiemSV[i])["DIEM"].ToString());
            //                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            //                String str_sp = "dbo.SP_INSERT_DIEM";
            //                Program.sqlcmd = Program.conn.CreateCommand();
            //                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            //                Program.sqlcmd.CommandText = str_sp;
            //                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)DiemSV[i])["MASV"].ToString();
            //                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMonHoc.Text;
            //                Program.sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lanthi;
            //                Program.sqlcmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
            //                Program.sqlcmd.ExecuteNonQuery();

            //                //this.checksv.Add(0);
            //            }else
            //            {
            //                continue;
            //            }
            //            Program.conn.Close();
            //        }

            //    }catch(Exception ex)
            //    {
            //        MessageBox.Show("Ghi điểm thất bại\n Lỗi:" +ex.Message, "Thông báo !", MessageBoxButtons.OK);
            //        return;
            //    }
            MessageBox.Show("Ghi điểm hoàn tất", "Thông báo !", MessageBoxButtons.OK);
            btnGhi.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DiemSV.CancelEdit();
        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.ClearColumnErrors();
            if (gridView1.GetFocusedRowCellDisplayText("DIEM").ToString() != "")
            {
                try
                {

                    float diem = float.Parse(gridView1.GetFocusedRowCellDisplayText("DIEM").ToString());
                    if (diem < 0 || diem > 10)
                    {
                        gridView1.SetColumnError(gridView1.Columns["DIEM"], "Điểm phải từ 0-10");
                    }

                }
                catch (Exception ex)
                {

                    gridView1.SetColumnError(gridView1.Columns["DIEM"], "Dữ liệu phải là số thực");
                }
            }

        }

        private void cmbChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChonKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cmbChonKhoa.SelectedValue.ToString();
                }
                if (cmbChonKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("KHÔNG CÓ QUYỀN TRÊN SITE NÀY", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        v_DSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        v_DSLOPTableAdapter.Fill(this.qLDSVDataSet.v_DSLOP);
                        //mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        //mONHOCTableAdapter.Fill(this.qLDSVDataSet.MONHOC);
                        chonLop.Enabled = chonMonHoc.Enabled = true;
                        chonLop.EditValue = null;
                        btnBatDau.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                        sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi cập nhật dữ liệu!" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}