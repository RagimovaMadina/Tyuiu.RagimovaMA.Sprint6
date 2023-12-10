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
using Tyuiu.RagimovaMA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.RagimovaMA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_RMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_RMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int col;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string filedata = File.ReadAllText(filePath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            col = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, col];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < col; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RMA.ShowDialog();
            openFilePath = openFileDialogTask_RMA.FileName;

            int[,] arrayValues = new int[rows, col];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPut_RMA.ColumnCount = col;
            dataGridViewInPut_RMA.RowCount = rows;
            dataGridViewResult_RMA.ColumnCount = col;
            dataGridViewResult_RMA.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewInPut_RMA.Columns[i].Width = 25;
                dataGridViewResult_RMA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewInPut_RMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_RMA.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, col];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridViewResult_RMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_RMA.Enabled = true;
        }

        private void buttonSave_RMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_RMA.FileName = "OutPutFileTask7V25.csv";
            saveFileDialogMatrix_RMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_RMA.ShowDialog();

            string path = saveFileDialogMatrix_RMA.FileName;
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewResult_RMA.RowCount;
            int col = dataGridViewResult_RMA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        str = str + dataGridViewResult_RMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_RMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_RMA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_RMA.ColumnCount = 50;
            dataGridViewResult_RMA.ColumnCount = 50;

            dataGridViewResult_RMA.RowCount = 50;
            dataGridViewInPut_RMA.RowCount = 50;
            panelLeft_RMA.Width = this.Width / 2;
            panelRight_RMA.Width = this.Width / 2;
        }

        private void buttonOpen_RMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_RMA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_RMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_RMA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_RMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_RMA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_RMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_RMA.ToolTipTitle = "Справка";
        }

    }
}

