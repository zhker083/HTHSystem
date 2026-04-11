using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLogHelper = LogHelper.LogHelper;

namespace HTHSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                CommonLogHelper.RegisterLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "日志系统初始化失败：" + ex.Message,
                    "启动提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            Application.Run(new FormUserLogin());
        }
    }
}
