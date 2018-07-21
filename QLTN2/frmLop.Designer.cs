namespace QLTN2
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.mAKHLabel = new System.Windows.Forms.Label();
            this.tENLOPLabel = new System.Windows.Forms.Label();
            this.mALOPLabel = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.DS = new QLTN2.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.taLop = new QLTN2.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.taGVDK = new QLTN2.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.taKhoa = new QLTN2.DSTableAdapters.KHOATableAdapter();
            this.gbLop = new System.Windows.Forms.GroupBox();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            this.gbLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            this.mAKHLabel.AutoSize = true;
            this.mAKHLabel.Location = new System.Drawing.Point(224, 127);
            this.mAKHLabel.Name = "mAKHLabel";
            this.mAKHLabel.Size = new System.Drawing.Size(69, 21);
            this.mAKHLabel.TabIndex = 19;
            this.mAKHLabel.Text = "MAKH:";
            // 
            // tENLOPLabel
            // 
            this.tENLOPLabel.AutoSize = true;
            this.tENLOPLabel.Location = new System.Drawing.Point(224, 78);
            this.tENLOPLabel.Name = "tENLOPLabel";
            this.tENLOPLabel.Size = new System.Drawing.Size(86, 21);
            this.tENLOPLabel.TabIndex = 17;
            this.tENLOPLabel.Text = "TENLOP:";
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.AutoSize = true;
            this.mALOPLabel.Location = new System.Drawing.Point(224, 31);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(79, 21);
            this.mALOPLabel.TabIndex = 16;
            this.mALOPLabel.Text = "MALOP:";
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
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnThoat,
            this.btnHieuChinh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 6;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 2;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1124, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 556);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1124, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1124, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(176, 11);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(356, 28);
            this.cmbCoSo.TabIndex = 0;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // taLop
            // 
            this.taLop.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.taLop;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.RelationName = "FK__GIAOVIEN___MALOP__5FB337D6";
            gridLevelNode3.RelationName = "FK__BANGDIEM__MASV__1A89E4E1";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "FK__SINHVIEN__MALOP__5629CD9C";
            gridLevelNode4.RelationName = "Level1";
            this.gcLop.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode4});
            this.gcLop.Location = new System.Drawing.Point(0, 96);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1124, 415);
            this.gcLop.TabIndex = 6;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gvLop.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.Editable = false;
            this.gvLop.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.gvLop.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK__GIAOVIEN___MALOP__5FB337D6";
            this.bdsGVDK.DataSource = this.bdsLop;
            // 
            // taGVDK
            // 
            this.taGVDK.ClearBeforeFill = true;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // taKhoa
            // 
            this.taKhoa.ClearBeforeFill = true;
            // 
            // gbLop
            // 
            this.gbLop.Controls.Add(this.btnGhi);
            this.gbLop.Controls.Add(this.btnHuy);
            this.gbLop.Controls.Add(this.mAKHLabel);
            this.gbLop.Controls.Add(this.cmbMaKH);
            this.gbLop.Controls.Add(this.tENLOPLabel);
            this.gbLop.Controls.Add(this.txtTenLop);
            this.gbLop.Controls.Add(this.mALOPLabel);
            this.gbLop.Controls.Add(this.txtMaLop);
            this.gbLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbLop.Enabled = false;
            this.gbLop.Location = new System.Drawing.Point(0, 336);
            this.gbLop.Name = "gbLop";
            this.gbLop.Size = new System.Drawing.Size(1124, 220);
            this.gbLop.TabIndex = 20;
            this.gbLop.TabStop = false;
            this.gbLop.Text = "Thông tin";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(381, 171);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(91, 31);
            this.btnGhi.TabIndex = 23;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(561, 171);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 31);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKH", true));
            this.cmbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(360, 124);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(319, 28);
            this.cmbMaKH.TabIndex = 21;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(360, 75);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(319, 22);
            this.txtTenLop.TabIndex = 20;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(360, 28);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.MaxLength = 8;
            this.txtMaLop.Size = new System.Drawing.Size(319, 22);
            this.txtMaLop.TabIndex = 18;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 556);
            this.Controls.Add(this.gbLop);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            this.gbLop.ResumeLayout(false);
            this.gbLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter taLop;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter taGVDK;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter taKhoa;
        private System.Windows.Forms.GroupBox gbLop;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.Label mAKHLabel;
        private System.Windows.Forms.Label tENLOPLabel;
        private System.Windows.Forms.Label mALOPLabel;
    }
}