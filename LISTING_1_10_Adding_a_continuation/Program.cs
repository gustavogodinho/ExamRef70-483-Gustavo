using System;
using System.Threading.Tasks;

namespace LISTING_1_10_Adding_a_continuation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            }).ContinueWith((x) =>
            {
                return x.Result - 80;
            }
            );

            Console.WriteLine(t.Result);
            Console.ReadKey();


        }
    }
}
