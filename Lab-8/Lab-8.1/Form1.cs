using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show($"Click event: {e.Button} button", "Click event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 f = sender as Form1;
            Graphics g = f.CreateGraphics();
            g.DrawString(e.Button.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), e.Location);
        }
    }
}
