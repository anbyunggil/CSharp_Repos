using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;
            String grade;
            if (textBox1.Text == " ")
            {
                MessageBox.Show("점수를 입력하세요", "경고 1");
                goto Nagayo;
            }
            score = int.Parse(textBox1.Text);
            if(score >= 100 || score <= 0)
            {
                MessageBox.Show("0~100 사이의 숫자를 입력하세요", "경고 2");
                goto Nagayo;
            }
            if (score >= 96)
                grade = "A+";
            else if (score >= 91)
                grade = "A0";
            else if (score >= 86)
                grade = "B+";
            else if (score >= 81)
                grade = "B0";
            else if (score >= 76)
                grade = "C+";
            else if (score >= 71)
                grade = "C0";
            else if (score >= 66)
                grade = "D+";
            else if (score >= 60)
                grade = "D0";
            else
                grade = "F : 재수강";
            textBox2.Text = grade;
        Nagayo: textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }
    }
}
