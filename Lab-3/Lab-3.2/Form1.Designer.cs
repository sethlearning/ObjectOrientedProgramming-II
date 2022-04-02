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
            this.textBox1Result = new System.Windows.Forms.TextBox();
            this.label1C2 = new System.Windows.Forms.Label();
            this.label1D = new System.Windows.Forms.Label();
            this.textBox1D = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1Lab31
            // 
            this.label1Lab31.AutoSize = true;
            this.label1Lab31.Location = new System.Drawing.Point(13, 13);
            this.label1Lab31.Name = "label1Lab31";
            this.label1Lab31.Size = new System.Drawing.Size(253, 13);
            this.label1Lab31.TabIndex = 0;
            this.label1Lab31.Text = "Вычисление функции: if d<a then a+b+d else a-b-d";
            // 
            // label1A
            // 
            this.label1A.AutoSize = true;
            this.label1A.Location = new System.Drawing.Point(17, 48);
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
            this.button1Process.Location = new System.Drawing.Point(81, 189);
            this.button1Process.Name = "button1Process";
            this.button1Process.Size = new System.Drawing.Size(75, 23);
            this.button1Process.TabIndex = 6;
            this.button1Process.Text = "Update";
            this.button1Process.UseVisualStyleBackColor = true;
            this.button1Process.Click += new System.EventHandler(this.button1Process_Click);
            // 
            // textBox1Result
            // 
            this.textBox1Result.Location = new System.Drawing.Point(56, 150);
            this.textBox1Result.Name = "textBox1Result";
            this.textBox1Result.ReadOnly = true;
            this.textBox1Result.Size = new System.Drawing.Size(100, 20);
            this.textBox1Result.TabIndex = 9;
            this.textBox1Result.TabStop = false;
            this.textBox1Result.Text = "...";
            this.textBox1Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1C2
            // 
            this.label1C2.AutoSize = true;
            this.label1C2.Location = new System.Drawing.Point(9, 153);
            this.label1C2.Name = "label1C2";
            this.label1C2.Size = new System.Drawing.Size(23, 13);
            this.label1C2.TabIndex = 10;
            this.label1C2.Text = "C2:";
            // 
            // label1D
            // 
            this.label1D.AutoSize = true;
            this.label1D.Location = new System.Drawing.Point(17, 115);
            this.label1D.Name = "label1D";
            this.label1D.Size = new System.Drawing.Size(18, 13);
            this.label1D.TabIndex = 11;
            this.label1D.Text = "D:";
            // 
            // textBox1D
            // 
            this.textBox1D.Location = new System.Drawing.Point(56, 111);
            this.textBox1D.Name = "textBox1D";
            this.textBox1D.Size = new System.Drawing.Size(100, 20);
            this.textBox1D.TabIndex = 5;
            this.textBox1D.Text = "2.7";
            this.textBox1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1D.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 247);
            this.Controls.Add(this.textBox1D);
            this.Controls.Add(this.label1D);
            this.Controls.Add(this.label1C2);
            this.Controls.Add(this.textBox1Result);
            this.Controls.Add(this.button1Process);
            this.Controls.Add(this.textBox1B);
            this.Controls.Add(this.label1B);
            this.Controls.Add(this.textBox1A);
            this.Controls.Add(this.label1A);
            this.Controls.Add(this.label1Lab31);
            this.Name = "Form1";
            this.Text = "Lab-3.2";
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
        private System.Windows.Forms.TextBox textBox1Result;
        private System.Windows.Forms.Label label1C2;
        private System.Windows.Forms.Label label1D;
        private System.Windows.Forms.TextBox textBox1D;
    }
}

