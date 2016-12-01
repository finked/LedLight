namespace LedLight
{
    partial class AmbilightForm
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
            this.ChangeLedButton = new System.Windows.Forms.Button();
            this.IntBTextBox = new System.Windows.Forms.TextBox();
            this.IntGTextBox = new System.Windows.Forms.TextBox();
            this.LedNumber = new System.Windows.Forms.Label();
            this.DeleteLedButton = new System.Windows.Forms.Button();
            this.CreateLedButton = new System.Windows.Forms.Button();
            this.RectId = new System.Windows.Forms.Label();
            this.Intensitivity = new System.Windows.Forms.Label();
            this.LedId = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RecIdTextBox = new System.Windows.Forms.TextBox();
            this.IntRTextBox = new System.Windows.Forms.TextBox();
            this.LedIdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numMonTextBox = new System.Windows.Forms.TextBox();
            this.DelRecButton = new System.Windows.Forms.Button();
            this.CreateRecButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RecHeightTextBox = new System.Windows.Forms.TextBox();
            this.RecWidthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecYDistTextBox = new System.Windows.Forms.TextBox();
            this.RecXDistTextBox = new System.Windows.Forms.TextBox();
            this.RecYPosTextBox = new System.Windows.Forms.TextBox();
            this.RecXPosTextBox = new System.Windows.Forms.TextBox();
            this.AmbilightLabel = new System.Windows.Forms.Label();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ScreenHeightTextBox = new System.Windows.Forms.TextBox();
            this.ScreenYPosTextBox = new System.Windows.Forms.TextBox();
            this.ScreenWidthTextBox = new System.Windows.Forms.TextBox();
            this.ScreenXPosTextBox = new System.Windows.Forms.TextBox();
            this.CreateScreenButton = new System.Windows.Forms.Button();
            this.DeleteScreenButton = new System.Windows.Forms.Button();
            this.ChangeRecButton = new System.Windows.Forms.Button();
            this.ChangeScreenButton = new System.Windows.Forms.Button();
            this.NumLedUpDown = new System.Windows.Forms.NumericUpDown();
            this.LedListBox = new System.Windows.Forms.ListBox();
            this.RecListBox = new System.Windows.Forms.ListBox();
            this.ScreenListBox = new System.Windows.Forms.ListBox();
            this.NumRecUpDown = new System.Windows.Forms.NumericUpDown();
            this.LedListDownButton = new System.Windows.Forms.Button();
            this.LedListUpButton = new System.Windows.Forms.Button();
            this.ScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.RecLabel = new System.Windows.Forms.Label();
            this.LedLabel = new System.Windows.Forms.Label();
            this.ScreenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRecUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeLedButton
            // 
            this.ChangeLedButton.Location = new System.Drawing.Point(443, 405);
            this.ChangeLedButton.Name = "ChangeLedButton";
            this.ChangeLedButton.Size = new System.Drawing.Size(113, 23);
            this.ChangeLedButton.TabIndex = 129;
            this.ChangeLedButton.Text = "Change Led";
            this.ChangeLedButton.UseVisualStyleBackColor = true;
            this.ChangeLedButton.Click += new System.EventHandler(this.ChangeLedButton_Click);
            // 
            // IntBTextBox
            // 
            this.IntBTextBox.Location = new System.Drawing.Point(342, 399);
            this.IntBTextBox.Name = "IntBTextBox";
            this.IntBTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntBTextBox.TabIndex = 127;
            // 
            // IntGTextBox
            // 
            this.IntGTextBox.Location = new System.Drawing.Point(314, 399);
            this.IntGTextBox.Name = "IntGTextBox";
            this.IntGTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntGTextBox.TabIndex = 126;
            // 
            // LedNumber
            // 
            this.LedNumber.AutoSize = true;
            this.LedNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedNumber.Location = new System.Drawing.Point(218, 429);
            this.LedNumber.Name = "LedNumber";
            this.LedNumber.Size = new System.Drawing.Size(64, 13);
            this.LedNumber.TabIndex = 123;
            this.LedNumber.Text = "Led Amount";
            // 
            // DeleteLedButton
            // 
            this.DeleteLedButton.Location = new System.Drawing.Point(443, 376);
            this.DeleteLedButton.Name = "DeleteLedButton";
            this.DeleteLedButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteLedButton.TabIndex = 121;
            this.DeleteLedButton.Text = "Delete Led";
            this.DeleteLedButton.UseVisualStyleBackColor = true;
            this.DeleteLedButton.Click += new System.EventHandler(this.DeleteLedButton_Click);
            // 
            // CreateLedButton
            // 
            this.CreateLedButton.Location = new System.Drawing.Point(443, 345);
            this.CreateLedButton.Name = "CreateLedButton";
            this.CreateLedButton.Size = new System.Drawing.Size(113, 23);
            this.CreateLedButton.TabIndex = 120;
            this.CreateLedButton.Text = "Create Led";
            this.CreateLedButton.UseVisualStyleBackColor = true;
            this.CreateLedButton.Click += new System.EventHandler(this.CreateLedButton_Click);
            // 
            // RectId
            // 
            this.RectId.AutoSize = true;
            this.RectId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RectId.Location = new System.Drawing.Point(211, 376);
            this.RectId.Name = "RectId";
            this.RectId.Size = new System.Drawing.Size(70, 13);
            this.RectId.TabIndex = 118;
            this.RectId.Text = "Rectangle ID";
            // 
            // Intensitivity
            // 
            this.Intensitivity.AutoSize = true;
            this.Intensitivity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Intensitivity.Location = new System.Drawing.Point(222, 402);
            this.Intensitivity.Name = "Intensitivity";
            this.Intensitivity.Size = new System.Drawing.Size(59, 13);
            this.Intensitivity.TabIndex = 117;
            this.Intensitivity.Text = "Intensitivity";
            // 
            // LedId
            // 
            this.LedId.AutoSize = true;
            this.LedId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedId.Location = new System.Drawing.Point(242, 348);
            this.LedId.Name = "LedId";
            this.LedId.Size = new System.Drawing.Size(39, 13);
            this.LedId.TabIndex = 116;
            this.LedId.Text = "Led ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 375);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 114;
            this.label18.Text = "W:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(222, 401);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 113;
            this.label19.Text = "Y:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(222, 348);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 112;
            this.label20.Text = "X:";
            // 
            // RecIdTextBox
            // 
            this.RecIdTextBox.Location = new System.Drawing.Point(286, 372);
            this.RecIdTextBox.Name = "RecIdTextBox";
            this.RecIdTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecIdTextBox.TabIndex = 110;
            // 
            // IntRTextBox
            // 
            this.IntRTextBox.Location = new System.Drawing.Point(286, 399);
            this.IntRTextBox.Name = "IntRTextBox";
            this.IntRTextBox.Size = new System.Drawing.Size(22, 20);
            this.IntRTextBox.TabIndex = 109;
            // 
            // LedIdTextBox
            // 
            this.LedIdTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LedIdTextBox.Location = new System.Drawing.Point(286, 345);
            this.LedIdTextBox.Name = "LedIdTextBox";
            this.LedIdTextBox.ReadOnly = true;
            this.LedIdTextBox.Size = new System.Drawing.Size(43, 20);
            this.LedIdTextBox.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(200, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = "Screen Number";
            // 
            // numMonTextBox
            // 
            this.numMonTextBox.Location = new System.Drawing.Point(286, 290);
            this.numMonTextBox.Name = "numMonTextBox";
            this.numMonTextBox.Size = new System.Drawing.Size(43, 20);
            this.numMonTextBox.TabIndex = 105;
            // 
            // DelRecButton
            // 
            this.DelRecButton.Location = new System.Drawing.Point(443, 138);
            this.DelRecButton.Name = "DelRecButton";
            this.DelRecButton.Size = new System.Drawing.Size(113, 23);
            this.DelRecButton.TabIndex = 104;
            this.DelRecButton.Text = "Delete Rectangles";
            this.DelRecButton.UseVisualStyleBackColor = true;
            this.DelRecButton.Click += new System.EventHandler(this.DelRecButton_Click);
            // 
            // CreateRecButton
            // 
            this.CreateRecButton.Location = new System.Drawing.Point(443, 109);
            this.CreateRecButton.Name = "CreateRecButton";
            this.CreateRecButton.Size = new System.Drawing.Size(113, 23);
            this.CreateRecButton.TabIndex = 103;
            this.CreateRecButton.Text = "Create Rectangles";
            this.CreateRecButton.UseVisualStyleBackColor = true;
            this.CreateRecButton.Click += new System.EventHandler(this.CreateRecButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(220, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "Rectangles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(249, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "YDist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(249, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "XDist";
            // 
            // RecHeightTextBox
            // 
            this.RecHeightTextBox.Location = new System.Drawing.Point(286, 237);
            this.RecHeightTextBox.Name = "RecHeightTextBox";
            this.RecHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecHeightTextBox.TabIndex = 98;
            // 
            // RecWidthTextBox
            // 
            this.RecWidthTextBox.Location = new System.Drawing.Point(286, 211);
            this.RecWidthTextBox.Name = "RecWidthTextBox";
            this.RecWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecWidthTextBox.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(246, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(249, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(248, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "YPos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(249, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "XPos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "H:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "X:";
            // 
            // RecYDistTextBox
            // 
            this.RecYDistTextBox.Location = new System.Drawing.Point(286, 185);
            this.RecYDistTextBox.Name = "RecYDistTextBox";
            this.RecYDistTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecYDistTextBox.TabIndex = 88;
            // 
            // RecXDistTextBox
            // 
            this.RecXDistTextBox.Location = new System.Drawing.Point(286, 133);
            this.RecXDistTextBox.Name = "RecXDistTextBox";
            this.RecXDistTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecXDistTextBox.TabIndex = 87;
            // 
            // RecYPosTextBox
            // 
            this.RecYPosTextBox.Location = new System.Drawing.Point(286, 159);
            this.RecYPosTextBox.Name = "RecYPosTextBox";
            this.RecYPosTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecYPosTextBox.TabIndex = 86;
            // 
            // RecXPosTextBox
            // 
            this.RecXPosTextBox.Location = new System.Drawing.Point(286, 106);
            this.RecXPosTextBox.Name = "RecXPosTextBox";
            this.RecXPosTextBox.Size = new System.Drawing.Size(43, 20);
            this.RecXPosTextBox.TabIndex = 85;
            // 
            // AmbilightLabel
            // 
            this.AmbilightLabel.AutoSize = true;
            this.AmbilightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmbilightLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmbilightLabel.Location = new System.Drawing.Point(454, 35);
            this.AmbilightLabel.Name = "AmbilightLabel";
            this.AmbilightLabel.Size = new System.Drawing.Size(203, 31);
            this.AmbilightLabel.TabIndex = 130;
            this.AmbilightLabel.Text = "Ambilight Editor";
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(54, 540);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveProfileButton.TabIndex = 131;
            this.SaveProfileButton.Text = "Save Profile";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(858, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 144;
            this.label13.Text = "Height";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(862, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 143;
            this.label14.Text = "YPos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(861, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 142;
            this.label15.Text = "Width";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(862, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 141;
            this.label16.Text = "XPos";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(876, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 140;
            this.label21.Text = "H:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(876, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 139;
            this.label22.Text = "W:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(876, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 13);
            this.label23.TabIndex = 138;
            this.label23.Text = "Y:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(876, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 13);
            this.label24.TabIndex = 137;
            this.label24.Text = "X:";
            // 
            // ScreenHeightTextBox
            // 
            this.ScreenHeightTextBox.Location = new System.Drawing.Point(899, 182);
            this.ScreenHeightTextBox.Name = "ScreenHeightTextBox";
            this.ScreenHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScreenHeightTextBox.TabIndex = 136;
            this.ScreenHeightTextBox.Text = "0";
            // 
            // ScreenYPosTextBox
            // 
            this.ScreenYPosTextBox.Location = new System.Drawing.Point(899, 130);
            this.ScreenYPosTextBox.Name = "ScreenYPosTextBox";
            this.ScreenYPosTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScreenYPosTextBox.TabIndex = 135;
            this.ScreenYPosTextBox.Text = "0";
            // 
            // ScreenWidthTextBox
            // 
            this.ScreenWidthTextBox.Location = new System.Drawing.Point(899, 156);
            this.ScreenWidthTextBox.Name = "ScreenWidthTextBox";
            this.ScreenWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScreenWidthTextBox.TabIndex = 134;
            this.ScreenWidthTextBox.Text = "0";
            // 
            // ScreenXPosTextBox
            // 
            this.ScreenXPosTextBox.Location = new System.Drawing.Point(899, 103);
            this.ScreenXPosTextBox.Name = "ScreenXPosTextBox";
            this.ScreenXPosTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScreenXPosTextBox.TabIndex = 133;
            this.ScreenXPosTextBox.Text = "0";
            // 
            // CreateScreenButton
            // 
            this.CreateScreenButton.Location = new System.Drawing.Point(969, 103);
            this.CreateScreenButton.Name = "CreateScreenButton";
            this.CreateScreenButton.Size = new System.Drawing.Size(113, 23);
            this.CreateScreenButton.TabIndex = 146;
            this.CreateScreenButton.Text = "Create Screen";
            this.CreateScreenButton.UseVisualStyleBackColor = true;
            this.CreateScreenButton.Click += new System.EventHandler(this.CreateScreen_Click);
            // 
            // DeleteScreenButton
            // 
            this.DeleteScreenButton.Location = new System.Drawing.Point(969, 133);
            this.DeleteScreenButton.Name = "DeleteScreenButton";
            this.DeleteScreenButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteScreenButton.TabIndex = 145;
            this.DeleteScreenButton.Text = "Delete Screen";
            this.DeleteScreenButton.UseVisualStyleBackColor = true;
            this.DeleteScreenButton.Click += new System.EventHandler(this.DeleteScreenButton_Click);
            // 
            // ChangeRecButton
            // 
            this.ChangeRecButton.Location = new System.Drawing.Point(443, 167);
            this.ChangeRecButton.Name = "ChangeRecButton";
            this.ChangeRecButton.Size = new System.Drawing.Size(113, 23);
            this.ChangeRecButton.TabIndex = 147;
            this.ChangeRecButton.Text = "Change Rectangle";
            this.ChangeRecButton.UseVisualStyleBackColor = true;
            this.ChangeRecButton.Click += new System.EventHandler(this.ChangeRecButton_Click);
            // 
            // ChangeScreenButton
            // 
            this.ChangeScreenButton.Location = new System.Drawing.Point(969, 162);
            this.ChangeScreenButton.Name = "ChangeScreenButton";
            this.ChangeScreenButton.Size = new System.Drawing.Size(113, 23);
            this.ChangeScreenButton.TabIndex = 148;
            this.ChangeScreenButton.Text = "Change Screen";
            this.ChangeScreenButton.UseVisualStyleBackColor = true;
            this.ChangeScreenButton.Click += new System.EventHandler(this.ChangeScreenButton_Click);
            // 
            // NumLedUpDown
            // 
            this.NumLedUpDown.Location = new System.Drawing.Point(286, 426);
            this.NumLedUpDown.Name = "NumLedUpDown";
            this.NumLedUpDown.Size = new System.Drawing.Size(43, 20);
            this.NumLedUpDown.TabIndex = 149;
            // 
            // LedListBox
            // 
            this.LedListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LedListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LedListBox.FormattingEnabled = true;
            this.LedListBox.Location = new System.Drawing.Point(54, 345);
            this.LedListBox.Name = "LedListBox";
            this.LedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LedListBox.Size = new System.Drawing.Size(128, 121);
            this.LedListBox.TabIndex = 150;
            this.LedListBox.SelectedIndexChanged += new System.EventHandler(this.LedListBox_SelectedIndexChanged);
            // 
            // RecListBox
            // 
            this.RecListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RecListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RecListBox.FormattingEnabled = true;
            this.RecListBox.Location = new System.Drawing.Point(54, 103);
            this.RecListBox.Name = "RecListBox";
            this.RecListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RecListBox.Size = new System.Drawing.Size(128, 121);
            this.RecListBox.TabIndex = 151;
            this.RecListBox.SelectedIndexChanged += new System.EventHandler(this.RecListBox_SelectedIndexChanged);
            // 
            // ScreenListBox
            // 
            this.ScreenListBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ScreenListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ScreenListBox.FormattingEnabled = true;
            this.ScreenListBox.Location = new System.Drawing.Point(693, 103);
            this.ScreenListBox.Name = "ScreenListBox";
            this.ScreenListBox.Size = new System.Drawing.Size(128, 121);
            this.ScreenListBox.TabIndex = 152;
            this.ScreenListBox.SelectedIndexChanged += new System.EventHandler(this.ScreenListBox_SelectedIndexChanged);
            // 
            // NumRecUpDown
            // 
            this.NumRecUpDown.Location = new System.Drawing.Point(287, 264);
            this.NumRecUpDown.Name = "NumRecUpDown";
            this.NumRecUpDown.Size = new System.Drawing.Size(42, 20);
            this.NumRecUpDown.TabIndex = 153;
            // 
            // LedListDownButton
            // 
            this.LedListDownButton.BackgroundImage = global::LedLight.Properties.Resources.arrow487_down;
            this.LedListDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LedListDownButton.Location = new System.Drawing.Point(26, 376);
            this.LedListDownButton.Name = "LedListDownButton";
            this.LedListDownButton.Size = new System.Drawing.Size(22, 23);
            this.LedListDownButton.TabIndex = 156;
            this.LedListDownButton.UseVisualStyleBackColor = true;
            this.LedListDownButton.Click += new System.EventHandler(this.LedListDownButton_Click);
            // 
            // LedListUpButton
            // 
            this.LedListUpButton.BackgroundImage = global::LedLight.Properties.Resources.arrow487_up;
            this.LedListUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LedListUpButton.Location = new System.Drawing.Point(26, 345);
            this.LedListUpButton.Name = "LedListUpButton";
            this.LedListUpButton.Size = new System.Drawing.Size(22, 23);
            this.LedListUpButton.TabIndex = 155;
            this.LedListUpButton.UseVisualStyleBackColor = true;
            this.LedListUpButton.Click += new System.EventHandler(this.LedListUpButton_Click);
            // 
            // ScreenPictureBox
            // 
            this.ScreenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScreenPictureBox.Location = new System.Drawing.Point(632, 290);
            this.ScreenPictureBox.Name = "ScreenPictureBox";
            this.ScreenPictureBox.Size = new System.Drawing.Size(490, 285);
            this.ScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenPictureBox.TabIndex = 154;
            this.ScreenPictureBox.TabStop = false;
            // 
            // RecLabel
            // 
            this.RecLabel.AutoSize = true;
            this.RecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RecLabel.Location = new System.Drawing.Point(50, 65);
            this.RecLabel.Name = "RecLabel";
            this.RecLabel.Size = new System.Drawing.Size(90, 20);
            this.RecLabel.TabIndex = 157;
            this.RecLabel.Text = "Rectangles";
            // 
            // LedLabel
            // 
            this.LedLabel.AutoSize = true;
            this.LedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LedLabel.Location = new System.Drawing.Point(50, 304);
            this.LedLabel.Name = "LedLabel";
            this.LedLabel.Size = new System.Drawing.Size(49, 20);
            this.LedLabel.TabIndex = 158;
            this.LedLabel.Text = "LEDs";
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScreenLabel.Location = new System.Drawing.Point(689, 65);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(68, 20);
            this.ScreenLabel.TabIndex = 159;
            this.ScreenLabel.Text = "Screens";
            // 
            // AmbilightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1160, 615);
            this.Controls.Add(this.ScreenLabel);
            this.Controls.Add(this.LedLabel);
            this.Controls.Add(this.RecLabel);
            this.Controls.Add(this.LedListDownButton);
            this.Controls.Add(this.LedListUpButton);
            this.Controls.Add(this.ScreenPictureBox);
            this.Controls.Add(this.NumRecUpDown);
            this.Controls.Add(this.ScreenListBox);
            this.Controls.Add(this.RecListBox);
            this.Controls.Add(this.LedListBox);
            this.Controls.Add(this.NumLedUpDown);
            this.Controls.Add(this.ChangeScreenButton);
            this.Controls.Add(this.ChangeRecButton);
            this.Controls.Add(this.CreateScreenButton);
            this.Controls.Add(this.DeleteScreenButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.ScreenHeightTextBox);
            this.Controls.Add(this.ScreenYPosTextBox);
            this.Controls.Add(this.ScreenWidthTextBox);
            this.Controls.Add(this.ScreenXPosTextBox);
            this.Controls.Add(this.SaveProfileButton);
            this.Controls.Add(this.AmbilightLabel);
            this.Controls.Add(this.ChangeLedButton);
            this.Controls.Add(this.IntBTextBox);
            this.Controls.Add(this.IntGTextBox);
            this.Controls.Add(this.LedNumber);
            this.Controls.Add(this.DeleteLedButton);
            this.Controls.Add(this.CreateLedButton);
            this.Controls.Add(this.RectId);
            this.Controls.Add(this.Intensitivity);
            this.Controls.Add(this.LedId);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.RecIdTextBox);
            this.Controls.Add(this.IntRTextBox);
            this.Controls.Add(this.LedIdTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numMonTextBox);
            this.Controls.Add(this.DelRecButton);
            this.Controls.Add(this.CreateRecButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RecHeightTextBox);
            this.Controls.Add(this.RecWidthTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecYDistTextBox);
            this.Controls.Add(this.RecXDistTextBox);
            this.Controls.Add(this.RecYPosTextBox);
            this.Controls.Add(this.RecXPosTextBox);
            this.Name = "AmbilightForm";
            this.Text = "Ambilight Editor";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumLedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRecUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeLedButton;
        private System.Windows.Forms.TextBox IntBTextBox;
        private System.Windows.Forms.TextBox IntGTextBox;
        private System.Windows.Forms.Label LedNumber;
        private System.Windows.Forms.Button DeleteLedButton;
        private System.Windows.Forms.Button CreateLedButton;
        private System.Windows.Forms.Label RectId;
        private System.Windows.Forms.Label Intensitivity;
        private System.Windows.Forms.Label LedId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox RecIdTextBox;
        private System.Windows.Forms.TextBox IntRTextBox;
        private System.Windows.Forms.TextBox LedIdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numMonTextBox;
        private System.Windows.Forms.Button DelRecButton;
        private System.Windows.Forms.Button CreateRecButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RecHeightTextBox;
        private System.Windows.Forms.TextBox RecWidthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecYDistTextBox;
        private System.Windows.Forms.TextBox RecXDistTextBox;
        private System.Windows.Forms.TextBox RecYPosTextBox;
        private System.Windows.Forms.TextBox RecXPosTextBox;
        private System.Windows.Forms.Label AmbilightLabel;
        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox ScreenHeightTextBox;
        private System.Windows.Forms.TextBox ScreenYPosTextBox;
        private System.Windows.Forms.TextBox ScreenWidthTextBox;
        private System.Windows.Forms.TextBox ScreenXPosTextBox;
        private System.Windows.Forms.Button CreateScreenButton;
        private System.Windows.Forms.Button DeleteScreenButton;
        private System.Windows.Forms.Button ChangeRecButton;
        private System.Windows.Forms.Button ChangeScreenButton;
        private System.Windows.Forms.NumericUpDown NumLedUpDown;
        private System.Windows.Forms.ListBox LedListBox;
        private System.Windows.Forms.ListBox RecListBox;
        private System.Windows.Forms.ListBox ScreenListBox;
        private System.Windows.Forms.NumericUpDown NumRecUpDown;
        private System.Windows.Forms.PictureBox ScreenPictureBox;
        private System.Windows.Forms.Button LedListUpButton;
        private System.Windows.Forms.Button LedListDownButton;
        private System.Windows.Forms.Label RecLabel;
        private System.Windows.Forms.Label LedLabel;
        private System.Windows.Forms.Label ScreenLabel;
    }
}