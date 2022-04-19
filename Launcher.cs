using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AllTheLaunchers
{
    internal class Launcher
    {
        public static void LaunchRift()
        {
            Process.Start("Rift.exe");
        }

        public static void LaunchEra()
        {
            Process.Start("FortniteLauncher.exe");
        }

        public static void GithubPage(string url)
        {
            Process.Start(url);
        }

        public static void LaunchLawinServer()
        {
            Process.Start("start.bat");
        }

        public static void InstallLawinServer()
        {
            Process.Start("install_packages.bat");
        }

        public static void ShowFiddlerScriptLawinPC()
        {
            Process.Start("notepad.exe" , "FiddlerScriptLawinPC");
        }

        public static void FiddlerClassicSetup()
        {
            Process.Start("FiddlerSetup.exe");
        }

    }
}
