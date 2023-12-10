
namespace Tyuiu.RagimovaMA.Sprint6.Task7.V25
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_RMA = new System.Windows.Forms.Panel();
            this.buttonInfo_RMA = new System.Windows.Forms.Button();
            this.buttonSave_RMA = new System.Windows.Forms.Button();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.buttonOpen_RMA = new System.Windows.Forms.Button();
            this.panelTask_RMA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLeft_RMA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_RMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_RMA = new System.Windows.Forms.DataGridView();
            this.panelRight_RMA = new System.Windows.Forms.Panel();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewResult_RMA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_RMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_RMA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_RMA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_RMA.SuspendLayout();
            this.panelTask_RMA.SuspendLayout();
            this.groupBoxTask_RMA.SuspendLayout();
            this.panelLeft_RMA.SuspendLayout();
            this.groupBoxInPut_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_RMA)).BeginInit();
            this.panelRight_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_RMA
            // 
            this.panelTop_RMA.Controls.Add(this.buttonInfo_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonSave_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonDone_RMA);
            this.panelTop_RMA.Controls.Add(this.buttonOpen_RMA);
            this.panelTop_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_RMA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_RMA.Name = "panelTop_RMA";
            this.panelTop_RMA.Size = new System.Drawing.Size(800, 52);
            this.panelTop_RMA.TabIndex = 0;
            // 
            // buttonInfo_RMA
            // 
            this.buttonInfo_RMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_RMA.Image")));
            this.buttonInfo_RMA.Location = new System.Drawing.Point(734, 6);
            this.buttonInfo_RMA.Name = "buttonInfo_RMA";
            this.buttonInfo_RMA.Size = new System.Drawing.Size(54, 40);
            this.buttonInfo_RMA.TabIndex = 0;
            this.toolTipButton_RMA.SetToolTip(this.buttonInfo_RMA, "Информация о разработчике");
            this.buttonInfo_RMA.UseVisualStyleBackColor = true;
            this.buttonInfo_RMA.Click += new System.EventHandler(this.buttonInfo_RMA_Click);
            this.buttonInfo_RMA.MouseEnter += new System.EventHandler(this.buttonInfo_RMA_MouseEnter);
            // 
            // buttonSave_RMA
            // 
            this.buttonSave_RMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_RMA.Image")));
            this.buttonSave_RMA.Location = new System.Drawing.Point(136, 6);
            this.buttonSave_RMA.Name = "buttonSave_RMA";
            this.buttonSave_RMA.Size = new System.Drawing.Size(54, 40);
            this.buttonSave_RMA.TabIndex = 0;
            this.toolTipButton_RMA.SetToolTip(this.buttonSave_RMA, "Сохранить результат ");
            this.buttonSave_RMA.UseVisualStyleBackColor = true;
            this.buttonSave_RMA.Click += new System.EventHandler(this.buttonSave_RMA_Click);
            this.buttonSave_RMA.MouseEnter += new System.EventHandler(this.buttonSave_RMA_MouseEnter);
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_RMA.Image")));
            this.buttonDone_RMA.Location = new System.Drawing.Point(76, 6);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(54, 40);
            this.buttonDone_RMA.TabIndex = 0;
            this.toolTipButton_RMA.SetToolTip(this.buttonDone_RMA, "Выполнить вычисления");
            this.buttonDone_RMA.UseVisualStyleBackColor = true;
            this.buttonDone_RMA.Click += new System.EventHandler(this.button2_Click);
            this.buttonDone_RMA.MouseEnter += new System.EventHandler(this.buttonDone_RMA_MouseEnter);
            // 
            // buttonOpen_RMA
            // 
            this.buttonOpen_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOpen_RMA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_RMA.Image")));
            this.buttonOpen_RMA.Location = new System.Drawing.Point(16, 6);
            this.buttonOpen_RMA.Name = "buttonOpen_RMA";
            this.buttonOpen_RMA.Size = new System.Drawing.Size(54, 40);
            this.buttonOpen_RMA.TabIndex = 0;
            this.toolTipButton_RMA.SetToolTip(this.buttonOpen_RMA, "Выбрать файл и открыть его");
            this.buttonOpen_RMA.UseVisualStyleBackColor = false;
            this.buttonOpen_RMA.Click += new System.EventHandler(this.button1_Click);
            this.buttonOpen_RMA.MouseEnter += new System.EventHandler(this.buttonOpen_RMA_MouseEnter);
            // 
            // panelTask_RMA
            // 
            this.panelTask_RMA.Controls.Add(this.groupBoxTask_RMA);
            this.panelTask_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_RMA.Location = new System.Drawing.Point(0, 52);
            this.panelTask_RMA.Name = "panelTask_RMA";
            this.panelTask_RMA.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_RMA.Size = new System.Drawing.Size(800, 83);
            this.panelTask_RMA.TabIndex = 0;
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBox1);
            this.groupBoxTask_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(790, 73);
            this.groupBoxTask_RMA.TabIndex = 0;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(5, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeft_RMA
            // 
            this.panelLeft_RMA.Controls.Add(this.groupBoxInPut_RMA);
            this.panelLeft_RMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_RMA.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_RMA.Name = "panelLeft_RMA";
            this.panelLeft_RMA.Size = new System.Drawing.Size(401, 315);
            this.panelLeft_RMA.TabIndex = 0;
            // 
            // groupBoxInPut_RMA
            // 
            this.groupBoxInPut_RMA.Controls.Add(this.dataGridViewInPut_RMA);
            this.groupBoxInPut_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_RMA.Name = "groupBoxInPut_RMA";
            this.groupBoxInPut_RMA.Size = new System.Drawing.Size(401, 315);
            this.groupBoxInPut_RMA.TabIndex = 0;
            this.groupBoxInPut_RMA.TabStop = false;
            this.groupBoxInPut_RMA.Text = "Ввод:";
            // 
            // dataGridViewInPut_RMA
            // 
            this.dataGridViewInPut_RMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_RMA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_RMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_RMA.Name = "dataGridViewInPut_RMA";
            this.dataGridViewInPut_RMA.RowHeadersVisible = false;
            this.dataGridViewInPut_RMA.RowHeadersWidth = 10;
            this.dataGridViewInPut_RMA.Size = new System.Drawing.Size(395, 296);
            this.dataGridViewInPut_RMA.TabIndex = 0;
            // 
            // panelRight_RMA
            // 
            this.panelRight_RMA.Controls.Add(this.groupBoxResult_RMA);
            this.panelRight_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_RMA.Location = new System.Drawing.Point(401, 135);
            this.panelRight_RMA.Name = "panelRight_RMA";
            this.panelRight_RMA.Size = new System.Drawing.Size(399, 315);
            this.panelRight_RMA.TabIndex = 0;
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.splitter1);
            this.groupBoxResult_RMA.Controls.Add(this.dataGridViewResult_RMA);
            this.groupBoxResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(399, 315);
            this.groupBoxResult_RMA.TabIndex = 0;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 296);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewResult_RMA
            // 
            this.dataGridViewResult_RMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_RMA.ColumnHeadersVisible = false;
            this.dataGridViewResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_RMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_RMA.Name = "dataGridViewResult_RMA";
            this.dataGridViewResult_RMA.RowHeadersVisible = false;
            this.dataGridViewResult_RMA.Size = new System.Drawing.Size(393, 296);
            this.dataGridViewResult_RMA.TabIndex = 0;
            // 
            // openFileDialogTask_RMA
            // 
            this.openFileDialogTask_RMA.FileName = "openFileDialog1";
            // 
            // toolTipButton_RMA
            // 
            this.toolTipButton_RMA.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_RMA);
            this.Controls.Add(this.panelLeft_RMA);
            this.Controls.Add(this.panelTask_RMA);
            this.Controls.Add(this.panelTop_RMA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 25 | Рагимова М. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_RMA.ResumeLayout(false);
            this.panelTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.panelLeft_RMA.ResumeLayout(false);
            this.groupBoxInPut_RMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_RMA)).EndInit();
            this.panelRight_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_RMA;
        private System.Windows.Forms.Button buttonSave_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.Button buttonOpen_RMA;
        private System.Windows.Forms.Panel panelTask_RMA;
        private System.Windows.Forms.Panel panelLeft_RMA;
        private System.Windows.Forms.Panel panelRight_RMA;
        private System.Windows.Forms.Button buttonInfo_RMA;
        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_RMA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewResult_RMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_RMA;
        private System.Windows.Forms.ToolTip toolTipButton_RMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_RMA;
    }
}

