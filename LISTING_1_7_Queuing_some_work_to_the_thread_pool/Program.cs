using System;
using System.Threading;

namespace LISTING_1_7_Queuing_some_work_to_the_thread_pool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>             
             {                 
                 Console.WriteLine("Working on a thread from threadpool"); 
             }
           ); 
 
            Console.ReadLine(); 
        }
    }
}
