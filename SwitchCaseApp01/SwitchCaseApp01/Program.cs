using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력해 주세요. (1,2,3,4,5,6,7) : ");
            string num = Console.ReadLine();

            switch (num)
            {
                case "1":
                    Console.WriteLine($"{"월요일"}입니다.");
                    break;
                case "2":
                    Console.WriteLine($"{"화요일"}입니다.");
                    break;
                case "3":
                    Console.WriteLine($"{"수요일"}입니다.");
                    break;
                case "4":
                    Console.WriteLine($"{"목요일"}입니다.");
                    break;
                case "5":
                    Console.WriteLine($"{"금요일"}입니다.");
                    break;
                case "6":
                    Console.WriteLine($"{"토요일"}입니다.");
                    break;
                case "7":
                    Console.WriteLine($"{"일요일"}입니다.");
                    break;
                default:
                    Console.WriteLine($"{"일요일"}입니다.");
                    break;

            }
        }
    }
}
