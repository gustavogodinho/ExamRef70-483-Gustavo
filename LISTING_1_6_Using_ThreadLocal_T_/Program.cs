using System;
using System.Threading;
using LISTING_1_6_Using_ThreadLocal_T_.Models;

namespace LISTING_1_6_Using_ThreadLocal_T_
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
           new Thread(() => 
           {
               for (int x = 0; x < Threads._field.Value; x ++)
               {
                    Console.WriteLine("Thread A: {0}", x); 
               }
           } 
           ).Start();

            new Thread(() =>                 
            {                     
                for (int x = 0; x < Threads._field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                } 
            }).Start(); 
          Console.ReadKey();         
        }  
    }
}

