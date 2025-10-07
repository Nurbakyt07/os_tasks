using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ProcessTask
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public int BurstTime { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Priority Scheduling Demo ===\n");

        List<ProcessTask> processes = new List<ProcessTask>
        {
            new ProcessTask { Name = "P1", Priority = 3, BurstTime = 4 },
            new ProcessTask { Name = "P2", Priority = 1, BurstTime = 3 },
            new ProcessTask { Name = "P3", Priority = 2, BurstTime = 2 }
        };

        // Приоритеті бойынша (кіші сан — жоғары приоритет)
        var sorted = processes.OrderBy(p => p.Priority).ToList();

        foreach (var p in sorted)
        {
            Console.WriteLine($"Executing {p.Name} with Priority {p.Priority}");
            Thread.Sleep(p.BurstTime * 500);
        }

        Console.WriteLine("\nAll processes executed based on priority.");
    }
}
