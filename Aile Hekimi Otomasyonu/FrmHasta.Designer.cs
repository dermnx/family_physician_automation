namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmHasta
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
            this.lblAileHekimNo = new System.Windows.Forms.Label();
            this.mTxtTCno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAltKayanYazi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblAileHekimNo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2050, 126);
            this.panel1.TabIndex = 1;
            // 
            // lblAileHekimNo
            // 
            this.lblAileHekimNo.AutoSize = true;
            this.lblAileHekimNo.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAileHekimNo.Location = new System.Drawing.Point(488, 9);
            this.lblAileHekimNo.Name = "lblAileHekimNo";
            this.lblAileHekimNo.Size = new System.Drawing.Size(954, 97);
            this.lblAileHekimNo.TabIndex = 0;
            this.lblAileHekimNo.Text = "00. Nolu Aile Hekimliği";
            // 
            // mTxtTCno
            // 
            this.mTxtTCno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mTxtTCno.BeepOnError = true;
            this.mTxtTCno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtTCno.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtTCno.Location = new System.Drawing.Point(978, 423);
            this.mTxtTCno.Mask = "00000000000";
            this.mTxtTCno.Name = "mTxtTCno";
            this.mTxtTCno.Size = new System.Drawing.Size(627, 97);
            this.mTxtTCno.TabIndex = 1;
            this.mTxtTCno.ValidatingType = typeof(int);
            this.mTxtTCno.TextAlignChanged += new System.EventHandler(this.mTxtTCno_TextAlignChanged);
            this.mTxtTCno.SizeChanged += new System.EventHandler(this.mTxtTCno_SizeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(245, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 97);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC KİMLİK NO :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblAltKayanYazi);
            this.panel2.Location = new System.Drawing.Point(1, 872);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2050, 126);
            this.panel2.TabIndex = 1;
            // 
            // lblAltKayanYazi
            // 
            this.lblAltKayanYazi.AutoSize = true;
            this.lblAltKayanYazi.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltKayanYazi.Location = new System.Drawing.Point(100, 11);
            this.lblAltKayanYazi.Name = "lblAltKayanYazi";
            this.lblAltKayanYazi.Size = new System.Drawing.Size(617, 97);
            this.lblAltKayanYazi.TabIndex = 0;
            this.lblAltKayanYazi.Text = "Alt Kayan Yazi";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(131, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1941, 991);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mTxtTCno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHasta";
            this.Text = " Derman KARATEKE AHBS     --   V1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHasta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAileHekimNo;
        private System.Windows.Forms.MaskedTextBox mTxtTCno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAltKayanYazi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}