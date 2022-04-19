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

    }
}
