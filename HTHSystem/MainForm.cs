using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using CommonLogHelper = LogHelper.LogHelper;
using CommonLogLevel = LogHelper.LogLevel;
using Models;

namespace HTHSystem
{
    public partial class MainForm : Form
    {
        private readonly IUserService _userService;
        private Button[] _navigationButtons;
        private Panel[] _modulePanels;
        private int _currentModuleIndex;

        public MainForm()
        {
            bool isDesignMode = IsDesignMode();
            _userService = isDesignMode ? null : (IUserService)new UserService();
            InitializeComponent();

            if (isDesignMode)
            {
                return;
            }

            InitializeLogOutput();
            InitializePermissionOptions();
            InitializeModuleData();
            InitializeNavigation();
            InitializeClock();
            LoadUserList();
            CommonLogHelper.LogInfo("主界面已初始化。");
        }

        private static bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void InitializeModuleData()
        {
            InitializeDataModule();
            InitializeMonitorModule();
            InitializeSettingModule();
        }

        private void InitializeNavigation()
        {
            _navigationButtons = new[] { btnNavMonitor, btnNavData, btnNavDevice, btnNavUser, btnNavSetting };
            _modulePanels = new[] { panelMonitorModule, panelDataModule, panelDeviceModule, panelUserModule, panelSettingModule };
            ShowModule(3);
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

        private void InitializeDataModule()
        {
            dtpDataStart.Value = DateTime.Today;
            dtpDataEnd.Value = DateTime.Today;
            checkBoxDataOk.Checked = true;
            checkBoxDataNg.Checked = false;
            dgvProductData.DataSource = CreateProductDataTableSchema();
            dgvProductData.ClearSelection();
        }

        private void InitializeMonitorModule()
        {
            lblMonitorTotalValue.Text = "--";
            lblMonitorGoodRateValue.Text = "--";
            lblMonitorNgRateValue.Text = "--";
            dgvMonitorSummary.DataSource = CreateMonitorSummaryTableSchema();
            dgvMonitorSummary.ClearSelection();
            txtModifyLog.Clear();
            txtAlarmLog.Clear();
            InitializeMonitorChart();
        }

        private void InitializeSettingModule()
        {
            dgvSettings.DataSource = CreateSettingTableSchema();
            dgvSettings.ClearSelection();
            lblSettingSelectedName.Text = string.Empty;
            txtSettingValue.Clear();
            txtSettingDescription.Clear();
        }

        private void InitializeMonitorChart()
        {
            chartMonitorTrend.Series.Clear();
            chartMonitorTrend.ChartAreas.Clear();
            chartMonitorTrend.Legends.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.FromArgb(18, 63, 111);
            chartArea.AxisX.LineColor = Color.FromArgb(140, 180, 220);
            chartArea.AxisY.LineColor = Color.FromArgb(140, 180, 220);
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(70, 110, 150);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(70, 110, 150);
            chartMonitorTrend.ChartAreas.Add(chartArea);

            Legend legend = new Legend("MainLegend");
            legend.BackColor = Color.FromArgb(18, 63, 111);
            legend.ForeColor = Color.White;
            chartMonitorTrend.Legends.Add(legend);

            Series okSeries = new Series("OK");
            okSeries.ChartType = SeriesChartType.Line;
            okSeries.BorderWidth = 3;
            okSeries.Color = Color.FromArgb(255, 225, 120);

            Series ngSeries = new Series("NG");
            ngSeries.ChartType = SeriesChartType.Line;
            ngSeries.BorderWidth = 2;
            ngSeries.Color = Color.FromArgb(245, 245, 245);

            chartMonitorTrend.Series.Add(okSeries);
            chartMonitorTrend.Series.Add(ngSeries);
        }

        private static DataTable CreateProductDataTableSchema()
        {
            DataTable table = new DataTable();
            table.Columns.Add("产品序号");
            table.Columns.Add("测量值");
            table.Columns.Add("产品状态");
            table.Columns.Add("日期");
            return table;
        }

        private static DataTable CreateMonitorSummaryTableSchema()
        {
            DataTable table = new DataTable();
            table.Columns.Add("状态");
            table.Columns.Add("测量值");
            table.Columns.Add("产品情况");
            return table;
        }

        private static DataTable CreateSettingTableSchema()
        {
            DataTable table = new DataTable();
            table.Columns.Add("配置项");
            table.Columns.Add("当前值");
            return table;
        }

        private void LoadUserList()
        {
            dgvUsers.DataSource = _userService.GetList();
            dgvUsers.ClearSelection();
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

            for (int i = 0; i < _navigationButtons.Length; i++)
            {
                if (activeButton == _navigationButtons[i])
                {
                    ShowModule(i);
                    return;
                }
            }
        }

        private void ShowModule(int moduleIndex)
        {
            _currentModuleIndex = moduleIndex;

            for (int i = 0; i < _modulePanels.Length; i++)
            {
                _modulePanels[i].Visible = i == moduleIndex;
                _navigationButtons[i].BackColor = i == moduleIndex
                    ? Color.FromArgb(16, 129, 255)
                    : Color.FromArgb(25, 76, 123);
            }

            _modulePanels[moduleIndex].BringToFront();
            lblModuleCaption.Text = _navigationButtons[moduleIndex].Text;
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

        private void btnFooterMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFooterSetting_Click(object sender, EventArgs e)
        {
            ShowModule(4);
        }

        private void btnPageLeft_Click(object sender, EventArgs e)
        {
            int nextIndex = _currentModuleIndex == 0 ? _modulePanels.Length - 1 : _currentModuleIndex - 1;
            ShowModule(nextIndex);
        }

        private void btnPageRight_Click(object sender, EventArgs e)
        {
            int nextIndex = _currentModuleIndex == _modulePanels.Length - 1 ? 0 : _currentModuleIndex + 1;
            ShowModule(nextIndex);
        }

        private void btnDataSearch_Click(object sender, EventArgs e)
        {
            ShowMessage("已按条件刷新数据列表。", false, CommonLogLevel.Info);
        }

        private void btnDataExport_Click(object sender, EventArgs e)
        {
            ShowMessage("已完成 CSV 导出示意操作。", false, CommonLogLevel.Info);
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            ShowMessage("已保存配置项：" + lblSettingSelectedName.Text + "。", false, CommonLogLevel.Info);
        }

        private void dgvSettings_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedSetting();
        }

        private void UpdateSelectedSetting()
        {
            if (dgvSettings.CurrentRow == null)
            {
                return;
            }

            object settingNameValue = dgvSettings.CurrentRow.Cells[0].Value;
            object settingCurrentValue = dgvSettings.CurrentRow.Cells[1].Value;

            string settingName = settingNameValue == null ? string.Empty : settingNameValue.ToString();
            string settingValue = settingCurrentValue == null ? string.Empty : settingCurrentValue.ToString();

            lblSettingSelectedName.Text = settingName;
            txtSettingValue.Text = settingValue;
            txtSettingDescription.Text = GetSettingDescription(settingName);
        }

        private static string GetSettingDescription(string settingName)
        {
            switch (settingName)
            {
                case "ConnectTimeout":
                    return "连接超时时间，单位为秒，用于控制客户端与设备建立通信时的等待时长。";
                case "IP":
                    return "设备或服务端的目标 IP 地址，用于 TCP/Socket 通信连接。";
                case "Port":
                    return "通信端口号，决定数据采集服务监听或连接的端口。";
                case "ScanPeriod":
                    return "扫描周期，单位可按项目约定解释，用于控制轮询读取数据的间隔。";
                default:
                    return "当前配置项暂无说明。";
            }
        }

    }
}
