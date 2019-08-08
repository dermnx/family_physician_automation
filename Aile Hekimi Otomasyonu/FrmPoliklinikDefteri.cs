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
using System.Net.Mail;

namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmPoliklinikDefteri : Form
    {
        public FrmPoliklinikDefteri()
        {
            InitializeComponent();
        } ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        FrmDoktorPanel dp = new FrmDoktorPanel();
        private void FrmPoliklinikDefteri_Load(object sender, EventArgs e)
        {
            //GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engeeleyen kod satırları.
            gridViewPoliklinikDefteri.OptionsBehavior.Editable = false;
           
            db.connectOpen(); //veri tabanı class ile bağlanı açma. 
            listsPoliklinikDefter(); // ilstemee metodunu load ta çalıştırıyoruz.
            db.connectClose();//veri tabanı class ile bağlanı kapatma. 

            
        }

        private void listsPoliklinikDefter()
        {
            //veri tabanından polikilnik defteri için gerekli olan verileri metodumuz ile veri listeleme yapıyoruz. ŞArtımız ise Birey işlem panelinde olduğu gibi aynı aile hekim poliklniğinde kayıtlı olan insanlardır.
            string query = "Select * FROM TBLHastaBilgileri where AhpId=1";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridControlPoliklinikDefteri.DataSource = dt;
        }
        private void ikiTarihSorgulama()
        {
            string tarihBaslangic = dateEditBaslangic.EditValue.ToString();
            string tarihBitis = dateEditBitis.EditValue.ToString();

            string queryDate = "SELECT  AhpId,TCkimlikNo,HastaAd,HastaSoyad,Cinsiyet,DogumTarihi,Yas,AnneAdi,BabaAdi,KronikHastalık,KanGrubu,Kilo,Boy,SosyalGüvence,CepTelefonu,Adres FROM TBLHastaBilgileri WHERE SonAlinanRandevuTarihi >= '"+tarihBaslangic+ "'and SonAlinanRandevuTarihi <='"+tarihBitis+"'";
            OleDbDataReader readTarih = db.DBResult(queryDate);
            DataTable dtDate = new DataTable();
            dtDate.Load(readTarih);
            gridControlPoliklinikDefteri.DataSource = dtDate;
        }
       
        private void simpleBtnMailGonder_Click(object sender, EventArgs e)
        {
         
            try
            {
                MailMessage eRecete = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("dkahbs@gmail.com", "1907derman");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                eRecete.To.Add(txtEdtMail.Text);
                eRecete.From = new MailAddress("dkahbs@gmail.com");
                eRecete.Subject = "||  E-REÇETE BİLDİRİSİ  ||  00.NOlU SAĞLIK OCAĞI AİLE HEKİMLİĞİ";
                eRecete.Body = "E-reçete  kodunuz. " + labelControleRecete.Text + " GEÇMİŞ OLSUN.";
                istemci.Send(eRecete);
                MessageBox.Show("E-reçete mail adresine gönderildi.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilirken hata oluştu. /n Hata Kodu : "+ex.Message,"BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            simpleBtnMailGonder.Enabled = false;
            labelControleRecete.Text = "E-Reçete";
            labelControleRecete.Enabled = false;
        }
        private void gridViewPoliklinikDefteri_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridViewPoliklinikDefteri.GetDataRow(gridViewPoliklinikDefteri.FocusedRowHandle);
            txtEdtMail.Text = row[31].ToString();
        }

        private void simpleBtnEreceteVer_Click(object sender, EventArgs e)
        {
           receteKod();
        }

        private void receteKod()
        {
            labelControleRecete.Enabled = true;
            simpleBtnMailGonder.Enabled = true;
            int i;
            string captcha = "";

            Random r = new Random(); // random sınıfından r nesnesi üretiyoruz
            string[] karakterler = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            // güvenlik numaramızda yer alacak karakterleri giriyoruz
            for (i = 0; i < 8; i++) // for döngüsü ile  random olarak aldığı karakterleri birleştiriyor
            {
                string a = karakterler[r.Next(0, karakterler.Length)];
                captcha += a; // a değişkenine gelen değer captcha değişkenine aktarıyoruz
            }
            labelControleRecete.Text = captcha;
            //for döngüsü ile birleştirilen karakterler labelde gösteriliyor.
        }
        private void sBtnSorgula_Click(object sender, EventArgs e)
        {
            ikiTarihSorgulama();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                string query = "Select * FROM TBLHastaBilgileri where Yas<=0";
                OleDbDataReader read = db.DBResult(query);
                DataTable dt = new DataTable();
                dt.Load(read);
                gridControlPoliklinikDefteri.DataSource = dt;
            }
            else if (label1.Text == "2")
            {
                //string query = "Select * FROM TBLHastaBilgileri where Yas >0 and Yas <= 12";
                //OleDbDataReader read = db.DBResult(query);
                //DataTable dt = new DataTable();
                //dt.Load(read);
                //gridControlPoliklinikDefteri.DataSource = dt;
            }



        }
    }
}




















//public static string _OnayKodu = "";
//public bool OnayKoduGonder(string mail)
//{
//    bool sonuc = false;

//    string bizimMail = "mail.adresiniz@gmail.com";
//    string sifre = "mail şifresi";

//    Random rastgele = new Random();
//    string harfler = "ABCDEFGHIJKLMNOPRSTUVYZWX";
//    _OnayKodu = "";
//    for (int i = 0; i < 6; i++)
//    {
//        _OnayKodu += harfler[rastgele.Next(harfler.Length)];
//    }
//}