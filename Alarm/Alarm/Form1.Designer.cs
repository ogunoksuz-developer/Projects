namespace Alarm
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlarmSil = new System.Windows.Forms.Button();
            this.lstAlarm = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.cmbDakika = new System.Windows.Forms.ComboBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlarmSil);
            this.panel1.Controls.Add(this.lstAlarm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 209);
            this.panel1.TabIndex = 0;
            // 
            // btnAlarmSil
            // 
            this.btnAlarmSil.Location = new System.Drawing.Point(13, 175);
            this.btnAlarmSil.Name = "btnAlarmSil";
            this.btnAlarmSil.Size = new System.Drawing.Size(150, 23);
            this.btnAlarmSil.TabIndex = 2;
            this.btnAlarmSil.Text = "Secili Alarmi Sil";
            this.btnAlarmSil.UseVisualStyleBackColor = true;
            this.btnAlarmSil.Click += new System.EventHandler(this.btnAlarmSil_Click);
            // 
            // lstAlarm
            // 
            this.lstAlarm.FormattingEnabled = true;
            this.lstAlarm.Location = new System.Drawing.Point(13, 47);
            this.lstAlarm.Name = "lstAlarm";
            this.lstAlarm.Size = new System.Drawing.Size(150, 121);
            this.lstAlarm.TabIndex = 1;
            this.lstAlarm.SelectedIndexChanged += new System.EventHandler(this.lstAlarm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm listesi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnAlarmKur);
            this.panel2.Controls.Add(this.cmbDakika);
            this.panel2.Controls.Add(this.cmbSaat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(237, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 209);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Alarmı durdur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.Location = new System.Drawing.Point(11, 143);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(75, 38);
            this.btnAlarmKur.TabIndex = 4;
            this.btnAlarmKur.Text = "Alarmı kur";
            this.btnAlarmKur.UseVisualStyleBackColor = true;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // cmbDakika
            // 
            this.cmbDakika.FormattingEnabled = true;
            this.cmbDakika.Location = new System.Drawing.Point(100, 74);
            this.cmbDakika.Name = "cmbDakika";
            this.cmbDakika.Size = new System.Drawing.Size(82, 21);
            this.cmbDakika.TabIndex = 2;
            this.cmbDakika.Text = "Dakika";
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(11, 74);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(83, 21);
            this.cmbSaat.TabIndex = 1;
            this.cmbSaat.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 445);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlarmSil;
        private System.Windows.Forms.ListBox lstAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.ComboBox cmbDakika;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label label2;
    }
}

