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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Kullanıcılar.Where(r=>r.EMail==txtEmailGiris.Text&& r.Sifre==txtSifreGiris.Text).Count()>0)
                {
                    MessageBox.Show("Giriş başarılı");
                    FrmKaloriTakipSayfasi frmKaloriTakipSayfasi = new FrmKaloriTakipSayfasi();
                    frmKaloriTakipSayfasi.Show();
                    this.Hide();
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
        RemFitKaloriEntities db;
        private void Form4_Load(object sender, EventArgs e)
        {
            db = new RemFitKaloriEntities();
            txtSifreGiris.isPassword = true;
          
        }
    }
}
