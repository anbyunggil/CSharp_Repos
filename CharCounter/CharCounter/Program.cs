using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCounter
{
    class Program
    {
        public int CharCounter(char[]arr, char ch)
        {
            int N = 0;
            

            return N;
        }
        static void Main(string[] args)
        {
            Console.Write("문자열 입력 : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            
            Console.Write("문자 입력 : ");
            string str2 = Console.ReadLine();

            char c = str2[0];

            

            int result = CharCounter(arr, c);
            Console.WriteLine("결과 : " + result);
        }
    }
}
