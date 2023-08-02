using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //임베디드 프로그래밍 50% I/O입출력
            //리눅스 모든것이 File --> low level --> byte[]

            //File과 FileInfo
            //FileStream fs = File.Create("a.dat");
            File.Copy("a.dat", "d.dat");

            FileInfo file = new FileInfo("b.dat");
            FileStream fs = file.Create(); //생성
            fs.Close();
            FileInfo src = new FileInfo("b.dat");
            FileInfo dst = src.CopyTo("e.dat");

            File.Delete("a.dat");
        }
    }
}
