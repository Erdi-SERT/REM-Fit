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
    public partial class FrmAdminPaneli : Form
    {
        public enum Birim { Gram, Adet, Porsiyon, Bardak, Kaşık, Dilim }
        public FrmAdminPaneli()
        {
            InitializeComponent();
        }
        RemFitKaloriEntitiesSon db;
        private void FrmAdminPaneli_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
            cmbBirimler.Items.AddRange(Enum.GetNames(typeof(Birim)));
        }

        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            Besinler besinler = new Besinler();
            int sayac = 0;

            if (txtBesinGiris.Text != "" && txtKaloriGirisi.Text != "" && cmbBirimler.SelectedIndex >= 0)
            {
                foreach (var item in db.Besinlers)
                {
                    if (item.BesinAdı.ToLower() == txtBesinGiris.Text.ToLower() && item.Kalori == Convert.ToInt32(txtKaloriGirisi.Text) && item.Birimi == cmbBirimler.SelectedIndex)
                    {
                        sayac++;
                    }

                }
                if (sayac == 0)
                {
                    besinler.BesinAdı = txtBesinGiris.Text;
                    besinler.Kalori = Convert.ToInt32(txtKaloriGirisi.Text);
                    besinler.Birimi = cmbBirimler.SelectedIndex;
                    db.Besinlers.Add(besinler);
                    MessageBox.Show("Ürün Girişi Başarılı");
                }
                else
                {
                    MessageBox.Show("Besin Daha Önce Girilmiş Lütfen Farklı Bir Besin Giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları eksiksiz giriniz.");
            }
            db.SaveChanges();
        }

        private void btnKullaniciBul_Click(object sender, EventArgs e)
        {
            int userID = 0;
            userID = db.Kullanıcılar.Where(x => x.EMail == txtAraMail.Text).FirstOrDefault().UserID;
            txtKullaniciAdi2.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Ad;
            txtSoyad.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Soyadı;
            txtEmail.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().EMail;
            txtTipi.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().KullanıcıTipi.ToString();
            dtpDogumTarihi.Value = (DateTime)db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().DoğumTarihi;
            txtKCinsiyeti.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Cinsiyeti.ToString();
            txtKSifre.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Sifre;
            txtKKilo.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Kilo.ToString();
            txtKBoy.Text = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault().Boy.ToString();

        }
        double kaloriIhtiyaci;
        private void btnKullaniciDüzenle_Click(object sender, EventArgs e)
        {
            int userID = 0;           

            userID = db.Kullanıcılar.Where(x => x.EMail == txtEmail.Text).FirstOrDefault().UserID;
            var güncellenecekKullanıcı = db.Kullanıcılar.Where(x => x.UserID == userID).FirstOrDefault();
            güncellenecekKullanıcı.Ad = txtKullaniciAdi2.Text;
            güncellenecekKullanıcı.Soyadı = txtSoyad.Text;
            güncellenecekKullanıcı.EMail = txtEmail.Text;
            güncellenecekKullanıcı.KullanıcıTipi = Convert.ToInt32(txtTipi.Text);
            güncellenecekKullanıcı.Boy = Convert.ToDouble(txtKBoy.Text);
            güncellenecekKullanıcı.Sifre = txtKSifre.Text;
            güncellenecekKullanıcı.DoğumTarihi =Convert.ToDateTime(dtpDogumTarihi.Value);
            güncellenecekKullanıcı.Kilo = Convert.ToDouble(txtKKilo.Text);
            güncellenecekKullanıcı.Cinsiyeti = Convert.ToInt32(txtKCinsiyeti.Text);            

            if (güncellenecekKullanıcı.Cinsiyeti == 0)
            {
                kaloriIhtiyaci = 66 + (13.7 * güncellenecekKullanıcı.Kilo) + (5 * güncellenecekKullanıcı.Boy * 100) - (6.8 * (DateTime.Now.Year - güncellenecekKullanıcı.DoğumTarihi.Value.Year));
            }
            else if (güncellenecekKullanıcı.Cinsiyeti == 1)
            {
                kaloriIhtiyaci = 655 + (9.6 * güncellenecekKullanıcı.Kilo) + (1.8 * güncellenecekKullanıcı.Boy * 100) - (4.7 * (DateTime.Now.Year - güncellenecekKullanıcı.DoğumTarihi.Value.Year));
            }
            güncellenecekKullanıcı.GünlülKaloriIhtiyacı = kaloriIhtiyaci;
            
            db.SaveChanges();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
