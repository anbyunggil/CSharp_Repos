using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam01
{
    interface IAttack
    {
        void attack();
    }
    class Weapon
    {

    }
    class Bow
    {

    }
    class Knight : Bow, IAttack
    {
        public void attack()
        {
            Console.WriteLine("아더가 활을 쏩니다. ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.attack();
        }
    }
}
