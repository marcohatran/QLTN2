namespace QLTN2
{
    partial class frmCauTraLoi
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
            System.Windows.Forms.Label tRINHDOLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLTN2.DS();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.taLop = new QLTN2.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLTN2.DSTableAdapters.TableAdapterManager();
            this.taMonHoc = new QLTN2.DSTableAdapters.MONHOCTableAdapter();
            this.taBoDe = new QLTN2.DSTableAdapters.BODETableAdapter();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(14, 29);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(86, 21);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(325, 29);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(79, 21);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(634, 29);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(98, 21);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(tRINHDOLabel);
            this.panel1.Controls.Add(this.cmbTrinhDo);
            this.panel1.Controls.Add(tENMHLabel);
            this.panel1.Controls.Add(this.cmbTenMH);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.cmbTenLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 96);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1080, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(944, 24);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 41);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "TRINHDO", true));
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(747, 29);
            this.cmbTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(150, 28);
            this.cmbTrinhDo.TabIndex = 5;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK__BODE__MAMH__339FAB6E";
            this.bdsBoDe.DataSource = this.bdsMonHoc;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(409, 25);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(217, 28);
            this.cmbTenMH.TabIndex = 3;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(108, 25);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(209, 28);
            this.cmbTenLop.TabIndex = 1;
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTN2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taMonHoc
            // 
            this.taMonHoc.ClearBeforeFill = true;
            // 
            // taBoDe
            // 
            this.taBoDe.ClearBeforeFill = true;
            // 
            // frmCauTraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 726);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCauTraLoi";
            this.Text = "frmCauTraLoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCauTraLoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter taMonHoc;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DSTableAdapters.BODETableAdapter taBoDe;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}