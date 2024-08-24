using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUI
{
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(TxtLicenceKey.Text == "6B29FC40-CA47-1067-B31D-00DD010662DA")
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

                if( !string.IsNullOrEmpty(MACAddress) && !string.IsNullOrEmpty(HardDriveSerialNumber))
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey("PhoneDirectory", true);
                    Key.SetValue("HardDriveSerialNumber", HardDriveSerialNumber);
                    Key.SetValue("MACAddress", MACAddress);

                    MessageBox.Show("Your licensing process is complete, please close and reopen the application.","!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The license number you entered is incorrect. Try again.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
