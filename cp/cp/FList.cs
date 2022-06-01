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
    public partial class FList : Form
    {
        private BindingSource bsSells = new BindingSource();
        //private DataTable dt = new DataTable();
        private DataTable dtSells = new DataTable();
        //private DataRow dr;
        private DataRow drSells;

        public FList()
        {
            InitializeComponent();
        }
        
        private void FillDataGridViewSells()
        {
            this.sellsTableAdapter.FillExt(this.cpDataSet.Sells);
            dtSells = this.sellsTableAdapter.GetDataExt();
            dtSells.Columns[0].ColumnName = "ID Продажи";
            dtSells.Columns[1].ColumnName = "ID Товара";
            dtSells.Columns[2].ColumnName = "Дата продажи";
            dtSells.Columns[3].ColumnName = "Количество";
            dtSells.Columns[4].ColumnName = "Цена";
            dtSells.Columns[5].ColumnName = "Наименование товара";
            //bs.DataMember = "Sells";
            bsSells.DataSource = dtSells;
        }
        private void FormatDataGridViewSells(DataGridView d)
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

        private void FillDataGridViewGoods()
        {
            this.goodsTableAdapter.FillExt(this.cpDataSet.Goods);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            this.goodsTableAdapter.Fill(this.cpDataSet.Goods);
            this.sellsTableAdapter.Fill(this.cpDataSet.Sells);

            FillDataGridViewSells();
            dataGridViewSells.DataSource = bsSells;
            FormatDataGridViewSells(dataGridViewSells);
            // dtSells = this.sellsTableAdapter.GetData();
        }

        private void NewSells()
        {
            drSells = dtSells.Rows[0];
            DataTable dtg = new DataTable();
            goodsTableAdapter.Fill(this.cpDataSet.Goods);
            dtg = goodsTableAdapter.GetData();

            FSell f2 = new FSell(drSells, dtg, true);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.NewSellsRow();
                sellsRow.SGID = (int)drSells[1];
                sellsRow.SDate = (DateTime)drSells[2];

                sellsRow.SQuantity = (int)drSells[3];
                sellsRow.SSellingPrice = (decimal)drSells[4];

                cpDataSet.Sells.Rows.Add(sellsRow);
                tableAdapterManager.UpdateAll(cpDataSet);

                FillDataGridViewSells();
                //bs.DataSource = dt;

                dataGridViewSells.CurrentCell = dataGridViewSells.Rows[dataGridViewSells.Rows.Count - 2].Cells[0];
            }
            f2.Dispose();
        }

        private void EditSells(int i)
        {
            drSells = dtSells.Rows[i];
            DataTable dtg = new DataTable();
            goodsTableAdapter.Fill(this.cpDataSet.Goods);
            dtg = goodsTableAdapter.GetData();

            FSell f2 = new FSell(drSells, dtg, false);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && f2.dataChanged)
            {
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.FindBySellID((int)drSells[0]);

                sellsRow.SGID = (int)drSells[1];
                sellsRow.SDate = (DateTime)drSells[2];
                sellsRow.SQuantity = (int)drSells[3];
                sellsRow.SSellingPrice = (decimal)drSells[4];

                tableAdapterManager.UpdateAll(cpDataSet);

                if (f2.gNameChanged)
                    dtSells.Rows[i][5] = goodsTableAdapter.GetGNameByGID((int)drSells[1]);
            }
            f2.Dispose();
        }

        private void DeleteSells(int i)
        {
            if (MessageBox.Show("Remove record?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                drSells = dtSells.Rows[i];
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.FindBySellID((int)drSells[0]);
                sellsRow.Delete();

                tableAdapterManager.UpdateAll(cpDataSet);

                FillDataGridViewSells();
                //bs.DataSource = dt;

                if (i > dataGridViewSells.Rows.Count - 2)
                    dataGridViewSells.CurrentCell = dataGridViewSells.Rows[dataGridViewSells.Rows.Count - 2].Cells[0];
                else
                    dataGridViewSells.CurrentCell = dataGridViewSells.Rows[i].Cells[0];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewSells.Rows.Count - 1)  // EDIT
                EditSells(e.RowIndex);
            else if (e.RowIndex == dataGridViewSells.Rows.Count - 1)    // NEW
                NewSells();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (tabControlLists.TabIndex == 0 && dataGridViewSells.SelectedCells.Count > 0)
            {
                if (dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1) // EDIT
                    EditSells(dataGridViewSells.SelectedCells[0].RowIndex);
                else if (dataGridViewSells.SelectedCells[0].RowIndex == dataGridViewSells.Rows.Count - 1)   // NEW
                    NewSells();
            }
        }

        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            if (tabControlLists.TabIndex == 0)
                NewSells();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (tabControlLists.TabIndex == 0 &&
                dataGridViewSells.SelectedCells.Count > 0 &&
                dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1)
                    DeleteSells(dataGridViewSells.SelectedCells[0].RowIndex);
        }

        private void tabControlLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            //MessageBox.Show($"{t.SelectedIndex}");
            if (tc.SelectedIndex == 0)
                FillDataGridViewSells();
            else if (tc.SelectedIndex == 1)
                FillDataGridViewGoods();
        }
    }
}
