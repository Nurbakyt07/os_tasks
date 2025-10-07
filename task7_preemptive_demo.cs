
using System;
using System.Threading;

class Program
{
    static bool running = true;

    static void BackgroundTask()
    {
        while (running)
        {
            Console.WriteLine("[Low Priority] Background task running...");
            Thread.Sleep(700);
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Preemptive Scheduling Demo ===\n");

        Thread background = new Thread(BackgroundTask);
        background.Priority = ThreadPriority.BelowNormal;
        background.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("[High Priority] Main task executing...");
            Thread.Sleep(500);
        }

        running = false;
        background.Join();

        Console.WriteLine("\nPreemptive scheduling demonstration complete.");
    }
}
