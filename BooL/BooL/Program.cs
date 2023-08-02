using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);

            object c = 123;
            Console.WriteLine(c);

            object d = 3.141592;
            Console.WriteLine(d);

            object e = "안녕하세요";
            Console.WriteLine(e);

            //Boxing, UnBoxing
            object f = 20;
            int g = 123;
            int h = (int)f;

        }
    }
}
