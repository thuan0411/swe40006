namespace TaskTrackerWeb.Models;

// Task 2.3: values here now come from configuration (appsettings.json locally,
// Azure App Service "Application settings" in production) instead of being
// hardcoded string literals in a .cs file like they were for Task 2.2.
public class DemoSettings
{
    public string DisplayTitle { get; set; } = "Task Tracker";
    public string DemoApiKey { get; set; } = "not-configured";
}
