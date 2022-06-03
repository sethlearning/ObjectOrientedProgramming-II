namespace cp
{
    partial class FList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FList));
            this.tabControlLists = new System.Windows.Forms.TabControl();
            this.tabPageSells = new System.Windows.Forms.TabPage();
            this.dataGridViewSells = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSells = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSellsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSellsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSellsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSellsGoOver = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsGoOver = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuppliersNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuppliersEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuppliersDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuppliersGoOver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpDataSet = new cp.cpDataSet();
            this.sellsTableAdapter = new cp.cpDataSetTableAdapters.SellsTableAdapter();
            this.tableAdapterManager = new cp.cpDataSetTableAdapters.TableAdapterManager();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new cp.cpDataSetTableAdapters.GoodsTableAdapter();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new cp.cpDataSetTableAdapters.SuppliersTableAdapter();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlLists.SuspendLayout();
            this.tabPageSells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSells)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLists
            // 
            this.tabControlLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlLists.Controls.Add(this.tabPageSells);
            this.tabControlLists.Controls.Add(this.tabPageGoods);
            this.tabControlLists.Controls.Add(this.tabPageSuppliers);
            this.tabControlLists.Location = new System.Drawing.Point(12, 52);
            this.tabControlLists.Name = "tabControlLists";
            this.tabControlLists.SelectedIndex = 0;
            this.tabControlLists.Size = new System.Drawing.Size(858, 365);
            this.tabControlLists.TabIndex = 0;
            this.tabControlLists.SelectedIndexChanged += new System.EventHandler(this.TabChange);
            // 
            // tabPageSells
            // 
            this.tabPageSells.Controls.Add(this.dataGridViewSells);
            this.tabPageSells.Location = new System.Drawing.Point(4, 22);
            this.tabPageSells.Name = "tabPageSells";
            this.tabPageSells.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSells.Size = new System.Drawing.Size(850, 339);
            this.tabPageSells.TabIndex = 0;
            this.tabPageSells.Text = "Продажи";
            this.tabPageSells.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSells
            // 
            this.dataGridViewSells.AllowUserToOrderColumns = true;
            this.dataGridViewSells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSells.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewSells.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSells.Name = "dataGridViewSells";
            this.dataGridViewSells.Size = new System.Drawing.Size(838, 327);
            this.dataGridViewSells.TabIndex = 0;
            this.dataGridViewSells.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSells_CellDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemNew,
            this.ContextMenuItemEdit,
            this.ContextMenuItemDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(155, 70);
            // 
            // ContextMenuItemNew
            // 
            this.ContextMenuItemNew.Name = "ContextMenuItemNew";
            this.ContextMenuItemNew.Size = new System.Drawing.Size(154, 22);
            this.ContextMenuItemNew.Text = "Создать";
            this.ContextMenuItemNew.Click += new System.EventHandler(this.NewItemCommand);
            // 
            // ContextMenuItemEdit
            // 
            this.ContextMenuItemEdit.Name = "ContextMenuItemEdit";
            this.ContextMenuItemEdit.Size = new System.Drawing.Size(154, 22);
            this.ContextMenuItemEdit.Text = "Редактировать";
            this.ContextMenuItemEdit.Click += new System.EventHandler(this.EditItemCommand);
            // 
            // ContextMenuItemDelete
            // 
            this.ContextMenuItemDelete.Name = "ContextMenuItemDelete";
            this.ContextMenuItemDelete.Size = new System.Drawing.Size(154, 22);
            this.ContextMenuItemDelete.Text = "Удалить";
            this.ContextMenuItemDelete.Click += new System.EventHandler(this.DeleteItemCommand);
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Controls.Add(this.dataGridViewGoods);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoods.Size = new System.Drawing.Size(850, 339);
            this.tabPageGoods.TabIndex = 1;
            this.tabPageGoods.Text = "Товары";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoods.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewGoods.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.Size = new System.Drawing.Size(838, 327);
            this.dataGridViewGoods.TabIndex = 0;
            this.dataGridViewGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGoods_CellDoubleClick);
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.dataGridViewSuppliers);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(850, 339);
            this.tabPageSuppliers.TabIndex = 2;
            this.tabPageSuppliers.Text = "Поставщики";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(838, 327);
            this.dataGridViewSuppliers.TabIndex = 0;
            this.dataGridViewSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellDoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSells,
            this.ToolStripMenuItemGoods,
            this.ToolStripMenuItemSuppliers,
            this.ToolStripMenuItemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(874, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSells
            // 
            this.ToolStripMenuItemSells.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSellsNew,
            this.ToolStripMenuItemSellsEdit,
            this.ToolStripMenuItemSellsDelete,
            this.ToolStripMenuItemSellsGoOver});
            this.ToolStripMenuItemSells.Name = "ToolStripMenuItemSells";
            this.ToolStripMenuItemSells.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMenuItemSells.Text = "Продажи";
            this.ToolStripMenuItemSells.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSells_MouseEnter);
            this.ToolStripMenuItemSells.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSellsNew
            // 
            this.ToolStripMenuItemSellsNew.Name = "ToolStripMenuItemSellsNew";
            this.ToolStripMenuItemSellsNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSellsNew.Text = "Создать";
            this.ToolStripMenuItemSellsNew.Click += new System.EventHandler(this.NewSellMenuCommand);
            this.ToolStripMenuItemSellsNew.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSellsNew_MouseEnter);
            this.ToolStripMenuItemSellsNew.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSellsEdit
            // 
            this.ToolStripMenuItemSellsEdit.Name = "ToolStripMenuItemSellsEdit";
            this.ToolStripMenuItemSellsEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSellsEdit.Text = "Редактировать";
            this.ToolStripMenuItemSellsEdit.Click += new System.EventHandler(this.EditItemCommand);
            this.ToolStripMenuItemSellsEdit.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSellsEdit_MouseEnter);
            this.ToolStripMenuItemSellsEdit.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSellsDelete
            // 
            this.ToolStripMenuItemSellsDelete.Name = "ToolStripMenuItemSellsDelete";
            this.ToolStripMenuItemSellsDelete.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSellsDelete.Text = "Удалить";
            this.ToolStripMenuItemSellsDelete.Click += new System.EventHandler(this.DeleteItemCommand);
            this.ToolStripMenuItemSellsDelete.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSellsDelete_MouseEnter);
            this.ToolStripMenuItemSellsDelete.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSellsGoOver
            // 
            this.ToolStripMenuItemSellsGoOver.Name = "ToolStripMenuItemSellsGoOver";
            this.ToolStripMenuItemSellsGoOver.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSellsGoOver.Text = "Перейти";
            this.ToolStripMenuItemSellsGoOver.Visible = false;
            this.ToolStripMenuItemSellsGoOver.Click += new System.EventHandler(this.ToolStripMenuItemSellsGoOver_Click);
            this.ToolStripMenuItemSellsGoOver.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSellsGoOver_MouseEnter);
            this.ToolStripMenuItemSellsGoOver.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemGoods
            // 
            this.ToolStripMenuItemGoods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGoodsNew,
            this.ToolStripMenuItemGoodsEdit,
            this.ToolStripMenuItemGoodsDelete,
            this.ToolStripMenuItemGoodsGoOver});
            this.ToolStripMenuItemGoods.Name = "ToolStripMenuItemGoods";
            this.ToolStripMenuItemGoods.Size = new System.Drawing.Size(60, 20);
            this.ToolStripMenuItemGoods.Text = "Товары";
            this.ToolStripMenuItemGoods.MouseEnter += new System.EventHandler(this.ToolStripMenuItemGoods_MouseEnter);
            this.ToolStripMenuItemGoods.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemGoodsNew
            // 
            this.ToolStripMenuItemGoodsNew.Name = "ToolStripMenuItemGoodsNew";
            this.ToolStripMenuItemGoodsNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemGoodsNew.Text = "Создать";
            this.ToolStripMenuItemGoodsNew.Click += new System.EventHandler(this.NewGoodMenuCommand);
            this.ToolStripMenuItemGoodsNew.MouseEnter += new System.EventHandler(this.ToolStripMenuItemGoodsNew_MouseEnter);
            this.ToolStripMenuItemGoodsNew.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemGoodsEdit
            // 
            this.ToolStripMenuItemGoodsEdit.Name = "ToolStripMenuItemGoodsEdit";
            this.ToolStripMenuItemGoodsEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemGoodsEdit.Text = "Редактировать";
            this.ToolStripMenuItemGoodsEdit.Visible = false;
            this.ToolStripMenuItemGoodsEdit.Click += new System.EventHandler(this.EditItemCommand);
            this.ToolStripMenuItemGoodsEdit.MouseEnter += new System.EventHandler(this.ToolStripMenuItemGoodsEdit_MouseEnter);
            this.ToolStripMenuItemGoodsEdit.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemGoodsDelete
            // 
            this.ToolStripMenuItemGoodsDelete.Name = "ToolStripMenuItemGoodsDelete";
            this.ToolStripMenuItemGoodsDelete.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemGoodsDelete.Text = "Удалить";
            this.ToolStripMenuItemGoodsDelete.Visible = false;
            this.ToolStripMenuItemGoodsDelete.Click += new System.EventHandler(this.DeleteItemCommand);
            this.ToolStripMenuItemGoodsDelete.MouseEnter += new System.EventHandler(this.ToolStripMenuItemGoodsDelete_MouseEnter);
            this.ToolStripMenuItemGoodsDelete.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemGoodsGoOver
            // 
            this.ToolStripMenuItemGoodsGoOver.Name = "ToolStripMenuItemGoodsGoOver";
            this.ToolStripMenuItemGoodsGoOver.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemGoodsGoOver.Text = "Перейти";
            this.ToolStripMenuItemGoodsGoOver.Click += new System.EventHandler(this.ToolStripMenuItemGoodsGoOver_Click);
            this.ToolStripMenuItemGoodsGoOver.MouseEnter += new System.EventHandler(this.ToolStripMenuItemGoodsGoOver_MouseEnter);
            this.ToolStripMenuItemGoodsGoOver.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSuppliers
            // 
            this.ToolStripMenuItemSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSuppliersNew,
            this.ToolStripMenuItemSuppliersEdit,
            this.ToolStripMenuItemSuppliersDelete,
            this.ToolStripMenuItemSuppliersGoOver});
            this.ToolStripMenuItemSuppliers.Name = "ToolStripMenuItemSuppliers";
            this.ToolStripMenuItemSuppliers.Size = new System.Drawing.Size(89, 20);
            this.ToolStripMenuItemSuppliers.Text = "Поставщики";
            this.ToolStripMenuItemSuppliers.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSuppliers_MouseEnter);
            this.ToolStripMenuItemSuppliers.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSuppliersNew
            // 
            this.ToolStripMenuItemSuppliersNew.Name = "ToolStripMenuItemSuppliersNew";
            this.ToolStripMenuItemSuppliersNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSuppliersNew.Text = "Создать";
            this.ToolStripMenuItemSuppliersNew.Click += new System.EventHandler(this.NewSupplierMenuCommand);
            this.ToolStripMenuItemSuppliersNew.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSuppliersNew_MouseEnter);
            this.ToolStripMenuItemSuppliersNew.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSuppliersEdit
            // 
            this.ToolStripMenuItemSuppliersEdit.Name = "ToolStripMenuItemSuppliersEdit";
            this.ToolStripMenuItemSuppliersEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSuppliersEdit.Text = "Редактировать";
            this.ToolStripMenuItemSuppliersEdit.Visible = false;
            this.ToolStripMenuItemSuppliersEdit.Click += new System.EventHandler(this.EditItemCommand);
            this.ToolStripMenuItemSuppliersEdit.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSuppliersEdit_MouseEnter);
            this.ToolStripMenuItemSuppliersEdit.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSuppliersDelete
            // 
            this.ToolStripMenuItemSuppliersDelete.Name = "ToolStripMenuItemSuppliersDelete";
            this.ToolStripMenuItemSuppliersDelete.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSuppliersDelete.Text = "Удалить";
            this.ToolStripMenuItemSuppliersDelete.Visible = false;
            this.ToolStripMenuItemSuppliersDelete.Click += new System.EventHandler(this.DeleteItemCommand);
            this.ToolStripMenuItemSuppliersDelete.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSuppliersDelete_MouseEnter);
            this.ToolStripMenuItemSuppliersDelete.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // ToolStripMenuItemSuppliersGoOver
            // 
            this.ToolStripMenuItemSuppliersGoOver.Name = "ToolStripMenuItemSuppliersGoOver";
            this.ToolStripMenuItemSuppliersGoOver.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSuppliersGoOver.Text = "Перейти";
            this.ToolStripMenuItemSuppliersGoOver.Click += new System.EventHandler(this.ToolStripMenuItemSuppliersGoOver_Click);
            this.ToolStripMenuItemSuppliersGoOver.MouseEnter += new System.EventHandler(this.ToolStripMenuItemSuppliersGoOver_MouseEnter);
            this.ToolStripMenuItemSuppliersGoOver.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreate,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStrip.Size = new System.Drawing.Size(874, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonCreate
            // 
            this.toolStripButtonCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreate.Image")));
            this.toolStripButtonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreate.Name = "toolStripButtonCreate";
            this.toolStripButtonCreate.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonCreate.Text = "Создать";
            this.toolStripButtonCreate.Click += new System.EventHandler(this.NewItemCommand);
            this.toolStripButtonCreate.MouseEnter += new System.EventHandler(this.toolStripButtonCreate_MouseEnter);
            this.toolStripButtonCreate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(91, 22);
            this.toolStripButtonEdit.Text = "Редактировать";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.EditItemCommand);
            this.toolStripButtonEdit.MouseEnter += new System.EventHandler(this.toolStripButtonEdit_MouseEnter);
            this.toolStripButtonEdit.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.DeleteItemCommand);
            this.toolStripButtonDelete.MouseEnter += new System.EventHandler(this.toolStripButtonDelete_MouseEnter);
            this.toolStripButtonDelete.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(874, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // sellsBindingSource
            // 
            this.sellsBindingSource.DataMember = "Sells";
            this.sellsBindingSource.DataSource = this.cpDataSet;
            // 
            // cpDataSet
            // 
            this.cpDataSet.DataSetName = "cpDataSet";
            this.cpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellsTableAdapter
            // 
            this.sellsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.SellsTableAdapter = this.sellsTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cp.cpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.cpDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.cpDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            this.ToolStripMenuItemExit.MouseEnter += new System.EventHandler(this.toolStripButtonExit_MouseEnter);
            this.ToolStripMenuItemExit.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
            // 
            // FList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControlLists);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(890, 39);
            this.Name = "FList";
            this.Text = "Computer equipment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlLists.ResumeLayout(false);
            this.tabPageSells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSells)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabPageGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.tabPageSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLists;
        private System.Windows.Forms.TabPage tabPageSells;
        private System.Windows.Forms.TabPage tabPageGoods;
        private System.Windows.Forms.DataGridView dataGridViewSells;
        private cpDataSet cpDataSet;
        private System.Windows.Forms.BindingSource sellsBindingSource;
        private cpDataSetTableAdapters.SellsTableAdapter sellsTableAdapter;
        private cpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        public cpDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private cpDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreate;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.TabPage tabPageSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSells;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSellsNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSellsEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSellsDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoods;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoodsNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoodsEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoodsDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGoodsGoOver;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuppliers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuppliersNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuppliersEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuppliersDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuppliersGoOver;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSellsGoOver;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

