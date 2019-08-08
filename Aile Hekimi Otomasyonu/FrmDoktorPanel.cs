using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmDoktorPanel : RibbonForm
    {
        public FrmDoktorPanel()
        {
            InitializeComponent();
        }
        FrmBireyİslemGnl bi;
        FrmHastaKabul hk;
        FrmPoliklinikDefteri pd;
        FrmRandevu rd;
        FrmAileİslemleri ai;
        Frmİstatistik ist;
        FrmVeriİslem vi;
        FrmProgramAyarları pa;
        FrmBeklemeEkran be;
        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        private void Form1_Load(object sender, EventArgs e)
        {////Combobox'a veri çekme
         //////////
         ///
            
            db.connectOpen();
            ////////////////
            SıradakileriYazdirma();
            db.connectClose();
            /* Mustafa hoca Form hatası giderme kodu (ancak benim formuma uymadı)
            foreach (Form form in Application.OpenForms)
            {
                if (ribbonPageHastaKabul.GetType() == typeof(FrmDoktorPanel))
                {
                    hk.Activate();
                    hk.Show();
                    this.Close();
                    return;
                }
            }
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Frmİstatistik")
                {
                    form.Activate();
                    form.Show();
                    this.Close();
                    return;
                }
            }

            FrmDoktorPanel p = new FrmDoktorPanel();
            p.Show();
            */

            //Hasta Kabul Formu Formu Açma
            if (ribbonCntrl.SelectedPage == ribbonPageHastaKabul)
            {
                if (hk == null)
                {
                    hk = new FrmHastaKabul();
                    hk.MdiParent = this;
                    hk.Show();
                }
            }

            //Birey İşlem Formu Açmaw
            else if (ribbonCntrl.SelectedPage == ribbonPageBireyİslem)
            {
                if (bi == null)
                {
                    bi = new FrmBireyİslemGnl();
                    bi.MdiParent = this;
                    bi.Show();
                }
            }
            //Poliklinik Defteri Formu Açma
            else if (ribbonCntrl.SelectedPage == ribbonPagePoliklinikDefteri)
            {
                if (pd == null)
                {
                    pd = new FrmPoliklinikDefteri();
                    pd.MdiParent = this;
                    pd.Show();
                }
            }
            //Randevu Defteri Formu Açma
            else if (ribbonCntrl.SelectedPage == ribbonPageRandevu)
            {
                if (rd == null)
                {
                    rd = new FrmRandevu();
                    rd.MdiParent = this;
                    rd.Show();
                }
            }
            //Aile islemleri Formu Acma
            else if (ribbonCntrl.SelectedPage == ribbonPageAileİslemleri)
            {
                if (ai == null)
                {
                    ai = new FrmAileİslemleri();
                    ai.MdiParent = this;
                    ai.Show();
                }
            }
            //İstatistik Formu Acma
            else if (ribbonCntrl.SelectedPage == ribbonPageİstatistik)
            {
                if (ist == null)
                {
                    ist = new Frmİstatistik();
                    ist.MdiParent = this;
                    ist.Show();
                }
            }
            //Veri İslem Formu Acma
            else if (ribbonCntrl.SelectedPage == ribbonPageVeriİslem)
            {
                if (vi == null)
                {
                    vi = new FrmVeriİslem();
                    vi.MdiParent = this;
                    vi.Show();
                }
            }
            //Program Ayarları Formu Acma
            else if (ribbonCntrl.SelectedPage == ribbonPageProgramAyarları)
            {
                if (pa == null)
                {
                    pa = new FrmProgramAyarları();
                    pa.MdiParent = this;
                    pa.Show();
                }
            }

        }

        FrmKapiUstu ku = new FrmKapiUstu();

        private void barChckItmEkranAcKapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ku.Show();
        }

        private void barChckItmEkranAcKapa_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ku.Hide();
        }

        private void simpleBtnBeklemeGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            be = new FrmBeklemeEkran();
            be.Show();
        }

        private void barBtnItmBireySil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.connectOpen();
            try
            {
                //   if (hk.lblId.Text != null)
                //  { 
                string sorgu = "UPDATE TBLHastaBilgileri  SET HastaSilmeId=1 WHERE HastaID=" + hk.lblId.Text + "";
                db.DBCommand(sorgu);
                hk.listsAnlik();
                hk.listsmuayeneolanlar();
                db.connectClose();
                MessageBox.Show("Kayıt silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt silme işlemi başarısız.\nHata Kodu :" + ex.Message, "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        OleDbCommand komutMuayeneOlanlar;
        private void SıradakileriYazdirma()
        {

            string sorguAnlik = "SELECT COUNT(*) FROM TBLHastaBilgileri WHERE girisMuayene=0 and AileHekimiId=3 and HastaSilmeId=0";
            OleDbCommand komutAnlik = new OleDbCommand(sorguAnlik, db.con);
            lblSiradaki.Text = komutAnlik.ExecuteScalar().ToString() + " kişi vardır.";

            string sorguMuayeneOlanlar = "SELECT COUNT(*) FROM TBLHastaBilgileri WHERE girisMuayene=1 and AileHekimiId=3 and HastaSilmeId=0";
            komutMuayeneOlanlar = new OleDbCommand(sorguMuayeneOlanlar, db.con);
            lblMuayeneEdilmiş.Text = komutMuayeneOlanlar.ExecuteScalar().ToString() + " kişi vardır. ";

        }
        private void barBtnItmBireyCagır_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMuayene m = new FrmMuayene();
            m.Show();
        }

        private void bedtItmCmbYonlendir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // System.Diagnostics.Process.Start(@"" + Application.StartupPath + "SnippingTool.exe"); // Excel kütüphanesini eklediğimizde Application nesnesi Form kütüphanesi ile çakışmaktadır.
            System.Diagnostics.Process.Start(@"C:\Users\karat\Desktop\AileHekimiOtomasyonuTasarım\AileHekimiOtomasyonu\bin\Debug\SnippingTool.exe");
        
        }

        private void barBtnItemExceleGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string gun = DateTime.Now.ToString();
            try
            {
                // string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Bireyler Tablosu"+gun+".xls";
                string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\İstatistik Tablosu.xls"; // kaydedilecek konum ve kaydedilecek isim değişkeni.
                bi.gridViewBireyİslem.ExportToXls(dosyaKonumu);//kaydedilecek konumu değişkenini export nesnesine veriyoruz.
                DialogResult cevap = MessageBox.Show("Rapor oluşturuldu. Açmak için EVET'e tıklayınız. /n DosyaKonumu : " + dosyaKonumu + "", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//MessageBox tan gelen evet cevabını lede tutup yorumlamak için dialog cevap (dialogresult) aracını kullanıyoruz.
                if (cevap == DialogResult.Yes) // if ile gelen cevap yes ile yapacağı işlemi yorumluyoruz.
                {
                    System.Diagnostics.Process.Start(dosyaKonumu);// Excel rapporunu aç.
                }
            }
            catch (Exception ex) // eğer try boğundaki işlemlerden olabilecek tüm hataları algılar ve hatayı ex.Message olarak bise döndurur.
            {
                MessageBox.Show("Excel rapor dökümanı oluşturulamadı." + ex.Message, "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barBtnItmExcelGonderPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string gun = DateTime.Now.ToString();
            try
            {
                // string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Bireyler Tablosu"+gun+".xls";
                string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\İstatistik Tablosu.xls"; // kaydedilecek konum ve kaydedilecek isim değişkeni.
                pd.gridViewPoliklinikDefteri.ExportToXls(dosyaKonumu);//kaydedilecek konumu değişkenini export nesnesine veriyoruz.
                DialogResult cevap = MessageBox.Show("Rapor oluşturuldu. Açmak için EVET'e tıklayınız. /n DosyaKonumu : " + dosyaKonumu + "", "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//MessageBox tan gelen evet cevabını lede tutup yorumlamak için dialog cevap (dialogresult) aracını kullanıyoruz.
                if (cevap == DialogResult.Yes) // if ile gelen cevap yes ile yapacağı işlemi yorumluyoruz.
                {
                    System.Diagnostics.Process.Start(dosyaKonumu);// Excel rapporunu aç.
                }
            }
            catch (Exception ex) // eğer try boğundaki işlemlerden olabilecek tüm hataları algılar ve hatayı ex.Message olarak bise döndurur.
            {
                MessageBox.Show("Excel rapor dökümanı oluşturulamadı." + ex.Message, "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonCntrl_Click(object sender, EventArgs e)
        {

        }
        public int veri=0;
        private void barChckItmBebek_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 1;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmCocuk_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 2;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmErgen_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 3;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmGenc_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 4;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmYetiskin_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 5;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmYasli_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 6;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmKadin_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 7;
            pd.label1.Text = veri.ToString();
        }

        private void barChckItmErkek_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            veri = 8;
            pd.label1.Text = veri.ToString();
        }
    }
}