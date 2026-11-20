using PROJEKKKK_PBOO;
using System;
using System.Windows.Forms;

namespace MonitoringKesehatanAyam;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
