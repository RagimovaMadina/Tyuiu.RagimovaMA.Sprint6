using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.RagimovaMA.Sprint6.Task6.V28.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string openFilePath;

        private void buttonOpenFile_RMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RMA.ShowDialog();
            openFilePath = openFileDialogTask_RMA.FileName;
            textBoxInPut_RMA.Text = File.ReadAllText(openFilePath);
            groupBoxResult_RMA.Text = groupBoxResult_RMA.Text + " " + openFileDialogTask_RMA.FileName;
            buttonDone_RMA.Enabled = true;
        }

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHelp_RMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_RMA_Click_1(object sender, EventArgs e)
        {
            textBoxResult_RMA.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
