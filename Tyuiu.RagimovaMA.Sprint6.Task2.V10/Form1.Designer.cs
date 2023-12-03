
namespace Tyuiu.RagimovaMA.Sprint6.Task2.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.groupBoxData_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_RMA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_RMA = new System.Windows.Forms.TextBox();
            this.labelStartStep_RMA = new System.Windows.Forms.Label();
            this.labelStopStep_RMA = new System.Windows.Forms.Label();
            this.buttonResult_RMA = new System.Windows.Forms.Button();
            this.buttonInfo_RMA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_RMA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_RMA = new System.Windows.Forms.Label();
            this.chartFunction_RMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            this.groupBoxData_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBox1);
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(431, 212);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие";
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.chartFunction_RMA);
            this.groupBoxResult_RMA.Controls.Add(this.labelResult_RMA);
            this.groupBoxResult_RMA.Controls.Add(this.dataGridViewFunction_RMA);
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(449, 12);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(509, 285);
            this.groupBoxResult_RMA.TabIndex = 0;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод данных";
            // 
            // groupBoxData_RMA
            // 
            this.groupBoxData_RMA.Controls.Add(this.labelStopStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.labelStartStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxStopStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxStartStep_RMA);
            this.groupBoxData_RMA.Location = new System.Drawing.Point(12, 230);
            this.groupBoxData_RMA.Name = "groupBoxData_RMA";
            this.groupBoxData_RMA.Size = new System.Drawing.Size(224, 67);
            this.groupBoxData_RMA.TabIndex = 1;
            this.groupBoxData_RMA.TabStop = false;
            this.groupBoxData_RMA.Text = "Ввод данных";
            // 
            // textBoxStartStep_RMA
            // 
            this.textBoxStartStep_RMA.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartStep_RMA.Name = "textBoxStartStep_RMA";
            this.textBoxStartStep_RMA.Size = new System.Drawing.Size(99, 20);
            this.textBoxStartStep_RMA.TabIndex = 0;
            // 
            // textBoxStopStep_RMA
            // 
            this.textBoxStopStep_RMA.Location = new System.Drawing.Point(119, 32);
            this.textBoxStopStep_RMA.Name = "textBoxStopStep_RMA";
            this.textBoxStopStep_RMA.Size = new System.Drawing.Size(99, 20);
            this.textBoxStopStep_RMA.TabIndex = 0;
            // 
            // labelStartStep_RMA
            // 
            this.labelStartStep_RMA.AutoSize = true;
            this.labelStartStep_RMA.Location = new System.Drawing.Point(6, 19);
            this.labelStartStep_RMA.Name = "labelStartStep_RMA";
            this.labelStartStep_RMA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_RMA.TabIndex = 1;
            this.labelStartStep_RMA.Text = "Старт шага:";
            // 
            // labelStopStep_RMA
            // 
            this.labelStopStep_RMA.AutoSize = true;
            this.labelStopStep_RMA.Location = new System.Drawing.Point(116, 19);
            this.labelStopStep_RMA.Name = "labelStopStep_RMA";
            this.labelStopStep_RMA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_RMA.TabIndex = 1;
            this.labelStopStep_RMA.Text = "Конец шага:";
            // 
            // buttonResult_RMA
            // 
            this.buttonResult_RMA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult_RMA.Location = new System.Drawing.Point(316, 230);
            this.buttonResult_RMA.Name = "buttonResult_RMA";
            this.buttonResult_RMA.Size = new System.Drawing.Size(127, 67);
            this.buttonResult_RMA.TabIndex = 2;
            this.buttonResult_RMA.Text = "Выполнить";
            this.buttonResult_RMA.UseVisualStyleBackColor = false;
            this.buttonResult_RMA.Click += new System.EventHandler(this.buttonResult_RMA_Click);
            this.buttonResult_RMA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_RMA_MouseDown);
            this.buttonResult_RMA.MouseEnter += new System.EventHandler(this.buttonResult_RMA_MouseEnter);
            this.buttonResult_RMA.MouseLeave += new System.EventHandler(this.buttonResult_RMA_MouseLeave);
            // 
            // buttonInfo_RMA
            // 
            this.buttonInfo_RMA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInfo_RMA.Location = new System.Drawing.Point(242, 230);
            this.buttonInfo_RMA.Name = "buttonInfo_RMA";
            this.buttonInfo_RMA.Size = new System.Drawing.Size(67, 67);
            this.buttonInfo_RMA.TabIndex = 2;
            this.buttonInfo_RMA.Text = "Справка";
            this.buttonInfo_RMA.UseVisualStyleBackColor = false;
            this.buttonInfo_RMA.Click += new System.EventHandler(this.buttonInfo_RMA_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(19, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 74);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и" +
    " построить график функции.";
            // 
            // dataGridViewFunction_RMA
            // 
            this.dataGridViewFunction_RMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_RMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_RMA.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewFunction_RMA.Name = "dataGridViewFunction_RMA";
            this.dataGridViewFunction_RMA.RowHeadersVisible = false;
            this.dataGridViewFunction_RMA.Size = new System.Drawing.Size(128, 244);
            this.dataGridViewFunction_RMA.TabIndex = 0;
            this.dataGridViewFunction_RMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // labelResult_RMA
            // 
            this.labelResult_RMA.AutoSize = true;
            this.labelResult_RMA.Location = new System.Drawing.Point(3, 19);
            this.labelResult_RMA.Name = "labelResult_RMA";
            this.labelResult_RMA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_RMA.TabIndex = 1;
            this.labelResult_RMA.Text = "Результат:";
            // 
            // chartFunction_RMA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_RMA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_RMA.Legends.Add(legend5);
            this.chartFunction_RMA.Location = new System.Drawing.Point(140, 35);
            this.chartFunction_RMA.Name = "chartFunction_RMA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_RMA.Series.Add(series5);
            this.chartFunction_RMA.Size = new System.Drawing.Size(363, 244);
            this.chartFunction_RMA.TabIndex = 2;
            this.chartFunction_RMA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 309);
            this.Controls.Add(this.buttonInfo_RMA);
            this.Controls.Add(this.buttonResult_RMA);
            this.Controls.Add(this.groupBoxData_RMA);
            this.Controls.Add(this.groupBoxResult_RMA);
            this.Controls.Add(this.groupBoxTask_RMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 |  Рагимова М. А.";
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.groupBoxResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.PerformLayout();
            this.groupBoxData_RMA.ResumeLayout(false);
            this.groupBoxData_RMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.GroupBox groupBoxData_RMA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewFunction_RMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelStopStep_RMA;
        private System.Windows.Forms.Label labelStartStep_RMA;
        private System.Windows.Forms.TextBox textBoxStopStep_RMA;
        private System.Windows.Forms.TextBox textBoxStartStep_RMA;
        private System.Windows.Forms.Button buttonResult_RMA;
        private System.Windows.Forms.Button buttonInfo_RMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RMA;
        private System.Windows.Forms.Label labelResult_RMA;
    }
}

