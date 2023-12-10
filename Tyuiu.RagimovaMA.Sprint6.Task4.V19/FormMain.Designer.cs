
namespace Tyuiu.RagimovaMA.Sprint6.Task4.V19
{
    partial class FormMain_RMA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_RMA = new System.Windows.Forms.Panel();
            this.panelLeft_RMA = new System.Windows.Forms.Panel();
            this.panelRight_RMA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RMA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_RMA = new System.Windows.Forms.TextBox();
            this.labelStartStep_RMA = new System.Windows.Forms.Label();
            this.textBoxStopStep_RMA = new System.Windows.Forms.TextBox();
            this.labelStopStep_RMA = new System.Windows.Forms.Label();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.buttonSave_RMA = new System.Windows.Forms.Button();
            this.buttonHelp_RMA = new System.Windows.Forms.Button();
            this.splitterPanel_RMA = new System.Windows.Forms.Splitter();
            this.groupBoxOutPutData_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_RMA = new System.Windows.Forms.TextBox();
            this.chartFunction_RMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_RMA.SuspendLayout();
            this.panelLeft_RMA.SuspendLayout();
            this.panelRight_RMA.SuspendLayout();
            this.groupBoxTask_RMA.SuspendLayout();
            this.groupBoxInPutData_RMA.SuspendLayout();
            this.groupBoxOutPutData_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_RMA
            // 
            this.panelTop_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTop_RMA.Controls.Add(this.buttonHelp_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonSave_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonDone_RMA);
            this.panelTop_RMA.Controls.Add(this.groupBoxInPutData_RMA);
            this.panelTop_RMA.Controls.Add(this.groupBoxTask_RMA);
            this.panelTop_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_RMA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_RMA.Name = "panelTop_RMA";
            this.panelTop_RMA.Size = new System.Drawing.Size(963, 84);
            this.panelTop_RMA.TabIndex = 0;
            // 
            // panelLeft_RMA
            // 
            this.panelLeft_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft_RMA.Controls.Add(this.groupBoxOutPutData_RMA);
            this.panelLeft_RMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_RMA.Location = new System.Drawing.Point(0, 84);
            this.panelLeft_RMA.Name = "panelLeft_RMA";
            this.panelLeft_RMA.Size = new System.Drawing.Size(301, 327);
            this.panelLeft_RMA.TabIndex = 0;
            // 
            // panelRight_RMA
            // 
            this.panelRight_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRight_RMA.Controls.Add(this.chartFunction_RMA);
            this.panelRight_RMA.Controls.Add(this.splitterPanel_RMA);
            this.panelRight_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_RMA.Location = new System.Drawing.Point(301, 84);
            this.panelRight_RMA.Name = "panelRight_RMA";
            this.panelRight_RMA.Size = new System.Drawing.Size(662, 327);
            this.panelRight_RMA.TabIndex = 0;
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBoxTask_RMA);
            this.groupBoxTask_RMA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(404, 66);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие:";
            // 
            // textBoxTask_RMA
            // 
            this.textBoxTask_RMA.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxTask_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_RMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_RMA.Multiline = true;
            this.textBoxTask_RMA.Name = "textBoxTask_RMA";
            this.textBoxTask_RMA.Size = new System.Drawing.Size(398, 47);
            this.textBoxTask_RMA.TabIndex = 0;
            this.textBoxTask_RMA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.  Результат вывести в te" +
    "xtBoxю Построить график функции и сохранить файл OutPutFileTask4V19.txt по нажат" +
    "ию кнопки.";
            // 
            // groupBoxInPutData_RMA
            // 
            this.groupBoxInPutData_RMA.Controls.Add(this.labelStopStep_RMA);
            this.groupBoxInPutData_RMA.Controls.Add(this.labelStartStep_RMA);
            this.groupBoxInPutData_RMA.Controls.Add(this.textBoxStopStep_RMA);
            this.groupBoxInPutData_RMA.Controls.Add(this.textBoxStartStep_RMA);
            this.groupBoxInPutData_RMA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxInPutData_RMA.Location = new System.Drawing.Point(422, 12);
            this.groupBoxInPutData_RMA.Name = "groupBoxInPutData_RMA";
            this.groupBoxInPutData_RMA.Size = new System.Drawing.Size(275, 66);
            this.groupBoxInPutData_RMA.TabIndex = 1;
            this.groupBoxInPutData_RMA.TabStop = false;
            this.groupBoxInPutData_RMA.Text = "Ввод данных:";
            // 
            // textBoxStartStep_RMA
            // 
            this.textBoxStartStep_RMA.Location = new System.Drawing.Point(6, 31);
            this.textBoxStartStep_RMA.Name = "textBoxStartStep_RMA";
            this.textBoxStartStep_RMA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStartStep_RMA.TabIndex = 0;
            // 
            // labelStartStep_RMA
            // 
            this.labelStartStep_RMA.AutoSize = true;
            this.labelStartStep_RMA.Location = new System.Drawing.Point(3, 19);
            this.labelStartStep_RMA.Name = "labelStartStep_RMA";
            this.labelStartStep_RMA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_RMA.TabIndex = 1;
            this.labelStartStep_RMA.Text = "Старт шага:";
            // 
            // textBoxStopStep_RMA
            // 
            this.textBoxStopStep_RMA.Location = new System.Drawing.Point(139, 31);
            this.textBoxStopStep_RMA.Name = "textBoxStopStep_RMA";
            this.textBoxStopStep_RMA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStopStep_RMA.TabIndex = 0;
            // 
            // labelStopStep_RMA
            // 
            this.labelStopStep_RMA.AutoSize = true;
            this.labelStopStep_RMA.Location = new System.Drawing.Point(136, 19);
            this.labelStopStep_RMA.Name = "labelStopStep_RMA";
            this.labelStopStep_RMA.Size = new System.Drawing.Size(67, 13);
            this.labelStopStep_RMA.TabIndex = 1;
            this.labelStopStep_RMA.Text = "Старт шага:";
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_RMA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDone_RMA.Location = new System.Drawing.Point(712, 12);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(76, 66);
            this.buttonDone_RMA.TabIndex = 2;
            this.buttonDone_RMA.Text = "Выполнить";
            this.buttonDone_RMA.UseVisualStyleBackColor = false;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click);
            // 
            // buttonSave_RMA
            // 
            this.buttonSave_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_RMA.Location = new System.Drawing.Point(794, 12);
            this.buttonSave_RMA.Name = "buttonSave_RMA";
            this.buttonSave_RMA.Size = new System.Drawing.Size(76, 66);
            this.buttonSave_RMA.TabIndex = 2;
            this.buttonSave_RMA.Text = "Сохранить ";
            this.buttonSave_RMA.UseVisualStyleBackColor = true;
            this.buttonSave_RMA.Click += new System.EventHandler(this.buttonSave_RMA_Click);
            // 
            // buttonHelp_RMA
            // 
            this.buttonHelp_RMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RMA.Location = new System.Drawing.Point(876, 12);
            this.buttonHelp_RMA.Name = "buttonHelp_RMA";
            this.buttonHelp_RMA.Size = new System.Drawing.Size(76, 66);
            this.buttonHelp_RMA.TabIndex = 2;
            this.buttonHelp_RMA.Text = "Справка";
            this.buttonHelp_RMA.UseVisualStyleBackColor = true;
            this.buttonHelp_RMA.Click += new System.EventHandler(this.buttonHelp_RMA_Click);
            // 
            // splitterPanel_RMA
            // 
            this.splitterPanel_RMA.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_RMA.Name = "splitterPanel_RMA";
            this.splitterPanel_RMA.Size = new System.Drawing.Size(3, 327);
            this.splitterPanel_RMA.TabIndex = 0;
            this.splitterPanel_RMA.TabStop = false;
            // 
            // groupBoxOutPutData_RMA
            // 
            this.groupBoxOutPutData_RMA.Controls.Add(this.textBoxResult_RMA);
            this.groupBoxOutPutData_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_RMA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxOutPutData_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_RMA.Name = "groupBoxOutPutData_RMA";
            this.groupBoxOutPutData_RMA.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxOutPutData_RMA.Size = new System.Drawing.Size(301, 327);
            this.groupBoxOutPutData_RMA.TabIndex = 0;
            this.groupBoxOutPutData_RMA.TabStop = false;
            this.groupBoxOutPutData_RMA.Text = "Вывод:";
            // 
            // textBoxResult_RMA
            // 
            this.textBoxResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_RMA.Location = new System.Drawing.Point(8, 21);
            this.textBoxResult_RMA.Multiline = true;
            this.textBoxResult_RMA.Name = "textBoxResult_RMA";
            this.textBoxResult_RMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_RMA.Size = new System.Drawing.Size(285, 298);
            this.textBoxResult_RMA.TabIndex = 0;
            // 
            // chartFunction_RMA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_RMA.ChartAreas.Add(chartArea4);
            this.chartFunction_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartFunction_RMA.Legends.Add(legend4);
            this.chartFunction_RMA.Location = new System.Drawing.Point(3, 0);
            this.chartFunction_RMA.Name = "chartFunction_RMA";
            this.chartFunction_RMA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_RMA.Series.Add(series4);
            this.chartFunction_RMA.Size = new System.Drawing.Size(659, 327);
            this.chartFunction_RMA.TabIndex = 1;
            this.chartFunction_RMA.Tag = "";
            // 
            // FormMain_RMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 411);
            this.Controls.Add(this.panelRight_RMA);
            this.Controls.Add(this.panelLeft_RMA);
            this.Controls.Add(this.panelTop_RMA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain_RMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Рагимова М. А.";
            this.panelTop_RMA.ResumeLayout(false);
            this.panelLeft_RMA.ResumeLayout(false);
            this.panelRight_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.groupBoxInPutData_RMA.ResumeLayout(false);
            this.groupBoxInPutData_RMA.PerformLayout();
            this.groupBoxOutPutData_RMA.ResumeLayout(false);
            this.groupBoxOutPutData_RMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_RMA;
        private System.Windows.Forms.Button buttonHelp_RMA;
        private System.Windows.Forms.Button buttonSave_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_RMA;
        private System.Windows.Forms.Label labelStopStep_RMA;
        private System.Windows.Forms.Label labelStartStep_RMA;
        private System.Windows.Forms.TextBox textBoxStopStep_RMA;
        private System.Windows.Forms.TextBox textBoxStartStep_RMA;
        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBoxTask_RMA;
        private System.Windows.Forms.Panel panelLeft_RMA;
        private System.Windows.Forms.Panel panelRight_RMA;
        private System.Windows.Forms.Splitter splitterPanel_RMA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_RMA;
        private System.Windows.Forms.TextBox textBoxResult_RMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RMA;
    }
}

