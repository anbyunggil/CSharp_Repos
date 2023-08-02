using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbortingThread
{
    internal class Program
    {
        class SideTask
        {
            int count;

            public SideTask(int count)
            {
                this.count = count;
            }
            public void KeepAlive()
            {
                try
                {
                    while (count > 0)
                    {
                        Console.WriteLine($"{ count-- } left");
                        Thread.Sleep(10);
                    }
                    Console.WriteLine("Count : 0");
                }
                catch(ThreadAbortException e)
                {
                    Console.WriteLine(e);
                    Thread.ResetAbort();
                }
                finally
                {
                    Console.WriteLine("Clearing resource...");
                }
            }
        }
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Strating thread...");
            t1.Start();

            Thread.Sleep(100);
            Console.WriteLine("Aborting thread...");
            t1.Abort();     //스레드 취소(catch 절 실행)

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
