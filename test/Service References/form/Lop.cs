using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Collections.Generic;
using test.QLDSVDataSetTableAdapters;

namespace test.form
{

    public partial class Lop : DevExpress.XtraEditors.XtraForm
    {
        int addLop;
        int addSV;
        int updateLop;
        int changeName;
        public int vitri;
        private CommandManager cmdManager;
        private CommandManager cmdManagerSV;
        public Lop()
        {
            InitializeComponent();
            vitri = 0;
            addLop = -1;
            addSV = -1;
            updateLop = -1;
            changeName = -1;
            cmdManager = new CommandManager();
            cmdManagerSV = new CommandManager();
        }

        private void Lop_Load(object sender, EventArgs e)
        {

            Program.Bds_Dspm.Filter = "TENCN LIKE 'KHOA%'";
            func.BindingDataToComBo(comboBox1, Program.Bds_Dspm);
            load();
            comboBox1.SelectedIndex = Program.mKhoa;
            if (Program.mGroup.Equals("Khoa"))
            {
                comboBox1.Enabled = false;
            }
            else if (Program.mGroup.Equals("User"))
            {
                comboBox1.Enabled = false;
                lOPBindingNavigator.Enabled = false;
                gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = true;
                contextMenuStrip1.Enabled = false;
                gridView2.OptionsBehavior.ReadOnly = true;
            }
            gridView1.ShowingEditor += (s, ex) =>
            {
                readOnly("MALOP", gridView1, addLop);
                
                if(addLop!=1)
                    cmdManager.execute(new UpdateAction(lOPBindingSource));
            

            };

            gridView2.ShowingEditor += (s, ex) =>
            {
                readOnly("MASV", gridView2, addSV);
                if (addSV != 1)
                    cmdManagerSV.execute(new UpdateAction(sINHVIENBindingSource));

            };
            gridView1.CellValueChanging += (s, ex) =>
            {
                changeName = 1;
        
            };
            gridView1.CellValueChanged += (s, ex) =>
            {
             
                changeName = -1;
                toolStripButton2.Enabled = true;
                if (addLop == 1) ((InsertAction)cmdManager.getLastUndoNode()).getData();
                else ((UpdateAction)cmdManager.getLastUndoNode()).getData();
            };
            gridView2.CellValueChanged += (s, ex) =>
            {
              //  gridView2.OptionsBehavior.ReadOnly = true;
                cntUndo.Enabled = true;
                if (addSV == 1) ((InsertAction)cmdManagerSV.getLastUndoNode()).getData();
                else ((UpdateAction)cmdManagerSV.getLastUndoNode()).getData();
            };
            toolStripButton2.Enabled = toolStripButton3.Enabled = false;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOP").ToString();
                String ten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString();
                if (ma.Length > 8)
                {
                    MessageBox.Show("Mã lớp quá dài (>8 kí tự)", "", MessageBoxButtons.OK);
                    return ;
                }
                else if (ten.Length > 200)
                {
                    MessageBox.Show("Tên lớp quá dài (>200 kí tự)", "", MessageBoxButtons.OK);
                    return ;
                }

                if (CheckLoiLop(ma, ten, "MALOP"))
                {

                    Validate();
                    this.lOPBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);
                    addLop = -1;
                    changeName = -1;
                    MessageBox.Show("Thành công");
                    load();

                }
                else
                {
                    addLop = 1;
                    MessageBox.Show("Thêm thất bại!!");
                }
            }
            catch (Exception ex)
            {
                addLop = 2;
                if (ex.ToString().Contains("UNIQUE"))
                    MessageBox.Show("Tên lớp đã tồn tại!!");
                return;

            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = comboBox1.SelectedValue.ToString();
                }
                if (comboBox1.SelectedIndex != Program.mKhoa)
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
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        load();

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }

        private bool CheckLoiLop(String ma, String ten, String type)
        {
           
            gridView1.ClearColumnErrors();
            if (ma.Equals(""))
            {

                if (type.Equals("MASV"))
                    gridView2.SetColumnError(gridView2.Columns[type], "Mã rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                else
                    gridView1.SetColumnError(gridView1.Columns["MALOP"], "Mã rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
            }
            if (ten.Equals(""))
            {
                if (type.Equals("MALOP"))
                    gridView1.SetColumnError(gridView1.Columns["TENLOP"], "Mã rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return false;
            }
            if (changeName == 1)
            {
                if (addLop == 1)
                    check(ten, "TENLOP", "SP_CHECKNAME");
                else if (addLop == -1)
                    return check(ten, "TENLOP", "SP_CHECKNAME");
            }

            if (addLop == 1 || addSV == 1)
            {

                //TODO: Check mã lớp có tồn tại chưa
                if (type.Equals("MASV"))
                    return check(ma, "MASV", "SP_CHECKID");
                else
                    return check(ma, "MALOP", "SP_CHECKID") && check(ten, "TENLOP", "SP_CHECKNAME"); ;
            }

            return true;
        }

        private bool check(String ma, String type, String sp)
        {
            string query1 = "DECLARE  @return_value int \n"
                           + "EXEC  @return_value = " + sp + " \n";
            if (!sp.Equals("SP_CHECKNAME"))
                query1 += "@Ma = N'" + ma + "',@Type = N'" + type + "' \n";
            else
                query1 += "@Name = N'" + ma + "',@Type = N'" + type + "' \n";
            query1 += "SELECT  'Return Value' = @return_value ";

            SqlDataReader resultMa = Program.ExecSqlDataReader(query1);
            if (resultMa == null)
            {
                MessageBox.Show("Server Lỗi");
                resultMa.Close();
                return false;
            }
            resultMa.Read();
            if (resultMa.GetInt32(0) == 1)
            {

                if (type.Equals("MASV"))
                    gridView2.SetColumnError(gridView2.Columns[type], "Mã tồn tại ở khoa này!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                else
                    gridView1.SetColumnError(gridView1.Columns[type], type + " tồn tại ở khoa này!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                resultMa.Close();
                return false;
            }
            if (resultMa.GetInt32(0) == 2)
            {

                if (type.Equals("MASV"))
                    gridView2.SetColumnError(gridView2.Columns[type], "Mã tồn tại ở khoa khác!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                else
                    gridView1.SetColumnError(gridView1.Columns[type], type + " tồn tại ở khoa khác!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                resultMa.Close();
                return false;
            }


            // check ten lop
            resultMa.Close();
            return true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = false;
            cmdManager.execute(new InsertAction(lOPBindingSource));
            addLop = 1;
            if (comboBox1.SelectedIndex == 0)
                gridView1.SetFocusedRowCellValue("MAKH", "CNTT");
            else if (comboBox1.SelectedIndex == 1)
                gridView1.SetFocusedRowCellValue("MAKH", "VT");

        }
        private void readOnly(String col, GridView GridView, int num)
        {
            if (num == 1)
            {

                if (GridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                {
                    GridView.Columns[col].OptionsColumn.ReadOnly = false;
                }
                else
                {
                    if (GridView.FocusedRowHandle == gridView1.RowCount - 1)
                        GridView.Columns[col].OptionsColumn.ReadOnly = false;
                    else
                        GridView.Columns[col].OptionsColumn.ReadOnly = true;
                }

            }
            else
            {
                GridView.Columns[col].OptionsColumn.ReadOnly = true;
            }
        }

        private void gridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(sINHVIENGridControl, e.Location);
            }
        }
        private void load()
        {

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
            this.lOPTableAdapter.Fill(this.qLDSVDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cmdManager.clear();
            cmdManagerSV.clear();
            cntUndo.Enabled = false;
            cntRedo.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            MessageBox.Show("Đã load lại dữ liệu");
            changeName = -1;
            addLop = -1;
            addSV = -1;
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addSV = 1;
            cmdManagerSV.execute(new InsertAction(sINHVIENBindingSource));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmdManagerSV.execute(new DeleteAction(sINHVIENBindingSource));
            addSV = -1;
            cntUndo.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            gridView2.ClearColumnErrors();
            try
            {
                String ma = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASV").ToString();
                String ho = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HO").ToString();
                String ten = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TEN").ToString();
                String noiSinh = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NOISINH").ToString();
                String diaChi = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIACHI").ToString();
                if (ho.Equals(""))
                {
                    gridView2.SetColumnError(gridView2.Columns["HO"], "Không được để rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                }
                if (ten.Equals(""))
                {
                    gridView2.SetColumnError(gridView2.Columns["TEN"], "Không được để rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);

                }
                if (noiSinh.Equals(""))
                {
                    gridView2.SetColumnError(gridView2.Columns["NOISINH"], "Không được để rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);

                }
                if (diaChi.Equals(""))
                {
                    gridView2.SetColumnError(gridView2.Columns["DIACHI"], "Không được để rỗng!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                    return;
                }
                if (CheckLoiLop(ma, ten, "MASV"))
                {
                    this.Validate();
                    this.sINHVIENBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.qLDSVDataSet);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    addSV = 1;
                    MessageBox.Show("Thêm thất bại!!");
                }
            }
            catch (Exception ex)
            {
                addSV = 2;
                return;

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string maLop = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOP").ToString();
            string query1 = "select COUNT(MASV) from SINHVIEN where MALOP = '" + maLop + "'";
            SqlDataReader resultMa = Program.ExecSqlDataReader(query1);
            resultMa.Read();
            int count = resultMa.GetInt32(0);
            if (count > 0)
            {
                MessageBox.Show("Lớp hiện tại đang có sinh viên không thể xóa");
                return;
            }
            resultMa.Close();
            cmdManager.execute(new DeleteAction(lOPBindingSource));
            toolStripButton2.Enabled = true;
            addLop = -1;
            changeName = -1;
            if (lOPBindingSource.Count == 0) bindingNavigatorDeleteItem.Enabled = false;
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cmdManager.undo();

            if (cmdManager.undoStackSize() == 0)
            {
                toolStripButton2.Enabled = false;
            }
            toolStripButton3.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cmdManager.redo();
            if (cmdManager.redoStackSize() == 0)
            {
                toolStripButton3.Enabled = false;
            }
            toolStripButton2.Enabled = true;
        }

        private void cntUndo_Click(object sender, EventArgs e)
        {
            cmdManagerSV.undo();

            if (cmdManagerSV.undoStackSize() == 0)
            {
                cntUndo.Enabled = false;
            }
            cntRedo.Enabled = true;
        }

        private void cntRedo_Click(object sender, EventArgs e)
        {
            cmdManagerSV.redo();
            if (cmdManagerSV.redoStackSize() == 0)
            {
                cntRedo.Enabled = false;
            }
            cntUndo.Enabled = true;
        }

        private void lamMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmdManagerSV.clear();
            cntUndo.Enabled = false;
            cntRedo.Enabled = false;
            MessageBox.Show("Đã load lại dữ liệu");
            addSV = -1;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet.SINHVIEN);
            updateLop = -1;
        }

        private void updateRow_Click(object sender, EventArgs e)
        {
            gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = false;
            updateLop = 1;
            cmdManager.execute(new UpdateAction(lOPBindingSource));
            
        }

        private void SuaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // gridView2.OptionsBehavior.ReadOnly = false;
            //gridView2.Columns["MASV"].OptionsColumn.ReadOnly = true;
            //if (addSV != 1)
            //{
            //    cmdManagerSV.execute(new UpdateAction(sINHVIENBindingSource));
            //}
        }
    }
}