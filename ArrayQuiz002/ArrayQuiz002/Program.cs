using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuiz002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //대문자'Z'~'A'까지 출력하는 배열
            char[] arr = new char[26];

            char ch = 'Z';
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ch--;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //소문자'a'~'z'까지 출력하는 배열
            char[] arr2 = new char[26];

            char ch2 = 'a';
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = ch2++;
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
