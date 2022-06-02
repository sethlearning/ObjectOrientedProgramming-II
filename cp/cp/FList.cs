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
        private BindingSource bsGoods = new BindingSource();
        //private DataTable dt = new DataTable();
        private DataTable dtSells = new DataTable();
        private DataTable dtGoods = new DataTable();
        //private DataRow dr;
        private DataRow drSells;
        private DataRow drGoods;

        public FList()
        {
            InitializeComponent();
        }
        
        private void FillDataGridViewSells()
        {
            this.sellsTableAdapter.FillExt(this.cpDataSet.Sells);
            dtSells = this.sellsTableAdapter.GetDataExt();
            dtSells.Columns[0].ColumnName = "ID продажи";
            dtSells.Columns[1].ColumnName = "ID товара";
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
            //d.Columns[0].Resizable = DataGridViewTriState.True;
            //d.Columns[1].Resizable = DataGridViewTriState.True;
            //d.Columns[2].Resizable = DataGridViewTriState.True;
            //d.Columns[3].Resizable = DataGridViewTriState.True;
            //d.Columns[4].Resizable = DataGridViewTriState.True;
            //d.Columns[5].Resizable = DataGridViewTriState.True;
            d.Columns[0].MinimumWidth = 95;
            d.Columns[1].MinimumWidth = 95;
            d.Columns[2].MinimumWidth = 105;
            d.Columns[3].MinimumWidth = 80;
            d.Columns[4].MinimumWidth = 80;
            d.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SellID
            d.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SGID
            d.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SDate
            d.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SQuantity
            d.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SSellingrice
            d.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;        // GName
        }

        private void FillDataGridViewGoods()
        {
            this.goodsTableAdapter.FillExt(this.cpDataSet.Goods);
            dtGoods = this.goodsTableAdapter.GetDataExt();
            dtGoods.Columns[0].ColumnName = "ID товара";
            dtGoods.Columns[1].ColumnName = "Наименование товара";
            dtGoods.Columns[2].ColumnName = "ID поставщика";
            dtGoods.Columns[3].ColumnName = "Дата поставки";
            dtGoods.Columns[4].ColumnName = "Количество";
            dtGoods.Columns[5].ColumnName = "Оптовая цена";
            dtGoods.Columns[6].ColumnName = "Поставщик";
            bsGoods.DataSource = dtGoods;
        }

        private void FormatDataGridViewGoods(DataGridView d)
        {
            d.Columns[6].DisplayIndex = 3;
            d.Columns[0].MinimumWidth = 85;
            //d.Columns[1].MinimumWidth = 200;
            d.Columns[2].MinimumWidth = 110;
            d.Columns[3].MinimumWidth = 110;
            d.Columns[4].MinimumWidth = 70;
            d.Columns[5].MinimumWidth = 105;
            d.Columns[6].MinimumWidth = 100;
            d.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // GID
            d.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;        // GName
            d.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // GSupplierID
            d.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // GSupplyDate
            d.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // GQuantity
            d.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // GBuyingPrice
            d.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SName
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            this.goodsTableAdapter.Fill(this.cpDataSet.Goods);
            this.sellsTableAdapter.Fill(this.cpDataSet.Sells);

            FillDataGridViewSells();
            dataGridViewSells.DataSource = bsSells;
            FormatDataGridViewSells(dataGridViewSells);

            FillDataGridViewGoods();
            dataGridViewGoods.DataSource = bsGoods;
            FormatDataGridViewGoods(dataGridViewGoods);
            // dtSells = this.sellsTableAdapter.GetData();
        }

        #region Sells
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

                sellsTableAdapter.Update(sellsRow);
                //tableAdapterManager.UpdateAll(cpDataSet);

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
        #endregion Sells

        #region Goods
        private void NewGoods()
        {
            drGoods = dtGoods.Rows[0];
            DataTable dts = new DataTable();
            suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            dts = suppliersTableAdapter.GetData();

            FGood f2 = new FGood(drGoods, dts, true);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                cpDataSet.GoodsRow goodsRow = cpDataSet.Goods.NewGoodsRow();
                goodsRow.GName = (string)drGoods[1];
                goodsRow.GSupplierID = (int)drGoods[2];
                goodsRow.GSupplyDate = (DateTime)drGoods[3];
                goodsRow.GQuantity = (int)drGoods[4];
                goodsRow.GBuyingPrice = (decimal)drGoods[5];

                cpDataSet.Goods.Rows.Add(goodsRow);
                goodsTableAdapter.Update(cpDataSet);
                //tableAdapterManager.UpdateAll(cpDataSet);

                FillDataGridViewGoods();
                dataGridViewGoods.CurrentCell = dataGridViewGoods.Rows[dataGridViewGoods.Rows.Count - 2].Cells[0];
            }
            f2.Dispose();
        }

        private void EditGoods(int i)
        {
            drGoods = dtGoods.Rows[i];
            DataTable dts = new DataTable();
            suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);
            dts = suppliersTableAdapter.GetData();

            FGood f2 = new FGood(drGoods, dts, false);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && f2.dataChanged)
            {
                cpDataSet.GoodsRow goodsRow = cpDataSet.Goods.FindByGID((int)drGoods[0]);

                goodsRow.GName = (string)drGoods[1];
                goodsRow.GSupplierID = (int)drGoods[2];
                goodsRow.GSupplyDate = (DateTime)drGoods[3];
                goodsRow.GQuantity = (int)drGoods[4];
                goodsRow.GBuyingPrice = (decimal)drGoods[5];

                goodsTableAdapter.Update(goodsRow);

                //tableAdapterManager.UpdateAll(cpDataSet);

                if (f2.sNameChanged)
                    dtGoods.Rows[i][6] = suppliersTableAdapter.GetSNameBySupplierID((int)drGoods[2]);
            }
            f2.Dispose();
        }
        #endregion Goods
        
        // CREATE Button
        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0)
                NewSells();
            else if (tabControlLists.SelectedIndex == 1)
                NewGoods();
        }

        // EDIT Button
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0 && dataGridViewSells.SelectedCells.Count > 0)
            {
                if (dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1) // EDIT Sell
                    EditSells(dataGridViewSells.SelectedCells[0].RowIndex);
                else if (dataGridViewSells.SelectedCells[0].RowIndex == dataGridViewSells.Rows.Count - 1)   // NEW Sell
                    NewSells();
            }
            else if (tabControlLists.SelectedIndex == 1 && dataGridViewGoods.SelectedCells.Count > 0)
            {
                if (dataGridViewGoods.SelectedCells[0].RowIndex < dataGridViewGoods.Rows.Count - 1) // EDIT Good
                    EditGoods(dataGridViewGoods.SelectedCells[0].RowIndex);
                else if (dataGridViewGoods.SelectedCells[0].RowIndex == dataGridViewGoods.Rows.Count - 1)   // NEW Good
                    NewGoods();
            }
        }



        // DELETE Button
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0 &&
                dataGridViewSells.SelectedCells.Count > 0 &&
                dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1)
                    DeleteSells(dataGridViewSells.SelectedCells[0].RowIndex);
        }

        // Tab Changed
        private void tabControlLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            //MessageBox.Show($"{t.SelectedIndex}");
            if (tc.SelectedIndex == 0)
                FillDataGridViewSells();
            else if (tc.SelectedIndex == 1)
                FillDataGridViewGoods();

        }

        private void dataGridViewSells_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewSells.Rows.Count - 1)  // EDIT
                EditSells(e.RowIndex);
            else if (e.RowIndex == dataGridViewSells.Rows.Count - 1)    // NEW
                NewSells();
        }

        private void dataGridViewGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewGoods.Rows.Count - 1) // EDIT
                EditGoods(e.RowIndex);
            if (e.RowIndex == dataGridViewGoods.Rows.Count - 1) // NEW
                NewGoods();

        }
    }
}
