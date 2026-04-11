using System;
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

        public MainForm()
        {
            _userService = new UserService();
            InitializeComponent();
            InitializeLogOutput();
            InitializePermissionOptions();
            InitializeNavigation();
            InitializeClock();
            LoadUserList();
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
