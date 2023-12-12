using Newtonsoft.Json;
public static class AppConfigHelper
{
    private const string AppConfigFileName = "appconfig.json";
    private static AppConfig appConfig;

    static AppConfigHelper()
    {
        LoadAppConfig();
    }

    private static void LoadAppConfig()
    {
        string configJson = File.ReadAllText(AppConfigFileName);
        appConfig = JsonConvert.DeserializeObject<AppConfig>(configJson);
    }

    public static int GetBackupFrequency()
    {
        return appConfig?.BackupFrequency ?? 0;
    }
}