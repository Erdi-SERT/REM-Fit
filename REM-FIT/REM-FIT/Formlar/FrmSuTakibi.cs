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
    public partial class FrmSuTakibi : Form
    {
        public FrmSuTakibi()
        {
            InitializeComponent();
        }
        RemFitKaloriEntitiesSon db;
        private void FrmSuTakibi_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
            int userID1 = db.Kullanıcılar.Where(x => x.EMail == Form4.email).FirstOrDefault().UserID;
            double sonuc = 0;
            foreach (var item in db.TüketildiğiÖğün)
            {
                if (item.UserID_UserID == userID1)
                {
                    if (item.BesinID == 1)
                    {
                        if (item.TükedildiğiTarih.DayOfYear==DateTime.Now.DayOfYear)
                        {
                            sonuc += item.Miktarı;
                        }
                    }

                }

            }
            label4.Text = (sonuc * 0.25).ToString() + " Bugün Lt Su İçtiniz";

        }     

        private void btnKaloriTakip_Click_1(object sender, EventArgs e)
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

        private void btnUzmanaSor_Click(object sender, EventArgs e)
        {
            FrmUzmanaSor frmUzmanaSor = new FrmUzmanaSor();
            frmUzmanaSor.Show();
            this.Hide();
        }
    }
}
