using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using Models;

namespace HTHSystem
{
    public partial class MainForm : Form
    {
        private readonly IUserBll _userBll;

        public MainForm()
        {
            _userBll = new UserBll();
            InitializeComponent();
            InitializePermissionOptions();
            LoadUserList();
        }

        private void InitializePermissionOptions()
        {
            List<KeyValuePair<string, UserPermission>> permissions = new List<KeyValuePair<string, UserPermission>>
            {
                new KeyValuePair<string, UserPermission>("员工", UserPermission.Staff),
                new KeyValuePair<string, UserPermission>("技术员", UserPermission.Technician),
                new KeyValuePair<string, UserPermission>("工程师", UserPermission.Engineer)
            };

            cmbPermission.DisplayMember = "Key";
            cmbPermission.ValueMember = "Value";
            cmbPermission.DataSource = permissions;
            cmbPermission.SelectedIndex = 0;
        }

        private void LoadUserList()
        {
            dgvUsers.DataSource = _userBll.GetList();
            dgvUsers.ClearSelection();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                UserInfo user = new UserInfo
                {
                    Account = txtAccount.Text.Trim(),
                    Password = txtPassword.Text,
                    Permission = (UserPermission)cmbPermission.SelectedValue
                };

                int result = _userBll.Register(user);
                LoadUserList();
                txtPassword.Clear();
                ShowMessage(result > 0 ? "注册成功，已写入数据库。" : "注册失败，没有写入任何记录。");
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                UserInfo user = _userBll.Login(txtAccount.Text.Trim(), txtPassword.Text);
                if (user == null)
                {
                    ShowMessage("登录失败，账号或密码错误。");
                    return;
                }

                cmbPermission.SelectedValue = user.Permission;
                ShowMessage(string.Format("登录成功。账号：{0}，权限：{1}。", user.Account, GetPermissionText(user.Permission)));
            });
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                bool exists = _userBll.Exists(txtAccount.Text.Trim());
                ShowMessage(exists ? "账号已存在。" : "账号不存在。");
            });
        }

        private void btnGetByAccount_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                UserInfo user = _userBll.GetByAccount(txtAccount.Text.Trim());
                if (user == null)
                {
                    ShowMessage("未查询到该账号。", true);
                    return;
                }

                txtAccount.Text = user.Account;
                cmbPermission.SelectedValue = user.Permission;
                txtPassword.Clear();
                ShowMessage(string.Format("查询成功。账号：{0}，权限：{1}。", user.Account, GetPermissionText(user.Permission)));
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExecuteAction(() =>
            {
                int result = _userBll.Delete(txtAccount.Text.Trim());
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
            txtMessage.Clear();
            txtAccount.Focus();
        }

        private void ExecuteAction(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                ShowMessage("操作失败：" + ex.Message);
            }
        }

        private void ShowMessage(string message, bool appendDataSourceHint = false)
        {
            if (appendDataSourceHint)
            {
                txtMessage.Text = message + Environment.NewLine + "当前结果来自 UI -> BLL -> DAL -> SQL Server。";
                return;
            }

            txtMessage.Text = message;
        }

        private static string GetPermissionText(UserPermission permission)
        {
            switch (permission)
            {
                case UserPermission.Staff:
                    return "员工";
                case UserPermission.Technician:
                    return "技术员";
                case UserPermission.Engineer:
                    return "工程师";
                default:
                    return "未知";
            }
        }
    }
}
