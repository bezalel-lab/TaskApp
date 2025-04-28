using System;
using System.Collections.Generic;

class TaskManager
{
  private List<TaskItem> tasks = new List<TaskItem>();

  public void AddTask(string title)
  {
    tasks.Add(new TaskItem(title));
  }

  public void ShowTasks()
  {
    Console.WriteLine("=== タスク一覧 ===");
    foreach (var task in tasks)
    {
      Console.WriteLine($"{(task.IsDone ? "[x]" : "[ ]")} {task.Title}");
    }
  }

  public void CompleteTask(int index)
  {
    if (index >= 0 && index < tasks.Count)
    {
      tasks[index].MarkDone();
    }
  }
}