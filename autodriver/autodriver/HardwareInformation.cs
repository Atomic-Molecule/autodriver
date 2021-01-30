using System;
using System.Management;
using System.IO;
using System.Collections.Generic;

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

		// GPU INFORMATION
		public static string gpuName;
		public static string gpuDriverVersion;
		public static string gpuResolution;
		// GPU INFORMATION

		// MOTHERBOARD INFORMATION
		public static string motherboardName;
		public static string motherboardModel;
		public static string motherboardManufacturer;
		// MOTHERBOARD INFORMAITON

		// MEMORY INFORMATION
		// MEMORY INFORMATION

		// BIOS INFORMATION
		public static string biosName;
		public static string biosManufacturer;
		public static string biosVersion;
		// BIOS INFORMATION

		// STORAGE INFORMATION
		public static List<string> driveNames = new List<string>();
		public static List<long> driveSize = new List<long>();
		// STORAGE INFORMATION

        public static void getCpuInformation() {
			ManagementObjectSearcher getCpuInformation = new ManagementObjectSearcher("Select * From Win32_Processor");
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

		public static void getGpuInformation() {
			ManagementObjectSearcher getGpuInformation = new ManagementObjectSearcher("Select * From Win32_VideoController");
			foreach (ManagementObject info in getGpuInformation.Get()) {
				gpuName = (string) info["Name"];
				gpuResolution = (string) info["VideoModeDescription"];
				gpuDriverVersion = (string) info["DriverVersion"];
			}
		}

		public static void getMotherboardInformation() {
			ManagementObjectSearcher getMotherboardInformation = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
			foreach (ManagementObject info in getMotherboardInformation.Get()) {
				motherboardName = (string) info["Name"]; // Needs fixing - displays "Baseboard"
				motherboardModel = (string) info["Model"]; // Needs fixing  - displays nothing
				motherboardManufacturer = (string) info["Manufacturer"];
			}
		}

		public static void getMemoryInformation() { 
			// To be implemented
		}

		public static void getBiosInformation() {
			ManagementObjectSearcher getBiosInformation = new ManagementObjectSearcher("Select * From Win32_BIOS");
			foreach (ManagementObject info in getBiosInformation.Get()) {
				biosName = (string) info["Name"];
				biosManufacturer = (string) info["Manufacturer"];
				biosVersion = (string) info["Version"];
			}
		}

		public static void getStorageInformation() {
			foreach (var drive in DriveInfo.GetDrives()) {
				driveNames.Add(drive.Name);
				driveSize.Add(drive.TotalSize);
			}
		}
	}
}

