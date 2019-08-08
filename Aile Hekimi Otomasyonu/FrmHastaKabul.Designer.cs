namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmHastaKabul
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
            this.lblAnlıkBekleyen = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlTamamlananMuayene = new DevExpress.XtraGrid.GridControl();
            this.gridViewTamamlanan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtEdtMazeret = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbyonlendir = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sBtnSiradakilerYonlendir = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnBeklemeEkran = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewAnlikBekleyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlAnlikBekleyen = new DevExpress.XtraGrid.GridControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTamamlananMuayene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTamamlanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMazeret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnlikBekleyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnlikBekleyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnlıkBekleyen
            // 
            this.lblAnlıkBekleyen.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnlıkBekleyen.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAnlıkBekleyen.Appearance.Options.UseFont = true;
            this.lblAnlıkBekleyen.Appearance.Options.UseForeColor = true;
            this.lblAnlıkBekleyen.Location = new System.Drawing.Point(778, 2);
            this.lblAnlıkBekleyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAnlıkBekleyen.Name = "lblAnlıkBekleyen";
            this.lblAnlıkBekleyen.Size = new System.Drawing.Size(451, 45);
            this.lblAnlıkBekleyen.TabIndex = 0;
            this.lblAnlıkBekleyen.Text = "--- Anlık Bekleyenler --- ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2033, 60);
            this.panel1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(828, 6);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(402, 45);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "--- Anlık Bekleyen --- ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 17);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(3, 430);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2033, 60);
            this.panel2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(703, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(597, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "--- Tamamlanan Muayeneler --- ";
            // 
            // gridControlTamamlananMuayene
            // 
            this.gridControlTamamlananMuayene.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlTamamlananMuayene.Location = new System.Drawing.Point(3, 481);
            this.gridControlTamamlananMuayene.MainView = this.gridViewTamamlanan;
            this.gridControlTamamlananMuayene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlTamamlananMuayene.Name = "gridControlTamamlananMuayene";
            this.gridControlTamamlananMuayene.Size = new System.Drawing.Size(2065, 382);
            this.gridControlTamamlananMuayene.TabIndex = 3;
            this.gridControlTamamlananMuayene.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTamamlanan});
            // 
            // gridViewTamamlanan
            // 
            this.gridViewTamamlanan.GridControl = this.gridControlTamamlananMuayene;
            this.gridViewTamamlanan.Name = "gridViewTamamlanan";
            this.gridViewTamamlanan.OptionsView.ShowGroupPanel = false;
            this.gridViewTamamlanan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTamamlanan_FocusedRowChanged);
            // 
            // txtEdtMazeret
            // 
            this.txtEdtMazeret.Location = new System.Drawing.Point(324, 16);
            this.txtEdtMazeret.Name = "txtEdtMazeret";
            this.txtEdtMazeret.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtMazeret.Properties.Appearance.Options.UseFont = true;
            this.txtEdtMazeret.Size = new System.Drawing.Size(199, 40);
            this.txtEdtMazeret.TabIndex = 5;
            this.txtEdtMazeret.TextChanged += new System.EventHandler(this.txtEdtMazeret_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(99, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(197, 33);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mazereti Giriniz : ";
            // 
            // cmbyonlendir
            // 
            this.cmbyonlendir.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbyonlendir.FormattingEnabled = true;
            this.cmbyonlendir.Location = new System.Drawing.Point(1280, 11);
            this.cmbyonlendir.Name = "cmbyonlendir";
            this.cmbyonlendir.Size = new System.Drawing.Size(266, 41);
            this.cmbyonlendir.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(987, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(264, 33);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Yönlendirilecek Doktor :";
            // 
            // sBtnSiradakilerYonlendir
            // 
            this.sBtnSiradakilerYonlendir.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F);
            this.sBtnSiradakilerYonlendir.Appearance.Options.UseFont = true;
            this.sBtnSiradakilerYonlendir.Location = new System.Drawing.Point(1570, 4);
            this.sBtnSiradakilerYonlendir.Name = "sBtnSiradakilerYonlendir";
            this.sBtnSiradakilerYonlendir.Size = new System.Drawing.Size(299, 58);
            this.sBtnSiradakilerYonlendir.TabIndex = 9;
            this.sBtnSiradakilerYonlendir.Text = "Sıradakileri Yönlendir\r\n";
            // 
            // sBtnBeklemeEkran
            // 
            this.sBtnBeklemeEkran.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F);
            this.sBtnBeklemeEkran.Appearance.Options.UseFont = true;
            this.sBtnBeklemeEkran.Enabled = false;
            this.sBtnBeklemeEkran.Location = new System.Drawing.Point(553, 4);
            this.sBtnBeklemeEkran.Name = "sBtnBeklemeEkran";
            this.sBtnBeklemeEkran.Size = new System.Drawing.Size(369, 58);
            this.sBtnBeklemeEkran.TabIndex = 10;
            this.sBtnBeklemeEkran.Text = "Bekleme Ekranını Aç";
            this.sBtnBeklemeEkran.Click += new System.EventHandler(this.sBtnBeklemeEkran_Click);
            // 
            // gridViewAnlikBekleyen
            // 
            this.gridViewAnlikBekleyen.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridViewAnlikBekleyen.Appearance.Row.Options.UseFont = true;
            this.gridViewAnlikBekleyen.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridViewAnlikBekleyen.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewAnlikBekleyen.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridViewAnlikBekleyen.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewAnlikBekleyen.GridControl = this.gridControlAnlikBekleyen;
            this.gridViewAnlikBekleyen.Name = "gridViewAnlikBekleyen";
            this.gridViewAnlikBekleyen.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAnlikBekleyen.OptionsView.ShowGroupPanel = false;
            this.gridViewAnlikBekleyen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewAnlikBekleyen_FocusedRowChanged);
            // 
            // gridControlAnlikBekleyen
            // 
            this.gridControlAnlikBekleyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlAnlikBekleyen.Location = new System.Drawing.Point(-37, 137);
            this.gridControlAnlikBekleyen.MainView = this.gridViewAnlikBekleyen;
            this.gridControlAnlikBekleyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlAnlikBekleyen.Name = "gridControlAnlikBekleyen";
            this.gridControlAnlikBekleyen.Size = new System.Drawing.Size(2087, 291);
            this.gridControlAnlikBekleyen.TabIndex = 4;
            this.gridControlAnlikBekleyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAnlikBekleyen});
            // 
            // FrmHastaKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1924, 857);
            this.ControlBox = false;
            this.Controls.Add(this.sBtnBeklemeEkran);
            this.Controls.Add(this.sBtnSiradakilerYonlendir);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmbyonlendir);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEdtMazeret);
            this.Controls.Add(this.gridControlAnlikBekleyen);
            this.Controls.Add(this.gridControlTamamlananMuayene);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHastaKabul";
            this.Text = "HASTA KABUL";
            this.Load += new System.EventHandler(this.FrmHastaKabul_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTamamlananMuayene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTamamlanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMazeret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnlikBekleyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnlikBekleyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblAnlıkBekleyen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.Label lblId;
        public DevExpress.XtraGrid.GridControl gridControlTamamlananMuayene;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewTamamlanan;
        private DevExpress.XtraEditors.TextEdit txtEdtMazeret;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbyonlendir;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sBtnSiradakilerYonlendir;
        private DevExpress.XtraEditors.SimpleButton sBtnBeklemeEkran;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewAnlikBekleyen;
        public DevExpress.XtraGrid.GridControl gridControlAnlikBekleyen;
    }
}