using TaskTrackerWeb.Models;

namespace TaskTrackerWeb.Services;

// Simple in-memory task store — deliberately no database, so the app has
// zero external dependencies and nothing to provision beyond App Service itself.
// State resets on app restart; that's an accepted trade-off for a teaching demo.
public class TaskService : ITaskService
{
    private readonly List<TaskItem> _tasks = new();
    private readonly object _lock = new();
    private int _nextId = 1;
    private readonly ILogger<TaskService> _logger;

    public TaskService(ILogger<TaskService> logger)
    {
        _logger = logger;
        _tasks.Add(new TaskItem { Id = _nextId++, Title = "Set up Azure App Service", IsDone = true });
        _tasks.Add(new TaskItem { Id = _nextId++, Title = "Deploy TaskTrackerWeb from VS Code", IsDone = false });
        _tasks.Add(new TaskItem { Id = _nextId++, Title = "Configure App Settings & log streaming", IsDone = false });
    }

    public IReadOnlyList<TaskItem> GetAll()
    {
        lock (_lock)
        {
            return _tasks.OrderBy(t => t.IsDone).ThenByDescending(t => t.CreatedAt).ToList();
        }
    }

    public TaskItem Add(string title)
    {
        lock (_lock)
        {
            var task = new TaskItem { Id = _nextId++, Title = title.Trim() };
            _tasks.Add(task);
            _logger.LogInformation("Task added: #{TaskId} \"{Title}\"", task.Id, task.Title);
            return task;
        }
    }

    public void ToggleDone(int id)
    {
        lock (_lock)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
            {
                _logger.LogWarning("Attempted to toggle missing task #{TaskId}", id);
                return;
            }
            task.IsDone = !task.IsDone;
            _logger.LogInformation("Task #{TaskId} marked {Status}", id, task.IsDone ? "done" : "not done");
        }
    }

    public void Delete(int id)
    {
        lock (_lock)
        {
            var removed = _tasks.RemoveAll(t => t.Id == id);
            _logger.LogInformation("Task #{TaskId} delete requested, removed={Removed}", id, removed > 0);
        }
    }
}
