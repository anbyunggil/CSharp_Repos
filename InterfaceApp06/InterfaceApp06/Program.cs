using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp06
{
    interface IRun
    {
        void Run();
    }
    interface IFly
    {
        void Fly();
    }
    class Car : IRun, IFly
    {
        public void Fly()
        {
            Console.WriteLine("날아! 날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려! 달려!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            car.Fly();

            IRun run = car as IRun;
            run.Run();

            IFly fly = car as IFly;
            fly.Fly();
        }
    }
}
