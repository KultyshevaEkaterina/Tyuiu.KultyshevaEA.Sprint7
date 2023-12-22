
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirms));
            this.panelFirm_KEA = new System.Windows.Forms.Panel();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.dataGridViewFirms_KEA = new System.Windows.Forms.DataGridView();
            this.comboBoxCity_KEA = new System.Windows.Forms.ComboBox();
            this.labelFiltrs_KEA = new System.Windows.Forms.Label();
            this.buttonBack_KEA = new System.Windows.Forms.Button();
            this.comboBoxName_KEA = new System.Windows.Forms.ComboBox();
            this.labelCity_KEA = new System.Windows.Forms.Label();
            this.buttonOpen_KEA = new System.Windows.Forms.Button();
            this.buttonReturn_KEA = new System.Windows.Forms.Button();
            this.openFileDialogFirms_KEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipFirms_KEA = new System.Windows.Forms.ToolTip(this.components);
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
            // comboBoxCity_KEA
            // 
            this.comboBoxCity_KEA.FormattingEnabled = true;
            this.comboBoxCity_KEA.Items.AddRange(new object[] {
            "Москва",
            "Уфа",
            "Екатеринбург",
            "Зеленоград"});
            this.comboBoxCity_KEA.Location = new System.Drawing.Point(875, 204);
            this.comboBoxCity_KEA.Name = "comboBoxCity_KEA";
            this.comboBoxCity_KEA.Size = new System.Drawing.Size(184, 21);
            this.comboBoxCity_KEA.TabIndex = 2;
            this.comboBoxCity_KEA.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrs_KEA_SelectedIndexChanged);
            // 
            // labelFiltrs_KEA
            // 
            this.labelFiltrs_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFiltrs_KEA.Location = new System.Drawing.Point(871, 178);
            this.labelFiltrs_KEA.Name = "labelFiltrs_KEA";
            this.labelFiltrs_KEA.Size = new System.Drawing.Size(123, 23);
            this.labelFiltrs_KEA.TabIndex = 3;
            this.labelFiltrs_KEA.Text = "Фильтр: Город";
            // 
            // buttonBack_KEA
            // 
            this.buttonBack_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_KEA.Image")));
            this.buttonBack_KEA.Location = new System.Drawing.Point(875, 543);
            this.buttonBack_KEA.Name = "buttonBack_KEA";
            this.buttonBack_KEA.Size = new System.Drawing.Size(135, 49);
            this.buttonBack_KEA.TabIndex = 4;
            this.toolTipFirms_KEA.SetToolTip(this.buttonBack_KEA, "Обратно");
            this.buttonBack_KEA.UseVisualStyleBackColor = true;
            this.buttonBack_KEA.Click += new System.EventHandler(this.buttonBack_KEA_Click);
            // 
            // comboBoxName_KEA
            // 
            this.comboBoxName_KEA.FormattingEnabled = true;
            this.comboBoxName_KEA.Location = new System.Drawing.Point(875, 273);
            this.comboBoxName_KEA.Name = "comboBoxName_KEA";
            this.comboBoxName_KEA.Size = new System.Drawing.Size(184, 21);
            this.comboBoxName_KEA.TabIndex = 5;
            // 
            // labelCity_KEA
            // 
            this.labelCity_KEA.AutoSize = true;
            this.labelCity_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity_KEA.Location = new System.Drawing.Point(871, 249);
            this.labelCity_KEA.Name = "labelCity_KEA";
            this.labelCity_KEA.Size = new System.Drawing.Size(139, 21);
            this.labelCity_KEA.TabIndex = 6;
            this.labelCity_KEA.Text = "Фильтр: Название";
            // 
            // buttonOpen_KEA
            // 
            this.buttonOpen_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KEA.Image")));
            this.buttonOpen_KEA.Location = new System.Drawing.Point(761, 169);
            this.buttonOpen_KEA.Name = "buttonOpen_KEA";
            this.buttonOpen_KEA.Size = new System.Drawing.Size(75, 56);
            this.buttonOpen_KEA.TabIndex = 7;
            this.toolTipFirms_KEA.SetToolTip(this.buttonOpen_KEA, "Открыть файл");
            this.buttonOpen_KEA.UseVisualStyleBackColor = true;
            this.buttonOpen_KEA.Click += new System.EventHandler(this.buttonOpen_KEA_Click);
            // 
            // buttonReturn_KEA
            // 
            this.buttonReturn_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn_KEA.Image")));
            this.buttonReturn_KEA.Location = new System.Drawing.Point(761, 231);
            this.buttonReturn_KEA.Name = "buttonReturn_KEA";
            this.buttonReturn_KEA.Size = new System.Drawing.Size(75, 56);
            this.buttonReturn_KEA.TabIndex = 8;
            this.toolTipFirms_KEA.SetToolTip(this.buttonReturn_KEA, "Вернуть все");
            this.buttonReturn_KEA.UseVisualStyleBackColor = true;
            this.buttonReturn_KEA.Click += new System.EventHandler(this.buttonReturn_KEA_Click);
            // 
            // openFileDialogFirms_KEA
            // 
            this.openFileDialogFirms_KEA.FileName = "openFileDialog1";
            // 
            // toolTipFirms_KEA
            // 
            this.toolTipFirms_KEA.Tag = "Подсказка";
            // 
            // FormFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.buttonReturn_KEA);
            this.Controls.Add(this.buttonOpen_KEA);
            this.Controls.Add(this.labelCity_KEA);
            this.Controls.Add(this.comboBoxName_KEA);
            this.Controls.Add(this.buttonBack_KEA);
            this.Controls.Add(this.labelFiltrs_KEA);
            this.Controls.Add(this.comboBoxCity_KEA);
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
        private System.Windows.Forms.ComboBox comboBoxCity_KEA;
        private System.Windows.Forms.Label labelFiltrs_KEA;
        private System.Windows.Forms.Button buttonBack_KEA;
        private System.Windows.Forms.ComboBox comboBoxName_KEA;
        private System.Windows.Forms.Label labelCity_KEA;
        private System.Windows.Forms.Button buttonOpen_KEA;
        private System.Windows.Forms.Button buttonReturn_KEA;
        private System.Windows.Forms.ToolTip toolTipFirms_KEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogFirms_KEA;
    }
}