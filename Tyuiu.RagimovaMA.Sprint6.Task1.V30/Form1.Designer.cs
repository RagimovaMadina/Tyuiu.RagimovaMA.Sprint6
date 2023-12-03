
namespace Tyuiu.RagimovaMA.Sprint6.Task1.V30
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
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.groupBoxData_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RMA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_RMA = new System.Windows.Forms.TextBox();
            this.labelStartStep_RMA = new System.Windows.Forms.Label();
            this.textBoxStopStep_RMA = new System.Windows.Forms.TextBox();
            this.labelStopStep_RMA = new System.Windows.Forms.Label();
            this.buttonInfo_RMA = new System.Windows.Forms.Button();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.textBoxResult_RMA = new System.Windows.Forms.TextBox();
            this.labelResult_RMA = new System.Windows.Forms.Label();
            this.groupBoxTask_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            this.groupBoxData_RMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBoxTask_RMA);
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(429, 264);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие";
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.labelResult_RMA);
            this.groupBoxResult_RMA.Controls.Add(this.textBoxResult_RMA);
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(447, 12);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(259, 328);
            this.groupBoxResult_RMA.TabIndex = 0;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод  данных";
            // 
            // groupBoxData_RMA
            // 
            this.groupBoxData_RMA.Controls.Add(this.labelStopStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.labelStartStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxStopStep_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxStartStep_RMA);
            this.groupBoxData_RMA.Location = new System.Drawing.Point(12, 282);
            this.groupBoxData_RMA.Name = "groupBoxData_RMA";
            this.groupBoxData_RMA.Size = new System.Drawing.Size(236, 58);
            this.groupBoxData_RMA.TabIndex = 1;
            this.groupBoxData_RMA.TabStop = false;
            this.groupBoxData_RMA.Text = "Ввод данных";
            // 
            // textBoxTask_RMA
            // 
            this.textBoxTask_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_RMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_RMA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_RMA.Multiline = true;
            this.textBoxTask_RMA.Name = "textBoxTask_RMA";
            this.textBoxTask_RMA.Size = new System.Drawing.Size(288, 131);
            this.textBoxTask_RMA.TabIndex = 0;
            this.textBoxTask_RMA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в виде таблицы.";
            // 
            // textBoxStartStep_RMA
            // 
            this.textBoxStartStep_RMA.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartStep_RMA.Name = "textBoxStartStep_RMA";
            this.textBoxStartStep_RMA.Size = new System.Drawing.Size(107, 20);
            this.textBoxStartStep_RMA.TabIndex = 0;
            // 
            // labelStartStep_RMA
            // 
            this.labelStartStep_RMA.AutoSize = true;
            this.labelStartStep_RMA.Location = new System.Drawing.Point(6, 16);
            this.labelStartStep_RMA.Name = "labelStartStep_RMA";
            this.labelStartStep_RMA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_RMA.TabIndex = 1;
            this.labelStartStep_RMA.Text = "Старт шага:";
            // 
            // textBoxStopStep_RMA
            // 
            this.textBoxStopStep_RMA.Location = new System.Drawing.Point(123, 32);
            this.textBoxStopStep_RMA.Name = "textBoxStopStep_RMA";
            this.textBoxStopStep_RMA.Size = new System.Drawing.Size(107, 20);
            this.textBoxStopStep_RMA.TabIndex = 0;
            // 
            // labelStopStep_RMA
            // 
            this.labelStopStep_RMA.AutoSize = true;
            this.labelStopStep_RMA.Location = new System.Drawing.Point(120, 16);
            this.labelStopStep_RMA.Name = "labelStopStep_RMA";
            this.labelStopStep_RMA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_RMA.TabIndex = 1;
            this.labelStopStep_RMA.Text = "Конец шага:";
            this.labelStopStep_RMA.Click += new System.EventHandler(this.labelEnd_RMA_Click);
            // 
            // buttonInfo_RMA
            // 
            this.buttonInfo_RMA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_RMA.Location = new System.Drawing.Point(254, 290);
            this.buttonInfo_RMA.Name = "buttonInfo_RMA";
            this.buttonInfo_RMA.Size = new System.Drawing.Size(74, 50);
            this.buttonInfo_RMA.TabIndex = 2;
            this.buttonInfo_RMA.Text = "Справка";
            this.buttonInfo_RMA.UseVisualStyleBackColor = false;
            this.buttonInfo_RMA.Click += new System.EventHandler(this.buttonInfo_RMA_Click);
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_RMA.Location = new System.Drawing.Point(334, 290);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(107, 50);
            this.buttonDone_RMA.TabIndex = 2;
            this.buttonDone_RMA.Text = "Выполнить";
            this.buttonDone_RMA.UseVisualStyleBackColor = false;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click);
            // 
            // textBoxResult_RMA
            // 
            this.textBoxResult_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_RMA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_RMA.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult_RMA.Multiline = true;
            this.textBoxResult_RMA.Name = "textBoxResult_RMA";
            this.textBoxResult_RMA.ReadOnly = true;
            this.textBoxResult_RMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_RMA.Size = new System.Drawing.Size(247, 285);
            this.textBoxResult_RMA.TabIndex = 0;
            // 
            // labelResult_RMA
            // 
            this.labelResult_RMA.AutoSize = true;
            this.labelResult_RMA.Location = new System.Drawing.Point(3, 16);
            this.labelResult_RMA.Name = "labelResult_RMA";
            this.labelResult_RMA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_RMA.TabIndex = 1;
            this.labelResult_RMA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.buttonDone_RMA);
            this.Controls.Add(this.buttonInfo_RMA);
            this.Controls.Add(this.groupBoxData_RMA);
            this.Controls.Add(this.groupBoxResult_RMA);
            this.Controls.Add(this.groupBoxTask_RMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 |  Таск 1 |  Вариант 30 | Рагимова М. А.";
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.groupBoxResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.PerformLayout();
            this.groupBoxData_RMA.ResumeLayout(false);
            this.groupBoxData_RMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBoxTask_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.GroupBox groupBoxData_RMA;
        private System.Windows.Forms.Label labelStopStep_RMA;
        private System.Windows.Forms.Label labelStartStep_RMA;
        private System.Windows.Forms.TextBox textBoxStopStep_RMA;
        private System.Windows.Forms.TextBox textBoxStartStep_RMA;
        private System.Windows.Forms.Button buttonInfo_RMA;
        private System.Windows.Forms.Label labelResult_RMA;
        private System.Windows.Forms.TextBox textBoxResult_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
    }
}

