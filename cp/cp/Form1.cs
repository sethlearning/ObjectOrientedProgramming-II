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
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private DataTable dtSells = new DataTable();
        private DataRow dr;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void FillDataSells()
        {
            this.sellsTableAdapter.FillBy(this.cpDataSet.Sells);
            dt = this.sellsTableAdapter.GetDataBy();
            dt.Columns[0].ColumnName = "ID Продажи";
            dt.Columns[1].ColumnName = "ID Товара";
            dt.Columns[2].ColumnName = "Дата продажи";
            dt.Columns[3].ColumnName = "Количество";
            dt.Columns[4].ColumnName = "Цена";
            dt.Columns[5].ColumnName = "Наименование товара";
        }
        private void FormatDataSells(DataGridView d)
        {
            d.Columns[5].DisplayIndex = 2;
            d.Columns[0].Resizable = DataGridViewTriState.True;
            d.Columns[1].Resizable = DataGridViewTriState.True;
            d.Columns[2].Resizable = DataGridViewTriState.True;
            d.Columns[3].Resizable = DataGridViewTriState.True;
            d.Columns[4].Resizable = DataGridViewTriState.True;
            d.Columns[5].Resizable = DataGridViewTriState.True;
            d.Columns[0].MinimumWidth = 95;
            d.Columns[1].MinimumWidth = 95;
            d.Columns[2].MinimumWidth = 105;
            d.Columns[3].MinimumWidth = 80;
            d.Columns[4].MinimumWidth = 80;
            d.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            d.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            // TODO: This line of code loads data into the 'cpDataSet.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.cpDataSet.Goods);
            // TODO: This line of code loads data into the 'cpDataSet.Sells' table. You can move, or remove it, as needed.
            // DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn("SellID"));



            FillDataSells();
            //bs.DataSource = this.sellsTableAdapter;
            //bs.DataMember = "Sells";
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            FormatDataSells(dataGridView1);

            this.sellsTableAdapter.Fill(this.cpDataSet.Sells);
            dtSells = this.sellsTableAdapter.GetData();

            //          dataGridView1.Columns.Add("A1", "A2");
            //            dataGridView1.Columns[0].
            /*
                        this.sellsTableAdapter.Fill(this.cpDataSet.Sells);
                        dt = this.sellsTableAdapter.GetData();
                        dt.Columns[0].ColumnName = "ID Продажи";
                        dt.Columns[1].ColumnName = "ID Товара";
                        dt.Columns[2].ColumnName = "Дата продажи";
                        dt.Columns[3].ColumnName = "Количество";
                        dt.Columns[4].ColumnName = "Цена";

                        bs.DataSource = dt;
                        dataGridView1.DataSource = bs;
            */
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show($"Column: {e.ColumnIndex} Row: {e.RowIndex} String: {e.ToString()}");


            /*String s;
            int i;
            DataTable dt = new DataTable();
            i = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            sellsTableAdapter.FillBy2(this.cpDataSet.Sells, i);
            dt = sellsTableAdapter.GetDataBy2(i);
            */
            //MessageBox.Show((dt.Rows[0])[dt.Columns[2]].ToString());

            // DataRow dr;

            //this.sellsTableAdapter.FillBy2(this.cpDataSet.Sells);

            //this.Enabled = false;
            //f2.Show();
            //f2.Activate();
            // this.Enabled = true;

            dr = dt.Rows[e.RowIndex];
            DataTable dtg = new DataTable();
            goodsTableAdapter.Fill(this.cpDataSet.Goods);
            dtg = goodsTableAdapter.GetData();


            FSell f2 = new FSell(dr, dtg);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && f2.dataChanged)
            {
                //dt = f2.dts;
                //MessageBox.Show(dr[5].ToString());
                //sellsTableAdapter.Update()
                //tableAdapterManager.UpdateAll(cpDataSet);
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.FindBySellID((int)dr[0]);
                //sellsRow = (cpDataSet.SellsRow)dr;
                sellsRow.SGID = (int)dr[1];
                sellsRow.SDate = (DateTime)dr[2];
                sellsRow.SQuantity = (int)dr[3];
                sellsRow.SSellingPrice = (decimal)dr[4];

                /*
                MessageBox.Show(sellsRow.SSellingPrice.ToString());
                MessageBox.Show(sellsRow[4].ToString());
                MessageBox.Show(cpDataSet.HasChanges().ToString());
                */
                tableAdapterManager.UpdateAll(cpDataSet);

                if (f2.gNameChanged)
                {
                    FillDataSells();
                    bs.DataSource = dt;
                }
            }

//            sellsTableAdapter.Update()

            //bs.DataSource = dt;
            //dataGridView1.Update();
            //MessageBox.Show(res.ToString());

        }
    }
}
