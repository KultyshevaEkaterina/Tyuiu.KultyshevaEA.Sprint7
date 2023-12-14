
namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelName_KEA = new System.Windows.Forms.Panel();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonAbout_KEA = new System.Windows.Forms.Button();
            this.textBoxSearch_KEA = new System.Windows.Forms.TextBox();
            this.labelSearch_KEA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSorted_KEA = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltr_KEA = new System.Windows.Forms.ComboBox();
            this.panelName_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName_KEA
            // 
            this.panelName_KEA.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelName_KEA.Controls.Add(this.buttonAbout_KEA);
            this.panelName_KEA.Controls.Add(this.buttonHelp_KEA);
            this.panelName_KEA.Controls.Add(this.labelName_KEA);
            this.panelName_KEA.Location = new System.Drawing.Point(0, 0);
            this.panelName_KEA.Name = "panelName_KEA";
            this.panelName_KEA.Size = new System.Drawing.Size(1114, 117);
            this.panelName_KEA.TabIndex = 0;
            // 
            // labelName_KEA
            // 
            this.labelName_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KEA.ForeColor = System.Drawing.Color.Black;
            this.labelName_KEA.Location = new System.Drawing.Point(194, 9);
            this.labelName_KEA.Name = "labelName_KEA";
            this.labelName_KEA.Size = new System.Drawing.Size(653, 90);
            this.labelName_KEA.TabIndex = 0;
            this.labelName_KEA.Text = "ПЕРСОНАЛЬНЫЕ ЭВМ";
            this.labelName_KEA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KEA.Image")));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(977, 9);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(55, 50);
            this.buttonHelp_KEA.TabIndex = 1;
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // buttonAbout_KEA
            // 
            this.buttonAbout_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_KEA.Image")));
            this.buttonAbout_KEA.Location = new System.Drawing.Point(1038, 9);
            this.buttonAbout_KEA.Name = "buttonAbout_KEA";
            this.buttonAbout_KEA.Size = new System.Drawing.Size(55, 50);
            this.buttonAbout_KEA.TabIndex = 2;
            this.buttonAbout_KEA.UseVisualStyleBackColor = true;
            this.buttonAbout_KEA.Click += new System.EventHandler(this.buttonAbout_KEA_Click);
            // 
            // textBoxSearch_KEA
            // 
            this.textBoxSearch_KEA.Location = new System.Drawing.Point(805, 174);
            this.textBoxSearch_KEA.Multiline = true;
            this.textBoxSearch_KEA.Name = "textBoxSearch_KEA";
            this.textBoxSearch_KEA.Size = new System.Drawing.Size(288, 43);
            this.textBoxSearch_KEA.TabIndex = 3;
            // 
            // labelSearch_KEA
            // 
            this.labelSearch_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_KEA.Location = new System.Drawing.Point(800, 148);
            this.labelSearch_KEA.Name = "labelSearch_KEA";
            this.labelSearch_KEA.Size = new System.Drawing.Size(100, 23);
            this.labelSearch_KEA.TabIndex = 4;
            this.labelSearch_KEA.Text = "Поиск:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 360);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBoxSorted_KEA
            // 
            this.comboBoxSorted_KEA.FormattingEnabled = true;
            this.comboBoxSorted_KEA.Location = new System.Drawing.Point(377, 196);
            this.comboBoxSorted_KEA.Name = "comboBoxSorted_KEA";
            this.comboBoxSorted_KEA.Size = new System.Drawing.Size(229, 21);
            this.comboBoxSorted_KEA.TabIndex = 6;
            // 
            // comboBoxFiltr_KEA
            // 
            this.comboBoxFiltr_KEA.FormattingEnabled = true;
            this.comboBoxFiltr_KEA.Location = new System.Drawing.Point(62, 196);
            this.comboBoxFiltr_KEA.Name = "comboBoxFiltr_KEA";
            this.comboBoxFiltr_KEA.Size = new System.Drawing.Size(260, 21);
            this.comboBoxFiltr_KEA.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1115, 626);
            this.Controls.Add(this.comboBoxFiltr_KEA);
            this.Controls.Add(this.comboBoxSorted_KEA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSearch_KEA);
            this.Controls.Add(this.textBoxSearch_KEA);
            this.Controls.Add(this.panelName_KEA);
            this.Name = "FormMain";
            this.panelName_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelName_KEA;
        private System.Windows.Forms.Button buttonAbout_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Label labelName_KEA;
        private System.Windows.Forms.TextBox textBoxSearch_KEA;
        private System.Windows.Forms.Label labelSearch_KEA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSorted_KEA;
        private System.Windows.Forms.ComboBox comboBoxFiltr_KEA;
    }
}

