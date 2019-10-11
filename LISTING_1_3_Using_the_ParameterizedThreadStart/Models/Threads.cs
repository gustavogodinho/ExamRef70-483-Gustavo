using System;
using System.Threading;

namespace LISTING_1_3_Using_the_ParameterizedThreadStart.Models
{
    internal class Threads
    {

        public static void ThreadMethod(object o)
        {
         
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }

        }
    }
}