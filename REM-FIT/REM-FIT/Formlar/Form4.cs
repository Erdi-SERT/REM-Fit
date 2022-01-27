using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.SqlServer;
using REM_FIT.Formlar;


namespace REM_FIT.Formlar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string email;
        public static string sifre;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Kullanıcılar.Where(r => r.EMail == txtEmailGiris.Text && r.Sifre == txtSifreGiris.Text && r.KullanıcıTipi == 1).Count() > 0)
                {
                    //MessageBox.Show("Kullanıcı Giriş başarılı");
                    FrmKaloriTakipSayfasi frmKaloriTakipSayfasi = new FrmKaloriTakipSayfasi();
                    frmKaloriTakipSayfasi.Show();
                    this.Hide();
                    email = txtEmailGiris.Text;
                    sifre = txtSifreGiris.Text;
                }
                else if (db.Kullanıcılar.Where(r => r.EMail == txtEmailGiris.Text && r.Sifre == txtSifreGiris.Text && r.KullanıcıTipi==0).Count() > 0 )
                {
                    //MessageBox.Show("Admin Giriş başarılı");
                    FrmAdminPaneli frmAdminPaneli = new FrmAdminPaneli();
                    frmAdminPaneli.Show();
                    this.Hide();
                    email = txtEmailGiris.Text;
                    sifre = txtSifreGiris.Text;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifrenizi yanlış girdiniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış giriş yaptınız");
                throw;
            }

        }
        RemFitKaloriEntitiesSon db;
        
        private void Form4_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntitiesSon();           
            txtSifreGiris.isPassword = true;
        }        
    }
}
