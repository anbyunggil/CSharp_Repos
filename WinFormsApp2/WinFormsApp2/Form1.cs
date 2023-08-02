namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 입니다!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#의 세상에 오신 것을 환영합니다!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "누르지말라고 했지!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}