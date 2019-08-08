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
    public partial class FrmAileİslemleri : Form
    {
        public FrmAileİslemleri()
        {
            InitializeComponent();
        }

        ClassAddDeleteUpdate db = new ClassAddDeleteUpdate();

        private void FrmAileİslemleri_Load(object sender, EventArgs e)
        {
            //GridControl üzerine düşen verilere direkt olarak gridcontrolden verilerde değişiklik yapmamızı engeeleyen kod satırları.
            gridView1.OptionsBehavior.Editable = false;

            db.connectOpen(); // class ile bağlanti açma 
            listsRandevular(); // listeleme metodunu load event'ında çalıştırıyoruz.
            db.connectClose(); // class ile bağlanti kapatma
        }

        private void listsRandevular()
        {//listeleme metodunda gerekli olan veriyi filtreleyip veri tabanı komut satırını çalıştırıyoruz.
            string query = "SELECT HastaSoyad,COUNT(*) as KişiSayısı From TBLHastaBilgileri GROUP BY HastaSoyad";
            OleDbDataReader read = db.DBResult(query);
            DataTable dt = new DataTable();
            dt.Load(read);
            gridControlAileler.DataSource = dt;
        }
    }
}
