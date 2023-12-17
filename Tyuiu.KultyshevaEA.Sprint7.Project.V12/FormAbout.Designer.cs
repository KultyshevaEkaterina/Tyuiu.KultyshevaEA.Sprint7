
namespace Tyuiu.KultyshevaEA.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxPhoto_KEA = new System.Windows.Forms.PictureBox();
            this.labelAbout_KEA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto_KEA
            // 
            this.pictureBoxPhoto_KEA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto_KEA.Image")));
            this.pictureBoxPhoto_KEA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPhoto_KEA.Name = "pictureBoxPhoto_KEA";
            this.pictureBoxPhoto_KEA.Size = new System.Drawing.Size(111, 134);
            this.pictureBoxPhoto_KEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto_KEA.TabIndex = 0;
            this.pictureBoxPhoto_KEA.TabStop = false;
            // 
            // labelAbout_KEA
            // 
            this.labelAbout_KEA.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_KEA.Location = new System.Drawing.Point(129, 9);
            this.labelAbout_KEA.Name = "labelAbout_KEA";
            this.labelAbout_KEA.Size = new System.Drawing.Size(274, 163);
            this.labelAbout_KEA.TabIndex = 1;
            this.labelAbout_KEA.Text = resources.GetString("labelAbout_KEA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 181);
            this.Controls.Add(this.labelAbout_KEA);
            this.Controls.Add(this.pictureBoxPhoto_KEA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_KEA;
        private System.Windows.Forms.Label labelAbout_KEA;
    }
}