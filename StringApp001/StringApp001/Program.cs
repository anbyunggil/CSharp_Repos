using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf()
            Console.WriteLine($"{greeting.IndexOf("Morning")}");
            Console.WriteLine($"{greeting.IndexOf("d")}");

            //LastIndexOf()
            Console.WriteLine($"{greeting.LastIndexOf("Good")}");
            Console.WriteLine($"{greeting.LastIndexOf("o")}");

            //StartsWith()
            Console.WriteLine($"StartsWith:{greeting.StartsWith("Good")}");
            Console.WriteLine($"StartsWith:{greeting.StartsWith("Morning")}");

            //Endswith()
            Console.WriteLine($"EndsWith:{greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith:{greeting.EndsWith("Morning")}");

            //Contains()
            Console.WriteLine($"Contains Evening:{greeting.Contains("Evening")}");
            Console.WriteLine($"Contains Evening:{greeting.Contains("Morning")}");

            //Replace()
            Console.WriteLine($"Replace Evening:{greeting.Replace("Morning", "Evening")}");
        }
    }
}
