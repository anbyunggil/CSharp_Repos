using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp02
{
    internal class Program
    {
        static void Run()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread Program 종료");
        }
        static void Main(string[] args)
        {
            //Thread를 이용해서 1 ~ 100 출력하는 프로그램 작성
            Thread t = new Thread(new ThreadStart(Run));
            t.Start();
            t.Join();
            Console.WriteLine("Main Program 종료");
        }
    }
}
