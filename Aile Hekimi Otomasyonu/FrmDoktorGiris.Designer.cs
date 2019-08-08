namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.simpleBtrCikisYap = new DevExpress.XtraEditors.SimpleButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.txtCaptchaAlani = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.linkLblSanalKlavye = new System.Windows.Forms.LinkLabel();
            this.simpleBtnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.linkLblSifreDegistir = new System.Windows.Forms.LinkLabel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mTxtTCno = new System.Windows.Forms.MaskedTextBox();
            this.txtEdevlet = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleBtrCikisYap
            // 
            this.simpleBtrCikisYap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleBtrCikisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtrCikisYap.ImageOptions.Image")));
            this.simpleBtrCikisYap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleBtrCikisYap.Location = new System.Drawing.Point(1965, 12);
            this.simpleBtrCikisYap.Name = "simpleBtrCikisYap";
            this.simpleBtrCikisYap.Size = new System.Drawing.Size(69, 69);
            this.simpleBtrCikisYap.TabIndex = 0;
            this.simpleBtrCikisYap.Click += new System.EventHandler(this.simpleBtrCikisYap_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel1.Controls.Add(this.lblRobot);
            this.Panel1.Controls.Add(this.txtCaptchaAlani);
            this.Panel1.Controls.Add(this.lblCaptcha);
            this.Panel1.Controls.Add(this.linkLblSanalKlavye);
            this.Panel1.Controls.Add(this.simpleBtnGirisYap);
            this.Panel1.Controls.Add(this.linkLblSifreDegistir);
            this.Panel1.Controls.Add(this.labelControl3);
            this.Panel1.Controls.Add(this.labelControl2);
            this.Panel1.Controls.Add(this.labelControl1);
            this.Panel1.Controls.Add(this.mTxtTCno);
            this.Panel1.Controls.Add(this.txtEdevlet);
            this.Panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Panel1.Location = new System.Drawing.Point(710, 220);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(581, 585);
            this.Panel1.TabIndex = 1;
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRobot.Location = new System.Drawing.Point(115, 267);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(368, 29);
            this.lblRobot.TabIndex = 9;
            this.lblRobot.Text = "Robot olmadığınızı kanıtlayın ";
            // 
            // txtCaptchaAlani
            // 
            this.txtCaptchaAlani.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCaptchaAlani.Location = new System.Drawing.Point(222, 333);
            this.txtCaptchaAlani.Name = "txtCaptchaAlani";
            this.txtCaptchaAlani.Size = new System.Drawing.Size(167, 35);
            this.txtCaptchaAlani.TabIndex = 2;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaptcha.Location = new System.Drawing.Point(99, 339);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(85, 29);
            this.lblCaptcha.TabIndex = 2;
            this.lblCaptcha.Text = "label1";
            // 
            // linkLblSanalKlavye
            // 
            this.linkLblSanalKlavye.AutoSize = true;
            this.linkLblSanalKlavye.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblSanalKlavye.Location = new System.Drawing.Point(410, 186);
            this.linkLblSanalKlavye.Name = "linkLblSanalKlavye";
            this.linkLblSanalKlavye.Size = new System.Drawing.Size(147, 29);
            this.linkLblSanalKlavye.TabIndex = 8;
            this.linkLblSanalKlavye.TabStop = true;
            this.linkLblSanalKlavye.Text = "Sanal Klavye";
            this.linkLblSanalKlavye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSanalKlavye_LinkClicked);
            // 
            // simpleBtnGirisYap
            // 
            this.simpleBtnGirisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtnGirisYap.Appearance.Options.UseFont = true;
            this.simpleBtnGirisYap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleBtnGirisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnGirisYap.ImageOptions.Image")));
            this.simpleBtnGirisYap.Location = new System.Drawing.Point(41, 395);
            this.simpleBtnGirisYap.Name = "simpleBtnGirisYap";
            this.simpleBtnGirisYap.Size = new System.Drawing.Size(516, 87);
            this.simpleBtnGirisYap.TabIndex = 7;
            this.simpleBtnGirisYap.Text = "Sisteme Giriş Yap";
            this.simpleBtnGirisYap.Click += new System.EventHandler(this.simpleBtnGirisYap_Click);
            // 
            // linkLblSifreDegistir
            // 
            this.linkLblSifreDegistir.AutoSize = true;
            this.linkLblSifreDegistir.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblSifreDegistir.Location = new System.Drawing.Point(181, 510);
            this.linkLblSifreDegistir.Name = "linkLblSifreDegistir";
            this.linkLblSifreDegistir.Size = new System.Drawing.Size(218, 34);
            this.linkLblSifreDegistir.TabIndex = 6;
            this.linkLblSifreDegistir.TabStop = true;
            this.linkLblSifreDegistir.Text = "Şifremi Unuttum";
            this.linkLblSifreDegistir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSifreDegistir_LinkClicked);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(454, 63);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "AHBS Giriş Ekranı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 28);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "e-Devlet Şifresi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 163);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 28);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "TC  Kimlik No :";
            // 
            // mTxtTCno
            // 
            this.mTxtTCno.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mTxtTCno.Location = new System.Drawing.Point(222, 160);
            this.mTxtTCno.Mask = "00000000000";
            this.mTxtTCno.Name = "mTxtTCno";
            this.mTxtTCno.Size = new System.Drawing.Size(167, 35);
            this.mTxtTCno.TabIndex = 2;
            this.mTxtTCno.Text = "00000000000";
            this.mTxtTCno.ValidatingType = typeof(int);
            // 
            // txtEdevlet
            // 
            this.txtEdevlet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdevlet.Location = new System.Drawing.Point(222, 217);
            this.txtEdevlet.Name = "txtEdevlet";
            this.txtEdevlet.Size = new System.Drawing.Size(167, 35);
            this.txtEdevlet.TabIndex = 1;
            this.txtEdevlet.Text = "1234";
            this.txtEdevlet.UseSystemPasswordChar = true;
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1942, 833);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.simpleBtrCikisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoktorGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDoktorGiris_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleBtrCikisYap;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox txtEdevlet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox mTxtTCno;
        private System.Windows.Forms.LinkLabel linkLblSanalKlavye;
        private DevExpress.XtraEditors.SimpleButton simpleBtnGirisYap;
        private System.Windows.Forms.LinkLabel linkLblSifreDegistir;
        private System.Windows.Forms.TextBox txtCaptchaAlani;
        private System.Windows.Forms.Label lblRobot;
        public System.Windows.Forms.Label lblCaptcha;
    }
}