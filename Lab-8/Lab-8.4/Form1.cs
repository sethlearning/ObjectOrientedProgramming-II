using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // public bool paintMode = false;
        public Point? pt;
        private readonly Pen redPen = new Pen(Color.Red, 2);
        private readonly Pen bluePen = new Pen(Color.Blue, 2);
        private readonly Pen grayPen = new Pen(Color.Gray, 2);


        // private void Form1_MouseDown(object sender, MouseEventArgs e) => paintMode = true;

        // private void Form1_MouseUp(object sender, MouseEventArgs e) => paintMode = false;

        // private void Form1_MouseLeave(object sender, EventArgs e) => paintMode = false;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None && pt != null)
            {
                Graphics g = this.CreateGraphics();
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        g.DrawLine(redPen, (Point)pt, e.Location);
                        break;
                    case MouseButtons.Right:
                        g.DrawLine(bluePen, (Point)pt, e.Location);
                        break;
                    case MouseButtons.Middle:
                        g.DrawLine(grayPen, (Point)pt, e.Location);
                        break;
                }
            }
            pt = e.Location;
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
