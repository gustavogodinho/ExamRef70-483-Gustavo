using System;
using System.Threading;
using LISTING_1_3_Using_the_ParameterizedThreadStart.Models;

namespace LISTING_1_3_Using_the_ParameterizedThreadStart
{
    public class Program
    {
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Threads.ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
