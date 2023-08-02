using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEventApp
{

    internal class Program : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X} Y : {e.Y}");
            Console.WriteLine($"Button : {e.Button} Clicks : {e.Clicks}");
            Console.WriteLine();
        }
        public Program(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new Program("마우스 이벤트 테스트"));
        }
    }
}