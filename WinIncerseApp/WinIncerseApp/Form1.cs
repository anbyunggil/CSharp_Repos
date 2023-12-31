﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinIncerseApp
{
    public partial class Form1 : Form
    {
        public int count = 0;
        private Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    try 
                    {
                        Invoke((Action)(() => label1.Text = count++ + ""));
                        Thread.Sleep(1000);
                    }
                    catch(Exception ex)
                    {
                        
                            break;
                    }
                }
            });

            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Interrupt();
        }
    }
}
