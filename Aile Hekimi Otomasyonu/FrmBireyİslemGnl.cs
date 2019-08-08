using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Access kütüphanesini çağırıyoruz.

namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmBireyİslemGnl : Form
    {
        public FrmBireyİslemGnl()
        {
            InitializeComponent();
        }
        //Veritabanı classımızı çağırarak nesnesini oluşturduk ve formumuza dahil ettik.
        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();
        private void FrmBireyİslemGnl_Load(object sender, EventArgs e)
        {
            
        //   this.gridViewBireyİslem.OptionsView.ShowAutoFilterRow = true;  //gridview sütün olarak arama.
            //GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engeeleyen kod satırları.
            gridViewBireyİslem.OptionsBehavior.Editable = false;
            db.connectOpen();  //Veritabanı bağlantı açma.
            try
            {
                listsBireyİslem();  //listeleme metodunu load event'ında çağırıyoruz ve listeletiyoruz.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanına erişilemedi. \n HATA KODU : " + ex.Message +
                                  "\n hata ile karşılaşmaya devam ederseinz lütfen destek ekibine başvurunuz.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hata için bilgi verildi ve sistemin dönderdiği hata mesaje belirtildi.
            }
            db.connectClose();// veri tabanı bağlantı kapatma
        //    gridViewBireyİslem.Columns["HastaAd"].Summary.Add(DevExpress.Data.SummaryItemType.Count, "HastaAd", "{0}");
        }
        private void listsBireyİslem()
        {//Birey işlem tablosu için gerekli olan komut ile veritabanımızdan verileri çekecek olan metodumuz. where şartımız aynı aile hekimi polikliniğinde olmaları.  
            string query = "Select HastaAd,HastaSoyad,DogumTarihi,Cinsiyet,AnneAdi,BabaAdi,KanGrubu,SosyalGüvence,KronikHastalık, HastaDurum FROM TBLHastaBilgileri where AhpId=1";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridCntrlBireyler.DataSource = dt;
        }
        
        private void gridViewBireyİslem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridViewBireyİslem.GetDataRow(gridViewBireyİslem.FocusedRowHandle);
            lblCtrlAd.Text = row[0].ToString();
            lblCtrlSoyad.Text = row[1].ToString();
            lblCtrlTarih.Text = row[2].ToString();
            lblCtrlCinsiyet.Text = row[3].ToString();
            lblctrlDurum.Text = row[9].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEdtAra_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}