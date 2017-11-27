namespace QLTN2
{
    partial class frmGV
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHLabel;
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
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.taGV = new QLTN2.DSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.taBode = new QLTN2.DSTableAdapters.BODETableAdapter();
            this.taGVDK = new QLTN2.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBode = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMAKH = new System.Windows.Forms.ComboBox();
            this.txtHV = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.taKhoa = new QLTN2.DSTableAdapters.KHOATableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(219, 49);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(91, 17);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giáo viên :";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(219, 94);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(89, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ giáo viên :";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(577, 94);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(94, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên giáo viên :";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(219, 139);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(54, 17);
            hOCVILabel.TabIndex = 6;
            hOCVILabel.Text = "Học vị :";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(577, 139);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(67, 17);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "Mã khoa :";
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
            this.btnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBack_ItemClick);
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
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Caption = "Làm mới";
            this.btnLammoi.Id = 4;
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1180, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 628);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1180, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1180, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIAOVIEN";
            this.bdsGV.DataSource = this.DS;
            // 
            // taGV
            // 
            this.taGV.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.taBode;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.taGVDK;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.taGV;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taBode
            // 
            this.taBode.ClearBeforeFill = true;
            // 
            // taGVDK
            // 
            this.taGVDK.ClearBeforeFill = true;
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.DataSource = this.bdsGV;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(0, 22);
            this.gIAOVIENGridControl.MainView = this.gridView1;
            this.gIAOVIENGridControl.MenuManager = this.barManager1;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(1180, 220);
            this.gIAOVIENGridControl.TabIndex = 5;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGV,
            this.HO,
            this.TEN,
            this.HOCVI,
            this.MAKH});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gIAOVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // MAGV
            // 
            this.MAGV.Caption = "Mã giáo viên";
            this.MAGV.FieldName = "MAGV";
            this.MAGV.Name = "MAGV";
            this.MAGV.Visible = true;
            this.MAGV.VisibleIndex = 0;
            // 
            // HO
            // 
            this.HO.Caption = "Họ";
            this.HO.FieldName = "HO";
            this.HO.Name = "HO";
            this.HO.Visible = true;
            this.HO.VisibleIndex = 1;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 2;
            // 
            // HOCVI
            // 
            this.HOCVI.Caption = "Học vị";
            this.HOCVI.FieldName = "HOCVI";
            this.HOCVI.Name = "HOCVI";
            this.HOCVI.Visible = true;
            this.HOCVI.VisibleIndex = 3;
            // 
            // MAKH
            // 
            this.MAKH.Caption = "Mã khoa";
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 4;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK__GIAOVIEN_D__MAGV__5EBF139D";
            this.bdsGVDK.DataSource = this.bdsGV;
            // 
            // bdsBode
            // 
            this.bdsBode.DataMember = "FK__BODE__MAGV__32AB8735";
            this.bdsBode.DataSource = this.bdsGV;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.cmbMAKH);
            this.groupBox1.Controls.Add(hOCVILabel);
            this.groupBox1.Controls.Add(this.txtHV);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.txtMAGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(612, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(157, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(359, 202);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(157, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Ghi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbMAKH
            // 
            this.cmbMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKH", true));
            this.cmbMAKH.FormattingEnabled = true;
            this.cmbMAKH.Location = new System.Drawing.Point(679, 131);
            this.cmbMAKH.Name = "cmbMAKH";
            this.cmbMAKH.Size = new System.Drawing.Size(253, 25);
            this.cmbMAKH.TabIndex = 9;
            // 
            // txtHV
            // 
            this.txtHV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCVI", true));
            this.txtHV.Location = new System.Drawing.Point(316, 132);
            this.txtHV.MenuManager = this.barManager1;
            this.txtHV.Name = "txtHV";
            this.txtHV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHV.Properties.Appearance.Options.UseFont = true;
            this.txtHV.Size = new System.Drawing.Size(246, 24);
            this.txtHV.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(679, 87);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(253, 24);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(316, 87);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(246, 24);
            this.txtHo.TabIndex = 3;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(316, 42);
            this.txtMAGV.MenuManager = this.barManager1;
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Size = new System.Drawing.Size(246, 24);
            this.txtMAGV.TabIndex = 1;
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
            // frmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gIAOVIENGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGV";
            this.Text = "fromGV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fromGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsGV;
        private DS DS;
        private DSTableAdapters.GIAOVIENTableAdapter taGV;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAGV;
        private DevExpress.XtraGrid.Columns.GridColumn HO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn HOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter taGVDK;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.BODETableAdapter taBode;
        private System.Windows.Forms.BindingSource bdsBode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMAKH;
        private DevExpress.XtraEditors.TextEdit txtHV;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLammoi;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter taKhoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}