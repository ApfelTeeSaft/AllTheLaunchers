using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AllTheLaunchers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Rift_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchRift();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Launcher.InstallLawinServer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchLawinServer();
        }

        private void FiddlerScriptLawinPC_Click(object sender, RoutedEventArgs e)
        {
            Launcher.ShowFiddlerScriptLawinPC();
        }

        private void FiddlerSetup_Click(object sender, RoutedEventArgs e)
        {
            Launcher.FiddlerClassicSetup();
        }
    }
}
