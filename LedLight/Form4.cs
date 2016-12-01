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
    public partial class AmbilightForm : Form
    {

        Ambilight newAmbi = new Ambilight();

        int idindex = 1;

        public AmbilightForm(Ambilight profile)
        {
            InitializeComponent();
            GetMaxId();

            this.newAmbi = profile;

            showData();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void showData()
        {
            // Show led data
            LedListBox.Items.Clear();
            for (int i = 0; i < newAmbi.LedList.Length; ++i)
            {
                LedListBox.Items.Add(newAmbi.LedList[i]._id);
            }

            // Show rectangle and screen data
            RecListBox.Items.Clear();
            ScreenListBox.Items.Clear();

            ScreenDevice[] getScreen = newAmbi.GetSceenData();

            int _id = 0;

            for (int j = 0; j < getScreen.Length; ++j)
            {
                ScreenListBox.Items.Add("Screen" + j);

                // TODO: Implement rectangle ids and get correct values
                for (int i = 0; i < getScreen[j].Rect.Length; ++i)
                {
                    RecListBox.Items.Add(_id);
                    _id++;
                }
            }

            // Show data in picturebox
            if (ScreenListBox.Items.Count > 0)
            {
                DrawScreenPreview();
            }
        }

        private void DrawScreenPreview()
        {
            // Get screen data and calculate max width and height
            ScreenDevice[] drawScreens = newAmbi.GetSceenData();
            int xLength = 0;
            int yLength = 0;

            for (int i = 0; i < drawScreens.Length; ++i)
            {
                if (drawScreens[i].XPos + drawScreens[i].Width > xLength)
                {
                    xLength = drawScreens[i].XPos + drawScreens[i].Width;
                }

                if (drawScreens[i].YPos + drawScreens[i].Height > yLength)
                {
                    yLength = drawScreens[i].YPos + drawScreens[i].Height;
                }
            }

            // Create bitmap with calculated screen values
            if (xLength != 0 && yLength != 0)
            {
                Bitmap bmp = new Bitmap(xLength, yLength);
                Graphics gfx = Graphics.FromImage(bmp);

                Rectangle screenrect = new Rectangle();

                // Create screens on pictureBox
                for (int i = 0; i < drawScreens.Length; ++i)
                {
                    Rectangle screen = new Rectangle();
                    screen.X = drawScreens[i].XPos;
                    screen.Y = drawScreens[i].YPos;
                    screen.Width = drawScreens[i].Width;
                    screen.Height = drawScreens[i].Height;

                    PaintEventArgs screenPaintEvent = new PaintEventArgs(gfx, screenrect);
                    Pen drawPen = new Pen(Color.Blue, 6);
                    screenPaintEvent.Graphics.DrawRectangle(drawPen, screen);
                }

                // Create rectangles on pictureBox
                int RectID = 0;

                int listindex = 0;

                for (int i = 0; i < drawScreens.Length; i++)
                {
                    for (int j = 0; j < drawScreens[i].Rect.Length; j++)
                    {
                        // Check the monitor position to each other
                        Rectangle rec = new Rectangle();
                        // Draw rectangles a bit smaller if they are large enough
                        if (drawScreens[i].Rect[j].Width > 3 && drawScreens[i].Rect[j].Height > 3)
                        {
                            rec.Width = drawScreens[i].Rect[j].Width-3;
                            rec.Height = drawScreens[i].Rect[j].Height-3;
                        }
                        else
                        {
                            rec.Width = drawScreens[i].Rect[j].Width;
                            rec.Height = drawScreens[i].Rect[j].Height;
                        }
                        rec.X = drawScreens[i].XPos + drawScreens[i].Rect[j].X;
                        rec.Y = drawScreens[i].YPos + drawScreens[i].Rect[j].Y;

                        PaintEventArgs recPaintEvent = new PaintEventArgs(gfx, screenrect);
                        // Check if rectangle should be drawn white or red
                        Pen drawPen;

                        // Check if item is selected or not
                        if (RecListBox.Items.Count != 0 && RecListBox.SelectedIndices.Count > listindex && RectID == RecListBox.SelectedIndices[listindex])
                        {
                            drawPen = new Pen(Color.White, 3);
                            listindex++;
                        }
                        else
                        {
                            drawPen = new Pen(Color.Red, 3);
                        }
                        recPaintEvent.Graphics.DrawRectangle(drawPen, rec);

                        RectID++;
                    }
                }

                // Show picture in picturebox
                ScreenPictureBox.Image = bmp;
            }
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            // Profile settings
            newAmbi.mode = "Ambilight";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newAmbi.CreateProfile(saveFileDialog1.FileName);
            }
        }

        private void GetMaxId()
        {
            // Get LED list from ambilight
            LED[] LedList = newAmbi.LedList;

            // Search for highest id and set idindex to it
            for (int i = 0; i < LedList.Length; ++i)
            {
                if (LedList[i]._id > idindex)
                {
                    idindex = LedList[i]._id;
                }
            }
        }

/* --------------------------------------------------------------------------------------------- */

        private void CreateScreen_Click(object sender, EventArgs e)
        {
            // Check if screen values are valid numbers
            if (CheckTextFieldValue(ScreenXPosTextBox.Text) &&
                CheckTextFieldValue(ScreenYPosTextBox.Text) &&
                CheckTextFieldValue(ScreenWidthTextBox.Text) &&
                CheckTextFieldValue(ScreenHeightTextBox.Text))
            {
                // Get screen values and create new screen
                ScreenDevice addScreen = new ScreenDevice();
                addScreen.Rect = new Rectangle[0];

                addScreen.XPos = Convert.ToInt32(ScreenXPosTextBox.Text);
                addScreen.YPos = Convert.ToInt32(ScreenYPosTextBox.Text);
                addScreen.Width = Convert.ToInt32(ScreenWidthTextBox.Text);
                addScreen.Height = Convert.ToInt32(ScreenHeightTextBox.Text);

                // Adding new screens to ambilight
                newAmbi.AddScreen(addScreen);

                showData();

                ScreenDevice[] getScreen = newAmbi.GetSceenData();
                Console.WriteLine("New Number of Screens is " + getScreen.Length);
            }
            else
            {
                MessageBox.Show("Please enter positive numbers");
            }
        }

        private void DeleteScreenButton_Click(object sender, EventArgs e)
        {
            newAmbi.RemScreen(ScreenListBox.SelectedIndex);

            showData();
        }

        private void ChangeScreenButton_Click(object sender, EventArgs e)
        {
            // Check if screen values are valid numbers
            if (CheckTextFieldValue(ScreenXPosTextBox.Text) &&
                CheckTextFieldValue(ScreenYPosTextBox.Text) &&
                CheckTextFieldValue(ScreenWidthTextBox.Text) &&
                CheckTextFieldValue(ScreenHeightTextBox.Text))
            {
                ScreenDevice changedScreen = new ScreenDevice();
                changedScreen.Rect = new Rectangle[0];

                // Get screen values and create new screen
                ScreenDevice addScreen = new ScreenDevice();
                changedScreen.XPos = Convert.ToInt32(ScreenXPosTextBox.Text);
                changedScreen.YPos = Convert.ToInt32(ScreenYPosTextBox.Text);
                changedScreen.Width = Convert.ToInt32(ScreenWidthTextBox.Text);
                changedScreen.Height = Convert.ToInt32(ScreenHeightTextBox.Text);

                if (ScreenListBox.SelectedIndex != -1)
                {
                    newAmbi.ChangeScreen(changedScreen, ScreenListBox.SelectedIndex);

                    showData();
                }
                else
                {
                    MessageBox.Show("Please select a screen to change!");
                }
            }
            else
            {
                MessageBox.Show("Please enter positive numbers!");
            }
        }

        private void ScreenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get screen index of selected screen
            int index = ScreenListBox.SelectedIndex;

            // Get screen information from ambilight

            if (index != -1)
            {
                ScreenDevice selScreen = newAmbi.GetSceenData(index);

                // Show information of selected screen
                ScreenXPosTextBox.Text = selScreen.XPos.ToString();
                ScreenYPosTextBox.Text = selScreen.YPos.ToString();
                ScreenWidthTextBox.Text = selScreen.Width.ToString();
                ScreenHeightTextBox.Text = selScreen.Height.ToString();
            }
        }

/* --------------------------------------------------------------------------------------------- */

        private void CreateRecButton_Click(object sender, EventArgs e)
        {
            // Check if textfield values are valid
            if (CheckTextFieldValue(numMonTextBox.Text) &&
                    ScreenListBox.SelectedIndices.Count > Convert.ToInt32(numMonTextBox.Text))
            {
                if (CheckTextFieldValue(RecXPosTextBox.Text) &&
                    CheckTextFieldValue(RecYPosTextBox.Text) &&
                    CheckTextFieldValue(RecWidthTextBox.Text) &&
                    CheckTextFieldValue(RecHeightTextBox.Text) &&
                    CheckTextFieldValue(RecXDistTextBox.Text) &&
                    CheckTextFieldValue(RecYDistTextBox.Text))

                {
                    // Get rectangle data and create new rectangles
                    Rectangle[] newRec = new Rectangle[Convert.ToInt32(NumRecUpDown.Value)];

                    int recx = Convert.ToInt32(RecXPosTextBox.Text);
                    int recxd = Convert.ToInt32(RecXDistTextBox.Text);
                    int recy = Convert.ToInt32(RecYPosTextBox.Text);
                    int recyd = Convert.ToInt32(RecYDistTextBox.Text);
                    int recw = Convert.ToInt32(RecWidthTextBox.Text);
                    int rech = Convert.ToInt32(RecHeightTextBox.Text);

                    for (int i = 0; i < newRec.Length; ++i)
                    {
                        newRec[i].X = recx + i * recxd;
                        newRec[i].Y = recy + i * recyd;
                        newRec[i].Height = recw;
                        newRec[i].Width = rech;
                    }

                    newAmbi.AddRectangles(newRec, Convert.ToInt32(numMonTextBox.Text));

                    showData();
                }
                else
                {
                    MessageBox.Show("Please insert positive rectangle values!");
                }

            }
            else
            {
                MessageBox.Show("Selected screen does not exist!");
            }
        }

        private void DelRecButton_Click(object sender, EventArgs e)
        {
            // TODO:    Remove extra int array and use directly SelectedIndices

            int[] RemIds = new int[RecListBox.SelectedIndices.Count];

            for (int i = 0; i < RecListBox.SelectedIndices.Count; ++i)
            {
                RemIds[i] = RecListBox.SelectedIndices[i];
            }

            newAmbi.RemRectangles(RemIds);

            showData();
        }

        private void ChangeRecButton_Click(object sender, EventArgs e)
        {
            // TODO:    Use SelectedIndices for changeRec method instead of extra index array
            Rectangle changedRec = new Rectangle();

            // Fill rectangle if there are values in the text fields
            if (CheckTextFieldValue(RecHeightTextBox.Text))
            {
                changedRec.Height = Convert.ToInt32(RecHeightTextBox.Text);
            }
            if (CheckTextFieldValue(RecWidthTextBox.Text))
            {
                changedRec.Width = Convert.ToInt32(RecWidthTextBox.Text);
            }
            if (CheckTextFieldValue(RecXPosTextBox.Text))
            {
                changedRec.X = Convert.ToInt32(RecXPosTextBox.Text);
            }
            if (CheckTextFieldValue(RecYPosTextBox.Text))
            {
                changedRec.Y = Convert.ToInt32(RecYPosTextBox.Text);
            }

            // Fill index array
            int[] index = new int[RecListBox.SelectedIndices.Count];
            for (int i = 0; i < RecListBox.SelectedIndices.Count; ++i)
            {
                index[i] = RecListBox.SelectedIndices[i];
            }

            newAmbi.ChangeRec(changedRec, index);

            DrawScreenPreview();
        }

        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if one or more items are selected and show information
            if (RecListBox.SelectedItems.Count == 1)
            {
                Rectangle showRec = newAmbi.GetRec(RecListBox.SelectedIndex);

                RecXPosTextBox.Text = showRec.X.ToString();
                RecYPosTextBox.Text = showRec.Y.ToString();
                RecWidthTextBox.Text = showRec.Width.ToString();
                RecHeightTextBox.Text = showRec.Height.ToString();
            }
            else
            {
                // TODO:    Show limited information if multiple items are selected

                Rectangle showRec = newAmbi.GetRec(RecListBox.SelectedIndices[0]);

                RecXPosTextBox.Text = showRec.X.ToString();
                RecYPosTextBox.Text = showRec.Y.ToString();
                RecWidthTextBox.Text = showRec.Width.ToString();
                RecHeightTextBox.Text = showRec.Height.ToString();

                for (int i = 1; i < RecListBox.SelectedIndices.Count; ++i )
                {
                    Rectangle nextRec = newAmbi.GetRec(RecListBox.SelectedIndices[i]);
                    if (showRec.X != nextRec.X)
                    {
                        RecXPosTextBox.Clear();
                    }
                    if (showRec.Y != nextRec.Y)
                    {
                        RecYPosTextBox.Clear();
                    }
                    if (showRec.Width != nextRec.Width)
                    {
                        RecWidthTextBox.Clear();
                    }
                    if (showRec.Height != nextRec.Height)
                    {
                        RecHeightTextBox.Clear();
                    }
                }
            }

            DrawScreenPreview();
        }

/* --------------------------------------------------------------------------------------------- */

        private void CreateLedButton_Click(object sender, EventArgs e)
        {
            // TODO:    Check for double values and not int. Will not work with the check right now. Instead improve the method with a template for different types (int/double).
            if(CheckTextFieldValue(RecIdTextBox.Text) &&
                CheckTextFieldValue(IntRTextBox.Text) &&
                CheckTextFieldValue(IntGTextBox.Text) &&
                CheckTextFieldValue(IntBTextBox.Text))
            {
                LED[] addLeds = new LED[Convert.ToInt32(NumLedUpDown.Value)];

                for (int i = 0; i < addLeds.Length; ++i)
                {
                    ++idindex;
                    addLeds[i]._id = idindex;
                    addLeds[i].Intensity = new double[] { Convert.ToDouble(IntRTextBox.Text), Convert.ToDouble(IntGTextBox.Text), Convert.ToDouble(IntBTextBox.Text) };
                    addLeds[i].RectID = Convert.ToInt32(RecIdTextBox.Text);
                }
                newAmbi.AddLeds(addLeds);

                showData();
            }
            else
            {
                MessageBox.Show("Please insert valid numbers to create LEDs!");
            }
        }

        private void DeleteLedButton_Click(object sender, EventArgs e)
        {
            int[] LedIdSet = new int[LedListBox.SelectedItems.Count];

            for (int i = 0; i < LedIdSet.Length; ++i )
            {
                // TODO:    Get Led Ids from ambilight and track them in form
                //LedIdSet[i] = Convert.ToInt32(LedListBox.SelectedItems[i].ToString());
            }

            newAmbi.RemLeds(LedIdSet);

            showData();
        }

        private void ChangeLedButton_Click(object sender, EventArgs e)
        {
            if (CheckTextFieldValue(RecIdTextBox.Text) &&
                CheckTextFieldValue(IntRTextBox.Text) &&
                CheckTextFieldValue(IntGTextBox.Text) &&
                CheckTextFieldValue(IntBTextBox.Text))
            {
                LED changeLed = new LED();

                changeLed.Color = new byte[3] { 0, 0, 0 };
                changeLed.Intensity = new double[3] { Convert.ToDouble(IntRTextBox.Text), Convert.ToDouble(IntGTextBox.Text), Convert.ToDouble(IntBTextBox.Text) };
                changeLed.RectID = Convert.ToInt32(RecIdTextBox.Text);

                for (int i = 0; i < LedListBox.SelectedIndices.Count; ++i)
                {
                    // TODO:    Get correct IDs
                    changeLed._id = 0;

                    bool suc = newAmbi.SetLed(changeLed);
                    if (suc == false)
                    {
                        MessageBox.Show("Id was not found!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please insert valid numbers to change LEDs!");
            }
        }

        private void LedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LED[] LedData = newAmbi.GetLedData();

            if (LedListBox.SelectedIndices.Count == 1)
            {
                // Get Led ID of selected item and show it in textfields
                LedIdTextBox.Text = LedData[LedListBox.SelectedIndex]._id.ToString();

                // Get rectangle ID of selected item and show it in textfields
                RecIdTextBox.Text = LedData[LedListBox.SelectedIndex].RectID.ToString();

                // Get intensity values of selected item and show them in textfields
                IntRTextBox.Text = LedData[LedListBox.SelectedIndex].Intensity[0].ToString();
                IntGTextBox.Text = LedData[LedListBox.SelectedIndex].Intensity[1].ToString();
                IntBTextBox.Text = LedData[LedListBox.SelectedIndex].Intensity[2].ToString();

                // Set Led amount to one
                NumLedUpDown.Value = 1;
            }
            else if (LedListBox.SelectedIndices.Count > 1)
            {
                LedIdTextBox.Clear();

                for (int i = 0; i < LedListBox.SelectedIndices.Count; ++i)
                {
                    // Set values of first led
                    if (i == 0)
                    {
                        int index = LedListBox.SelectedIndices[i];

                        RecIdTextBox.Text = LedData[index].RectID.ToString();

                        IntRTextBox.Text = LedData[index].Intensity[0].ToString();
                        IntGTextBox.Text = LedData[index].Intensity[1].ToString();
                        IntBTextBox.Text = LedData[index].Intensity[2].ToString();
                    }
                    // Compare values and delete them if they are not the same
                    else
                    {
                        // Check if rectangle ID is the same and clear if not
                        if (LedData[i].RectID != LedData[i - 1].RectID)
                        {
                            RecIdTextBox.Clear();
                        }

                        // Check if intensities are the same and clear if not
                        if (LedData[i].Intensity[0] != LedData[i - 1].Intensity[0]
                            || LedData[i].Intensity[1] != LedData[i - 1].Intensity[1]
                            || LedData[i].Intensity[2] != LedData[i - 1].Intensity[2])
                        {
                            IntRTextBox.Clear();
                            IntRTextBox.Clear();
                            IntRTextBox.Clear();
                        }
                    }
                }
            }
        }

        private void LedListUpButton_Click(object sender, EventArgs e)
        {
            // TODO:    Push selected LEDs one step higher in the List
        }

        private void LedListDownButton_Click(object sender, EventArgs e)
        {
            // TODO:    Push selected LEDs one step lower in the List
        }

        private bool CheckTextFieldValue(string value)
        {
            int outParse;
            if (Int32.TryParse(value, out outParse))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
