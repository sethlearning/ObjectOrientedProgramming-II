using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {

        // Sin(x) - Sin(2Pi - x)
        float f(float x) => (float)(Math.Sin(x) - Math.Sin(2 * Math.PI - x));


        void CreateDefaultChartSeries()
        {
            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());

            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            chart.Series[0].BorderWidth = 2;
            chart.Series[0].LegendText = "(e^x - e^-x)/2";

            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[1].Color = Color.Blue;
            chart.Series[1].BorderWidth = 1;
            chart.Series[1].LegendText = "E x^2n+1/(2n+1)!";

            chart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[2].Color = Color.Orange;
            chart.Series[2].LegendText = "Functions delta";
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
