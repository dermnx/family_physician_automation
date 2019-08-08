namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmBeklemeEkran
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
            this.lblUstLutfen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMazeret = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUstLutfen
            // 
            this.lblUstLutfen.AutoSize = true;
            this.lblUstLutfen.Font = new System.Drawing.Font("Microsoft JhengHei", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUstLutfen.Location = new System.Drawing.Point(100, 49);
            this.lblUstLutfen.Name = "lblUstLutfen";
            this.lblUstLutfen.Size = new System.Drawing.Size(935, 101);
            this.lblUstLutfen.TabIndex = 0;
            this.lblUstLutfen.Text = "LÜTFEN BEKLEYİNİZ ! !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblUstLutfen);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2083, 191);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMazeret
            // 
            this.lblMazeret.AutoSize = true;
            this.lblMazeret.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMazeret.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMazeret.Location = new System.Drawing.Point(145, 392);
            this.lblMazeret.Name = "lblMazeret";
            this.lblMazeret.Size = new System.Drawing.Size(1602, 150);
            this.lblMazeret.TabIndex = 2;
            this.lblMazeret.Text = "DOKTOR                  DOLAYI ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1653, 150);
            this.label3.TabIndex = 4;
            this.label3.Text = "HİZMET VEREMEMEKTEDİR";
            // 
            // FrmBeklemeEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2024, 1039);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMazeret);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBeklemeEkran";
            this.Text = "FrmBeklemeEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBeklemeEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUstLutfen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMazeret;
    }
}