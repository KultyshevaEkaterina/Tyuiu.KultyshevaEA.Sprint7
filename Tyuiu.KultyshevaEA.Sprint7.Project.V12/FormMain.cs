using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {

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
            string searchText = textBoxSearch_KEA.Text;

            // Проходим по каждой строке в DataGridView и скрываем те строки, в которых не найден искомый текст
            foreach (DataGridViewRow row in dataGridViewTable_KEA.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем пустую строку для ввода новых данных

                bool rowVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        rowVisible = true;
                        break;
                    }
                }

                row.Visible = rowVisible;
            }
        }

        private void dataGridViewTable_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
