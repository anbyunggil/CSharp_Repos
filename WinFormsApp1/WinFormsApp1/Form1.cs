namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.�޽����ڽ� ���
            //MessageBox.Show("�ȳ��ϼ���. ������ ���α׷��Դϴ�.");
            //2. ����� �α׿� ���!
            //Trace.WriteLine(string.Format($"{System.DateTime.Now}: ��¸޽���"));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("C#�� ���� ���� ���� ȯ���մϴ�. ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "���� ������ ����� �Ͽ��µ�~~";
        }

        
    }
}