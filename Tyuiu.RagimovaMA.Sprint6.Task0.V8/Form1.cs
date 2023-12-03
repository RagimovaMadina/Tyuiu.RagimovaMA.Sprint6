using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RagimovaMA.Sprint6.Task0.V8.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxTask_RMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_RMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_RMA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_RMA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_RMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы СМАРТб-23-1 Рагимова Мадина Абдулакимовна ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxVarX_RMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
