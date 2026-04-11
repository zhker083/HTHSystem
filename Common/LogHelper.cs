using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogHelper
{
    /// <summary>
    /// 日志辅助类，基于 log4net，支持输出到文件、ListView、TextBox
    /// </summary>
    public static class LogHelper
    {
        private static readonly ILog _logger = LogManager.GetLogger("logLogger");

        /// <summary>
        /// 记录已经添加过 Appender 的控件，避免重复注册
        /// </summary>
        private static readonly ConcurrentDictionary<object, byte> _registeredControls =
            new ConcurrentDictionary<object, byte>();

        /// <summary>
        /// 初始化日志系统，程序启动时优先调用
        /// </summary>
        public static void RegisterLog()
        {
            string configPath = Path.Combine(Application.StartupPath, "log4net.config");
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException(
                    "未找到 log4net.config 配置文件，请确保文件存在于程序根目录。",
                    configPath);
            }

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(configPath));

            // 启动后异步清理旧日志
            DeleteOldLogs(30);
        }

        /// <summary>
        /// 删除超过指定天数的旧日志文件
        /// </summary>
        /// <param name="keepDays">保留天数</param>
        public static void DeleteOldLogs(int keepDays)
        {
            if (keepDays < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(keepDays), "保留天数不能小于 0。");
            }

            Task.Run(() =>
            {
                try
                {
                    string folder = GetLogFolder();
                    if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
                    {
                        Debug.WriteLine($"日志目录不存在或无法获取：{folder}");
                        return;
                    }

                    DirectoryInfo dir = new DirectoryInfo(folder);
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        try
                        {
                            int days = (DateTime.Now - file.LastWriteTime).Days;
                            if (days > keepDays)
                            {
                                file.Delete();
                                Debug.WriteLine($"已删除过期日志文件：{file.FullName}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"删除日志文件失败：{file.FullName}，原因：{ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"清理日志目录时发生异常：{ex.Message}");
                }
            });
        }

        /// <summary>
        /// 获取日志文件所在目录
        /// </summary>
        public static string GetLogFolder()
        {
            Logger logger = _logger.Logger as Logger;
            RollingFileAppender appender = logger?.GetAppender("LogFile") as RollingFileAppender;

            if (appender == null || string.IsNullOrWhiteSpace(appender.File))
            {
                throw new InvalidOperationException(
                    "未找到名为 LogFile 的 RollingFileAppender，请检查 log4net.config 配置。");
            }

            return Path.GetDirectoryName(appender.File);
        }

        /// <summary>
        /// 绑定日志到 ListView
        /// </summary>
        public static void InitializeListView(ListView listView)
        {
            if (listView == null)
            {
                return;
            }

            if (!_registeredControls.TryAdd(listView, 0))
            {
                return;
            }

            Logger logger = _logger.Logger as Logger;
            if (logger == null)
            {
                return;
            }

            var appender = new ListViewAppender(listView)
            {
                Name = $"ListViewAppender_{listView.GetHashCode()}",
                Layout = new PatternLayout("%d{yyyy-MM-dd HH:mm:ss} [%-5p] %m%n")
            };

            logger.AddAppender(appender);
        }

        /// <summary>
        /// 绑定日志到 TextBox
        /// </summary>
        public static void InitializeTextBox(TextBox textBox)
        {
            if (textBox == null)
            {
                return;
            }

            if (!_registeredControls.TryAdd(textBox, 0))
            {
                return;
            }

            Logger logger = _logger.Logger as Logger;
            if (logger == null)
            {
                return;
            }

            var appender = new TextBoxAppender(textBox)
            {
                Name = $"TextBoxAppender_{textBox.GetHashCode()}",
                Layout = new PatternLayout("%d{yyyy-MM-dd HH:mm:ss} [%-5p] %m%n")
            };

            logger.AddAppender(appender);
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="message">日志内容</param>
        /// <param name="level">日志级别</param>
        public static void Log(string message, LogLevel level = LogLevel.Info)
        {
            if (message == null)
            {
                message = string.Empty;
            }

            switch (level)
            {
                case LogLevel.Debug:
                    _logger.Debug(message);
                    break;
                case LogLevel.Info:
                    _logger.Info(message);
                    break;
                case LogLevel.Warn:
                    _logger.Warn(message);
                    break;
                case LogLevel.Error:
                    _logger.Error(message);
                    break;
                case LogLevel.Fatal:
                    _logger.Fatal(message);
                    break;
                default:
                    _logger.Info(message);
                    break;
            }
        }

        /// <summary>
        /// 记录带异常信息的日志
        /// </summary>
        /// <param name="message">日志内容</param>
        /// <param name="exception">异常对象</param>
        /// <param name="level">日志级别</param>
        public static void Log(string message, Exception exception, LogLevel level = LogLevel.Error)
        {
            string logMessage = BuildLogMessage(message, null, exception);
            Log(logMessage, level);
        }

        /// <summary>
        /// 记录带分类的日志
        /// </summary>
        /// <param name="category">日志分类</param>
        /// <param name="message">日志内容</param>
        /// <param name="level">日志级别</param>
        public static void Log(string category, string message, LogLevel level)
        {
            string logMessage = BuildLogMessage(message, category, null);
            Log(logMessage, level);
        }

        /// <summary>
        /// 记录带分类和异常信息的日志
        /// </summary>
        /// <param name="category">日志分类</param>
        /// <param name="message">日志内容</param>
        /// <param name="exception">异常对象</param>
        /// <param name="level">日志级别</param>
        public static void Log(string category, string message, Exception exception, LogLevel level = LogLevel.Error)
        {
            string logMessage = BuildLogMessage(message, category, exception);
            Log(logMessage, level);
        }

        public static void LogDebug(string message)
        {
            Log(message, LogLevel.Debug);
        }

        public static void LogInfo(string message)
        {
            Log(message, LogLevel.Info);
        }

        public static void LogWarn(string message)
        {
            Log(message, LogLevel.Warn);
        }

        public static void LogError(string message)
        {
            Log(message, LogLevel.Error);
        }

        public static void LogError(string message, Exception exception)
        {
            Log(message, exception, LogLevel.Error);
        }

        public static void LogFatal(string message)
        {
            Log(message, LogLevel.Fatal);
        }

        public static void LogException(string message, Exception exception)
        {
            Log(message, exception, LogLevel.Error);
        }

        private static string BuildLogMessage(string message, string category, Exception exception)
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(category))
            {
                sb.Append('[').Append(category.Trim()).Append("] ");
            }

            if (!string.IsNullOrWhiteSpace(message))
            {
                sb.Append(message.Trim());
            }

            if (exception != null)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" | ");
                }

                sb.Append("异常：").Append(exception.Message);

                if (!string.IsNullOrWhiteSpace(exception.StackTrace))
                {
                    sb.Append(Environment.NewLine)
                        .Append(exception.StackTrace);
                }
            }

            return sb.ToString();
        }
    }

    /// <summary>
    /// 日志级别
    /// </summary>
    public enum LogLevel
    {
        Debug = 0,
        Info,
        Warn,
        Error,
        Fatal
    }

    /// <summary>
    /// 自定义 UI Appender 抽象基类
    /// 提供异步批量刷新控件的公共机制
    /// </summary>
    public abstract class ControlAppenderBase : AppenderSkeleton
    {
        private readonly ConcurrentQueue<string> _queue = new ConcurrentQueue<string>();
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private int _started;

        protected ControlAppenderBase()
        {
            StartWorker();
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            string message;

            try
            {
                if (Layout != null)
                {
                    using (var sw = new StringWriter())
                    {
                        Layout.Format(sw, loggingEvent);
                        message = sw.ToString();

                        if (loggingEvent.ExceptionObject != null)
                        {
                            message += loggingEvent.ExceptionObject + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    message = loggingEvent.RenderedMessage + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                message = $"[日志格式化失败] {loggingEvent?.RenderedMessage}，原因：{ex.Message}{Environment.NewLine}";
                Debug.WriteLine(message);
            }

            _queue.Enqueue(message);
        }

        private void StartWorker()
        {
            if (Interlocked.Exchange(ref _started, 1) == 1)
            {
                return;
            }

            Task.Run(async () =>
            {
                while (!_cts.Token.IsCancellationRequested)
                {
                    try
                    {
                        await Task.Delay(300, _cts.Token).ConfigureAwait(false);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"日志后台线程延时异常：{ex.Message}");
                        continue;
                    }

                    if (_queue.IsEmpty)
                    {
                        continue;
                    }

                    var sb = new StringBuilder();
                    while (_queue.TryDequeue(out string item))
                    {
                        sb.Append(item);
                    }

                    string batchText = sb.ToString();
                    if (!string.IsNullOrEmpty(batchText))
                    {
                        try
                        {
                            SafeAppend(batchText);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"日志追加到控件失败：{ex.Message}");
                        }
                    }
                }
            }, _cts.Token);
        }

        /// <summary>
        /// 安全地把文本追加到具体控件
        /// </summary>
        protected abstract void SafeAppend(string text);

        protected override void OnClose()
        {
            if (!_cts.IsCancellationRequested)
            {
                _cts.Cancel();
            }

            _cts.Dispose();
            base.OnClose();
        }
    }

    /// <summary>
    /// 输出到 TextBox 的 Appender
    /// </summary>
    public sealed class TextBoxAppender : ControlAppenderBase
    {
        private readonly TextBox _textBox;
        private const int MaxLines = 100;

        public TextBoxAppender(TextBox textBox)
        {
            _textBox = textBox ?? throw new ArgumentNullException(nameof(textBox));
        }

        protected override void SafeAppend(string text)
        {
            if (_textBox.IsDisposed || !_textBox.IsHandleCreated)
            {
                return;
            }

            try
            {
                if (_textBox.InvokeRequired)
                {
                    _textBox.BeginInvoke(new Action(() => AppendToTextBox(text)));
                }
                else
                {
                    AppendToTextBox(text);
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"TextBox BeginInvoke 失败：{ex.Message}");
            }
        }

        private void AppendToTextBox(string text)
        {
            try
            {
                if (_textBox.IsDisposed || !_textBox.IsHandleCreated)
                {
                    return;
                }

                _textBox.AppendText(text);
                TrimLines(_textBox, MaxLines);
                _textBox.SelectionStart = _textBox.TextLength;
                _textBox.ScrollToCaret();
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"TextBox 更新失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 保留最新 maxLines 行，删除最旧的行
        /// </summary>
        private static void TrimLines(TextBox textBox, int maxLines)
        {
            string[] lines = textBox.Lines;
            if (lines.Length <= maxLines)
            {
                return;
            }

            int keepCount = maxLines;
            string[] newLines = new string[keepCount];
            Array.Copy(lines, lines.Length - keepCount, newLines, 0, keepCount);
            textBox.Lines = newLines;
        }
    }

    /// <summary>
    /// 输出到 ListView 的 Appender
    /// </summary>
    public sealed class ListViewAppender : ControlAppenderBase
    {
        private readonly ListView _listView;
        private const int MaxItems = 100;

        public ListViewAppender(ListView listView)
        {
            _listView = listView ?? throw new ArgumentNullException(nameof(listView));
        }

        protected override void SafeAppend(string text)
        {
            if (_listView.IsDisposed || !_listView.IsHandleCreated)
            {
                return;
            }

            try
            {
                if (_listView.InvokeRequired)
                {
                    _listView.BeginInvoke(new Action(() => AppendToListView(text)));
                }
                else
                {
                    AppendToListView(text);
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ListView BeginInvoke 失败：{ex.Message}");
            }
        }

        private void AppendToListView(string text)
        {
            try
            {
                if (_listView.IsDisposed || !_listView.IsHandleCreated)
                {
                    return;
                }

                _listView.BeginUpdate();

                string[] lines = text.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    _listView.Items.Add(new ListViewItem(line));
                }

                while (_listView.Items.Count > MaxItems)
                {
                    _listView.Items.RemoveAt(0);
                }

                if (_listView.Items.Count > 0)
                {
                    _listView.Items[_listView.Items.Count - 1].EnsureVisible();
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ListView 更新失败：{ex.Message}");
            }
            finally
            {
                try
                {
                    if (!_listView.IsDisposed && _listView.IsHandleCreated)
                    {
                        _listView.EndUpdate();
                    }
                }
                catch
                {
                }
            }
        }
    }
}