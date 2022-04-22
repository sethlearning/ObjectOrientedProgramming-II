namespace Lab_5_theory
{
    partial class frmMain
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
            this.btn1 = new System.Windows.Forms.Button();
            this.graphWind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(78, 252);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(120, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Нарисовать график";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // graphWind
            // 
            this.graphWind.BackColor = System.Drawing.Color.White;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(12, 12);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(255, 225);
            this.graphWind.TabIndex = 1;
            this.graphWind.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 290);
            this.Controls.Add(this.graphWind);
            this.Controls.Add(this.btn1);
            this.Name = "frmMain";
            this.Text = "График функции";
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox graphWind;
    }
}

