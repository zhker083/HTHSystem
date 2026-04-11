using System;
using System.Windows.Forms;
using BLL;
using Models;

namespace HTHSystem
{
    public partial class FormUserLogin : Form
    {
        private readonly IUserService _userService;

        public FormUserLogin()
        {
            _userService = new UserService();
            InitializeComponent();
            LoadRememberedCredentials();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControlAuth.SelectedTab = tabPageRegister;
        }

        private void linkLabelBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControlAuth.SelectedTab = tabPageLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string account = textBoxLoginAccount.Text.Trim();
                string password = textBoxLoginPassword.Text;

                if (!ValidateLoginInput(account, password))
                {
                    return;
                }

                UserInfo user = _userService.Login(account, password);
                if (user == null)
                {
                    string errorMessage = _userService.Exists(account) ? "密码错误。" : "账号不存在。";
                    textBoxLoginPassword.Clear();
                    MessageBox.Show(errorMessage, "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxLoginPassword.Focus();
                    return;
                }

                MainForm mainForm = new MainForm();
                SaveRememberedCredentials(account, password);
                mainForm.FormClosed += MainForm_FormClosed;
                Hide();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string account = textBoxRegisterAccount.Text.Trim();
                string password = textBoxRegisterPassword.Text;
                string confirmPassword = textBoxRegisterConfirmPassword.Text;

                if (!ValidateRegisterInput(account, password, confirmPassword))
                {
                    return;
                }

                UserInfo user = new UserInfo
                {
                    Account = account,
                    Password = password,
                    Permission = Permission.员工
                };

                _userService.Register(user);

                MessageBox.Show("注册成功，请使用新账号登录。", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLoginAccount.Text = account;
                textBoxLoginPassword.Clear();
                textBoxRegisterPassword.Clear();
                textBoxRegisterConfirmPassword.Clear();
                tabControlAuth.SelectedTab = tabPageLogin;
                textBoxLoginPassword.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLoginInput(string account, string password)
        {
            if (string.IsNullOrWhiteSpace(account))
            {
                MessageBox.Show("请输入账号。", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLoginAccount.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("请输入密码。", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLoginPassword.Focus();
                return false;
            }

            if (!checkBoxAgreementLogin.Checked)
            {
                MessageBox.Show("请先阅读并同意服务协议。", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxAgreementLogin.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateRegisterInput(string account, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(account))
            {
                MessageBox.Show("请输入注册账号。", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegisterAccount.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("请输入注册密码。", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegisterPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("请输入确认密码。", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegisterConfirmPassword.Focus();
                return false;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("两次输入的密码不一致。", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegisterConfirmPassword.Clear();
                textBoxRegisterConfirmPassword.Focus();
                return false;
            }

            if (!checkBoxAgreementRegister.Checked)
            {
                MessageBox.Show("请先阅读并同意服务协议。", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxAgreementRegister.Focus();
                return false;
            }

            return true;
        }

        private void LoadRememberedCredentials()
        {
            bool rememberPasswordEnabled = Properties.Settings.Default.RememberPasswordEnabled;
            checkBoxRememberPassword.Checked = rememberPasswordEnabled;

            if (!rememberPasswordEnabled)
            {
                textBoxLoginAccount.Focus();
                return;
            }

            textBoxLoginAccount.Text = Properties.Settings.Default.RememberAccount;
            textBoxLoginPassword.Text = Properties.Settings.Default.RememberPassword;

            if (!string.IsNullOrWhiteSpace(textBoxLoginPassword.Text))
            {
                textBoxLoginPassword.SelectionStart = textBoxLoginPassword.TextLength;
                textBoxLoginPassword.Focus();
                return;
            }

            textBoxLoginAccount.Focus();
        }

        private void SaveRememberedCredentials(string account, string password)
        {
            Properties.Settings.Default.RememberPasswordEnabled = checkBoxRememberPassword.Checked;

            if (checkBoxRememberPassword.Checked)
            {
                Properties.Settings.Default.RememberAccount = account;
                Properties.Settings.Default.RememberPassword = password;
            }
            else
            {
                Properties.Settings.Default.RememberAccount = string.Empty;
                Properties.Settings.Default.RememberPassword = string.Empty;
            }

            Properties.Settings.Default.Save();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
