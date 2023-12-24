using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Tyuiu.KultyshevaEA.Sprint7.Project.V12.Lib;

namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonBack_KEA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }

        private void textBoxMin_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = dataGridViewChart_KEA.Rows.Cast<DataGridViewRow>().Count(row => row.Visible && !row.IsNewRow); // рассчитывает количество видимых строк кроме последней
                int[] valuesAv = new int[visibleRowCount];

                for (int i = 0; i < dataGridViewChart_KEA.Rows.Count - 1; i++)
                {
                    int valuesAverage;
                    if (dataGridViewChart_KEA.Rows[i].Cells[5].Value != null && int.TryParse(dataGridViewChart_KEA.Rows[i].Cells[5].Value.ToString(), out valuesAverage))
                    {
                        valuesAv[i] = valuesAverage;
                    }
                }

                double average = ds.CalculateAverage(valuesAv);
                textBoxMid_KEA.Text = average.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                int visibleRowCount = dataGridViewChart_KEA.Rows.Cast<DataGridViewRow>().Count(row => row.Visible && !row.IsNewRow); // рассчитывает количество видимых строк кроме последней
                int[] valuesAv = new int[visibleRowCount];

                for (int i = 0; i < dataGridViewChart_KEA.Rows.Count - 1; i++)
                {
                    int valuesAverage;
                    if (dataGridViewChart_KEA.Rows[i].Cells[5].Value != null && int.TryParse(dataGridViewChart_KEA.Rows[i].Cells[5].Value.ToString(), out valuesAverage))
                    {
                        valuesAv[i] = valuesAverage;
                    }
                }

                double average = ds.CalculateMin(valuesAv);
                textBoxMin_KEA.Text = average.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                int visibleRowCount = dataGridViewChart_KEA.Rows.Cast<DataGridViewRow>().Count(row => row.Visible && !row.IsNewRow); // рассчитывает количество видимых строк кроме последней
                int[] valuesAv = new int[visibleRowCount];

                for (int i = 0; i < dataGridViewChart_KEA.Rows.Count - 1; i++)
                {
                    int valuesAverage;
                    if (dataGridViewChart_KEA.Rows[i].Cells[5].Value != null && int.TryParse(dataGridViewChart_KEA.Rows[i].Cells[5].Value.ToString(), out valuesAverage))
                    {
                        valuesAv[i] = valuesAverage;
                    }
                }

                double average = ds.CalculateMax(valuesAv);
                textBoxMax_KEA.Text = average.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //try
            //{
            //    chartAVM_KEA.Series.Clear();

            //    // новая серия данных для диаграммы
            //    chartAVM_KEA.Series.Add("DataSeries");
            //    chartAVM_KEA.Series["DataSeries"].ChartType = SeriesChartType.Pie; // круговая диаграмма

            //    foreach (DataGridViewRow row in dataGridViewChart_KEA.Rows)
            //    {
            //        if (row.Cells[4].Value != null && row.Cells[5].Value != null)
            //        {
            //            if (row.Visible)
            //            {
            //                string labelOne = row.Cells[4].Value.ToString();
            //                int valueFour = Convert.ToInt32(row.Cells[5].Value);

            //                // добавление данных в серию для диаграммы
            //                chartAVM_KEA.Series["DataSeries"].Points.AddXY(labelOne, valueFour);
            //            }
            //        }
            //    }





            //    chartAVM_KEA.Update();
            //}
            //catch
            //{
            //    MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            // Создание словаря для хранения суммарных значений
            Dictionary<string, int> dataMap = new Dictionary<string, int>();

            // Группировка данных по меткам и суммирование значений
            foreach (DataGridViewRow row in dataGridViewChart_KEA.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[5].Value != null && row.Visible)
                {
                    string label = row.Cells[4].Value.ToString();
                    int value = Convert.ToInt32(row.Cells[5].Value);

                    if (dataMap.ContainsKey(label))
                    {
                        // Если метка уже существует в словаре, добавить значение к существующему
                        dataMap[label] += value;
                    }
                    else
                    {
                        // Иначе создать новую запись в словаре
                        dataMap.Add(label, value);
                    }
                }
            }

            chartAVM_KEA.Series.Clear();
            chartAVM_KEA.Series.Add("DataSeries");
            chartAVM_KEA.Series["DataSeries"].ChartType = SeriesChartType.Pie;

            // Добавление суммарных значений в серию для диаграммы
            foreach (var entry in dataMap)
            {
                chartAVM_KEA.Series["DataSeries"].Points.AddXY(entry.Key, entry.Value);
            }

            chartAVM_KEA.Update();

        }

        private void panelDown_KEA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogChart_KEA.ShowDialog();
                openFilePath = openFileDialogChart_KEA.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewChart_KEA.RowCount = rows + 1;
                dataGridViewChart_KEA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewChart_KEA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewChart_KEA.AutoResizeColumns();
                dataGridViewChart_KEA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReturn_KEA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewChart_KEA.Rows)
            {
                row.Visible = true;
            }
        }

        private void labelName_KEA_Click(object sender, EventArgs e)
        {

        }

  
    }
}
