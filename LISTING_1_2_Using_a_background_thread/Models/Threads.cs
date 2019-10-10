using System.Threading;

namespace Godinho.Exame.Models 
{
    public class Threads
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("ThreadProc:  {0}",i);
                Thread.Sleep(1000);
            }
        }

    }

}