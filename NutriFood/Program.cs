using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriFood.Models;
using NutriFood.Views;
using NutriFood.Presenters;
using NutriFood.Repositories;

namespace NutriFood
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //
            string sqlConnection = ""; //Acá iría la conneción con SQL
            IMainForm mainForm = new MainForm();
            new MainPresenter(mainForm, sqlConnection);
            Application.Run((Form)mainForm);
        }
    }
}
