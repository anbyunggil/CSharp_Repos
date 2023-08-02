using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char[] BigAlpha = new char[26];
            Char[] SmallAlpha = new char[26];

            char BA = 'Z';
            char SA = 'a';

            for (int i = 0; i < BigAlpha.Length; i++)
            {
                BigAlpha[i] = BA--;
                SmallAlpha[i] = SA++;

                Console.WriteLine($"{BigAlpha[i]}  {SmallAlpha[i]}");
            }
        }
    }
}
