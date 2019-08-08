using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        FrmHastaKabul hk = new FrmHastaKabul();
        FrmDoktorPanel dp = new FrmDoktorPanel();
        OleDbConnection con;
        private void simpleBtnGirisYap_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(); // Acceess bağlantı nesnesi oluşturuyoruz.
            con.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBAhbsVeriTabani.mdb");
            //con.ConnectionString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBAhbsVeriTabani.accdb");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                OleDbCommand sorguGiris = new OleDbCommand("Select AhID,AhTCno, AhGirisSifre from TBLAileHekimiBilgileri where AhTCno='" + mTxtTCno.Text + "'and AhGirisSifre='" + txtEdevlet.Text + "'", con);   // Sql sorgumuzu yazıyoruz ve where şartımız ise TC no ile sifrenin uyuması.
                sorguGiris.ExecuteNonQuery();
                OleDbDataReader dr = sorguGiris.ExecuteReader();
                if (dr.Read())
                {
                    if (txtCaptchaAlani.Text == captcha)
                    {
                        dp.Show();
                        this.Hide();
                    }
                    else
                    {
                        HataMesajı();

                    }
                }
                else
                {
                    HataMesajı();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATALI GİRİŞ YAPILDI. LÜTFEN TEKRAR DENEYİNİZ./n EĞER GİRİŞ BİLGİLERİNİZDE HATA GÖRMÜYORSANIZ LÜTFEN SİSTEM SERVİSİNE HATAYI BİLDİRİNİZ. \n HATA KODU : " + ex.Message +
                   "", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hata için bilgi verildi ve sistemin dönderdiği hata mesaje belirtildi.
            }
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private  void HataMesajı()
        { 
            DialogResult evetHayır = MessageBox.Show("Hatalı TC Kimlik No Şifre veya güvenlik numarası  girildi. \n Lütfen tekrar deneyiniz. Eğer şifrenizi unuttuysanız Evet'e tıklayarak değiştirebilirsiniz." , "BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);  // Yapılan girişin TC no şifreden veya güvenlik numarasından kaynaklı olduğu belirtildi.
            if (evetHayır == DialogResult.Yes)
            {
                Process.Start("https://giris.turkiye.gov.tr/Giris/SifremiUnuttum");
            }
        }

        private void simpleBtrCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();  // X butonuna çıkış yetkisi verildi.
        }
        private void linkLblSanalKlavye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.StartupPath + "//osk.exe");
            mTxtTCno.Focus();
            //Sanal klavyeyi açar ve mTxtTCno'ya imleci focuslar.
        }

        private void linkLblSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://giris.turkiye.gov.tr/Giris/SifremiUnuttum");
            // Şifresini unutan doktorun eDevlet üzerinden değiştirebileveğini yani giriş şiresinin eDevlet şifresi ile aynı olduğu ve eDevlet doğrulamalırını yaparak şifresini değiştirebileceğini belirtiyoruz.
        }
        int i;
        string captcha = "";
        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            FrmHasta h = new FrmHasta();
            reCaptcha();
        }
        private void reCaptcha()//Güvenlik numarasının random olarak gelmesi için metot oluşturuyoruz.
        {
            Random r = new Random(); // random sınıfından r nesnesi üretiyoruz
            string[] karakterler = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};  // güvenlik numaramızda yer alacak karakterleri giriyoruz
            for (i = 0; i < 4; i++) // for döngüsü ile  random olarak aldığı karakterleri birleştiriyor
            {
                string a = karakterler[r.Next(0, karakterler.Length)]; //
                captcha += a; // a değişkenine gelen değer captcha değişkenine aktarıyoruz
            }
            lblCaptcha.Text = captcha;
            //for döngüsü ile birleştirilen karakterler labelde gösteriliyor.
        }
    }
}
