using System;

class Program
{
  static void Main(string[] args)
  {
    var manager = new TaskManager();

    while (true)
    {
      Console.WriteLine("\n1. タスク追加 2. タスク一覧表示 3. タスク完了 0. 終了");
      Console.Write("選択肢を入力して：");
      string input = Console.ReadLine();

      if (input == "1")
      {
        Console.Write("タスク名を入力して：");
        string title = Console.ReadLine();
        manager.AddTask(title);
      }
      else if (input == "2")
      {
        manager.ShowTasks();
      }
      else if (input == "3")
      {
        Console.Write("完了したいタスク番号を入力して(0スタート)：");
        int index = int.Parse(Console.ReadLine());
        manager.CompleteTask(index);
      }
      else if (input == "0")
      {
        break;
      }
    }
    Console.WriteLine("アプリ終了。お疲れさま！");
  }
}