using System.Threading;

namespace LISTING_1_6_Using_ThreadLocal_T_.Models
{
    public class Threads 
    {
    public static ThreadLocal<int> _field = 
        new ThreadLocal<int>(() => 
        {
            return Thread.CurrentThread.ManagedThreadId;
        }
    );
    }
    
}