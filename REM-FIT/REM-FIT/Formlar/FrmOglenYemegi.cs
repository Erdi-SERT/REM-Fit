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
    public partial class FrmOglenYemegi : Form
    {
        public FrmOglenYemegi()
        {
            InitializeComponent();
        }
        //RemFitKaloriEntities1 db;
        RemFitKaloriEntitiesSon db;
        private void FrmOglenYemegi_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
            VerileriDoldur(db.Besinlers.ToList(), cmbOgleMenu);
        }
        private void VerileriDoldur(List<Besinler> besinlers, ComboBox combobox)
        {
            foreach (var item in besinlers)
            {
                string besin = item.BesinAdı + "(" + item.Kalori + " )";
                combobox.Items.Add(besin);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && cmbOgleMenu.SelectedIndex > 0)
            {

                foreach (var item in db.Besinlers)
                {
                    if (cmbOgleMenu.SelectedIndex == item.BesinID)
                    {
                        int tüketilenkalori = item.Kalori * (Convert.ToInt32((numericUpDown1.Value)));
                        string tüketilenBesinAdı = item.BesinAdı;
                        int tüketilenBesinID = item.BesinID;
                        int tüketimMiktarı = Convert.ToInt32(numericUpDown1.Value);
                        DateTime tüketimTarihi = DateTime.Now;
                        int deneme1 = db.Kullanıcılar.Where(x => x.EMail == Form4.email).FirstOrDefault().UserID;



                        db.TüketildiğiÖğün.Add(new TüketildiğiÖğün()
                        {
                            BesinID = tüketilenBesinID,
                            TüketildiğiÖğün1 = 1,
                            BesinAdı = tüketilenBesinAdı,
                            Miktarı = tüketimMiktarı,
                            TükedildiğiTarih = tüketimTarihi,
                            UserID_UserID = deneme1,
                            Kalori = tüketilenkalori
                        });
                        MessageBox.Show("Başarı ile eklendi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bütün alanları doldurunuz.");
            }
            db.SaveChanges();
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvGunlukListe.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Day == DateTime.Now.Day && x.TükedildiğiTarih.Year == DateTime.Now.Year && x.TüketildiğiÖğün1 == 1).Select(x => new
                    {
                        TüketilenBesinID = x.TüketilenBesinID,
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                        Kalori = x.Kalori,
                        TüketildiğiTarih = x.TükedildiğiTarih

                    }).ToList();

                }
            }
        }

        private void btnKahvaltiEkle_Click(object sender, EventArgs e)
        {
            Temizle(grpOgle);
        }
        private void Temizle(GroupBox grpKahvalti)
        {
            foreach (var item in grpKahvalti.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is TextBox)
                    ((TextBox)item).Text = ""; // null, isEmpty bunlarda yazılabilir
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
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

        private void btnTuketilenGidalar_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvGunlukListe.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Day == DateTime.Now.Day && x.TükedildiğiTarih.Year == DateTime.Now.Year && x.TüketildiğiÖğün1 == 1).Select(x => new
                    {
                        TüketilenBesinID = x.TüketilenBesinID,
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                        Kalori = x.Kalori,
                        TüketildiğiTarih = x.TükedildiğiTarih

                    }).ToList();

                }
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (dgvGunlukListe.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Besini silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    //seçili satırı siliyoruz.
                    var istenecekOlanID = dgvGunlukListe.SelectedRows[0].Cells[0].Value;
                    var silinecek = db.TüketildiğiÖğün.Where(x => x.TüketilenBesinID == (int)istenecekOlanID).FirstOrDefault();
                    db.TüketildiğiÖğün.Remove(silinecek);
                    db.SaveChanges();
                    MessageBox.Show("Besin Günlük Listenizden Silindi");
                }
                else if (secenek == DialogResult.No)
                {
                    MessageBox.Show("Besin silinmedi...");
                }

            }


            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }

            foreach (var item in db.Kullanıcılar)
            {
                if (item.EMail == Form4.email)
                {
                    dgvGunlukListe.DataSource = db.TüketildiğiÖğün.Where(x => x.TükedildiğiTarih.Day == DateTime.Now.Day && x.TükedildiğiTarih.Year == DateTime.Now.Year && x.TüketildiğiÖğün1 == 1).Select(x => new
                    {
                        TüketilenBesinID = x.TüketilenBesinID,
                        BesinAdı = x.BesinAdı,
                        TüketildiğiMiktar = x.Miktarı,
                        Kalori = x.Kalori,
                        TüketildiğiTarih = x.TükedildiğiTarih

                    }).ToList();

                }
            }
        }
    }
}
