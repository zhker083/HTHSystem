namespace HTHSystem
{
    partial class FormUserLogin
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.tabControlAuth = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.panelLoginCard = new System.Windows.Forms.Panel();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelAgreementLogin = new System.Windows.Forms.LinkLabel();
            this.checkBoxAgreementLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxRememberPassword = new System.Windows.Forms.CheckBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginAccount = new System.Windows.Forms.TextBox();
            this.labelLoginAccount = new System.Windows.Forms.Label();
            this.labelLoginHeader = new System.Windows.Forms.Label();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.panelRegisterCard = new System.Windows.Forms.Panel();
            this.linkLabelBackToLogin = new System.Windows.Forms.LinkLabel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.linkLabelAgreementRegister = new System.Windows.Forms.LinkLabel();
            this.checkBoxAgreementRegister = new System.Windows.Forms.CheckBox();
            this.textBoxRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterAccount = new System.Windows.Forms.TextBox();
            this.labelRegisterAccount = new System.Windows.Forms.Label();
            this.labelRegisterHeader = new System.Windows.Forms.Label();
            this.tabControlAuth.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.panelLoginCard.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.panelRegisterCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelTitle.Location = new System.Drawing.Point(274, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(153, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "欢迎使用";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.labelSubtitle.Location = new System.Drawing.Point(220, 77);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(259, 19);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "请登录或注册账号后继续访问系统";
            // 
            // tabControlAuth
            // 
            this.tabControlAuth.Controls.Add(this.tabPageLogin);
            this.tabControlAuth.Controls.Add(this.tabPageRegister);
            this.tabControlAuth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAuth.ItemSize = new System.Drawing.Size(120, 32);
            this.tabControlAuth.Location = new System.Drawing.Point(60, 120);
            this.tabControlAuth.Name = "tabControlAuth";
            this.tabControlAuth.SelectedIndex = 0;
            this.tabControlAuth.Size = new System.Drawing.Size(620, 500);
            this.tabControlAuth.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlAuth.TabIndex = 2;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPageLogin.Controls.Add(this.panelLoginCard);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 36);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(612, 460);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "登录";
            // 
            // panelLoginCard
            // 
            this.panelLoginCard.BackColor = System.Drawing.Color.White;
            this.panelLoginCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoginCard.Controls.Add(this.linkLabelRegister);
            this.panelLoginCard.Controls.Add(this.buttonLogin);
            this.panelLoginCard.Controls.Add(this.linkLabelAgreementLogin);
            this.panelLoginCard.Controls.Add(this.checkBoxAgreementLogin);
            this.panelLoginCard.Controls.Add(this.checkBoxRememberPassword);
            this.panelLoginCard.Controls.Add(this.textBoxLoginPassword);
            this.panelLoginCard.Controls.Add(this.labelLoginPassword);
            this.panelLoginCard.Controls.Add(this.textBoxLoginAccount);
            this.panelLoginCard.Controls.Add(this.labelLoginAccount);
            this.panelLoginCard.Controls.Add(this.labelLoginHeader);
            this.panelLoginCard.Location = new System.Drawing.Point(118, 36);
            this.panelLoginCard.Name = "panelLoginCard";
            this.panelLoginCard.Size = new System.Drawing.Size(380, 375);
            this.panelLoginCard.TabIndex = 0;
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.linkLabelRegister.Location = new System.Drawing.Point(111, 320);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(158, 15);
            this.linkLabelRegister.TabIndex = 9;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "还没有账号？立即注册账号";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(44, 265);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(290, 38);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelAgreementLogin
            // 
            this.linkLabelAgreementLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.linkLabelAgreementLogin.AutoSize = true;
            this.linkLabelAgreementLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.linkLabelAgreementLogin.Location = new System.Drawing.Point(161, 226);
            this.linkLabelAgreementLogin.Name = "linkLabelAgreementLogin";
            this.linkLabelAgreementLogin.Size = new System.Drawing.Size(79, 15);
            this.linkLabelAgreementLogin.TabIndex = 7;
            this.linkLabelAgreementLogin.TabStop = true;
            this.linkLabelAgreementLogin.Text = "《服务协议》";
            // 
            // checkBoxAgreementLogin
            // 
            this.checkBoxAgreementLogin.AutoSize = true;
            this.checkBoxAgreementLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.checkBoxAgreementLogin.Location = new System.Drawing.Point(44, 224);
            this.checkBoxAgreementLogin.Name = "checkBoxAgreementLogin";
            this.checkBoxAgreementLogin.Size = new System.Drawing.Size(123, 19);
            this.checkBoxAgreementLogin.TabIndex = 6;
            this.checkBoxAgreementLogin.Text = "我已阅读并同意";
            this.checkBoxAgreementLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberPassword
            // 
            this.checkBoxRememberPassword.AutoSize = true;
            this.checkBoxRememberPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.checkBoxRememberPassword.Location = new System.Drawing.Point(44, 189);
            this.checkBoxRememberPassword.Name = "checkBoxRememberPassword";
            this.checkBoxRememberPassword.Size = new System.Drawing.Size(75, 19);
            this.checkBoxRememberPassword.TabIndex = 5;
            this.checkBoxRememberPassword.Text = "记住密码";
            this.checkBoxRememberPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(44, 146);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(290, 23);
            this.textBoxLoginPassword.TabIndex = 4;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelLoginPassword.Location = new System.Drawing.Point(41, 126);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(31, 15);
            this.labelLoginPassword.TabIndex = 3;
            this.labelLoginPassword.Text = "密码";
            // 
            // textBoxLoginAccount
            // 
            this.textBoxLoginAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginAccount.Location = new System.Drawing.Point(44, 89);
            this.textBoxLoginAccount.Name = "textBoxLoginAccount";
            this.textBoxLoginAccount.Size = new System.Drawing.Size(290, 23);
            this.textBoxLoginAccount.TabIndex = 2;
            // 
            // labelLoginAccount
            // 
            this.labelLoginAccount.AutoSize = true;
            this.labelLoginAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelLoginAccount.Location = new System.Drawing.Point(41, 69);
            this.labelLoginAccount.Name = "labelLoginAccount";
            this.labelLoginAccount.Size = new System.Drawing.Size(31, 15);
            this.labelLoginAccount.TabIndex = 1;
            this.labelLoginAccount.Text = "账号";
            // 
            // labelLoginHeader
            // 
            this.labelLoginHeader.AutoSize = true;
            this.labelLoginHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelLoginHeader.Location = new System.Drawing.Point(39, 28);
            this.labelLoginHeader.Name = "labelLoginHeader";
            this.labelLoginHeader.Size = new System.Drawing.Size(145, 25);
            this.labelLoginHeader.TabIndex = 0;
            this.labelLoginHeader.Text = "登录到系统账号";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tabPageRegister.Controls.Add(this.panelRegisterCard);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 36);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(612, 460);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "注册";
            // 
            // panelRegisterCard
            // 
            this.panelRegisterCard.BackColor = System.Drawing.Color.White;
            this.panelRegisterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegisterCard.Controls.Add(this.linkLabelBackToLogin);
            this.panelRegisterCard.Controls.Add(this.buttonRegister);
            this.panelRegisterCard.Controls.Add(this.linkLabelAgreementRegister);
            this.panelRegisterCard.Controls.Add(this.checkBoxAgreementRegister);
            this.panelRegisterCard.Controls.Add(this.textBoxRegisterConfirmPassword);
            this.panelRegisterCard.Controls.Add(this.labelRegisterConfirmPassword);
            this.panelRegisterCard.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegisterCard.Controls.Add(this.labelRegisterPassword);
            this.panelRegisterCard.Controls.Add(this.textBoxRegisterAccount);
            this.panelRegisterCard.Controls.Add(this.labelRegisterAccount);
            this.panelRegisterCard.Controls.Add(this.labelRegisterHeader);
            this.panelRegisterCard.Location = new System.Drawing.Point(118, 24);
            this.panelRegisterCard.Name = "panelRegisterCard";
            this.panelRegisterCard.Size = new System.Drawing.Size(380, 402);
            this.panelRegisterCard.TabIndex = 0;
            // 
            // linkLabelBackToLogin
            // 
            this.linkLabelBackToLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.linkLabelBackToLogin.AutoSize = true;
            this.linkLabelBackToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.linkLabelBackToLogin.Location = new System.Drawing.Point(123, 346);
            this.linkLabelBackToLogin.Name = "linkLabelBackToLogin";
            this.linkLabelBackToLogin.Size = new System.Drawing.Size(131, 15);
            this.linkLabelBackToLogin.TabIndex = 10;
            this.linkLabelBackToLogin.TabStop = true;
            this.linkLabelBackToLogin.Text = "已有账号？返回登录";
            this.linkLabelBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackToLogin_LinkClicked);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(44, 290);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(290, 38);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "注册账号";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // linkLabelAgreementRegister
            // 
            this.linkLabelAgreementRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(235)))));
            this.linkLabelAgreementRegister.AutoSize = true;
            this.linkLabelAgreementRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(218)))));
            this.linkLabelAgreementRegister.Location = new System.Drawing.Point(161, 250);
            this.linkLabelAgreementRegister.Name = "linkLabelAgreementRegister";
            this.linkLabelAgreementRegister.Size = new System.Drawing.Size(79, 15);
            this.linkLabelAgreementRegister.TabIndex = 8;
            this.linkLabelAgreementRegister.TabStop = true;
            this.linkLabelAgreementRegister.Text = "《服务协议》";
            // 
            // checkBoxAgreementRegister
            // 
            this.checkBoxAgreementRegister.AutoSize = true;
            this.checkBoxAgreementRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.checkBoxAgreementRegister.Location = new System.Drawing.Point(44, 248);
            this.checkBoxAgreementRegister.Name = "checkBoxAgreementRegister";
            this.checkBoxAgreementRegister.Size = new System.Drawing.Size(123, 19);
            this.checkBoxAgreementRegister.TabIndex = 7;
            this.checkBoxAgreementRegister.Text = "我已阅读并同意";
            this.checkBoxAgreementRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxRegisterConfirmPassword
            // 
            this.textBoxRegisterConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterConfirmPassword.Location = new System.Drawing.Point(44, 202);
            this.textBoxRegisterConfirmPassword.Name = "textBoxRegisterConfirmPassword";
            this.textBoxRegisterConfirmPassword.PasswordChar = '*';
            this.textBoxRegisterConfirmPassword.Size = new System.Drawing.Size(290, 23);
            this.textBoxRegisterConfirmPassword.TabIndex = 6;
            // 
            // labelRegisterConfirmPassword
            // 
            this.labelRegisterConfirmPassword.AutoSize = true;
            this.labelRegisterConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelRegisterConfirmPassword.Location = new System.Drawing.Point(41, 182);
            this.labelRegisterConfirmPassword.Name = "labelRegisterConfirmPassword";
            this.labelRegisterConfirmPassword.Size = new System.Drawing.Size(55, 15);
            this.labelRegisterConfirmPassword.TabIndex = 5;
            this.labelRegisterConfirmPassword.Text = "确认密码";
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(44, 145);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(290, 23);
            this.textBoxRegisterPassword.TabIndex = 4;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelRegisterPassword.Location = new System.Drawing.Point(41, 125);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(31, 15);
            this.labelRegisterPassword.TabIndex = 3;
            this.labelRegisterPassword.Text = "密码";
            // 
            // textBoxRegisterAccount
            // 
            this.textBoxRegisterAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegisterAccount.Location = new System.Drawing.Point(44, 88);
            this.textBoxRegisterAccount.Name = "textBoxRegisterAccount";
            this.textBoxRegisterAccount.Size = new System.Drawing.Size(290, 23);
            this.textBoxRegisterAccount.TabIndex = 2;
            // 
            // labelRegisterAccount
            // 
            this.labelRegisterAccount.AutoSize = true;
            this.labelRegisterAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelRegisterAccount.Location = new System.Drawing.Point(41, 68);
            this.labelRegisterAccount.Name = "labelRegisterAccount";
            this.labelRegisterAccount.Size = new System.Drawing.Size(31, 15);
            this.labelRegisterAccount.TabIndex = 1;
            this.labelRegisterAccount.Text = "账号";
            // 
            // labelRegisterHeader
            // 
            this.labelRegisterHeader.AutoSize = true;
            this.labelRegisterHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.labelRegisterHeader.Location = new System.Drawing.Point(39, 28);
            this.labelRegisterHeader.Name = "labelRegisterHeader";
            this.labelRegisterHeader.Size = new System.Drawing.Size(126, 25);
            this.labelRegisterHeader.TabIndex = 0;
            this.labelRegisterHeader.Text = "创建新账号";
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(740, 660);
            this.Controls.Add(this.tabControlAuth);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录 / 注册";
            this.tabControlAuth.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.panelLoginCard.ResumeLayout(false);
            this.panelLoginCard.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.panelRegisterCard.ResumeLayout(false);
            this.panelRegisterCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TabControl tabControlAuth;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.Panel panelLoginCard;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelAgreementLogin;
        private System.Windows.Forms.CheckBox checkBoxAgreementLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberPassword;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginAccount;
        private System.Windows.Forms.Label labelLoginAccount;
        private System.Windows.Forms.Label labelLoginHeader;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.Panel panelRegisterCard;
        private System.Windows.Forms.LinkLabel linkLabelBackToLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.LinkLabel linkLabelAgreementRegister;
        private System.Windows.Forms.CheckBox checkBoxAgreementRegister;
        private System.Windows.Forms.TextBox textBoxRegisterConfirmPassword;
        private System.Windows.Forms.Label labelRegisterConfirmPassword;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterAccount;
        private System.Windows.Forms.Label labelRegisterAccount;
        private System.Windows.Forms.Label labelRegisterHeader;
    }
}