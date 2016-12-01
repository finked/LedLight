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
    public partial class MultiLightForm : Form
    {
        // TODO: Form should not create own Multilight class. Use profileManager instead.
        MultiLight newMulti = new MultiLight();
        int idindex = 1;

        public MultiLightForm(MultiLight profile)
        {
            InitializeComponent();

            this.newMulti = profile;

            showData();
        }

        private void CreateLedButton_Click(object sender, EventArgs e)
        {
            LED[] addLeds = new LED[Convert.ToInt32(NumLedUpDown.Value)];

            for (int i = 0; i < addLeds.Length; ++i )
            {
                addLeds[i]._id = idindex;
                addLeds[i].Color = new byte[] { Convert.ToByte(ColorRTextBox.Text), Convert.ToByte(ColorGTextBox.Text), Convert.ToByte(ColorBTextBox.Text) };
                addLeds[i].Intensity = new double[] { Convert.ToDouble(IntRTextBox.Text), Convert.ToDouble(IntGTextBox.Text), Convert.ToDouble(IntBTextBox.Text) };

                // PRINT_OUT
                Console.WriteLine("New Led added with id: " + idindex + ", Color: " + addLeds[i].Color[0] + " " + addLeds[i].Color[1] + " " + addLeds[i].Color[2] + " and Intensity: " + addLeds[i].Intensity[0] + " " + addLeds[i].Intensity[1] + " " + addLeds[i].Intensity[2]);

                idindex++;
            }
            newMulti.AddLeds(addLeds);

            showData();
        }

        private void showData()
        {
            LedListBox.Items.Clear();

            for (int i = 0; i < newMulti.LedList.Length; ++i )
            {
                LedListBox.Items.Add(newMulti.LedList[i]._id);
            }

            NumLedUpDown.Value = newMulti.LedList.Length;
        }

        private void MultiLightForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            // Change it so it works with multiple selected elements
            LED LedChange = new LED();

            for (int i = 0; i < LedListBox.SelectedIndices.Count; ++i)
            {
                int selId = Convert.ToInt32(LedListBox.SelectedIndices[i]);

                LedChange.Color = new byte[] { Convert.ToByte(ColorRTextBox.Text), Convert.ToByte(ColorGTextBox.Text), Convert.ToByte(ColorBTextBox.Text) };
                LedChange.Intensity = new double[] { Convert.ToDouble(IntRTextBox.Text), Convert.ToDouble(IntGTextBox.Text), Convert.ToDouble(IntBTextBox.Text) };

                LedChange._id = selId;

                newMulti.SetLed(LedChange);
            }

            showData();
        }

        private void LedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LED[] LedData = newMulti.GetLedData();

            int selId = Convert.ToInt32(LedListBox.SelectedIndex);

            // Set Color
            ColorRTextBox.Text = LedData[selId].Color[0].ToString();
            ColorGTextBox.Text = LedData[selId].Color[1].ToString();
            ColorBTextBox.Text = LedData[selId].Color[2].ToString();

            // Set Intensity
            IntRTextBox.Text = LedData[selId].Intensity[0].ToString();
            IntGTextBox.Text = LedData[selId].Intensity[1].ToString();
            IntBTextBox.Text = LedData[selId].Intensity[2].ToString();
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
            newMulti.mode = "Multilight";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newMulti.CreateProfile(saveFileDialog1.FileName);
            }
        }

        private void DeleteLedButton_Click(object sender, EventArgs e)
        {
            // Get number of selected items
            int SelLedCount = LedListBox.SelectedIndices.Count;

            // Get Led Numbers out of ListBox
            int[] LedIdList = new int[SelLedCount];

            for (int i = 0; i < SelLedCount; ++i)
            {
                // TODO: Get correct index out of the string
                LedIdList[i] = LedListBox.SelectedIndices[i];

                // PRINT_OUT
                Console.WriteLine("Delete Led with id: " + LedListBox.SelectedIndices[i]);
            }

            // Delete leds in profile
            newMulti.RemLeds(LedIdList);

            showData();
        }
    }
}
