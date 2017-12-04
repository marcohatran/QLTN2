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
            this.DS = new QLTN2.DS();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.taGVDK = new QLTN2.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.cmbMAMH = new System.Windows.Forms.ComboBox();
            this.lbNT = new System.Windows.Forms.Label();
            this.gbThi = new System.Windows.Forms.GroupBox();
            this.rdg = new DevExpress.XtraEditors.RadioGroup();
            this.D = new System.Windows.Forms.RadioButton();
            this.fnc_LAYDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.fnc_LAYDEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLan = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.fnc_LAYDETableAdapter = new QLTN2.DSTableAdapters.fnc_LAYDETableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.tRINHDOToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tRINHDOToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mAMHToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mAMHToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.sOCAUToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sOCAUToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            this.gbThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnc_LAYDEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnc_LAYDEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(28, 120);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(93, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "Chọn môn học";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
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
            // cmbMAMH
            // 
            this.cmbMAMH.FormattingEnabled = true;
            this.cmbMAMH.Location = new System.Drawing.Point(127, 112);
            this.cmbMAMH.Name = "cmbMAMH";
            this.cmbMAMH.Size = new System.Drawing.Size(239, 25);
            this.cmbMAMH.TabIndex = 3;
            this.cmbMAMH.SelectedIndexChanged += new System.EventHandler(this.cmbMAMH_SelectedIndexChanged);
            // 
            // lbNT
            // 
            this.lbNT.AutoSize = true;
            this.lbNT.Location = new System.Drawing.Point(63, 151);
            this.lbNT.Name = "lbNT";
            this.lbNT.Size = new System.Drawing.Size(58, 17);
            this.lbNT.TabIndex = 4;
            this.lbNT.Text = "Ngày thi";
            // 
            // gbThi
            // 
            this.gbThi.Controls.Add(this.D);
            this.gbThi.Controls.Add(this.label3);
            this.gbThi.Controls.Add(this.C);
            this.gbThi.Controls.Add(this.B);
            this.gbThi.Controls.Add(this.fnc_LAYDEGridControl);
            this.gbThi.Controls.Add(this.groupBox1);
            this.gbThi.Controls.Add(this.A);
            this.gbThi.Controls.Add(this.rdg);
            this.gbThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbThi.Location = new System.Drawing.Point(0, 0);
            this.gbThi.Name = "gbThi";
            this.gbThi.Size = new System.Drawing.Size(939, 407);
            this.gbThi.TabIndex = 5;
            this.gbThi.TabStop = false;
            this.gbThi.Text = "groupBox1";
            // 
            // rdg
            // 
            this.rdg.Location = new System.Drawing.Point(198, 204);
            this.rdg.Name = "rdg";
            this.rdg.Size = new System.Drawing.Size(213, 139);
            this.rdg.TabIndex = 7;
            this.rdg.SelectedIndexChanged += new System.EventHandler(this.rdg_SelectedIndexChanged);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fnc_LAYDEBindingSource, "D", true));
            this.D.Location = new System.Drawing.Point(241, 253);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(37, 21);
            this.D.TabIndex = 5;
            this.D.TabStop = true;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // fnc_LAYDEBindingSource
            // 
            this.fnc_LAYDEBindingSource.DataMember = "fnc_LAYDE";
            this.fnc_LAYDEBindingSource.DataSource = this.DS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nội dung";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fnc_LAYDEBindingSource, "C", true));
            this.C.Location = new System.Drawing.Point(241, 222);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(36, 21);
            this.C.TabIndex = 4;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fnc_LAYDEBindingSource, "B", true));
            this.B.Location = new System.Drawing.Point(231, 123);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(36, 21);
            this.B.TabIndex = 3;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // fnc_LAYDEGridControl
            // 
            this.fnc_LAYDEGridControl.DataSource = this.fnc_LAYDEBindingSource;
            this.fnc_LAYDEGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.fnc_LAYDEGridControl.Location = new System.Drawing.Point(3, 21);
            this.fnc_LAYDEGridControl.MainView = this.gridView1;
            this.fnc_LAYDEGridControl.Name = "fnc_LAYDEGridControl";
            this.fnc_LAYDEGridControl.Size = new System.Drawing.Size(169, 383);
            this.fnc_LAYDEGridControl.TabIndex = 1;
            this.fnc_LAYDEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colChon});
            this.gridView1.GridControl = this.fnc_LAYDEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.Caption = "Câu";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 46;
            // 
            // colChon
            // 
            this.colChon.Caption = "Chọn";
            this.colChon.Name = "colChon";
            this.colChon.Visible = true;
            this.colChon.VisibleIndex = 1;
            this.colChon.Width = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbLan);
            this.groupBox1.Controls.Add(this.cmbMAMH);
            this.groupBox1.Controls.Add(this.lbNT);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Location = new System.Drawing.Point(470, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên lớp";
            // 
            // lbLan
            // 
            this.lbLan.AutoSize = true;
            this.lbLan.Location = new System.Drawing.Point(90, 182);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(31, 17);
            this.lbLan.TabIndex = 5;
            this.lbLan.Text = "Lần";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fnc_LAYDEBindingSource, "A", true));
            this.A.Location = new System.Drawing.Point(231, 96);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(37, 21);
            this.A.TabIndex = 2;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // fnc_LAYDETableAdapter
            // 
            this.fnc_LAYDETableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRINHDOToolStripLabel,
            this.tRINHDOToolStripTextBox,
            this.mAMHToolStripLabel,
            this.mAMHToolStripTextBox,
            this.sOCAUToolStripLabel,
            this.sOCAUToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(939, 25);
            this.fillToolStrip.TabIndex = 6;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // tRINHDOToolStripLabel
            // 
            this.tRINHDOToolStripLabel.Name = "tRINHDOToolStripLabel";
            this.tRINHDOToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.tRINHDOToolStripLabel.Text = "TRINHDO:";
            // 
            // tRINHDOToolStripTextBox
            // 
            this.tRINHDOToolStripTextBox.Name = "tRINHDOToolStripTextBox";
            this.tRINHDOToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // mAMHToolStripLabel
            // 
            this.mAMHToolStripLabel.Name = "mAMHToolStripLabel";
            this.mAMHToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.mAMHToolStripLabel.Text = "MAMH:";
            // 
            // mAMHToolStripTextBox
            // 
            this.mAMHToolStripTextBox.Name = "mAMHToolStripTextBox";
            this.mAMHToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // sOCAUToolStripLabel
            // 
            this.sOCAUToolStripLabel.Name = "sOCAUToolStripLabel";
            this.sOCAUToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.sOCAUToolStripLabel.Text = "SOCAU:";
            // 
            // sOCAUToolStripTextBox
            // 
            this.sOCAUToolStripTextBox.Name = "sOCAUToolStripTextBox";
            this.sOCAUToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 407);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.gbThi);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            this.gbThi.ResumeLayout(false);
            this.gbThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnc_LAYDEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnc_LAYDEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS DS;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter taGVDK;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMAMH;
        private System.Windows.Forms.Label lbNT;
        private System.Windows.Forms.GroupBox gbThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fnc_LAYDEBindingSource;
        private DSTableAdapters.fnc_LAYDETableAdapter fnc_LAYDETableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel tRINHDOToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tRINHDOToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel mAMHToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mAMHToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel sOCAUToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sOCAUToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton A;
        private DevExpress.XtraGrid.GridControl fnc_LAYDEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.RadioGroup rdg;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colChon;
    }
}