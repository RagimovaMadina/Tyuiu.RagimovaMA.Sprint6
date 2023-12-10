
namespace Tyuiu.RagimovaMA.Sprint6.Task7.V25
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
            this.pictureBoxInfo_RMA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_RMA = new System.Windows.Forms.TextBox();
            this.buttonOk_RMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_RMA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo_RMA
            // 
            this.pictureBoxInfo_RMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxInfo_RMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_RMA.Image")));
            this.pictureBoxInfo_RMA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfo_RMA.Name = "pictureBoxInfo_RMA";
            this.pictureBoxInfo_RMA.Size = new System.Drawing.Size(205, 236);
            this.pictureBoxInfo_RMA.TabIndex = 0;
            this.pictureBoxInfo_RMA.TabStop = false;
            // 
            // textBoxInfo_RMA
            // 
            this.textBoxInfo_RMA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo_RMA.Location = new System.Drawing.Point(205, 0);
            this.textBoxInfo_RMA.Multiline = true;
            this.textBoxInfo_RMA.Name = "textBoxInfo_RMA";
            this.textBoxInfo_RMA.Size = new System.Drawing.Size(208, 236);
            this.textBoxInfo_RMA.TabIndex = 1;
            this.textBoxInfo_RMA.Text = resources.GetString("textBoxInfo_RMA.Text");
            // 
            // buttonOk_RMA
            // 
            this.buttonOk_RMA.Location = new System.Drawing.Point(298, 199);
            this.buttonOk_RMA.Name = "buttonOk_RMA";
            this.buttonOk_RMA.Size = new System.Drawing.Size(92, 25);
            this.buttonOk_RMA.TabIndex = 2;
            this.buttonOk_RMA.Text = "OK";
            this.buttonOk_RMA.UseVisualStyleBackColor = true;
            this.buttonOk_RMA.Click += new System.EventHandler(this.buttonOk_RMA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 236);
            this.Controls.Add(this.buttonOk_RMA);
            this.Controls.Add(this.textBoxInfo_RMA);
            this.Controls.Add(this.pictureBoxInfo_RMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_RMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_RMA;
        private System.Windows.Forms.TextBox textBoxInfo_RMA;
        private System.Windows.Forms.Button buttonOk_RMA;
    }
}