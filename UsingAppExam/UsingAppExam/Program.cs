using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAppExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Stream outStream = new FileStream("a.dat", FileMode.Create))
            {
                long someValue = 0x123456789ABCD;
                byte[] someBytes = BitConverter.GetBytes(someValue);
                outStream.Write(someBytes, 0, someBytes.Length);
            }
        }
    }
}
