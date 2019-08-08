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
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
        }
        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            //GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engelleyen kod satırları.
            gridView1.OptionsBehavior.Editable = false;
            db.connectOpen(); //veritabanımızı cllass tan çağırırarak bağlantı açtık
            listsRandevular(); // listeleme metodumuzu çağırdık.
            db.connectClose(); //veritabanımızı cllass tan çağırırarak bağlantı kapattık
        }

        private void listsRandevular()
        {//metod ile randevu tablosunda bize gereken tabloları filtreliyerek listeleme komutunu yazdık.where şartımız randevu tarihinin ve randevu saatinin >0 olması yani >0 dan kastım içlerinde ver barındırması.
            string query = "SELECT TCkimlikNo, HastaAd,HastaSoyad,SonAlinanRandevuTarihi,SonAlinanRandevuSaati,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık FROM TBLHastaBilgileri Where SonAlinanRandevuSaati >0 and SonAlinanRandevuTarihi >0";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridControlRandevular.DataSource = dt;
        }
    }
}
