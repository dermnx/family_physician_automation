namespace Aile_Hekimi_Otomasyonu
{
    partial class FrmBireyİslemGnl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBireyİslemGnl));
            this.gridCntrlBireyler = new DevExpress.XtraGrid.GridControl();
            this.gridViewBireyİslem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupBoxEdtBireyBilgisi = new DevExpress.XtraEditors.GroupControl();
            this.lblctrlDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblCtrlYas = new DevExpress.XtraEditors.LabelControl();
            this.lblCtrlTarih = new DevExpress.XtraEditors.LabelControl();
            this.lblCtrlCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.lblCtrlSoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblCtrlAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupCtrlNotDegteri = new DevExpress.XtraEditors.GroupControl();
            this.simpleBtnNotKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.richTxtNot = new System.Windows.Forms.RichTextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sBtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtAra = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCntrlBireyler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBireyİslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxEdtBireyBilgisi)).BeginInit();
            this.GroupBoxEdtBireyBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlNotDegteri)).BeginInit();
            this.groupCtrlNotDegteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCntrlBireyler
            // 
            this.gridCntrlBireyler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            this.gridCntrlBireyler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCntrlBireyler.Location = new System.Drawing.Point(-4, 57);
            this.gridCntrlBireyler.MainView = this.gridViewBireyİslem;
            this.gridCntrlBireyler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCntrlBireyler.Name = "gridCntrlBireyler";
            this.gridCntrlBireyler.Size = new System.Drawing.Size(1651, 744);
            this.gridCntrlBireyler.TabIndex = 1;
            this.gridCntrlBireyler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBireyİslem});
            // 
            // gridViewBireyİslem
            // 
            this.gridViewBireyİslem.GridControl = this.gridCntrlBireyler;
            this.gridViewBireyİslem.Name = "gridViewBireyİslem";
            this.gridViewBireyİslem.OptionsView.ShowGroupPanel = false;
            this.gridViewBireyİslem.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBireyİslem_FocusedRowChanged);
            // 
            // GroupBoxEdtBireyBilgisi
            // 
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblctrlDurum);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblCtrlYas);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblCtrlTarih);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblCtrlCinsiyet);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblCtrlSoyad);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.lblCtrlAd);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl9);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl8);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl6);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl4);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl5);
            this.GroupBoxEdtBireyBilgisi.Controls.Add(this.labelControl3);
            this.GroupBoxEdtBireyBilgisi.Location = new System.Drawing.Point(13, 39);
            this.GroupBoxEdtBireyBilgisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxEdtBireyBilgisi.Name = "GroupBoxEdtBireyBilgisi";
            this.GroupBoxEdtBireyBilgisi.Size = new System.Drawing.Size(352, 359);
            this.GroupBoxEdtBireyBilgisi.TabIndex = 0;
            this.GroupBoxEdtBireyBilgisi.Text = "Birey Bilgisi";
            // 
            // lblctrlDurum
            // 
            this.lblctrlDurum.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblctrlDurum.Appearance.Options.UseFont = true;
            this.lblctrlDurum.Location = new System.Drawing.Point(185, 284);
            this.lblctrlDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblctrlDurum.Name = "lblctrlDurum";
            this.lblctrlDurum.Size = new System.Drawing.Size(66, 28);
            this.lblctrlDurum.TabIndex = 13;
            this.lblctrlDurum.Text = "durum";
            // 
            // lblCtrlYas
            // 
            this.lblCtrlYas.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCtrlYas.Appearance.Options.UseFont = true;
            this.lblCtrlYas.Location = new System.Drawing.Point(185, 233);
            this.lblCtrlYas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCtrlYas.Name = "lblCtrlYas";
            this.lblCtrlYas.Size = new System.Drawing.Size(33, 28);
            this.lblCtrlYas.TabIndex = 11;
            this.lblCtrlYas.Text = "yas";
            // 
            // lblCtrlTarih
            // 
            this.lblCtrlTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCtrlTarih.Appearance.Options.UseFont = true;
            this.lblCtrlTarih.Location = new System.Drawing.Point(197, 188);
            this.lblCtrlTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCtrlTarih.Name = "lblCtrlTarih";
            this.lblCtrlTarih.Size = new System.Drawing.Size(46, 28);
            this.lblCtrlTarih.TabIndex = 9;
            this.lblCtrlTarih.Text = "tarih";
            // 
            // lblCtrlCinsiyet
            // 
            this.lblCtrlCinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCtrlCinsiyet.Appearance.Options.UseFont = true;
            this.lblCtrlCinsiyet.Location = new System.Drawing.Point(185, 146);
            this.lblCtrlCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCtrlCinsiyet.Name = "lblCtrlCinsiyet";
            this.lblCtrlCinsiyet.Size = new System.Drawing.Size(75, 28);
            this.lblCtrlCinsiyet.TabIndex = 7;
            this.lblCtrlCinsiyet.Text = "cinsiyet";
            // 
            // lblCtrlSoyad
            // 
            this.lblCtrlSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCtrlSoyad.Appearance.Options.UseFont = true;
            this.lblCtrlSoyad.Location = new System.Drawing.Point(185, 100);
            this.lblCtrlSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCtrlSoyad.Name = "lblCtrlSoyad";
            this.lblCtrlSoyad.Size = new System.Drawing.Size(58, 28);
            this.lblCtrlSoyad.TabIndex = 5;
            this.lblCtrlSoyad.Text = "soyad";
            // 
            // lblCtrlAd
            // 
            this.lblCtrlAd.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCtrlAd.Appearance.Options.UseFont = true;
            this.lblCtrlAd.Location = new System.Drawing.Point(185, 54);
            this.lblCtrlAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCtrlAd.Name = "lblCtrlAd";
            this.lblCtrlAd.Size = new System.Drawing.Size(25, 28);
            this.lblCtrlAd.TabIndex = 3;
            this.lblCtrlAd.Text = "ad";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(84, 278);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 28);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Durum :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(119, 233);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 28);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Yaş :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 188);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(151, 28);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Doğum Tarihi :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(75, 143);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 28);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Cinsiyet :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(92, 98);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 28);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Soyad :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(127, 54);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 28);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ad :";
            // 
            // groupCtrlNotDegteri
            // 
            this.groupCtrlNotDegteri.Controls.Add(this.simpleBtnNotKaydet);
            this.groupCtrlNotDegteri.Controls.Add(this.richTxtNot);
            this.groupCtrlNotDegteri.Location = new System.Drawing.Point(5, 446);
            this.groupCtrlNotDegteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupCtrlNotDegteri.Name = "groupCtrlNotDegteri";
            this.groupCtrlNotDegteri.Size = new System.Drawing.Size(379, 329);
            this.groupCtrlNotDegteri.TabIndex = 1;
            this.groupCtrlNotDegteri.Text = "Not Defteri";
            // 
            // simpleBtnNotKaydet
            // 
            this.simpleBtnNotKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleBtnNotKaydet.Appearance.Options.UseFont = true;
            this.simpleBtnNotKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleBtnNotKaydet.ImageOptions.Image")));
            this.simpleBtnNotKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.simpleBtnNotKaydet.Location = new System.Drawing.Point(8, 265);
            this.simpleBtnNotKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleBtnNotKaydet.Name = "simpleBtnNotKaydet";
            this.simpleBtnNotKaydet.Size = new System.Drawing.Size(369, 57);
            this.simpleBtnNotKaydet.TabIndex = 1;
            this.simpleBtnNotKaydet.Text = "Notu Kaydet";
            // 
            // richTxtNot
            // 
            this.richTxtNot.Location = new System.Drawing.Point(12, 28);
            this.richTxtNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTxtNot.Name = "richTxtNot";
            this.richTxtNot.Size = new System.Drawing.Size(361, 230);
            this.richTxtNot.TabIndex = 0;
            this.richTxtNot.Text = "";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupCtrlNotDegteri);
            this.panelControl1.Controls.Add(this.GroupBoxEdtBireyBilgisi);
            this.panelControl1.Location = new System.Drawing.Point(1652, 12);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(389, 780);
            this.panelControl1.TabIndex = 0;
            // 
            // sBtnAra
            // 
            this.sBtnAra.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F);
            this.sBtnAra.Appearance.Options.UseFont = true;
            this.sBtnAra.Enabled = false;
            this.sBtnAra.Location = new System.Drawing.Point(1112, 9);
            this.sBtnAra.Name = "sBtnAra";
            this.sBtnAra.Size = new System.Drawing.Size(369, 40);
            this.sBtnAra.TabIndex = 13;
            this.sBtnAra.Text = "Ara";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(692, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 33);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Ad\'a göre ara : ";
            // 
            // txtEdtAra
            // 
            this.txtEdtAra.EditValue = "";
            this.txtEdtAra.Location = new System.Drawing.Point(875, 12);
            this.txtEdtAra.Name = "txtEdtAra";
            this.txtEdtAra.Properties.Appearance.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtAra.Properties.Appearance.Options.UseFont = true;
            this.txtEdtAra.Size = new System.Drawing.Size(199, 40);
            this.txtEdtAra.TabIndex = 11;
            this.txtEdtAra.EditValueChanged += new System.EventHandler(this.txtEdtAra_EditValueChanged);
            // 
            // FrmBireyİslemGnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 804);
            this.Controls.Add(this.sBtnAra);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEdtAra);
            this.Controls.Add(this.gridCntrlBireyler);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBireyİslemGnl";
            this.Text = "BİREY İŞLEM";
            this.Load += new System.EventHandler(this.FrmBireyİslemGnl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCntrlBireyler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBireyİslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxEdtBireyBilgisi)).EndInit();
            this.GroupBoxEdtBireyBilgisi.ResumeLayout(false);
            this.GroupBoxEdtBireyBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlNotDegteri)).EndInit();
            this.groupCtrlNotDegteri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl GroupBoxEdtBireyBilgisi;
        private DevExpress.XtraEditors.LabelControl lblctrlDurum;
        private DevExpress.XtraEditors.LabelControl lblCtrlYas;
        private DevExpress.XtraEditors.LabelControl lblCtrlTarih;
        private DevExpress.XtraEditors.LabelControl lblCtrlCinsiyet;
        private DevExpress.XtraEditors.LabelControl lblCtrlSoyad;
        private DevExpress.XtraEditors.LabelControl lblCtrlAd;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupCtrlNotDegteri;
        private DevExpress.XtraEditors.SimpleButton simpleBtnNotKaydet;
        private System.Windows.Forms.RichTextBox richTxtNot;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl gridCntrlBireyler;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewBireyİslem;
        private DevExpress.XtraEditors.SimpleButton sBtnAra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtAra;
    }
}