﻿namespace cp
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
            this.labelGName = new System.Windows.Forms.Label();
            this.labelSDate = new System.Windows.Forms.Label();
            this.labelSQuantity = new System.Windows.Forms.Label();
            this.labelSSellingPrice = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSSellingPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSellID
            // 
            this.labelSellID.AutoSize = true;
            this.labelSellID.Location = new System.Drawing.Point(25, 35);
            this.labelSellID.Name = "labelSellID";
            this.labelSellID.Size = new System.Drawing.Size(76, 13);
            this.labelSellID.TabIndex = 0;
            this.labelSellID.Text = "ИД Продажи:";
            // 
            // textBoxSellID
            // 
            this.textBoxSellID.Location = new System.Drawing.Point(164, 28);
            this.textBoxSellID.Name = "textBoxSellID";
            this.textBoxSellID.ReadOnly = true;
            this.textBoxSellID.Size = new System.Drawing.Size(298, 20);
            this.textBoxSellID.TabIndex = 1;
            // 
            // labelSGID
            // 
            this.labelSGID.AutoSize = true;
            this.labelSGID.Location = new System.Drawing.Point(25, 65);
            this.labelSGID.Name = "labelSGID";
            this.labelSGID.Size = new System.Drawing.Size(67, 13);
            this.labelSGID.TabIndex = 2;
            this.labelSGID.Text = "ИД Товара:";
            // 
            // textBoxSGID
            // 
            this.textBoxSGID.Location = new System.Drawing.Point(164, 58);
            this.textBoxSGID.Name = "textBoxSGID";
            this.textBoxSGID.Size = new System.Drawing.Size(298, 20);
            this.textBoxSGID.TabIndex = 3;
            // 
            // comboBoxSGID
            // 
            this.comboBoxSGID.FormattingEnabled = true;
            this.comboBoxSGID.Location = new System.Drawing.Point(164, 88);
            this.comboBoxSGID.Name = "comboBoxSGID";
            this.comboBoxSGID.Size = new System.Drawing.Size(298, 21);
            this.comboBoxSGID.TabIndex = 4;
            this.comboBoxSGID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSGID_SelectedIndexChanged);
            // 
            // labelGName
            // 
            this.labelGName.AutoSize = true;
            this.labelGName.Location = new System.Drawing.Point(25, 96);
            this.labelGName.Name = "labelGName";
            this.labelGName.Size = new System.Drawing.Size(124, 13);
            this.labelGName.TabIndex = 6;
            this.labelGName.Text = "Наименование товара:";
            // 
            // labelSDate
            // 
            this.labelSDate.AutoSize = true;
            this.labelSDate.Location = new System.Drawing.Point(25, 127);
            this.labelSDate.Name = "labelSDate";
            this.labelSDate.Size = new System.Drawing.Size(83, 13);
            this.labelSDate.TabIndex = 7;
            this.labelSDate.Text = "Дата продажи:";
            // 
            // labelSQuantity
            // 
            this.labelSQuantity.AutoSize = true;
            this.labelSQuantity.Location = new System.Drawing.Point(25, 160);
            this.labelSQuantity.Name = "labelSQuantity";
            this.labelSQuantity.Size = new System.Drawing.Size(69, 13);
            this.labelSQuantity.TabIndex = 8;
            this.labelSQuantity.Text = "Количество:";
            // 
            // labelSSellingPrice
            // 
            this.labelSSellingPrice.AutoSize = true;
            this.labelSSellingPrice.Location = new System.Drawing.Point(25, 193);
            this.labelSSellingPrice.Name = "labelSSellingPrice";
            this.labelSSellingPrice.Size = new System.Drawing.Size(36, 13);
            this.labelSSellingPrice.TabIndex = 11;
            this.labelSSellingPrice.Text = "Цена:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(103, 243);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(294, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // numericUpDownSQuantity
            // 
            this.numericUpDownSQuantity.Location = new System.Drawing.Point(164, 153);
            this.numericUpDownSQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSQuantity.Name = "numericUpDownSQuantity";
            this.numericUpDownSQuantity.Size = new System.Drawing.Size(298, 20);
            this.numericUpDownSQuantity.TabIndex = 16;
            // 
            // numericUpDownSSellingPrice
            // 
            this.numericUpDownSSellingPrice.DecimalPlaces = 2;
            this.numericUpDownSSellingPrice.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownSSellingPrice.Location = new System.Drawing.Point(164, 186);
            this.numericUpDownSSellingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSSellingPrice.Name = "numericUpDownSSellingPrice";
            this.numericUpDownSSellingPrice.Size = new System.Drawing.Size(298, 20);
            this.numericUpDownSSellingPrice.TabIndex = 17;
            // 
            // FSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 296);
            this.Controls.Add(this.numericUpDownSSellingPrice);
            this.Controls.Add(this.numericUpDownSQuantity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSSellingPrice);
            this.Controls.Add(this.labelSQuantity);
            this.Controls.Add(this.labelSDate);
            this.Controls.Add(this.labelGName);
            this.Controls.Add(this.comboBoxSGID);
            this.Controls.Add(this.textBoxSGID);
            this.Controls.Add(this.labelSGID);
            this.Controls.Add(this.textBoxSellID);
            this.Controls.Add(this.labelSellID);
            this.Name = "FSell";
            this.Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSellingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSellID;
        private System.Windows.Forms.TextBox textBoxSellID;
        private System.Windows.Forms.Label labelSGID;
        private System.Windows.Forms.TextBox textBoxSGID;
        private System.Windows.Forms.ComboBox comboBoxSGID;
        private System.Windows.Forms.Label labelGName;
        private System.Windows.Forms.Label labelSDate;
        private System.Windows.Forms.Label labelSQuantity;
        private System.Windows.Forms.Label labelSSellingPrice;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDownSQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownSSellingPrice;
    }
}