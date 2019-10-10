using System;
using System.Threading;
using Godinho.Exame.Models;

namespace Gustavo.Exame
{
/*If you run this application with the IsBackground property set to true, the application exits
immediately. If you set it to false (creating a foreground thread), the application prints the
ThreadProc message ten times.*/

    class Program
    {
        static void Main()
        {
           Thread t = new Thread(new ThreadStart(Threads.ThreadMethod));
           t.IsBackground = false;
           t.Start();
        }
    }
}
