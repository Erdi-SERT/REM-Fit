using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REM_FIT.Formlar
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void btnUzmanaSor_Click(object sender, EventArgs e)
        {
            FrmUzmanaSor frmUzmanaSor = new FrmUzmanaSor();
            frmUzmanaSor.Show();
            this.Hide();
        }
      
        private void btnKiyasRaporu_Click(object sender, EventArgs e)
        {
            FrmKiyasRaporu frmKiyasRaporu = new FrmKiyasRaporu();
            frmKiyasRaporu.Show();
            this.Hide();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            FrmYemekCesidiRaporu frmYemekCesidi = new FrmYemekCesidiRaporu();
            frmYemekCesidi.Show();
            this.Hide();
        }

        private void btnKaloriTakip_Click_1(object sender, EventArgs e)
        {
            FrmKaloriTakipSayfasi frmtakip = new FrmKaloriTakipSayfasi();
            frmtakip.Show();
            this.Hide();
        }

        private void btnKaçKalori_Click_1(object sender, EventArgs e)
        {
            FrmKaloriArama frmKaloriArama = new FrmKaloriArama();
            frmKaloriArama.Show();
            this.Hide();
        }

        private void btnSuTakibi_Click_1(object sender, EventArgs e)
        {
            FrmSuTakibi frmSuTakip = new FrmSuTakibi();
            frmSuTakip.Show();
            this.Hide();
        }

        private void btnTarifler_Click_1(object sender, EventArgs e)
        {
            FrmTarifler frmTarifler = new FrmTarifler();
            frmTarifler.Show();
            this.Hide();
        }

        private void btnRaporlar_Click_1(object sender, EventArgs e)
        {
            FrmRaporlar frmRaporlar = new FrmRaporlar();
            frmRaporlar.Show();
            this.Hide();
        }
    }
}
