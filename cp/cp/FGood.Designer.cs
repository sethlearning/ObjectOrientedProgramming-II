namespace cp
{
    partial class FGood
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
            this.labelGID = new System.Windows.Forms.Label();
            this.textBoxGID = new System.Windows.Forms.TextBox();
            this.labelGName = new System.Windows.Forms.Label();
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.labelGSupplierID = new System.Windows.Forms.Label();
            this.textBoxGSupplierID = new System.Windows.Forms.TextBox();
            this.labelSName = new System.Windows.Forms.Label();
            this.comboBoxSName = new System.Windows.Forms.ComboBox();
            this.labelGSupplyDate = new System.Windows.Forms.Label();
            this.dateTimePickerGSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.labelGQuantity = new System.Windows.Forms.Label();
            this.numericUpDownGQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.labelGBuyingPrice = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGBuyingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGID
            // 
            this.labelGID.AutoSize = true;
            this.labelGID.Location = new System.Drawing.Point(25, 35);
            this.labelGID.Name = "labelGID";
            this.labelGID.Size = new System.Drawing.Size(61, 13);
            this.labelGID.TabIndex = 0;
            this.labelGID.Text = "ID Товара:";
            // 
            // textBoxGID
            // 
            this.textBoxGID.Location = new System.Drawing.Point(164, 28);
            this.textBoxGID.Name = "textBoxGID";
            this.textBoxGID.ReadOnly = true;
            this.textBoxGID.Size = new System.Drawing.Size(298, 20);
            this.textBoxGID.TabIndex = 1;
            // 
            // labelGName
            // 
            this.labelGName.AutoSize = true;
            this.labelGName.Location = new System.Drawing.Point(25, 70);
            this.labelGName.Name = "labelGName";
            this.labelGName.Size = new System.Drawing.Size(124, 13);
            this.labelGName.TabIndex = 2;
            this.labelGName.Text = "Наименование товара:";
            // 
            // textBoxGName
            // 
            this.textBoxGName.Location = new System.Drawing.Point(164, 63);
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(298, 20);
            this.textBoxGName.TabIndex = 3;
            // 
            // labelGSupplierID
            // 
            this.labelGSupplierID.AutoSize = true;
            this.labelGSupplierID.Location = new System.Drawing.Point(25, 105);
            this.labelGSupplierID.Name = "labelGSupplierID";
            this.labelGSupplierID.Size = new System.Drawing.Size(88, 13);
            this.labelGSupplierID.TabIndex = 4;
            this.labelGSupplierID.Text = "ID Поставщика:";
            // 
            // textBoxGSupplierID
            // 
            this.textBoxGSupplierID.Location = new System.Drawing.Point(164, 98);
            this.textBoxGSupplierID.Name = "textBoxGSupplierID";
            this.textBoxGSupplierID.ReadOnly = true;
            this.textBoxGSupplierID.Size = new System.Drawing.Size(298, 20);
            this.textBoxGSupplierID.TabIndex = 5;
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(25, 140);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(68, 13);
            this.labelSName.TabIndex = 6;
            this.labelSName.Text = "Поставщик:";
            // 
            // comboBoxSName
            // 
            this.comboBoxSName.FormattingEnabled = true;
            this.comboBoxSName.Location = new System.Drawing.Point(164, 133);
            this.comboBoxSName.Name = "comboBoxSName";
            this.comboBoxSName.Size = new System.Drawing.Size(298, 21);
            this.comboBoxSName.TabIndex = 7;
            this.comboBoxSName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSName_SelectedIndexChanged);
            // 
            // labelGSupplyDate
            // 
            this.labelGSupplyDate.AutoSize = true;
            this.labelGSupplyDate.Location = new System.Drawing.Point(25, 175);
            this.labelGSupplyDate.Name = "labelGSupplyDate";
            this.labelGSupplyDate.Size = new System.Drawing.Size(86, 13);
            this.labelGSupplyDate.TabIndex = 8;
            this.labelGSupplyDate.Text = "Дата поставки:";
            // 
            // dateTimePickerGSupplyDate
            // 
            this.dateTimePickerGSupplyDate.Location = new System.Drawing.Point(164, 168);
            this.dateTimePickerGSupplyDate.Name = "dateTimePickerGSupplyDate";
            this.dateTimePickerGSupplyDate.Size = new System.Drawing.Size(298, 20);
            this.dateTimePickerGSupplyDate.TabIndex = 9;
            // 
            // labelGQuantity
            // 
            this.labelGQuantity.AutoSize = true;
            this.labelGQuantity.Location = new System.Drawing.Point(25, 210);
            this.labelGQuantity.Name = "labelGQuantity";
            this.labelGQuantity.Size = new System.Drawing.Size(69, 13);
            this.labelGQuantity.TabIndex = 10;
            this.labelGQuantity.Text = "Количество:";
            // 
            // numericUpDownGQuantity
            // 
            this.numericUpDownGQuantity.Location = new System.Drawing.Point(164, 203);
            this.numericUpDownGQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGQuantity.Name = "numericUpDownGQuantity";
            this.numericUpDownGQuantity.Size = new System.Drawing.Size(298, 20);
            this.numericUpDownGQuantity.TabIndex = 11;
            this.numericUpDownGQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownGBuyingPrice
            // 
            this.numericUpDownGBuyingPrice.DecimalPlaces = 2;
            this.numericUpDownGBuyingPrice.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownGBuyingPrice.Location = new System.Drawing.Point(164, 238);
            this.numericUpDownGBuyingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGBuyingPrice.Name = "numericUpDownGBuyingPrice";
            this.numericUpDownGBuyingPrice.Size = new System.Drawing.Size(298, 20);
            this.numericUpDownGBuyingPrice.TabIndex = 12;
            // 
            // labelGBuyingPrice
            // 
            this.labelGBuyingPrice.AutoSize = true;
            this.labelGBuyingPrice.Location = new System.Drawing.Point(25, 245);
            this.labelGBuyingPrice.Name = "labelGBuyingPrice";
            this.labelGBuyingPrice.Size = new System.Drawing.Size(80, 13);
            this.labelGBuyingPrice.TabIndex = 13;
            this.labelGBuyingPrice.Text = "Оптовая цена:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(302, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(387, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FGood
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(489, 321);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGBuyingPrice);
            this.Controls.Add(this.numericUpDownGBuyingPrice);
            this.Controls.Add(this.numericUpDownGQuantity);
            this.Controls.Add(this.labelGQuantity);
            this.Controls.Add(this.dateTimePickerGSupplyDate);
            this.Controls.Add(this.labelGSupplyDate);
            this.Controls.Add(this.comboBoxSName);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.textBoxGSupplierID);
            this.Controls.Add(this.labelGSupplierID);
            this.Controls.Add(this.textBoxGName);
            this.Controls.Add(this.labelGName);
            this.Controls.Add(this.textBoxGID);
            this.Controls.Add(this.labelGID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FGood";
            this.Text = "FGood";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGBuyingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGID;
        private System.Windows.Forms.TextBox textBoxGID;
        private System.Windows.Forms.Label labelGName;
        private System.Windows.Forms.TextBox textBoxGName;
        private System.Windows.Forms.Label labelGSupplierID;
        private System.Windows.Forms.TextBox textBoxGSupplierID;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.ComboBox comboBoxSName;
        private System.Windows.Forms.Label labelGSupplyDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerGSupplyDate;
        private System.Windows.Forms.Label labelGQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownGQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownGBuyingPrice;
        private System.Windows.Forms.Label labelGBuyingPrice;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}