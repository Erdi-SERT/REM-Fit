using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace REM_FIT.Formlar
{
    public partial class FrmUzmanaSor : Form
    {
        public FrmUzmanaSor()
        {
            InitializeComponent();
        }
        private void FrmUzmanaSor_Load(object sender, EventArgs e)
        {
            
        }        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/");
            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            //MailMessage eposta = new MailMessage();
            ////eposta.From = new MailAddress(Form4.email);
            //eposta.To.Add("uzmanyorum@rem.com.tr");
            //eposta.Subject = "REMFİT uygulamasının başarısı";
            //eposta.Body = "İçerik";
        }            
          
        private void btnKaloriTakip_Click(object sender, EventArgs e)
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
