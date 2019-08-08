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
namespace Aile_Hekimi_Otomasyonu
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            db.connectOpen();// veri tabanı bağlantı açma class yardımı ile
            listsİstatistik(); // listeleme metodumuz load event'ında çalıştırıyoruz.
            db.connectClose();// veri tabanı bağlantı kapatma class yardımı ile
        }

        private void listsİstatistik()
        {//istatistik tablosunda gerekli olan verilerin filterelenerek listelenmesini sağlayan kod bloğun metodu.
            string query = "SELECT TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık,AileSıraNo,CiltNo,SeriNo,DogumYeri,MedeniDurum,Meslegi,CepTelefonu,EvTelefonu,Adres,SonAlinanRandevuTarihi FROM TBLHastaBilgileri";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridControlIstatistik.DataSource = dt;
        }

        private void simpleBtnExceleAktar_Click(object sender, EventArgs e)
        {
            string gun = DateTime.Now.ToString();
            try
            {
                // string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\Veri İslem Bireyler Tablosu"+gun+".xls";
                string dosyaKonumu = @"C:\Users\karat\Desktop\Aile Hekimi OtomasyonuTasarım\Excel Raporları\İstatistik Tablosu.xls"; // kaydedilecek konum ve kaydedilecek isim değişkeni.
                gridView1.ExportToXls(dosyaKonumu);//kaydedilecek konumu değişkenini export nesnesine veriyoruz.
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
    }
}
