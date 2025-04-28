class TaskItem
{
  public string Title { get; set; }
  public bool IsDone { get; private set; }

  public TaskItem(string title)
  {
    Title = title;
    IsDone = false;
  }

  public void MarkDone()
  {
    IsDone = true;
  }
}