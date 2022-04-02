using Lab_3_1;
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
        }

        private void Calculate()
        {
            try
            {
                l31.a = Convert.ToInt32(textBox1A.Text);
                l31.b = Convert.ToSingle(textBox1B.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox1Result.Text = l31.GetResult().ToString();
            label1History.Text = $"History count: {l31.history.Count}";
            comboBox1History.Items.Add(l31.history.Count);
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

        private void button1History_Click(object sender, EventArgs e)
        {
            if (comboBox1History.SelectedIndex >= 0)
                MessageBox.Show($"Calculation: {l31.history[comboBox1History.SelectedIndex].n.ToString()}\n" +
                    $"A: {l31.history[comboBox1History.SelectedIndex].a.ToString()}\n" +
                    $"B: {l31.history[comboBox1History.SelectedIndex].b.ToString()}\n" +
                    $"Result: {l31.history[comboBox1History.SelectedIndex].res.ToString()}",
                    "Calculation history", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
