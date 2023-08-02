using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Calculator
    {
        public int SumLoop(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;

        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("숫자 입력");
            int start = int.Parse(Console.ReadLine());

            Console.Write("숫자 입력");
            int end = int.Parse(Console.ReadLine());
            
            Calculator calculator = new Calculator();
            int result = calculator.SumLoop(start, end);

            Console.WriteLine(result);
        }
    }
}