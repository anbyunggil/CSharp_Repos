using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Lamda
{
    internal class Program
    {
        delegate string Concatenate(String[] args);
        static void Main(string[] args)
        {
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
}
