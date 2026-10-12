using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DatasulCompileGen.UI;

[assembly: AssemblyTitle("Datasul Search & Compile Script Generator")]
[assembly: AssemblyDescription("Utilitario portatil para busca de programas Progress Datasul e geracao automatica de scripts de compilacao (.p)")]
[assembly: AssemblyCompany("Macritec")]
[assembly: AssemblyProduct("DatasulCompileGen")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace DatasulCompileGen
{
    public static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    SetProcessDPIAware();
                }
            }
            catch
            {
                // Ignore if DPI API is unavailable
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
