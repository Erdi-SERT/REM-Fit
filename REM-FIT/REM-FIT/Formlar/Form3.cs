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
using Model;


namespace REM_FIT.Formlar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();//Kayıt  olmaktan vazgeçerse Form2 ekranına yönlendirildi.
            form2.Show();
            this.Hide();
        }
        RemFitKaloriEntitiesSon db;
        int sayac = 0;
        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            if (chkKullaniciSozlesmesi.Checked)
            {
                if (txtAd.Text.ToString() == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");
                }
                else if (txtSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");
                }
                else if (txtTelefon.Text == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");

                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");
                }

                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");

                }
                else if (txtSifreTekrar.Text == "")
                {
                    MessageBox.Show("Lütfen bütün sutunları doldurun");

                }
                else if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor Lütfen Kontrol Ediniz");
                }
                else if (txtEmail.Text != "")
                {
                    foreach (var item in db.Kullanıcılar)
                    {
                        if (item.EMail.ToLower() == txtEmail.Text.ToLower())
                        {
                            sayac++;
                        }

                    }
                    if (sayac > 0)
                    {
                        MessageBox.Show("Bu Mail Adresi ile Kullanıcı Oluşturulmuştur.");
                    }
                    else if (sayac == 0)
                    {

                        if (Form2.cinsiyet == 0)
                        {
                            kaloriIhtiyaci = 66 + (13.7 * Form2.kilo) + (5 * Form2.boy * 100) - (6.8 * (DateTime.Now.Year - Form2.doğumTarihi.Year));
                        }
                        else if (Form2.cinsiyet == 1)
                        {
                            kaloriIhtiyaci = 655 + (9.6 * Form2.kilo) + (1.8 * Form2.boy * 100) - (4.7 * (DateTime.Now.Year - Form2.doğumTarihi.Year));
                        }


                        db.Kullanıcılar.Add(new Kullanıcılar()
                        {
                            Ad = txtAd.Text,
                            Soyadı = txtSoyad.Text,
                            EMail = txtEmail.Text,
                            KayıtTarihi = DateTime.Now,
                            KullanıcıTipi = 1,
                            Sifre = txtSifre.Text,
                            Boy = Form2.boy,
                            DoğumTarihi = Form2.doğumTarihi,
                            Kilo = Form2.kilo,
                            Cinsiyeti = Form2.cinsiyet,
                            GünlülKaloriIhtiyacı = kaloriIhtiyaci
                        });
                        db.SaveChanges();

                        MessageBox.Show("Kayıdnız başarılı bir şekilde oluşturulmuştur");

                        Form4 frm4 = new Form4();
                        frm4.Show();
                        this.Hide();

                    }

                }
            }
            else if (chkKullaniciSozlesmesi.Checked == false)
            {
                MessageBox.Show("Lütfen kullanıcı sözleşmesini oluyup kabul ediniz");
            }
        }
        public static double kaloriIhtiyaci;

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();
        }
        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {
            txtSifre.isPassword = true;
            txtSifreTekrar.isPassword = true;
        }
    }
}
