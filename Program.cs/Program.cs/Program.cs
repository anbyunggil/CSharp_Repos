using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    internal class Program //IfElse
    {
        static void Main(string[] args)
        {
            int number = 2;
            //입력부 만들기


            if (number %2 == 1)
            {
                Console.WriteLine("홀수입니다.");
            } else
            {
                Console.WriteLine("짝수입니다.");
            }
        }
    }
}
