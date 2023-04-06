using System;
using System.Windows.Forms;

namespace SchuelerverwaltungProjekt;

internal static class Program
{
    /// <summary>
    ///     Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new SchuelerverwaltungForm());
    }
}