using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace autodriver {

public class HardWareInformation {
		public static void getHardwareInformation() {
			ManagementObjectSearcher getCpuInformation = new ManagementObjectSearcher("Select * from Win32_Processor");
			foreach (ManagementObject info in getCpuInformation.Get()) {
				Console.WriteLine("Computer Processor: " + info["Name"]);
				Console.WriteLine("Processor Family: " + info["Family"]);
				Console.WriteLine("Processor Architecture: " + info["Architecture"] + "th generation");
			}
		}
	}

}
