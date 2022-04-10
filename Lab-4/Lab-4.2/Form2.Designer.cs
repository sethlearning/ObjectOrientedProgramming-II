namespace Lab_4
{
    partial class Form2
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
            this.label1A = new System.Windows.Forms.Label();
            this.label1B = new System.Windows.Forms.Label();
            this.textBox1A = new System.Windows.Forms.TextBox();
            this.textBox1B = new System.Windows.Forms.TextBox();
            this.button2R = new System.Windows.Forms.Button();
            this.textBox1Result1 = new System.Windows.Forms.TextBox();
            this.label1D = new System.Windows.Forms.Label();
            this.textBox1D = new System.Windows.Forms.TextBox();
            this.button2C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1A
            // 
            this.label1A.AutoSize = true;
            this.label1A.Location = new System.Drawing.Point(13, 24);
            this.label1A.Name = "label1A";
            this.label1A.Size = new System.Drawing.Size(17, 13);
            this.label1A.TabIndex = 0;
            this.label1A.Text = "A:";
            // 
            // label1B
            // 
            this.label1B.AutoSize = true;
            this.label1B.Location = new System.Drawing.Point(13, 51);
            this.label1B.Name = "label1B";
            this.label1B.Size = new System.Drawing.Size(17, 13);
            this.label1B.TabIndex = 1;
            this.label1B.Text = "B:";
            // 
            // textBox1A
            // 
            this.textBox1A.Location = new System.Drawing.Point(53, 19);
            this.textBox1A.Name = "textBox1A";
            this.textBox1A.Size = new System.Drawing.Size(100, 20);
            this.textBox1A.TabIndex = 2;
            this.textBox1A.Text = "5";
            this.textBox1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1AB_KeyDown);
            // 
            // textBox1B
            // 
            this.textBox1B.Location = new System.Drawing.Point(53, 47);
            this.textBox1B.Name = "textBox1B";
            this.textBox1B.Size = new System.Drawing.Size(100, 20);
            this.textBox1B.TabIndex = 3;
            this.textBox1B.Text = "1.5";
            this.textBox1B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1AB_KeyDown);
            // 
            // button2R
            // 
            this.button2R.Location = new System.Drawing.Point(78, 121);
            this.button2R.Name = "button2R";
            this.button2R.Size = new System.Drawing.Size(75, 23);
            this.button2R.TabIndex = 5;
            this.button2R.Text = "Test L42R";
            this.button2R.UseVisualStyleBackColor = true;
            this.button2R.Click += new System.EventHandler(this.button2R_Click);
            // 
            // textBox1Result1
            // 
            this.textBox1Result1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1Result1.Location = new System.Drawing.Point(191, 19);
            this.textBox1Result1.Multiline = true;
            this.textBox1Result1.Name = "textBox1Result1";
            this.textBox1Result1.ReadOnly = true;
            this.textBox1Result1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Result1.Size = new System.Drawing.Size(284, 188);
            this.textBox1Result1.TabIndex = 5;
            this.textBox1Result1.TabStop = false;
            // 
            // label1D
            // 
            this.label1D.AutoSize = true;
            this.label1D.Location = new System.Drawing.Point(13, 79);
            this.label1D.Name = "label1D";
            this.label1D.Size = new System.Drawing.Size(18, 13);
            this.label1D.TabIndex = 6;
            this.label1D.Text = "D:";
            // 
            // textBox1D
            // 
            this.textBox1D.Location = new System.Drawing.Point(53, 79);
            this.textBox1D.Name = "textBox1D";
            this.textBox1D.Size = new System.Drawing.Size(100, 20);
            this.textBox1D.TabIndex = 4;
            this.textBox1D.Text = "3";
            this.textBox1D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1D.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1D_KeyDown);
            // 
            // button2C
            // 
            this.button2C.Location = new System.Drawing.Point(78, 161);
            this.button2C.Name = "button2C";
            this.button2C.Size = new System.Drawing.Size(75, 23);
            this.button2C.TabIndex = 6;
            this.button2C.Text = "Test L42C";
            this.button2C.UseVisualStyleBackColor = true;
            this.button2C.Click += new System.EventHandler(this.button2C_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 240);
            this.Controls.Add(this.button2C);
            this.Controls.Add(this.textBox1D);
            this.Controls.Add(this.label1D);
            this.Controls.Add(this.textBox1Result1);
            this.Controls.Add(this.button2R);
            this.Controls.Add(this.textBox1B);
            this.Controls.Add(this.textBox1A);
            this.Controls.Add(this.label1B);
            this.Controls.Add(this.label1A);
            this.MinimumSize = new System.Drawing.Size(522, 279);
            this.Name = "Form2";
            this.Text = "Lab-4.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1A;
        private System.Windows.Forms.Label label1B;
        private System.Windows.Forms.TextBox textBox1A;
        private System.Windows.Forms.TextBox textBox1B;
        private System.Windows.Forms.Button button2R;
        private System.Windows.Forms.TextBox textBox1Result1;
        private System.Windows.Forms.Label label1D;
        private System.Windows.Forms.TextBox textBox1D;
        private System.Windows.Forms.Button button2C;
    }
}

