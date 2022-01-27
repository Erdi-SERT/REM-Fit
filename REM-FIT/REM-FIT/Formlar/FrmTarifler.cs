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
    public partial class FrmTarifler : Form
    {
        public FrmTarifler()
        {
            InitializeComponent();
        }

        private void cmbTarifler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTarifler.Items.Clear();
            if (cmbTarifler.SelectedIndex == 1)
            {
                lstTarifler.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Users\MRG\source\repos\REM-FIT\Resources\cips.txt"));
                //pictureBox1.Image=Image.FromFile(@"C:\Users\MRG\source\repos\REM-FIT\Resources\cips.jpeg");
                pictureBox1.Image = REM_FIT.Properties.Resources.cips;
            }
            if (cmbTarifler.SelectedIndex == 2)
            {
                lstTarifler.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Users\MRG\source\repos\REM-FIT\Resources\KabakTabanliPizza.txt"));
                pictureBox1.Image = REM_FIT.Properties.Resources.Pizza;
            }
            if (cmbTarifler.SelectedIndex == 3)
            {
                lstTarifler.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Users\MRG\source\repos\REM-FIT\Resources\Portakallı_light_kereviz.txt"));
                pictureBox1.Image = REM_FIT.Properties.Resources.Kereviz;
            }
        }
        private void FrmTarifler_Load(object sender, EventArgs e)
        {
            cmbTarifler.Items.Add("Diyet Cips");
            cmbTarifler.Items.Add("Kabak Tabanlı Pizza");
            cmbTarifler.Items.Add("Portakallı Light Kereviz");
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
