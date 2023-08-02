using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char '반' '가' '워'
            //string "행복하세요!!!" -->\n
            char a = '반';
            char b = '가';
            char c = '워';

            Console.WriteLine($"{a}{b}{c}");
            Console.WriteLine();

            string multi01 = "행복\n하세\n요!!!";
            Console.Write(multi01);
            Console.WriteLine();
        }
    }
}
