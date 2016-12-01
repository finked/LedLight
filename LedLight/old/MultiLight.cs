using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LedLight
{
    public class MultiLight : MultiLightManager
    {
        public MultiLight()
        {
        }
        
        public void SetMultiColor(byte[] r, byte[] g, byte[] b)
        {
            // TODO:    Set colors in LedList with new values
        }

/* --------------------------------------------------------------------------------------------- */

        public override void ActivateProfile()
        {
            Console.WriteLine("Activating multiight profile...");

            // Open serial port connection to the arduino board
            connect.Open();

            // Create bytearray to send the data to the arduino board
            RGBdata = new byte[LedList.Length * 3 + 2];

            // Set start and stop byte
            RGBdata[0] = 0x01;
            RGBdata[RGBdata.Length - 1] = 0x02;

            for (int i = 1; i < LedList.Length; i++)
            {
                RGBdata[3 * i - 2] = LedList[i].Color[0];
                RGBdata[3 * i - 1] = LedList[i].Color[1];
                RGBdata[3 * i] = LedList[i].Color[2];

                if (RGBdata[3 * i - 2] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
                if (RGBdata[3 * i - 1] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
                if (RGBdata[3 * i] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
            }

            // Send data bytearray to the arduino board
            Thread.Sleep(2000);
            connect.Send(RGBdata);

            Console.WriteLine("Profile activated...");
        }

        public override bool LoadProfile(string profileName)
        {
            // Get multilight data from xml file

            Console.WriteLine("Loading Profile: " + profileName);
            try
            {
                XDocument loadedXmlDoc = XDocument.Load(profileName);

                var screens = loadedXmlDoc.Element("LedProfile").Descendants("Screen");
                var leds = loadedXmlDoc.Element("LedProfile").Descendants("LED");

                // Loading Mode
                mode = loadedXmlDoc.Element("LedProfile").Attribute("Mode").Value;
                
                // Find leds

                int id = 0;
                int numLed = leds.Count();

                Console.WriteLine(numLed + " LEDs found...");

                LedList = new LED[numLed];

                byte[] r = new byte[numLed];
                byte[] g = new byte[numLed];
                byte[] b = new byte[numLed];

                foreach (var led in leds)
                {

                    LedList[id]._id = Convert.ToByte(led.Attribute("LedID").Value);

                    // Set color
                    LedList[id].Color = new byte[3];
                    LedList[id].Color[0] = Convert.ToByte(led.Element("Color").Attribute("R").Value);
                    LedList[id].Color[1] = Convert.ToByte(led.Element("Color").Attribute("G").Value);
                    LedList[id].Color[2] = Convert.ToByte(led.Element("Color").Attribute("B").Value);

                    // Set intensity
                    LedList[id].Intensity = new double[3];
                    LedList[id].Intensity[0] = Convert.ToDouble(led.Element("Intensity").Attribute("R").Value);
                    LedList[id].Intensity[1] = Convert.ToDouble(led.Element("Intensity").Attribute("G").Value);
                    LedList[id].Intensity[2] = Convert.ToDouble(led.Element("Intensity").Attribute("B").Value);

                    // Test output
                    Console.WriteLine("Loading LED " + LedList[id]._id);

                    id++;
                }

                // Initialise RGBdata array with numLed*3 + 2 and set start and stop byte
                RGBdata = new byte[leds.Count() * 3 + 2];
                RGBdata[0] = 0x01;
                RGBdata[leds.Count() * 3 + 1] = 0x02;
                Console.WriteLine("Loading done...");

                return true;
            }
            catch (FileNotFoundException e)
            {
                return false;
            }
        }

        public void CreateProfile(string path)
        {
            Console.WriteLine("Start creating multilight profile");

            // Create general XML-File
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("LedLighter Profile"),
                new XElement("LedProfile",
                    new XAttribute("Mode", mode)
                    )
                );

            // Add multilight data
            for (int i = 0; i < LedList.Length; i++)
            {
                // Create new LED Element
                var addLed = new XElement("LED",
                    new XAttribute("LedID", i),
                    new XElement("RectID",
                        new XAttribute("Id", LedList[i].RectID)),
                    new XElement("Intensity",
                        new XAttribute("R", LedList[i].Intensity[0].ToString("0.##")),
                        new XAttribute("G", LedList[i].Intensity[1].ToString("0.##")),
                        new XAttribute("B", LedList[i].Intensity[2].ToString("0.##"))),
                    new XElement("Color",
                        new XAttribute("R", LedList[i].Color[0]),
                        new XAttribute("G", LedList[i].Color[1]),
                        new XAttribute("B", LedList[i].Color[2])
                        )
                    );

                doc.Element("LedProfile").Add(addLed);
            }

            // Save file
            doc.Save(path);
            Console.WriteLine("Finished creating multilight profile...");

        }
    }
}
