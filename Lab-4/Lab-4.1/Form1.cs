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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        L41 l41 = new L41();

        private void Task1()
        {
            try
            {
                l41.A = Convert.ToInt32(textBox1A.Text);
                l41.B = Convert.ToDouble(textBox1B.Text);
                l41.D = Convert.ToDouble(textBox1D.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            l41.CalculateResult();
            textBox1Result1.AppendText("CalculateResult()\r\nResult = " + l41.Result.ToString() + "\r\n\r\n");

            l41.CalculateResult(15);
            l41.CalculateC();
            textBox1Result1.AppendText("CalculateResult(15)\r\nCalculateC()\r\n" + l41.ToString() + "\r\n\r\n");

            l41.CalculateResult(10.8);
            l41.CalculateC(5);
            textBox1Result1.AppendText(l41.ToString("CalculateResult(10.8) = ", "\r\nCalculateC(5) = ") + "\r\n\r\n");

            l41.CalculateResult(20, 35.5);
            l41.CalculateC(15, 20, 25);
            textBox1Result1.AppendText(l41.ToString("CalculateResult(20, 35.5) = ", "\r\nCalculateC(15, 20, 25) = ") + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Task1();
        }
    }
}
