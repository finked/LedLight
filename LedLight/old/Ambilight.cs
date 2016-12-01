using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SlimDX.Direct3D9;
using SlimDX;
using System.Xml.Linq;
using System.IO;

namespace LedLight
{
    // TODO:    Still working with old multiscreencapture? Check it!
    public class Ambilight : MultiLightManager
    {
        ScreenDevice[] mon;
        int monNumber = 0;

        // diagnostics
        Stopwatch sw = new Stopwatch();
        // Connector
        UsbConnect connect = new UsbConnect();


        // Dx capture
        ScreenCapture sc = new ScreenCapture();
        const int Bpp = 4;
        // Dx end

        // datastructure
        byte[] r; byte[] g; byte[] b; // Use for BlockAmbilight
        //byte r; byte g; byte b; // Use for ScreenAmbilight

        Bitmap bmp;
        Graphics gfx;
        Screen[] MultScreen;
        int ScreenNumber = 0;
        //int BlockNumber;
        Rectangle[] rect;
        Rectangle screenrect;
        Rectangle screenrect1;

        BitmapData srcData;
        //Bitmap recBitmap;
        //Graphics recGraphic;
        IntPtr Scan0;
        int stride;
        long[] totals;

        //threadbedingung
        //Thread ambiThread;
        private volatile bool isStarted = false;

        // Rectangle byte array for average values
        byte[] avgRect;

        public Ambilight()
        {
            // Make objects for storage/processing of images
            MultScreen = Screen.AllScreens;
            ScreenNumber = MultScreen.Length;

            //BMP erstellen
            screenrect = new Rectangle(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
            for (int i = 0; i < ScreenNumber; i++)
            {
                screenrect = Rectangle.Union(screenrect, MultScreen[i].Bounds);
            }

            screenrect1 = new Rectangle(0,0,screenrect.Width-1,screenrect.Height-1);

            bmp = new Bitmap(screenrect.Width, screenrect.Height, PixelFormat.Format24bppRgb);

            //BMP fuellen
            gfx = Graphics.FromImage(bmp);   

            // Initialize empty parts
            mon = new ScreenDevice[0];
            LedList = new LED[0];
        }

        ~Ambilight()
        {
            Console.WriteLine("Destructor of Ambilight started.");
        }

        private void loop()
        {
            while( isStarted == true)
            {
                //sw.Reset();
                //sw.Start(); 
                //BlockScreenCap();
                DXBlockScreenCap();
                /*
                sw.Stop();
                
                TimeSpan ts = sw.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}", ts.Hours, ts.Minutes,
                    ts.Seconds, ts.Milliseconds);
                Console.WriteLine("Time needed: " + elapsedTime);
                */
                // Console.WriteLine("RGBdata: " + RGBdata);
                connect.Send(RGBdata);

                //await Task.Delay(1);
            }
        }

        public void BlockScreenCap()
        {
            //GET screenBMP
            gfx.CopyFromScreen(MultScreen[ScreenNumber - 1].Bounds.X, MultScreen[ScreenNumber - 1].Bounds.Y, 0, 0,
            bmp.Size, CopyPixelOperation.SourceCopy);

            
            srcData = bmp.LockBits(
            screenrect1,
            ImageLockMode.ReadOnly,
            PixelFormat.Format24bppRgb);

            stride = srcData.Stride;
            Scan0 = srcData.Scan0;

            // Get RectangleValues and fill byte array
            for (int i = 0; i < rect.Length; i++)
            {
                RectCapture(i);
            }

            bmp.UnlockBits(srcData);
        }

        public void RectCapture(int index)
        {
            int RGBindex = index * 3;

            totals[0] = 0;
            totals[1] = 0;
            totals[2] = 0;            
            
            int width = rect[index].Width;
            int height = rect[index].Height;
            int step = 32;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y += step)
                {
                    for (int x = 0; x < width; x += step)
                    {
                        for (int color = 0; color < 3; color++)
                        {
                            int idx = ((rect[index].Y + y) * stride) + (rect[index].X + x) * 3 + color;
                            totals[color] += p[idx];
                        }
                    }
                }
            }

            byte avgR = (byte)(totals[2] / (width * height / step / step));
            byte avgG = (byte)(totals[1] / (width * height / step / step));
            byte avgB = (byte)(totals[0] / (width * height / step / step));

            //Console.WriteLine(index+": "+avgR+" "+avgG+" "+avgB+" : "+totals[2]+"/"+ (width * height / step / step));

            if (avgR == 0x01 | avgR == 0x02)
            {
                avgR = 0x00;
            }
            if (avgG == 0x01 | avgG == 0x02)
            {
                avgG = 0x00;
            }
            if (avgB == 0x01 | avgB == 0x02)
            {
                avgB = 0x00;
            }

            RGBdata[RGBindex + 1] = avgR;
            RGBdata[RGBindex + 2] = avgG;
            RGBdata[RGBindex + 3] = avgB;
        }

        public bool ScreenCap(out byte[] r, out byte[] g, out byte[] b)
        {
            Bitmap[] bmp;
            Graphics[] gfx;

            int ScreenNumber = 0;

            try
            {
                // Make objects for storage/processing of images
                Screen[] MultScreen = Screen.AllScreens;
                ScreenNumber = MultScreen.Length;

                bmp = new Bitmap[ScreenNumber];
                gfx = new Graphics[ScreenNumber];

                for (int i = 0; i < ScreenNumber; i++)
                {
                    int ScreenWidth = MultScreen[i].Bounds.Width;
                    int ScreenHeigth = MultScreen[i].Bounds.Height;

                    bmp[i] = new Bitmap(ScreenWidth, ScreenHeigth, PixelFormat.Format24bppRgb);
                    gfx[i] = Graphics.FromImage(bmp[i]);
                    gfx[i].CopyFromScreen(MultScreen[i].Bounds.X, MultScreen[i].Bounds.Y, 0, 0,
                        bmp[i].Size, CopyPixelOperation.SourceCopy);
                }
            }
            catch
            {
                r = new byte[1] { 0 };
                g = new byte[1] { 0 };
                b = new byte[1] { 0 };
                return false;
            }

            // Analyze the screen capture:

            r = new byte[ScreenNumber];
            g = new byte[ScreenNumber];
            b = new byte[ScreenNumber];

            for (int i = 0; i < ScreenNumber; i++)
            {
                BitmapData srcData = bmp[i].LockBits(
                new Rectangle(0, 0, bmp[i].Width, bmp[i].Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

                int stride = srcData.Stride;
                IntPtr Scan0 = srcData.Scan0;
                long[] totals = new long[] { 0, 0, 0 };
                int width = bmp[i].Width;
                int height = bmp[i].Height;
                int step = 4;

                unsafe
                {
                    byte* p = (byte*)(void*)Scan0;
                    for (int y = 0; y < height; y += step)
                    {
                        for (int x = 0; x < width; x += step)
                        {
                            for (int color = 0; color < 3; color++)
                            {
                                int idx = (y * stride) + x * 3 + color;
                                totals[color] += p[idx];
                            }
                        }
                    }
                }

                byte avgR = (byte)(totals[2] / (width * height / step / step));
                byte avgG = (byte)(totals[1] / (width * height / step / step));
                byte avgB = (byte)(totals[0] / (width * height / step / step));

                r[i] = avgR;
                b[i] = avgB;
                g[i] = avgG;

                bmp[i].UnlockBits(srcData);
                bmp[i].Dispose();
                gfx[i].Dispose();
            }
            return true;
        }

        private void DXBlockScreenCap()
        {
            // Console.WriteLine("DXBlockScreenCap started. myScreens.Length: " + myScreens.Length);
            for (int i = 0; i < mon.Length; i++)
            {
                // Console.WriteLine("DXBlockScreenCap loop started.");
                Surface s;
                s = sc.CaptureScreen(sc.d[i]);

                DataRectangle dr = s.LockRectangle(LockFlags.None);
                DataStream gs = dr.Data;

                DXRectCapture(gs, i);

                s.UnlockRectangle();
                s.Dispose();
            }
            // Console.WriteLine("DXBlockScreenCap finished.");
        }

        private void DXRectCapture(DataStream gs, int screenID)
        {
            // Console.WriteLine("DX RectCapture started.");
            int avgRectScreenStart = 0;
            for (int i = 0; i < screenID; i++ )
            {
                avgRectScreenStart += mon[i].Rect.Length*3;
            }

            // Console.WriteLine("TEEEST " + mon[screenID].Rect.Length);
            for (int index = 0; index < mon[screenID].Rect.Length; index++)
            {
                int RGBindex = index * 3;
                byte[] bu = new byte[4];

                // Calculate positions of rectangle
                int width = mon[screenID].Rect[index].Width;
                int height = mon[screenID].Rect[index].Height;

                int screenWidth = mon[screenID].Width;

                int startpos = (mon[screenID].Rect[index].X) + (mon[screenID].Rect[index].Y) * screenWidth;

                int step = 8;

                int r = 0;
                int g = 0;
                int b = 0;

                int numPoints = 0;
                for (int y = 0; y < height; y = y + step)
                {
                    for (int x = 0; x < width; x = x + step)
                    {
                        gs.Position = 4 * (startpos + x + y * screenWidth);
                        gs.Read(bu, 0, 4);
                        r += bu[2];
                        g += bu[1];
                        b += bu[0];
                        numPoints++;
                    }
                }

                // Calculate average colors
                // Check if numPoints is zero
                if (numPoints == 0)
                { 
                    numPoints = 1; 
                }
                byte avgR = (byte)(r / numPoints);
                byte avgG = (byte)(g / numPoints);
                byte avgB = (byte)(b / numPoints);

                // Console.WriteLine(index+": "+avgR+" "+avgG+" "+avgB);

                avgRect[index * 3 + avgRectScreenStart] = avgR;
                avgRect[index * 3 + avgRectScreenStart + 1] = avgG;
                avgRect[index * 3 + avgRectScreenStart + 2] = avgB;
            }

            // Calculate LED Data
            // TODO:    Check if values exist
            for (int i = 0; i < LedList.Length; i++)
            {
                int avgPos = LedList[i].RectID * 3;
                int LedPos = i * 3;

                RGBdata[LedPos + 1] = (byte)(avgRect[avgPos] * LedList[i].Intensity[0]);
                RGBdata[LedPos + 2] = (byte)(avgRect[avgPos + 1] * LedList[i].Intensity[1]);
                RGBdata[LedPos + 3] = (byte)(avgRect[avgPos + 2] * LedList[i].Intensity[2]);

                if (RGBdata[LedPos + 1] == 0x01 | RGBdata[LedPos + 1] == 0x02)
                {
                    RGBdata[LedPos + 1] = 0x00;
                }
                if (RGBdata[LedPos + 2] == 0x01 | RGBdata[LedPos + 2] == 0x02)
                {
                    RGBdata[LedPos + 2] = 0x00;
                }
                if (RGBdata[LedPos + 3] == 0x01 | RGBdata[LedPos + 3] == 0x02)
                {
                    RGBdata[LedPos + 3] = 0x00;
                }
              //  Console.WriteLine(avgPos + " : LedPos = " + LedPos);
            }
        }
        
/* --------------------------------------------------------------------------------------------- */

        public void CreateProfile(string path)
        {
            Console.WriteLine("starte Create Profile");

            // Create general XML-File
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("LedLighter Profile"),
                new XElement("LedProfile",
                    new XAttribute("Mode", mode)
                    )
                );

            // Add ambilight data
            int RectId = 0;

            for (int i = 0; i < mon.Length; i++)
            {
                // Add new screen
                var addScreen = new XElement("Screen",
                    new XAttribute("ScreenId", i),
                    new XElement("ScreenData",
                        new XAttribute("Width", mon[i].Width),
                        new XAttribute("Height", mon[i].Height),
                        new XAttribute("XPos", mon[i].XPos),
                        new XAttribute("YPos", mon[i].YPos)
                        )
                );

                doc.Element("LedProfile").Add(addScreen);

                for (int j = 0; j < mon[i].Rect.Length; j++)
                {
                    // Add new rectangle
                    var addRect = new XElement("Rectangle",
                        new XAttribute("RectId", RectId),
                        new XAttribute("X", mon[i].Rect[j].X),
                        new XAttribute("Y", mon[i].Rect[j].Y),
                        new XAttribute("W", mon[i].Rect[j].Width),
                        new XAttribute("H", mon[i].Rect[j].Height)
                        );

                    var cust = doc.Element("LedProfile").Descendants("Screen")
                    .First(c => c.Attribute("ScreenId").Value == i.ToString());
                    cust.Add(addRect);

                    RectId++;
                }
            }

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
            Console.WriteLine("Finished creating profile...");

        }

        public override bool LoadProfile(string profileName)
        {
            Console.WriteLine("Loading Profile: " + profileName);
            try
            {
                XDocument loadedXmlDoc = XDocument.Load(profileName);

                var screens = loadedXmlDoc.Element("LedProfile").Descendants("Screen");
                var leds = loadedXmlDoc.Element("LedProfile").Descendants("LED");

                // Loading Mode
                mode = loadedXmlDoc.Element("LedProfile").Attribute("Mode").Value;

                // Find screens and define rectangles
                int screenid = 0;
                mon = new ScreenDevice[screens.Count()];

                Console.WriteLine("new mons: " + screens.Count());

                foreach (var screen in screens)
                {
                    screenid = Convert.ToInt32(screen.Attribute("ScreenId").Value);
                    mon[screenid] = new ScreenDevice();
                    int numRect = screen.Elements("Rectangle").Count();

                    mon[screenid].Rect = new Rectangle[numRect];

                    mon[screenid].Width = Convert.ToInt32(screen.Element("ScreenData").Attribute("Width").Value);
                    mon[screenid].Height = Convert.ToInt32(screen.Element("ScreenData").Attribute("Height").Value);

                    mon[screenid].XPos = Convert.ToInt32(screen.Element("ScreenData").Attribute("XPos").Value);
                    mon[screenid].YPos = Convert.ToInt32(screen.Element("ScreenData").Attribute("YPos").Value);

                    var rects = screen.Descendants("Rectangle");

                    int rectNr = 0;
                    foreach (var rect in rects)
                    {
                        mon[screenid].Rect[rectNr] = new Rectangle();

                        mon[screenid].Rect[rectNr].X = Convert.ToInt32(rect.Attribute("X").Value);
                        mon[screenid].Rect[rectNr].Y = Convert.ToInt32(rect.Attribute("Y").Value);
                        mon[screenid].Rect[rectNr].Width = Convert.ToInt32(rect.Attribute("W").Value);
                        mon[screenid].Rect[rectNr].Height = Convert.ToInt32(rect.Attribute("H").Value);

                        // Console.WriteLine("Loading Rectangle " + rectNr + " with X = " + mon[screenid].Rect[rectNr].X + " and Y = " + mon[screenid].Rect[rectNr].Y + " ScreenId = " + screenid);

                        rectNr++;
                    }
                }

                // Find leds

                int id = 0;
                int numLed = leds.Count();
                LedList = new LED[numLed];

                r = new byte[numLed];
                g = new byte[numLed];
                b = new byte[numLed];

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

                    //Set rectangleID
                    LedList[id].RectID = Convert.ToInt32(led.Element("RectID").Attribute("Id").Value);

                    // Test output
                    //Console.WriteLine("Loading LED " + LedList[id]._id + ": " + "RectId = " + LedList[id].RectID);

                    id++;
                }

                int RectTot = 0;
                for (int i = 0; i < mon.Length; i++)
                {
                    RectTot += mon[i].Rect.Length;
                }
                avgRect = new byte[RectTot * 3];

                // Initialise RGBdata array with numLed*3 + 2 and set start and stop byte
                RGBdata = new byte[leds.Count()*3 + 2];
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

        public override void ActivateProfile()
        {
            Console.WriteLine("Activating ambilight profile...");

            //SetData(LedList, mon);

            //ambiThread = new Thread(new ThreadStart(loop));

            connect.Open();

            isStarted = true;

            Console.WriteLine("Starting Ambilight Loop...");
            var task = Task.Factory.StartNew(loop, TaskCreationOptions.LongRunning);
            //task.RunSynchronously();
            //task.Start();
            //ambiThread.Start();

            Console.WriteLine("Profile activated...");
        }

        public override void StopProfile()
        {
            Console.WriteLine("Stopping ambilight profile...");

            isStarted = false;

            bmp.Dispose();
            gfx.Dispose();

            connect.Close();
        }

/* --------------------------------------------------------------------------------------------- */

        public void AddRectangles(Rectangle[] newRecs, int ScreenNumber)
        {
            // TODO:    Add rectangles to profile
            //          Check boundaries of screen when inserting rectangles
            //          LedIds must be set somehow

            // Check if screem exists. If not create a new one
            if (ScreenNumber >= mon.Length)
            {
                Console.WriteLine("Screen does not exist...");
            }
            else
            {
                Console.WriteLine("Adding new rectangles...");

                // Reallocate number of rectangles
                int oldlength = 0;

                oldlength = mon[ScreenNumber].Rect.Length;

                Rectangle[] buffRec = mon[ScreenNumber].Rect;

                Console.WriteLine("Old rectangle length is " + oldlength);
                mon[ScreenNumber].Rect = new Rectangle[oldlength + newRecs.Length];
                Console.WriteLine("New rectangle length is " + mon[ScreenNumber].Rect.Length);

                // Fill new rectangles with data
                for (int i = 0; i < mon[ScreenNumber].Rect.Length; ++i)
                {
                    if(i < oldlength)
                    {
                        Console.WriteLine("Fill array with old data...");
                        mon[ScreenNumber].Rect[i] = buffRec[i];
                    }
                    else
                    {
                        Console.WriteLine("Fill array with new data...");
                        mon[ScreenNumber].Rect[i] = newRecs[i-oldlength];
                    }
                    Console.WriteLine("New rectangle created...");
                }
            }
        }

        public void RemRectangles(int[] IdSet)
        {
            // Find screen fitting to Id
            int screenNr = 0;
            int numRecs = mon[0].Rect.Length;

            for (int i = 0; i < IdSet.Length; ++i)
            {
                Console.WriteLine("Removing rectangle " + IdSet[i] + " ...");

                while (numRecs < IdSet[i])
                {
                    screenNr++;
                    numRecs += mon[screenNr].Rect.Length;
                }

                // Create new rectangle array
                Rectangle[] newRecArray = new Rectangle[mon[screenNr].Rect.Length - 1];
                for (int j = 0; j < mon[screenNr].Rect.Length - 1; ++j)
                {
                    int screenId = IdSet[i] - numRecs + mon[screenNr].Rect.Length;
                    if (j < screenId)
                    {
                        newRecArray[j] = mon[screenNr].Rect[j];
                    }
                    else
                    {
                        newRecArray[j] = mon[screenNr].Rect[j + 1];
                    }
                }

                // Set new rectangle array to screen array
                mon[screenNr].Rect = newRecArray;
            }
        }

        /* TODO:    Remove only one rectangle

        public void RemRectangles(int IdSet)
        {
            // Find screen fitting to Id
            int screenNr = 0;
            int numRecs = mon[0].Rect.Length;
            for (int i = 0; i < IdSet.Length; ++i)
            {
                while (numRecs < IdSet[i])
                {
                    screenNr++;
                    numRecs += mon[screenNr].Rect.Length;
                }

                // Create new rectangle array
                Rectangle[] newRecArray = new Rectangle[mon[screenNr].Rect.Length - 1];
                for (int j = 0; j < mon[screenNr].Rect.Length - 1; ++j)
                {
                    if (j < IdSet[i] - numRecs + mon[screenNr].Rect.Length)
                    {
                        newRecArray[j] = mon[screenNr].Rect[j];
                    }
                    else
                    {
                        newRecArray[j] = mon[screenNr].Rect[j + 1];
                    }
                }

                // Set new rectangle array to screen array
                mon[screenNr].Rect = newRecArray;

                Console.WriteLine("Rectangle " + IdSet + " removed...");
            }
        }
         * */

        public Rectangle GetRec(int index)
        {
            int screenNr = 0;
            int RectNr = 0;
            while (RectNr <= index)
            {
                RectNr += mon[screenNr].Rect.Length;
                screenNr++;
            }
            return mon[screenNr-1].Rect[index-RectNr+mon[screenNr-1].Rect.Length];
        }

        public void ChangeRec(Rectangle changedRec, int[] index)
        {
            int screenNr = 0;
            int RectNr = 0;

            for (int i = 0; i < index.Length; ++i)
            {
                while(index[i] > RectNr)
                {
                    RectNr += mon[screenNr].Rect.Length;
                    screenNr++;
                }

                // Check if there is a new value and replace old value in this case
                int recId = index[i] - RectNr + mon[screenNr-1].Rect.Length;

                if (changedRec.X != null)
                {
                    mon[screenNr-1].Rect[recId].X = changedRec.X;
                }
                if (changedRec.Y != null)
                {
                    mon[screenNr-1].Rect[recId].Y = changedRec.Y;
                }
                if (changedRec.Width != null)
                {
                    mon[screenNr-1].Rect[recId].Width = changedRec.Width;
                }
                if (changedRec.Height != null)
                {
                    mon[screenNr-1].Rect[recId].Height = changedRec.Height;
                }
            }
        }

/* --------------------------------------------------------------------------------------------- */

        public void AddScreen(ScreenDevice addScreen)
        {
            Console.WriteLine("Adding new screen...");

            // TODO: Test if we can use mon instead or if it is overwritten
            Array.Resize(ref mon, monNumber + 1);
            monNumber++;

            Console.WriteLine("Length of mon is " + mon.Length + " and monNumber is " + monNumber);

            // Put in old screens

            // Add new screen
            mon[mon.Length - 1] = addScreen;

            // Initialize rectangles
            mon[mon.Length - 1].Rect = new Rectangle[0];
        }

        public void RemScreen(int index)
        {
            // TODO:    Is there a better way to rallocate the array and remove one object from between?
            //          Same with removing LEDs or Rectangles

            // Create smaller screen array
            ScreenDevice[] NewMon = new ScreenDevice[mon.Length-1];

            // Fill it with old screens
            for (int i = 0; i < NewMon.Length; ++i)
            {
                if (i < index)
                {
                    NewMon[i] = mon[i];
                    NewMon[i].Rect = mon[i].Rect;
                    NewMon[i].Height = mon[i].Height;
                    NewMon[i].Width = mon[i].Width;
                    NewMon[i].XPos = mon[i].XPos;
                    NewMon[i].YPos = mon[i].YPos;
                }
                else if (i >= index)
                {
                    NewMon[i] = mon[i + 1];
                    NewMon[i].Rect = mon[i + 1].Rect;
                    NewMon[i].Height = mon[i + 1].Height;
                    NewMon[i].Width = mon[i + 1].Width;
                    NewMon[i].XPos = mon[i + 1].XPos;
                    NewMon[i].YPos = mon[i + 1].YPos;
                }
            }

            // Replace original screen array mon
            mon = NewMon;
        }

        public ScreenDevice[] GetSceenData()
        {
            return mon;
        }

        public ScreenDevice GetSceenData(int index)
        {
            return mon[index];
        }

        public void ChangeScreen(ScreenDevice changedScreen, int index)
        {
            mon[index] = changedScreen;
        }
    }
}
