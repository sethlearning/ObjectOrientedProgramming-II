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
    public partial class FGood : Form
    {
        public DataRow dr;
        public bool sNameChanged = false;
        public bool dataChanged = false;
        private bool isNewGood;

        public FGood(DataRow idr, DataTable dts, Boolean isNewGood)
        {
            InitializeComponent();

            this.isNewGood = isNewGood;
            dr = idr;

            if (isNewGood)
            {
                this.Text = $"Новый товар";

                textBoxGID.Text = "New";
                comboBoxSName.DataSource = dts;
                comboBoxSName.DisplayMember = "SName";
                comboBoxSName.ValueMember = "SupplierID";
                textBoxGSupplierID.Text = comboBoxSName.SelectedValue.ToString();
            }

            else
            {
                this.Text = $"Товар №{dr[0]}";
                int id = (int)dr[2];

                textBoxGID.Text = dr[0].ToString();
                textBoxGName.Text = dr[1].ToString();

                numericUpDownGQuantity.Value = Convert.ToDecimal(dr[4]);
                numericUpDownGBuyingPrice.Value = Convert.ToDecimal(dr[5]);
                dateTimePickerGSupplyDate.Value = (DateTime)dr[3];

                comboBoxSName.DataSource = dts;
                comboBoxSName.DisplayMember = "SName";
                comboBoxSName.ValueMember = "SupplierID";
                comboBoxSName.SelectedValue = id;
                textBoxGSupplierID.Text = comboBoxSName.SelectedValue.ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            // GName
            if ((string)dr[1] != textBoxGName.Text)
            {
                dr[1] = textBoxGName.Text;
                dataChanged = true;
            }

            // GSupplierID
            if (dr[2].ToString() != textBoxGSupplierID.Text)
            {
                dr[2] = Convert.ToInt32(textBoxGSupplierID.Text);
                dataChanged = true;
                sNameChanged = true;
            }

            // GSupplyDate
            if ((DateTime)dr[3] != dateTimePickerGSupplyDate.Value)
            {
                dr[3] = dateTimePickerGSupplyDate.Value.Date;
                dataChanged = true;
            }

            // GQuantity
            if ((int)dr[4] != (int)numericUpDownGQuantity.Value)
            {
                dr[4] = Convert.ToInt32(numericUpDownGQuantity.Value);
                dataChanged = true;
            }

            // GBuyingPrice
            if ((decimal)dr[5] != numericUpDownGBuyingPrice.Value)
            {
                dr[5] = numericUpDownGBuyingPrice.Value;
                dataChanged = true;
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxSName_SelectedIndexChanged(object sender, EventArgs e) =>
            textBoxGSupplierID.Text = comboBoxSName.SelectedValue.ToString();
    }
}
