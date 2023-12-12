public class Logger
{
    public event EventHandler BackupRequired;

    private const string LogFilePath = "log.txt";
    private const string BackupFolderPath = "Backup";

    private int logCount;

    public Logger()
    {
        logCount = 0;
    }

    public async Task LogAsync(string message)
    {
        logCount++;

        if (logCount % AppConfigHelper.GetBackupFrequency() == 0)
        {
            Backup();
            OnBackupRequired();
        }

        using (StreamWriter writer = new StreamWriter(LogFilePath, true))
        {
            await writer.WriteLineAsync($"{DateTime.Now} - {message}");
        }
    }

    private void Backup()
    {
        string backupFileName = $"Backup_{DateTime.Now:yyyyMMddHHmmss}.txt";
        string backupFilePath = Path.Combine(BackupFolderPath, backupFileName);

        Directory.CreateDirectory(BackupFolderPath);

        File.Copy(LogFilePath, backupFilePath);
    }

    private void OnBackupRequired()
    {
        BackupRequired?.Invoke(this, EventArgs.Empty);
    }
}