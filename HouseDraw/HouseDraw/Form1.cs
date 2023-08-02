using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseDraw
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen BlackPen = new Pen(Color.Black, 3);
            Pen BluePen = new Pen(Color.Blue, 3);
            Pen RedPen = new Pen(Color.Red, 3);

            Rectangle rectangle = new Rectangle(50, 50, 200, 200);
            g.DrawRectangle(BlackPen, rectangle);

            Point pt1 = new Point(50, 50);
            Point pt2 = new Point(250, 250);
            g.DrawLine(BluePen, pt1, pt2);
            Point pt3 = new Point(250, 50);
            Point pt4 = new Point(50, 250);
            g.DrawLine(BluePen, pt3, pt4);

            RectangleF recf = new RectangleF(50, 50, 200, 200);
            g.DrawEllipse(BluePen, recf);
            Brush blueBrush = new SolidBrush(Color.Blue);
            g.FillEllipse(blueBrush, recf);

            Point pt5 = new Point(50, 50);
            Point pt6 = new Point(250, 50);
            Point pt7 = new Point(150, 0);

            Point[] pt = { pt5, pt6, pt7 };
            Brush RedBrush = new SolidBrush(Color.Red);
            g.DrawPolygon(RedPen, pt);
            g.FillPolygon(RedBrush, pt);
        }
    }
}
