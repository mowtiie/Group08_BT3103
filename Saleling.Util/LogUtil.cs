using System.Collections.Concurrent;

namespace Saleling.Util
{
    public class LogUtil : IDisposable
    {
        private static readonly string LOG_FILE_NAME = "Saleling.logs";
        private static readonly Lazy<LogUtil> instance = new Lazy<LogUtil>(() => new LogUtil());
        private readonly ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private Task logTask;

        public static LogUtil Instance => instance.Value;

        private LogUtil()
        {
            try
            {
                if (!File.Exists(LOG_FILE_NAME))
                {
                    File.Create(LOG_FILE_NAME).Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating log file: {ex.Message}");
            }

            logTask = Task.Run(() => WriteLogEntriesAsync());
        }

        public void Log(string message)
        {
            string formattedMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {message}";
            logQueue.Enqueue(formattedMessage);
        }

        private async Task WriteLogEntriesAsync()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                try
                {
                    await Task.Delay(50, cancellationTokenSource.Token);

                    while (logQueue.TryDequeue(out string message))
                    {
                        await File.AppendAllTextAsync(LOG_FILE_NAME, message + Environment.NewLine, cancellationTokenSource.Token);
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to log file: {ex.Message}");
                }
            }
        }

        public void Clear()
        {
            try
            {
                if (File.Exists(LOG_FILE_NAME))
                {
                    File.Delete(LOG_FILE_NAME);
                    Console.WriteLine("Log file cleared successfully.");
                }
                logQueue.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing log file: {ex.Message}");
            }
        }

        public void Dispose()
        {
            cancellationTokenSource.Cancel();
            logTask.Wait(5000);
            cancellationTokenSource.Dispose();
        }
    }
}
