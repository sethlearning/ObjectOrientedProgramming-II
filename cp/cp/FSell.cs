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
        //public DataTable dts;
        public DataRow dr;
        public bool gNameChanged = false;
        public bool dataChanged = false;

        public FSell()
        {
            InitializeComponent();
        }

        public FSell(DataRow idr, DataTable dtg)
        {
            InitializeComponent();

            dr = idr;
            int id = (int)dr[1];
                        
            textBoxSellID.Text = dr[0].ToString();
            textBoxSQuantity.Text = dr[3].ToString();
            textBoxSSellingPrice.Text = dr[4].ToString();
            dateTimePicker1.Value = (DateTime)dr[2];

            comboBoxSGID.DataSource = dtg;
            comboBoxSGID.DisplayMember = "GName";
            comboBoxSGID.ValueMember = "GID";
            comboBoxSGID.SelectedValue = id;
            textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();

            dataGridView1.DataSource = dr;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //(dts.Rows[0])[dts.Columns[0]] = Convert.ToInt32(textBox1.Text);
            //(dts.Rows[0])[dts.Columns[1]] = Convert.ToInt32(textBox2.Text);
            //(dts.Rows[0])[dts.Columns[2]] = Convert.ToDateTime(textBox3.Text);
            //(dts.Rows[0])[dts.Columns[3]] = Convert.ToInt32(textBox4.Text);
            //(dts.Rows[0])[dts.Columns[4]] = Convert.ToInt32(textBox5.Text);

            if (dr[0].ToString() != textBoxSellID.Text)
            {
                dr[0] = Convert.ToInt32(textBoxSellID.Text);
                dataChanged = true;
            }

            //if (dr[2].ToString() != dateTimePicker1.Text)
            if (dr[2] != dateTimePicker1)
            {
                dr[2] = dateTimePicker1.Value;
                //dr[2] = Convert.ToDateTime(textBoxSDate.Text);
                dataChanged = true;
            }

            if (dr[3].ToString() != textBoxSQuantity.Text)
            {
                dr[3] = Convert.ToInt32(textBoxSQuantity.Text);
                dataChanged = true;
            }

            if (dr[4].ToString() != textBoxSSellingPrice.Text)
            {
                dr[4] = Convert.ToInt32(textBoxSSellingPrice.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dr[1] = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            textBoxSGID.Text = comboBoxSGID.SelectedValue.ToString();

        }

    }
}
