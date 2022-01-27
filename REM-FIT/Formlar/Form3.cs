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

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnVazgec_Click(object sender, EventArgs e)
        {
            // Ya burada programı kapatacağız ya da Form 2 ye geri döndüreceğiz bence burada kapatalım üst tarafa geri diye bir buton koyarız oradan geri döner
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        RemFitKaloriEntities db;
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
                else if (txtSifre.Text!=txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor Lütfen Kontrol Ediniz");
                }
                else
                {
                    MessageBox.Show("Kayıdnız başarılı bir şekilde oluşturulmuştur");
                    //database gönderdik ardından bilgileri tekrardan gösterebiliriz                    
                    //Burada database e kayıt edeceğiz artık ancak bundan önceki boy kilo gibi verileri daha önce aldığımız için ya bunları listede tutup ekleyeceğiz ya da database orada ekleyip ardından vazgeç e basarsa sileceğiz

                    //User user = new User();
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
                        Cinsiyeti= Form2.cinsiyet


                    });
                    db.SaveChanges();
                    Form4 frm4 = new Form4();
                    frm4.Show();
                    this.Hide();
                }

            }
            else if (chkKullaniciSozlesmesi.Checked == false)
            {
                MessageBox.Show("Lütfen kullanıcı sözleşmesini oluyup kabul ediniz");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtAd_MouseClick(object sender, MouseEventArgs e)
        {
            txtAd.Text = "";

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntities();
            
            
        }

        private void txtSifre_OnValueChanged(object sender, EventArgs e)
        {
            txtSifre.isPassword = true;
            txtSifreTekrar.isPassword = true;
        }
    }
}
