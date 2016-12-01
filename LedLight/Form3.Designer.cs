namespace LedLight
{
    partial class MultiLightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiLightForm));
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.MultilightLabel = new System.Windows.Forms.Label();
            this.LedListBox = new System.Windows.Forms.ListBox();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.IntBTextBox = new System.Windows.Forms.TextBox();
            this.IntGTextBox = new System.Windows.Forms.TextBox();
            this.ColorBTextBox = new System.Windows.Forms.TextBox();
            this.ColorGTextBox = new System.Windows.Forms.TextBox();
            this.LedNumber = new System.Windows.Forms.Label();
            this.LedColor = new System.Windows.Forms.Label();
            this.Intensitivity = new System.Windows.Forms.Label();
            this.ColorRTextBox = new System.Windows.Forms.TextBox();
            this.IntRTextBox = new System.Windows.Forms.TextBox();
            this.CreateLedButton = new System.Windows.Forms.Button();
            this.NumLedUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DeleteLedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(38, 244);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfileButton.TabIndex = 1;
            this.SaveProfileButton.Text = "Save Profile";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // MultilightLabel
            // 
            this.MultilightLabel.AutoSize = true;
            this.MultilightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultilightLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MultilightLabel.Location = new System.Drawing.Point(74, 23);
            this.MultilightLabel.Name = "MultilightLabel";
            this.MultilightLabel.Size = new System.Drawing.Size(199, 31);
            this.MultilightLabel.TabIndex = 91;
            this.MultilightLabel.Text = "Multilight Editor";
            // 
            // LedListBox
            // 
            this.LedListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LedListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LedListBox.FormattingEnabled = true;
            this.LedListBox.Location = new System.Drawing.Point(37, 78);
            this.LedListBox.Name = "LedListBox";
            this.LedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LedListBox.Size = new System.Drawing.Size(76, 160);
            this.LedListBox.TabIndex = 92;
            this.LedListBox.SelectedIndexChanged += new System.EventHandler(this.LedListBox_SelectedIndexChanged);
            // 
            // SetColorButton
            // 
            this.SetColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetColorButton.BackgroundImage")));
            this.SetColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetColorButton.Location = new System.Drawing.Point(291, 109);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(22, 22);
            this.SetColorButton.TabIndex = 105;
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // IntBTextBox
            // 
            this.IntBTextBox.Location = new System.Drawing.Point(264, 85);
            this.IntBTextBox.Name = "IntBTextBox";
            this.IntBTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntBTextBox.TabIndex = 104;
            this.IntBTextBox.Text = "1";
            // 
            // IntGTextBox
            // 
            this.IntGTextBox.Location = new System.Drawing.Point(236, 85);
            this.IntGTextBox.Name = "IntGTextBox";
            this.IntGTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntGTextBox.TabIndex = 103;
            this.IntGTextBox.Text = "1";
            // 
            // ColorBTextBox
            // 
            this.ColorBTextBox.Location = new System.Drawing.Point(264, 110);
            this.ColorBTextBox.Name = "ColorBTextBox";
            this.ColorBTextBox.Size = new System.Drawing.Size(22, 20);
            this.ColorBTextBox.TabIndex = 102;
            this.ColorBTextBox.Text = "0";
            // 
            // ColorGTextBox
            // 
            this.ColorGTextBox.Location = new System.Drawing.Point(236, 110);
            this.ColorGTextBox.Name = "ColorGTextBox";
            this.ColorGTextBox.Size = new System.Drawing.Size(22, 20);
            this.ColorGTextBox.TabIndex = 101;
            this.ColorGTextBox.Text = "0";
            // 
            // LedNumber
            // 
            this.LedNumber.AutoSize = true;
            this.LedNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedNumber.Location = new System.Drawing.Point(136, 172);
            this.LedNumber.Name = "LedNumber";
            this.LedNumber.Size = new System.Drawing.Size(64, 13);
            this.LedNumber.TabIndex = 100;
            this.LedNumber.Text = "Led Amount";
            // 
            // LedColor
            // 
            this.LedColor.AutoSize = true;
            this.LedColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedColor.Location = new System.Drawing.Point(136, 114);
            this.LedColor.Name = "LedColor";
            this.LedColor.Size = new System.Drawing.Size(63, 13);
            this.LedColor.TabIndex = 98;
            this.LedColor.Text = "Color (RGB)";
            // 
            // Intensitivity
            // 
            this.Intensitivity.AutoSize = true;
            this.Intensitivity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Intensitivity.Location = new System.Drawing.Point(136, 88);
            this.Intensitivity.Name = "Intensitivity";
            this.Intensitivity.Size = new System.Drawing.Size(59, 13);
            this.Intensitivity.TabIndex = 97;
            this.Intensitivity.Text = "Intensitivity";
            // 
            // ColorRTextBox
            // 
            this.ColorRTextBox.Location = new System.Drawing.Point(208, 110);
            this.ColorRTextBox.Name = "ColorRTextBox";
            this.ColorRTextBox.Size = new System.Drawing.Size(22, 20);
            this.ColorRTextBox.TabIndex = 94;
            this.ColorRTextBox.Text = "0";
            // 
            // IntRTextBox
            // 
            this.IntRTextBox.Location = new System.Drawing.Point(208, 85);
            this.IntRTextBox.Name = "IntRTextBox";
            this.IntRTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntRTextBox.TabIndex = 93;
            this.IntRTextBox.Text = "1";
            // 
            // CreateLedButton
            // 
            this.CreateLedButton.Location = new System.Drawing.Point(207, 196);
            this.CreateLedButton.Name = "CreateLedButton";
            this.CreateLedButton.Size = new System.Drawing.Size(75, 23);
            this.CreateLedButton.TabIndex = 106;
            this.CreateLedButton.Text = "Create Leds";
            this.CreateLedButton.UseVisualStyleBackColor = true;
            this.CreateLedButton.Click += new System.EventHandler(this.CreateLedButton_Click);
            // 
            // NumLedUpDown
            // 
            this.NumLedUpDown.Location = new System.Drawing.Point(208, 170);
            this.NumLedUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumLedUpDown.Name = "NumLedUpDown";
            this.NumLedUpDown.Size = new System.Drawing.Size(52, 20);
            this.NumLedUpDown.TabIndex = 107;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(207, 136);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 108;
            this.ChangeButton.Text = "Change Led";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteLedButton
            // 
            this.DeleteLedButton.Location = new System.Drawing.Point(207, 225);
            this.DeleteLedButton.Name = "DeleteLedButton";
            this.DeleteLedButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteLedButton.TabIndex = 109;
            this.DeleteLedButton.Text = "Delete Leds";
            this.DeleteLedButton.UseVisualStyleBackColor = true;
            this.DeleteLedButton.Click += new System.EventHandler(this.DeleteLedButton_Click);
            // 
            // MultiLightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(331, 291);
            this.Controls.Add(this.DeleteLedButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NumLedUpDown);
            this.Controls.Add(this.CreateLedButton);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.IntBTextBox);
            this.Controls.Add(this.IntGTextBox);
            this.Controls.Add(this.ColorBTextBox);
            this.Controls.Add(this.ColorGTextBox);
            this.Controls.Add(this.LedNumber);
            this.Controls.Add(this.LedColor);
            this.Controls.Add(this.Intensitivity);
            this.Controls.Add(this.ColorRTextBox);
            this.Controls.Add(this.IntRTextBox);
            this.Controls.Add(this.LedListBox);
            this.Controls.Add(this.MultilightLabel);
            this.Controls.Add(this.SaveProfileButton);
            this.Name = "MultiLightForm";
            this.Text = "Multilight Editor";
            this.Load += new System.EventHandler(this.MultiLightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Label MultilightLabel;
        private System.Windows.Forms.ListBox LedListBox;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.TextBox IntBTextBox;
        private System.Windows.Forms.TextBox IntGTextBox;
        private System.Windows.Forms.TextBox ColorBTextBox;
        private System.Windows.Forms.TextBox ColorGTextBox;
        private System.Windows.Forms.Label LedNumber;
        private System.Windows.Forms.Label LedColor;
        private System.Windows.Forms.Label Intensitivity;
        private System.Windows.Forms.TextBox ColorRTextBox;
        private System.Windows.Forms.TextBox IntRTextBox;
        private System.Windows.Forms.Button CreateLedButton;
        private System.Windows.Forms.NumericUpDown NumLedUpDown;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DeleteLedButton;
    }
}