namespace test.form
{
    partial class formMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMonHoc));
            System.Windows.Forms.Label tENMHLabel;
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.barManagerMonHoc = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.mONHOCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.picture = new System.Windows.Forms.PictureBox();
            this.groupBoxMonHoc = new System.Windows.Forms.GroupBox();
            this.mONHOCTableAdapter = new test.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new test.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new test.QLDSVDataSetTableAdapters.DIEMTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingNavigator)).BeginInit();
            this.mONHOCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBoxMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            resources.ApplyResources(mAMHLabel, "mAMHLabel");
            mAMHLabel.Name = "mAMHLabel";
            // 
            // tENMHLabel
            // 
            resources.ApplyResources(tENMHLabel, "tENMHLabel");
            tENMHLabel.Name = "tENMHLabel";
            // 
            // barManagerMonHoc
            // 
            this.barManagerMonHoc.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManagerMonHoc.DockControls.Add(this.barDockControlTop);
            this.barManagerMonHoc.DockControls.Add(this.barDockControlBottom);
            this.barManagerMonHoc.DockControls.Add(this.barDockControlLeft);
            this.barManagerMonHoc.DockControls.Add(this.barDockControlRight);
            this.barManagerMonHoc.Form = this;
            this.barManagerMonHoc.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThem,
            this.barBtnXoa,
            this.barBtnSua,
            this.barBtnUndo,
            this.barBtnGhi,
            this.barBtnHuy,
            this.barBtnLamMoi,
            this.barBtnDong,
            this.barWorkspaceMenuItem1});
            this.barManagerMonHoc.MainMenu = this.bar2;
            this.barManagerMonHoc.MaxItemId = 9;
            this.barManagerMonHoc.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(71, 142);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.barBtnLamMoi, "Làm Mới", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // barBtnThem
            // 
            resources.ApplyResources(this.barBtnThem, "barBtnThem");
            this.barBtnThem.Id = 0;
            this.barBtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnThem.ImageOptions.SvgImage")));
            this.barBtnThem.Name = "barBtnThem";
            this.barBtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThem_ItemClick);
            // 
            // barBtnXoa
            // 
            resources.ApplyResources(this.barBtnXoa, "barBtnXoa");
            this.barBtnXoa.Id = 1;
            this.barBtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnXoa.ImageOptions.SvgImage")));
            this.barBtnXoa.Name = "barBtnXoa";
            this.barBtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoa_ItemClick);
            // 
            // barBtnSua
            // 
            resources.ApplyResources(this.barBtnSua, "barBtnSua");
            this.barBtnSua.Id = 2;
            this.barBtnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnSua.ImageOptions.SvgImage")));
            this.barBtnSua.Name = "barBtnSua";
            this.barBtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSua_ItemClick);
            // 
            // barBtnUndo
            // 
            resources.ApplyResources(this.barBtnUndo, "barBtnUndo");
            this.barBtnUndo.Id = 3;
            this.barBtnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUndo.ImageOptions.SvgImage")));
            this.barBtnUndo.Name = "barBtnUndo";
            // 
            // barBtnGhi
            // 
            resources.ApplyResources(this.barBtnGhi, "barBtnGhi");
            this.barBtnGhi.Id = 4;
            this.barBtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnGhi.ImageOptions.SvgImage")));
            this.barBtnGhi.Name = "barBtnGhi";
            this.barBtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGhi_ItemClick);
            // 
            // barBtnHuy
            // 
            resources.ApplyResources(this.barBtnHuy, "barBtnHuy");
            this.barBtnHuy.Id = 5;
            this.barBtnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnHuy.ImageOptions.SvgImage")));
            this.barBtnHuy.Name = "barBtnHuy";
            this.barBtnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHuy_ItemClick);
            // 
            // barBtnLamMoi
            // 
            resources.ApplyResources(this.barBtnLamMoi, "barBtnLamMoi");
            this.barBtnLamMoi.Id = 6;
            this.barBtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnLamMoi.ImageOptions.SvgImage")));
            this.barBtnLamMoi.Name = "barBtnLamMoi";
            this.barBtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLamMoi_ItemClick);
            // 
            // barBtnDong
            // 
            resources.ApplyResources(this.barBtnDong, "barBtnDong");
            this.barBtnDong.Id = 7;
            this.barBtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDong.ImageOptions.Image")));
            this.barBtnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDong.ImageOptions.LargeImage")));
            this.barBtnDong.Name = "barBtnDong";
            this.barBtnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDong_ItemClick);
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
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManagerMonHoc;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManagerMonHoc;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManagerMonHoc;
            this.barDockControlLeft.Click += new System.EventHandler(this.barDockControlLeft_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManagerMonHoc;
            this.barDockControlRight.Click += new System.EventHandler(this.barDockControlRight_Click);
            // 
            // barWorkspaceMenuItem1
            // 
            resources.ApplyResources(this.barWorkspaceMenuItem1, "barWorkspaceMenuItem1");
            this.barWorkspaceMenuItem1.Id = 8;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingNavigator
            // 
            this.mONHOCBindingNavigator.AddNewItem = null;
            this.mONHOCBindingNavigator.BackColor = System.Drawing.Color.MistyRose;
            this.mONHOCBindingNavigator.BindingSource = this.mONHOCBindingSource;
            this.mONHOCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mONHOCBindingNavigator.DeleteItem = null;
            this.mONHOCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.helpToolStripButton});
            resources.ApplyResources(this.mONHOCBindingNavigator, "mONHOCBindingNavigator");
            this.mONHOCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mONHOCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mONHOCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mONHOCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mONHOCBindingNavigator.Name = "mONHOCBindingNavigator";
            this.mONHOCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mONHOCBindingNavigator.RefreshItems += new System.EventHandler(this.mONHOCBindingNavigator_RefreshItems);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.helpToolStripButton, "helpToolStripButton");
            this.helpToolStripButton.Name = "helpToolStripButton";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            resources.ApplyResources(this.txtTenMonHoc, "txtTenMonHoc");
            this.txtTenMonHoc.MenuManager = this.barManagerMonHoc;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Properties.MaxLength = 40;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            resources.ApplyResources(this.txtMaMonHoc, "txtMaMonHoc");
            this.txtMaMonHoc.MenuManager = this.barManagerMonHoc;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Properties.MaxLength = 5;
            // 
            // picture
            // 
            resources.ApplyResources(this.picture, "picture");
            this.picture.Name = "picture";
            this.picture.TabStop = false;
            // 
            // groupBoxMonHoc
            // 
            resources.ApplyResources(this.groupBoxMonHoc, "groupBoxMonHoc");
            this.groupBoxMonHoc.Controls.Add(this.picture);
            this.groupBoxMonHoc.Controls.Add(this.txtMaMonHoc);
            this.groupBoxMonHoc.Controls.Add(tENMHLabel);
            this.groupBoxMonHoc.Controls.Add(mAMHLabel);
            this.groupBoxMonHoc.Controls.Add(this.txtTenMonHoc);
            this.groupBoxMonHoc.Name = "groupBoxMonHoc";
            this.groupBoxMonHoc.TabStop = false;
            this.groupBoxMonHoc.Enter += new System.EventHandler(this.groupBoxMonHoc_Enter);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "FK_DIEM_MONHOC1";
            this.dIEMBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(834, 500, 256, 228);
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập tên môn học cần tìm...";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTENMH, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(this.colMAMH, "colMAMH");
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            resources.ApplyResources(this.colTENMH, "colTENMH");
            // 
            // mONHOCGridControl
            // 
            resources.ApplyResources(this.mONHOCGridControl, "mONHOCGridControl");
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManagerMonHoc;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.mONHOCGridControl.Click += new System.EventHandler(this.mONHOCGridControl_Click);
            // 
            // formMonHoc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mONHOCBindingNavigator);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.groupBoxMonHoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formMonHoc";
            this.Load += new System.EventHandler(this.formMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingNavigator)).EndInit();
            this.mONHOCBindingNavigator.ResumeLayout(false);
            this.mONHOCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBoxMonHoc.ResumeLayout(false);
            this.groupBoxMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMonHoc;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnUndo;
        private DevExpress.XtraBars.BarButtonItem barBtnGhi;
        private DevExpress.XtraBars.BarButtonItem barBtnHuy;
        private DevExpress.XtraBars.BarButtonItem barBtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingNavigator mONHOCBindingNavigator;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox groupBoxMonHoc;
        private System.Windows.Forms.PictureBox picture;
        private DevExpress.XtraEditors.TextEdit txtMaMonHoc;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private QLDSVDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    }
}