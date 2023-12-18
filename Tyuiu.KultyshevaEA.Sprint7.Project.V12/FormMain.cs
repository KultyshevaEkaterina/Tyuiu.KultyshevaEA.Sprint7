﻿using System;
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
    }
}
