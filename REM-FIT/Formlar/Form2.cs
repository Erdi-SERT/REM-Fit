using Model;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }
        RemFitKaloriEntities db;
        private void Form2_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntities();

            chkKadin.Checked = true;
            if (chkKadin.Checked == true)
            {
                chkErkek.Checked = false;
            }
            else if (chkErkek.Checked == true)
            {
                chkKadin.Checked = false;
            }

        }
        public static int cinsiyet;
        public static double boy, kilo;
        public static DateTime doğumTarihi;


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            // datetime kısmını kontrol et , text kısmını kontrol et

            if (chkKadin.Checked)
            {
                cinsiyet = 1;
            }
            else if (chkErkek.Checked)
            {
                cinsiyet = 0;
            }

            if (dtpDogumTarihi.Value < DateTime.Now && (chkErkek.Checked == true || chkKadin.Checked == true) && txtBoy.Text != "" && txtKilo.Text != null)
            {

                User user = new User();

                user.DoğumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
                user.Boy = Convert.ToDouble(txtBoy.Text);
                user.Kilo = Convert.ToDouble(txtKilo.Text);
                
                doğumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value);
                boy = Convert.ToDouble(txtBoy.Text);
                kilo = Convert.ToDouble(txtKilo.Text);
                //user.Cinsiyeti = Model.CinsiyetTipi(cinsiyet);
                //db = new RemFitKaloriEntities();
                //db.Kullanıcılar.Add(new Kullanıcılar()
                //{
                //    Boy = Convert.ToDouble(txtBoy.Text),
                //    Kilo = Convert.ToDouble(txtKilo.Text),
                //    DoğumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value),
                //    Cinsiyeti = cinsiyet

                //});
                //db.SaveChanges();
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
            }

        }

        private void btnZatenUyeyim_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo;
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            if (boy > 0 && boy < 3 && kilo > 0)
            {
                string Vki = VKIHesapla(boy, kilo);
                lblVki.Text = Vki;   //Vki
            }
            else
            {
                MessageBox.Show("Kilo ve Boy bilgisini Kontrol ediniz.");
            }

        }
        public string VKIHesapla(double boy, double kilo)
        {
            double vki = kilo / (boy * boy);
            string sonuc = "";

            if (vki < 18)
            {
                sonuc = "Zayıf";
            }
            else if (18 < vki && vki < 25)
            {
                sonuc = "Normal";
            }
            else if (25 < vki && vki < 30)
            {
                sonuc = "Fazla Kilolu";
            }
            else if (30 < vki && vki < 40)
            {
                sonuc = "Obez";
            }
            else if (40 < vki)
            {
                sonuc = "İleri Derece Obez";
            }
            return sonuc;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void chkKadin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKadin.Checked == true)
            {
                chkErkek.Checked = false;
            }
        }

        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (chkErkek.Checked == true)
            {
                chkKadin.Checked = false;
            }
        }
    }
}
