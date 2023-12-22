
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelName_KEA = new System.Windows.Forms.Panel();
            this.buttonAbout_KEA = new System.Windows.Forms.Button();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.textBoxSearch_KEA = new System.Windows.Forms.TextBox();
            this.labelSearch_KEA = new System.Windows.Forms.Label();
            this.dataGridViewTable_KEA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSorted_KEA = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltr_KEA = new System.Windows.Forms.ComboBox();
            this.buttonDiagram_KEA = new System.Windows.Forms.Button();
            this.buttonFirms_KEA = new System.Windows.Forms.Button();
            this.buttonOpen_KEA = new System.Windows.Forms.Button();
            this.buttonSave_KEA = new System.Windows.Forms.Button();
            this.buttonAdd_KEA = new System.Windows.Forms.Button();
            this.buttonDel_KEA = new System.Windows.Forms.Button();
            this.toolTip_KEA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogMain_KEA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain_KEA = new System.Windows.Forms.SaveFileDialog();
            this.panelName_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KEA)).BeginInit();
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
            // buttonAbout_KEA
            // 
            this.buttonAbout_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_KEA.Image")));
            this.buttonAbout_KEA.Location = new System.Drawing.Point(1040, 9);
            this.buttonAbout_KEA.Name = "buttonAbout_KEA";
            this.buttonAbout_KEA.Size = new System.Drawing.Size(55, 50);
            this.buttonAbout_KEA.TabIndex = 2;
            this.toolTip_KEA.SetToolTip(this.buttonAbout_KEA, "Информация о разработчике");
            this.buttonAbout_KEA.UseVisualStyleBackColor = true;
            this.buttonAbout_KEA.Click += new System.EventHandler(this.buttonAbout_KEA_Click);
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KEA.Image")));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(979, 9);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(55, 50);
            this.buttonHelp_KEA.TabIndex = 1;
            this.toolTip_KEA.SetToolTip(this.buttonHelp_KEA, "Информация о программе");
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
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
            // textBoxSearch_KEA
            // 
            this.textBoxSearch_KEA.Location = new System.Drawing.Point(807, 183);
            this.textBoxSearch_KEA.Multiline = true;
            this.textBoxSearch_KEA.Name = "textBoxSearch_KEA";
            this.textBoxSearch_KEA.Size = new System.Drawing.Size(288, 43);
            this.textBoxSearch_KEA.TabIndex = 3;
            this.textBoxSearch_KEA.TextChanged += new System.EventHandler(this.textBoxSearch_KEA_TextChanged);
            // 
            // labelSearch_KEA
            // 
            this.labelSearch_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch_KEA.Location = new System.Drawing.Point(802, 146);
            this.labelSearch_KEA.Name = "labelSearch_KEA";
            this.labelSearch_KEA.Size = new System.Drawing.Size(100, 23);
            this.labelSearch_KEA.TabIndex = 4;
            this.labelSearch_KEA.Text = "Поиск:";
            // 
            // dataGridViewTable_KEA
            // 
            this.dataGridViewTable_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewTable_KEA.Location = new System.Drawing.Point(12, 249);
            this.dataGridViewTable_KEA.Name = "dataGridViewTable_KEA";
            this.dataGridViewTable_KEA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewTable_KEA.Size = new System.Drawing.Size(782, 360);
            this.dataGridViewTable_KEA.TabIndex = 5;
            this.dataGridViewTable_KEA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_KEA_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Фирма-изготовитель";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 141;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Тип процессора";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Тактовая частота";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 112;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Объем ОЗУ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 86;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Объём жёсткого диска";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 138;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Дата выпуска";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 96;
            // 
            // comboBoxSorted_KEA
            // 
            this.comboBoxSorted_KEA.FormattingEnabled = true;
            this.comboBoxSorted_KEA.Location = new System.Drawing.Point(807, 349);
            this.comboBoxSorted_KEA.Name = "comboBoxSorted_KEA";
            this.comboBoxSorted_KEA.Size = new System.Drawing.Size(260, 21);
            this.comboBoxSorted_KEA.TabIndex = 6;
            // 
            // comboBoxFiltr_KEA
            // 
            this.comboBoxFiltr_KEA.FormattingEnabled = true;
            this.comboBoxFiltr_KEA.Location = new System.Drawing.Point(807, 289);
            this.comboBoxFiltr_KEA.Name = "comboBoxFiltr_KEA";
            this.comboBoxFiltr_KEA.Size = new System.Drawing.Size(260, 21);
            this.comboBoxFiltr_KEA.TabIndex = 7;
            // 
            // buttonDiagram_KEA
            // 
            this.buttonDiagram_KEA.BackColor = System.Drawing.Color.Silver;
            this.buttonDiagram_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiagram_KEA.Location = new System.Drawing.Point(22, 146);
            this.buttonDiagram_KEA.Name = "buttonDiagram_KEA";
            this.buttonDiagram_KEA.Size = new System.Drawing.Size(185, 70);
            this.buttonDiagram_KEA.TabIndex = 8;
            this.buttonDiagram_KEA.Text = "Построить диаграмму";
            this.toolTip_KEA.SetToolTip(this.buttonDiagram_KEA, "Построить диаграмму по данным");
            this.buttonDiagram_KEA.UseVisualStyleBackColor = false;
            this.buttonDiagram_KEA.Click += new System.EventHandler(this.buttonDiagram_KEA_Click);
            // 
            // buttonFirms_KEA
            // 
            this.buttonFirms_KEA.BackColor = System.Drawing.Color.Silver;
            this.buttonFirms_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirms_KEA.Location = new System.Drawing.Point(233, 146);
            this.buttonFirms_KEA.Name = "buttonFirms_KEA";
            this.buttonFirms_KEA.Size = new System.Drawing.Size(185, 70);
            this.buttonFirms_KEA.TabIndex = 9;
            this.buttonFirms_KEA.Text = "Информация о фирмах реализаторах";
            this.toolTip_KEA.SetToolTip(this.buttonFirms_KEA, "Получить информацию о фирмах реализаторах");
            this.buttonFirms_KEA.UseVisualStyleBackColor = false;
            this.buttonFirms_KEA.Click += new System.EventHandler(this.buttonFirms_KEA_Click);
            // 
            // buttonOpen_KEA
            // 
            this.buttonOpen_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KEA.Image")));
            this.buttonOpen_KEA.Location = new System.Drawing.Point(434, 146);
            this.buttonOpen_KEA.Name = "buttonOpen_KEA";
            this.buttonOpen_KEA.Size = new System.Drawing.Size(75, 70);
            this.buttonOpen_KEA.TabIndex = 10;
            this.toolTip_KEA.SetToolTip(this.buttonOpen_KEA, "Открыть файл");
            this.buttonOpen_KEA.UseVisualStyleBackColor = true;
            this.buttonOpen_KEA.Click += new System.EventHandler(this.buttonOpen_KEA_Click);
            // 
            // buttonSave_KEA
            // 
            this.buttonSave_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KEA.Image")));
            this.buttonSave_KEA.Location = new System.Drawing.Point(515, 146);
            this.buttonSave_KEA.Name = "buttonSave_KEA";
            this.buttonSave_KEA.Size = new System.Drawing.Size(75, 70);
            this.buttonSave_KEA.TabIndex = 11;
            this.toolTip_KEA.SetToolTip(this.buttonSave_KEA, "Сохранить файл");
            this.buttonSave_KEA.UseVisualStyleBackColor = true;
            this.buttonSave_KEA.Click += new System.EventHandler(this.buttonSave_KEA_Click);
            // 
            // buttonAdd_KEA
            // 
            this.buttonAdd_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_KEA.Image")));
            this.buttonAdd_KEA.Location = new System.Drawing.Point(596, 146);
            this.buttonAdd_KEA.Name = "buttonAdd_KEA";
            this.buttonAdd_KEA.Size = new System.Drawing.Size(75, 70);
            this.buttonAdd_KEA.TabIndex = 12;
            this.toolTip_KEA.SetToolTip(this.buttonAdd_KEA, "Добавить строку");
            this.buttonAdd_KEA.UseVisualStyleBackColor = true;
            this.buttonAdd_KEA.Click += new System.EventHandler(this.buttonAdd_KEA_Click);
            // 
            // buttonDel_KEA
            // 
            this.buttonDel_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDel_KEA.Image")));
            this.buttonDel_KEA.Location = new System.Drawing.Point(677, 146);
            this.buttonDel_KEA.Name = "buttonDel_KEA";
            this.buttonDel_KEA.Size = new System.Drawing.Size(75, 70);
            this.buttonDel_KEA.TabIndex = 13;
            this.toolTip_KEA.SetToolTip(this.buttonDel_KEA, "Удалить строку");
            this.buttonDel_KEA.UseVisualStyleBackColor = true;
            this.buttonDel_KEA.Click += new System.EventHandler(this.buttonDel_KEA_Click);
            // 
            // toolTip_KEA
            // 
            this.toolTip_KEA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip_KEA.IsBalloon = true;
            this.toolTip_KEA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KEA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogMain_KEA
            // 
            this.openFileDialogMain_KEA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.buttonDel_KEA);
            this.Controls.Add(this.buttonAdd_KEA);
            this.Controls.Add(this.buttonSave_KEA);
            this.Controls.Add(this.buttonOpen_KEA);
            this.Controls.Add(this.buttonFirms_KEA);
            this.Controls.Add(this.buttonDiagram_KEA);
            this.Controls.Add(this.comboBoxFiltr_KEA);
            this.Controls.Add(this.comboBoxSorted_KEA);
            this.Controls.Add(this.dataGridViewTable_KEA);
            this.Controls.Add(this.labelSearch_KEA);
            this.Controls.Add(this.textBoxSearch_KEA);
            this.Controls.Add(this.panelName_KEA);
            this.Name = "FormMain";
            this.panelName_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KEA)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewTable_KEA;
        private System.Windows.Forms.ComboBox comboBoxSorted_KEA;
        private System.Windows.Forms.ComboBox comboBoxFiltr_KEA;
        private System.Windows.Forms.Button buttonDiagram_KEA;
        private System.Windows.Forms.Button buttonFirms_KEA;
        private System.Windows.Forms.Button buttonOpen_KEA;
        private System.Windows.Forms.Button buttonSave_KEA;
        private System.Windows.Forms.Button buttonAdd_KEA;
        private System.Windows.Forms.Button buttonDel_KEA;
        private System.Windows.Forms.ToolTip toolTip_KEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_KEA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_KEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

