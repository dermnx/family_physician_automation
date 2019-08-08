using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aile_Hekimi_Otomasyonu
{
    public partial class FrmBeklemeEkran : Form
    {
        public FrmBeklemeEkran()
        {
            InitializeComponent();
        }
        public string mazeret = "";
        private void FrmBeklemeEkran_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblUstLutfen.Text = "--------------SAYGINIZDAN DOLAYI TEŞEKKÜR EDERİZ--------------";
            lblMazeret.Text = "DOKTOR "+mazeret+" DOLAYI";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUstLutfen.Text = lblUstLutfen.Text.Substring(1) + lblUstLutfen.Text.Substring(0,1);
            
        }
    }
}
