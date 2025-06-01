using System;
using System.IO;
using System.Text.Json;

namespace GitHubDeployMonitor
{
    public class AppConfig
    {
        public string ApiKey { get; set; } = string.Empty;
        public bool UsePrivateKey { get; set; } = false;

        private static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public void Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigPath, json);
            }
            catch { /* log or handle */ }
        }

        public static AppConfig Load()
        {
            try
            {
                if (!File.Exists(ConfigPath))
                    return new AppConfig();

                var json = File.ReadAllText(ConfigPath);
                return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }
            catch
            {
                return new AppConfig();
            }
        }
    }
}