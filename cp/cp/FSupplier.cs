using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp
{
    public partial class FSupplier : Form
    {
        public FSupplier()
        {
            InitializeComponent();
        }

        public DataRow dr;
        public bool dataChanged = false;
        private bool isNewSupplier;

        public FSupplier(DataRow idr, Boolean isNewSupplier)
        {
            InitializeComponent();

            this.isNewSupplier = isNewSupplier;
            dr = idr;

            if (isNewSupplier)
            {
                this.Text = $"Новый поставщик";

                textBoxSupplierID.Text = "New";
            }

            else
            {
                this.Text = $"Поставщик №{dr[0]}";

                textBoxSupplierID.Text = dr[0].ToString();
                textBoxSName.Text = dr[1].ToString();
                textBoxSAddess.Text = dr[2].ToString();
                textBoxSPhoneNumber.Text = dr[3].ToString();
                textBoxSContact.Text = dr[4].ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            // SName
            if ((string)dr[1] != textBoxSName.Text)
            {
                dr[1] = textBoxSName.Text;
                dataChanged = true;
            }

            // SAddress
            if ((string)dr[2] != textBoxSAddess.Text)
            {
                dr[2] = textBoxSAddess.Text;
                dataChanged = true;
            }

            // SPhoneNumber
            if ((string)dr[3] != textBoxSPhoneNumber.Text)
            {
                dr[3] = textBoxSPhoneNumber.Text;
                dataChanged = true;
            }

            // SContact
            if ((string)dr[4] != textBoxSContact.Text)
            {
                dr[4] = textBoxSContact.Text;
                dataChanged = true;
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
