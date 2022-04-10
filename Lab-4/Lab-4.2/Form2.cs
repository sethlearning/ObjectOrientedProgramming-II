using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        L42R l42r = new L42R();
        L42C l42c = new L42C();

        private void Task1()
        {
            try
            {
                l42r.A = Convert.ToInt32(textBox1A.Text);
                l42r.B = Convert.ToDouble(textBox1B.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            l42r.Calculate();
            textBox1Result1.AppendText(l42r.ToString() + "\r\n");
        }

        private void Task2()
        {
            try
            {
                l42c.A = Convert.ToInt32(textBox1A.Text);
                l42c.B = Convert.ToDouble(textBox1B.Text);
                l42c.D = Convert.ToDouble(textBox1D.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            l42c.Calculate();
            textBox1Result1.AppendText(l42c.ToString() + "\r\n");
        }

        private void button2R_Click(object sender, EventArgs e) => Task1();

        private void textBox1AB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Task1();
        }

        private void button2C_Click(object sender, EventArgs e) => Task2();

        private void textBox1D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Task2();
        }
    }
}
