namespace LedLight
{
    partial class MonolightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonolightForm));
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.ColorBTextBox = new System.Windows.Forms.TextBox();
            this.ColorGTextBox = new System.Windows.Forms.TextBox();
            this.LedColor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ColorRTextBox = new System.Windows.Forms.TextBox();
            this.LedNumber = new System.Windows.Forms.Label();
            this.MonolightLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.NumLedUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(121, 131);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfileButton.TabIndex = 0;
            this.SaveProfileButton.Text = "Save Profile";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // SetColorButton
            // 
            this.SetColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetColorButton.BackgroundImage")));
            this.SetColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetColorButton.Location = new System.Drawing.Point(187, 64);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(22, 22);
            this.SetColorButton.TabIndex = 87;
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // ColorBTextBox
            // 
            this.ColorBTextBox.Location = new System.Drawing.Point(160, 65);
            this.ColorBTextBox.Name = "ColorBTextBox";
            this.ColorBTextBox.Size = new System.Drawing.Size(24, 20);
            this.ColorBTextBox.TabIndex = 86;
            this.ColorBTextBox.Text = "0";
            // 
            // ColorGTextBox
            // 
            this.ColorGTextBox.Location = new System.Drawing.Point(132, 65);
            this.ColorGTextBox.Name = "ColorGTextBox";
            this.ColorGTextBox.Size = new System.Drawing.Size(24, 20);
            this.ColorGTextBox.TabIndex = 85;
            this.ColorGTextBox.Text = "0";
            // 
            // LedColor
            // 
            this.LedColor.AutoSize = true;
            this.LedColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedColor.Location = new System.Drawing.Point(32, 69);
            this.LedColor.Name = "LedColor";
            this.LedColor.Size = new System.Drawing.Size(63, 13);
            this.LedColor.TabIndex = 84;
            this.LedColor.Text = "Color (RGB)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "H:";
            // 
            // ColorRTextBox
            // 
            this.ColorRTextBox.Location = new System.Drawing.Point(104, 65);
            this.ColorRTextBox.Name = "ColorRTextBox";
            this.ColorRTextBox.Size = new System.Drawing.Size(24, 20);
            this.ColorRTextBox.TabIndex = 82;
            this.ColorRTextBox.Text = "0";
            // 
            // LedNumber
            // 
            this.LedNumber.AutoSize = true;
            this.LedNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedNumber.Location = new System.Drawing.Point(31, 98);
            this.LedNumber.Name = "LedNumber";
            this.LedNumber.Size = new System.Drawing.Size(64, 13);
            this.LedNumber.TabIndex = 89;
            this.LedNumber.Text = "Led Amount";
            // 
            // MonolightLabel
            // 
            this.MonolightLabel.AutoSize = true;
            this.MonolightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonolightLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MonolightLabel.Location = new System.Drawing.Point(59, 18);
            this.MonolightLabel.Name = "MonolightLabel";
            this.MonolightLabel.Size = new System.Drawing.Size(209, 31);
            this.MonolightLabel.TabIndex = 90;
            this.MonolightLabel.Text = "Monolight Editor";
            // 
            // NumLedUpDown
            // 
            this.NumLedUpDown.Location = new System.Drawing.Point(103, 94);
            this.NumLedUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumLedUpDown.Name = "NumLedUpDown";
            this.NumLedUpDown.Size = new System.Drawing.Size(52, 20);
            this.NumLedUpDown.TabIndex = 91;
            // 
            // MonolightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 170);
            this.Controls.Add(this.NumLedUpDown);
            this.Controls.Add(this.MonolightLabel);
            this.Controls.Add(this.LedNumber);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.ColorBTextBox);
            this.Controls.Add(this.ColorGTextBox);
            this.Controls.Add(this.LedColor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ColorRTextBox);
            this.Controls.Add(this.SaveProfileButton);
            this.Name = "MonolightForm";
            this.Text = "Monolight Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.TextBox ColorBTextBox;
        private System.Windows.Forms.TextBox ColorGTextBox;
        private System.Windows.Forms.Label LedColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ColorRTextBox;
        private System.Windows.Forms.Label LedNumber;
        private System.Windows.Forms.Label MonolightLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown NumLedUpDown;
    }
}