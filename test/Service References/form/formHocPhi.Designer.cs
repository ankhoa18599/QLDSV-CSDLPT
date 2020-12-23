namespace test.form
{
    partial class formHocPhi
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHocPhi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBatDau = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.bdsCT_HoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.cT_HOADONTableAdapter = new test.QLDSVDataSetTableAdapters.CT_HOADONTableAdapter();
            this.cT_HOADONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoTienDong = new DevExpress.XtraEditors.TextEdit();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.mASVLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1 = new test.QLDSVDataSet1();
            this.tableAdapterManager = new test.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter1 = new test.QLDSVDataSet1TableAdapters.SINHVIENTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(15, 145);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 14;
            mALOPLabel.Text = "MALOP:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(5, 109);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(60, 13);
            hOLabel.TabIndex = 12;
            hOLabel.Text = "Họ và Tên:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(22, 71);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(38, 13);
            mASVLabel.TabIndex = 8;
            mASVLabel.Text = "MASV:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(634, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 8;
            label1.Text = "Niên khóa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(647, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 13);
            label2.TabIndex = 8;
            label2.Text = "Học kì:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(615, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 8;
            label3.Text = "Số tiền đóng:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBatDau,
            this.btnGhi,
            this.btnHuy,
            this.barButtonItem8});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBatDau, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Caption = "Bắt dầu";
            this.btnBatDau.Id = 0;
            this.btnBatDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.Image")));
            this.btnBatDau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.LargeImage")));
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBatDau_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thoát";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(911, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(911, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(911, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCT_HoaDon
            // 
            this.bdsCT_HoaDon.DataMember = "CT_HOADON";
            this.bdsCT_HoaDon.DataSource = this.qLDSVDataSet;
            // 
            // cT_HOADONTableAdapter
            // 
            this.cT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // cT_HOADONGridControl
            // 
            this.cT_HOADONGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cT_HOADONGridControl.DataSource = this.bdsCT_HoaDon;
            this.cT_HOADONGridControl.Location = new System.Drawing.Point(0, 218);
            this.cT_HOADONGridControl.MainView = this.gridView1;
            this.cT_HOADONGridControl.MenuManager = this.barManager1;
            this.cT_HOADONGridControl.Name = "cT_HOADONGridControl";
            this.cT_HOADONGridControl.Size = new System.Drawing.Size(911, 242);
            this.cT_HOADONGridControl.TabIndex = 9;
            this.cT_HOADONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gridView1.GridControl = this.cT_HOADONGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên Khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kì";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.Caption = "Số tiền đã đóng";
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // txtSoTienDong
            // 
            this.txtSoTienDong.Location = new System.Drawing.Point(692, 142);
            this.txtSoTienDong.Name = "txtSoTienDong";
            this.txtSoTienDong.Size = new System.Drawing.Size(165, 20);
            this.txtSoTienDong.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(692, 107);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 21);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(692, 67);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(165, 21);
            this.cmbNienKhoa.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.txtMaLop);
            this.groupControl1.Controls.Add(this.txtHo);
            this.groupControl1.Controls.Add(mALOPLabel);
            this.groupControl1.Controls.Add(hOLabel);
            this.groupControl1.Controls.Add(this.cmbNienKhoa);
            this.groupControl1.Controls.Add(this.numericUpDown1);
            this.groupControl1.Controls.Add(this.txtSoTienDong);
            this.groupControl1.Controls.Add(label3);
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(mASVLabel);
            this.groupControl1.Controls.Add(this.mASVLookUpEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(911, 189);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(66, 142);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(518, 20);
            this.txtMaLop.TabIndex = 15;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(66, 106);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.ReadOnly = true;
            this.txtHo.Size = new System.Drawing.Size(518, 20);
            this.txtHo.TabIndex = 15;
            // 
            // mASVLookUpEdit
            // 
            this.mASVLookUpEdit.Location = new System.Drawing.Point(66, 68);
            this.mASVLookUpEdit.MenuManager = this.barManager1;
            this.mASVLookUpEdit.Name = "mASVLookUpEdit";
            this.mASVLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mASVLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 50, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "HO", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "TEN", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHAI", "PHAI", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGAYSINH", "NGAYSINH", 61, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGHIHOC", "NGHIHOC", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.mASVLookUpEdit.Properties.DataSource = this.sINHVIENBindingSource1;
            this.mASVLookUpEdit.Properties.DisplayMember = "MASV";
            this.mASVLookUpEdit.Properties.NullText = "Chọn sinh viên";
            this.mASVLookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.mASVLookUpEdit.Properties.ValueMember = "MASV";
            this.mASVLookUpEdit.Size = new System.Drawing.Size(518, 20);
            this.mASVLookUpEdit.TabIndex = 9;
            this.mASVLookUpEdit.EditValueChanged += new System.EventHandler(this.mASVLookUpEdit_EditValueChanged);
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.qLDSVDataSet1;
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter1
            // 
            this.sINHVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // formHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 485);
            this.Controls.Add(this.cT_HOADONGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formHocPhi";
            this.Text = "formHocPhi";
            this.Load += new System.EventHandler(this.formHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBatDau;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource bdsCT_HoaDon;
        private QLDSVDataSetTableAdapters.CT_HOADONTableAdapter cT_HOADONTableAdapter;
        private DevExpress.XtraGrid.GridControl cT_HOADONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.TextEdit txtSoTienDong;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.LookUpEdit mASVLookUpEdit;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private QLDSVDataSet1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter1;
    }
}