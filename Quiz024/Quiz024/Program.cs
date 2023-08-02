using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("실수를 입력하세요 : ");
            double d = double.Parse(Console.ReadLine());

            byte[] doubleBytes = BitConverter.GetBytes(d);
            Console.WriteLine(BitConverter.ToString(doubleBytes));

            double doubleResult = BitConverter.ToDouble(doubleBytes, 0);
            Console.WriteLine(doubleResult.ToString());
        }
    }
}