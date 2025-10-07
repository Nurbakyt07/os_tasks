using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Preemptive Scheduling Demo ===\n");

        Thread highPriority = new Thread(() =>
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("High Priority Task running...");
                Thread.Sleep(300);
            }
        });

        Thread lowPriority = new Thread(() =>
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Low Priority Task running...");
                Thread.Sleep(700);
            }
        });

        // Приоритет беру
        highPriority.Priority = ThreadPriority.Highest;
        lowPriority.Priority = ThreadPriority.Lowest;

        highPriority.Start();
        lowPriority.Start();

        highPriority.Join();
        lowPriority.Join();

        Console.WriteLine("\nPreemptive scheduling demonstration complete.");
    }
}
