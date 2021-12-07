using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Race);
            t1.Name = "Frog 1";

            Thread t2 = new Thread(Race);
            t2.Name = "Frog 2";

            Thread t3 = new Thread(Race);
            t3.Name = "Frog 3";


            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            t1.Join();
            t2.Join();
            t3.Join();
        }

        private static void Race(object n)
        {
            int i = (int)n;    

            Random rnd = new Random(i);

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Rã {i} deu salto {j} (Nome da thread: {Thread.CurrentThread.Name}");
                Thread.Sleep(rnd.Next(1001));
            }
        }
    }
}
