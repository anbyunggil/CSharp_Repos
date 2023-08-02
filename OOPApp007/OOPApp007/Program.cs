using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp007
{
    class Car 
    {
        public virtual void Run() 
        {
            Console.WriteLine("car 달리다");

        }
    }
    class SuperCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("supercar 달리다");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            SuperCar superCar = new SuperCar();
            superCar.Run();
        }
    }
}
    