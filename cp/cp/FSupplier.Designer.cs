namespace cp
{
    partial class FSupplier
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
            this.labelSupplierID = new System.Windows.Forms.Label();
            this.textBoxSupplierID = new System.Windows.Forms.TextBox();
            this.labelSName = new System.Windows.Forms.Label();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.labelSAddress = new System.Windows.Forms.Label();
            this.textBoxSAddess = new System.Windows.Forms.TextBox();
            this.labelSPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxSPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelSContact = new System.Windows.Forms.Label();
            this.textBoxSContact = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSupplierID
            // 
            this.labelSupplierID.AutoSize = true;
            this.labelSupplierID.Location = new System.Drawing.Point(25, 35);
            this.labelSupplierID.Name = "labelSupplierID";
            this.labelSupplierID.Size = new System.Drawing.Size(88, 13);
            this.labelSupplierID.TabIndex = 0;
            this.labelSupplierID.Text = "ID Поставщика:";
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Location = new System.Drawing.Point(164, 28);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.ReadOnly = true;
            this.textBoxSupplierID.Size = new System.Drawing.Size(298, 20);
            this.textBoxSupplierID.TabIndex = 1;
            this.textBoxSupplierID.TabStop = false;
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(25, 70);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(68, 13);
            this.labelSName.TabIndex = 2;
            this.labelSName.Text = "Поставщик:";
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(164, 63);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(298, 20);
            this.textBoxSName.TabIndex = 1;
            // 
            // labelSAddress
            // 
            this.labelSAddress.AutoSize = true;
            this.labelSAddress.Location = new System.Drawing.Point(25, 105);
            this.labelSAddress.Name = "labelSAddress";
            this.labelSAddress.Size = new System.Drawing.Size(41, 13);
            this.labelSAddress.TabIndex = 4;
            this.labelSAddress.Text = "Адрес:";
            // 
            // textBoxSAddess
            // 
            this.textBoxSAddess.Location = new System.Drawing.Point(164, 98);
            this.textBoxSAddess.Name = "textBoxSAddess";
            this.textBoxSAddess.Size = new System.Drawing.Size(298, 20);
            this.textBoxSAddess.TabIndex = 2;
            // 
            // labelSPhoneNumber
            // 
            this.labelSPhoneNumber.AutoSize = true;
            this.labelSPhoneNumber.Location = new System.Drawing.Point(25, 140);
            this.labelSPhoneNumber.Name = "labelSPhoneNumber";
            this.labelSPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.labelSPhoneNumber.TabIndex = 6;
            this.labelSPhoneNumber.Text = "Телефон:";
            // 
            // textBoxSPhoneNumber
            // 
            this.textBoxSPhoneNumber.Location = new System.Drawing.Point(164, 133);
            this.textBoxSPhoneNumber.Name = "textBoxSPhoneNumber";
            this.textBoxSPhoneNumber.Size = new System.Drawing.Size(298, 20);
            this.textBoxSPhoneNumber.TabIndex = 3;
            // 
            // labelSContact
            // 
            this.labelSContact.AutoSize = true;
            this.labelSContact.Location = new System.Drawing.Point(25, 175);
            this.labelSContact.Name = "labelSContact";
            this.labelSContact.Size = new System.Drawing.Size(51, 13);
            this.labelSContact.TabIndex = 8;
            this.labelSContact.Text = "Контакт:";
            // 
            // textBoxSContact
            // 
            this.textBoxSContact.Location = new System.Drawing.Point(164, 168);
            this.textBoxSContact.Name = "textBoxSContact";
            this.textBoxSContact.Size = new System.Drawing.Size(298, 20);
            this.textBoxSContact.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(302, 210);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(387, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FSupplier
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(489, 251);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSContact);
            this.Controls.Add(this.labelSContact);
            this.Controls.Add(this.textBoxSPhoneNumber);
            this.Controls.Add(this.labelSPhoneNumber);
            this.Controls.Add(this.textBoxSAddess);
            this.Controls.Add(this.labelSAddress);
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.textBoxSupplierID);
            this.Controls.Add(this.labelSupplierID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FSupplier";
            this.Text = "FSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierID;
        private System.Windows.Forms.TextBox textBoxSupplierID;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label labelSAddress;
        private System.Windows.Forms.TextBox textBoxSAddess;
        private System.Windows.Forms.Label labelSPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSPhoneNumber;
        private System.Windows.Forms.Label labelSContact;
        private System.Windows.Forms.TextBox textBoxSContact;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}