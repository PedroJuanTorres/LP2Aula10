using System;
using System.Threading;

namespace Threads
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountToNumber);
            thread1.Start(10);
            Thread thread2 = new Thread(CountToNumber);
            thread2.Start(100);
            thread1.Join();
            thread2.Join();
        }

        private static void CountToNumber(object input)
        {
            int n = (int)input;
            for (int index = 0; index < n; index++)
                Console.WriteLine($"{index++} ({Thread.CurrentThread.Name})");
        }
    }
}
