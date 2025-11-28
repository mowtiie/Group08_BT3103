using System.Diagnostics;

namespace Saleling.Util
{
    public enum LogLevel { DEBUG, INFO, WARN, ERROR, FATAL }

    public sealed class LoggerUtil
    {
        private static readonly string LOG_DIRECTORY = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string LOG_FILE = Path.Combine(LOG_DIRECTORY, "Saleling-Debug.logs");

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private static readonly LoggerUtil _instance = new LoggerUtil();

        private LoggerUtil()
        {
            try
            {
                Directory.CreateDirectory(LOG_DIRECTORY);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CRITICAL ERROR: Logger could not create log directory at {LOG_DIRECTORY}. {ex.Message}");
                throw new InvalidOperationException("Failed to initialize LoggerUtil due to directory creation error.", ex);
            }
        }

        public static LoggerUtil Instance
        {
            get { return _instance; }
        }

        private async Task WriteLogAsync(string level, string message)
        {
            await _semaphore.WaitAsync().ConfigureAwait(false);

            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}{Environment.NewLine}";
                await File.AppendAllTextAsync(LOG_FILE, logEntry).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: Failed to write log entry to {LOG_FILE}. Message: {message}. Exception: {ex.Message}");
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<string> GetLogContentsAsync()
        {
            await _semaphore.WaitAsync().ConfigureAwait(false);

            try
            {
                if (!File.Exists(LOG_FILE))
                {
                    return "Log file not found.";
                }

                return await File.ReadAllTextAsync(LOG_FILE).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CRITICAL ERROR: Failed to read log file contents. Exception: {ex.Message}");
                return $"Error reading log file: {ex.Message}";
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public Task LogInfoAsync(string message) => WriteLogAsync(nameof(LogLevel.INFO), message);
        public Task LogErrorAsync(string message) => WriteLogAsync(nameof(LogLevel.ERROR), message);
        public Task LogDebugAsync(string message) => WriteLogAsync(nameof(LogLevel.DEBUG), message);
        public Task LogWarningAsync(string message) => WriteLogAsync(nameof(LogLevel.WARN), message);
        public Task LogFatalAsync(string message) => WriteLogAsync(nameof(LogLevel.FATAL), message);

        public Task LogExceptionAsync(Exception ex, string message = "Unhandled Exception")
        {
            string fullMessage = $"{message} | Type: {ex.GetType().Name} | Source: {ex.Source} | Message: {ex.Message} | StackTrace: {ex.StackTrace}";
            return WriteLogAsync(nameof(LogLevel.FATAL), fullMessage);
        }
    }
}
