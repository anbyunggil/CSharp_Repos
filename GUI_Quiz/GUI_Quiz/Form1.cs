using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            using (Stream s = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sw = new StreamReader(s))
                {
                    textBox2.Text = sw.ReadToEnd();
                }
            }
        }
    }
}
