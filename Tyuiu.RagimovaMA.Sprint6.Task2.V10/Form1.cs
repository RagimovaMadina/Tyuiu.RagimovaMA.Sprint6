using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RagimovaMA.Sprint6.Task2.V10.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataService ds = new DataService();

        private void buttonResult_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_RMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_RMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_RMA.Titles.Add("График функции");
                this.chartFunction_RMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_RMA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_RMA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_RMA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_RMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы СМАРТб-23-1 Рагимова Мадина Абдулакимовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_RMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_RMA.BackColor = Color.Blue;
        }

        private void buttonResult_RMA_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_RMA.BackColor = Color.Green;
        }

        private void buttonResult_RMA_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_RMA.BackColor = Color.Red;
        }
    }
}
