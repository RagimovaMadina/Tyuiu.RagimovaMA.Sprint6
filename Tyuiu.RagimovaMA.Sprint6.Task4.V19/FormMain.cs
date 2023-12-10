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
using Tyuiu.RagimovaMA.Sprint6.Task4.V19.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task4.V19
{
    public partial class FormMain_RMA : Form
    {
        public FormMain_RMA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_RMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_RMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_RMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_RMA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_RMA.Text = "";
                chartFunction_RMA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_RMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_RMA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonHelp_RMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы СМАРТб-23-1 Рагимова Мадина Абдулакимовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V19.txt";
                File.WriteAllText(path, textBoxResult_RMA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
