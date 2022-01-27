using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REM_FIT.Formlar;

namespace REM_FIT.Formlar
{
    public partial class FrmKaloriTakipSayfasi : Form
    {
        public FrmKaloriTakipSayfasi()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 5;
        }

        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            FrmKahvalti frmKahvalti = new FrmKahvalti();
            frmKahvalti.Show();
            this.Hide();
        }

        private void btnOgle_Click(object sender, EventArgs e)
        {
            FrmOglenYemegi frmOglenYemegi = new FrmOglenYemegi();
            frmOglenYemegi.Show();
            this.Hide();
        }

        private void btnAksam_Click(object sender, EventArgs e)
        {
            FrmAksamYemegi frmAksamYemegi = new FrmAksamYemegi();
            frmAksamYemegi.Show();
            this.Hide();
        }

        private void btnAraOgun_Click(object sender, EventArgs e)
        {
            FrmAraOgun frmAraOgun = new FrmAraOgun();
            frmAraOgun.Show();
            this.Hide();
        }

        private void btnKaçKalori_Click(object sender, EventArgs e)
        {
            FrmKaloriArama frmKaloriArama = new FrmKaloriArama();
            frmKaloriArama.Show();
            this.Hide();
        }
        RemFitKaloriEntitiesSon db;
        private void FrmKaloriTakipSayfasi_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
        }

        private void btnKaloriTakip_Click(object sender, EventArgs e)
        {
            FrmKaloriTakipSayfasi frmtakip = new FrmKaloriTakipSayfasi();
            frmtakip.Show();
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

        private void btnUzmanaSor_Click(object sender, EventArgs e)
        {
            FrmUzmanaSor frmUzmanaSor = new FrmUzmanaSor();
            frmUzmanaSor.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
            double GunlukKaloriIhtiyacı = db.Kullanıcılar.Where(x => x.EMail == Form4.email).FirstOrDefault().GünlülKaloriIhtiyacı;
            int userID = db.Kullanıcılar.Where(x => x.EMail == Form4.email).FirstOrDefault().UserID;          

            var itemsInCart = (from o in db.TüketildiğiÖğün
                               where o.UserID_UserID == userID && o.TükedildiğiTarih.Day == DateTime.Now.Day && o.TükedildiğiTarih.Year == DateTime.Now.Year
                               select new { o.Kalori }
                  ).ToList();
            var sum = itemsInCart.Select(c => c.Kalori).Sum();
            lblAlınanKalori.Text = sum.ToString();
            lblKalanKalori.Text = (GunlukKaloriIhtiyacı - Convert.ToDouble(lblAlınanKalori.Text)).ToString();
            double var = Convert.ToInt32(100 * Convert.ToDouble(lblAlınanKalori.Text) / Convert.ToDouble(GunlukKaloriIhtiyacı));

            if (var>100)
            {
                MessageBox.Show("Günlük Almanız Gereken Kaloriden Fazla Değer Aldınız");
                bunifuCircleProgressbar1.Value = 100;
            }
            else if (var<100)
            {
                bunifuCircleProgressbar1.Value = Convert.ToInt32(var);
            }
           
            //var = 100;


            //bunifuCircleProgressbar1.Value = Convert.ToInt32(100*Convert.ToDouble(lblAlınanKalori.Text) / Convert.ToDouble(GunlukKaloriIhtiyacı));

            //if (bunifuCircleProgressbar1.Value>GunlukKaloriIhtiyacı)
            //{
            //    MessageBox.Show("Günlük Kalori İhtiyacınızı Aştınız");
            //}


        }
    }
}
