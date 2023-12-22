
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
            ((System.ComponentModel.ISupportInitialize)(this.chartAVM_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName_KEA;
        private System.Windows.Forms.Label labelName_KEA;
        private System.Windows.Forms.Button buttonBack_KEA;
        private System.Windows.Forms.Panel panelDown_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAVM_KEA;
    }
}