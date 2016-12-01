using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedLight
{
    public partial class MonolightForm : Form
    {
        private MonoLight monLight = new MonoLight();

        public MonolightForm(MonoLight profile)
        {
            InitializeComponent();
            this.monLight = profile;

            showData();
        }

        private void showData()
        {
            ColorRTextBox.Text = monLight.Color[0].ToString();
            ColorGTextBox.Text = monLight.Color[1].ToString();
            ColorBTextBox.Text = monLight.Color[2].ToString();

            NumLedUpDown.Value = monLight.numLeds;
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            // Check if ok button was pressed and a color selected
            if (result == DialogResult.OK)
            {
                //Show Color in color field
                ColorRTextBox.Text = colorDialog1.Color.R.ToString();
                ColorGTextBox.Text = colorDialog1.Color.G.ToString();
                ColorBTextBox.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {            
            // Profile settings
            monLight.mode = "Monolight";

            // TODO: Change structure of profilmanager for mono and multilight
            monLight.numLeds = Convert.ToInt32(NumLedUpDown.Value);
            monLight.SetColor(Convert.ToByte(ColorRTextBox.Text), Convert.ToByte(ColorGTextBox.Text), Convert.ToByte(ColorBTextBox.Text));

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                monLight.CreateProfile(saveFileDialog1.FileName);
            }
        }
    }
}
