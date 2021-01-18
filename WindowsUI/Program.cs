using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Business.DIResolvers;
using DevExpress.Utils.Extensions;
using FluentValidation;

namespace WindowsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                AppRun();
            }
            catch (Exception e)
            {
                var dialogResult = MessageBox.Show(e.Message + " - do you want to restart the application ?", "An error occurred", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }
        static void AppRun()
        {
            Application.EnableVisualStyles();   
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectProject());
        }

    }
}
