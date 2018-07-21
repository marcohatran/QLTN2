namespace QLTN2
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.s = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.dS = new QLTN2.DS();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.taSinhVien = new QLTN2.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gvSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.taBangDiem = new QLTN2.DSTableAdapters.BANGDIEMTableAdapter();
            this.taLop = new QLTN2.DSTableAdapters.LOPTableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.mASVLabel = new System.Windows.Forms.Label();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.hOLabel = new System.Windows.Forms.Label();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.tENLabel = new System.Windows.Forms.Label();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.nGAYSINHLabel = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            this.gbSinhVien.SuspendLayout();
            this.SuspendLayout();
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
            this.btnThem,
            this.btnHieuChinh,
            this.btnUndo,
            this.btnReload,
            this.s,
            this.btnXoa,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 7;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "ReLoad";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // s
            // 
            this.s.Caption = "Thoát";
            this.s.Id = 6;
            this.s.Name = "s";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 56);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(137, 14);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(318, 28);
            this.cmbCoSo.TabIndex = 0;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.dS;
            // 
            // taSinhVien
            // 
            this.taSinhVien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.taSinhVien;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.bdsSinhVien;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "Level1";
            this.gcSinhVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSinhVien.Location = new System.Drawing.Point(0, 106);
            this.gcSinhVien.MainView = this.gvSinhVien;
            this.gcSinhVien.MenuManager = this.barManager1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1084, 185);
            this.gcSinhVien.TabIndex = 6;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinhVien});
            // 
            // gvSinhVien
            // 
            this.gvSinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gvSinhVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvSinhVien.GridControl = this.gcSinhVien;
            this.gvSinhVien.Name = "gvSinhVien";
            this.gvSinhVien.OptionsBehavior.Editable = false;
            this.gvSinhVien.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.gvSinhVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // taBangDiem
            // 
            this.taBangDiem.ClearBeforeFill = true;
            // 
            // taLop
            // 
            this.taLop.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK__BANGDIEM__MASV__71D1E811";
            this.bdsBangDiem.DataSource = this.bdsSinhVien;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(274, 26);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.MaxLength = 8;
            this.txtMaSV.Size = new System.Drawing.Size(277, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // mASVLabel
            // 
            this.mASVLabel.AutoSize = true;
            this.mASVLabel.Location = new System.Drawing.Point(177, 29);
            this.mASVLabel.Name = "mASVLabel";
            this.mASVLabel.Size = new System.Drawing.Size(66, 21);
            this.mASVLabel.TabIndex = 0;
            this.mASVLabel.Text = "MASV:";
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(274, 64);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(277, 22);
            this.txtHo.TabIndex = 3;
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(178, 67);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(41, 21);
            this.hOLabel.TabIndex = 2;
            this.hOLabel.Text = "HO:";
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(669, 64);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(277, 22);
            this.txtTen.TabIndex = 5;
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(603, 65);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(50, 21);
            this.tENLabel.TabIndex = 4;
            this.tENLabel.Text = "TEN:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "NGAYSINH", true));
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(273, 104);
            this.txtNgaySinh.MenuManager = this.barManager1;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(277, 22);
            this.txtNgaySinh.TabIndex = 7;
            // 
            // nGAYSINHLabel
            // 
            this.nGAYSINHLabel.AutoSize = true;
            this.nGAYSINHLabel.Location = new System.Drawing.Point(177, 105);
            this.nGAYSINHLabel.Name = "nGAYSINHLabel";
            this.nGAYSINHLabel.Size = new System.Drawing.Size(108, 21);
            this.nGAYSINHLabel.TabIndex = 6;
            this.nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSinhVien, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(669, 104);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(277, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Location = new System.Drawing.Point(593, 107);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(78, 21);
            this.dIACHILabel.TabIndex = 8;
            this.dIACHILabel.Text = "DIACHI:";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(459, 156);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(93, 30);
            this.btnGhi.TabIndex = 12;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(620, 156);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 30);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSinhVien, "MALOP", true));
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(671, 21);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(277, 28);
            this.cmbMaLop.TabIndex = 16;
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.AutoSize = true;
            this.mALOPLabel.Location = new System.Drawing.Point(592, 27);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(79, 21);
            this.mALOPLabel.TabIndex = 15;
            this.mALOPLabel.Text = "MALOP:";
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.Controls.Add(this.mALOPLabel);
            this.gbSinhVien.Controls.Add(this.cmbMaLop);
            this.gbSinhVien.Controls.Add(this.btnHuy);
            this.gbSinhVien.Controls.Add(this.btnGhi);
            this.gbSinhVien.Controls.Add(this.dIACHILabel);
            this.gbSinhVien.Controls.Add(this.txtDiaChi);
            this.gbSinhVien.Controls.Add(this.nGAYSINHLabel);
            this.gbSinhVien.Controls.Add(this.txtNgaySinh);
            this.gbSinhVien.Controls.Add(this.tENLabel);
            this.gbSinhVien.Controls.Add(this.txtTen);
            this.gbSinhVien.Controls.Add(this.hOLabel);
            this.gbSinhVien.Controls.Add(this.txtHo);
            this.gbSinhVien.Controls.Add(this.mASVLabel);
            this.gbSinhVien.Controls.Add(this.txtMaSV);
            this.gbSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSinhVien.Location = new System.Drawing.Point(0, 291);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1084, 180);
            this.gbSinhVien.TabIndex = 7;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Thông tin";
            this.gbSinhVien.Enter += new System.EventHandler(this.gbSinhVien_Enter);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 471);
            this.Controls.Add(this.gbSinhVien);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
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
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DS dS;
        private DSTableAdapters.SINHVIENTableAdapter taSinhVien;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinhVien;
        private DSTableAdapters.BANGDIEMTableAdapter taBangDiem;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter taLop;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem s;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private System.Windows.Forms.Label mALOPLabel;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Label dIACHILabel;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.Label nGAYSINHLabel;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private System.Windows.Forms.Label tENLabel;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.Label hOLabel;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private System.Windows.Forms.Label mASVLabel;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
    }
}