﻿namespace HesapMakinesi2
{
    partial class AcilisEkrani
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
            this.lblFormGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormGiris
            // 
            this.lblFormGiris.AutoSize = true;
            this.lblFormGiris.Location = new System.Drawing.Point(97, 30);
            this.lblFormGiris.Name = "lblFormGiris";
            this.lblFormGiris.Size = new System.Drawing.Size(80, 13);
            this.lblFormGiris.TabIndex = 0;
            this.lblFormGiris.Text = "HOŞGELDİNİZ";
            // 
            // AcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblFormGiris);
            this.Name = "AcilisEkrani";
            this.Text = "AcilisEkrani";
            this.Load += new System.EventHandler(this.AcilisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormGiris;

    }
}