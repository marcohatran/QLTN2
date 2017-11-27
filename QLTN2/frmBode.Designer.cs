namespace QLTN2
{
    partial class frmBode
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLTN2.DS();
            this.bdsBode = new System.Windows.Forms.BindingSource(this.components);
            this.taBode = new QLTN2.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.bODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cAUHOISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nOIDUNGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dAP_ANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            mAMHLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(44, 38);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 17);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "Mã môn học :";
            mAMHLabel.UseWaitCursor = true;
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(270, 38);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(60, 17);
            cAUHOILabel.TabIndex = 2;
            cAUHOILabel.Text = "Câu hỏi :";
            cAUHOILabel.UseWaitCursor = true;
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(461, 38);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(64, 17);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "Trình độ :";
            tRINHDOLabel.UseWaitCursor = true;
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(59, 68);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(68, 17);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "Nội dung :";
            nOIDUNGLabel.UseWaitCursor = true;
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(102, 97);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(25, 17);
            aLabel.TabIndex = 8;
            aLabel.Text = "A :";
            aLabel.UseWaitCursor = true;
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(498, 97);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(25, 17);
            bLabel.TabIndex = 10;
            bLabel.Text = "B :";
            bLabel.UseWaitCursor = true;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(102, 128);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(25, 17);
            cLabel.TabIndex = 12;
            cLabel.Text = "C :";
            cLabel.UseWaitCursor = true;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(498, 128);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(26, 17);
            dLabel.TabIndex = 14;
            dLabel.Text = "D :";
            dLabel.UseWaitCursor = true;
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(69, 158);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(58, 17);
            dAP_ANLabel.TabIndex = 16;
            dAP_ANLabel.Text = "Đáp án :";
            dAP_ANLabel.UseWaitCursor = true;
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(671, 38);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(91, 17);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "Mã giáo viên :";
            mAGVLabel.UseWaitCursor = true;
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
            this.btnBack,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLammoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(491, 275);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBack),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLammoi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBack
            // 
            this.btnBack.Caption = "Back";
            this.btnBack.Id = 0;
            this.btnBack.Name = "btnBack";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 2;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Caption = "Làm mới";
            this.btnLammoi.Id = 4;
            this.btnLammoi.Name = "btnLammoi";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(951, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 556);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(951, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(951, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "BODE";
            this.bdsBode.DataSource = this.DS;
            // 
            // taBode
            // 
            this.taBode.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.taBode;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODEGridControl
            // 
            this.bODEGridControl.DataSource = this.bdsBode;
            this.bODEGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bODEGridControl.Location = new System.Drawing.Point(0, 22);
            this.bODEGridControl.MainView = this.gridView1;
            this.bODEGridControl.MenuManager = this.barManager1;
            this.bODEGridControl.Name = "bODEGridControl";
            this.bODEGridControl.Size = new System.Drawing.Size(951, 214);
            this.bODEGridControl.TabIndex = 5;
            this.bODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colCAUHOI,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.bODEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 74;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.Caption = "Câu hỏi";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 1;
            this.colCAUHOI.Width = 54;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 57;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 137;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 111;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 108;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 103;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 105;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 67;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnGhi);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.mAMHTextEdit);
            this.groupBox1.Controls.Add(cAUHOILabel);
            this.groupBox1.Controls.Add(this.cAUHOISpinEdit);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(this.tRINHDOTextEdit);
            this.groupBox1.Controls.Add(nOIDUNGLabel);
            this.groupBox1.Controls.Add(this.nOIDUNGTextEdit);
            this.groupBox1.Controls.Add(aLabel);
            this.groupBox1.Controls.Add(this.aTextEdit);
            this.groupBox1.Controls.Add(bLabel);
            this.groupBox1.Controls.Add(this.bTextEdit);
            this.groupBox1.Controls.Add(cLabel);
            this.groupBox1.Controls.Add(this.cTextEdit);
            this.groupBox1.Controls.Add(dLabel);
            this.groupBox1.Controls.Add(this.dTextEdit);
            this.groupBox1.Controls.Add(dAP_ANLabel);
            this.groupBox1.Controls.Add(this.dAP_ANTextEdit);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.mAGVTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(531, 187);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 29);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseWaitCursor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(403, 187);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(74, 29);
            this.btnGhi.TabIndex = 22;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseWaitCursor = true;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(136, 35);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(117, 20);
            this.mAMHTextEdit.TabIndex = 1;
            this.mAMHTextEdit.UseWaitCursor = true;
            // 
            // cAUHOISpinEdit
            // 
            this.cAUHOISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "CAUHOI", true));
            this.cAUHOISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cAUHOISpinEdit.Location = new System.Drawing.Point(332, 35);
            this.cAUHOISpinEdit.MenuManager = this.barManager1;
            this.cAUHOISpinEdit.Name = "cAUHOISpinEdit";
            this.cAUHOISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cAUHOISpinEdit.Size = new System.Drawing.Size(124, 20);
            this.cAUHOISpinEdit.TabIndex = 3;
            this.cAUHOISpinEdit.UseWaitCursor = true;
            // 
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "TRINHDO", true));
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(531, 35);
            this.tRINHDOTextEdit.MenuManager = this.barManager1;
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(132, 20);
            this.tRINHDOTextEdit.TabIndex = 5;
            this.tRINHDOTextEdit.UseWaitCursor = true;
            // 
            // nOIDUNGTextEdit
            // 
            this.nOIDUNGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "NOIDUNG", true));
            this.nOIDUNGTextEdit.Location = new System.Drawing.Point(136, 65);
            this.nOIDUNGTextEdit.MenuManager = this.barManager1;
            this.nOIDUNGTextEdit.Name = "nOIDUNGTextEdit";
            this.nOIDUNGTextEdit.Size = new System.Drawing.Size(527, 20);
            this.nOIDUNGTextEdit.TabIndex = 7;
            this.nOIDUNGTextEdit.UseWaitCursor = true;
            // 
            // aTextEdit
            // 
            this.aTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "A", true));
            this.aTextEdit.Location = new System.Drawing.Point(136, 94);
            this.aTextEdit.MenuManager = this.barManager1;
            this.aTextEdit.Name = "aTextEdit";
            this.aTextEdit.Size = new System.Drawing.Size(341, 20);
            this.aTextEdit.TabIndex = 9;
            this.aTextEdit.UseWaitCursor = true;
            // 
            // bTextEdit
            // 
            this.bTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "B", true));
            this.bTextEdit.Location = new System.Drawing.Point(531, 94);
            this.bTextEdit.MenuManager = this.barManager1;
            this.bTextEdit.Name = "bTextEdit";
            this.bTextEdit.Size = new System.Drawing.Size(341, 20);
            this.bTextEdit.TabIndex = 11;
            this.bTextEdit.UseWaitCursor = true;
            // 
            // cTextEdit
            // 
            this.cTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "C", true));
            this.cTextEdit.Location = new System.Drawing.Point(136, 125);
            this.cTextEdit.MenuManager = this.barManager1;
            this.cTextEdit.Name = "cTextEdit";
            this.cTextEdit.Size = new System.Drawing.Size(341, 20);
            this.cTextEdit.TabIndex = 13;
            this.cTextEdit.UseWaitCursor = true;
            // 
            // dTextEdit
            // 
            this.dTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "D", true));
            this.dTextEdit.Location = new System.Drawing.Point(531, 125);
            this.dTextEdit.MenuManager = this.barManager1;
            this.dTextEdit.Name = "dTextEdit";
            this.dTextEdit.Size = new System.Drawing.Size(341, 20);
            this.dTextEdit.TabIndex = 15;
            this.dTextEdit.UseWaitCursor = true;
            // 
            // dAP_ANTextEdit
            // 
            this.dAP_ANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "DAP_AN", true));
            this.dAP_ANTextEdit.Location = new System.Drawing.Point(136, 157);
            this.dAP_ANTextEdit.MenuManager = this.barManager1;
            this.dAP_ANTextEdit.Name = "dAP_ANTextEdit";
            this.dAP_ANTextEdit.Size = new System.Drawing.Size(117, 20);
            this.dAP_ANTextEdit.TabIndex = 17;
            this.dAP_ANTextEdit.UseWaitCursor = true;
            // 
            // mAGVTextEdit
            // 
            this.mAGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBode, "MAGV", true));
            this.mAGVTextEdit.Location = new System.Drawing.Point(768, 37);
            this.mAGVTextEdit.MenuManager = this.barManager1;
            this.mAGVTextEdit.Name = "mAGVTextEdit";
            this.mAGVTextEdit.Size = new System.Drawing.Size(104, 20);
            this.mAGVTextEdit.TabIndex = 19;
            this.mAGVTextEdit.UseWaitCursor = true;
            // 
            // frmBode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bODEGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBode";
            this.Text = "frmBode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGVTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLammoi;
        private System.Windows.Forms.BindingSource bdsBode;
        private DS DS;
        private DSTableAdapters.BODETableAdapter taBode;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraEditors.SpinEdit cAUHOISpinEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.TextEdit nOIDUNGTextEdit;
        private DevExpress.XtraEditors.TextEdit aTextEdit;
        private DevExpress.XtraEditors.TextEdit bTextEdit;
        private DevExpress.XtraEditors.TextEdit cTextEdit;
        private DevExpress.XtraEditors.TextEdit dTextEdit;
        private DevExpress.XtraEditors.TextEdit dAP_ANTextEdit;
        private DevExpress.XtraEditors.TextEdit mAGVTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
    }
}