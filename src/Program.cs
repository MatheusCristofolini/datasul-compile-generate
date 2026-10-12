using System;
using System.Reflection;
using System.Windows;
using DatasulCompileGen.UI;

[assembly: AssemblyTitle("Datasul Search & Compile Script Generator")]
[assembly: AssemblyDescription("Utilitario portatil com Design UI/UX Pro Max para busca de programas Progress Datasul e geracao automatica de scripts de compilacao (.p)")]
[assembly: AssemblyCompany("Macritec")]
[assembly: AssemblyProduct("DatasulCompileGen")]
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]

namespace DatasulCompileGen
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();
            MainForm mainWindow = new MainForm();
            app.Run(mainWindow);
        }
    }
}
