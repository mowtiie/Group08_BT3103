using System.Diagnostics;

namespace Saleling.Util
{
    public sealed class LoggerUtil
    {
        private static readonly LoggerUtil instance = new LoggerUtil();

        private static readonly string LOG_DIRECTORY = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string LOG_FILE = Path.Combine(LOG_DIRECTORY, "Saleling-Debug.logs");

        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        private LoggerUtil()
        {
            try
            {
                Directory.CreateDirectory(LOG_DIRECTORY);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: Could not create directory. {ex.Message}");
            }
        }

        public static LoggerUtil Instance
        {
            get { return instance; }
        }

        public async Task LogAsync(string message)
        {
            await semaphore.WaitAsync();

            try
            {
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

                using (StreamWriter streamWriter = File.AppendText(LOG_FILE))
                {
                    await streamWriter.WriteLineAsync(logEntry);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: Failed to write to {LOG_FILE}. Original Message: {message}. Exception: {ex.Message}");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
