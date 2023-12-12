public class App
{
    static async Task Main()
    {
        Logger logger = new Logger();
        logger.BackupRequired += Logger_BackupRequired;

        await RunLoggerTasks(logger, 50);
    }

    private static async Task RunLoggerTasks(Logger logger, int count)
    {
        List<Task> tasks = new List<Task>();

        for (int i = 0; i < count; i++)
        {
            tasks.Add(logger.LogAsync($"Log message {i + 1}"));
        }

        await Task.WhenAll(tasks);
    }

    private static void Logger_BackupRequired(object sender, EventArgs e)
    {
        Console.WriteLine("Backup is required!");
    }
}