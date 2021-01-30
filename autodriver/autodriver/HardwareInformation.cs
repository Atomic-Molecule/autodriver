using System;
using System.Management;

namespace autodriver {

public class HardwareInformation {

		// CPU INFORMATION
		public static string cpuName;
		public static string cpuSerialNumber;
		public static string cpuStatus;
		public static bool cpuVirtualisationEnabled;
		public static UInt16 cpuArchitecture;
		public static UInt32 cpuCores;
		public static UInt32 cpuLogicalProcessors;
		public static UInt32 cpuThreads;
		// CPU INFORMATION


		public static void getHardwareInformation() {
		}

        public static void getCpuInformation() {
			ManagementObjectSearcher getCpuInformation = new ManagementObjectSearcher("Select * from Win32_Processor");
			foreach (ManagementObject info in getCpuInformation.Get()) {
                cpuName = (string) info["Name"];
				cpuSerialNumber = (string) info["SerialNumber"];
				cpuStatus = (string) info["Status"];
				cpuVirtualisationEnabled = (bool) info["VirtualizationFirmwareEnabled"];
				cpuArchitecture = (UInt16) info["Architecture"];
				cpuCores = (UInt32) info["NumberOfCores"];
				cpuLogicalProcessors = (UInt32) info["NumberOfLogicalProcessors"];
				cpuThreads = (UInt32) info["ThreadCount"];
			}
		}
	}
}

