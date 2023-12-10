
namespace Tyuiu.RagimovaMA.Sprint6.Task5.V22
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_RMA = new System.Windows.Forms.Panel();
            this.panelLeft_RMA = new System.Windows.Forms.Panel();
            this.panelRight_RMA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RMA = new System.Windows.Forms.TextBox();
            this.buttonHelp_RMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_RMA = new System.Windows.Forms.Button();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.splitterResult_RMA = new System.Windows.Forms.Splitter();
            this.chartFunction_RMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_RMA = new System.Windows.Forms.DataGridView();
            this.panelTop_RMA.SuspendLayout();
            this.panelLeft_RMA.SuspendLayout();
            this.panelRight_RMA.SuspendLayout();
            this.groupBoxTask_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_RMA
            // 
            this.panelTop_RMA.Controls.Add(this.buttonDone_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonOpenFile_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonHelp_RMA);
            this.panelTop_RMA.Controls.Add(this.groupBoxTask_RMA);
            this.panelTop_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_RMA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_RMA.Name = "panelTop_RMA";
            this.panelTop_RMA.Size = new System.Drawing.Size(800, 78);
            this.panelTop_RMA.TabIndex = 0;
            // 
            // panelLeft_RMA
            // 
            this.panelLeft_RMA.Controls.Add(this.groupBoxResult_RMA);
            this.panelLeft_RMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_RMA.Location = new System.Drawing.Point(0, 78);
            this.panelLeft_RMA.Name = "panelLeft_RMA";
            this.panelLeft_RMA.Size = new System.Drawing.Size(188, 372);
            this.panelLeft_RMA.TabIndex = 0;
            // 
            // panelRight_RMA
            // 
            this.panelRight_RMA.Controls.Add(this.chartFunction_RMA);
            this.panelRight_RMA.Controls.Add(this.splitterResult_RMA);
            this.panelRight_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_RMA.Location = new System.Drawing.Point(188, 78);
            this.panelRight_RMA.Name = "panelRight_RMA";
            this.panelRight_RMA.Size = new System.Drawing.Size(612, 372);
            this.panelRight_RMA.TabIndex = 0;
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBoxTask_RMA);
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(399, 69);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие:";
            // 
            // textBoxTask_RMA
            // 
            this.textBoxTask_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_RMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_RMA.Location = new System.Drawing.Point(6, 13);
            this.textBoxTask_RMA.Multiline = true;
            this.textBoxTask_RMA.Name = "textBoxTask_RMA";
            this.textBoxTask_RMA.Size = new System.Drawing.Size(322, 50);
            this.textBoxTask_RMA.TabIndex = 0;
            this.textBoxTask_RMA.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView все число бо" +
    "льшие 5 и построить диаграмму по этим значениям.";
            // 
            // buttonHelp_RMA
            // 
            this.buttonHelp_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RMA.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_RMA.Location = new System.Drawing.Point(690, 12);
            this.buttonHelp_RMA.Name = "buttonHelp_RMA";
            this.buttonHelp_RMA.Size = new System.Drawing.Size(98, 60);
            this.buttonHelp_RMA.TabIndex = 1;
            this.buttonHelp_RMA.Text = "Справка";
            this.buttonHelp_RMA.UseVisualStyleBackColor = false;
            this.buttonHelp_RMA.Click += new System.EventHandler(this.buttonHelp_RMA_Click);
            // 
            // buttonOpenFile_RMA
            // 
            this.buttonOpenFile_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_RMA.BackColor = System.Drawing.Color.Cyan;
            this.buttonOpenFile_RMA.Location = new System.Drawing.Point(586, 12);
            this.buttonOpenFile_RMA.Name = "buttonOpenFile_RMA";
            this.buttonOpenFile_RMA.Size = new System.Drawing.Size(98, 60);
            this.buttonOpenFile_RMA.TabIndex = 1;
            this.buttonOpenFile_RMA.Text = "Открыть файл";
            this.buttonOpenFile_RMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_RMA.Click += new System.EventHandler(this.buttonOpenFile_RMA_Click);
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDone_RMA.Location = new System.Drawing.Point(482, 12);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(98, 60);
            this.buttonDone_RMA.TabIndex = 1;
            this.buttonDone_RMA.Text = "Выполнить";
            this.buttonDone_RMA.UseVisualStyleBackColor = false;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click);
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.dataGridViewResult_RMA);
            this.groupBoxResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(188, 372);
            this.groupBoxResult_RMA.TabIndex = 0;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод данных:";
            // 
            // splitterResult_RMA
            // 
            this.splitterResult_RMA.Location = new System.Drawing.Point(0, 0);
            this.splitterResult_RMA.Name = "splitterResult_RMA";
            this.splitterResult_RMA.Size = new System.Drawing.Size(3, 372);
            this.splitterResult_RMA.TabIndex = 0;
            this.splitterResult_RMA.TabStop = false;
            // 
            // chartFunction_RMA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_RMA.ChartAreas.Add(chartArea1);
            this.chartFunction_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_RMA.Legends.Add(legend1);
            this.chartFunction_RMA.Location = new System.Drawing.Point(3, 0);
            this.chartFunction_RMA.Name = "chartFunction_RMA";
            this.chartFunction_RMA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_RMA.Series.Add(series1);
            this.chartFunction_RMA.Size = new System.Drawing.Size(609, 372);
            this.chartFunction_RMA.TabIndex = 1;
            this.chartFunction_RMA.Text = "chart1";
            // 
            // dataGridViewResult_RMA
            // 
            this.dataGridViewResult_RMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_RMA.ColumnHeadersVisible = false;
            this.dataGridViewResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_RMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_RMA.Name = "dataGridViewResult_RMA";
            this.dataGridViewResult_RMA.RowHeadersVisible = false;
            this.dataGridViewResult_RMA.Size = new System.Drawing.Size(182, 353);
            this.dataGridViewResult_RMA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_RMA);
            this.Controls.Add(this.panelLeft_RMA);
            this.Controls.Add(this.panelTop_RMA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Рагимова М. А.";
            this.panelTop_RMA.ResumeLayout(false);
            this.panelLeft_RMA.ResumeLayout(false);
            this.panelRight_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.groupBoxResult_RMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.Button buttonOpenFile_RMA;
        private System.Windows.Forms.Button buttonHelp_RMA;
        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBoxTask_RMA;
        private System.Windows.Forms.Panel panelLeft_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.Panel panelRight_RMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RMA;
        private System.Windows.Forms.Splitter splitterResult_RMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_RMA;
    }
}

