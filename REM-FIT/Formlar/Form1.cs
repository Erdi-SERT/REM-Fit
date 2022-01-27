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

namespace REM_FIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(); //instance aldık
            frm4.Show(); //from2 göster dedik
            this.Hide();
        }
               

        private void btnUyeOl_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //instance aldık
            frm2.Show(); //from2 göster dedik
            this.Hide();

        }
    }
}
