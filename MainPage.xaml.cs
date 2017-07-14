using Windows.UI.Xaml.Controls;
using Windows.System;
using System;

namespace PowerManagement
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn_Restart_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ShutdownManager.BeginShutdown(ShutdownKind.Restart, TimeSpan.FromSeconds(5));
        }

        private void btn_ShutDown_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ShutdownManager.BeginShutdown(ShutdownKind.Shutdown, TimeSpan.FromSeconds(5));
        }

        private void btn_Cancel_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ShutdownManager.CancelShutdown();
        }
    }
}
