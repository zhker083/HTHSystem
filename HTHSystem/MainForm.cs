using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using CommonLogHelper = LogHelper.LogHelper;
using CommonLogLevel = LogHelper.LogLevel;
using Models;

namespace HTHSystem
{
    public partial class MainForm : Form
    {
        private readonly IUserService _userService;
        private DataTable _userTableSnapshot;
        private readonly Random _random = new Random();

        public MainForm()
        {
            _userService = new UserService();
            InitializeComponent();
            InitializeLogOutput();
            InitializePermissionOptions();
            InitializeNavigation();
            InitializeClock();
            InitializeScreenStyles();
            InitializeMonitorModule();
            InitializeDataModule();
            InitializeProcessModule();
            LoadUserList();
            btnSearchUser.Click += btnSearchUser_Click;
            CommonLogHelper.LogInfo("主界面已初始化。");
        }

        private void InitializeNavigation()
        {
            ShowModule(panelUserModule, btnNavUser);
            lblSystemStatusValue.Text = "已启动";
        }

        private void InitializeClock()
        {
            UpdateCurrentTime();
            timerClock.Start();
        }

        private void InitializeLogOutput()
        {
            CommonLogHelper.InitializeTextBox(txtMessage);
        }

        private void InitializePermissionOptions()
        {
            cmbPermission.DataSource = Enum.GetValues(typeof(Permission));
            cmbPermission.SelectedIndex = 0;
        }

        private void LoadUserList()
        {
            _userTableSnapshot = _userService.GetList();
            dgvUsers.DataSource = _userTableSnapshot;
            dgvUsers.ClearSelection();
        }

        private void InitializeScreenStyles()
        {
            lblTitle.Text = "翰庭汇-电池测量监视";
            btnNavDevice.Text = "流程";
            btnNavSetting.Text = "设置";
            btnNavUser.Text = "用户";
            btnNavMonitor.Text = "监视";
            btnNavData.Text = "数据";
            lblCurrentUserCaption.Text = "登录用户：";
            lblCurrentUserValue.Text = "张三";
        }

        private void InitializeMonitorModule()
        {
            panelMonitorCard.Controls.Clear();
            panelMonitorCard.Dock = DockStyle.Fill;
            panelMonitorCard.Location = new Point(0, 0);
            panelMonitorCard.Size = panelMonitorModule.ClientSize;
            panelMonitorCard.Padding = new Padding(0);

            var leftPanel = new Panel { Dock = DockStyle.Left, Width = 440, BackColor = Color.FromArgb(12, 47, 90) };
            var rightPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(15, 52, 96) };
            panelMonitorCard.Controls.Add(rightPanel);
            panelMonitorCard.Controls.Add(leftPanel);

            var lblDay = new Label { Text = "今日数据", ForeColor = Color.White, Location = new Point(10, 10), AutoSize = true };
            var lblOutput = new Label { Text = "产量：11", ForeColor = Color.White, Location = new Point(26, 36), AutoSize = true };
            var lblOk = new Label { Text = "良品：54.54%", ForeColor = Color.White, Location = new Point(170, 36), AutoSize = true };
            var lblNg = new Label { Text = "NG率：45.46%", ForeColor = Color.White, Location = new Point(318, 36), AutoSize = true };
            leftPanel.Controls.Add(lblDay);
            leftPanel.Controls.Add(lblOutput);
            leftPanel.Controls.Add(lblOk);
            leftPanel.Controls.Add(lblNg);

            var monitorGrid = new DataGridView
            {
                Dock = DockStyle.Bottom,
                Height = 560,
                BackgroundColor = Color.FromArgb(12, 47, 90),
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            monitorGrid.Columns.Add("Status", "状态");
            monitorGrid.Columns.Add("Measure", "测量值");
            monitorGrid.Columns.Add("Result", "产品情况");
            for (int i = 0; i < 11; i++)
            {
                int value = _random.Next(2, 12);
                string result = value >= 6 ? "OK" : "NG";
                monitorGrid.Rows.Add(result == "OK" ? "🟢" : "🔴", value, result);
            }
            leftPanel.Controls.Add(monitorGrid);

            var chartTitle = new Label { Text = "产量曲线", ForeColor = Color.White, Location = new Point(8, 8), AutoSize = true };
            var chartHost = new Panel { Location = new Point(8, 30), Size = new Size(730, 360), BackColor = Color.FromArgb(42, 84, 125) };
            chartHost.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.Clear(Color.FromArgb(63, 101, 138));
                using (var pen = new Pen(Color.FromArgb(38, 61, 82), 1))
                {
                    for (int x = 0; x <= 7; x++) g.DrawLine(pen, 60 + x * 82, 20, 60 + x * 82, 320);
                    for (int y = 0; y <= 6; y++) g.DrawLine(pen, 60, 20 + y * 50, 640, 20 + y * 50);
                }
                DrawLine(g, new[] { 7, 7, 7, 6, 8, 10 }, Color.Gold);
                DrawLine(g, new[] { 4, 3, 2, 4, 11 }, Color.Silver);
            };
            rightPanel.Controls.Add(chartTitle);
            rightPanel.Controls.Add(chartHost);

            var logPanel = new Panel { Dock = DockStyle.Bottom, Height = 240, BackColor = Color.FromArgb(12, 47, 90) };
            var logTitle = new Label { Text = "日志", ForeColor = Color.White, Location = new Point(8, 8), AutoSize = true };
            var logBox = new TextBox { Multiline = true, Dock = DockStyle.Bottom, Height = 208, BackColor = Color.FromArgb(8, 37, 72), ForeColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
            logBox.Text = "修改日志\r\n报警日志";
            logPanel.Controls.Add(logTitle);
            logPanel.Controls.Add(logBox);
            rightPanel.Controls.Add(logPanel);
        }

        private void InitializeDataModule()
        {
            panelDataCard.Controls.Clear();
            panelDataCard.Dock = DockStyle.Fill;
            panelDataCard.Location = new Point(0, 0);
            panelDataCard.Size = panelDataModule.ClientSize;

            var leftPanel = new Panel { Dock = DockStyle.Left, Width = 220, BackColor = Color.FromArgb(12, 47, 90) };
            var rightGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.FromArgb(15, 52, 96)
            };
            rightGrid.Columns.Add("No", "产品序号");
            rightGrid.Columns.Add("Value", "测量值");
            rightGrid.Columns.Add("Status", "产品状态");
            rightGrid.Columns.Add("Date", "日期");
            for (int i = 1; i <= 30; i++)
            {
                double value = 5 + _random.NextDouble() * 5;
                rightGrid.Rows.Add(i, value.ToString("0.0000"), "OK", DateTime.Today.ToString("yyyy/MM/dd"));
            }
            panelDataCard.Controls.Add(rightGrid);
            panelDataCard.Controls.Add(leftPanel);

            leftPanel.Controls.Add(new Label { Text = "开始：", ForeColor = Color.White, Location = new Point(12, 34), AutoSize = true });
            leftPanel.Controls.Add(new DateTimePicker { Location = new Point(55, 29), Width = 150 });
            leftPanel.Controls.Add(new Label { Text = "结束：", ForeColor = Color.White, Location = new Point(12, 96), AutoSize = true });
            leftPanel.Controls.Add(new DateTimePicker { Location = new Point(55, 91), Width = 150, Value = DateTime.Today });
            leftPanel.Controls.Add(new CheckBox { Text = "NG", ForeColor = Color.White, Location = new Point(60, 150), AutoSize = true });
            leftPanel.Controls.Add(new CheckBox { Text = "OK", ForeColor = Color.White, Location = new Point(140, 150), AutoSize = true, Checked = true });
            leftPanel.Controls.Add(new Label { Text = "根据产量长度搜索:", ForeColor = Color.White, Location = new Point(12, 230), AutoSize = true });
            var searchBox = new TextBox { Multiline = true, Location = new Point(12, 255), Size = new Size(180, 96), BackColor = Color.FromArgb(18, 56, 96), ForeColor = Color.White };
            leftPanel.Controls.Add(searchBox);
            leftPanel.Controls.Add(new Button { Text = "搜索", Location = new Point(122, 390), Width = 70, Height = 32, BackColor = Color.FromArgb(47, 112, 168), ForeColor = Color.White, FlatStyle = FlatStyle.Flat });
            leftPanel.Controls.Add(new Button { Text = "CSV导出", Location = new Point(102, 450), Width = 90, Height = 32, BackColor = Color.FromArgb(47, 112, 168), ForeColor = Color.White, FlatStyle = FlatStyle.Flat });
        }

        private void InitializeProcessModule()
        {
            panelDeviceCard.Controls.Clear();
            panelDeviceCard.Dock = DockStyle.Fill;
            panelDeviceCard.Location = new Point(0, 0);
            panelDeviceCard.Size = panelDeviceModule.ClientSize;

            var cfgGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.FromArgb(15, 52, 96),
                BorderStyle = BorderStyle.None
            };
            cfgGrid.Columns.Add("Key", "通信设置");
            cfgGrid.Columns.Add("Value", "值");
            cfgGrid.Rows.Add("ConnectTionimeout", "50");
            cfgGrid.Rows.Add("IP", "127.0.0.1");
            cfgGrid.Rows.Add("Port", "5000");
            cfgGrid.Rows.Add("ScanPeriod", "21");
            panelDeviceCard.Controls.Add(cfgGrid);

            var footer = new Panel { Dock = DockStyle.Bottom, Height = 80, BackColor = Color.FromArgb(12, 47, 90) };
            footer.Controls.Add(new Label { Text = "ConnectTionimeout", ForeColor = Color.FromArgb(112, 193, 214), Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold), Location = new Point(6, 8), AutoSize = true });
            footer.Controls.Add(new Label { Text = "连接超时时间", ForeColor = Color.FromArgb(112, 193, 214), Location = new Point(6, 34), AutoSize = true });
            footer.Controls.Add(new Button { Text = "保存", Width = 86, Height = 30, Location = new Point(1230, 24) });
            panelDeviceCard.Controls.Add(footer);
        }

        private static void DrawLine(Graphics g, int[] points, Color color)
        {
            if (points == null || points.Length < 2)
            {
                return;
            }

            using (var pen = new Pen(color, 2))
            {
                for (int i = 0; i < points.Length - 1; i++)
                {
                    int x1 = 60 + i * 82;
                    int x2 = 60 + (i + 1) * 82;
                    int y1 = 320 - points[i] * 25;
                    int y2 = 320 - points[i + 1] * 25;
                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                string account;
                if (!TryGetAccount(out account))
                {
                    return;
                }

                string password;
                if (!TryGetPassword(out password))
                {
                    return;
                }

                UserInfo user = new UserInfo
                {
                    Account = account,
                    Password = password,
                    Permission = (Permission)cmbPermission.SelectedItem
                };

                int result = _userService.Register(user);
                LoadUserList();
                txtPassword.Clear();
                ShowMessage(result > 0 ? "注册成功，已写入数据库。" : "注册失败，没有写入任何记录。");
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                string account;
                if (!TryGetAccount(out account))
                {
                    return;
                }

                string password;
                if (!TryGetPassword(out password))
                {
                    return;
                }

                UserInfo user = _userService.Login(account, password);
                if (user == null)
                {
                    ShowMessage("登录失败，账号或密码错误。");
                    return;
                }

                cmbPermission.SelectedItem = user.Permission;
                ShowMessage(string.Format("登录成功。账号：{0}，权限：{1}。", user.Account, user.Permission));
            });
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                string account;
                if (!TryGetAccount(out account))
                {
                    return;
                }

                bool exists = _userService.Exists(account);
                ShowMessage(exists ? "账号已存在。" : "账号不存在。");
            });
        }

        private void btnGetByAccount_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                string account;
                if (!TryGetAccount(out account))
                {
                    return;
                }

                UserInfo user = _userService.GetByAccount(account);
                if (user == null)
                {
                    ShowMessage("未查询到该账号。", true);
                    return;
                }

                txtAccount.Text = user.Account;
                cmbPermission.SelectedItem = user.Permission;
                txtPassword.Clear();
                ShowMessage(string.Format("查询成功。账号：{0}，权限：{1}。", user.Account, user.Permission));
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                string account;
                if (!TryGetAccount(out account))
                {
                    return;
                }

                int result = _userService.Delete(account);
                LoadUserList();
                txtPassword.Clear();
                ShowMessage(result > 0 ? "删除成功。" : "未删除任何记录，请确认账号是否存在。", true);
            });
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                LoadUserList();
                ShowMessage("已重新加载用户列表。", true);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtPassword.Clear();
            cmbPermission.SelectedIndex = 0;
            txtAccount.Focus();
            CommonLogHelper.LogInfo("已清空输入内容。");
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchUserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvUsers.DataSource = _userTableSnapshot;
                return;
            }

            if (_userTableSnapshot == null)
            {
                return;
            }

            DataTable filtered = _userTableSnapshot.Clone();
            foreach (DataRow row in _userTableSnapshot.Rows)
            {
                string account = row["Account"]?.ToString() ?? string.Empty;
                string permission = row.Table.Columns.Contains("PermissionName")
                    ? row["PermissionName"]?.ToString() ?? string.Empty
                    : string.Empty;

                if (account.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    permission.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filtered.ImportRow(row);
                }
            }

            dgvUsers.DataSource = filtered;
            ShowMessage($"按关键字“{keyword}”查询到 {filtered.Rows.Count} 条记录。", true);
        }

        private void btnLogTest_Click(object sender, EventArgs e)
        {
            CommonLogHelper.LogInfo("开始执行日志测试。");
            CommonLogHelper.Log("UI", "这是一个日志测试信息。", CommonLogLevel.Info);
            CommonLogHelper.Log("UI", "这是一个日志测试警告。", CommonLogLevel.Warn);
            CommonLogHelper.Log("UI", "日志测试已完成。", CommonLogLevel.Info);
        }

        private bool TryGetAccount(out string account)
        {
            account = txtAccount.Text.Trim();
            if (!string.IsNullOrWhiteSpace(account))
            {
                return true;
            }

            ShowMessage("请输入账号。", false, CommonLogLevel.Warn);
            txtAccount.Focus();
            return false;
        }

        private bool TryGetPassword(out string password)
        {
            password = txtPassword.Text;
            if (!string.IsNullOrWhiteSpace(password))
            {
                return true;
            }

            ShowMessage("请输入密码。", false, CommonLogLevel.Warn);
            txtPassword.Focus();
            return false;
        }

        private void ExecuteAction(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                CommonLogHelper.LogError("界面操作执行失败。", ex);
                ShowMessage("操作失败：" + ex.Message, true, CommonLogLevel.Error);
            }
        }

        private void ShowMessage(string message, bool appendDataSourceHint = false, CommonLogLevel level = CommonLogLevel.Info)
        {
            string finalMessage = message;

            if (appendDataSourceHint)
            {
                finalMessage = message + " 当前结果来自 UI -> BLL -> DAL -> SQL Server。";
            }

            CommonLogHelper.Log("UI", finalMessage, level);
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            Button activeButton = sender as Button;
            if (activeButton == null)
            {
                return;
            }

            if (activeButton == btnNavMonitor)
            {
                ShowModule(panelMonitorModule, btnNavMonitor);
                return;
            }

            if (activeButton == btnNavData)
            {
                ShowModule(panelDataModule, btnNavData);
                return;
            }

            if (activeButton == btnNavDevice)
            {
                ShowModule(panelDeviceModule, btnNavDevice);
                return;
            }

            if (activeButton == btnNavUser)
            {
                ShowModule(panelUserModule, btnNavUser);
                return;
            }

            if (activeButton == btnNavSetting)
            {
                ShowModule(panelSettingModule, btnNavSetting);
            }
        }

        private void ShowModule(Panel targetPanel, Button activeButton)
        {
            panelMonitorModule.Visible = false;
            panelDataModule.Visible = false;
            panelDeviceModule.Visible = false;
            panelUserModule.Visible = false;
            panelSettingModule.Visible = false;

            btnNavMonitor.BackColor = System.Drawing.Color.FromArgb(25, 76, 123);
            btnNavData.BackColor = System.Drawing.Color.FromArgb(25, 76, 123);
            btnNavDevice.BackColor = System.Drawing.Color.FromArgb(25, 76, 123);
            btnNavUser.BackColor = System.Drawing.Color.FromArgb(25, 76, 123);
            btnNavSetting.BackColor = System.Drawing.Color.FromArgb(25, 76, 123);

            targetPanel.Visible = true;
            targetPanel.BringToFront();
            activeButton.BackColor = System.Drawing.Color.FromArgb(16, 129, 255);
        }

        private void btnNavExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }

        private void UpdateCurrentTime()
        {
            lblTimeValue.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

    }
}
