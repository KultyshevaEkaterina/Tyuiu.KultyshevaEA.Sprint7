
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
            this.panelName_KEA = new System.Windows.Forms.Panel();
            this.labelName_KEA = new System.Windows.Forms.Label();
            this.dataGridViewChart_KEA = new System.Windows.Forms.DataGridView();
            this.buttonBack_KEA = new System.Windows.Forms.Button();
            this.panelName_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChart_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName_KEA
            // 
            this.panelName_KEA.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelName_KEA.Controls.Add(this.labelName_KEA);
            this.panelName_KEA.Location = new System.Drawing.Point(0, 0);
            this.panelName_KEA.Name = "panelName_KEA";
            this.panelName_KEA.Size = new System.Drawing.Size(1113, 159);
            this.panelName_KEA.TabIndex = 0;
            // 
            // labelName_KEA
            // 
            this.labelName_KEA.Font = new System.Drawing.Font("Segoe UI Variable Display", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KEA.Location = new System.Drawing.Point(313, 31);
            this.labelName_KEA.Name = "labelName_KEA";
            this.labelName_KEA.Size = new System.Drawing.Size(465, 70);
            this.labelName_KEA.TabIndex = 0;
            this.labelName_KEA.Text = "Построение графика";
            this.labelName_KEA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewChart_KEA
            // 
            this.dataGridViewChart_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChart_KEA.Location = new System.Drawing.Point(12, 178);
            this.dataGridViewChart_KEA.Name = "dataGridViewChart_KEA";
            this.dataGridViewChart_KEA.Size = new System.Drawing.Size(766, 399);
            this.dataGridViewChart_KEA.TabIndex = 1;
            // 
            // buttonBack_KEA
            // 
            this.buttonBack_KEA.Location = new System.Drawing.Point(898, 535);
            this.buttonBack_KEA.Name = "buttonBack_KEA";
            this.buttonBack_KEA.Size = new System.Drawing.Size(110, 42);
            this.buttonBack_KEA.TabIndex = 2;
            this.buttonBack_KEA.UseVisualStyleBackColor = true;
            this.buttonBack_KEA.Click += new System.EventHandler(this.buttonBack_KEA_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.buttonBack_KEA);
            this.Controls.Add(this.dataGridViewChart_KEA);
            this.Controls.Add(this.panelName_KEA);
            this.Name = "FormChart";
            this.panelName_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChart_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName_KEA;
        private System.Windows.Forms.DataGridView dataGridViewChart_KEA;
        private System.Windows.Forms.Label labelName_KEA;
        private System.Windows.Forms.Button buttonBack_KEA;
    }
}