namespace QLTN2
{
    partial class frmThi
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.DS = new QLTN2.DS();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.taGVDK = new QLTN2.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNop = new DevExpress.XtraEditors.SimpleButton();
            this.lbTGThi = new System.Windows.Forms.Label();
            this.btnThi = new DevExpress.XtraEditors.SimpleButton();
            this.lbMALOP = new System.Windows.Forms.Label();
            this.lbTENLOP = new System.Windows.Forms.Label();
            this.lbLan = new System.Windows.Forms.Label();
            this.cmbMAMH = new System.Windows.Forms.ComboBox();
            this.lbNT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bdsBaithi = new System.Windows.Forms.BindingSource(this.components);
            this.taBaithi = new QLTN2.DSTableAdapters.BAITHITableAdapter();
            this.bAITHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUTRALOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsBangdiem = new System.Windows.Forms.BindingSource(this.components);
            this.taBangdiem = new QLTN2.DSTableAdapters.BANGDIEMTableAdapter();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.lbSocau = new System.Windows.Forms.Label();
            this.lbND = new System.Windows.Forms.Label();
            this.btnDi = new DevExpress.XtraEditors.SimpleButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.spnCau = new DevExpress.XtraEditors.SpinEdit();
            this.C = new System.Windows.Forms.RadioButton();
            this.btnCuoi = new DevExpress.XtraEditors.SimpleButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.btnDau = new DevExpress.XtraEditors.SimpleButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaithi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCau.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(8, 112);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(93, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "Chọn môn học";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.DS;
            // 
            // taGVDK
            // 
            this.taGVDK.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.taGVDK;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnThi);
            this.groupBox1.Controls.Add(this.lbMALOP);
            this.groupBox1.Controls.Add(this.lbTENLOP);
            this.groupBox1.Controls.Add(this.lbLan);
            this.groupBox1.Controls.Add(this.cmbMAMH);
            this.groupBox1.Controls.Add(this.lbNT);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(673, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNop);
            this.groupBox2.Controls.Add(this.lbTGThi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 241);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(61, 156);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(147, 23);
            this.btnNop.TabIndex = 9;
            this.btnNop.Text = "Nộp bài";
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // lbTGThi
            // 
            this.lbTGThi.AutoSize = true;
            this.lbTGThi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGThi.Location = new System.Drawing.Point(79, 68);
            this.lbTGThi.Name = "lbTGThi";
            this.lbTGThi.Size = new System.Drawing.Size(115, 27);
            this.lbTGThi.TabIndex = 0;
            this.lbTGThi.Text = "Thời gian :";
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(64, 217);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(147, 23);
            this.btnThi.TabIndex = 8;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // lbMALOP
            // 
            this.lbMALOP.AutoSize = true;
            this.lbMALOP.Location = new System.Drawing.Point(51, 50);
            this.lbMALOP.Name = "lbMALOP";
            this.lbMALOP.Size = new System.Drawing.Size(50, 17);
            this.lbMALOP.TabIndex = 7;
            this.lbMALOP.Text = "Mã lớp";
            // 
            // lbTENLOP
            // 
            this.lbTENLOP.AutoSize = true;
            this.lbTENLOP.Location = new System.Drawing.Point(48, 81);
            this.lbTENLOP.Name = "lbTENLOP";
            this.lbTENLOP.Size = new System.Drawing.Size(53, 17);
            this.lbTENLOP.TabIndex = 6;
            this.lbTENLOP.Text = "Tên lớp";
            // 
            // lbLan
            // 
            this.lbLan.AutoSize = true;
            this.lbLan.Location = new System.Drawing.Point(70, 174);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(31, 17);
            this.lbLan.TabIndex = 5;
            this.lbLan.Text = "Lần";
            // 
            // cmbMAMH
            // 
            this.cmbMAMH.FormattingEnabled = true;
            this.cmbMAMH.Location = new System.Drawing.Point(107, 105);
            this.cmbMAMH.Name = "cmbMAMH";
            this.cmbMAMH.Size = new System.Drawing.Size(147, 25);
            this.cmbMAMH.TabIndex = 3;
            this.cmbMAMH.SelectedIndexChanged += new System.EventHandler(this.cmbMAMH_SelectedIndexChanged);
            // 
            // lbNT
            // 
            this.lbNT.AutoSize = true;
            this.lbNT.Location = new System.Drawing.Point(43, 143);
            this.lbNT.Name = "lbNT";
            this.lbNT.Size = new System.Drawing.Size(58, 17);
            this.lbNT.TabIndex = 4;
            this.lbNT.Text = "Ngày thi";
            // 
            // bdsBaithi
            // 
            this.bdsBaithi.DataMember = "BAITHI";
            this.bdsBaithi.DataSource = this.DS;
            // 
            // taBaithi
            // 
            this.taBaithi.ClearBeforeFill = true;
            // 
            // bAITHIGridControl
            // 
            this.bAITHIGridControl.DataSource = this.bdsBaithi;
            this.bAITHIGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAITHIGridControl.Location = new System.Drawing.Point(0, 0);
            this.bAITHIGridControl.MainView = this.gridView1;
            this.bAITHIGridControl.Name = "bAITHIGridControl";
            this.bAITHIGridControl.Size = new System.Drawing.Size(158, 525);
            this.bAITHIGridControl.TabIndex = 1;
            this.bAITHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cau,
            this.colCAUTRALOI});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.bAITHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // Cau
            // 
            this.Cau.Caption = "Câu";
            this.Cau.FieldName = "Cau";
            this.Cau.Name = "Cau";
            this.Cau.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Cau.Visible = true;
            this.Cau.VisibleIndex = 0;
            this.Cau.Width = 40;
            // 
            // colCAUTRALOI
            // 
            this.colCAUTRALOI.AppearanceCell.Options.UseTextOptions = true;
            this.colCAUTRALOI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAUTRALOI.Caption = "Lựa chọn";
            this.colCAUTRALOI.FieldName = "CAUTRALOI";
            this.colCAUTRALOI.Name = "colCAUTRALOI";
            this.colCAUTRALOI.Visible = true;
            this.colCAUTRALOI.VisibleIndex = 1;
            // 
            // bdsBangdiem
            // 
            this.bdsBangdiem.DataMember = "BANGDIEM";
            this.bdsBangdiem.DataSource = this.DS;
            // 
            // taBangdiem
            // 
            this.taBangdiem.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(299, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 25);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(117, 305);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(81, 25);
            this.btnPre.TabIndex = 7;
            this.btnPre.Text = "Câu trước";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lbSocau
            // 
            this.lbSocau.AutoSize = true;
            this.lbSocau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSocau.Location = new System.Drawing.Point(247, 314);
            this.lbSocau.Name = "lbSocau";
            this.lbSocau.Size = new System.Drawing.Size(46, 17);
            this.lbSocau.TabIndex = 10;
            this.lbSocau.Text = "/socau";
            // 
            // lbND
            // 
            this.lbND.AutoSize = true;
            this.lbND.Location = new System.Drawing.Point(43, 33);
            this.lbND.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbND.Name = "lbND";
            this.lbND.Size = new System.Drawing.Size(68, 17);
            this.lbND.TabIndex = 6;
            this.lbND.Text = "Nội dung :";
            // 
            // btnDi
            // 
            this.btnDi.Location = new System.Drawing.Point(213, 337);
            this.btnDi.Name = "btnDi";
            this.btnDi.Size = new System.Drawing.Size(67, 23);
            this.btnDi.TabIndex = 11;
            this.btnDi.Text = "Đi";
            this.btnDi.Click += new System.EventHandler(this.btnDi_Click);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(44, 229);
            this.D.MaximumSize = new System.Drawing.Size(400, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(101, 21);
            this.D.TabIndex = 5;
            this.D.TabStop = true;
            this.D.Text = "radioButton4";
            this.D.UseVisualStyleBackColor = true;
            this.D.CheckedChanged += new System.EventHandler(this.D_CheckedChanged);
            // 
            // spnCau
            // 
            this.spnCau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCau.Location = new System.Drawing.Point(204, 310);
            this.spnCau.Name = "spnCau";
            this.spnCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions2)});
            this.spnCau.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spnCau.Properties.Mask.EditMask = "f0";
            this.spnCau.Size = new System.Drawing.Size(44, 20);
            this.spnCau.TabIndex = 12;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(44, 179);
            this.C.MaximumSize = new System.Drawing.Size(400, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(101, 21);
            this.C.TabIndex = 4;
            this.C.TabStop = true;
            this.C.Text = "radioButton3";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(386, 306);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(67, 25);
            this.btnCuoi.TabIndex = 13;
            this.btnCuoi.Text = "Cuối";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(44, 129);
            this.B.MaximumSize = new System.Drawing.Size(400, 0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(101, 21);
            this.B.TabIndex = 3;
            this.B.TabStop = true;
            this.B.Text = "radioButton2";
            this.B.UseVisualStyleBackColor = true;
            this.B.CheckedChanged += new System.EventHandler(this.B_CheckedChanged);
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(44, 305);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(67, 25);
            this.btnDau.TabIndex = 14;
            this.btnDau.Text = "Đầu";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(44, 79);
            this.A.MaximumSize = new System.Drawing.Size(400, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(101, 21);
            this.A.TabIndex = 2;
            this.A.TabStop = true;
            this.A.Text = "radioButton1";
            this.A.UseVisualStyleBackColor = true;
            this.A.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.A);
            this.groupBox3.Controls.Add(this.btnDau);
            this.groupBox3.Controls.Add(this.B);
            this.groupBox3.Controls.Add(this.btnCuoi);
            this.groupBox3.Controls.Add(this.C);
            this.groupBox3.Controls.Add(this.spnCau);
            this.groupBox3.Controls.Add(this.D);
            this.groupBox3.Controls.Add(this.btnDi);
            this.groupBox3.Controls.Add(this.lbND);
            this.groupBox3.Controls.Add(this.lbSocau);
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(158, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 525);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bAITHIGridControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaithi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCau.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DS DS;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter taGVDK;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMALOP;
        private System.Windows.Forms.Label lbTENLOP;
        private System.Windows.Forms.Label lbLan;
        private System.Windows.Forms.ComboBox cmbMAMH;
        private System.Windows.Forms.Label lbNT;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnThi;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnNop;
        private System.Windows.Forms.Label lbTGThi;
        private System.Windows.Forms.BindingSource bdsBaithi;
        private DSTableAdapters.BAITHITableAdapter taBaithi;
        private DevExpress.XtraGrid.GridControl bAITHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Cau;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUTRALOI;
        private System.Windows.Forms.BindingSource bdsBangdiem;
        private DSTableAdapters.BANGDIEMTableAdapter taBangdiem;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private System.Windows.Forms.Label lbSocau;
        private System.Windows.Forms.Label lbND;
        private DevExpress.XtraEditors.SimpleButton btnDi;
        private System.Windows.Forms.RadioButton D;
        private DevExpress.XtraEditors.SpinEdit spnCau;
        private System.Windows.Forms.RadioButton C;
        private DevExpress.XtraEditors.SimpleButton btnCuoi;
        private System.Windows.Forms.RadioButton B;
        private DevExpress.XtraEditors.SimpleButton btnDau;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}