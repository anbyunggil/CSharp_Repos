namespace RandomColorApp
{
    public partial class Form1 : Form
    {
        private Random rand;
        public Form1()
        {
            InitializeComponent();  //������

            Load += Form1_Load;
            MouseClick += RandomColorAction;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
        }
        
        //����� ���� �޼ҵ�
        private void RandomColorAction(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);   
            int purple = rand.Next(0, 256);
            int yellow = rand.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}