using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] BigAlpha = new char[26];
            char[] SmallAlpha = new char[26];

            char BA = 'Z';
            char SA = 'a';

            for(int i = 0; i < BigAlpha.Length; i++)
            {
                BigAlpha[i] = BA--;
                Console.Write($"{BigAlpha[i]} ");

            }

            Console.WriteLine();

            for(int i = 0;i < SmallAlpha.Length;i++)
            {
                SmallAlpha[i] = SA++;
                Console.Write($"{SmallAlpha[i]} ");
            }
        }
    }
}
