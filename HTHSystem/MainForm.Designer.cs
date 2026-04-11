namespace HTHSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnNavExit = new System.Windows.Forms.Button();
            this.btnNavSetting = new System.Windows.Forms.Button();
            this.btnNavUser = new System.Windows.Forms.Button();
            this.btnNavDevice = new System.Windows.Forms.Button();
            this.btnNavData = new System.Windows.Forms.Button();
            this.btnNavMonitor = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTimeCaption = new System.Windows.Forms.Label();
            this.lblCurrentUserValue = new System.Windows.Forms.Label();
            this.lblCurrentUserCaption = new System.Windows.Forms.Label();
            this.lblSystemStatusValue = new System.Windows.Forms.Label();
            this.lblSystemStatusCaption = new System.Windows.Forms.Label();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelModuleHost = new System.Windows.Forms.Panel();
            this.panelSettingModule = new System.Windows.Forms.Panel();
            this.panelSettingCard = new System.Windows.Forms.Panel();
            this.lblSettingDescription = new System.Windows.Forms.Label();
            this.lblSettingTitle = new System.Windows.Forms.Label();
            this.panelUserModule = new System.Windows.Forms.Panel();
            this.panelUserRight = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelUserLog = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelUserToolbar = new System.Windows.Forms.Panel();
            this.btnLogTest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetByAccount = new System.Windows.Forms.Button();
            this.btnExists = new System.Windows.Forms.Button();
            this.panelUserLeft = new System.Windows.Forms.Panel();
            this.panelUserSearch = new System.Windows.Forms.Panel();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.panelUserEditor = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblUserEditorTitle = new System.Windows.Forms.Label();
            this.panelDeviceModule = new System.Windows.Forms.Panel();
            this.panelDeviceCard = new System.Windows.Forms.Panel();
            this.lblDeviceDescription = new System.Windows.Forms.Label();
            this.lblDeviceTitle = new System.Windows.Forms.Label();
            this.panelDataModule = new System.Windows.Forms.Panel();
            this.panelDataCard = new System.Windows.Forms.Panel();
            this.lblDataDescription = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.panelMonitorModule = new System.Windows.Forms.Panel();
            this.panelMonitorCard = new System.Windows.Forms.Panel();
            this.lblMonitorDescription = new System.Windows.Forms.Label();
            this.lblMonitorTitle = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelTopBar.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.panelModuleHost.SuspendLayout();
            this.panelSettingModule.SuspendLayout();
            this.panelSettingCard.SuspendLayout();
            this.panelUserModule.SuspendLayout();
            this.panelUserRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelUserLog.SuspendLayout();
            this.panelUserToolbar.SuspendLayout();
            this.panelUserLeft.SuspendLayout();
            this.panelUserSearch.SuspendLayout();
            this.panelUserEditor.SuspendLayout();
            this.panelDeviceModule.SuspendLayout();
            this.panelDeviceCard.SuspendLayout();
            this.panelDataModule.SuspendLayout();
            this.panelDataCard.SuspendLayout();
            this.panelMonitorModule.SuspendLayout();
            this.panelMonitorCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.panelTopBar.Controls.Add(this.btnNavExit);
            this.panelTopBar.Controls.Add(this.btnNavSetting);
            this.panelTopBar.Controls.Add(this.btnNavUser);
            this.panelTopBar.Controls.Add(this.btnNavDevice);
            this.panelTopBar.Controls.Add(this.btnNavData);
            this.panelTopBar.Controls.Add(this.btnNavMonitor);
            this.panelTopBar.Controls.Add(this.lblTitle);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1364, 78);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnNavExit
            // 
            this.btnNavExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavExit.FlatAppearance.BorderSize = 0;
            this.btnNavExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavExit.ForeColor = System.Drawing.Color.White;
            this.btnNavExit.Location = new System.Drawing.Point(1240, 18);
            this.btnNavExit.Name = "btnNavExit";
            this.btnNavExit.Size = new System.Drawing.Size(96, 40);
            this.btnNavExit.TabIndex = 6;
            this.btnNavExit.Text = "退出";
            this.btnNavExit.UseVisualStyleBackColor = false;
            this.btnNavExit.Click += new System.EventHandler(this.btnNavExit_Click);
            // 
            // btnNavSetting
            // 
            this.btnNavSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavSetting.FlatAppearance.BorderSize = 0;
            this.btnNavSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavSetting.ForeColor = System.Drawing.Color.White;
            this.btnNavSetting.Location = new System.Drawing.Point(532, 18);
            this.btnNavSetting.Name = "btnNavSetting";
            this.btnNavSetting.Size = new System.Drawing.Size(96, 40);
            this.btnNavSetting.TabIndex = 5;
            this.btnNavSetting.Text = "设置";
            this.btnNavSetting.UseVisualStyleBackColor = false;
            this.btnNavSetting.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnNavUser
            // 
            this.btnNavUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavUser.FlatAppearance.BorderSize = 0;
            this.btnNavUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavUser.ForeColor = System.Drawing.Color.White;
            this.btnNavUser.Location = new System.Drawing.Point(430, 18);
            this.btnNavUser.Name = "btnNavUser";
            this.btnNavUser.Size = new System.Drawing.Size(96, 40);
            this.btnNavUser.TabIndex = 4;
            this.btnNavUser.Text = "用户";
            this.btnNavUser.UseVisualStyleBackColor = false;
            this.btnNavUser.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnNavDevice
            // 
            this.btnNavDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavDevice.FlatAppearance.BorderSize = 0;
            this.btnNavDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDevice.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDevice.ForeColor = System.Drawing.Color.White;
            this.btnNavDevice.Location = new System.Drawing.Point(328, 18);
            this.btnNavDevice.Name = "btnNavDevice";
            this.btnNavDevice.Size = new System.Drawing.Size(96, 40);
            this.btnNavDevice.TabIndex = 3;
            this.btnNavDevice.Text = "设备";
            this.btnNavDevice.UseVisualStyleBackColor = false;
            this.btnNavDevice.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnNavData
            // 
            this.btnNavData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavData.FlatAppearance.BorderSize = 0;
            this.btnNavData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavData.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavData.ForeColor = System.Drawing.Color.White;
            this.btnNavData.Location = new System.Drawing.Point(226, 18);
            this.btnNavData.Name = "btnNavData";
            this.btnNavData.Size = new System.Drawing.Size(96, 40);
            this.btnNavData.TabIndex = 2;
            this.btnNavData.Text = "数据";
            this.btnNavData.UseVisualStyleBackColor = false;
            this.btnNavData.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnNavMonitor
            // 
            this.btnNavMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btnNavMonitor.FlatAppearance.BorderSize = 0;
            this.btnNavMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMonitor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMonitor.ForeColor = System.Drawing.Color.White;
            this.btnNavMonitor.Location = new System.Drawing.Point(124, 18);
            this.btnNavMonitor.Name = "btnNavMonitor";
            this.btnNavMonitor.Size = new System.Drawing.Size(96, 40);
            this.btnNavMonitor.TabIndex = 1;
            this.btnNavMonitor.Text = "监视";
            this.btnNavMonitor.UseVisualStyleBackColor = false;
            this.btnNavMonitor.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "主界面";
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(126)))));
            this.panelStatusBar.Controls.Add(this.lblTimeValue);
            this.panelStatusBar.Controls.Add(this.lblTimeCaption);
            this.panelStatusBar.Controls.Add(this.lblCurrentUserValue);
            this.panelStatusBar.Controls.Add(this.lblCurrentUserCaption);
            this.panelStatusBar.Controls.Add(this.lblSystemStatusValue);
            this.panelStatusBar.Controls.Add(this.lblSystemStatusCaption);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusBar.Location = new System.Drawing.Point(0, 769);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(1364, 32);
            this.panelStatusBar.TabIndex = 1;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblTimeValue.ForeColor = System.Drawing.Color.White;
            this.lblTimeValue.Location = new System.Drawing.Point(1120, 9);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(68, 17);
            this.lblTimeValue.TabIndex = 5;
            this.lblTimeValue.Text = "--:--:--";
            // 
            // lblTimeCaption
            // 
            this.lblTimeCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeCaption.AutoSize = true;
            this.lblTimeCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblTimeCaption.ForeColor = System.Drawing.Color.White;
            this.lblTimeCaption.Location = new System.Drawing.Point(1066, 9);
            this.lblTimeCaption.Name = "lblTimeCaption";
            this.lblTimeCaption.Size = new System.Drawing.Size(44, 17);
            this.lblTimeCaption.TabIndex = 4;
            this.lblTimeCaption.Text = "时间：";
            // 
            // lblCurrentUserValue
            // 
            this.lblCurrentUserValue.AutoSize = true;
            this.lblCurrentUserValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblCurrentUserValue.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUserValue.Location = new System.Drawing.Point(312, 9);
            this.lblCurrentUserValue.Name = "lblCurrentUserValue";
            this.lblCurrentUserValue.Size = new System.Drawing.Size(56, 17);
            this.lblCurrentUserValue.TabIndex = 3;
            this.lblCurrentUserValue.Text = "系统用户";
            // 
            // lblCurrentUserCaption
            // 
            this.lblCurrentUserCaption.AutoSize = true;
            this.lblCurrentUserCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblCurrentUserCaption.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUserCaption.Location = new System.Drawing.Point(238, 9);
            this.lblCurrentUserCaption.Name = "lblCurrentUserCaption";
            this.lblCurrentUserCaption.Size = new System.Drawing.Size(68, 17);
            this.lblCurrentUserCaption.TabIndex = 2;
            this.lblCurrentUserCaption.Text = "登录用户：";
            // 
            // lblSystemStatusValue
            // 
            this.lblSystemStatusValue.AutoSize = true;
            this.lblSystemStatusValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblSystemStatusValue.ForeColor = System.Drawing.Color.White;
            this.lblSystemStatusValue.Location = new System.Drawing.Point(92, 9);
            this.lblSystemStatusValue.Name = "lblSystemStatusValue";
            this.lblSystemStatusValue.Size = new System.Drawing.Size(32, 17);
            this.lblSystemStatusValue.TabIndex = 1;
            this.lblSystemStatusValue.Text = "待机";
            // 
            // lblSystemStatusCaption
            // 
            this.lblSystemStatusCaption.AutoSize = true;
            this.lblSystemStatusCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblSystemStatusCaption.ForeColor = System.Drawing.Color.White;
            this.lblSystemStatusCaption.Location = new System.Drawing.Point(20, 9);
            this.lblSystemStatusCaption.Name = "lblSystemStatusCaption";
            this.lblSystemStatusCaption.Size = new System.Drawing.Size(68, 17);
            this.lblSystemStatusCaption.TabIndex = 0;
            this.lblSystemStatusCaption.Text = "系统状态：";
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(79)))));
            this.panelMainContainer.Controls.Add(this.panelModuleHost);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 78);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.panelMainContainer.Size = new System.Drawing.Size(1364, 691);
            this.panelMainContainer.TabIndex = 2;
            // 
            // panelModuleHost
            // 
            this.panelModuleHost.Controls.Add(this.panelSettingModule);
            this.panelModuleHost.Controls.Add(this.panelUserModule);
            this.panelModuleHost.Controls.Add(this.panelDeviceModule);
            this.panelModuleHost.Controls.Add(this.panelDataModule);
            this.panelModuleHost.Controls.Add(this.panelMonitorModule);
            this.panelModuleHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModuleHost.Location = new System.Drawing.Point(14, 12);
            this.panelModuleHost.Name = "panelModuleHost";
            this.panelModuleHost.Size = new System.Drawing.Size(1336, 667);
            this.panelModuleHost.TabIndex = 0;
            // 
            // panelSettingModule
            // 
            this.panelSettingModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelSettingModule.Controls.Add(this.panelSettingCard);
            this.panelSettingModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingModule.Location = new System.Drawing.Point(0, 0);
            this.panelSettingModule.Name = "panelSettingModule";
            this.panelSettingModule.Size = new System.Drawing.Size(1336, 667);
            this.panelSettingModule.TabIndex = 4;
            this.panelSettingModule.Visible = false;
            // 
            // panelSettingCard
            // 
            this.panelSettingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(68)))), ((int)(((byte)(118)))));
            this.panelSettingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettingCard.Controls.Add(this.lblSettingDescription);
            this.panelSettingCard.Controls.Add(this.lblSettingTitle);
            this.panelSettingCard.Location = new System.Drawing.Point(42, 36);
            this.panelSettingCard.Name = "panelSettingCard";
            this.panelSettingCard.Size = new System.Drawing.Size(466, 160);
            this.panelSettingCard.TabIndex = 0;
            // 
            // lblSettingDescription
            // 
            this.lblSettingDescription.AutoSize = true;
            this.lblSettingDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblSettingDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblSettingDescription.Location = new System.Drawing.Point(26, 78);
            this.lblSettingDescription.Name = "lblSettingDescription";
            this.lblSettingDescription.Size = new System.Drawing.Size(264, 20);
            this.lblSettingDescription.TabIndex = 1;
            this.lblSettingDescription.Text = "设置模块区域，可放置系统参数与权限配置。";
            // 
            // lblSettingTitle
            // 
            this.lblSettingTitle.AutoSize = true;
            this.lblSettingTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSettingTitle.ForeColor = System.Drawing.Color.White;
            this.lblSettingTitle.Location = new System.Drawing.Point(24, 28);
            this.lblSettingTitle.Name = "lblSettingTitle";
            this.lblSettingTitle.Size = new System.Drawing.Size(110, 31);
            this.lblSettingTitle.TabIndex = 0;
            this.lblSettingTitle.Text = "设置区域";
            // 
            // panelUserModule
            // 
            this.panelUserModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelUserModule.Controls.Add(this.panelUserRight);
            this.panelUserModule.Controls.Add(this.panelUserLeft);
            this.panelUserModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserModule.Location = new System.Drawing.Point(0, 0);
            this.panelUserModule.Name = "panelUserModule";
            this.panelUserModule.Size = new System.Drawing.Size(1336, 667);
            this.panelUserModule.TabIndex = 3;
            // 
            // panelUserRight
            // 
            this.panelUserRight.Controls.Add(this.dgvUsers);
            this.panelUserRight.Controls.Add(this.panelUserLog);
            this.panelUserRight.Controls.Add(this.panelUserToolbar);
            this.panelUserRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserRight.Location = new System.Drawing.Point(310, 0);
            this.panelUserRight.Name = "panelUserRight";
            this.panelUserRight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelUserRight.Size = new System.Drawing.Size(1026, 667);
            this.panelUserRight.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(190)))));
            this.dgvUsers.Location = new System.Drawing.Point(10, 58);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 26;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1016, 449);
            this.dgvUsers.TabIndex = 2;
            // 
            // panelUserLog
            // 
            this.panelUserLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelUserLog.Controls.Add(this.txtMessage);
            this.panelUserLog.Controls.Add(this.lblMessage);
            this.panelUserLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserLog.Location = new System.Drawing.Point(10, 507);
            this.panelUserLog.Name = "panelUserLog";
            this.panelUserLog.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelUserLog.Size = new System.Drawing.Size(1016, 160);
            this.panelUserLog.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(18, 45);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(980, 97);
            this.txtMessage.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(14, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "日志输出区";
            // 
            // panelUserToolbar
            // 
            this.panelUserToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelUserToolbar.Controls.Add(this.btnLogTest);
            this.panelUserToolbar.Controls.Add(this.btnClear);
            this.panelUserToolbar.Controls.Add(this.btnLoadList);
            this.panelUserToolbar.Controls.Add(this.btnDelete);
            this.panelUserToolbar.Controls.Add(this.btnGetByAccount);
            this.panelUserToolbar.Controls.Add(this.btnExists);
            this.panelUserToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserToolbar.Location = new System.Drawing.Point(10, 0);
            this.panelUserToolbar.Name = "panelUserToolbar";
            this.panelUserToolbar.Size = new System.Drawing.Size(1016, 58);
            this.panelUserToolbar.TabIndex = 0;
            // 
            // btnLogTest
            // 
            this.btnLogTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnLogTest.FlatAppearance.BorderSize = 0;
            this.btnLogTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogTest.ForeColor = System.Drawing.Color.White;
            this.btnLogTest.Location = new System.Drawing.Point(558, 13);
            this.btnLogTest.Name = "btnLogTest";
            this.btnLogTest.Size = new System.Drawing.Size(96, 30);
            this.btnLogTest.TabIndex = 5;
            this.btnLogTest.Text = "日志测试";
            this.btnLogTest.UseVisualStyleBackColor = false;
            this.btnLogTest.Click += new System.EventHandler(this.btnLogTest_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(450, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空输入";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadList
            // 
            this.btnLoadList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnLoadList.FlatAppearance.BorderSize = 0;
            this.btnLoadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadList.ForeColor = System.Drawing.Color.White;
            this.btnLoadList.Location = new System.Drawing.Point(342, 13);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(96, 30);
            this.btnLoadList.TabIndex = 3;
            this.btnLoadList.Text = "加载列表";
            this.btnLoadList.UseVisualStyleBackColor = false;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(234, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除用户";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetByAccount
            // 
            this.btnGetByAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnGetByAccount.FlatAppearance.BorderSize = 0;
            this.btnGetByAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetByAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGetByAccount.ForeColor = System.Drawing.Color.White;
            this.btnGetByAccount.Location = new System.Drawing.Point(126, 13);
            this.btnGetByAccount.Name = "btnGetByAccount";
            this.btnGetByAccount.Size = new System.Drawing.Size(96, 30);
            this.btnGetByAccount.TabIndex = 1;
            this.btnGetByAccount.Text = "按账号查询";
            this.btnGetByAccount.UseVisualStyleBackColor = false;
            this.btnGetByAccount.Click += new System.EventHandler(this.btnGetByAccount_Click);
            // 
            // btnExists
            // 
            this.btnExists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnExists.FlatAppearance.BorderSize = 0;
            this.btnExists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExists.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExists.ForeColor = System.Drawing.Color.White;
            this.btnExists.Location = new System.Drawing.Point(18, 13);
            this.btnExists.Name = "btnExists";
            this.btnExists.Size = new System.Drawing.Size(96, 30);
            this.btnExists.TabIndex = 0;
            this.btnExists.Text = "检查账号";
            this.btnExists.UseVisualStyleBackColor = false;
            this.btnExists.Click += new System.EventHandler(this.btnExists_Click);
            // 
            // panelUserLeft
            // 
            this.panelUserLeft.Controls.Add(this.panelUserSearch);
            this.panelUserLeft.Controls.Add(this.panelUserEditor);
            this.panelUserLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserLeft.Location = new System.Drawing.Point(0, 0);
            this.panelUserLeft.Name = "panelUserLeft";
            this.panelUserLeft.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelUserLeft.Size = new System.Drawing.Size(310, 667);
            this.panelUserLeft.TabIndex = 0;
            // 
            // panelUserSearch
            // 
            this.panelUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelUserSearch.Controls.Add(this.btnSearchUser);
            this.panelUserSearch.Controls.Add(this.txtSearchUserName);
            this.panelUserSearch.Controls.Add(this.lblSearchTitle);
            this.panelUserSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserSearch.Location = new System.Drawing.Point(0, 422);
            this.panelUserSearch.Name = "panelUserSearch";
            this.panelUserSearch.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelUserSearch.Size = new System.Drawing.Size(300, 245);
            this.panelUserSearch.TabIndex = 1;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(168)))));
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(166, 136);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(104, 34);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "搜索";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.txtSearchUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUserName.ForeColor = System.Drawing.Color.White;
            this.txtSearchUserName.Location = new System.Drawing.Point(23, 52);
            this.txtSearchUserName.Multiline = true;
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(247, 64);
            this.txtSearchUserName.TabIndex = 1;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.White;
            this.lblSearchTitle.Location = new System.Drawing.Point(19, 20);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(121, 19);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "搜索用户名称：";
            // 
            // panelUserEditor
            // 
            this.panelUserEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelUserEditor.Controls.Add(this.btnLogin);
            this.panelUserEditor.Controls.Add(this.btnRegister);
            this.panelUserEditor.Controls.Add(this.txtUserName);
            this.panelUserEditor.Controls.Add(this.lblUserName);
            this.panelUserEditor.Controls.Add(this.txtConfirmPassword);
            this.panelUserEditor.Controls.Add(this.lblConfirmPassword);
            this.panelUserEditor.Controls.Add(this.cmbPermission);
            this.panelUserEditor.Controls.Add(this.lblPermission);
            this.panelUserEditor.Controls.Add(this.txtPassword);
            this.panelUserEditor.Controls.Add(this.lblPassword);
            this.panelUserEditor.Controls.Add(this.txtAccount);
            this.panelUserEditor.Controls.Add(this.lblAccount);
            this.panelUserEditor.Controls.Add(this.lblUserEditorTitle);
            this.panelUserEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserEditor.Location = new System.Drawing.Point(0, 0);
            this.panelUserEditor.Name = "panelUserEditor";
            this.panelUserEditor.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelUserEditor.Size = new System.Drawing.Size(300, 422);
            this.panelUserEditor.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(154, 343);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 36);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登录测试";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(164)))), ((int)(((byte)(79)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(23, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 36);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(23, 287);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(19, 263);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "用户名：";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(23, 227);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(247, 23);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(19, 203);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(79, 20);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "确认密码：";
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Location = new System.Drawing.Point(23, 167);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(247, 25);
            this.cmbPermission.TabIndex = 6;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblPermission.ForeColor = System.Drawing.Color.White;
            this.lblPermission.Location = new System.Drawing.Point(19, 143);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(65, 20);
            this.lblPermission.TabIndex = 5;
            this.lblPermission.Text = "权限类型";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(23, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(19, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "密码：";
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.ForeColor = System.Drawing.Color.White;
            this.txtAccount.Location = new System.Drawing.Point(23, 49);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(247, 23);
            this.txtAccount.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(19, 25);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(51, 20);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "账号：";
            // 
            // lblUserEditorTitle
            // 
            this.lblUserEditorTitle.AutoSize = true;
            this.lblUserEditorTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUserEditorTitle.ForeColor = System.Drawing.Color.White;
            this.lblUserEditorTitle.Location = new System.Drawing.Point(18, -1);
            this.lblUserEditorTitle.Name = "lblUserEditorTitle";
            this.lblUserEditorTitle.Size = new System.Drawing.Size(88, 26);
            this.lblUserEditorTitle.TabIndex = 0;
            this.lblUserEditorTitle.Text = "用户区域";
            // 
            // panelDeviceModule
            // 
            this.panelDeviceModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelDeviceModule.Controls.Add(this.panelDeviceCard);
            this.panelDeviceModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeviceModule.Location = new System.Drawing.Point(0, 0);
            this.panelDeviceModule.Name = "panelDeviceModule";
            this.panelDeviceModule.Size = new System.Drawing.Size(1336, 667);
            this.panelDeviceModule.TabIndex = 2;
            this.panelDeviceModule.Visible = false;
            // 
            // panelDeviceCard
            // 
            this.panelDeviceCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(68)))), ((int)(((byte)(118)))));
            this.panelDeviceCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeviceCard.Controls.Add(this.lblDeviceDescription);
            this.panelDeviceCard.Controls.Add(this.lblDeviceTitle);
            this.panelDeviceCard.Location = new System.Drawing.Point(42, 36);
            this.panelDeviceCard.Name = "panelDeviceCard";
            this.panelDeviceCard.Size = new System.Drawing.Size(466, 160);
            this.panelDeviceCard.TabIndex = 0;
            // 
            // lblDeviceDescription
            // 
            this.lblDeviceDescription.AutoSize = true;
            this.lblDeviceDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblDeviceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblDeviceDescription.Location = new System.Drawing.Point(26, 78);
            this.lblDeviceDescription.Name = "lblDeviceDescription";
            this.lblDeviceDescription.Size = new System.Drawing.Size(279, 20);
            this.lblDeviceDescription.TabIndex = 1;
            this.lblDeviceDescription.Text = "设备模块区域，可放置手动控制与运行状态面板。";
            // 
            // lblDeviceTitle
            // 
            this.lblDeviceTitle.AutoSize = true;
            this.lblDeviceTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDeviceTitle.ForeColor = System.Drawing.Color.White;
            this.lblDeviceTitle.Location = new System.Drawing.Point(24, 28);
            this.lblDeviceTitle.Name = "lblDeviceTitle";
            this.lblDeviceTitle.Size = new System.Drawing.Size(110, 31);
            this.lblDeviceTitle.TabIndex = 0;
            this.lblDeviceTitle.Text = "设备区域";
            // 
            // panelDataModule
            // 
            this.panelDataModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelDataModule.Controls.Add(this.panelDataCard);
            this.panelDataModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataModule.Location = new System.Drawing.Point(0, 0);
            this.panelDataModule.Name = "panelDataModule";
            this.panelDataModule.Size = new System.Drawing.Size(1336, 667);
            this.panelDataModule.TabIndex = 1;
            this.panelDataModule.Visible = false;
            // 
            // panelDataCard
            // 
            this.panelDataCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(68)))), ((int)(((byte)(118)))));
            this.panelDataCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataCard.Controls.Add(this.lblDataDescription);
            this.panelDataCard.Controls.Add(this.lblDataTitle);
            this.panelDataCard.Location = new System.Drawing.Point(42, 36);
            this.panelDataCard.Name = "panelDataCard";
            this.panelDataCard.Size = new System.Drawing.Size(466, 160);
            this.panelDataCard.TabIndex = 0;
            // 
            // lblDataDescription
            // 
            this.lblDataDescription.AutoSize = true;
            this.lblDataDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblDataDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblDataDescription.Location = new System.Drawing.Point(26, 78);
            this.lblDataDescription.Name = "lblDataDescription";
            this.lblDataDescription.Size = new System.Drawing.Size(264, 20);
            this.lblDataDescription.TabIndex = 1;
            this.lblDataDescription.Text = "数据模块区域，可放置报表、趋势图和检索表格。";
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.AutoSize = true;
            this.lblDataTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDataTitle.ForeColor = System.Drawing.Color.White;
            this.lblDataTitle.Location = new System.Drawing.Point(24, 28);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(110, 31);
            this.lblDataTitle.TabIndex = 0;
            this.lblDataTitle.Text = "数据区域";
            // 
            // panelMonitorModule
            // 
            this.panelMonitorModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelMonitorModule.Controls.Add(this.panelMonitorCard);
            this.panelMonitorModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitorModule.Location = new System.Drawing.Point(0, 0);
            this.panelMonitorModule.Name = "panelMonitorModule";
            this.panelMonitorModule.Size = new System.Drawing.Size(1336, 667);
            this.panelMonitorModule.TabIndex = 0;
            this.panelMonitorModule.Visible = false;
            // 
            // panelMonitorCard
            // 
            this.panelMonitorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(68)))), ((int)(((byte)(118)))));
            this.panelMonitorCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMonitorCard.Controls.Add(this.lblMonitorDescription);
            this.panelMonitorCard.Controls.Add(this.lblMonitorTitle);
            this.panelMonitorCard.Location = new System.Drawing.Point(42, 36);
            this.panelMonitorCard.Name = "panelMonitorCard";
            this.panelMonitorCard.Size = new System.Drawing.Size(466, 160);
            this.panelMonitorCard.TabIndex = 0;
            // 
            // lblMonitorDescription
            // 
            this.lblMonitorDescription.AutoSize = true;
            this.lblMonitorDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.lblMonitorDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.lblMonitorDescription.Location = new System.Drawing.Point(26, 78);
            this.lblMonitorDescription.Name = "lblMonitorDescription";
            this.lblMonitorDescription.Size = new System.Drawing.Size(279, 20);
            this.lblMonitorDescription.TabIndex = 1;
            this.lblMonitorDescription.Text = "监视模块区域，可放置设备总览、报警列表和状态卡片。";
            // 
            // lblMonitorTitle
            // 
            this.lblMonitorTitle.AutoSize = true;
            this.lblMonitorTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMonitorTitle.ForeColor = System.Drawing.Color.White;
            this.lblMonitorTitle.Location = new System.Drawing.Point(24, 28);
            this.lblMonitorTitle.Name = "lblMonitorTitle";
            this.lblMonitorTitle.Size = new System.Drawing.Size(110, 31);
            this.lblMonitorTitle.TabIndex = 0;
            this.lblMonitorTitle.Text = "监视区域";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1364, 801);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelStatusBar);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1280, 840);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工控系统主界面";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelStatusBar.ResumeLayout(false);
            this.panelStatusBar.PerformLayout();
            this.panelMainContainer.ResumeLayout(false);
            this.panelModuleHost.ResumeLayout(false);
            this.panelSettingModule.ResumeLayout(false);
            this.panelSettingCard.ResumeLayout(false);
            this.panelSettingCard.PerformLayout();
            this.panelUserModule.ResumeLayout(false);
            this.panelUserRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelUserLog.ResumeLayout(false);
            this.panelUserLog.PerformLayout();
            this.panelUserToolbar.ResumeLayout(false);
            this.panelUserLeft.ResumeLayout(false);
            this.panelUserSearch.ResumeLayout(false);
            this.panelUserSearch.PerformLayout();
            this.panelUserEditor.ResumeLayout(false);
            this.panelUserEditor.PerformLayout();
            this.panelDeviceModule.ResumeLayout(false);
            this.panelDeviceCard.ResumeLayout(false);
            this.panelDeviceCard.PerformLayout();
            this.panelDataModule.ResumeLayout(false);
            this.panelDataCard.ResumeLayout(false);
            this.panelDataCard.PerformLayout();
            this.panelMonitorModule.ResumeLayout(false);
            this.panelMonitorCard.ResumeLayout(false);
            this.panelMonitorCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnNavExit;
        private System.Windows.Forms.Button btnNavSetting;
        private System.Windows.Forms.Button btnNavUser;
        private System.Windows.Forms.Button btnNavDevice;
        private System.Windows.Forms.Button btnNavData;
        private System.Windows.Forms.Button btnNavMonitor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelStatusBar;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTimeCaption;
        private System.Windows.Forms.Label lblCurrentUserValue;
        private System.Windows.Forms.Label lblCurrentUserCaption;
        private System.Windows.Forms.Label lblSystemStatusValue;
        private System.Windows.Forms.Label lblSystemStatusCaption;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelModuleHost;
        private System.Windows.Forms.Panel panelSettingModule;
        private System.Windows.Forms.Panel panelSettingCard;
        private System.Windows.Forms.Label lblSettingDescription;
        private System.Windows.Forms.Label lblSettingTitle;
        private System.Windows.Forms.Panel panelUserModule;
        private System.Windows.Forms.Panel panelUserRight;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelUserLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelUserToolbar;
        private System.Windows.Forms.Button btnLogTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetByAccount;
        private System.Windows.Forms.Button btnExists;
        private System.Windows.Forms.Panel panelUserLeft;
        private System.Windows.Forms.Panel panelUserSearch;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Panel panelUserEditor;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblUserEditorTitle;
        private System.Windows.Forms.Panel panelDeviceModule;
        private System.Windows.Forms.Panel panelDeviceCard;
        private System.Windows.Forms.Label lblDeviceDescription;
        private System.Windows.Forms.Label lblDeviceTitle;
        private System.Windows.Forms.Panel panelDataModule;
        private System.Windows.Forms.Panel panelDataCard;
        private System.Windows.Forms.Label lblDataDescription;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Panel panelMonitorModule;
        private System.Windows.Forms.Panel panelMonitorCard;
        private System.Windows.Forms.Label lblMonitorDescription;
        private System.Windows.Forms.Label lblMonitorTitle;
        private System.Windows.Forms.Timer timerClock;
    }
}

