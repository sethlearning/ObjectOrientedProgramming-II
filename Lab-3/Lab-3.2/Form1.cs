using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                l32.a = Convert.ToInt32(textBox1A.Text);
                l32.b = Convert.ToSingle(textBox1B.Text);
                l32.d = Convert.ToSingle(textBox1D.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox1Result.Text = l32.c2.ToString();
        }

        private void button1Process_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate();
            }
        }
    }
}
