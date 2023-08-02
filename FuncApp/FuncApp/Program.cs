using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FuncApp
{
    internal class Program
    {
        static void threadFunc()
        {
            Console.WriteLine("5초 후 종료");
            Thread.Sleep(5000);
            Console.WriteLine("스레드 종료");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(threadFunc));
            t.IsBackground = true;  //주석 처리 했을 때와 안 했을 때를 비교
            t.Start();
            t.Join(); //main 스레드가 스레드를 기다려줌
            Console.WriteLine("메인 스레드 종료");
        }
    }
}
