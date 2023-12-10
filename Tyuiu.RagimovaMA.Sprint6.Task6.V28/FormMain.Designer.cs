
namespace Tyuiu.RagimovaMA.Sprint6.Task6.V28
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
            this.panelButtons_RMA = new System.Windows.Forms.Panel();
            this.buttonHelp_RMA = new System.Windows.Forms.Button();
            this.buttonDone_RMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_RMA = new System.Windows.Forms.Button();
            this.splitterTop_RMA = new System.Windows.Forms.Splitter();
            this.paneTask_RMA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RMA = new System.Windows.Forms.TextBox();
            this.splitterLeft_RMA = new System.Windows.Forms.Splitter();
            this.panelInPut_RMA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_RMA = new System.Windows.Forms.TextBox();
            this.splitterRight_RMA = new System.Windows.Forms.Splitter();
            this.panelResult_RMA = new System.Windows.Forms.Panel();
            this.groupBoxResult_RMA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_RMA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_RMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_RMA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_RMA.SuspendLayout();
            this.paneTask_RMA.SuspendLayout();
            this.groupBoxTask_RMA.SuspendLayout();
            this.panelInPut_RMA.SuspendLayout();
            this.groupBoxInPut_RMA.SuspendLayout();
            this.panelResult_RMA.SuspendLayout();
            this.groupBoxResult_RMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_RMA
            // 
            this.panelButtons_RMA.Controls.Add(this.buttonHelp_RMA);
            this.panelButtons_RMA.Controls.Add(this.buttonDone_RMA);
            this.panelButtons_RMA.Controls.Add(this.buttonOpenFile_RMA);
            this.panelButtons_RMA.Controls.Add(this.splitterTop_RMA);
            this.panelButtons_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_RMA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_RMA.Name = "panelButtons_RMA";
            this.panelButtons_RMA.Size = new System.Drawing.Size(800, 57);
            this.panelButtons_RMA.TabIndex = 0;
            // 
            // buttonHelp_RMA
            // 
            this.buttonHelp_RMA.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_RMA.Location = new System.Drawing.Point(726, 3);
            this.buttonHelp_RMA.Name = "buttonHelp_RMA";
            this.buttonHelp_RMA.Size = new System.Drawing.Size(71, 48);
            this.buttonHelp_RMA.TabIndex = 1;
            this.buttonHelp_RMA.Text = "Справка";
            this.buttonHelp_RMA.UseVisualStyleBackColor = false;
            this.buttonHelp_RMA.Click += new System.EventHandler(this.buttonHelp_RMA_Click);
            // 
            // buttonDone_RMA
            // 
            this.buttonDone_RMA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_RMA.Location = new System.Drawing.Point(80, 3);
            this.buttonDone_RMA.Name = "buttonDone_RMA";
            this.buttonDone_RMA.Size = new System.Drawing.Size(71, 48);
            this.buttonDone_RMA.TabIndex = 1;
            this.buttonDone_RMA.Text = "Выполнить";
            this.toolTip_RMA.SetToolTip(this.buttonDone_RMA, "Производит поиск в файле нужное слово и конкатенирует строки в которых находится " +
        "это слово.");
            this.buttonDone_RMA.UseVisualStyleBackColor = false;
            this.buttonDone_RMA.Click += new System.EventHandler(this.buttonDone_RMA_Click_1);
            // 
            // buttonOpenFile_RMA
            // 
            this.buttonOpenFile_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOpenFile_RMA.CausesValidation = false;
            this.buttonOpenFile_RMA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_RMA.Name = "buttonOpenFile_RMA";
            this.buttonOpenFile_RMA.Size = new System.Drawing.Size(71, 48);
            this.buttonOpenFile_RMA.TabIndex = 1;
            this.buttonOpenFile_RMA.Text = "Открыть файл";
            this.toolTip_RMA.SetToolTip(this.buttonOpenFile_RMA, "Открыть файл. Выберите нужный файл для обработки.");
            this.buttonOpenFile_RMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_RMA.Click += new System.EventHandler(this.buttonOpenFile_RMA_Click);
            // 
            // splitterTop_RMA
            // 
            this.splitterTop_RMA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterTop_RMA.Location = new System.Drawing.Point(0, 54);
            this.splitterTop_RMA.Name = "splitterTop_RMA";
            this.splitterTop_RMA.Size = new System.Drawing.Size(800, 3);
            this.splitterTop_RMA.TabIndex = 0;
            this.splitterTop_RMA.TabStop = false;
            // 
            // paneTask_RMA
            // 
            this.paneTask_RMA.Controls.Add(this.groupBoxTask_RMA);
            this.paneTask_RMA.Controls.Add(this.splitterLeft_RMA);
            this.paneTask_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneTask_RMA.Location = new System.Drawing.Point(0, 57);
            this.paneTask_RMA.Name = "paneTask_RMA";
            this.paneTask_RMA.Size = new System.Drawing.Size(800, 74);
            this.paneTask_RMA.TabIndex = 0;
            // 
            // groupBoxTask_RMA
            // 
            this.groupBoxTask_RMA.Controls.Add(this.textBoxTask_RMA);
            this.groupBoxTask_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_RMA.Name = "groupBoxTask_RMA";
            this.groupBoxTask_RMA.Size = new System.Drawing.Size(800, 71);
            this.groupBoxTask_RMA.TabIndex = 1;
            this.groupBoxTask_RMA.TabStop = false;
            this.groupBoxTask_RMA.Text = "Условие:";
            // 
            // textBoxTask_RMA
            // 
            this.textBoxTask_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_RMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_RMA.Multiline = true;
            this.textBoxTask_RMA.Name = "textBoxTask_RMA";
            this.textBoxTask_RMA.Size = new System.Drawing.Size(794, 52);
            this.textBoxTask_RMA.TabIndex = 0;
            this.textBoxTask_RMA.Text = resources.GetString("textBoxTask_RMA.Text");
            // 
            // splitterLeft_RMA
            // 
            this.splitterLeft_RMA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterLeft_RMA.Location = new System.Drawing.Point(0, 71);
            this.splitterLeft_RMA.Name = "splitterLeft_RMA";
            this.splitterLeft_RMA.Size = new System.Drawing.Size(800, 3);
            this.splitterLeft_RMA.TabIndex = 0;
            this.splitterLeft_RMA.TabStop = false;
            // 
            // panelInPut_RMA
            // 
            this.panelInPut_RMA.Controls.Add(this.groupBoxInPut_RMA);
            this.panelInPut_RMA.Controls.Add(this.splitterRight_RMA);
            this.panelInPut_RMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_RMA.Location = new System.Drawing.Point(0, 131);
            this.panelInPut_RMA.Name = "panelInPut_RMA";
            this.panelInPut_RMA.Size = new System.Drawing.Size(399, 319);
            this.panelInPut_RMA.TabIndex = 0;
            // 
            // groupBoxInPut_RMA
            // 
            this.groupBoxInPut_RMA.Controls.Add(this.textBoxInPut_RMA);
            this.groupBoxInPut_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_RMA.Name = "groupBoxInPut_RMA";
            this.groupBoxInPut_RMA.Size = new System.Drawing.Size(396, 319);
            this.groupBoxInPut_RMA.TabIndex = 1;
            this.groupBoxInPut_RMA.TabStop = false;
            this.groupBoxInPut_RMA.Text = "Ввод:";
            // 
            // textBoxInPut_RMA
            // 
            this.textBoxInPut_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_RMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPut_RMA.Multiline = true;
            this.textBoxInPut_RMA.Name = "textBoxInPut_RMA";
            this.textBoxInPut_RMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_RMA.Size = new System.Drawing.Size(390, 300);
            this.textBoxInPut_RMA.TabIndex = 0;
            // 
            // splitterRight_RMA
            // 
            this.splitterRight_RMA.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight_RMA.Location = new System.Drawing.Point(396, 0);
            this.splitterRight_RMA.Name = "splitterRight_RMA";
            this.splitterRight_RMA.Size = new System.Drawing.Size(3, 319);
            this.splitterRight_RMA.TabIndex = 0;
            this.splitterRight_RMA.TabStop = false;
            // 
            // panelResult_RMA
            // 
            this.panelResult_RMA.Controls.Add(this.groupBoxResult_RMA);
            this.panelResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_RMA.Location = new System.Drawing.Point(399, 131);
            this.panelResult_RMA.Name = "panelResult_RMA";
            this.panelResult_RMA.Size = new System.Drawing.Size(401, 319);
            this.panelResult_RMA.TabIndex = 0;
            // 
            // groupBoxResult_RMA
            // 
            this.groupBoxResult_RMA.Controls.Add(this.textBoxResult_RMA);
            this.groupBoxResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_RMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_RMA.Name = "groupBoxResult_RMA";
            this.groupBoxResult_RMA.Size = new System.Drawing.Size(401, 319);
            this.groupBoxResult_RMA.TabIndex = 0;
            this.groupBoxResult_RMA.TabStop = false;
            this.groupBoxResult_RMA.Text = "Вывод:";
            // 
            // textBoxResult_RMA
            // 
            this.textBoxResult_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_RMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_RMA.Multiline = true;
            this.textBoxResult_RMA.Name = "textBoxResult_RMA";
            this.textBoxResult_RMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_RMA.Size = new System.Drawing.Size(395, 300);
            this.textBoxResult_RMA.TabIndex = 0;
            // 
            // openFileDialogTask_RMA
            // 
            this.openFileDialogTask_RMA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResult_RMA);
            this.Controls.Add(this.panelInPut_RMA);
            this.Controls.Add(this.paneTask_RMA);
            this.Controls.Add(this.panelButtons_RMA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 28 | Рагимова М. А.";
            this.panelButtons_RMA.ResumeLayout(false);
            this.paneTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.ResumeLayout(false);
            this.groupBoxTask_RMA.PerformLayout();
            this.panelInPut_RMA.ResumeLayout(false);
            this.groupBoxInPut_RMA.ResumeLayout(false);
            this.groupBoxInPut_RMA.PerformLayout();
            this.panelResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.ResumeLayout(false);
            this.groupBoxResult_RMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_RMA;
        private System.Windows.Forms.Button buttonHelp_RMA;
        private System.Windows.Forms.Button buttonDone_RMA;
        private System.Windows.Forms.Button buttonOpenFile_RMA;
        private System.Windows.Forms.Splitter splitterTop_RMA;
        private System.Windows.Forms.Panel paneTask_RMA;
        private System.Windows.Forms.GroupBox groupBoxTask_RMA;
        private System.Windows.Forms.TextBox textBoxTask_RMA;
        private System.Windows.Forms.Splitter splitterLeft_RMA;
        private System.Windows.Forms.Panel panelInPut_RMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_RMA;
        private System.Windows.Forms.TextBox textBoxInPut_RMA;
        private System.Windows.Forms.Splitter splitterRight_RMA;
        private System.Windows.Forms.Panel panelResult_RMA;
        private System.Windows.Forms.GroupBox groupBoxResult_RMA;
        private System.Windows.Forms.TextBox textBoxResult_RMA;
        private System.Windows.Forms.ToolTip toolTip_RMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_RMA;
    }
}

