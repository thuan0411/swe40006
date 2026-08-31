using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using TaskTrackerWeb.Models;
using TaskTrackerWeb.Services;

namespace TaskTrackerWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ITaskService _taskService;
    private readonly ILogger<IndexModel> _logger;
    private readonly DemoSettings _settings;

    public IndexModel(ITaskService taskService, ILogger<IndexModel> logger, IOptions<DemoSettings> settings)
    {
        _taskService = taskService;
        _logger = logger;
        _settings = settings.Value;
    }

    public IReadOnlyList<TaskItem> Tasks { get; private set; } = Array.Empty<TaskItem>();
    public string PageDisplayTitle { get; private set; } = string.Empty;
    public string ApiKeyPreview { get; private set; } = string.Empty;

    [BindProperty]
    public string NewTaskTitle { get; set; } = string.Empty;

    public void OnGet()
    {
        Load();
    }

    public IActionResult OnPostAdd()
    {
        if (!string.IsNullOrWhiteSpace(NewTaskTitle))
        {
            _taskService.Add(NewTaskTitle);
        }
        return RedirectToPage();
    }

    public IActionResult OnPostToggle(int id)
    {
        _taskService.ToggleDone(id);
        return RedirectToPage();
    }

    public IActionResult OnPostDelete(int id)
    {
        _taskService.Delete(id);
        return RedirectToPage();
    }

    private void Load()
    {
        Tasks = _taskService.GetAll();
        PageDisplayTitle = _settings.DisplayTitle;
        var key = _settings.DemoApiKey ?? string.Empty;
        ApiKeyPreview = key.Length > 8 ? key[..8] + "..." : key;
        _logger.LogInformation("Index page loaded with {Count} tasks", Tasks.Count);
    }
}
