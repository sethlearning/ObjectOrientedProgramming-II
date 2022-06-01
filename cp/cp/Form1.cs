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
            this.sellsTableAdapter.FillExt(this.cpDataSet.Sells);
            dt = this.sellsTableAdapter.GetDataExt();
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
            this.suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            this.goodsTableAdapter.Fill(this.cpDataSet.Goods);

            FillDataSells();
            bs.DataSource = dt;
            //bs.DataMember = "Sells";
            dataGridViewSells.DataSource = bs;
            FormatDataSells(dataGridViewSells);

            this.sellsTableAdapter.Fill(this.cpDataSet.Sells);
            dtSells = this.sellsTableAdapter.GetData();
        }

        private void NewSells()
        {
            DataTable dtg = new DataTable();
            goodsTableAdapter.Fill(this.cpDataSet.Goods);
            dtg = goodsTableAdapter.GetData();

            FSell f2 = new FSell(dtg);
            DialogResult res = f2.ShowDialog();
        }

        private void EditSells(int i)
        {
            //dr = dt.Rows[e.RowIndex];
            //dr = dt.Rows[dataGridView1.SelectedCells[0].RowIndex];
            dr = dt.Rows[i];
            DataTable dtg = new DataTable();
            goodsTableAdapter.Fill(this.cpDataSet.Goods);
            dtg = goodsTableAdapter.GetData();

            FSell f2 = new FSell(dr, dtg);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && f2.dataChanged)
            {
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.FindBySellID((int)dr[0]);

                sellsRow.SGID = (int)dr[1];
                sellsRow.SDate = (DateTime)dr[2];
                sellsRow.SQuantity = (int)dr[3];
                sellsRow.SSellingPrice = (decimal)dr[4];

                tableAdapterManager.UpdateAll(cpDataSet);

                // MessageBox.Show(cpDataSet.HasChanges().ToString());

                if (f2.gNameChanged)
                    dt.Rows[i][5] = goodsTableAdapter.GetGNameByGID((int)dr[1]);
            }
            f2.Dispose();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewSells.Rows.Count - 1)  // EDIT
                EditSells(e.RowIndex);
            else if (e.RowIndex == dataGridViewSells.Rows.Count - 1)    // NEW
                NewSells();
                //MessageBox.Show("NEW");
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 0 && dataGridViewSells.SelectedCells.Count > 0)
            {
                if (dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1) // EDIT
                    EditSells(dataGridViewSells.SelectedCells[0].RowIndex);
                else if (dataGridViewSells.SelectedCells[0].RowIndex == dataGridViewSells.Rows.Count - 1)   // NEW
                    MessageBox.Show("NEW");
            }
        }
    }
}
