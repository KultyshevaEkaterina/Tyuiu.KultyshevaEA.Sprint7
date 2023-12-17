
namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    partial class FormFirms
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
            this.panelFirm_KEA = new System.Windows.Forms.Panel();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.dataGridViewFirms_KEA = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltrs_KEA = new System.Windows.Forms.ComboBox();
            this.labelFiltrs_KEA = new System.Windows.Forms.Label();
            this.buttonBack_KEA = new System.Windows.Forms.Button();
            this.comboBoxSorted_KEA = new System.Windows.Forms.ComboBox();
            this.labelSorted_KEA = new System.Windows.Forms.Label();
            this.panelFirm_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirms_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFirm_KEA
            // 
            this.panelFirm_KEA.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelFirm_KEA.Controls.Add(this.labelName_KEA);
            this.panelFirm_KEA.Location = new System.Drawing.Point(0, 0);
            this.panelFirm_KEA.Name = "panelFirm_KEA";
            this.panelFirm_KEA.Size = new System.Drawing.Size(1106, 144);
            this.panelFirm_KEA.TabIndex = 0;
            // 
            // labelName_KEA
            // 
            this.labelName_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KEA.Location = new System.Drawing.Point(272, 39);
            this.labelName_KEA.Name = "labelName_KEA";
            this.labelName_KEA.Size = new System.Drawing.Size(545, 60);
            this.labelName_KEA.TabIndex = 0;
            this.labelName_KEA.Text = "Фирмы-реализаторы";
            this.labelName_KEA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewFirms_KEA
            // 
            this.dataGridViewFirms_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirms_KEA.Location = new System.Drawing.Point(12, 169);
            this.dataGridViewFirms_KEA.Name = "dataGridViewFirms_KEA";
            this.dataGridViewFirms_KEA.Size = new System.Drawing.Size(743, 423);
            this.dataGridViewFirms_KEA.TabIndex = 1;
            // 
            // comboBoxFiltrs_KEA
            // 
            this.comboBoxFiltrs_KEA.FormattingEnabled = true;
            this.comboBoxFiltrs_KEA.Location = new System.Drawing.Point(826, 204);
            this.comboBoxFiltrs_KEA.Name = "comboBoxFiltrs_KEA";
            this.comboBoxFiltrs_KEA.Size = new System.Drawing.Size(184, 21);
            this.comboBoxFiltrs_KEA.TabIndex = 2;
            // 
            // labelFiltrs_KEA
            // 
            this.labelFiltrs_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFiltrs_KEA.Location = new System.Drawing.Point(822, 178);
            this.labelFiltrs_KEA.Name = "labelFiltrs_KEA";
            this.labelFiltrs_KEA.Size = new System.Drawing.Size(100, 23);
            this.labelFiltrs_KEA.TabIndex = 3;
            this.labelFiltrs_KEA.Text = "Фильтры";
            // 
            // buttonBack_KEA
            // 
            this.buttonBack_KEA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBack_KEA.Location = new System.Drawing.Point(875, 543);
            this.buttonBack_KEA.Name = "buttonBack_KEA";
            this.buttonBack_KEA.Size = new System.Drawing.Size(135, 49);
            this.buttonBack_KEA.TabIndex = 4;
            this.buttonBack_KEA.UseVisualStyleBackColor = true;
            this.buttonBack_KEA.Click += new System.EventHandler(this.buttonBack_KEA_Click);
            // 
            // comboBoxSorted_KEA
            // 
            this.comboBoxSorted_KEA.FormattingEnabled = true;
            this.comboBoxSorted_KEA.Location = new System.Drawing.Point(826, 273);
            this.comboBoxSorted_KEA.Name = "comboBoxSorted_KEA";
            this.comboBoxSorted_KEA.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSorted_KEA.TabIndex = 5;
            // 
            // labelSorted_KEA
            // 
            this.labelSorted_KEA.AutoSize = true;
            this.labelSorted_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSorted_KEA.Location = new System.Drawing.Point(826, 249);
            this.labelSorted_KEA.Name = "labelSorted_KEA";
            this.labelSorted_KEA.Size = new System.Drawing.Size(96, 21);
            this.labelSorted_KEA.TabIndex = 6;
            this.labelSorted_KEA.Text = "Сортировка";
            // 
            // FormFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.labelSorted_KEA);
            this.Controls.Add(this.comboBoxSorted_KEA);
            this.Controls.Add(this.buttonBack_KEA);
            this.Controls.Add(this.labelFiltrs_KEA);
            this.Controls.Add(this.comboBoxFiltrs_KEA);
            this.Controls.Add(this.dataGridViewFirms_KEA);
            this.Controls.Add(this.panelFirm_KEA);
            this.Name = "FormFirms";
            this.panelFirm_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirms_KEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFirm_KEA;
        private System.Windows.Forms.Label labelName_KEA;
        private System.Windows.Forms.DataGridView dataGridViewFirms_KEA;
        private System.Windows.Forms.ComboBox comboBoxFiltrs_KEA;
        private System.Windows.Forms.Label labelFiltrs_KEA;
        private System.Windows.Forms.Button buttonBack_KEA;
        private System.Windows.Forms.ComboBox comboBoxSorted_KEA;
        private System.Windows.Forms.Label labelSorted_KEA;
    }
}