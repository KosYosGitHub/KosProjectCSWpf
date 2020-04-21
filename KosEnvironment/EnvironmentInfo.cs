using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace KosEnvironment
{
	public class EnvironmentInfo
	{
		public string OperatingSystemName { get; }
		public string OperatingSystemCaption { get; }
		public string OperatingSystemDescription { get; }
		public string OperatingSystemVersion { get; }
		public string OperatingSystemBuildNumber { get; }
		public string OperatingSystemBuildType { get; }
		public string OperatingSystemManufacturer { get; }
		public string OperatingSystemLocaleID { get; }
		public string OperatingSystemLanguage { get; }
		public string OperatingSystemCodeSet { get; }
		public string OperatingSystemCountryCode { get; }
		public string OperatingSystemSerialNumber { get; }
		public string OperatingSystemInstallDate { get; }
		public string LastBootUpTime { get; }
		public string WindowsDirectory { get; }
		public string SystemDevice { get; }
		public string SystemDrive { get; }
		public string BootDevice { get; }
		public string PlusProductID { get; }
		public string PlusVersionNumber { get; }

		public EnvironmentInfo()
		{
			OperatingSystem os = Environment.OSVersion;
			using(ManagementClass mc = new ManagementClass("Win32_OperatingSystem")) {
				using(ManagementObjectCollection moc = mc.GetInstances()) {
					foreach(ManagementObject mo in moc) {
						OperatingSystemName = mo["Name"].ToString();
						OperatingSystemCaption = mo["Caption"].ToString();
						OperatingSystemDescription = mo["Description"].ToString();
						OperatingSystemVersion = mo["Version"].ToString();
						OperatingSystemBuildNumber = mo["BuildNumber"].ToString();
						OperatingSystemBuildType = mo["BuildType"].ToString();
						OperatingSystemManufacturer = mo["Manufacturer"].ToString();
						OperatingSystemLocaleID = mo["Locale"].ToString();
						OperatingSystemLanguage = mo["OSLanguage"].ToString();
						OperatingSystemCodeSet = mo["CodeSet"].ToString();
						OperatingSystemCountryCode = mo["CountryCode"].ToString();
						OperatingSystemSerialNumber = mo["SerialNumber"].ToString();
						OperatingSystemInstallDate = mo["InstallDate"].ToString();
						LastBootUpTime = mo["LastBootUpTime"].ToString();
						WindowsDirectory = mo["WindowsDirectory"].ToString();
						SystemDevice = mo["SystemDevice"].ToString();
						SystemDrive = mo["SystemDrive"].ToString();
						BootDevice = mo["BootDevice"].ToString();
						PlusProductID = mo["PlusProductID"]?.ToString();
						PlusVersionNumber = mo["PlusVersionNumber"]?.ToString();

						mo.Dispose();
						break;
					}
				}
			}
		}
	}
}
