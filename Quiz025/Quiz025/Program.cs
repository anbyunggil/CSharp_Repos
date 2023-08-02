using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "myLog.txt";
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString()} : 정상작동 중");
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append)))
                {
                    sw.WriteLine($"{System.DateTime.Now.ToString()}: 정상작동 중");

                }
                Thread.Sleep(5000);
            }
        }
    }
}
