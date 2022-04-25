using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitRoutine(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Close the application?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
                Application.Exit();
        }

        private void jPGFileOpenHandler(object sender, EventArgs e)
        {
            LoadImage(FileType.jpeg);
        }

        private void bMPFileOpenHandler(object sender, EventArgs e)
        {
            LoadImage(FileType.bmp);
        }

        //string currentPath = "";
        string fileName = "";
        Image im;
        ImagingMode imode;

        private void LoadImage(FileType fileType)
        {
            /*
            if (currentPath == "")
                openFileDialog.InitialDirectory = "c:\\";
            else
                openFileDialog.InitialDirectory = currentPath;
            */
            //currentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            switch (fileType)
            {
                case FileType.jpeg:
                    openFileDialog.Filter = "Image (JPEG) Files (*.jpeg, *.jpg)|*.jpeg;*.jpg|All files (*.*)|*.*";
                    break;
                case FileType.bmp:
                    openFileDialog.Filter = "Image (BMP) Files (*.bmp)|*.bmp|All files (*.*)|*.*";
                    break;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                openFileDialog.FileName = "";

                try
                {
                    changeLayout(ImagingMode.pictureBoxImage);

                    im = Image.FromFile(fileName);
                    pictureBox.Image = im;

                    textBox.Clear();
                    textBox.AppendText($"File loaded: {fileName}");
                    labelFileName.Text = $"FileName: {Path.GetFileName(fileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void getControlType(object sender, EventArgs e)
        {
            Control sourceControl = null;

            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    sourceControl = owner.SourceControl;
                    labelControl.Text = sourceControl.Name;
                }
            }
        }

        private void getImageOrGraphicProperties(object sender, EventArgs e)
        {
            switch(imode)
            {
                case ImagingMode.pictureBoxImage:
                    textBox.AppendText($"\r\nWidth: {im.Width} px, Height: {im.Height} px");
                    break;
                case ImagingMode.pictureBoxGraphic1:
                case ImagingMode.chartGraphic1:
                    textBox.AppendText($"\r\nXmin: 0, Xmax = 6Pi");
                    break;
                case ImagingMode.chartGraphic2:
                    textBox.AppendText($"\r\nXn: 0, Xk = 1");
                    break;
            }
        }

        private void changeLayout(ImagingMode imch)
        {
            switch (imch)
            {
                case ImagingMode.pictureBoxImage:
                    imode = ImagingMode.pictureBoxImage;
                    contextGetProperties.Text = "Get image properties";
                    if (!pictureBox.Visible)
                        pictureBox.Show();
                    if (chart.Visible)
                        chart.Hide();
                    break;
                case ImagingMode.pictureBoxGraphic1:
                    imode = ImagingMode.pictureBoxGraphic1;
                    contextGetProperties.Text = "Get graphic properties";
                    if (!pictureBox.Visible)
                        pictureBox.Show();
                    if (chart.Visible)
                        chart.Hide();
                    pictureBox.Image = null;
                    pictureBox.Refresh();
                    break;
                case ImagingMode.chartGraphic1:
                    imode = ImagingMode.chartGraphic1;
                    contextGetProperties.Text = "Get graphic properties";
                    if (pictureBox.Visible)
                        pictureBox.Hide();
                    if (!chart.Visible)
                        chart.Show();
                    break;
                case ImagingMode.chartGraphic2:
                    imode = ImagingMode.chartGraphic2;
                    contextGetProperties.Text = "Get graphic properties";
                    if (pictureBox.Visible)
                        pictureBox.Hide();
                    if (!chart.Visible)
                        chart.Show();
                    break;
            }
        }

        private void drawGraphic1(object sender, EventArgs e)
        {
            try
            {
                changeLayout(ImagingMode.pictureBoxGraphic1);

                Graphics g = pictureBox.CreateGraphics();

                Pen pbPen = new Pen(Color.Red, (float)1.5);

                int pointsCount = 100;
                float xmin = 0, xmax = (float)(6 * Math.PI);
                float xstep = (xmax - xmin) / pointsCount;

                float ymin = -3, ymax = 3;

                float kx = pictureBox.Width / (xmax - xmin);
                float ky = pictureBox.Height / (ymax - ymin);

                float x1 = xmin, y1 = f(xmin);
                float x2, y2;

                float pby1, pby2;

                for (int i = 0; i < pointsCount; i++)
                {
                    x2 = x1 + xstep;
                    y2 = f(x2);

                    pby1 = pictureBox.Height / 2 - ky * y1;
                    pby2 = pictureBox.Height / 2 - ky * y2;

                    g.DrawLine(pbPen, kx * x1, pby1, kx * x2, pby2);

                    x1 = x2;
                    y1 = y2;
                }

                textBox.Clear();
                textBox.AppendText("Graphic function: Sin(x) - Sin(2Pi - x)");


                //Font fnt = new Font("Arial", 10);
                //g.DrawString($"Sin(x) - Sin(2Pi - x)", fnt, new SolidBrush(Color.Blue), 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void chartGraphic1(object sender, EventArgs e)
        {
            try
            {
                changeLayout(ImagingMode.chartGraphic1);
                //float a = Convert.ToSingle(textBox12A.Text);

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

                chart.Series[serie].LegendText = $"Sin(x) - Sin(2Pi - x)";

                for (int i = 0; i < pointsCount; i++)
                {
                    y = f(x);
                    chart.Series[serie].Points.AddXY(x, y);

                    x += xstep;
                }

                textBox.Clear();
                textBox.AppendText("Graphic function: Sin(x) - Sin(2Pi - x)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chartGraphic2(object sender, EventArgs e)
        {
            try
            {
                changeLayout(ImagingMode.chartGraphic2);
                // double xn = Convert.ToDouble(textBox4Xn.Text);
                // double xk = Convert.ToDouble(textBox4Xk.Text);

                double xn = 0;
                double xk = 1;

                int pointsCount = 100;
                double xstep = (xk - xn) / pointsCount;
                double x = xn, y1, y2;

                chart.Series.Clear();
                CreateDefaultChartSeries();

                for (int i = 0; i < pointsCount; i++)
                {
                    y1 = formula(x);
                    chart.Series[0].Points.AddXY(x, y1);

                    y2 = series(x);
                    chart.Series[1].Points.AddXY(x, y2);

                    chart.Series[2].Points.AddXY(x, y2 - y1);

                    x += xstep;
                }

                textBox.Clear();
                textBox.AppendText("Graphic functions: (e^x - e^-x)/2; E x^2n+1/(2n+1)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
