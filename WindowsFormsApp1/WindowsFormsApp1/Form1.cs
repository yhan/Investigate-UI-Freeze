using System;
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
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer
            { 
                Interval = 1000,
            };
            timer.Tick +=Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++; 
            Thread.Sleep(500);
            this.label1.Text = $"DONE  - {counter}";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                
            }
        }
    }
}