using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;
            try
            {
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("예외가 발생하여 프로그램을 종료");
                Environment.Exit(0);
            }
        }
    }
}
