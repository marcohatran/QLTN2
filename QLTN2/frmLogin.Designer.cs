namespace QLTN2

{
    partial class frmLogin
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
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDangKi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(356, 318);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(401, 28);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "PassWord";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(356, 255);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(401, 28);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(356, 184);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(401, 28);
            this.txtPass.TabIndex = 5;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(384, 378);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(106, 40);
            this.btnDangKi.TabIndex = 10;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(619, 378);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 40);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(356, 116);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(401, 28);
            this.txtLogin.TabIndex = 15;
          
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(442, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tạo Login ";
          
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRole);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Đăng kí";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.SimpleButton btnDangKi;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}