using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Thread vs Process demonstration ===\n");

        // Процесс (мысалы, Notepad ашу)
        Process.Start("notepad.exe");
        Console.WriteLine("Process started: Notepad");

        // Thread (ағын) мысалы
        Thread thread = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread running... {i}");
                Thread.Sleep(500);
            }
        });

        thread.Start();
        thread.Join();

        Console.WriteLine("\nThread finished!");
        Console.WriteLine("Process and Thread demonstration complete.");
    }
}
