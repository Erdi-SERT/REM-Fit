using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemFit.Model;

namespace RemFit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (AppDbContext app = new AppDbContext(AppDbContext())  // süslü parantez içinde yarattığımız nesneyi kullanmamıza yarar   (using)                                                                            
            {              


            }
        }
    }
}
