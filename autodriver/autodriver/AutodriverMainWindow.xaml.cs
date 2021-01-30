using System.Windows;
using System.IO;
using System;
namespace autodriver {
    public partial class AutodriverMainWindow : Window {
        public AutodriverMainWindow() {
            InitializeComponent();
        }

        private void getHardwareInfo_Click(object sender, RoutedEventArgs e) {
            var HardwareInformationWindow = new HardwareInformationWindow();
            HardwareInformationWindow.Show();
        }
    }
}
