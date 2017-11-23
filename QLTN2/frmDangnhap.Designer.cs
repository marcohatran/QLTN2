namespace QLTN2
{
    partial class frmDangnhap
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
            System.Windows.Forms.Label cOSOLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.cOSOComboBox = new System.Windows.Forms.ComboBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.grpDangnhap = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            cOSOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.grpDangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOSOLabel
            // 
            cOSOLabel.AutoSize = true;
            cOSOLabel.Location = new System.Drawing.Point(12, 59);
            cOSOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cOSOLabel.Name = "cOSOLabel";
            cOSOLabel.Size = new System.Drawing.Size(53, 19);
            cOSOLabel.TabIndex = 1;
            cOSOLabel.Text = "Cơ sở :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 98);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 19);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 137);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 19);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu :";
            // 
            // cOSOComboBox
            // 
            this.cOSOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOSOComboBox.FormattingEnabled = true;
            this.cOSOComboBox.Location = new System.Drawing.Point(107, 51);
            this.cOSOComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cOSOComboBox.Name = "cOSOComboBox";
            this.cOSOComboBox.Size = new System.Drawing.Size(288, 27);
            this.cOSOComboBox.TabIndex = 2;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(107, 91);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(288, 26);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(107, 130);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(288, 26);
            this.txtMatkhau.TabIndex = 5;
            // 
            // grpDangnhap
            // 
            this.grpDangnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpDangnhap.Controls.Add(this.btnThoat);
            this.grpDangnhap.Controls.Add(this.btnDangnhap);
            this.grpDangnhap.Controls.Add(this.txtTaikhoan);
            this.grpDangnhap.Controls.Add(label2);
            this.grpDangnhap.Controls.Add(this.cOSOComboBox);
            this.grpDangnhap.Controls.Add(label1);
            this.grpDangnhap.Controls.Add(cOSOLabel);
            this.grpDangnhap.Controls.Add(this.txtMatkhau);
            this.grpDangnhap.Location = new System.Drawing.Point(481, 124);
            this.grpDangnhap.Name = "grpDangnhap";
            this.grpDangnhap.Size = new System.Drawing.Size(412, 235);
            this.grpDangnhap.TabIndex = 9;
            this.grpDangnhap.TabStop = false;
            this.grpDangnhap.Text = "Đăng nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(239, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(111, 172);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(97, 23);
            this.btnDangnhap.TabIndex = 9;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.grpDangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            this.grpDangnhap.ResumeLayout(false);
            this.grpDangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cOSOComboBox;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.GroupBox grpDangnhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
    }
}