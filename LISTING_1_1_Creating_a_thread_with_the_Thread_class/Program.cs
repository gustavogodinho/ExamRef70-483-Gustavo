using System;
using System.Threading;
using LISTING_1_1_Creating_a_thread_with_the_Thread_class.Models;

namespace LISTING_1_1_Creating_a_thread_with_the_Thread_class
{
    public static class Program
    {
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(Threads.ThreadMethod));
            t.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(2000);
            }
            t.Join();
        }
    }
}
