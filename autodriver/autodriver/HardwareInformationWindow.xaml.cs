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
using System.Windows.Shapes;

namespace autodriver {
    /// <summary>
    /// Interaction logic for HardwareInformationWindow.xaml
    /// </summary>
    public partial class HardwareInformationWindow : Window {
        public HardwareInformationWindow() {
            InitializeComponent();

            HardwareInformation.getCpuInformation();
            processorName.Content = HardwareInformation.cpuName;
            processorGeneration.Content = HardwareInformation.cpuArchitecture + "th Generation";
            processorCores.Content = HardwareInformation.cpuCores;
            processorLogicalProcessors.Content = HardwareInformation.cpuLogicalProcessors;
            processorThreads.Content = HardwareInformation.cpuThreads;
            processorStatus.Content = HardwareInformation.cpuStatus;
            processorSerialNumber.Content = HardwareInformation.cpuSerialNumber;
        }
    }
}
