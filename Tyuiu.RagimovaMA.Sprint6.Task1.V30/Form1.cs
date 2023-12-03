using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RagimovaMA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void labelEnd_RMA_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_RMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-23-1 Рагимова Мадина Абдулакимовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_RMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_RMA.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_RMA.Text = "";
                textBoxResult_RMA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_RMA.AppendText("|    X      +     f(x)  |" + Environment.NewLine);
                textBoxResult_RMA.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1, 5:f2}    | ", startStep, valueArray[i]);
                    textBoxResult_RMA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_RMA.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
