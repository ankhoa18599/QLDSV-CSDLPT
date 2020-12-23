namespace test.form
{
    partial class ChuyenLop
    {
         /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditChuyenLop = new DevExpress.XtraEditors.LookUpEdit();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMaSVMoi = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new test.QLDSVDataSetTableAdapters.KHOATableAdapter();
            this.lOPTableAdapter = new test.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new test.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new test.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.textEdit1);
            this.panel.Controls.Add(this.lookUpEditChuyenLop);
            this.panel.Controls.Add(this.mAMHLabel);
            this.panel.Controls.Add(this.txtMaLop);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.cbLop);
            this.panel.Controls.Add(this.tENMHLabel);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtTenSV);
            this.panel.Controls.Add(this.cbKhoa);
            this.panel.Controls.Add(this.labelMaSVMoi);
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.buttonOK);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1049, 355);
            this.panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(492, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(283, 206);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(202, 20);
            this.textEdit1.TabIndex = 15;
            this.textEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.textEdit1_EditValueChanging);
            // 
            // lookUpEditChuyenLop
            // 
            this.lookUpEditChuyenLop.Location = new System.Drawing.Point(283, 89);
            this.lookUpEditChuyenLop.Name = "lookUpEditChuyenLop";
            this.lookUpEditChuyenLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditChuyenLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "Mã sinh viên")});
            this.lookUpEditChuyenLop.Properties.DataSource = this.sINHVIENBindingSource;
            this.lookUpEditChuyenLop.Properties.DisplayMember = "MASV";
            this.lookUpEditChuyenLop.Properties.NullText = "Nhâp mã sv...";
            this.lookUpEditChuyenLop.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lookUpEditChuyenLop.Properties.ValueMember = "MASV";
            this.lookUpEditChuyenLop.Size = new System.Drawing.Size(133, 20);
            this.lookUpEditChuyenLop.TabIndex = 1;
            this.lookUpEditChuyenLop.EditValueChanged += new System.EventHandler(this.lookUpEditChuyenLop_EditValueChanged);
            this.lookUpEditChuyenLop.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpEditChuyenLop_EditValueChanging);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAMHLabel.Location = new System.Drawing.Point(105, 92);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(112, 18);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Mã sinh viên:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(796, 89);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(114, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lớp cần chuyển đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã lớp:";
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.lOPBindingSource;
            this.cbLop.DisplayMember = "MALOP";
            this.cbLop.Enabled = false;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(283, 166);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(202, 21);
            this.cbLop.TabIndex = 13;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectionChangeCommitted += new System.EventHandler(this.cbLop_SelectionChangeCommitted);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMHLabel.Location = new System.Drawing.Point(425, 93);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(105, 14);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Tên sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Khoa cần chuyển đến";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(536, 89);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(187, 20);
            this.txtTenSV.TabIndex = 3;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.kHOABindingSource;
            this.cbKhoa.DisplayMember = "TENKH";
            this.cbKhoa.Enabled = false;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(283, 125);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(202, 21);
            this.cbKhoa.TabIndex = 12;
            this.cbKhoa.ValueMember = "MAKH";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            this.cbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cbKhoa_SelectionChangeCommitted);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSVDataSet;
            // 
            // labelMaSVMoi
            // 
            this.labelMaSVMoi.AutoSize = true;
            this.labelMaSVMoi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSVMoi.Location = new System.Drawing.Point(105, 209);
            this.labelMaSVMoi.Name = "labelMaSVMoi";
            this.labelMaSVMoi.Size = new System.Drawing.Size(136, 18);
            this.labelMaSVMoi.TabIndex = 6;
            this.labelMaSVMoi.Text = "Mã Sinh Viên Mới";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(371, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 38);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "HỦY";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.Enabled = false;
            this.buttonOK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(246, 264);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(114, 38);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "XÁC NHẬN";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.qLDSVDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = test.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 408);
            this.Controls.Add(this.panel);
            this.Name = "ChuyenLop";
            this.Text = "Chuyển lớp";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelMaSVMoi;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditChuyenLop;
        private System.Windows.Forms.Label mAMHLabel;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLop;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSVDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label4;
    }
}