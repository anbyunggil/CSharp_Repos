using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 최적의 몸무게 구하기
            // 수식 키 - 110 --> 이상적 몸무게
            int tall;
            tall = int.Parse(Console.ReadLine());

            int result = tall - 110;

            Console.WriteLine(result);
            
        }
    }
}
