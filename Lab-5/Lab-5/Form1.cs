﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart.Series.Clear();
            CreateDefaultChartSeries();
            chart2.Series.Clear();
            CreateDefaultChart2Series();
        }
        
        /////////////////////////////////
        // Task 1-1

        // Sin(x) - Sin(2Pi - ax)
        float f(float a, float x) => (float)(Math.Sin(x) - Math.Sin(2 * Math.PI - a * x));

        void drawPb()
        {
            try
            {
                float a = Convert.ToSingle(textBox11A.Text);

                Graphics g = pb.CreateGraphics();

                Pen pbPen = new Pen(Color.Red, (float)1.5);

                int pointsCount = 100;
                float xmin = 0, xmax = (float)(6 * Math.PI);
                float xstep = (xmax - xmin) / pointsCount;

                float ymin = -3, ymax = 3;

                float kx = pb.Width / (xmax - xmin);
                float ky = pb.Height / (ymax - ymin);

                float x1 = xmin, y1 = f(a, xmin);
                float x2, y2;

                float pby1, pby2;

                for (int i = 0; i < pointsCount; i++)
                {
                    x2 = x1 + xstep;
                    y2 = f(a, x2);

                    pby1 = pb.Height / 2 - ky * y1;
                    pby2 = pb.Height / 2 - ky * y2;

                    g.DrawLine(pbPen, kx * x1, pby1, kx * x2, pby2);

                    x1 = x2;
                    y1 = y2;
                }

                Font fnt = new Font("Arial", 10);
                g.DrawString($"Sin(x) - Sin(2Pi - {a}x)", fnt, new SolidBrush(Color.Blue), 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //////////////////////////////
        // Task 1-2
        void drawChart()
        {
            try
            {
                float a = Convert.ToSingle(textBox12A.Text);

                int pointsCount = 100;
                float xmin = 0, xmax = (float)(6 * Math.PI);
                float xstep = (xmax - xmin) / pointsCount;

                float x = xmin, y;

                chart.Series.Clear();
                chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
                int serie = chart.Series.Count - 1;

                Random r = new Random();

                chart.Series[serie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                if (serie == 0)
                    chart.Series[serie].Color = Color.Blue;
                else
                    chart.Series[serie].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

                chart.Series[serie].LegendText = $"Sin(x) - Sin(2Pi - {a}x)";

                for (int i = 0; i < pointsCount; i++)
                {
                    y = f(a, x);
                    chart.Series[serie].Points.AddXY(x, y);

                    x += xstep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CreateDefaultChartSeries()
        {
            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Blue;
            chart.Series[0].LegendText = $"Sin(x) - Sin(2Pi - ax)";
        }

        void ClearPb(PictureBox pb)
        {
            Graphics g = pb.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, pb.Width, pb.Height);
            SolidBrush br = new SolidBrush(pb.BackColor);
            g.FillRectangle(br, rect);
        }

        //////////////////////////////
        // Task 2
        void drawRandomFigures()
        {
            Graphics g2 = pb2.CreateGraphics();

            int i, d, n, figurecount, figure;
            Color clr;
            Pen pn;
            Brush br;
            Font fnt;
            Char ch;
            Random r = new Random();

            figurecount = r.Next(100);

            for (i = 0; i < figurecount; i++)
            {
                figure = r.Next(5);
                clr = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                pn = new Pen(clr);

                switch (figure)
                {
                    case 0:
                        g2.DrawLine(pn, r.Next(pb2.Width), r.Next(pb2.Height), r.Next(pb2.Width), r.Next(pb2.Height));
                        break;
                    case 1:
                        d = r.Next(pb.Height);
                        g2.DrawEllipse(pn, r.Next(pb2.Width), r.Next(pb2.Height), d, d);
                        break;
                    case 2:
                        g2.DrawEllipse(pn, r.Next(pb2.Width), r.Next(pb2.Height), r.Next(pb2.Height), r.Next(pb2.Height));
                        break;
                    case 3:
                        g2.DrawRectangle(pn, r.Next(pb2.Width), r.Next(pb2.Height), r.Next(pb2.Width), r.Next(pb2.Height));
                        break;
                    case 4:
                        fnt = new Font("Arial", r.Next(1,48));
                        br = new SolidBrush(clr);
                        n = r.Next(52);
                        ch = n < 26 ? Char.ToUpper((char)('a' + n)) : (char)('a' + n - 26);
                        g2.DrawString(ch.ToString(), fnt, br, r.Next(pb2.Width), r.Next(pb2.Height));
                        break;
                }
            }
        }

        /////////////////////////////
        // Task 3
        void drawChart2()
        {
            try
            {
                double xn = Convert.ToDouble(textBox4Xn.Text);
                double xk = Convert.ToDouble(textBox4Xk.Text);

                int pointsCount = 100;
                double xstep = (xk - xn) / pointsCount;
                double x = xn, y1, y2;

                CreateDefaultChart2Series();

                for (int i = 0; i < pointsCount; i++)
                {
                    y1 = formula(x);
                    chart2.Series[0].Points.AddXY(x, y1);

                    y2 = series(x);
                    chart2.Series[1].Points.AddXY(x, y2);

                    chart2.Series[2].Points.AddXY(x, y2 - y1);

                    x += xstep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void CreateDefaultChart2Series()
        {
            chart2.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart2.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart2.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());

            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].Color = Color.Red;
            chart2.Series[0].BorderWidth = 2;
            chart2.Series[0].LegendText = "(e^x - e^-x)/2";

            chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[1].Color = Color.Blue;
            chart2.Series[1].BorderWidth = 1;
            chart2.Series[1].LegendText = "E x^2n+1/(2n+1)!";

            chart2.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[2].Color = Color.Orange;
            chart2.Series[2].LegendText = "Functions delta";
        }

        static public double formula(double x)
        {
            double result = 0;

            result = (Math.Exp(x) - Math.Exp(-x)) / 2;

            return result;
        }

        static public double series(double x)
        {
            double result, xp, fn;
            result = xp = fn = default;
            int n, N = 12;

            result = x;
            xp = x;
            fn = 1;

            for (n = 1; n <= N; n++)
            {
                xp *= x * x;
                fn *= 2 * n * (2 * n + 1);

                result += xp / fn;
            }

            return result;
        }
    }
}
