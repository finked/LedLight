using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Threading;

namespace LedLight
{
    public class MonoLight : LedLight
    {
        public int numLeds = 0;
        public byte[] Color;

        public MonoLight()
        {
        }

        ~MonoLight()
        {
        }

        public void CreateProfile(string path)
        {
            Console.WriteLine("Start creating profile");

            // Create general XML-File
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("LedLighter Profile"),
                new XElement("LedProfile",
                    new XAttribute("Mode", mode)
                    )
                );

            // Add number of leds
            var addLedNumber = new XAttribute("LedNumber", numLeds);
            doc.Element("LedProfile").Add(addLedNumber);

            // Add color
            var addColor = new XElement("Color",
                        new XAttribute("R", Color[0]),
                        new XAttribute("G", Color[1]),
                        new XAttribute("B", Color[2])
                        );
            doc.Element("LedProfile").Add(addColor);

            // Save file
            doc.Save(path);
            Console.WriteLine("Finished creating profile...");
        }

        public override bool LoadProfile(string profileName)
        {
            Console.WriteLine("Loading Profile: " + profileName);
            try
            {
                XDocument loadedXmlDoc = XDocument.Load(profileName);

                // Loading Mode
                mode = loadedXmlDoc.Element("LedProfile").Attribute("Mode").Value;

                // Find ledNumber
                numLeds = Convert.ToInt32(loadedXmlDoc.Element("LedProfile").Attribute("LedNumber").Value);

                // Find color
                byte r = Convert.ToByte(loadedXmlDoc.Element("LedProfile").Element("Color").Attribute("R").Value);
                byte g = Convert.ToByte(loadedXmlDoc.Element("LedProfile").Element("Color").Attribute("G").Value);
                byte b = Convert.ToByte(loadedXmlDoc.Element("LedProfile").Element("Color").Attribute("B").Value);

                Color = new byte[]{r, g, b};

                Console.WriteLine("Loading Done...");

                return true;
            }
            catch (FileNotFoundException e)
            {
                return false;
            }
        }

        public override void ActivateProfile()
        {
            Console.WriteLine("Activating monolight profile...");

            // Open serial port connection to the arduino board
            connect.Open();

            // Create bytearray to send the data to the arduino board
            byte[] RGBdata = new byte[numLeds * 3 + 2];

            // Set start and stop byte
            RGBdata[0] = 0x01;
            RGBdata[numLeds * 3 + 1] = 0x02;

            for (int i = 0; i < numLeds; ++i )
            {
                RGBdata[i * 3 + 1] = Color[0];
                RGBdata[i * 3 + 2] = Color[1];
                RGBdata[i * 3 + 3] = Color[2];

                // Check if there is a start or stop bit value and replace it with zero
                if (RGBdata[3 * i +1] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
                if (RGBdata[3 * i +2] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
                if (RGBdata[3 * i + 3] == (0x01 | 0x02))
                    RGBdata[i] = 0x00;
            }

            // Send data bytearray to ther arduino board
            Thread.Sleep(2000);
            connect.Send(RGBdata);

            Console.WriteLine("Profile activated...");
        }

        public void SetColor(byte r, byte g, byte b)
        {
            Color = new byte[] { r, g, b };

            /* Has to be a send function
            RGBdata = new byte[numLeds * 3];
            RGBdata[0] = 0x01;
            RGBdata[RGBdata.Length - 1] = 0x02;

            // Send one time for first not working sending
            connect.Send(RGBdata);

            for (int i = 1; i < RGBdata.Length -1 -2; i = i + 3)
            {
                if (r == (0x01 | 0x02))
                    r = 0x00;
                if (g == (0x01 | 0x02))
                    g = 0x00;
                if (b == (0x01 | 0x02))
                    b = 0x00;

                RGBdata[i] = r;
                RGBdata[i + 1] = g;
                RGBdata[i + 2] = b;
            }

            Console.WriteLine(r + ": " + g + ": " + b);
            connect.Send(RGBdata);
             */
        }
    }
}
