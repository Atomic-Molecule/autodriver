﻿using System;
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
