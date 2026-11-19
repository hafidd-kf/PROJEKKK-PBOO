
using System;
using System.Windows.Forms;
using PROJEKKKK_PBOO.View;

namespace PROJEKKKK_PBOO
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new Login());
        }
    }
}
