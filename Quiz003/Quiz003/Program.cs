using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz003 //화씨 온도 구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double result;

            a = int.Parse(Console.ReadLine());

            result = (9.0 / 5.0 * a) + 32.0;
            Console.WriteLine(result);

        }
    }
}
