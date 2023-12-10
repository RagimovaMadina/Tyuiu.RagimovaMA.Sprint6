using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RagimovaMA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService service1 = new DataService();
        private static readonly string path = @"C:\DataSprint6\InPutFileTask5V22.txt";

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {

            dataGridViewResult_RMA.Rows.Clear();
            chartFunction_RMA.Series[0].Points.Clear();

            dataGridViewResult_RMA.ColumnCount = 2;
            dataGridViewResult_RMA.Columns[0].Width = 20;
            dataGridViewResult_RMA.Columns[1].Width = 50;

            chartFunction_RMA.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction_RMA.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = service1.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewResult_RMA.Rows.Add(i + 1, serviceArray[i]);
                chartFunction_RMA.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }

        private void buttonOpenFile_RMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_RMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы СМАРТб-23-1 Рагимова Мадина Абдулакимовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
