
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ProcessTask
{
    public string Name { get; set; }
    public int Priority { get; set; } // 1 = жоғары, 3 = төмен
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Priority Scheduling Demo ===\n");

        List<ProcessTask> tasks = new List<ProcessTask>
        {
            new ProcessTask { Name = "Task A", Priority = 3 },
            new ProcessTask { Name = "Task B", Priority = 1 },
            new ProcessTask { Name = "Task C", Priority = 2 }
        };

        // Приоритет бойынша сұрыптау
        var sorted = tasks.OrderBy(t => t.Priority);

        foreach (var task in sorted)
        {
            Console.WriteLine($"Executing {task.Name} with priority {task.Priority}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\nAll tasks executed based on priority.");
    }
}
