using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

/// <summary>
/// Application to copy selected hairs, hair bones as well as textures from source preset to destination.
/// 
/// 
/// </summary>
namespace VRoidHairMerger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MergeForm());
        }

        private static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("Newtonsoft.Json"))
            {
                string assemblyFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Newtonsoft.Json.dll";
                return Assembly.LoadFrom(assemblyFileName);
            }
            else
                return null;
        }
    }
}
