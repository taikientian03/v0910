using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0910
{
    public partial class Form1 : Form
    {
        static Random raed = new Random();
        int vx = raed.Next(-15, 15);
        int vy = raed.Next(-15, 15);

        public Form1()
        {
            InitializeComponent();

            label1.Left = raed.Next(ClientSize.Width - label1.Width);
            label1.Top = raed.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = Math.Abs(vy);
            }
            if(label1.Right>ClientSize.Width)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Bottom>ClientSize.Height)
            {
                vy = Math.Abs(vy);
            }
        }
    }
}
