namespace QLTN2
{
    partial class frmBangDiemTheoLop
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLTN2.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.taLop = new QLTN2.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.taMonHoc = new QLTN2.DSTableAdapters.MONHOCTableAdapter();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(24, 33);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(86, 21);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(352, 33);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(79, 21);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLan);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(tENMHLabel);
            this.panel1.Controls.Add(this.cmbTenMH);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.cmbTenLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 96);
            this.panel1.TabIndex = 0;
            // 
            // cmbLan
            // 
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLan.Location = new System.Drawing.Point(673, 33);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(121, 28);
            this.cmbLan.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1029, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(887, 16);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(97, 41);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lần";
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(435, 29);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(150, 28);
            this.cmbTenMH.TabIndex = 3;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(117, 29);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(227, 28);
            this.cmbTenLop.TabIndex = 1;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            this.bdsMonHoc.CurrentChanged += new System.EventHandler(this.mONHOCBindingSource_CurrentChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
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
            this.tableAdapterManager.MONHOCTableAdapter = this.taMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taMonHoc
            // 
            this.taMonHoc.ClearBeforeFill = true;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 96);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(1143, 605);
            this.crptView.TabIndex = 1;
            this.crptView.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmBangDiemTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 701);
            this.Controls.Add(this.crptView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiemTheoLop";
            this.Text = "frmBangDiemTheoLop";
            this.Load += new System.EventHandler(this.frmBangDiemTheoLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter taLop;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private DSTableAdapters.MONHOCTableAdapter taMonHoc;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.ComboBox cmbLan;
    }
}