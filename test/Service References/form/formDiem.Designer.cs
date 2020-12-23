namespace test.form
{
    partial class formDiem
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
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDiem));
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
            this.ThongTin = new DevExpress.XtraEditors.GroupControl();
            this.cmbChonKhoa = new System.Windows.Forms.ComboBox();
            this.numLanThi = new System.Windows.Forms.NumericUpDown();
            this.maMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.maLop = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chonMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.MonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.chonLop = new DevExpress.XtraEditors.LookUpEdit();
            this.vDSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSLOPTableAdapter = new test.QLDSVDataSetTableAdapters.v_DSLOPTableAdapter();
            this.mONHOCTableAdapter = new test.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.DiemSV = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYDIEMSINHVIENTableAdapter = new test.QLDSVDataSetTableAdapters.SP_LAYDIEMSINHVIENTableAdapter();
            this.tableAdapterManager = new test.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.sP_LAYDIEMSINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTin)).BeginInit();
            this.ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLanThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDIEMSINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(50, 163);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(62, 13);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "MÔN HỌC :";
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
            this.btnBatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BatDau_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1029, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1029, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1029, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 477);
            // 
            // ThongTin
            // 
            this.ThongTin.AutoSize = true;
            this.ThongTin.Controls.Add(this.cmbChonKhoa);
            this.ThongTin.Controls.Add(this.numLanThi);
            this.ThongTin.Controls.Add(this.maMonHoc);
            this.ThongTin.Controls.Add(this.maLop);
            this.ThongTin.Controls.Add(this.label5);
            this.ThongTin.Controls.Add(this.label4);
            this.ThongTin.Controls.Add(this.label3);
            this.ThongTin.Controls.Add(this.chonMonHoc);
            this.ThongTin.Controls.Add(this.chonLop);
            this.ThongTin.Controls.Add(tENMHLabel);
            this.ThongTin.Controls.Add(this.label2);
            this.ThongTin.Controls.Add(this.label1);
            this.ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongTin.Location = new System.Drawing.Point(0, 28);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(1029, 207);
            this.ThongTin.TabIndex = 6;
            this.ThongTin.Text = "Thông Tin";
            this.ThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.ThongTin_Paint);
            // 
            // cmbChonKhoa
            // 
            this.cmbChonKhoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbChonKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChonKhoa.FormattingEnabled = true;
            this.cmbChonKhoa.Location = new System.Drawing.Point(118, 52);
            this.cmbChonKhoa.Name = "cmbChonKhoa";
            this.cmbChonKhoa.Size = new System.Drawing.Size(345, 21);
            this.cmbChonKhoa.TabIndex = 32;
            this.cmbChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbChonKhoa_SelectedIndexChanged);
            // 
            // numLanThi
            // 
            this.numLanThi.Location = new System.Drawing.Point(722, 53);
            this.numLanThi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLanThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLanThi.Name = "numLanThi";
            this.numLanThi.Size = new System.Drawing.Size(218, 21);
            this.numLanThi.TabIndex = 19;
            this.numLanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLanThi.ValueChanged += new System.EventHandler(this.numLanThi_ValueChanged);
            // 
            // maMonHoc
            // 
            this.maMonHoc.Location = new System.Drawing.Point(722, 159);
            this.maMonHoc.MenuManager = this.barManager1;
            this.maMonHoc.Name = "maMonHoc";
            this.maMonHoc.Properties.ReadOnly = true;
            this.maMonHoc.Size = new System.Drawing.Size(218, 20);
            this.maMonHoc.TabIndex = 18;
            // 
            // maLop
            // 
            this.maLop.Location = new System.Drawing.Point(722, 108);
            this.maLop.MenuManager = this.barManager1;
            this.maLop.Name = "maLop";
            this.maLop.Properties.ReadOnly = true;
            this.maLop.Size = new System.Drawing.Size(218, 20);
            this.maLop.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "MÃ MÔN HỌC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "MÃ LỚP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "LẦN THI :";
            // 
            // chonMonHoc
            // 
            this.chonMonHoc.Location = new System.Drawing.Point(118, 160);
            this.chonMonHoc.MenuManager = this.barManager1;
            this.chonMonHoc.Name = "chonMonHoc";
            this.chonMonHoc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.chonMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chonMonHoc.Properties.DataSource = this.MonHoc;
            this.chonMonHoc.Properties.DisplayMember = "TENMH";
            this.chonMonHoc.Properties.NullText = "Chọn môn học";
            this.chonMonHoc.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.chonMonHoc.Properties.ValueMember = "MAMH";
            this.chonMonHoc.Size = new System.Drawing.Size(345, 20);
            this.chonMonHoc.TabIndex = 9;
            this.chonMonHoc.EditValueChanged += new System.EventHandler(this.chonMonHoc_EditValueChanged);
            // 
            // MonHoc
            // 
            this.MonHoc.DataMember = "MONHOC";
            this.MonHoc.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chonLop
            // 
            this.chonLop.Location = new System.Drawing.Point(118, 106);
            this.chonLop.MenuManager = this.barManager1;
            this.chonLop.Name = "chonLop";
            this.chonLop.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.chonLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chonLop.Properties.DataSource = this.vDSLOPBindingSource;
            this.chonLop.Properties.DisplayMember = "TENLOP";
            this.chonLop.Properties.NullText = "Chọn lớp ";
            this.chonLop.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.chonLop.Properties.ValueMember = "MALOP";
            this.chonLop.Size = new System.Drawing.Size(345, 20);
            this.chonLop.TabIndex = 8;
            this.chonLop.EditValueChanged += new System.EventHandler(this.chonLop_EditValueChanged);
            // 
            // vDSLOPBindingSource
            // 
            this.vDSLOPBindingSource.DataMember = "v_DSLOP";
            this.vDSLOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LỚP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KHOA :";
            // 
            // DsKhoa
            // 
            this.DsKhoa.DataMember = "v_ds_PhanManh";
            this.DsKhoa.DataSource = this.qLDSVDataSet;
            // 
            // v_DSLOPTableAdapter
            // 
            this.v_DSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // DiemSV
            // 
            this.DiemSV.DataMember = "SP_LAYDIEMSINHVIEN";
            this.DiemSV.DataSource = this.qLDSVDataSet;
            // 
            // sP_LAYDIEMSINHVIENTableAdapter
            // 
            this.sP_LAYDIEMSINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LAYDIEMSINHVIENGridControl
            // 
            this.sP_LAYDIEMSINHVIENGridControl.DataSource = this.DiemSV;
            this.sP_LAYDIEMSINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_LAYDIEMSINHVIENGridControl.Location = new System.Drawing.Point(0, 231);
            this.sP_LAYDIEMSINHVIENGridControl.MainView = this.gridView1;
            this.sP_LAYDIEMSINHVIENGridControl.MenuManager = this.barManager1;
            this.sP_LAYDIEMSINHVIENGridControl.Name = "sP_LAYDIEMSINHVIENGridControl";
            this.sP_LAYDIEMSINHVIENGridControl.Size = new System.Drawing.Size(1029, 274);
            this.sP_LAYDIEMSINHVIENGridControl.TabIndex = 11;
            this.sP_LAYDIEMSINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.gridView1.GridControl = this.sP_LAYDIEMSINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // formDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 527);
            this.Controls.Add(this.sP_LAYDIEMSINHVIENGridControl);
            this.Controls.Add(this.ThongTin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formDiem";
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.formDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTin)).EndInit();
            this.ThongTin.ResumeLayout(false);
            this.ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLanThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDIEMSINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl ThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit chonMonHoc;
        private DevExpress.XtraEditors.LookUpEdit chonLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource DsKhoa;
        private System.Windows.Forms.BindingSource vDSLOPBindingSource;
        private QLDSVDataSetTableAdapters.v_DSLOPTableAdapter v_DSLOPTableAdapter;
        private System.Windows.Forms.BindingSource MonHoc;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.TextEdit maMonHoc;
        private DevExpress.XtraEditors.TextEdit maLop;
        private System.Windows.Forms.BindingSource DiemSV;
        private QLDSVDataSetTableAdapters.SP_LAYDIEMSINHVIENTableAdapter sP_LAYDIEMSINHVIENTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_LAYDIEMSINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.NumericUpDown numLanThi;
        private System.Windows.Forms.ComboBox cmbChonKhoa;
    }
}