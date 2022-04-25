namespace Lab_6
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextGetControl = new System.Windows.Forms.ToolStripMenuItem();
            this.contextGetProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGraphickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphic1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphic2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphic3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelControl = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jpegLoadButton = new System.Windows.Forms.ToolStripButton();
            this.bmpLoadButton = new System.Windows.Forms.ToolStripButton();
            this.graphic1Button = new System.Windows.Forms.ToolStripButton();
            this.graphic2Button = new System.Windows.Forms.ToolStripButton();
            this.graphic3Button = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ContextMenuStrip = this.contextMenuStrip;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(838, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextGetControl,
            this.contextGetProperties});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(185, 48);
            // 
            // contextGetControl
            // 
            this.contextGetControl.Name = "contextGetControl";
            this.contextGetControl.Size = new System.Drawing.Size(184, 22);
            this.contextGetControl.Text = "Get control name";
            this.contextGetControl.Click += new System.EventHandler(this.getControlType);
            // 
            // contextGetProperties
            // 
            this.contextGetProperties.Name = "contextGetProperties";
            this.contextGetProperties.Size = new System.Drawing.Size(184, 22);
            this.contextGetProperties.Text = "Get image properties";
            this.contextGetProperties.Click += new System.EventHandler(this.getImageOrGraphicProperties);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitRoutine);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.createGraphickToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jPGToolStripMenuItem,
            this.bMPToolStripMenuItem});
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.jPGToolStripMenuItem.Text = "JPEG Format";
            this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGFileOpenHandler);
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.bMPToolStripMenuItem.Text = "BMP Format";
            this.bMPToolStripMenuItem.Click += new System.EventHandler(this.bMPFileOpenHandler);
            // 
            // createGraphickToolStripMenuItem
            // 
            this.createGraphickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphic1ToolStripMenuItem,
            this.graphic2ToolStripMenuItem,
            this.graphic3ToolStripMenuItem});
            this.createGraphickToolStripMenuItem.Name = "createGraphickToolStripMenuItem";
            this.createGraphickToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createGraphickToolStripMenuItem.Text = "Create Graphic";
            // 
            // graphic1ToolStripMenuItem
            // 
            this.graphic1ToolStripMenuItem.Name = "graphic1ToolStripMenuItem";
            this.graphic1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.graphic1ToolStripMenuItem.Text = "Graphic 1";
            this.graphic1ToolStripMenuItem.Click += new System.EventHandler(this.drawGraphic1);
            // 
            // graphic2ToolStripMenuItem
            // 
            this.graphic2ToolStripMenuItem.Name = "graphic2ToolStripMenuItem";
            this.graphic2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.graphic2ToolStripMenuItem.Text = "Graphic 2";
            this.graphic2ToolStripMenuItem.Click += new System.EventHandler(this.chartGraphic1);
            // 
            // graphic3ToolStripMenuItem
            // 
            this.graphic3ToolStripMenuItem.Name = "graphic3ToolStripMenuItem";
            this.graphic3ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.graphic3ToolStripMenuItem.Text = "Graphic 3";
            this.graphic3ToolStripMenuItem.Click += new System.EventHandler(this.chartGraphic2);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.ContextMenuStrip = this.contextMenuStrip;
            this.textBox.Location = new System.Drawing.Point(12, 412);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(814, 75);
            this.textBox.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.ContextMenuStrip = this.contextMenuStrip;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFileName,
            this.labelSeparator,
            this.labelControl});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(838, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelFileName
            // 
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(57, 17);
            this.labelFileName.Text = "FileName";
            // 
            // labelSeparator
            // 
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(10, 17);
            this.labelSeparator.Text = "|";
            // 
            // labelControl
            // 
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(47, 17);
            this.labelControl.Text = "Control";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ContextMenuStrip = this.contextMenuStrip;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpegLoadButton,
            this.bmpLoadButton,
            this.toolStripSeparator1,
            this.graphic1Button,
            this.graphic2Button,
            this.graphic3Button,
            this.toolStripSeparator2,
            this.exitButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(838, 41);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "N2";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.contextMenuStrip;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 69);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(814, 338);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // jpegLoadButton
            // 
            this.jpegLoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jpegLoadButton.Image = ((System.Drawing.Image)(resources.GetObject("jpegLoadButton.Image")));
            this.jpegLoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jpegLoadButton.Name = "jpegLoadButton";
            this.jpegLoadButton.Size = new System.Drawing.Size(32, 38);
            this.jpegLoadButton.Text = "toolStripButton1";
            this.jpegLoadButton.Click += new System.EventHandler(this.jPGFileOpenHandler);
            // 
            // bmpLoadButton
            // 
            this.bmpLoadButton.AutoSize = false;
            this.bmpLoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bmpLoadButton.Image = global::Lab_6.Properties.Resources.bmp_icon;
            this.bmpLoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bmpLoadButton.Name = "bmpLoadButton";
            this.bmpLoadButton.Size = new System.Drawing.Size(40, 40);
            this.bmpLoadButton.Text = "toolStripButton2";
            this.bmpLoadButton.Click += new System.EventHandler(this.bMPFileOpenHandler);
            // 
            // graphic1Button
            // 
            this.graphic1Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graphic1Button.Image = global::Lab_6.Properties.Resources.green_chart_icon;
            this.graphic1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graphic1Button.Name = "graphic1Button";
            this.graphic1Button.Size = new System.Drawing.Size(32, 38);
            this.graphic1Button.Text = "toolStripButton1";
            this.graphic1Button.Click += new System.EventHandler(this.drawGraphic1);
            // 
            // graphic2Button
            // 
            this.graphic2Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graphic2Button.Image = global::Lab_6.Properties.Resources.yellow_chart_icon;
            this.graphic2Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graphic2Button.Name = "graphic2Button";
            this.graphic2Button.Size = new System.Drawing.Size(32, 38);
            this.graphic2Button.Text = "toolStripButton1";
            this.graphic2Button.Click += new System.EventHandler(this.chartGraphic1);
            // 
            // graphic3Button
            // 
            this.graphic3Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.graphic3Button.Image = global::Lab_6.Properties.Resources.red_chart_icon;
            this.graphic3Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graphic3Button.Name = "graphic3Button";
            this.graphic3Button.Size = new System.Drawing.Size(32, 38);
            this.graphic3Button.Text = "toolStripButton1";
            this.graphic3Button.Click += new System.EventHandler(this.chartGraphic2);
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitButton.Image = global::Lab_6.Properties.Resources.close_icon;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 38);
            this.exitButton.Text = "toolStripButton1";
            this.exitButton.Click += new System.EventHandler(this.exitRoutine);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBox.Location = new System.Drawing.Point(12, 69);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(814, 338);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 512);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.pictureBox);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Lab-6.1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton jpegLoadButton;
        private System.Windows.Forms.ToolStripButton bmpLoadButton;
        private System.Windows.Forms.ToolStripStatusLabel labelFileName;
        private System.Windows.Forms.ToolStripStatusLabel labelControl;
        private System.Windows.Forms.ToolStripMenuItem contextGetControl;
        private System.Windows.Forms.ToolStripStatusLabel labelSeparator;
        private System.Windows.Forms.ToolStripMenuItem contextGetProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton graphic1Button;
        private System.Windows.Forms.ToolStripButton graphic2Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ToolStripButton graphic3Button;
        private System.Windows.Forms.ToolStripMenuItem createGraphickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphic1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphic2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphic3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

