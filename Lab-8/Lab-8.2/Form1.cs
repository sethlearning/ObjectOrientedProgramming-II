using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 f;
            Graphics g;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    f = sender as Form1;
                    g = f.CreateGraphics();
                    g.DrawLine(new Pen(Color.Blue, 2), new Point(f.ClientSize.Width, f.ClientSize.Height - statusStrip1.Height), e.Location);
                    break;
                case MouseButtons.Right:
                    f = sender as Form1;
                    g = f.CreateGraphics();
                    g.DrawLine(new Pen(Color.Red, 2), new Point(0, 0), e.Location);
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1 f = sender as Form1;
                Graphics g = f.CreateGraphics();
                g.Clear(f.BackColor);
            }
        }
    }
}
