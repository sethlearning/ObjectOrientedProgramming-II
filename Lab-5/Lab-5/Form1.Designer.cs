namespace Lab_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1Clear = new System.Windows.Forms.Button();
            this.textBox11A = new System.Windows.Forms.TextBox();
            this.label11A = new System.Windows.Forms.Label();
            this.button1Draw = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2Clear = new System.Windows.Forms.Button();
            this.textBox12A = new System.Windows.Forms.TextBox();
            this.label12A = new System.Windows.Forms.Label();
            this.button2Draw = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3Clear = new System.Windows.Forms.Button();
            this.button3Draw = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox4Xk = new System.Windows.Forms.TextBox();
            this.label4Xk = new System.Windows.Forms.Label();
            this.textBox4Xn = new System.Windows.Forms.TextBox();
            this.label3Xn = new System.Windows.Forms.Label();
            this.button4Clear = new System.Windows.Forms.Button();
            this.button4Draw = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 549);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button1Clear);
            this.tabPage1.Controls.Add(this.textBox11A);
            this.tabPage1.Controls.Add(this.label11A);
            this.tabPage1.Controls.Add(this.button1Draw);
            this.tabPage1.Controls.Add(this.pb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1-1";
            // 
            // button1Clear
            // 
            this.button1Clear.Location = new System.Drawing.Point(423, 485);
            this.button1Clear.Name = "button1Clear";
            this.button1Clear.Size = new System.Drawing.Size(75, 23);
            this.button1Clear.TabIndex = 5;
            this.button1Clear.Text = "Clear";
            this.button1Clear.UseVisualStyleBackColor = true;
            this.button1Clear.Click += new System.EventHandler(this.button1Clear_Click);
            // 
            // textBox11A
            // 
            this.textBox11A.Location = new System.Drawing.Point(30, 485);
            this.textBox11A.Name = "textBox11A";
            this.textBox11A.Size = new System.Drawing.Size(100, 20);
            this.textBox11A.TabIndex = 4;
            this.textBox11A.Text = "1";
            this.textBox11A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox11A.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            this.textBox11A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox11A_KeyDown);
            // 
            // label11A
            // 
            this.label11A.AutoSize = true;
            this.label11A.Location = new System.Drawing.Point(7, 488);
            this.label11A.Name = "label11A";
            this.label11A.Size = new System.Drawing.Size(17, 13);
            this.label11A.TabIndex = 3;
            this.label11A.Text = "A:";
            // 
            // button1Draw
            // 
            this.button1Draw.Location = new System.Drawing.Point(329, 485);
            this.button1Draw.Name = "button1Draw";
            this.button1Draw.Size = new System.Drawing.Size(75, 23);
            this.button1Draw.TabIndex = 2;
            this.button1Draw.Text = "Draw";
            this.button1Draw.UseVisualStyleBackColor = true;
            this.button1Draw.Click += new System.EventHandler(this.button1Draw_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Location = new System.Drawing.Point(5, 5);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(778, 470);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button2Clear);
            this.tabPage2.Controls.Add(this.textBox12A);
            this.tabPage2.Controls.Add(this.label12A);
            this.tabPage2.Controls.Add(this.button2Draw);
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task1-2";
            // 
            // button2Clear
            // 
            this.button2Clear.Location = new System.Drawing.Point(423, 485);
            this.button2Clear.Name = "button2Clear";
            this.button2Clear.Size = new System.Drawing.Size(75, 23);
            this.button2Clear.TabIndex = 6;
            this.button2Clear.Text = "Clear";
            this.button2Clear.UseVisualStyleBackColor = true;
            this.button2Clear.Click += new System.EventHandler(this.button2Clear_Click);
            // 
            // textBox12A
            // 
            this.textBox12A.Location = new System.Drawing.Point(30, 485);
            this.textBox12A.Name = "textBox12A";
            this.textBox12A.Size = new System.Drawing.Size(100, 20);
            this.textBox12A.TabIndex = 5;
            this.textBox12A.Text = "1";
            this.textBox12A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox12A.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            this.textBox12A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox12A_KeyDown);
            // 
            // label12A
            // 
            this.label12A.AutoSize = true;
            this.label12A.Location = new System.Drawing.Point(7, 488);
            this.label12A.Name = "label12A";
            this.label12A.Size = new System.Drawing.Size(17, 13);
            this.label12A.TabIndex = 4;
            this.label12A.Text = "A:";
            // 
            // button2Draw
            // 
            this.button2Draw.Location = new System.Drawing.Point(329, 485);
            this.button2Draw.Name = "button2Draw";
            this.button2Draw.Size = new System.Drawing.Size(75, 23);
            this.button2Draw.TabIndex = 3;
            this.button2Draw.Text = "Draw";
            this.button2Draw.UseVisualStyleBackColor = true;
            this.button2Draw.Click += new System.EventHandler(this.button2Draw_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.AxisX.LabelStyle.Format = "N2";
            chartArea9.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea9);
            legend9.DockedToChartArea = "ChartArea1";
            legend9.Name = "Legend1";
            this.chart.Legends.Add(legend9);
            this.chart.Location = new System.Drawing.Point(6, 6);
            this.chart.Name = "chart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart.Series.Add(series9);
            this.chart.Size = new System.Drawing.Size(775, 460);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.button3Clear);
            this.tabPage3.Controls.Add(this.button3Draw);
            this.tabPage3.Controls.Add(this.pb2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task 2";
            // 
            // button3Clear
            // 
            this.button3Clear.Location = new System.Drawing.Point(423, 485);
            this.button3Clear.Name = "button3Clear";
            this.button3Clear.Size = new System.Drawing.Size(75, 23);
            this.button3Clear.TabIndex = 2;
            this.button3Clear.Text = "Clear";
            this.button3Clear.UseVisualStyleBackColor = true;
            this.button3Clear.Click += new System.EventHandler(this.button3Clear_Click);
            // 
            // button3Draw
            // 
            this.button3Draw.Location = new System.Drawing.Point(329, 485);
            this.button3Draw.Name = "button3Draw";
            this.button3Draw.Size = new System.Drawing.Size(75, 23);
            this.button3Draw.TabIndex = 1;
            this.button3Draw.Text = "Draw";
            this.button3Draw.UseVisualStyleBackColor = true;
            this.button3Draw.Click += new System.EventHandler(this.button3Draw_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Location = new System.Drawing.Point(5, 5);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(778, 470);
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.textBox4Xk);
            this.tabPage4.Controls.Add(this.label4Xk);
            this.tabPage4.Controls.Add(this.textBox4Xn);
            this.tabPage4.Controls.Add(this.label3Xn);
            this.tabPage4.Controls.Add(this.button4Clear);
            this.tabPage4.Controls.Add(this.button4Draw);
            this.tabPage4.Controls.Add(this.chart2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 523);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Task 3";
            // 
            // textBox4Xk
            // 
            this.textBox4Xk.Location = new System.Drawing.Point(185, 484);
            this.textBox4Xk.Name = "textBox4Xk";
            this.textBox4Xk.Size = new System.Drawing.Size(100, 20);
            this.textBox4Xk.TabIndex = 6;
            this.textBox4Xk.Text = "1";
            this.textBox4Xk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4Xk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label4Xk
            // 
            this.label4Xk.AutoSize = true;
            this.label4Xk.Location = new System.Drawing.Point(156, 487);
            this.label4Xk.Name = "label4Xk";
            this.label4Xk.Size = new System.Drawing.Size(23, 13);
            this.label4Xk.TabIndex = 5;
            this.label4Xk.Text = "Xk:";
            // 
            // textBox4Xn
            // 
            this.textBox4Xn.Location = new System.Drawing.Point(37, 484);
            this.textBox4Xn.Name = "textBox4Xn";
            this.textBox4Xn.Size = new System.Drawing.Size(100, 20);
            this.textBox4Xn.TabIndex = 4;
            this.textBox4Xn.Text = "0";
            this.textBox4Xn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4Xn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label3Xn
            // 
            this.label3Xn.AutoSize = true;
            this.label3Xn.Location = new System.Drawing.Point(8, 487);
            this.label3Xn.Name = "label3Xn";
            this.label3Xn.Size = new System.Drawing.Size(23, 13);
            this.label3Xn.TabIndex = 3;
            this.label3Xn.Text = "Xn:";
            // 
            // button4Clear
            // 
            this.button4Clear.Location = new System.Drawing.Point(423, 485);
            this.button4Clear.Name = "button4Clear";
            this.button4Clear.Size = new System.Drawing.Size(75, 23);
            this.button4Clear.TabIndex = 2;
            this.button4Clear.Text = "Clear";
            this.button4Clear.UseVisualStyleBackColor = true;
            this.button4Clear.Click += new System.EventHandler(this.button4Clear_Click);
            // 
            // button4Draw
            // 
            this.button4Draw.Location = new System.Drawing.Point(329, 485);
            this.button4Draw.Name = "button4Draw";
            this.button4Draw.Size = new System.Drawing.Size(75, 23);
            this.button4Draw.TabIndex = 1;
            this.button4Draw.Text = "Draw";
            this.button4Draw.UseVisualStyleBackColor = true;
            this.button4Draw.Click += new System.EventHandler(this.button4Draw_Click);
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.DockedToChartArea = "ChartArea1";
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.MarkerSize = 50;
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(775, 460);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 551);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Lab-5";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button button1Draw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button2Draw;
        private System.Windows.Forms.Button button2Clear;
        private System.Windows.Forms.TextBox textBox12A;
        private System.Windows.Forms.Label label12A;
        private System.Windows.Forms.Label label11A;
        private System.Windows.Forms.Button button1Clear;
        private System.Windows.Forms.TextBox textBox11A;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button button3Draw;
        private System.Windows.Forms.Button button3Clear;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button4Clear;
        private System.Windows.Forms.Button button4Draw;
        private System.Windows.Forms.TextBox textBox4Xk;
        private System.Windows.Forms.Label label4Xk;
        private System.Windows.Forms.TextBox textBox4Xn;
        private System.Windows.Forms.Label label3Xn;
    }
}

