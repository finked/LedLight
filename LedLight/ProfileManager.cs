using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace LedLight
{
    public class ProfileManager
    {
        int active = 0;
        // LedLight activeProfile;
        Ambilight ambiProfile;
        MonoLight monProfile;
        MultiLight multProfile;

        public ProfileManager()
        {
        }

        public string[] GetProfileNames(string sourceDir)
        {
            string[] ProfilFileNames = Directory.GetFiles(sourceDir, "*.xml");
            return ProfilFileNames;
        }

        public void DeleteProfile(string profileName)
        {
            File.Delete(profileName);
        }

        public bool LoadProfile(string profileName)
        {

            string mode = "";

            // Read in mode of profile
            Console.WriteLine("Reading Mode of Profile: " + profileName);
            try
            {
                XDocument loadedXmlDoc = XDocument.Load(profileName);

                // Loading Mode
                mode = loadedXmlDoc.Element("LedProfile").Attribute("Mode").Value;

            }
            catch
            {

            }

            if (mode == "Ambilight")
            {
                active = 1;
                ambiProfile = new Ambilight();

                Console.WriteLine("Mode set to " + mode);

                // Get profile data from xml file
                ambiProfile.LoadProfile(profileName);

                return true;
            }
            else if (mode == "Monolight")
            {
                active = 2;
                monProfile = new MonoLight();

                Console.WriteLine("Mode set to " + mode);

                // Get profile data from xml file
                monProfile.LoadProfile(profileName);

                // Open form window and show data
                //MonolightForm newForm = new MonolightForm(monProfile);
                //newForm.Show();
                
                return true;
            }
            else if (mode == "Multilight")
            {
                active = 3;
                multProfile = new MultiLight();

                Console.WriteLine("Mode set to " + mode);

                // Get profile data from xml file
                multProfile.LoadProfile(profileName);

                return true;
            }
            else
            {
                Console.WriteLine("Could not read mode...");

                return false;
            }
        }

        public void SaveProfile(string path)
        { 
            // TODO: Should the saveProfile go over the profileManager?
            // 
        }

        public void ActivateProfile()
        {
            // TODO: Check if active profile is set
            switch (active)
            {
                // Ambilight is active
                case 1:
                    ambiProfile.ActivateProfile();
                    break;
                // Monolight is active
                case 2:
                    monProfile.ActivateProfile();
                    break;
                case 3:
                    multProfile.ActivateProfile();
                    break;
                default:
                    break;

            }
        }

        public void StopActiveProfile()
        {
            switch (active)
            {
                // Ambilight is active
                case 1:
                    ambiProfile.StopProfile();
                    break;
                // Monolight is active
                case 2:
                    monProfile.StopProfile();
                    break;
                case 3:
                    multProfile.StopProfile();
                    break;
                default:
                    break;
            }

            active = 0;

            // TODO: Close profile window 
            
            // TODO: Call stop function if window is closed
        }

        public void ChangeProfile(string profstr)
        {

            LoadProfile(profstr);

            switch (active)
            {
                // Ambilight is active
                case 1:

                    // Open form window and show data
                    AmbilightForm newAmbiForm = new AmbilightForm(ambiProfile);
                    newAmbiForm.Show();

                    //ambiProfile.ActivateProfile();
                    break;
                // Monolight is active
                case 2:
                    // Open form window and show data
                    MonolightForm newMonForm = new MonolightForm(monProfile);
                    newMonForm.Show();

                    //monProfile.ActivateProfile();
                    break;
                case 3:
                    // Open form window and show data
                    MultiLightForm newMultForm = new MultiLightForm(multProfile);
                    newMultForm.Show();

                    //multProfile.ActivateProfile();
                    break;
                default:
                    break;

            }
        }
    }
}
