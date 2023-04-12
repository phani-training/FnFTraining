using System;
using System.Threading;
//Threads are not optmized as they work on OS Threads(Kernel Threads). Applications run on User Mode and Thread Creations happen on Kernel mode. The CPU Cycles will be more when context switching happens b/w the Application data and Thread Data. 
//.NET CLR internally maintains a set of threads ready to use for its working. As programmers we can use any one of those threads for performing async tasks. Here the .NET CLR will decide which thread it will allocate for UR Task. All Threads of the Thread Pool are background threads. 

namespace Frameworks
{
    internal class Ex26ThreadPoolExample
    {
        static void Main()
        {
            int threadCount, maxCount, minCount;
            ThreadPool.GetMaxThreads(out threadCount, out maxCount);
            Console.WriteLine("The Max Threads available for usage: " + threadCount);
            Console.WriteLine("No of Thread ports: " + maxCount);

            ThreadPool.QueueUserWorkItem(new WaitCallback((obj) =>{
                Console.WriteLine("The Thread ID: " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Is the Thread Background? : "+ Thread.CurrentThread.IsBackground);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("The parameter passed to the Thread func is " + obj);
                    var content = $"Thread Id with a beep {i}";
                    Console.WriteLine(content);
                    Thread.Sleep(1000);
                }
            }), "Apple123");
            Console.ReadKey();
        }
    }
}
