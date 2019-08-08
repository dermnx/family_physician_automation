namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmKapiUstu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoktorAdi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAltKayanYazi = new System.Windows.Forms.Label();
            this.listBoxHastaAdlari = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOncelik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblDoktorAdi);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2050, 126);
            this.panel1.TabIndex = 0;
            // 
            // lblDoktorAdi
            // 
            this.lblDoktorAdi.AutoSize = true;
            this.lblDoktorAdi.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAdi.Location = new System.Drawing.Point(579, 8);
            this.lblDoktorAdi.Name = "lblDoktorAdi";
            this.lblDoktorAdi.Size = new System.Drawing.Size(735, 97);
            this.lblDoktorAdi.TabIndex = 0;
            this.lblDoktorAdi.Text = "DR. DOKTOR ADI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblAltKayanYazi);
            this.panel2.Location = new System.Drawing.Point(-4, 865);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2057, 126);
            this.panel2.TabIndex = 1;
            // 
            // lblAltKayanYazi
            // 
            this.lblAltKayanYazi.AutoSize = true;
            this.lblAltKayanYazi.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltKayanYazi.Location = new System.Drawing.Point(84, 20);
            this.lblAltKayanYazi.Name = "lblAltKayanYazi";
            this.lblAltKayanYazi.Size = new System.Drawing.Size(564, 97);
            this.lblAltKayanYazi.TabIndex = 0;
            this.lblAltKayanYazi.Text = "altKayanYazi";
            this.lblAltKayanYazi.Click += new System.EventHandler(this.lblAltKayanYazi_Click);
            // 
            // listBoxHastaAdlari
            // 
            this.listBoxHastaAdlari.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxHastaAdlari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHastaAdlari.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxHastaAdlari.FormattingEnabled = true;
            this.listBoxHastaAdlari.ItemHeight = 72;
            this.listBoxHastaAdlari.Location = new System.Drawing.Point(12, 175);
            this.listBoxHastaAdlari.Name = "listBoxHastaAdlari";
            this.listBoxHastaAdlari.Size = new System.Drawing.Size(1037, 648);
            this.listBoxHastaAdlari.TabIndex = 2;
            this.listBoxHastaAdlari.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(972, 97);
            this.label3.TabIndex = 0;
            this.label3.Text = "HASTA SIRA HASTA AD";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncelik.Location = new System.Drawing.Point(27, 53);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(660, 468);
            this.lblOncelik.TabIndex = 0;
            this.lblOncelik.Text = "->Acil Vakalar,\r\n\r\nEngelliler,\r\n\r\nHamileler,\r\n\r\n65 Yaş üstü yaşlılar,\r\n\r\nYedi (7)" +
    " yaşından küçük çocuklar,\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(762, 72);
            this.label4.TabIndex = 1;
            this.label4.Text = "*Sağlık Bakanlığı Tedavi Hizmetleri Genel Müdürlüğü \r\n2010/73 sayılı genelge gere" +
    "ğince Polikliniklerde sırası ile";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lblOncelik);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1087, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 687);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Önceliği ";
            // 
            // FrmKapiUstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxHastaAdlari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKapiUstu";
            this.Text = "Derman KARATEKE AHBS     --   V1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKapiUstu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDoktorAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAltKayanYazi;
        private System.Windows.Forms.ListBox listBoxHastaAdlari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}