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
            MessageBox.Show("��ư �Դϴ�!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#�� ���� ���� ���� ȯ���մϴ�!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "����������� ����!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}