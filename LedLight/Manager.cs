using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedLight
{
    public class Manager
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //ScreenCapture sc = new ScreenCapture();

            //byte r, g, b;
            //sc.ScreenCap(out r, out g, out b);

        }

    }
}
