using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Drawing;

namespace LedLight
{
    public class LedLight
    {
        public string mode;
        public UsbConnect connect = new UsbConnect();
 
        public LedLight()
        {
            //DirectoryInfo info = Directory.CreateDirectory("D:/Test/Profile/");
            mode = "not set";
        }

        public virtual void ActivateProfile()
        {
        }

        public virtual void StopProfile()
        {
            connect.Close();
            // TODO: Stop the active profile
            // How to stop it if it only exists in StartProfile?
        }

        public virtual bool LoadProfile(String profileName)
        {
            return false;
        }
    }
}
