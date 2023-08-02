using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class MainApp
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "홍길동", Age = 123 };
            Console.WriteLine($"{a.Name} {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 1, 2, 3, 4, 5 } };
            Console.WriteLine(b.Subject + " " + b.Scores) ;

        }
    }
}
