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
            comboBoxCity_KEA.Items.Add("Москва");
            comboBoxCity_KEA.Items.Add("Уфа");
            comboBoxCity_KEA.Items.Add("Екатеринбург");
            comboBoxCity_KEA.Items.Add("Зеленоград");
            // Добавьте все доступные города в ComboBox

            // Привязка события выбора элемента
            comboBoxCity_KEA.SelectedIndexChanged += ComboBoxCity_SelectedIndexChanged;
        }

            // Метод-обработчик события выбора элемента
        private void ComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
                // Получите выбранный город
                string selectedCity = comboBoxCity_KEA.SelectedItem.ToString();

                // Произведите фильтрацию данных в таблице на основе выбранного города
                // Например, если у вас есть DataGridView с именем dataGridView, можете использовать фильтрацию так:
                ((DataTable)dataGridViewFirms_KEA.DataSource).DefaultView.RowFilter = $"Город = '{selectedCity}'";
        }
        
    }
}
