namespace LedLight
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProfileListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StartStopProfileButton = new System.Windows.Forms.Button();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.NewProfileButton = new System.Windows.Forms.Button();
            this.ChangeProfileButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProfielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monolightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProfile = new System.Windows.Forms.Button();
            this.StartStopProfile = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileListBox
            // 
            this.ProfileListBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileListBox.FormattingEnabled = true;
            this.ProfileListBox.Location = new System.Drawing.Point(3, 8);
            this.ProfileListBox.Name = "ProfileListBox";
            this.ProfileListBox.Size = new System.Drawing.Size(188, 303);
            this.ProfileListBox.TabIndex = 28;
            // 
            // StartStopProfileButton
            // 
            this.StartStopProfileButton.Location = new System.Drawing.Point(204, 118);
            this.StartStopProfileButton.Name = "StartStopProfileButton";
            this.StartStopProfileButton.Size = new System.Drawing.Size(104, 23);
            this.StartStopProfileButton.TabIndex = 84;
            this.StartStopProfileButton.Text = "Start Profile";
            this.StartStopProfileButton.UseVisualStyleBackColor = true;
            this.StartStopProfileButton.Click += new System.EventHandler(this.StartStopProfileButton_Click);
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(204, 206);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(104, 21);
            this.ProfileComboBox.TabIndex = 85;
            // 
            // NewProfileButton
            // 
            this.NewProfileButton.Location = new System.Drawing.Point(204, 233);
            this.NewProfileButton.Name = "NewProfileButton";
            this.NewProfileButton.Size = new System.Drawing.Size(104, 23);
            this.NewProfileButton.TabIndex = 86;
            this.NewProfileButton.Text = "Create New Profile";
            this.NewProfileButton.UseVisualStyleBackColor = true;
            this.NewProfileButton.Click += new System.EventHandler(this.NewProfileButton_Click);
            // 
            // ChangeProfileButton
            // 
            this.ChangeProfileButton.Location = new System.Drawing.Point(204, 146);
            this.ChangeProfileButton.Name = "ChangeProfileButton";
            this.ChangeProfileButton.Size = new System.Drawing.Size(104, 23);
            this.ChangeProfileButton.TabIndex = 87;
            this.ChangeProfileButton.Text = "Change Profile";
            this.ChangeProfileButton.UseVisualStyleBackColor = true;
            this.ChangeProfileButton.Click += new System.EventHandler(this.ChangeProfileButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 90;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfielToolStripMenuItem,
            this.changeProfileToolStripMenuItem,
            this.loadProfileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Main";
            // 
            // createProfielToolStripMenuItem
            // 
            this.createProfielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ambilightToolStripMenuItem,
            this.multilightToolStripMenuItem,
            this.monolightToolStripMenuItem});
            this.createProfielToolStripMenuItem.Name = "createProfielToolStripMenuItem";
            this.createProfielToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createProfielToolStripMenuItem.Text = "Create Profiel";
            // 
            // ambilightToolStripMenuItem
            // 
            this.ambilightToolStripMenuItem.Name = "ambilightToolStripMenuItem";
            this.ambilightToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ambilightToolStripMenuItem.Text = "Ambilight";
            // 
            // multilightToolStripMenuItem
            // 
            this.multilightToolStripMenuItem.Name = "multilightToolStripMenuItem";
            this.multilightToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.multilightToolStripMenuItem.Text = "Multilight";
            // 
            // monolightToolStripMenuItem
            // 
            this.monolightToolStripMenuItem.Name = "monolightToolStripMenuItem";
            this.monolightToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.monolightToolStripMenuItem.Text = "Monolight";
            // 
            // changeProfileToolStripMenuItem
            // 
            this.changeProfileToolStripMenuItem.Name = "changeProfileToolStripMenuItem";
            this.changeProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeProfileToolStripMenuItem.Text = "Change Profile";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            // 
            // EditProfile
            // 
            this.EditProfile.BackgroundImage = global::LedLight.Properties.Resources.edit45;
            this.EditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditProfile.Location = new System.Drawing.Point(199, 0);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(27, 25);
            this.EditProfile.TabIndex = 94;
            this.EditProfile.UseVisualStyleBackColor = true;
            // 
            // StartStopProfile
            // 
            this.StartStopProfile.BackgroundImage = global::LedLight.Properties.Resources.start3;
            this.StartStopProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartStopProfile.Location = new System.Drawing.Point(166, 0);
            this.StartStopProfile.Name = "StartStopProfile";
            this.StartStopProfile.Size = new System.Drawing.Size(27, 25);
            this.StartStopProfile.TabIndex = 93;
            this.StartStopProfile.UseVisualStyleBackColor = true;
            this.StartStopProfile.Click += new System.EventHandler(this.StartStopProfile_Click);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.BackgroundImage = global::LedLight.Properties.Resources.rubbish;
            this.DeleteProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteProfileButton.Location = new System.Drawing.Point(133, 0);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(27, 25);
            this.DeleteProfileButton.TabIndex = 92;
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.BackgroundImage = global::LedLight.Properties.Resources.folder265;
            this.FolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FolderButton.Location = new System.Drawing.Point(100, 0);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(27, 25);
            this.FolderButton.TabIndex = 91;
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::LedLight.Properties.Resources.refresh29;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(67, 0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(27, 25);
            this.RefreshButton.TabIndex = 89;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 359);
            this.tabControl1.TabIndex = 95;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProfileListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(678, 389);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.StartStopProfile);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ChangeProfileButton);
            this.Controls.Add(this.NewProfileButton);
            this.Controls.Add(this.ProfileComboBox);
            this.Controls.Add(this.StartStopProfileButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LED Light";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProfileListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button StartStopProfileButton;
        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Button NewProfileButton;
        private System.Windows.Forms.Button ChangeProfileButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProfielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multilightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monolightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Button StartStopProfile;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

