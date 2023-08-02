using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain_Easy
{
    internal class Program
    {
        delegate void ThisIsNavigation(string position);

        static void TurnLeft(string position)
        {
            Console.WriteLine($"{position}에서 좌회전");
        }
        static void TurnRight(string position)
        {
            Console.WriteLine($"{position}에서 우회전");
        }
        static void GoStraight(string position)
        {
            Console.WriteLine($"{position}에서 직진");
        }
        static void Main(string[] args)
        {
            ThisIsNavigation Navigation = new ThisIsNavigation(TurnLeft);
            Navigation += new ThisIsNavigation(TurnRight);
            Navigation += new ThisIsNavigation(GoStraight);

            Navigation("현재 위치");
        }
    }
}
