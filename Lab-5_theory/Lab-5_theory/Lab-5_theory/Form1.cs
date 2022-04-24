using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_theory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Создание художника и привязка его к холсту graphWind/
            Graphics g = graphWind.CreateGraphics();

            // Создание и установка цвета пера
            Pen myPen = new Pen(Color.Red);             // Красный цвет

            int nmbInterv = 100;                        // Количество точек на графике
            float xmin = 0, xmax = 2;                   // Диапазон изменения аргумента x
            float xstep = (xmax - xmin) / nmbInterv;    // Шаг по аргументу

            float ymin = 0, ymax = xmax * xmax;         // Диапазон изменения функции y=x^2

            // Коэффициенты пересчета абсолютных координат в координаты холста
            float kx = graphWind.Width / (xmax - xmin), ky = graphWind.Height / (ymax - ymin);

            float x1 = xmin, y1 = x1 * x1;              // Первая точка графика

            for (int i = 0; i < nmbInterv; i++)
            {
                float x2 = x1 + xstep;                  // Координаты
                float y2 = x2 * x2;                     // следующей точки графика

                // Рисование отрезка между точками (x1, y1) и (x2, y2)
                g.DrawLine(myPen, kx * x1, graphWind.Height - ky * y1, kx * x2, graphWind.Height - ky * y2);

                x1 = x2;
                y1 = y2;
            }

            // Вывод текста
            Font fnt = new Font("Arial", 10);           // Шрифт Arial, размер 10
            g.DrawString("y = x^2", fnt, new SolidBrush(Color.Blue), 10, 10);
        }
    }
}
