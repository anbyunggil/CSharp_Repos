using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\temp\\A1.txt";

            string copyPath = "C:\\temp\\B1.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))

            {

                FileInfo fi = new FileInfo(path);

                FileInfo dst = fi.CopyTo(copyPath);

            }
        }
    }
}
