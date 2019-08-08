using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

//using Excel = Microsoft.Office.Interop.Excel;

namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmVeriİslem : Form
    {
        public FrmVeriİslem()
        {
            InitializeComponent();
        }

        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        private void FrmVeriİslem_Load(object sender, EventArgs e)
        {//GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engeleyen kod satırları.
            gridViewYeniEklenen.OptionsBehavior.Editable = false;
            gridViewTasinmis.OptionsBehavior.Editable = false;

            db.connectOpen();//veritabanı bağlantısı açma
            listsSonKayitlar(); //son kayıtları listeme metodunu çağırma
            listsKaydiSilinen(); // kaydı bulunulan polikilnğinden alınan hastaları görüntüleyen listenin metod ile çağırma
            db.connectClose(); // veritabanı bağlantısı kapatma
            labelControl13.Text = DateTime.Now.ToString();
        }
        private void listsSonKayitlar()
        {//veri işlemde son 15 kaydı ıd  değerine göre seçip listeleme.
            string query = "SELECT TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,Kilo,Boy,SosyalGüvence,KronikHastalık,DogumYeri,Adres,SonAlinanRandevuTarihi,HastaDurum FROM TBLHastaBilgileri Order BY HastaID DESC";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridCntrlYeniEklenen.DataSource = dt;
        }
        private void listsKaydiSilinen()
        {//Kaydı alınan hastaları görüntüleme metodu
            string querySilinen = "SELECT TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,Kilo,Boy,SosyalGüvence,KronikHastalık,DogumYeri,Adres,SonAlinanRandevuTarihi,HastaDurum FROM TBLHastaBilgileri WHERE HastaSilmeId=1";
            OleDbDataReader readSilinen = db.DBResult(querySilinen);
            DataTable dtSilinen = new DataTable();
            dtSilinen.Load(readSilinen);
            gridCntrlSilinen.DataSource = dtSilinen;

        }

        private void gridViewYeniEklenen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow rowVeriler = gridViewYeniEklenen.GetDataRow(gridViewYeniEklenen.FocusedRowHandle);
            Tasima(rowVeriler);
        }

        private void Tasima(DataRow row)
        {
            mTxtTCno.Text = row[0].ToString();
            txtAd.Text = row[1].ToString();
            txtSoyad.Text = row[2].ToString();
            txtDogumTarihi.Text = row[3].ToString();
            txtEditKilo.Text = row[8].ToString();
            txtEdtBoy.Text = row[9].ToString();
            cmbBxEtDogumYeri.Text = row[12].ToString();
            txtİkametYeri.Text = row[13].ToString();
            txtSonMuayene.Text = row[14].ToString();
        }

        private void gridViewTasinmis_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow rowTasinmis = gridViewTasinmis.GetDataRow(gridViewTasinmis.FocusedRowHandle);
            Tasima(rowTasinmis);
        }

        private void simpleBtnExcelYeni_Click(object sender, EventArgs e)
        {
            string gun= DateTime.Now.ToString();
            try
            {
                // string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Bireyler Tablosu"+gun+".xls";
                string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\İstatistik Tablosu.xls"; // kaydedilecek konum ve kaydedilecek isim değişkeni.
                gridViewYeniEklenen.ExportToXls(dosyaKonumu);//kaydedilecek konumu değişkenini export nesnesine veriyoruz.
              DialogResult cevap =  MessageBox.Show("Rapor oluşturuldu. Açmak için EVET'e tıklayınız. /n DosyaKonumu : "+dosyaKonumu+"","BİLGİLENDİRME",MessageBoxButtons.YesNo,MessageBoxIcon.Information);//MessageBox tan gelen evet cevabını lede tutup yorumlamak için dialog cevap (dialogresult) aracını kullanıyoruz.
                if (cevap == DialogResult.Yes) // if ile gelen cevap yes ile yapacağı işlemi yorumluyoruz.
                {
                    System.Diagnostics.Process.Start(dosyaKonumu);// Excel rapporunu aç.
                }
            }
            catch (Exception ex) // eğer try boğundaki işlemlerden olabilecek tüm hataları algılar ve hatayı ex.Message olarak bise döndurur.
            {
                MessageBox.Show("Excel rapor dökümanı oluşturulamadı."+ex.Message,"BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void simpleBtnExcelTasinmis_Click(object sender, EventArgs e)
        {
            string gun = DateTime.Now.ToString();
            try
            {
              
                // string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Bireyler Tablosu"+gun+".xls";
                string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Taşınmış / İlişkisi Kesilmiş Birey Tablosu.xls"; // kaydedilecek konum ve kaydedilecek isim değişkeni.
                gridViewTasinmis.ExportToXls(dosyaKonumu);//kaydedilecek konumu değişkenini export nesnesine veriyoruz.
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

        private void simpleBtnExceleAktar_Click(object sender, EventArgs e)
        {
    
        }
    }
}
