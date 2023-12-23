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

namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

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
            DataService ds = new DataService();
            try
            {
                

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
