using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KultyshevaEA.Sprint7.Project.V12.Lib;

using System.IO;

namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    public partial class FormFirms : Form
    {
        public FormFirms()
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

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogFirms_KEA.ShowDialog();
                openFilePath = openFileDialogFirms_KEA.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewFirms_KEA.RowCount = rows + 1;
                dataGridViewFirms_KEA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewFirms_KEA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewFirms_KEA.AutoResizeColumns();
                dataGridViewFirms_KEA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReturn_KEA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewFirms_KEA.Rows)
            {
                row.Visible = true;
            }
        }

        private void comboBoxFiltrs_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }


        private void comboBoxName_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxName_KEA.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(selectedCity))
            {
                foreach (DataGridViewRow row in dataGridViewFirms_KEA.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["Nametov"].Value != null && row.Cells["Nametov"].Value.ToString() == selectedCity)
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

        private void comboBoxCity_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxCity_KEA.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(selectedCity))
            {
                foreach (DataGridViewRow row in dataGridViewFirms_KEA.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["City"].Value != null && row.Cells["City"].Value.ToString() == selectedCity)
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

        private void comboBoxPrice_KEA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxPrice_KEA.SelectedItem.ToString();
            if (selectedValue == "По возрастанию")
            {
                dataGridViewFirms_KEA.Sort(dataGridViewFirms_KEA.Columns[5], ListSortDirection.Ascending);
            }
            else if (selectedValue == "По убыванию")
            {
                dataGridViewFirms_KEA.Sort(dataGridViewFirms_KEA.Columns[5], ListSortDirection.Descending);
            }
        }
    }
}
