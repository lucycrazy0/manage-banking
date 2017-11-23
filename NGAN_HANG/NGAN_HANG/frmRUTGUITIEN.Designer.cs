namespace NGAN_HANG
{
    partial class frmRUTTIEN
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
            System.Windows.Forms.Label mAGDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnPHUCHOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnRELOAD = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new NGAN_HANG.DS();
            this.bdsGDGUIRUTTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.GD_GOIRUTTableAdapter = new NGAN_HANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NGAN_HANG.DSTableAdapters.TableAdapterManager();
            this.gcGDGOIRUTTIEN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmbLOAIGD = new System.Windows.Forms.ComboBox();
            this.txtMAGD = new System.Windows.Forms.TextBox();
            this.txtSOTK = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYGD = new DevExpress.XtraEditors.DateEdit();
            this.txtSOTIEN = new DevExpress.XtraEditors.SpinEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            mAGDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDGUIRUTTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGDGOIRUTTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGDLabel
            // 
            mAGDLabel.AutoSize = true;
            mAGDLabel.Location = new System.Drawing.Point(280, 57);
            mAGDLabel.Name = "mAGDLabel";
            mAGDLabel.Size = new System.Drawing.Size(43, 13);
            mAGDLabel.TabIndex = 0;
            mAGDLabel.Text = "MÃ GD:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(280, 127);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(40, 13);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "SỐ TK:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Location = new System.Drawing.Point(283, 201);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(52, 13);
            lOAIGDLabel.TabIndex = 4;
            lOAIGDLabel.Text = "LOẠI GD:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(510, 197);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(55, 13);
            nGAYGDLabel.TabIndex = 6;
            nGAYGDLabel.Text = "NGÀY GD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(510, 127);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(51, 13);
            sOTIENLabel.TabIndex = 8;
            sOTIENLabel.Text = "SỐ TIỀN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(510, 57);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(42, 13);
            mANVLabel.TabIndex = 10;
            mANVLabel.Text = "MÃ NV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnSUA,
            this.btnGHI,
            this.btnXOA,
            this.btnPHUCHOI,
            this.btnRELOAD,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(269, 162);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSUA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPHUCHOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRELOAD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "THÊM";
            this.btnTHEM.Glyph = global::NGAN_HANG.Properties.Resources.bank_account1;
            this.btnTHEM.Id = 0;
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "HIỆU CHỈNH";
            this.btnSUA.Glyph = global::NGAN_HANG.Properties.Resources.toolbox;
            this.btnSUA.Id = 1;
            this.btnSUA.Name = "btnSUA";
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "GHI ";
            this.btnGHI.Glyph = global::NGAN_HANG.Properties.Resources.diskette;
            this.btnGHI.Id = 2;
            this.btnGHI.Name = "btnGHI";
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "XÓA";
            this.btnXOA.Glyph = global::NGAN_HANG.Properties.Resources.rubbish;
            this.btnXOA.Id = 3;
            this.btnXOA.Name = "btnXOA";
            // 
            // btnPHUCHOI
            // 
            this.btnPHUCHOI.Caption = "PHỤC HỒI";
            this.btnPHUCHOI.Glyph = global::NGAN_HANG.Properties.Resources.undo;
            this.btnPHUCHOI.Id = 4;
            this.btnPHUCHOI.Name = "btnPHUCHOI";
            // 
            // btnRELOAD
            // 
            this.btnRELOAD.Caption = "RELOAD";
            this.btnRELOAD.Glyph = global::NGAN_HANG.Properties.Resources.refresh;
            this.btnRELOAD.Id = 5;
            this.btnRELOAD.Name = "btnRELOAD";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "THOÁT";
            this.btnTHOAT.Glyph = global::NGAN_HANG.Properties.Resources.door;
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.Name = "btnTHOAT";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(953, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 616);
            this.barDockControlBottom.Size = new System.Drawing.Size(953, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 576);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(953, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 576);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbChiNhanh);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(953, 93);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chọn chi nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(116, 42);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(243, 21);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGDGUIRUTTIEN
            // 
            this.bdsGDGUIRUTTIEN.DataMember = "GD_GOIRUT";
            this.bdsGDGUIRUTTIEN.DataSource = this.DS;
            // 
            // GD_GOIRUTTableAdapter
            // 
            this.GD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.GD_GOIRUTTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGAN_HANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGDGOIRUTTIEN
            // 
            this.gcGDGOIRUTTIEN.DataSource = this.bdsGDGUIRUTTIEN;
            this.gcGDGOIRUTTIEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGDGOIRUTTIEN.Location = new System.Drawing.Point(0, 133);
            this.gcGDGOIRUTTIEN.MainView = this.gridView1;
            this.gcGDGOIRUTTIEN.MenuManager = this.barManager1;
            this.gcGDGOIRUTTIEN.Name = "gcGDGOIRUTTIEN";
            this.gcGDGOIRUTTIEN.Size = new System.Drawing.Size(953, 220);
            this.gcGDGOIRUTTIEN.TabIndex = 9;
            this.gcGDGOIRUTTIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGDGOIRUTTIEN.Click += new System.EventHandler(this.gD_GOIRUTGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGD,
            this.SOTK,
            this.LOAIGD,
            this.NGAYGD,
            this.SOTIEN,
            this.MANV});
            this.gridView1.GridControl = this.gcGDGOIRUTTIEN;
            this.gridView1.Name = "gridView1";
            // 
            // MAGD
            // 
            this.MAGD.Caption = "MÃ GD";
            this.MAGD.FieldName = "MAGD";
            this.MAGD.Name = "MAGD";
            this.MAGD.Visible = true;
            this.MAGD.VisibleIndex = 0;
            // 
            // SOTK
            // 
            this.SOTK.Caption = "SỐ TK";
            this.SOTK.FieldName = "SOTK";
            this.SOTK.Name = "SOTK";
            this.SOTK.Visible = true;
            this.SOTK.VisibleIndex = 1;
            // 
            // LOAIGD
            // 
            this.LOAIGD.Caption = "LOẠI GD";
            this.LOAIGD.FieldName = "LOAIGD";
            this.LOAIGD.Name = "LOAIGD";
            this.LOAIGD.Visible = true;
            this.LOAIGD.VisibleIndex = 2;
            // 
            // NGAYGD
            // 
            this.NGAYGD.Caption = "NGÀY GD";
            this.NGAYGD.FieldName = "NGAYGD";
            this.NGAYGD.Name = "NGAYGD";
            this.NGAYGD.Visible = true;
            this.NGAYGD.VisibleIndex = 3;
            // 
            // SOTIEN
            // 
            this.SOTIEN.Caption = "SỐ TIỀN";
            this.SOTIEN.FieldName = "SOTIEN";
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Visible = true;
            this.SOTIEN.VisibleIndex = 4;
            // 
            // MANV
            // 
            this.MANV.Caption = "MÃ NV";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cmbLOAIGD);
            this.groupControl2.Controls.Add(this.txtMAGD);
            this.groupControl2.Controls.Add(mAGDLabel);
            this.groupControl2.Controls.Add(sOTKLabel);
            this.groupControl2.Controls.Add(this.txtSOTK);
            this.groupControl2.Controls.Add(lOAIGDLabel);
            this.groupControl2.Controls.Add(nGAYGDLabel);
            this.groupControl2.Controls.Add(this.dateNGAYGD);
            this.groupControl2.Controls.Add(sOTIENLabel);
            this.groupControl2.Controls.Add(this.txtSOTIEN);
            this.groupControl2.Controls.Add(mANVLabel);
            this.groupControl2.Controls.Add(this.txtMANV);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 353);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(953, 263);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Thông tin giao dịch";
            // 
            // cmbLOAIGD
            // 
            this.cmbLOAIGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGDGUIRUTTIEN, "LOAIGD", true));
            this.cmbLOAIGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLOAIGD.FormattingEnabled = true;
            this.cmbLOAIGD.Items.AddRange(new object[] {
            "GT",
            "RT"});
            this.cmbLOAIGD.Location = new System.Drawing.Point(338, 194);
            this.cmbLOAIGD.Name = "cmbLOAIGD";
            this.cmbLOAIGD.Size = new System.Drawing.Size(100, 21);
            this.cmbLOAIGD.TabIndex = 13;
            // 
            // txtMAGD
            // 
            this.txtMAGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGDGUIRUTTIEN, "MAGD", true));
            this.txtMAGD.Location = new System.Drawing.Point(338, 54);
            this.txtMAGD.Name = "txtMAGD";
            this.txtMAGD.Size = new System.Drawing.Size(100, 21);
            this.txtMAGD.TabIndex = 12;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGUIRUTTIEN, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(338, 124);
            this.txtSOTK.MenuManager = this.barManager1;
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(100, 20);
            this.txtSOTK.TabIndex = 3;
            // 
            // dateNGAYGD
            // 
            this.dateNGAYGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGUIRUTTIEN, "NGAYGD", true));
            this.dateNGAYGD.EditValue = null;
            this.dateNGAYGD.Location = new System.Drawing.Point(572, 194);
            this.dateNGAYGD.MenuManager = this.barManager1;
            this.dateNGAYGD.Name = "dateNGAYGD";
            this.dateNGAYGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYGD.Size = new System.Drawing.Size(100, 20);
            this.dateNGAYGD.TabIndex = 7;
            // 
            // txtSOTIEN
            // 
            this.txtSOTIEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGUIRUTTIEN, "SOTIEN", true));
            this.txtSOTIEN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSOTIEN.Location = new System.Drawing.Point(572, 124);
            this.txtSOTIEN.MenuManager = this.barManager1;
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOTIEN.Size = new System.Drawing.Size(100, 20);
            this.txtSOTIEN.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGDGUIRUTTIEN, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(572, 54);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 11;
            // 
            // frmRUTTIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 616);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcGDGOIRUTTIEN);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRUTTIEN";
            this.Text = "Rút - Gửi Tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRUTGUITIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGDGUIRUTTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGDGOIRUTTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnPHUCHOI;
        private DevExpress.XtraBars.BarButtonItem btnRELOAD;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bdsGDGUIRUTTIEN;
        private DS DS;
        private DSTableAdapters.GD_GOIRUTTableAdapter GD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtSOTK;
        private DevExpress.XtraEditors.DateEdit dateNGAYGD;
        private DevExpress.XtraEditors.SpinEdit txtSOTIEN;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraGrid.GridControl gcGDGOIRUTTIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAGD;
        private DevExpress.XtraGrid.Columns.GridColumn SOTK;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAGD;
        private System.Windows.Forms.ComboBox cmbLOAIGD;
    }
}