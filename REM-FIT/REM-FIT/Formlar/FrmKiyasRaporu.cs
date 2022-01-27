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
    public partial class FrmKiyasRaporu : Form
    {
        public FrmKiyasRaporu()
        {
            InitializeComponent();
        }
        RemFitKaloriEntitiesSon db;
        private void label1_Click(object sender, EventArgs e)
        {

        }       

        private void btnAylikRaporGetir_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail==Form4.email)
                {
                    dgvYenenGıdalar.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Month == DateTime.Now.Month && x.TükedildiğiTarih.Year == DateTime.Now.Year).Select(x => new
                    {
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                          Kalori = x.Kalori ,
                          TüketildiğiTarih=x.TükedildiğiTarih
                    }).ToList();                  

                }
            }
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    //double kalori1 = db.TüketildiğiÖğün;
                    dgvOgunlereGoreKaloriler.DataSource = db.TüketildiğiÖğün.GroupBy(x => new
                    {
                        x.TüketildiğiÖğün1,
                        //x.BesinAdı,
                        //x.Kalori,
                        //x.TükedildiğiTarih,
                       // x.Miktarı


                    }).Select(x => new
                    {
                        TüketildiğiÖğün = x.Key.TüketildiğiÖğün1,
                        //BesinAdı = x.Key.BesinAdı,
                       // Miktar = x.Count(),
                        Kalori = x.Sum(y => y.Kalori)

                    }).ToList();


                }
            }
        }

        private void btnHaftalikRaporGetir_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvYenenGıdalar.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Day>=((DateTime.Now.Day)-7) && x.TükedildiğiTarih.Day <= DateTime.Now.Day && x.TükedildiğiTarih.Year == DateTime.Now.Year).Select(x => new
                    {
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                        Kalori = x.Kalori,
                        TüketildiğiTarih = x.TükedildiğiTarih
                    }).ToList();

                }
            }
        }

        private void FrmKiyasRaporu_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
        }

        private void btnGünlükRapor_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvYenenGıdalar.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Day == DateTime.Now.Day && x.TükedildiğiTarih.Year == DateTime.Now.Year).Select(x => new
                    {
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                        Kalori = x.Kalori,
                        TüketildiğiTarih = x.TükedildiğiTarih
                    }).ToList();

                }
            }
        }

        private void btnKaloriTakip_Click_1(object sender, EventArgs e)
        {
            FrmKaloriTakipSayfasi frmtakip = new FrmKaloriTakipSayfasi();
            frmtakip.Show();
            this.Hide();
        }

        private void btnUzmanaSor_Click(object sender, EventArgs e)
        {
            FrmUzmanaSor frmUzmanaSor = new FrmUzmanaSor();
            frmUzmanaSor.Show();
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

        private void btnKiyasRaporu_Click(object sender, EventArgs e)
        {
            FrmKiyasRaporu frmKiyasRaporu = new FrmKiyasRaporu();
            frmKiyasRaporu.Show();
            this.Hide();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            FrmYemekCesidiRaporu frmYemekCesidiRaporu = new FrmYemekCesidiRaporu();
            frmYemekCesidiRaporu.Show();
            this.Hide();
        }
    }
}
