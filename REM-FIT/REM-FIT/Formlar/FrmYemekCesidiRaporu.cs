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
    public partial class FrmYemekCesidiRaporu : Form
    {
        public FrmYemekCesidiRaporu()
        {
            InitializeComponent();           

        }
        RemFitKaloriEntitiesSon db;
        private void FrmYemekCesidi_Load(object sender, EventArgs e)
        {

            db = new RemFitKaloriEntitiesSon();
        }       

        private void btnBesinleriGetir_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvOgunlereGoreBesinler.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Month == DateTime.Now.Month && x.TükedildiğiTarih.Year == DateTime.Now.Year).Select(x => new
                    {
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,                        
                        TüketildiğiTarih = x.TükedildiğiTarih
                    }).ToList();

                }
            }
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    //double kalori1 = db.TüketildiğiÖğün;
                    dgvOgunlereGoreBesinler.DataSource = db.TüketildiğiÖğün.GroupBy(x => new
                    {
                        x.TüketildiğiÖğün1,
                        x.BesinAdı,
                        x.Kalori,
                        x.TükedildiğiTarih,
                        x.Miktarı


                    }).Select(x => new
                    {
                        TüketildiğiÖğün = x.Key.TüketildiğiÖğün1,
                        BesinAdı = x.Key.BesinAdı,
                        Miktar = x.Count(),
                        

                    }).ToList();


                }
            }
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

        private void btnKaloriTakip_Click(object sender, EventArgs e)
        {
            FrmKaloriTakipSayfasi frmtakip = new FrmKaloriTakipSayfasi();
            frmtakip.Show();
            this.Hide();
        }

        private void btnKaçKalori_Click(object sender, EventArgs e)
        {
            FrmKaloriArama frmKaloriArama = new FrmKaloriArama();
            frmKaloriArama.Show();
            this.Hide();
        }

        private void btnSuTakibi_Click(object sender, EventArgs e)
        {
            FrmSuTakibi frmSuTakip = new FrmSuTakibi();
            frmSuTakip.Show();
            this.Hide();
        }

        private void btnTarifler_Click(object sender, EventArgs e)
        {
            FrmTarifler frmTarifler = new FrmTarifler();
            frmTarifler.Show();
            this.Hide();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar frmRaporlar = new FrmRaporlar();
            frmRaporlar.Show();
            this.Hide();
        }
    }
}
