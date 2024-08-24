using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUI
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            bool LC = LicenceControl();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (LC)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Licence());
            }

        }

        static bool LicenceControl()
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("PhoneDirectory");
            if (RK != null)
            {
                string HardDriveSerialNumber = string.Empty;
                string MACAddress = string.Empty;

                string drive = "C";

                ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
                Disk.Get();

                HardDriveSerialNumber = Disk["VolumeSerialNumber"].ToString();

                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MACADD.GetInstances();

                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        MACAddress = item["MACAddress"].ToString();
                    }
                }

                string HDSN = RK.GetValue("HardDriveSerialNumber").ToString();
                string MAC = RK.GetValue("MACAddress").ToString();

                if (HDSN == HardDriveSerialNumber && MAC == MACAddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
