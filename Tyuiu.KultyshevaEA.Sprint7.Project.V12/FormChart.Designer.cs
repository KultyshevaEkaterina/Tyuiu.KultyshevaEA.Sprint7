
namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    partial class FormChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelName_KEA = new System.Windows.Forms.Panel();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.buttonBack_KEA = new System.Windows.Forms.Button();
            this.panelDown_KEA = new System.Windows.Forms.Panel();
            this.chartAVM_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMin_KEA = new System.Windows.Forms.TextBox();
            this.labelMin_KEA = new System.Windows.Forms.Label();
            this.labelMid_KEA = new System.Windows.Forms.Label();
            this.textBoxMid_KEA = new System.Windows.Forms.TextBox();
            this.labelMax_KEA = new System.Windows.Forms.Label();
            this.textBoxMax_KEA = new System.Windows.Forms.TextBox();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.panelName_KEA.SuspendLayout();
            this.panelDown_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVM_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName_KEA
            // 
            this.panelName_KEA.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelName_KEA.Controls.Add(this.labelName_KEA);
            this.panelName_KEA.Location = new System.Drawing.Point(0, 0);
            this.panelName_KEA.Name = "panelName_KEA";
            this.panelName_KEA.Size = new System.Drawing.Size(1113, 136);
            this.panelName_KEA.TabIndex = 0;
            // 
            // labelName_KEA
            // 
            this.labelName_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KEA.Location = new System.Drawing.Point(315, 36);
            this.labelName_KEA.Name = "labelName_KEA";
            this.labelName_KEA.Size = new System.Drawing.Size(507, 70);
            this.labelName_KEA.TabIndex = 0;
            this.labelName_KEA.Text = "ПОСТРОЕНИЕ ДИАГРАММЫ";
            this.labelName_KEA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack_KEA
            // 
            this.buttonBack_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_KEA.Image")));
            this.buttonBack_KEA.Location = new System.Drawing.Point(95, 408);
            this.buttonBack_KEA.Name = "buttonBack_KEA";
            this.buttonBack_KEA.Size = new System.Drawing.Size(110, 42);
            this.buttonBack_KEA.TabIndex = 2;
            this.buttonBack_KEA.UseVisualStyleBackColor = true;
            this.buttonBack_KEA.Click += new System.EventHandler(this.buttonBack_KEA_Click);
            // 
            // panelDown_KEA
            // 
            this.panelDown_KEA.BackColor = System.Drawing.Color.Silver;
            this.panelDown_KEA.Controls.Add(this.buttonDone_KEA);
            this.panelDown_KEA.Controls.Add(this.textBoxMax_KEA);
            this.panelDown_KEA.Controls.Add(this.labelMax_KEA);
            this.panelDown_KEA.Controls.Add(this.textBoxMid_KEA);
            this.panelDown_KEA.Controls.Add(this.labelMid_KEA);
            this.panelDown_KEA.Controls.Add(this.labelMin_KEA);
            this.panelDown_KEA.Controls.Add(this.textBoxMin_KEA);
            this.panelDown_KEA.Controls.Add(this.buttonBack_KEA);
            this.panelDown_KEA.Location = new System.Drawing.Point(796, 135);
            this.panelDown_KEA.Name = "panelDown_KEA";
            this.panelDown_KEA.Size = new System.Drawing.Size(299, 486);
            this.panelDown_KEA.TabIndex = 3;
            // 
            // chartAVM_KEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAVM_KEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAVM_KEA.Legends.Add(legend1);
            this.chartAVM_KEA.Location = new System.Drawing.Point(0, 135);
            this.chartAVM_KEA.Name = "chartAVM_KEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAVM_KEA.Series.Add(series1);
            this.chartAVM_KEA.Size = new System.Drawing.Size(763, 474);
            this.chartAVM_KEA.TabIndex = 3;
            // 
            // textBoxMin_KEA
            // 
            this.textBoxMin_KEA.BackColor = System.Drawing.Color.White;
            this.textBoxMin_KEA.Location = new System.Drawing.Point(37, 52);
            this.textBoxMin_KEA.Multiline = true;
            this.textBoxMin_KEA.Name = "textBoxMin_KEA";
            this.textBoxMin_KEA.ReadOnly = true;
            this.textBoxMin_KEA.Size = new System.Drawing.Size(225, 37);
            this.textBoxMin_KEA.TabIndex = 4;
            this.textBoxMin_KEA.TextChanged += new System.EventHandler(this.textBoxMin_KEA_TextChanged);
            // 
            // labelMin_KEA
            // 
            this.labelMin_KEA.AutoSize = true;
            this.labelMin_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin_KEA.Location = new System.Drawing.Point(32, 23);
            this.labelMin_KEA.Name = "labelMin_KEA";
            this.labelMin_KEA.Size = new System.Drawing.Size(150, 26);
            this.labelMin_KEA.TabIndex = 5;
            this.labelMin_KEA.Text = "Мин.стоимость:";
            // 
            // labelMid_KEA
            // 
            this.labelMid_KEA.AutoSize = true;
            this.labelMid_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMid_KEA.Location = new System.Drawing.Point(32, 92);
            this.labelMid_KEA.Name = "labelMid_KEA";
            this.labelMid_KEA.Size = new System.Drawing.Size(139, 26);
            this.labelMid_KEA.TabIndex = 6;
            this.labelMid_KEA.Text = "Ср. стоимость:";
            // 
            // textBoxMid_KEA
            // 
            this.textBoxMid_KEA.BackColor = System.Drawing.Color.White;
            this.textBoxMid_KEA.Location = new System.Drawing.Point(37, 121);
            this.textBoxMid_KEA.Multiline = true;
            this.textBoxMid_KEA.Name = "textBoxMid_KEA";
            this.textBoxMid_KEA.ReadOnly = true;
            this.textBoxMid_KEA.Size = new System.Drawing.Size(225, 36);
            this.textBoxMid_KEA.TabIndex = 7;
            // 
            // labelMax_KEA
            // 
            this.labelMax_KEA.AutoSize = true;
            this.labelMax_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax_KEA.Location = new System.Drawing.Point(32, 160);
            this.labelMax_KEA.Name = "labelMax_KEA";
            this.labelMax_KEA.Size = new System.Drawing.Size(156, 26);
            this.labelMax_KEA.TabIndex = 8;
            this.labelMax_KEA.Text = "Макс.стоимость:";
            // 
            // textBoxMax_KEA
            // 
            this.textBoxMax_KEA.BackColor = System.Drawing.Color.White;
            this.textBoxMax_KEA.Location = new System.Drawing.Point(37, 189);
            this.textBoxMax_KEA.Multiline = true;
            this.textBoxMax_KEA.Name = "textBoxMax_KEA";
            this.textBoxMax_KEA.ReadOnly = true;
            this.textBoxMax_KEA.Size = new System.Drawing.Size(225, 34);
            this.textBoxMax_KEA.TabIndex = 9;
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonDone_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_KEA.Location = new System.Drawing.Point(65, 240);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(158, 34);
            this.buttonDone_KEA.TabIndex = 10;
            this.buttonDone_KEA.Text = "ВЫПОЛНИТЬ";
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.chartAVM_KEA);
            this.Controls.Add(this.panelDown_KEA);
            this.Controls.Add(this.panelName_KEA);
            this.Name = "FormChart";
            this.panelName_KEA.ResumeLayout(false);
            this.panelDown_KEA.ResumeLayout(false);
            this.panelDown_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVM_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName_KEA;
        private System.Windows.Forms.Label labelName_KEA;
        private System.Windows.Forms.Button buttonBack_KEA;
        private System.Windows.Forms.Panel panelDown_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAVM_KEA;
        private System.Windows.Forms.Label labelMax_KEA;
        private System.Windows.Forms.TextBox textBoxMid_KEA;
        private System.Windows.Forms.Label labelMid_KEA;
        private System.Windows.Forms.Label labelMin_KEA;
        private System.Windows.Forms.TextBox textBoxMin_KEA;
        private System.Windows.Forms.TextBox textBoxMax_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
    }
}