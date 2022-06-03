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
        private BindingSource bsSuppliers = new BindingSource();

        private DataTable dtSells = new DataTable();
        private DataTable dtGoods = new DataTable();
        private DataTable dtSuppliers = new DataTable();

        private DataRow drSells;
        private DataRow drGoods;
        private DataRow drSuppliers;

        public FList()
        {
            InitializeComponent();
        }
        
        private void FillDataGridViewSells()
        {
            this.sellsTableAdapter.FillExtSort(this.cpDataSet.Sells);
            dtSells = this.sellsTableAdapter.GetDataExtSort();
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
            this.goodsTableAdapter.FillExtSort(this.cpDataSet.Goods);
            dtGoods = this.goodsTableAdapter.GetDataExtSort();
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

        private void FillDataGridViewSuppliers()
        {
            this.suppliersTableAdapter.FillSort(this.cpDataSet.Suppliers);
            dtSuppliers = this.suppliersTableAdapter.GetDataSort();
            dtSuppliers.Columns[0].ColumnName = "ID поставщика";
            dtSuppliers.Columns[1].ColumnName = "Поставщик";
            dtSuppliers.Columns[2].ColumnName = "Адрес";
            dtSuppliers.Columns[3].ColumnName = "Телефон";
            dtSuppliers.Columns[4].ColumnName = "Контакт";
            bsSuppliers.DataSource = dtSuppliers;
        }

        private void FormatDataGridViewSuppliers(DataGridView d)
        {
            d.Columns[0].MinimumWidth = 110;
            d.Columns[2].MinimumWidth = 100;
            d.Columns[3].MinimumWidth = 100;
            d.Columns[4].MinimumWidth = 110;
            d.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SuppliersID
            d.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;        // SName
            d.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SAddress
            d.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SPhoneNumber
            d.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;    // SContact
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sellsTableAdapter.Fill(this.cpDataSet.Sells);
            this.goodsTableAdapter.Fill(this.cpDataSet.Goods);
            this.suppliersTableAdapter.Fill(this.cpDataSet.Suppliers);

            FillDataGridViewSells();
            dataGridViewSells.DataSource = bsSells;
            FormatDataGridViewSells(dataGridViewSells);

            FillDataGridViewGoods();
            dataGridViewGoods.DataSource = bsGoods;
            FormatDataGridViewGoods(dataGridViewGoods);

            FillDataGridViewSuppliers();
            dataGridViewSuppliers.DataSource = bsSuppliers;
            FormatDataGridViewSuppliers(dataGridViewSuppliers);
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
            if (MessageBox.Show($"Удалить продажу №{dtSells.Rows[i][0]}?", $"Удаление продажи №{dtSells.Rows[i][0]}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                drSells = dtSells.Rows[i];
                cpDataSet.SellsRow sellsRow = cpDataSet.Sells.FindBySellID((int)drSells[0]);
                sellsRow.Delete();

                try
                {
                    sellsTableAdapter.Update(sellsRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления продажи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cpDataSet.RejectChanges();
                    return;
                }

                //tableAdapterManager.UpdateAll(cpDataSet);
                FillDataGridViewSells();

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
        private void DeleteGoods(int i)
        {
            if (MessageBox.Show($"Удалить товар \"{dtGoods.Rows[i][1]}\"?", $"Удаление товара №{dtGoods.Rows[i][0]}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                drGoods = dtGoods.Rows[i];
                cpDataSet.GoodsRow goodsRow = cpDataSet.Goods.FindByGID((int)drGoods[0]);
                goodsRow.Delete();

                try
                {
                    goodsTableAdapter.Update(goodsRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cpDataSet.RejectChanges();
                    return;
                }

                FillDataGridViewGoods();

                if (i > dataGridViewGoods.Rows.Count - 2)
                    dataGridViewGoods.CurrentCell = dataGridViewGoods.Rows[dataGridViewGoods.Rows.Count - 2].Cells[0];
                else
                    dataGridViewGoods.CurrentCell = dataGridViewGoods.Rows[i].Cells[0];
            }
        }
        #endregion Goods

        #region Suppliers
        private void NewSuppliers()
        {
            drSuppliers = dtSuppliers.Rows[0];

            FSupplier f2 = new FSupplier(drSuppliers, true);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                cpDataSet.SuppliersRow suppliersRow = cpDataSet.Suppliers.NewSuppliersRow();
                suppliersRow.SName = (string)drSuppliers[1];
                suppliersRow.SAddress = (string)drSuppliers[2];
                suppliersRow.SPhoneNumber = (string)drSuppliers[3];
                suppliersRow.SContact = (string)drSuppliers[4];

                cpDataSet.Suppliers.Rows.Add(suppliersRow);
                suppliersTableAdapter.Update(suppliersRow);
                //tableAdapterManager.UpdateAll(cpDataSet);

                FillDataGridViewSuppliers();
                dataGridViewSuppliers.CurrentCell = dataGridViewSuppliers.Rows[dataGridViewSuppliers.Rows.Count - 2].Cells[0];
            }
            f2.Dispose();
        }
        private void EditSuppliers(int i)
        {
            drSuppliers = dtSuppliers.Rows[i];

            FSupplier f2 = new FSupplier(drSuppliers, false);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && f2.dataChanged)
            {
                cpDataSet.SuppliersRow suppliersRow = cpDataSet.Suppliers.FindBySupplierID((int)drSuppliers[0]);

                suppliersRow.SName = (string)drSuppliers[1];
                suppliersRow.SAddress = (string)drSuppliers[2];
                suppliersRow.SPhoneNumber = (string)drSuppliers[3];
                suppliersRow.SContact = (string)drSuppliers[4];

                suppliersTableAdapter.Update(suppliersRow);
                //tableAdapterManager.UpdateAll(cpDataSet);
            }
            f2.Dispose();
        }
        private void DeleteSuppliers(int i)
        {
            if (MessageBox.Show($"Удалить поставщика \"{dtSuppliers.Rows[i][1]}\"?", $"Удаление поставщика №{dtSuppliers.Rows[i][0]}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                drSuppliers = dtSuppliers.Rows[i];
                cpDataSet.SuppliersRow suppliersRow = cpDataSet.Suppliers.FindBySupplierID((int)drSuppliers[0]);
                suppliersRow.Delete();

                try
                {
                    suppliersTableAdapter.Update(suppliersRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления поставщика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cpDataSet.RejectChanges();
                    return;
                }

                FillDataGridViewSuppliers();

                if (i > dataGridViewSuppliers.Rows.Count - 2)
                    dataGridViewSuppliers.CurrentCell = dataGridViewSuppliers.Rows[dataGridViewSuppliers.Rows.Count - 2].Cells[0];
                else
                    dataGridViewSuppliers.CurrentCell = dataGridViewSuppliers.Rows[i].Cells[0];
            }
        }
        #endregion Suppliers

        // CREATE Button
        private void NewItem(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0)
                NewSells();
            else if (tabControlLists.SelectedIndex == 1)
                NewGoods();
            else if (tabControlLists.SelectedIndex == 2)
                NewSuppliers();
        }

        // EDIT Button
        private void EditItem(object sender, EventArgs e)
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

            else if (tabControlLists.SelectedIndex == 2 && dataGridViewSuppliers.SelectedCells.Count > 0)
            {
                if (dataGridViewSuppliers.SelectedCells[0].RowIndex < dataGridViewSuppliers.Rows.Count - 1) // EDIT Supplier
                    EditSuppliers(dataGridViewSuppliers.SelectedCells[0].RowIndex);
                else if (dataGridViewSuppliers.SelectedCells[0].RowIndex == dataGridViewSuppliers.Rows.Count - 1)   // NEW Supplier
                    NewSuppliers();
            }

        }

        // DELETE Button
        private void DeleteItem(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0 &&
                dataGridViewSells.SelectedCells.Count > 0 &&
                dataGridViewSells.SelectedCells[0].RowIndex < dataGridViewSells.Rows.Count - 1)
                    DeleteSells(dataGridViewSells.SelectedCells[0].RowIndex);

            else if (tabControlLists.SelectedIndex == 1 &&
                dataGridViewGoods.SelectedCells.Count > 0 &&
                dataGridViewGoods.SelectedCells[0].RowIndex < dataGridViewGoods.Rows.Count - 1)
                    DeleteGoods(dataGridViewGoods.SelectedCells[0].RowIndex);

            else if (tabControlLists.SelectedIndex == 2 &&
                dataGridViewSuppliers.SelectedCells.Count > 0 &&
                dataGridViewSuppliers.SelectedCells[0].RowIndex < dataGridViewSuppliers.Rows.Count - 1)
                    DeleteSuppliers(dataGridViewSuppliers.SelectedCells[0].RowIndex);
        }

        // Tab Changed
        private void tabControlLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;

            if (tc.SelectedIndex == 0)
                FillDataGridViewSells();
            else if (tc.SelectedIndex == 1)
                FillDataGridViewGoods();
            else if (tc.SelectedIndex == 2)
                FillDataGridViewSuppliers();
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
            else if (e.RowIndex == dataGridViewGoods.Rows.Count - 1) // NEW
                NewGoods();

        }

        private void dataGridViewSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewSuppliers.Rows.Count - 1) // EDIT
                EditSuppliers(e.RowIndex);
            else if (e.RowIndex == dataGridViewSuppliers.Rows.Count - 1) // NEW
                NewSuppliers();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonCreate_MouseEnter(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0)
                toolStripStatusLabel.Text = "Новая продажа";
            else if (tabControlLists.SelectedIndex == 1)
                toolStripStatusLabel.Text = "Новый товар";
            else if (tabControlLists.SelectedIndex == 2)
                toolStripStatusLabel.Text = "Новый поставщик";
        }

        private void CleatStatusLabel(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }

        private void toolStripButtonEdit_MouseEnter(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0)
                toolStripStatusLabel.Text = "Редактирование продажи";
            else if (tabControlLists.SelectedIndex == 1)
                toolStripStatusLabel.Text = "Редактирование товара";
            else if (tabControlLists.SelectedIndex == 2)
                toolStripStatusLabel.Text = "Редактирование поставщика";
        }

        private void toolStripButtonDelete_MouseEnter(object sender, EventArgs e)
        {
            if (tabControlLists.SelectedIndex == 0)
                toolStripStatusLabel.Text = "Удаление продажи";
            else if (tabControlLists.SelectedIndex == 1)
                toolStripStatusLabel.Text = "Удаление товара";
            else if (tabControlLists.SelectedIndex == 2)
                toolStripStatusLabel.Text = "Удаление поставщика";
        }

        private void toolStripButtonExit_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Выход";
        }
    }
}
