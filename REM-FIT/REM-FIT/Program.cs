using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Model;
using REM_FIT.Formlar;

namespace REM_FIT
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //using (RemFitDbContext app = new RemFitDbContext()) 
            //{
            //    Gender male = new Gender() { ID = 3, Type = GenderType.kadın};

            //    Gender female = new Gender() { ID = 4, Type = GenderType.erkek };

            //    app.Genders.Add(male);
            //    app.Genders.Add(female);

            //    app.SaveChanges();
            //}
        }
    }
}
