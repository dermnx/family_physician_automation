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
    public partial class FrmKapiUstu : Form
    {
        public FrmKapiUstu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAltKayanYazi.Text = lblAltKayanYazi.Text.Substring(1) + lblAltKayanYazi.Text.Substring(0, 1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKapiUstu_Load(object sender, EventArgs e)
        {
            lblAltKayanYazi.Text = "LÜTFEN ÇAĞIRILMADAN İÇERİ GİRMEYİNİZ!  ";
                timer1.Enabled = true;
        }

        private void lblAltKayanYazi_Click(object sender, EventArgs e)
        {

        }
    }
}
