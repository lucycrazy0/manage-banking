namespace NGAN_HANG
{
    partial class frmCHUYENTIEN
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
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
            this.DS = new NGAN_HANG.DS();
            this.bdsCHUYENTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.GD_CHUYENTIENTableAdapter = new NGAN_HANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new NGAN_HANG.DSTableAdapters.TableAdapterManager();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTHONGTINGIAODICH = new DevExpress.XtraEditors.GroupControl();
            this.spMAGD = new DevExpress.XtraEditors.SpinEdit();
            this.txtSOTKCHUYEN = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYGD = new DevExpress.XtraEditors.DateEdit();
            this.spSOTIEN = new DevExpress.XtraEditors.SpinEdit();
            this.txtSOTKNHAN = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            mAGDLabel = new System.Windows.Forms.Label();
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTHONGTINGIAODICH)).BeginInit();
            this.gcTHONGTINGIAODICH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMAGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTKCHUYEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTKNHAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGDLabel
            // 
            mAGDLabel.AutoSize = true;
            mAGDLabel.Location = new System.Drawing.Point(259, 79);
            mAGDLabel.Name = "mAGDLabel";
            mAGDLabel.Size = new System.Drawing.Size(43, 13);
            mAGDLabel.TabIndex = 0;
            mAGDLabel.Text = "MÃ GD:";
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(259, 145);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(83, 13);
            sOTK_CHUYENLabel.TabIndex = 2;
            sOTK_CHUYENLabel.Text = "SỐ TK CHUYỂN:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Location = new System.Drawing.Point(259, 211);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(55, 13);
            nGAYGDLabel.TabIndex = 4;
            nGAYGDLabel.Text = "NGÀY GD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Location = new System.Drawing.Point(664, 79);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(51, 13);
            sOTIENLabel.TabIndex = 6;
            sOTIENLabel.Text = "SỐ TIỀN:";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(664, 145);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(71, 13);
            sOTK_NHANLabel.TabIndex = 8;
            sOTK_NHANLabel.Text = "SỐ TK NHẬN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(664, 211);
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
            this.bar2.FloatLocation = new System.Drawing.Point(353, 167);
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
            this.btnGHI.Caption = "GHI";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1108, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Size = new System.Drawing.Size(1108, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 558);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1108, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 558);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCHUYENTIEN
            // 
            this.bdsCHUYENTIEN.DataMember = "GD_CHUYENTIEN";
            this.bdsCHUYENTIEN.DataSource = this.DS;
            // 
            // GD_CHUYENTIENTableAdapter
            // 
            this.GD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.GD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGAN_HANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.bdsCHUYENTIEN;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(0, 40);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(1108, 220);
            this.gD_CHUYENTIENGridControl.TabIndex = 5;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGD,
            this.SOTK_CHUYEN,
            this.NGAYGD,
            this.SOTIEN,
            this.SOTK_NHAN,
            this.MANV});
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
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
            // SOTK_CHUYEN
            // 
            this.SOTK_CHUYEN.Caption = "SỐ TK CHUYỂN";
            this.SOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.SOTK_CHUYEN.Name = "SOTK_CHUYEN";
            this.SOTK_CHUYEN.Visible = true;
            this.SOTK_CHUYEN.VisibleIndex = 1;
            // 
            // NGAYGD
            // 
            this.NGAYGD.Caption = "NGÀY GD";
            this.NGAYGD.FieldName = "NGAYGD";
            this.NGAYGD.Name = "NGAYGD";
            this.NGAYGD.Visible = true;
            this.NGAYGD.VisibleIndex = 2;
            // 
            // SOTIEN
            // 
            this.SOTIEN.Caption = "SỐ TIỀN";
            this.SOTIEN.FieldName = "SOTIEN";
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Visible = true;
            this.SOTIEN.VisibleIndex = 3;
            // 
            // SOTK_NHAN
            // 
            this.SOTK_NHAN.Caption = "SỐ TK NHẬN";
            this.SOTK_NHAN.FieldName = "SOTK_NHAN";
            this.SOTK_NHAN.Name = "SOTK_NHAN";
            this.SOTK_NHAN.Visible = true;
            this.SOTK_NHAN.VisibleIndex = 4;
            // 
            // MANV
            // 
            this.MANV.Caption = "MÃ NV";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 5;
            // 
            // gcTHONGTINGIAODICH
            // 
            this.gcTHONGTINGIAODICH.Controls.Add(mAGDLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.spMAGD);
            this.gcTHONGTINGIAODICH.Controls.Add(sOTK_CHUYENLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.txtSOTKCHUYEN);
            this.gcTHONGTINGIAODICH.Controls.Add(nGAYGDLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.dateNGAYGD);
            this.gcTHONGTINGIAODICH.Controls.Add(sOTIENLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.spSOTIEN);
            this.gcTHONGTINGIAODICH.Controls.Add(sOTK_NHANLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.txtSOTKNHAN);
            this.gcTHONGTINGIAODICH.Controls.Add(mANVLabel);
            this.gcTHONGTINGIAODICH.Controls.Add(this.txtMANV);
            this.gcTHONGTINGIAODICH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTHONGTINGIAODICH.Location = new System.Drawing.Point(0, 260);
            this.gcTHONGTINGIAODICH.Name = "gcTHONGTINGIAODICH";
            this.gcTHONGTINGIAODICH.Size = new System.Drawing.Size(1108, 338);
            this.gcTHONGTINGIAODICH.TabIndex = 6;
            this.gcTHONGTINGIAODICH.Text = "Thông tin giao dịch";
            // 
            // spMAGD
            // 
            this.spMAGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "MAGD", true));
            this.spMAGD.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spMAGD.Location = new System.Drawing.Point(345, 76);
            this.spMAGD.MenuManager = this.barManager1;
            this.spMAGD.Name = "spMAGD";
            this.spMAGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spMAGD.Size = new System.Drawing.Size(100, 20);
            this.spMAGD.TabIndex = 1;
            // 
            // txtSOTKCHUYEN
            // 
            this.txtSOTKCHUYEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "SOTK_CHUYEN", true));
            this.txtSOTKCHUYEN.Location = new System.Drawing.Point(345, 142);
            this.txtSOTKCHUYEN.MenuManager = this.barManager1;
            this.txtSOTKCHUYEN.Name = "txtSOTKCHUYEN";
            this.txtSOTKCHUYEN.Size = new System.Drawing.Size(100, 20);
            this.txtSOTKCHUYEN.TabIndex = 3;
            // 
            // dateNGAYGD
            // 
            this.dateNGAYGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "NGAYGD", true));
            this.dateNGAYGD.EditValue = null;
            this.dateNGAYGD.Location = new System.Drawing.Point(345, 208);
            this.dateNGAYGD.MenuManager = this.barManager1;
            this.dateNGAYGD.Name = "dateNGAYGD";
            this.dateNGAYGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYGD.Size = new System.Drawing.Size(100, 20);
            this.dateNGAYGD.TabIndex = 5;
            // 
            // spSOTIEN
            // 
            this.spSOTIEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "SOTIEN", true));
            this.spSOTIEN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSOTIEN.Location = new System.Drawing.Point(750, 76);
            this.spSOTIEN.MenuManager = this.barManager1;
            this.spSOTIEN.Name = "spSOTIEN";
            this.spSOTIEN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSOTIEN.Size = new System.Drawing.Size(100, 20);
            this.spSOTIEN.TabIndex = 7;
            // 
            // txtSOTKNHAN
            // 
            this.txtSOTKNHAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "SOTK_NHAN", true));
            this.txtSOTKNHAN.Location = new System.Drawing.Point(750, 142);
            this.txtSOTKNHAN.MenuManager = this.barManager1;
            this.txtSOTKNHAN.Name = "txtSOTKNHAN";
            this.txtSOTKNHAN.Size = new System.Drawing.Size(100, 20);
            this.txtSOTKNHAN.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCHUYENTIEN, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(750, 208);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 11;
            // 
            // frmCHUYENTIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 598);
            this.Controls.Add(this.gcTHONGTINGIAODICH);
            this.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCHUYENTIEN";
            this.Text = "Chuyển Tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCHUYENTIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTHONGTINGIAODICH)).EndInit();
            this.gcTHONGTINGIAODICH.ResumeLayout(false);
            this.gcTHONGTINGIAODICH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMAGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTKCHUYEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTKNHAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnPHUCHOI;
        private DevExpress.XtraBars.BarButtonItem btnRELOAD;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private System.Windows.Forms.BindingSource bdsCHUYENTIEN;
        private DS DS;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter GD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcTHONGTINGIAODICH;
        private DevExpress.XtraEditors.SpinEdit spMAGD;
        private DevExpress.XtraEditors.TextEdit txtSOTKCHUYEN;
        private DevExpress.XtraEditors.DateEdit dateNGAYGD;
        private DevExpress.XtraEditors.SpinEdit spSOTIEN;
        private DevExpress.XtraEditors.TextEdit txtSOTKNHAN;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAGD;
        private DevExpress.XtraGrid.Columns.GridColumn SOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
    }
}