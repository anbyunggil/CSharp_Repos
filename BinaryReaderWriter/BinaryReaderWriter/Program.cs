using System.IO;
using System.Threading;

namespace BinaryReaderWriter
{
    internal class Program
    {
        static void Run(string path, byte[] picture)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(picture);
                bw.Flush();
                bw.Close();
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\pic.png";
            byte[] picture;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length);
                br.Close();
            }
            path = "C:\\Temp\\pic2.png";

            Thread t1 = new Thread(()=> Run(path, picture));
            t1.Name = "Thread-1";
            t1.Start();
            t1.IsBackground = true;
            t1.Join();



        }
    }
}
