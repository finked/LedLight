using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace LedLight
{
    public partial class MainForm : Form
    {
        // TODO: Remove later and use profilemanager instead!
        //Ambilight LedLightProfile = new Ambilight();

        // Create profile manager
        ProfileManager LedLightManager = new ProfileManager();

        // TODO: Remove and outsource Data Handling
        ScreenDevice[] info;
        Screen[] getScreen = Screen.AllScreens;
        Rectangle screenrect = new Rectangle();

        int ScreenNumber;
        Bitmap bmp;
        Graphics gfx;

        public MainForm()
        {
            InitializeComponent();

            // Get profile files saved in the profile folder
            string curDir = Environment.CurrentDirectory;
            string addString = "../../profiles";
            string combi = Path.Combine(curDir, addString);
            DirectoryInfo dinfo = new DirectoryInfo(combi);
            FileInfo[] Files = dinfo.GetFiles("*.xml"); foreach (FileInfo file in Files)
            {
                ProfileListBox.Items.Add(file.Name);
            }

            // Get screen informations
            ScreenNumber = getScreen.Length;
            for (int i = 0; i < ScreenNumber; i++)
            {
                screenrect = Rectangle.Union(screenrect, getScreen[i].Bounds);
            }

            bmp = new Bitmap(screenrect.Width, screenrect.Height, PixelFormat.Format32bppArgb);
            gfx = Graphics.FromImage(bmp);

            gfx.CopyFromScreen(screenrect.X, screenrect.Y, 0, 0,
                        bmp.Size, CopyPixelOperation.SourceCopy);

            // Init list of possible profiles
            ProfileComboBox.Items.Add("Ambilight");
            ProfileComboBox.Items.Add("Monolight");
            ProfileComboBox.Items.Add("Multilight");

        }

        ~MainForm()
        {
            Console.WriteLine("Destructor of MainForm started.");
        }
        
        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Boolean result = LedLightManager.LoadProfile(openFileDialog1.FileName);
                
                // Check if loading was successful or not
                // TODO: When it failes show a message
                if (result == true)
                {
                    //editorTextBox.Clear();
                    //editorTextBox.AppendText("Load:" + openFileDialog1.FileName);
                }
                else
                {
                    //editorTextBox.Clear();
                    //editorTextBox.AppendText("Loading failed");
                }
            }
        }

        private void StartStopProfileButton_Click(object sender, EventArgs e)
        {
            if (StartStopProfileButton.Text == "Start Profile")
            {
                string profstr = Environment.CurrentDirectory;
                profstr = Path.Combine(profstr, "..\\..\\profiles\\");

                // TODO: Check if item is selected or give out a message to select one
                profstr += ProfileListBox.SelectedItem.ToString();

                /*
                // Activate loaded profile
                LedLightProfile.LoadProfile(profstr);
                LedLightProfile.ActivateProfile();
                 * */

                // TODO: Get and set profile type. Give it to profile manager for loading.

                // Load and activate profile
                LedLightManager.LoadProfile(profstr);
                LedLightManager.ActivateProfile();

                // Change button text
                StartStopProfileButton.Text = "Stop Profile";
            }
            else if (StartStopProfileButton.Text == "Stop Profile")
            {
                // Stop active profile
                LedLightManager.StopActiveProfile();

                // Change button text
                StartStopProfileButton.Text = "Start Profile";
            }
        }

        private void NewProfileButton_Click(object sender, EventArgs e)
        {
            // TODO: Open window with possibility to choose the mode
            Console.WriteLine("Opening window to create new profile...");

            if (ProfileComboBox.Text == "Monolight")
            {
                MonoLight newProf = new MonoLight();
                newProf.Color = new byte[]{0x00, 0x00, 0x00};
                MonolightForm secForm = new MonolightForm(newProf);
                secForm.Show();
            }
            else if (ProfileComboBox.Text == "Multilight")
            {
                MultiLight newProf = new MultiLight();
                MultiLightForm multiForm = new MultiLightForm(newProf);
                multiForm.Show();
            }
            else if (ProfileComboBox.Text == "Ambilight")
            {
                Ambilight newProf = new Ambilight();
                AmbilightForm ambiForm = new AmbilightForm(newProf);
                ambiForm.Show();
            }
            else
            {
                Console.WriteLine("No profile selected...");
            }
        }

        private void ChangeProfileButton_Click(object sender, EventArgs e)
        {
            // TODO:    Get profile data and mode. Open form and load data into it
            string profstr = Environment.CurrentDirectory;
            profstr = Path.Combine(profstr, "..\\..\\profiles\\");

            // TODO: Check if item is selected or give out a message to select one
            profstr += ProfileListBox.SelectedItem.ToString();

            Console.WriteLine("Changing " + ProfileListBox.SelectedItem.ToString() + " ...");

            LedLightManager.ChangeProfile(profstr);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ProfileListBox.Items.Clear();

            string curDir = Environment.CurrentDirectory;
            string addString = "../../profiles";
            string combi = Path.Combine(curDir, addString);
            DirectoryInfo dinfo = new DirectoryInfo(combi);
            FileInfo[] Files = dinfo.GetFiles("*.xml"); foreach (FileInfo file in Files)
            {
                ProfileListBox.Items.Add(file.Name);
            }
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            // TODO: Change folder shown in Form1 Window
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            // TODO: Delete selected profile
        }

        private void StartStopProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
