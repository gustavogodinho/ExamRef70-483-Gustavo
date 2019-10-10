using System.Threading;

namespace LISTING_1_1_Creating_a_thread_with_the_Thread_class.Models
{
public class Threads 
{

 public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine( "ThreadProc:  {0}", i);
                Thread.Sleep(2000);
            }
        }


}

}
