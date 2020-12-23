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
    public partial class formTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        String nLogin = "";
        String nPass = "";
        String nUserName = "";
        String nRole = "";
        public formTaoLogin()
        {
            
            InitializeComponent();
            
        }

        private void formTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.DSGV_CTTK' table. You can move, or remove it, as needed.
            this.dSGV_CTTKTableAdapter.Fill(this.qLDSVDataSet.DSGV_CTTK);
            // TODO: This line of code loads data into the 'qLDSVDataSet.v_ds_PhanManh' table. You can move, or remove it, as needed.
            this.v_ds_PhanManhTableAdapter.Fill(this.qLDSVDataSet.v_ds_PhanManh);
            //Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            
            if (Program.mGroup.ToLower()=="khoa" || Program.mGroup.ToLower() == "pkt")
            {
                cmbChonKhoa.Enabled = false;
                func.BindingDataToComBo(cmbChonKhoa, Program.Bds_Dspm);
                if (Program.mGroup.ToLower() == "khoa")
                {
                    //NhomQuyenGroup.Enabled = false;
                    cmbChonKhoa.SelectedIndex = Program.mKhoa; 
                    NhomQuyenGroup.SelectedIndex = 1;
                    NhomQuyenGroup.Properties.Items[0].Enabled = NhomQuyenGroup.Properties.Items[2].Enabled=false;
                }
                else if (Program.mGroup.ToLower() == "pkt")
                {
                    //Program.Bds_Dspm.RemoveFilter();
                    //func.BindingDataToComBo(cmbChonKhoa, Program.Bds_Dspm);
                    NhomQuyenGroup.Enabled = false;
                    NhomQuyenGroup.SelectedIndex = 2;
                }
            }else if(Program.mGroup.ToLower() == "pgv")
            {
                Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
                func.BindingDataToComBo(cmbChonKhoa, Program.Bds_Dspm);
                NhomQuyenGroup.Properties.Items[2].Enabled = false;
            }

            // TODO: This line of code loads data into the 'qLDSVDataSet.v_DSGV' table. You can move, or remove it, as needed.
            dSGV_CTTKTableAdapter.Connection.ConnectionString = Program.connstr;
            dSGV_CTTKTableAdapter.Fill(this.qLDSVDataSet.DSGV_CTTK);

        }

        private void taoLogin_Click(object sender, EventArgs e)
        {
            bool check = this.Validated();
            if (check)
            {
                
                nLogin = txtLogin.Text.Trim();
                nPass = txtPass.Text.Trim();
                nUserName = lookUpUser.EditValue.ToString();
                nRole = NhomQuyenGroup.EditValue.ToString();

                string strLenh = "DECLARE @A INT \n"
                    + "EXEC  @A= SP_TAOLOGIN '" + nLogin + "','" + nPass + "','" + nUserName + "','" + nRole + "'\n"
                    + "SELECT K=@A ";
                //string strLenh = "EXEC SP_TAOLOGIN '" + nLogin + "','" + nPass + "','" + nUserName + "','" + nRole + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    int noti = Program.myReader.GetInt32(0);
                    if (noti == 1)
                    {
                        MessageBox.Show("Trùng TÊN ĐĂNG NHẬP", "Thông báo !", MessageBoxButtons.OK);
                    }
                    else if (noti == 2)
                    {
                        MessageBox.Show("Giảng viên đã có tài khoản", "Thông báo !", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo !", MessageBoxButtons.OK);
                    }
                    Program.myReader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi tạo tài khoản!", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
            else { return; }
        }
        private void showConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showConfirmPass.Checked)
            {
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (PassWord.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private bool Validated()
        {
            bool isValid = true;

            errorProvider.Clear();

            if (txtLogin.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtLogin, "Vui lòng nhập tên login !");
                isValid = false;
            }
            else if (txtLogin.Text.Contains(" "))
            {
                this.errorProvider.SetError(this.txtLogin, "Tên login không được chứa khoảng trắng !");
                txtLogin.Focus();
                isValid = false;
            }

            if (txtPass.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtPass, "Vui lòng nhập mật khẩu");
                isValid = false;
            }
            else if (txtConfirm.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtConfirm, "Vui lòng nhập mật khẩu");
                isValid = false;
            }
            else if (txtConfirm.Text != txtPass.Text)
            {
                this.errorProvider.SetError(this.txtConfirm, "Mật khẩu không khớp");
                txtConfirm.Focus();
                isValid = false;
            }
            if (lookUpUser.EditValue == null)
            {
                this.errorProvider.SetError(this.lookUpUser, "Vui lòng chọn giảng viên");
                isValid = false;        
            }
            return isValid;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

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
                        dSGV_CTTKTableAdapter.Connection.ConnectionString = Program.connstr;
                        dSGV_CTTKTableAdapter.Fill(this.qLDSVDataSet.DSGV_CTTK);
                        lookUpUser.EditValue = null;
                        //MessageBox.Show(Program.servername,"Thông báo", MessageBoxButtons.OK);

                    }
                    catch (Exception ex) {
                        MessageBox.Show("Lỗi cập nhật dữ liệu!" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void lookUpUser_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}