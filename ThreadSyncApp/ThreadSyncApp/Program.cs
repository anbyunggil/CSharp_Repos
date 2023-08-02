using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncApp
{
    class Counter
    {
        public int count = 0;
        public void Increase()
        {
            count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Thread t1 = new Thread(counter.Increase);
            Thread t2 = new Thread(counter.Increase);
            Thread t3 = new Thread(counter.Increase);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(counter.count);
        }
    }
}
