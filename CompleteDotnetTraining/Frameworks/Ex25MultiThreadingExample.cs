using System;
using System.Threading;

//Multi Threading helps in performing async operations within the application.
//Async programming can be achieved in multiple ways in .NET
//ThreadPool, Delegates, Threads and Tasks are the different ways of achieving multi Threading in .NET. 
//System.Threading is the namespace used for creating Threads and working with Threads.
//Task Programming helps in performing optimized Async functionalities using multiple CORES of the machine that U execute the Application. 
//Normal Threads will make the Main Thread(parent thread) to wait till it completes its task. They are called as FOREGROUND Threads. However, some times, U might want a thread to stop immediately if the Main Thread stops(Closes). Such threads are called as Background Threads. 
namespace Frameworks
{

    class MultiThreadClass
    {
        private string _data;

        public MultiThreadClass(string data)
        {
            _data = data;
        }

        public void PerformOperation()
        {
            //lock (this)
            {
                for (int i = 0; i < _data.Length; i++)
                {
                    Console.Write(_data[i]);
                    Thread.Sleep(1500);
                }
            }
        }
    }
    internal class Ex25MultiThreadingExample
    {

        static void createMultipleThreads()
        {
            MultiThreadClass instance = new MultiThreadClass("Some content for the Demo");
            Thread th = new Thread(instance.PerformOperation);
            Thread th2 = new Thread(instance.PerformOperation);
            th.Start();
            th2.Start();
        }
        static void largeTimeBasedFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Some operation execution happening!!!");
                Thread.Sleep(1000);
            }
        }

        static void ThreadFuncWithArg(object argForThread)
        {
            if(argForThread is Array)
            {
                var temp = (Array)argForThread;
                foreach(var item in temp)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(1000);
                }    
            }
            else
            {
                throw new ArgumentException("Arg should be an Array");
            }
        }
        static void Main(string[] args)
        {
            //largeTimeBasedFunc();
            //createNewThreadAndExecute();
            createMultipleThreads();
            //backGroundThreadExample();
            Console.WriteLine("End of the Program");
        }

        private static void backGroundThreadExample()
        {
            Thread th = new Thread(largeTimeBasedFunc);
            th.IsBackground= true;
            th.Start();
        }

        static void createNewThreadWithArgAndExecute()
        {
            Thread th = new Thread(ThreadFuncWithArg);
            var arg = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            th.Start(arg);
        }
        private static void createNewThreadAndExecute()
        {
            Thread thread = new Thread(largeTimeBasedFunc);
            thread.Start();
            createNewThreadWithArgAndExecute();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[Main] function operation is running parallelly");
                Thread.Sleep(1000);
            }
        }
    }
}
//Assignment: Try out an Example on Semaphore where U can allow x no of threads to execute concurently upto a restricted no. 