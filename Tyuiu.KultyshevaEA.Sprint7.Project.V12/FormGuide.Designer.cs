
namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBack_KEA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(663, 667);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonBack_KEA
            // 
            this.buttonBack_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_KEA.Image")));
            this.buttonBack_KEA.Location = new System.Drawing.Point(547, 616);
            this.buttonBack_KEA.Name = "buttonBack_KEA";
            this.buttonBack_KEA.Size = new System.Drawing.Size(104, 41);
            this.buttonBack_KEA.TabIndex = 1;
            this.buttonBack_KEA.UseVisualStyleBackColor = true;
            this.buttonBack_KEA.Click += new System.EventHandler(this.buttonBack_KEA_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(687, 691);
            this.Controls.Add(this.buttonBack_KEA);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBack_KEA;
    }
}