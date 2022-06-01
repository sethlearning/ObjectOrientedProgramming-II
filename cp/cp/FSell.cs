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
    public partial class FSell : Form
    {
        public DataRow dr;
        public bool gNameChanged = false;
        public bool dataChanged = false;
        private bool isNewSell;

        public FSell(DataRow idr, DataTable dtg, Boolean isNewSell)
        {
            InitializeComponent();

            this.isNewSell = isNewSell;
            dr = idr;

            if (isNewSell)
            {
                this.Text = $"Новая продажа";

                textBoxSellID.Text = "New";
                comboBoxSGID.DataSource = dtg;
                comboBoxSGID.DisplayMember = "GName";
                comboBoxSGID.ValueMember = "GID";
                textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();
            }

            else
            {
                this.Text = $"Продажа №{dr[0]}";
                int id = (int)dr[1];
                        
                textBoxSellID.Text = dr[0].ToString();
                numericUpDownSQuantity.Value = Convert.ToDecimal(dr[3]);
                numericUpDownSSellingPrice.Value = Convert.ToDecimal(dr[4]);
                dateTimePickerSells.Value = (DateTime)dr[2];

                comboBoxSGID.DataSource = dtg;
                comboBoxSGID.DisplayMember = "GName";
                comboBoxSGID.ValueMember = "GID";
                comboBoxSGID.SelectedValue = id;
                textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();
            }
        }

        /*
        public FSell(DataTable dtg)
        {
            InitializeComponent();
            isNewSell = true;
            this.Text = $"Новая продажа";

            comboBoxSGID.DataSource = dtg;
            comboBoxSGID.DisplayMember = "GName";
            comboBoxSGID.ValueMember = "GID";
            //comboBoxSGID.SelectedValue = id;
            textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();
        }
        */

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if ((DateTime)dr[2] != dateTimePickerSells.Value)
            {
                dr[2] = dateTimePickerSells.Value.Date;
                dataChanged = true;
            }

            if ((int)dr[3] != (int)numericUpDownSQuantity.Value)
            {
                dr[3] = Convert.ToInt32(numericUpDownSQuantity.Value);
                dataChanged = true;
            }

            if ((decimal)dr[4] != numericUpDownSSellingPrice.Value)
            {
                dr[4] = numericUpDownSSellingPrice.Value;
                dataChanged = true;
            }

            if (dr[1].ToString() != textBoxSGID.Text)
            {
                dr[1] = Convert.ToInt32(textBoxSGID.Text);
                dataChanged = true;
                gNameChanged = true;
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxSGID_SelectedIndexChanged(object sender, EventArgs e) => 
            textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();
    }
}
