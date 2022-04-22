using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        private void button1Draw_Click(object sender, EventArgs e)
        {
            ClearPb(pb);
            drawPb();
        }

        private void button1Clear_Click(object sender, EventArgs e)
        {
            ClearPb(pb);
        }

        private void button2Draw_Click(object sender, EventArgs e)
        {
            drawChart();
        }

        private void button2Clear_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            CreateDefaultChartSeries();
        }

        private void button3Draw_Click(object sender, EventArgs e)
        {
            drawRandomFigures();
        }

        private void button3Clear_Click(object sender, EventArgs e)
        {
            ClearPb(pb2);
        }

        private void button4Draw_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            drawChart2();
        }

        private void button4Clear_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            CreateDefaultChart2Series();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (textBox12A.Text != textBox11A.Text)
            {
                TextBox tb = sender as TextBox;

                if (tb.Name == "textBox11A")
                    textBox12A.Text = textBox11A.Text;
                else if (tb.Name == "textBox12A")
                    textBox11A.Text = textBox12A.Text;
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        ClearPb(pb);
                        break;
                    case 1:
                        chart.Series.Clear();
                        CreateDefaultChartSeries();
                        break;
                    case 2:
                        ClearPb(pb2);
                        break;
                    case 3:
                        chart2.Series.Clear();
                        CreateDefaultChart2Series();
                        break;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        ClearPb(pb);
                        drawPb();
                        break;
                    case 1:
                        drawChart();
                        break;
                    case 2:
                        drawRandomFigures();
                        break;
                    case 3:
                        chart2.Series.Clear();
                        drawChart2();
                        break;
                }
                e.Handled = true;
            }
        }
    }
}
