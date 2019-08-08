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
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Controls;
namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmHastaKabul : Form
    {
        public FrmHastaKabul()
        {
            InitializeComponent();
        }
        //veritabanı Classımı Form'a dahil ettik. artık class'mızı nesne olarak kullanabilecağiz.
        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        FrmDoktorPanel dp = new FrmDoktorPanel();
        private void FrmHastaKabul_Load(object sender, EventArgs e)
        {

            //GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engeleyen kod satırları.
            gridViewAnlikBekleyen.OptionsBehavior.Editable = false;
            gridViewTamamlanan.OptionsBehavior.Editable = false;
            try
            {
                db.connectOpen();//Class nesnesi ile bağlanti açılışı.
                listsAnlik(); // metotlar olarak listeleme komutlarını çağırma
                listsmuayeneolanlar();
                OleDbCommand cmd = new OleDbCommand("Select AhAd, AhSoyad from TBLAileHekimiBilgileri",db.con);
              OleDbDataReader  dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbyonlendir.Items.Add(dr["AhAd"].ToString()+" "+dr["AhSoyad"].ToString());
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanına erişilemedi. \n HATA KODU : " + ex.Message +
                   "\n hata ile karşılaşmaya devam ederseinz lütfen destek ekibine başvurunuz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hata için bilgi verildi ve sistemin dönderdiği hata mesaje belirtildi.

            }
            //Class nesnesi ile bağlanti kapatma.
            db.connectClose();
        }
        public void listsmuayeneolanlar()
        {
            //Tamamlanam Muayeneleri gridcontrole listeleme metodu
            string queryBiten = "SELECT HastaID,TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık FROM TBLHastaBilgileri WHERE girisMuayene=1 and AileHekimiId=3 and HastaSilmeId=0";

            //string queryBiten = "SELECT TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık FROM TBLHastaBilgileri WHERE girisMuayene=1 and AileHekimiId='" + lblId.Text + "'";

            OleDbDataReader readBiten = db.DBResult(queryBiten);
            DataTable tableBiten = new DataTable();
            tableBiten.Load(readBiten);
            gridControlTamamlananMuayene.DataSource = tableBiten;
        }
        public void listsAnlik()
        {
            //Anlık bekleyenler gridcontrole listeleme metodu
            string queryAnlik = "SELECT HastaID,TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık FROM TBLHastaBilgileri WHERE girisMuayene=0 and AileHekimiId=3 and HastaSilmeId=0";

            //string queryAnlik = "SELECT TCkimlikNo, HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık FROM TBLHastaBilgileri WHERE girisMuayene=0 and AileHekimiId='" + lblId.Text + "'";

            OleDbDataReader readAnlik = db.DBResult(queryAnlik);
            DataTable tableAnlik = new DataTable();
            tableAnlik.Load(readAnlik);
            gridControlAnlikBekleyen.DataSource = tableAnlik;
        }
        ////////
        //GridView üzerinde tıklanan verinin HastaIdsini alır ve lblId'e aktarır
        private void gridViewAnlikBekleyen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblId.Text = gridViewAnlikBekleyen.GetFocusedRowCellValue("HastaID").ToString();
        }
        private void gridViewTamamlanan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblId.Text = gridViewTamamlanan.GetFocusedRowCellValue("HastaID").ToString();
        }
        FrmBeklemeEkran be = new FrmBeklemeEkran();
        private void sBtnBeklemeEkran_Click(object sender, EventArgs e)
        {
            be.mazeret = txtEdtMazeret.Text;
            be.Show();

            txtEdtMazeret.Text = "";
            sBtnBeklemeEkran.Enabled = false;
        }

        private void txtEdtMazeret_TextChanged(object sender, EventArgs e)
        {
            sBtnBeklemeEkran.Enabled = true;
        }
    }
}