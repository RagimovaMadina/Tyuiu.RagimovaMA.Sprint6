
namespace Tyuiu.RagimovaMA.Sprint6.Task3.V11
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
            this.groupBoxData_RMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_RMA = new System.Windows.Forms.DataGridView();
            this.textBoxData_RMA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.labelResult_RMA = new System.Windows.Forms.Label();
            this.textBoxResult_RMA = new System.Windows.Forms.TextBox();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.buttonHelp_RMA = new System.Windows.Forms.Button();
            this.groupBoxData_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_RMA)).BeginInit();
            this.groupBoxResult_RMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData_RMA
            // 
            this.groupBoxData_RMA.Controls.Add(this.dataGridViewMatrix_RMA);
            this.groupBoxData_RMA.Controls.Add(this.textBoxData_RMA);
            this.groupBoxData_RMA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData_RMA.Name = "groupBoxData_RMA";
            this.groupBoxData_RMA.Size = new System.Drawing.Size(547, 272);
            this.groupBoxData_RMA.TabIndex = 0;
            this.groupBoxData_RMA.TabStop = false;
            this.groupBoxData_RMA.Text = "Условие";
            // 
            // dataGridViewMatrix_RMA
            // 
            this.dataGridViewMatrix_RMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_RMA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_RMA.Location = new System.Drawing.Point(296, 21);
            this.dataGridViewMatrix_RMA.Name = "dataGridViewMatrix_RMA";
            this.dataGridViewMatrix_RMA.RowHeadersVisible = false;
            this.dataGridViewMatrix_RMA.Size = new System.Drawing.Size(229, 229);
            this.dataGridViewMatrix_RMA.TabIndex = 1;
            // 
            // textBoxData_RMA
            // 
            this.textBoxData_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxData_RMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_RMA.Location = new System.Drawing.Point(15, 21);
            this.textBoxData_RMA.Multiline = true;
            this.textBoxData_RMA.Name = "textBoxData_RMA";
            this.textBoxData_RMA.Size = new System.Drawing.Size(257, 183);
            this.textBoxData_RMA.TabIndex = 0;
            this.textBoxData_RMA.Text = resources.GetString("textBoxData_RMA.Text");
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.labelResult_RMA);
            this.groupBoxResult_RMA.Controls.Add(this.textBoxResult_RMA);
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(565, 12);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(203, 85);
            this.groupBoxResult_RMA.TabIndex = 1;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод данных";
            // 
            // labelResult_RMA
            // 
            this.labelResult_RMA.AutoSize = true;
            this.labelResult_RMA.Location = new System.Drawing.Point(3, 26);
            this.labelResult_RMA.Name = "labelResult_RMA";
            this.labelResult_RMA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_RMA.TabIndex = 1;
            this.labelResult_RMA.Text = "Результат:";
            // 
            // textBoxResult_RMA
            // 
            this.textBoxResult_RMA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_RMA.Location = new System.Drawing.Point(6, 42);
            this.textBoxResult_RMA.Name = "textBoxResult_RMA";
            this.textBoxResult_RMA.ReadOnly = true;
            this.textBoxResult_RMA.Size = new System.Drawing.Size(177, 20);
            this.textBoxResult_RMA.TabIndex = 0;
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.Location = new System.Drawing.Point(665, 258);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(103, 26);
            this.buttonDone_RMA.TabIndex = 2;
            this.buttonDone_RMA.Text = "Выполнить";
            this.buttonDone_RMA.UseVisualStyleBackColor = true;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click);
            // 
            // buttonHelp_RMA
            // 
            this.buttonHelp_RMA.Location = new System.Drawing.Point(621, 258);
            this.buttonHelp_RMA.Name = "buttonHelp_RMA";
            this.buttonHelp_RMA.Size = new System.Drawing.Size(26, 26);
            this.buttonHelp_RMA.TabIndex = 2;
            this.buttonHelp_RMA.Text = "?";
            this.buttonHelp_RMA.UseVisualStyleBackColor = true;
            this.buttonHelp_RMA.Click += new System.EventHandler(this.buttonHelp_RMA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 296);
            this.Controls.Add(this.buttonHelp_RMA);
            this.Controls.Add(this.buttonDone_RMA);
            this.Controls.Add(this.groupBoxResult_RMA);
            this.Controls.Add(this.groupBoxData_RMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 |  Рагимова М. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxData_RMA.ResumeLayout(false);
            this.groupBoxData_RMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_RMA)).EndInit();
            this.groupBoxResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData_RMA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_RMA;
        private System.Windows.Forms.TextBox textBoxData_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.Label labelResult_RMA;
        private System.Windows.Forms.TextBox textBoxResult_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.Button buttonHelp_RMA;
    }
}

