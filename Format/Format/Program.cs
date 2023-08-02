using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciko = new CultureInfo("ko-KR");
            Console.WriteLine();
           
            Console.WriteLine(dt.ToString("yyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            Console.WriteLine(dt.ToString("yyy-MM-dd HH:mm:ss (dddd)", ciko));
            Console.WriteLine(dt.ToString(ciko));

            CultureInfo ciEn = new CultureInfo("en_US");
            Console.WriteLine();
            
            Console.WriteLine(dt.ToString("yyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyy-MM-dd HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));


        }
    }
}
