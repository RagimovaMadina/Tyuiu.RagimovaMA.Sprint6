
namespace Tyuiu.RagimovaMA.Sprint6.Task6.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_RMA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOk_RMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_RMA
            // 
            this.textBoxInfo_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_RMA.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxInfo_RMA.Location = new System.Drawing.Point(201, 0);
            this.textBoxInfo_RMA.Multiline = true;
            this.textBoxInfo_RMA.Name = "textBoxInfo_RMA";
            this.textBoxInfo_RMA.Size = new System.Drawing.Size(207, 222);
            this.textBoxInfo_RMA.TabIndex = 0;
            this.textBoxInfo_RMA.Text = resources.GetString("textBoxInfo_RMA.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 222);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOk_RMA
            // 
            this.buttonOk_RMA.Location = new System.Drawing.Point(277, 189);
            this.buttonOk_RMA.Name = "buttonOk_RMA";
            this.buttonOk_RMA.Size = new System.Drawing.Size(119, 21);
            this.buttonOk_RMA.TabIndex = 2;
            this.buttonOk_RMA.Text = "ОК";
            this.buttonOk_RMA.UseVisualStyleBackColor = true;
            this.buttonOk_RMA.Click += new System.EventHandler(this.buttonOk_RMA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 222);
            this.Controls.Add(this.buttonOk_RMA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxInfo_RMA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_RMA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOk_RMA;
    }
}