namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmPoliklinikDefteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoliklinikDefteri));
            this.dateEditBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.lblId = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.sBtnSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControleRecete = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtMail = new DevExpress.XtraEditors.TextEdit();
            this.simpleBtnMailGonder = new DevExpress.XtraEditors.SimpleButton();
            this.simpleBtnSMSgonder = new DevExpress.XtraEditors.SimpleButton();
            this.simpleBtnEreceteVer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleBtnKisiAramaSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleBtnBitisSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleBtnBaslangicSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchControlKisiArama = new DevExpress.XtraEditors.SearchControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditBitis = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPoliklinikDefteri = new DevExpress.XtraGrid.GridControl();
            this.gridViewPoliklinikDefteri = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblId)).BeginInit();
            this.lblId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControlKisiArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPoliklinikDefteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoliklinikDefteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditBaslangic
            // 
            this.dateEditBaslangic.EditValue = null;
            this.dateEditBaslangic.Location = new System.Drawing.Point(173, 15);
            this.dateEditBaslangic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditBaslangic.Name = "dateEditBaslangic";
            this.dateEditBaslangic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditBaslangic.Properties.Appearance.Options.UseFont = true;
            this.dateEditBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBaslangic.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEditBaslangic.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBaslangic.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditBaslangic.Size = new System.Drawing.Size(161, 34);
            this.dateEditBaslangic.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Controls.Add(this.label1);
            this.lblId.Controls.Add(this.sBtnSorgula);
            this.lblId.Controls.Add(this.labelControleRecete);
            this.lblId.Controls.Add(this.txtEdtMail);
            this.lblId.Controls.Add(this.simpleBtnMailGonder);
            this.lblId.Controls.Add(this.simpleBtnSMSgonder);
            this.lblId.Controls.Add(this.simpleBtnEreceteVer);
            this.lblId.Controls.Add(this.simpleBtnKisiAramaSil);
            this.lblId.Controls.Add(this.simpleBtnBitisSil);
            this.lblId.Controls.Add(this.simpleBtnBaslangicSil);
            this.lblId.Controls.Add(this.labelControl3);
            this.lblId.Controls.Add(this.searchControlKisiArama);
            this.lblId.Controls.Add(this.labelControl2);
            this.lblId.Controls.Add(this.dateEditBitis);
            this.lblId.Controls.Add(this.labelControl1);
            this.lblId.Controls.Add(this.dateEditBaslangic);
            this.lblId.Location = new System.Drawing.Point(0, -2);
            this.lblId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(2035, 134);
            this.lblId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // sBtnSorgula
            // 
            this.sBtnSorgula.Location = new System.Drawing.Point(439, 20);
            this.sBtnSorgula.Name = "sBtnSorgula";
            this.sBtnSorgula.Size = new System.Drawing.Size(152, 96);
            this.sBtnSorgula.TabIndex = 17;
            this.sBtnSorgula.Text = "Sorgula";
            this.sBtnSorgula.Click += new System.EventHandler(this.sBtnSorgula_Click);
            // 
            // labelControleRecete
            // 
            this.labelControleRecete.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControleRecete.Appearance.Options.UseFont = true;
            this.labelControleRecete.Enabled = false;
            this.labelControleRecete.Location = new System.Drawing.Point(1263, 54);
            this.labelControleRecete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControleRecete.Name = "labelControleRecete";
            this.labelControleRecete.Size = new System.Drawing.Size(122, 33);
            this.labelControleRecete.TabIndex = 16;
            this.labelControleRecete.Text = "E-Reçete";
            // 
            // txtEdtMail
            // 
            this.txtEdtMail.Location = new System.Drawing.Point(1717, 57);
            this.txtEdtMail.Name = "txtEdtMail";
            this.txtEdtMail.Size = new System.Drawing.Size(125, 22);
            this.txtEdtMail.TabIndex = 15;
            // 
            // simpleBtnMailGonder
            // 
            this.simpleBtnMailGonder.Enabled = false;
            this.simpleBtnMailGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnMailGonder.ImageOptions.Image")));
            this.simpleBtnMailGonder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleBtnMailGonder.Location = new System.Drawing.Point(1576, 19);
            this.simpleBtnMailGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnMailGonder.Name = "simpleBtnMailGonder";
            this.simpleBtnMailGonder.Size = new System.Drawing.Size(135, 102);
            this.simpleBtnMailGonder.TabIndex = 14;
            this.simpleBtnMailGonder.Text = "E-Reçeteyi E-MAİL\r\nOlarak Gönder";
            this.simpleBtnMailGonder.Click += new System.EventHandler(this.simpleBtnMailGonder_Click);
            // 
            // simpleBtnSMSgonder
            // 
            this.simpleBtnSMSgonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnSMSgonder.ImageOptions.Image")));
            this.simpleBtnSMSgonder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleBtnSMSgonder.Location = new System.Drawing.Point(1449, 19);
            this.simpleBtnSMSgonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnSMSgonder.Name = "simpleBtnSMSgonder";
            this.simpleBtnSMSgonder.Size = new System.Drawing.Size(109, 102);
            this.simpleBtnSMSgonder.TabIndex = 13;
            this.simpleBtnSMSgonder.Text = "E-Reçeteyi SMS \r\nOlarak Gönder";
            // 
            // simpleBtnEreceteVer
            // 
            this.simpleBtnEreceteVer.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.simpleBtnEreceteVer.Appearance.Options.UseFont = true;
            this.simpleBtnEreceteVer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnEreceteVer.ImageOptions.Image")));
            this.simpleBtnEreceteVer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleBtnEreceteVer.Location = new System.Drawing.Point(1139, 17);
            this.simpleBtnEreceteVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnEreceteVer.Name = "simpleBtnEreceteVer";
            this.simpleBtnEreceteVer.Size = new System.Drawing.Size(93, 98);
            this.simpleBtnEreceteVer.TabIndex = 11;
            this.simpleBtnEreceteVer.Text = "E-Reçete\r\nVer";
            this.simpleBtnEreceteVer.Click += new System.EventHandler(this.simpleBtnEreceteVer_Click);
            // 
            // simpleBtnKisiAramaSil
            // 
            this.simpleBtnKisiAramaSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleBtnKisiAramaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnKisiAramaSil.ImageOptions.Image")));
            this.simpleBtnKisiAramaSil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleBtnKisiAramaSil.Location = new System.Drawing.Point(1075, 54);
            this.simpleBtnKisiAramaSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnKisiAramaSil.Name = "simpleBtnKisiAramaSil";
            this.simpleBtnKisiAramaSil.Size = new System.Drawing.Size(36, 30);
            this.simpleBtnKisiAramaSil.TabIndex = 9;
            // 
            // simpleBtnBitisSil
            // 
            this.simpleBtnBitisSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleBtnBitisSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnBitisSil.ImageOptions.Image")));
            this.simpleBtnBitisSil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleBtnBitisSil.Location = new System.Drawing.Point(340, 84);
            this.simpleBtnBitisSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnBitisSil.Name = "simpleBtnBitisSil";
            this.simpleBtnBitisSil.Size = new System.Drawing.Size(36, 33);
            this.simpleBtnBitisSil.TabIndex = 7;
            // 
            // simpleBtnBaslangicSil
            // 
            this.simpleBtnBaslangicSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleBtnBaslangicSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnBaslangicSil.ImageOptions.Image")));
            this.simpleBtnBaslangicSil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleBtnBaslangicSil.Location = new System.Drawing.Point(340, 18);
            this.simpleBtnBaslangicSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnBaslangicSil.Name = "simpleBtnBaslangicSil";
            this.simpleBtnBaslangicSil.Size = new System.Drawing.Size(36, 30);
            this.simpleBtnBaslangicSil.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(703, 57);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Kişi Arama :";
            // 
            // searchControlKisiArama
            // 
            this.searchControlKisiArama.Location = new System.Drawing.Point(817, 51);
            this.searchControlKisiArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControlKisiArama.Name = "searchControlKisiArama";
            this.searchControlKisiArama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchControlKisiArama.Properties.Appearance.Options.UseFont = true;
            this.searchControlKisiArama.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControlKisiArama.Size = new System.Drawing.Size(252, 34);
            this.searchControlKisiArama.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Bitiş Tarihi :";
            // 
            // dateEditBitis
            // 
            this.dateEditBitis.EditValue = null;
            this.dateEditBitis.Location = new System.Drawing.Point(173, 82);
            this.dateEditBitis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditBitis.Name = "dateEditBitis";
            this.dateEditBitis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditBitis.Properties.Appearance.Options.UseFont = true;
            this.dateEditBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBitis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEditBitis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditBitis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditBitis.Size = new System.Drawing.Size(161, 34);
            this.dateEditBitis.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Başlangıç Tarihi :";
            // 
            // gridControlPoliklinikDefteri
            // 
            this.gridControlPoliklinikDefteri.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPoliklinikDefteri.Location = new System.Drawing.Point(0, 123);
            this.gridControlPoliklinikDefteri.MainView = this.gridViewPoliklinikDefteri;
            this.gridControlPoliklinikDefteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPoliklinikDefteri.Name = "gridControlPoliklinikDefteri";
            this.gridControlPoliklinikDefteri.Size = new System.Drawing.Size(2309, 738);
            this.gridControlPoliklinikDefteri.TabIndex = 2;
            this.gridControlPoliklinikDefteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPoliklinikDefteri});
            // 
            // gridViewPoliklinikDefteri
            // 
            this.gridViewPoliklinikDefteri.GridControl = this.gridControlPoliklinikDefteri;
            this.gridViewPoliklinikDefteri.Name = "gridViewPoliklinikDefteri";
            this.gridViewPoliklinikDefteri.OptionsView.ShowGroupPanel = false;
            this.gridViewPoliklinikDefteri.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPoliklinikDefteri_FocusedRowChanged);
            // 
            // FrmPoliklinikDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 857);
            this.Controls.Add(this.gridControlPoliklinikDefteri);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPoliklinikDefteri";
            this.Text = "POLİKLİNİK DEFTERİ";
            this.Load += new System.EventHandler(this.FrmPoliklinikDefteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblId)).EndInit();
            this.lblId.ResumeLayout(false);
            this.lblId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControlKisiArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPoliklinikDefteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoliklinikDefteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEditBaslangic;
        private DevExpress.XtraEditors.SimpleButton simpleBtnBitisSil;
        private DevExpress.XtraEditors.SimpleButton simpleBtnBaslangicSil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchControl searchControlKisiArama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditBitis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleBtnKisiAramaSil;
        private DevExpress.XtraEditors.SimpleButton simpleBtnSMSgonder;
        private DevExpress.XtraEditors.SimpleButton simpleBtnEreceteVer;
        private DevExpress.XtraEditors.SimpleButton simpleBtnMailGonder;
        private DevExpress.XtraGrid.GridControl gridControlPoliklinikDefteri;
        private DevExpress.XtraEditors.TextEdit txtEdtMail;
        private DevExpress.XtraEditors.LabelControl labelControleRecete;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewPoliklinikDefteri;
        private DevExpress.XtraEditors.SimpleButton sBtnSorgula;
        public DevExpress.XtraEditors.PanelControl lblId;
        public System.Windows.Forms.Label label1;
    }
}