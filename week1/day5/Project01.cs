// // Personal Task Manager Console App
using System;
using System.Collections.Generic;

class TaskItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "Pending";

    public override string ToString()
    {
        return $"{Title} - {Status}\n  {Description}";
    }
}

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Task Manager ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task Status");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ViewTasks(); break;
                case "3": UpdateStatus(); break;
                case "4": DeleteTask(); break;
                case "5": return;
                default: break;
            }
        }
    }

    static void AddTask()
    {
        Console.Clear();
        Console.Write("Title: ");
        var title = Console.ReadLine();

        Console.Write("Description: ");
        var desc = Console.ReadLine();

        tasks.Add(new TaskItem { Title = title, Description = desc });

        Console.WriteLine("\nTask added. Press Enter.");
        Console.ReadLine();
    }

    static void ViewTasks()
    {
        Console.Clear();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks yet.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}\n");
            }
        }

        Console.WriteLine("Press Enter.");
        Console.ReadLine();
    }

    static void UpdateStatus()
    {
        Console.Clear();
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to update.");
            Console.ReadLine();
            return;
        }

        ViewTasks();
        Console.Write("Select task number: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid choice.");
            Console.ReadLine();
            return;
        }

        var t = tasks[index - 1];
        t.Status = t.Status == "Pending" ? "Completed" : "Pending";

        Console.WriteLine("Status updated. Press Enter.");
        Console.ReadLine();
    }

    static void DeleteTask()
    {
        Console.Clear();
        if (tasks.Count == 0)
        {
            Console.WriteLine("Nothing to delete.");
            Console.ReadLine();
            return;
        }

        ViewTasks();
        Console.Write("Select task number to delete: ");

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid choice.");
            Console.ReadLine();
            return;
        }

        Console.Write("Are you sure? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task deleted.");
        }
        else
        {
            Console.WriteLine("Cancelled.");
        }

        Console.ReadLine();
    }
}
