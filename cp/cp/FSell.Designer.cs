namespace cp
{
    partial class FSell
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
            this.labelSellID = new System.Windows.Forms.Label();
            this.textBoxSellID = new System.Windows.Forms.TextBox();
            this.labelSGID = new System.Windows.Forms.Label();
            this.textBoxSGID = new System.Windows.Forms.TextBox();
            this.comboBoxSGID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGName = new System.Windows.Forms.Label();
            this.labelSDate = new System.Windows.Forms.Label();
            this.labelSQuantity = new System.Windows.Forms.Label();
            this.textBoxSQuantity = new System.Windows.Forms.TextBox();
            this.labelSSellingPrice = new System.Windows.Forms.Label();
            this.textBoxSSellingPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSellID
            // 
            this.labelSellID.AutoSize = true;
            this.labelSellID.Location = new System.Drawing.Point(31, 47);
            this.labelSellID.Name = "labelSellID";
            this.labelSellID.Size = new System.Drawing.Size(76, 13);
            this.labelSellID.TabIndex = 0;
            this.labelSellID.Text = "ИД Продажи:";
            // 
            // textBoxSellID
            // 
            this.textBoxSellID.Location = new System.Drawing.Point(164, 44);
            this.textBoxSellID.Name = "textBoxSellID";
            this.textBoxSellID.Size = new System.Drawing.Size(149, 20);
            this.textBoxSellID.TabIndex = 1;
            // 
            // labelSGID
            // 
            this.labelSGID.AutoSize = true;
            this.labelSGID.Location = new System.Drawing.Point(34, 87);
            this.labelSGID.Name = "labelSGID";
            this.labelSGID.Size = new System.Drawing.Size(67, 13);
            this.labelSGID.TabIndex = 2;
            this.labelSGID.Text = "ИД Товара:";
            // 
            // textBoxSGID
            // 
            this.textBoxSGID.Location = new System.Drawing.Point(164, 87);
            this.textBoxSGID.Name = "textBoxSGID";
            this.textBoxSGID.Size = new System.Drawing.Size(149, 20);
            this.textBoxSGID.TabIndex = 3;
            // 
            // comboBoxSGID
            // 
            this.comboBoxSGID.FormattingEnabled = true;
            this.comboBoxSGID.Location = new System.Drawing.Point(164, 121);
            this.comboBoxSGID.Name = "comboBoxSGID";
            this.comboBoxSGID.Size = new System.Drawing.Size(423, 21);
            this.comboBoxSGID.TabIndex = 4;
            this.comboBoxSGID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelGName
            // 
            this.labelGName.AutoSize = true;
            this.labelGName.Location = new System.Drawing.Point(34, 129);
            this.labelGName.Name = "labelGName";
            this.labelGName.Size = new System.Drawing.Size(124, 13);
            this.labelGName.TabIndex = 6;
            this.labelGName.Text = "Наименование товара:";
            // 
            // labelSDate
            // 
            this.labelSDate.AutoSize = true;
            this.labelSDate.Location = new System.Drawing.Point(34, 177);
            this.labelSDate.Name = "labelSDate";
            this.labelSDate.Size = new System.Drawing.Size(83, 13);
            this.labelSDate.TabIndex = 7;
            this.labelSDate.Text = "Дата продажи:";
            // 
            // labelSQuantity
            // 
            this.labelSQuantity.AutoSize = true;
            this.labelSQuantity.Location = new System.Drawing.Point(37, 214);
            this.labelSQuantity.Name = "labelSQuantity";
            this.labelSQuantity.Size = new System.Drawing.Size(69, 13);
            this.labelSQuantity.TabIndex = 8;
            this.labelSQuantity.Text = "Количество:";
            // 
            // textBoxSQuantity
            // 
            this.textBoxSQuantity.Location = new System.Drawing.Point(123, 214);
            this.textBoxSQuantity.Name = "textBoxSQuantity";
            this.textBoxSQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxSQuantity.TabIndex = 10;
            // 
            // labelSSellingPrice
            // 
            this.labelSSellingPrice.AutoSize = true;
            this.labelSSellingPrice.Location = new System.Drawing.Point(37, 265);
            this.labelSSellingPrice.Name = "labelSSellingPrice";
            this.labelSSellingPrice.Size = new System.Drawing.Size(36, 13);
            this.labelSSellingPrice.TabIndex = 11;
            this.labelSSellingPrice.Text = "Цена:";
            // 
            // textBoxSSellingPrice
            // 
            this.textBoxSSellingPrice.Location = new System.Drawing.Point(96, 257);
            this.textBoxSSellingPrice.Name = "textBoxSSellingPrice";
            this.textBoxSSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSellingPrice.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // FSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSSellingPrice);
            this.Controls.Add(this.labelSSellingPrice);
            this.Controls.Add(this.textBoxSQuantity);
            this.Controls.Add(this.labelSQuantity);
            this.Controls.Add(this.labelSDate);
            this.Controls.Add(this.labelGName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSGID);
            this.Controls.Add(this.textBoxSGID);
            this.Controls.Add(this.labelSGID);
            this.Controls.Add(this.textBoxSellID);
            this.Controls.Add(this.labelSellID);
            this.Name = "FSell";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSellID;
        private System.Windows.Forms.TextBox textBoxSellID;
        private System.Windows.Forms.Label labelSGID;
        private System.Windows.Forms.TextBox textBoxSGID;
        private System.Windows.Forms.ComboBox comboBoxSGID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelGName;
        private System.Windows.Forms.Label labelSDate;
        private System.Windows.Forms.Label labelSQuantity;
        private System.Windows.Forms.TextBox textBoxSQuantity;
        private System.Windows.Forms.Label labelSSellingPrice;
        private System.Windows.Forms.TextBox textBoxSSellingPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}