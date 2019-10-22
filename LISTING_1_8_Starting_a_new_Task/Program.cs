using System;
using System.Threading.Tasks;

namespace LISTING_1_8_Starting_a_new_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine(x);
                }

            }
            );

            t.Wait();

            Console.ReadKey();

        }
    }
}
