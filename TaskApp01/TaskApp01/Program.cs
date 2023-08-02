using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //main 동작중...
            Action sum = () =>
            {
                //1. 1~100까지 더하기
                int num = 0;
                for (int i = 1; i <= 100; i++)
                {
                    num += i;
                }
                Console.WriteLine(num);
            };
            Task myTask1 = new Task(sum);     //Action대리
            myTask1.Start();
            myTask1.Wait();

            Task myTask2 = Task.Run(() => {
                //2. A~Z까지 출력
                char[] Alpha = new char[26];
                char Ap = 'A';
                for (int i = 0; i < Alpha.Length; i++)
                {
                    Alpha[i] = Ap++;
                    Console.Write($"{Alpha[i]} ");
                }
                Console.WriteLine();

            });
            myTask2.Wait(); //Join()

            
            Console.WriteLine("main 종료!!");

        }
    }
}
