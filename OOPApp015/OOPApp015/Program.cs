using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp015
{
    class MyClass
    {
        public int Field1;
        public int Field2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.Field1 = Field1;
            newCopy.Field2 = Field2;

            return newCopy;
        }
    }
       
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.Field1 = 10;
            source.Field2 = 20;

            MyClass target = source.DeepCopy();
            target.Field2 = 30;
            

            Console.WriteLine($"{source.Field1} {source.Field2} ");
            Console.WriteLine($"{target.Field1} {target.Field2} ");
        }
    }
}
