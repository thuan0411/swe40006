using TaskTrackerWeb.Models;

namespace TaskTrackerWeb.Services;

public interface ITaskService
{
    IReadOnlyList<TaskItem> GetAll();
    TaskItem Add(string title);
    void ToggleDone(int id);
    void Delete(int id);
}
