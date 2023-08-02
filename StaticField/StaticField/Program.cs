using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Global Count : {Global.Count}");

            ClassA ca1 = new ClassA();
            ClassA ca2 = new ClassA();
            ClassA ca3 = new ClassA();
            ClassA ca4 = new ClassA();

            Console.Write($"Global Count : {Global.Count}");
        }
    }
}
