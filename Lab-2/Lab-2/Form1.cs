using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_1;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void l1()
        {
            Double a, b, result;

            try
            {
                a = Convert.ToDouble(textBox1A.Text);
                b = Convert.ToDouble(textBox1B.Text);

                result = Lab_class.Lab_1_1(a, b);
                textBox1S.Text = result.ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Incorrect data format");
            }

        }

        public void l2()
        {
            int result;
            int[] x = new int[5];

            try
            {
                x[0] = Convert.ToInt32(textBox2in1.Text);
                x[1] = Convert.ToInt32(textBox2in2.Text);
                x[2] = Convert.ToInt32(textBox2in3.Text);
                x[3] = Convert.ToInt32(textBox2in4.Text);
                x[4] = Convert.ToInt32(textBox2in5.Text);
    
                result = Lab_class.Lab_1_2(x);
    
                if (result > x[0])
                {
                    textBox2Result.Text = result.ToString();
                    label2NotGreater.Text = "";
                }
                else
                {
                    textBox2Result.Text = "";
                    label2NotGreater.Text = "Среднее арифметическое не больше первого элемента";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Incorrect data format");
            }
        }

        public void l3()
        {
            double xn, xk, x, h, resultFormula, resultSeries;
            x = h = resultFormula = resultSeries = default;

            int k = 0;
            TextBox[] textBox3X = { textBox3X1, textBox3X2, textBox3X3, textBox3X4, textBox3X5, textBox3X6, textBox3X7, textBox3X8, textBox3X9, textBox3X10, textBox3X11 };
            TextBox[] textBox3Y = { textBox3Y1, textBox3Y2, textBox3Y3, textBox3Y4, textBox3Y5, textBox3Y6, textBox3Y7, textBox3Y8, textBox3Y9, textBox3Y10, textBox3Y11 };
            TextBox[] textBox3S = { textBox3S1, textBox3S2, textBox3S3, textBox3S4, textBox3S5, textBox3S6, textBox3S7, textBox3S8, textBox3S9, textBox3S10, textBox3S11 };

            try
            {
                xn = Convert.ToDouble(textBox3xn.Text);
                xk = Convert.ToDouble(textBox3xk.Text);
    
                h = (xk - xn) / 10;
    
                for (x = xn; x <= xk + h/2; x += h)
                {
                    resultFormula = Lab_class.Lab_1_3_formula(x);
                    resultSeries = Lab_class.Lab_1_3_series(x);
    
                    textBox3X[k].Text = x.ToString();
                    textBox3Y[k].Text = resultFormula.ToString();
                    textBox3S[k].Text = resultSeries.ToString();
                    
                    k++;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Incorrect data format");
            }
        }

        public void l4()
        {
            string str;
            List<char> clist = new List<char>();
            List<char> cdigits = new List<char>();
            List<char> ccharacters = new List<char>();

            str = textBox4String.Text;

            foreach (char c in str)
                clist.Add(c);

            Lab_class.Lab_1_4(clist, ref cdigits, ref ccharacters);

            textBox4Digits.Text = new string(cdigits.ToArray());
            textBox4OtherSymbols.Text = new string(ccharacters.ToArray());
        }

        private void button1Process_Click(object sender, EventArgs e)
        {
            l1();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l1();
            }
        }

        private void button2Process_Click(object sender, EventArgs e)
        {
            l2();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l2();
            }
        }

        private void button3Process_Click(object sender, EventArgs e)
        {
            l3();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l3();
            }
        }

        private void button4Process_Click(object sender, EventArgs e)
        {
            l4();
        }

        private void textBox4String_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l4();
            }
        }
    }
}
