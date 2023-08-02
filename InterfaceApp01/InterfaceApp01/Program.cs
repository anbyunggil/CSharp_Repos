using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp01    //C#과JAVA는 다중상속 불가, C++은 다중상속 가능
{
    interface Wing
    {
        void fly();
    }
    class Horse
    {

    }
    class Angel : Wing
    {
        public void fly()
        {
            Console.WriteLine("천사가 날다");
        }
    }
    class Unicon : Horse, Wing
    {
        public void fly()
        {
            Console.WriteLine("유니콘이 날다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Angel angel = new Angel();
            angel.fly();
            Unicon unicon = new Unicon();
            unicon.fly();
        }
    }
}
