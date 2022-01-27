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
    public partial class FrmKaloriArama : Form
    {
        public FrmKaloriArama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        RemFitKaloriEntitiesSon db;
        private void FrmKaloriArama_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
        }

        private void btnKaloriArama_Click(object sender, EventArgs e)
        {
            int kalori = 0;
            if (txtKaloriAra.Text == "")
            {
                MessageBox.Show("Lütfen Arayacağınız Besini Giriniz");
            }
            else if (txtKaloriAra.Text != "")
            {
                foreach (var item in db.Besinlers)
                {
                    if (txtKaloriAra.Text.ToLower() == item.BesinAdı.ToLower())
                    {
                        kalori = item.Kalori;

                    }
                }
            }
            lblGelenKalori.Text = txtKaloriAra.Text + " Besinin Kalorisi " + kalori + " Dir.";

        }

        private void txtKaloriAra_Enter(object sender, EventArgs e)
        {
            //int kalori = 0;
            //if (txtKaloriAra.Text == "")
            //{
            //    MessageBox.Show("Lütfen Arayacağınız Besini Giriniz");
            //}
            //else if (txtKaloriAra.Text != "")
            //{
            //    foreach (var item in db.Besinlers)
            //    {
            //        if (txtKaloriAra.Text.ToLower() == item.BesinAdı.ToLower())
            //        {
            //            kalori = item.Kalori;

            //        }
            //    }
            //}
            //lblGelenKalori.Text = txtKaloriAra.Text + " Besinin Kalorisi " + kalori + " Dir.";
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

        private void btnUzmanaSor_Click(object sender, EventArgs e)
        {
            FrmUzmanaSor frmUzmanaSor = new FrmUzmanaSor();
            frmUzmanaSor.Show();
            this.Hide();
        }
    }
}
