namespace Lab_3
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
            this.label1Lab31 = new System.Windows.Forms.Label();
            this.label1A = new System.Windows.Forms.Label();
            this.textBox1A = new System.Windows.Forms.TextBox();
            this.label1B = new System.Windows.Forms.Label();
            this.textBox1B = new System.Windows.Forms.TextBox();
            this.button1Process = new System.Windows.Forms.Button();
            this.label1History = new System.Windows.Forms.Label();
            this.comboBox1History = new System.Windows.Forms.ComboBox();
            this.button1History = new System.Windows.Forms.Button();
            this.textBox1Result = new System.Windows.Forms.TextBox();
            this.label1Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Lab31
            // 
            this.label1Lab31.AutoSize = true;
            this.label1Lab31.Location = new System.Drawing.Point(13, 13);
            this.label1Lab31.Name = "label1Lab31";
            this.label1Lab31.Size = new System.Drawing.Size(175, 13);
            this.label1Lab31.TabIndex = 0;
            this.label1Lab31.Text = "Вычисление функции: a+b*b/(a-1)";
            // 
            // label1A
            // 
            this.label1A.AutoSize = true;
            this.label1A.Location = new System.Drawing.Point(16, 49);
            this.label1A.Name = "label1A";
            this.label1A.Size = new System.Drawing.Size(17, 13);
            this.label1A.TabIndex = 1;
            this.label1A.Text = "A:";
            // 
            // textBox1A
            // 
            this.textBox1A.Location = new System.Drawing.Point(56, 45);
            this.textBox1A.Name = "textBox1A";
            this.textBox1A.Size = new System.Drawing.Size(100, 20);
            this.textBox1A.TabIndex = 2;
            this.textBox1A.Text = "15";
            this.textBox1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1B
            // 
            this.label1B.AutoSize = true;
            this.label1B.Location = new System.Drawing.Point(17, 82);
            this.label1B.Name = "label1B";
            this.label1B.Size = new System.Drawing.Size(17, 13);
            this.label1B.TabIndex = 3;
            this.label1B.Text = "B:";
            // 
            // textBox1B
            // 
            this.textBox1B.Location = new System.Drawing.Point(56, 77);
            this.textBox1B.Name = "textBox1B";
            this.textBox1B.Size = new System.Drawing.Size(100, 20);
            this.textBox1B.TabIndex = 4;
            this.textBox1B.Text = "1.5";
            this.textBox1B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1Process
            // 
            this.button1Process.Location = new System.Drawing.Point(81, 157);
            this.button1Process.Name = "button1Process";
            this.button1Process.Size = new System.Drawing.Size(75, 23);
            this.button1Process.TabIndex = 5;
            this.button1Process.Text = "Calculate";
            this.button1Process.UseVisualStyleBackColor = true;
            this.button1Process.Click += new System.EventHandler(this.button1Process_Click);
            // 
            // label1History
            // 
            this.label1History.AutoSize = true;
            this.label1History.Location = new System.Drawing.Point(236, 48);
            this.label1History.Name = "label1History";
            this.label1History.Size = new System.Drawing.Size(81, 13);
            this.label1History.TabIndex = 6;
            this.label1History.Text = "History count: 0";
            // 
            // comboBox1History
            // 
            this.comboBox1History.FormattingEnabled = true;
            this.comboBox1History.Location = new System.Drawing.Point(239, 77);
            this.comboBox1History.Name = "comboBox1History";
            this.comboBox1History.Size = new System.Drawing.Size(121, 21);
            this.comboBox1History.TabIndex = 7;
            // 
            // button1History
            // 
            this.button1History.Location = new System.Drawing.Point(285, 116);
            this.button1History.Name = "button1History";
            this.button1History.Size = new System.Drawing.Size(75, 23);
            this.button1History.TabIndex = 8;
            this.button1History.Text = "Get history";
            this.button1History.UseVisualStyleBackColor = true;
            this.button1History.Click += new System.EventHandler(this.button1History_Click);
            // 
            // textBox1Result
            // 
            this.textBox1Result.Location = new System.Drawing.Point(56, 118);
            this.textBox1Result.Name = "textBox1Result";
            this.textBox1Result.ReadOnly = true;
            this.textBox1Result.Size = new System.Drawing.Size(100, 20);
            this.textBox1Result.TabIndex = 9;
            this.textBox1Result.TabStop = false;
            this.textBox1Result.Text = "...";
            this.textBox1Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1Result
            // 
            this.label1Result.AutoSize = true;
            this.label1Result.Location = new System.Drawing.Point(9, 121);
            this.label1Result.Name = "label1Result";
            this.label1Result.Size = new System.Drawing.Size(40, 13);
            this.label1Result.TabIndex = 10;
            this.label1Result.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 247);
            this.Controls.Add(this.label1Result);
            this.Controls.Add(this.textBox1Result);
            this.Controls.Add(this.button1History);
            this.Controls.Add(this.comboBox1History);
            this.Controls.Add(this.label1History);
            this.Controls.Add(this.button1Process);
            this.Controls.Add(this.textBox1B);
            this.Controls.Add(this.label1B);
            this.Controls.Add(this.textBox1A);
            this.Controls.Add(this.label1A);
            this.Controls.Add(this.label1Lab31);
            this.MinimumSize = new System.Drawing.Size(441, 286);
            this.Name = "Form1";
            this.Text = "Lab-3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Lab31;
        private System.Windows.Forms.Label label1A;
        private System.Windows.Forms.TextBox textBox1A;
        private System.Windows.Forms.Label label1B;
        private System.Windows.Forms.TextBox textBox1B;
        private System.Windows.Forms.Button button1Process;
        private System.Windows.Forms.Label label1History;
        private System.Windows.Forms.ComboBox comboBox1History;
        private System.Windows.Forms.Button button1History;
        private System.Windows.Forms.TextBox textBox1Result;
        private System.Windows.Forms.Label label1Result;
    }
}

