using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadQuiz01
{

    internal class Program
    {
        static void Plus()
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                num += i;
            }
            Console.WriteLine(num);
        }
        static void Alpha()
        {
            for(int i=(int)'A'; i <= (int)'Z'; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Plus));
            Thread t2 = new Thread(new ThreadStart(Alpha));
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            Console.WriteLine();
            Console.WriteLine("Main 종료");
        }
    }
}
