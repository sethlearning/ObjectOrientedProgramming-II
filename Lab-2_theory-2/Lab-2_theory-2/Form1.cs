using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_theory_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = 0, x, y;
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("You haven't chosen the function");
            else
                try
                {
                    x = Convert.ToDouble(textBox1.Text);
                    y = Convert.ToDouble(textBox2.Text);
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            F = (Math.Sin(x) * Math.Pow(y - 2, 0.5)) / (x + 1.0);
                            break;
                        case 1:
                            F = Math.Cos(x) / x * y * y;
                            break;
                        case 2:
                            F = Math.Pow(x, 3.0 / 2.0) / 7 * y;
                            break;
                    }
                    textBox3.Text = Convert.ToString(F);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Wrond data");
                }
        }
    }
}
