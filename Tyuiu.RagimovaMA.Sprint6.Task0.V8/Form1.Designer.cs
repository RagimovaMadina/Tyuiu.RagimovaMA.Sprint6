
namespace Tyuiu.RagimovaMA.Sprint6.Task0.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RMA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_RMA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_RMA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_RMA = new System.Windows.Forms.TextBox();
            this.labelVarX_RMA = new System.Windows.Forms.Label();
            this.textBoxResult_RMA = new System.Windows.Forms.TextBox();
            this.labelResult_RMA = new System.Windows.Forms.Label();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.buttonInfo_RMA = new System.Windows.Forms.Button();
            this.groupBoxTask_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RMA)).BeginInit();
            this.groupBoxData_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.pictureBoxFormula_RMA);
            this.groupBoxTask_RMA.Controls.Add(this.textBoxTask_RMA);
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(514, 142);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие";
            // 
            // textBoxTask_RMA
            // 
            this.textBoxTask_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_RMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_RMA.Location = new System.Drawing.Point(16, 19);
            this.textBoxTask_RMA.Multiline = true;
            this.textBoxTask_RMA.Name = "textBoxTask_RMA";
            this.textBoxTask_RMA.Size = new System.Drawing.Size(336, 86);
            this.textBoxTask_RMA.TabIndex = 0;
            this.textBoxTask_RMA.Text = "Дан выражение. Вычислить его значение при x = 3, результат вывести в TestBox. Ору" +
    "глить до трёх знаков после запятой.";
            this.textBoxTask_RMA.TextChanged += new System.EventHandler(this.textBoxTask_RMA_TextChanged);
            // 
            // pictureBoxFormula_RMA
            // 
            this.pictureBoxFormula_RMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_RMA.Image")));
            this.pictureBoxFormula_RMA.Location = new System.Drawing.Point(373, 19);
            this.pictureBoxFormula_RMA.Name = "pictureBoxFormula_RMA";
            this.pictureBoxFormula_RMA.Size = new System.Drawing.Size(123, 70);
            this.pictureBoxFormula_RMA.TabIndex = 1;
            this.pictureBoxFormula_RMA.TabStop = false;
            // 
            // groupBoxData_RMA
            // 
            this.groupBoxData_RMA.Controls.Add(this.labelVarX_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxVarX_RMA);
            this.groupBoxData_RMA.Location = new System.Drawing.Point(12, 160);
            this.groupBoxData_RMA.Name = "groupBoxData_RMA";
            this.groupBoxData_RMA.Size = new System.Drawing.Size(268, 105);
            this.groupBoxData_RMA.TabIndex = 1;
            this.groupBoxData_RMA.TabStop = false;
            this.groupBoxData_RMA.Text = "Ввод данных";
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.labelResult_RMA);
            this.groupBoxResult_RMA.Controls.Add(this.textBoxResult_RMA);
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(286, 160);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(240, 105);
            this.groupBoxResult_RMA.TabIndex = 1;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод данных";
            // 
            // textBoxVarX_RMA
            // 
            this.textBoxVarX_RMA.Location = new System.Drawing.Point(16, 55);
            this.textBoxVarX_RMA.Name = "textBoxVarX_RMA";
            this.textBoxVarX_RMA.Size = new System.Drawing.Size(112, 20);
            this.textBoxVarX_RMA.TabIndex = 0;
            this.textBoxVarX_RMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_RMA_KeyPress);
            // 
            // labelVarX_RMA
            // 
            this.labelVarX_RMA.AutoSize = true;
            this.labelVarX_RMA.Location = new System.Drawing.Point(13, 39);
            this.labelVarX_RMA.Name = "labelVarX_RMA";
            this.labelVarX_RMA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_RMA.TabIndex = 1;
            this.labelVarX_RMA.Text = "Переменная X:";
            // 
            // textBoxResult_RMA
            // 
            this.textBoxResult_RMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult_RMA.Location = new System.Drawing.Point(21, 50);
            this.textBoxResult_RMA.Name = "textBoxResult_RMA";
            this.textBoxResult_RMA.ReadOnly = true;
            this.textBoxResult_RMA.Size = new System.Drawing.Size(112, 20);
            this.textBoxResult_RMA.TabIndex = 0;
            // 
            // labelResult_RMA
            // 
            this.labelResult_RMA.AutoSize = true;
            this.labelResult_RMA.Location = new System.Drawing.Point(18, 34);
            this.labelResult_RMA.Name = "labelResult_RMA";
            this.labelResult_RMA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_RMA.TabIndex = 1;
            this.labelResult_RMA.Text = "Результат:";
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.Location = new System.Drawing.Point(423, 271);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(103, 23);
            this.buttonDone_RMA.TabIndex = 2;
            this.buttonDone_RMA.Text = "Выполнить";
            this.buttonDone_RMA.UseVisualStyleBackColor = true;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click);
            // 
            // buttonInfo_RMA
            // 
            this.buttonInfo_RMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_RMA.Location = new System.Drawing.Point(394, 271);
            this.buttonInfo_RMA.Name = "buttonInfo_RMA";
            this.buttonInfo_RMA.Size = new System.Drawing.Size(22, 22);
            this.buttonInfo_RMA.TabIndex = 2;
            this.buttonInfo_RMA.Text = "?";
            this.buttonInfo_RMA.UseVisualStyleBackColor = true;
            this.buttonInfo_RMA.Click += new System.EventHandler(this.buttonInfo_RMA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 302);
            this.Controls.Add(this.buttonInfo_RMA);
            this.Controls.Add(this.buttonDone_RMA);
            this.Controls.Add(this.groupBoxResult_RMA);
            this.Controls.Add(this.groupBoxData_RMA);
            this.Controls.Add(this.groupBoxTask_RMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 8 | Рагимова М. А.";
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RMA)).EndInit();
            this.groupBoxData_RMA.ResumeLayout(false);
            this.groupBoxData_RMA.PerformLayout();
            this.groupBoxResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBoxTask_RMA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_RMA;
        private System.Windows.Forms.GroupBox groupBoxData_RMA;
        private System.Windows.Forms.Label labelVarX_RMA;
        private System.Windows.Forms.TextBox textBoxVarX_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.Label labelResult_RMA;
        private System.Windows.Forms.TextBox textBoxResult_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.Button buttonInfo_RMA;
    }
}

