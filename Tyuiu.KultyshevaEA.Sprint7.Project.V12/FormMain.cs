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

using Tyuiu.KultyshevaEA.Sprint7.Project.V12.Lib;

namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGuide fg = new FormGuide();
            fg.Show();
        }

        private void buttonAbout_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFirms_KEA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFirms fm = new FormFirms();
            fm.Show();
        }

        private void buttonDiagram_KEA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChart fm = new FormChart();
            fm.Show();
        }

        private void textBoxSearch_KEA_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_KEA.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewTable_KEA.Rows)
            {
                if (row.Cells["Firma"].Value != null && row.Cells["Processor"].Value != null && row.Cells["Takt"].Value != null)
                {
                    string column1Text = row.Cells["Firma"].Value.ToString().ToLower();
                    string column2Text = row.Cells["Processor"].Value.ToString().ToLower();
                    string column3Text = row.Cells["Takt"].Value.ToString().ToLower();


                    if (column1Text.Contains(searchText) || column2Text.Contains(searchText) || column3Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dataGridViewTable_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMain_KEA.ShowDialog();
                openFilePath = openFileDialogMain_KEA.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewTable_KEA.RowCount = rows + 1;
                dataGridViewTable_KEA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewTable_KEA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewTable_KEA.AutoResizeColumns();
                dataGridViewTable_KEA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_KEA.FileName = ".csv";
                saveFileDialogMain_KEA.InitialDirectory = @":C";
                if (saveFileDialogMain_KEA.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogMain_KEA.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewTable_KEA.RowCount;
                    int columns = dataGridViewTable_KEA.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewTable_KEA.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTable_KEA.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_KEA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_KEA.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridViewTable_KEA.CurrentCell.RowIndex;
                    dataGridViewTable_KEA.Rows.Remove(dataGridViewTable_KEA.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFiltr_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxFiltr_KEA.SelectedItem.ToString();
            if (selectedValue == "По возрастанию")
            {
                dataGridViewTable_KEA.Sort(dataGridViewTable_KEA.Columns[2], ListSortDirection.Ascending);
            }
            else if (selectedValue == "По убыванию")
            {
                dataGridViewTable_KEA.Sort(dataGridViewTable_KEA.Columns[2], ListSortDirection.Descending);
            }
        }

        private void comboBoxSorted_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxSorted_KEA.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(selectedCity))
            {
                foreach (DataGridViewRow row in dataGridViewTable_KEA.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["Processor"].Value != null && row.Cells["Processor"].Value.ToString() == selectedCity)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
