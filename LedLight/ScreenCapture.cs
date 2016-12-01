using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimDX.Direct3D9;

namespace LedLight
{
    class ScreenCapture
    {
        public Device[] d;

        public ScreenCapture ()
        {
            PresentParameters present_params = new PresentParameters();
            present_params.Windowed = true;
            present_params.SwapEffect = SwapEffect.Discard;

            // Get number of devices
            // TODO: Possibility with Direct3D?
            int ScreenNumber = Screen.AllScreens.Length;

            d = new Device[ScreenNumber];
            for (int i = 0; i < ScreenNumber; i++ )
            {
                d[i] = new Device(new Direct3D(), i, DeviceType.Hardware, IntPtr.Zero, CreateFlags.SoftwareVertexProcessing, present_params);
            }

            //d1 = new Device(new Direct3D(), 1, DeviceType.Hardware, IntPtr.Zero, CreateFlags.SoftwareVertexProcessing, present_params);
        }

        ~ScreenCapture()
        {

        }

        public Surface CaptureScreen(Device device)
        {
            Surface s = Surface.CreateOffscreenPlain(device, Screen.PrimaryScreen.Bounds.Width, 
                Screen.PrimaryScreen.Bounds.Height, Format.A8R8G8B8, Pool.Scratch);
            device.GetFrontBufferData(0, s);
            return s;
        }

        /*
        public Surface CaptureScreenMulti()
        {
            Screen[] MultScreen = Screen.AllScreens;
            int ScreenNumber = MultScreen.Length;

            Rectangle screenrect = new Rectangle(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
            for (int i = 0; i < ScreenNumber; i++)
            {
                screenrect = Rectangle.Union(screenrect, MultScreen[i].Bounds);
            }

            Surface s = Surface.CreateOffscreenPlain(d, screenrect.Width,
                screenrect.Height, Format.A8R8G8B8, Pool.Scratch);
            d.GetFrontBufferData(0, s);
            return s;
        }
         * */
    }
}
