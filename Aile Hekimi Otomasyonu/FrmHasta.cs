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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            lblAltKayanYazi.Text = "Kaydınızı yaptıktan sonra sıranızı bekleme salonunda bekleyiniz.     ";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAltKayanYazi.Text = lblAltKayanYazi.Text.Substring(1) + lblAltKayanYazi.Text.Substring(0, 1);
        }
        private void mTxtTCno_TextAlignChanged(object sender, EventArgs e)
        {
           
        }

        private void mTxtTCno_SizeChanged(object sender, EventArgs e)
        {
          
        }
    }
}
