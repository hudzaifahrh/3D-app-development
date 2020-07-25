namespace App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.DeviceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorNone = new System.Windows.Forms.ToolStripMenuItem();
            this.DepthMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DepthNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeLive = new System.Windows.Forms.ToolStripMenuItem();
            this.ModePlayback = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Landmarks = new System.Windows.Forms.CheckBox();
            this.Solid = new System.Windows.Forms.CheckBox();
            this.Textured = new System.Windows.Forms.CheckBox();
            this.OutOfRange = new System.Windows.Forms.Label();
            this.FaceNotDetected = new System.Windows.Forms.Label();
            this.TrackingLost = new System.Windows.Forms.Label();
            this.TooClose = new System.Windows.Forms.Label();
            this.TooFar = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ScanningArea = new System.Windows.Forms.ComboBox();
            this.MainPanel = new System.Windows.Forms.PictureBox();
            this.flopPreviewImage = new System.Windows.Forms.CheckBox();
            this.Reconstruct = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.Status2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeviceMenu,
            this.ColorMenu,
            this.DepthMenu,
            this.ModeMenu,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "MainMenu";
            // 
            // DeviceMenu
            // 
            this.DeviceMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeviceMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.DeviceMenu.Name = "DeviceMenu";
            this.DeviceMenu.Size = new System.Drawing.Size(54, 20);
            this.DeviceMenu.Text = "Device";
            // 
            // ColorMenu
            // 
            this.ColorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ColorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorNone});
            this.ColorMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.ColorMenu.Name = "ColorMenu";
            this.ColorMenu.Size = new System.Drawing.Size(48, 20);
            this.ColorMenu.Text = "Color";
            this.ColorMenu.Click += new System.EventHandler(this.ColorMenu_Click);
            // 
            // ColorNone
            // 
            this.ColorNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ColorNone.ForeColor = System.Drawing.Color.White;
            this.ColorNone.Name = "ColorNone";
            this.ColorNone.Size = new System.Drawing.Size(103, 22);
            this.ColorNone.Text = "None";
            // 
            // DepthMenu
            // 
            this.DepthMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DepthMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepthNone});
            this.DepthMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.DepthMenu.Name = "DepthMenu";
            this.DepthMenu.Size = new System.Drawing.Size(51, 20);
            this.DepthMenu.Text = "Depth";
            // 
            // DepthNone
            // 
            this.DepthNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DepthNone.ForeColor = System.Drawing.Color.White;
            this.DepthNone.Name = "DepthNone";
            this.DepthNone.Size = new System.Drawing.Size(103, 22);
            this.DepthNone.Text = "None";
            // 
            // ModeMenu
            // 
            this.ModeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeLive,
            this.ModePlayback,
            this.ModeRecord});
            this.ModeMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.ModeMenu.Name = "ModeMenu";
            this.ModeMenu.Size = new System.Drawing.Size(50, 20);
            this.ModeMenu.Text = "Mode";
            // 
            // ModeLive
            // 
            this.ModeLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModeLive.Checked = true;
            this.ModeLive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModeLive.ForeColor = System.Drawing.Color.White;
            this.ModeLive.Name = "ModeLive";
            this.ModeLive.Size = new System.Drawing.Size(121, 22);
            this.ModeLive.Text = "Live";
            this.ModeLive.Click += new System.EventHandler(this.ModeLive_Click);
            // 
            // ModePlayback
            // 
            this.ModePlayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModePlayback.ForeColor = System.Drawing.Color.White;
            this.ModePlayback.Name = "ModePlayback";
            this.ModePlayback.Size = new System.Drawing.Size(121, 22);
            this.ModePlayback.Text = "Playback";
            this.ModePlayback.Click += new System.EventHandler(this.ModePlayback_Click);
            // 
            // ModeRecord
            // 
            this.ModeRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ModeRecord.ForeColor = System.Drawing.Color.White;
            this.ModeRecord.Name = "ModeRecord";
            this.ModeRecord.Size = new System.Drawing.Size(121, 22);
            this.ModeRecord.Text = "Record";
            this.ModeRecord.Click += new System.EventHandler(this.ModeRecord_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Status2
            // 
            this.Status2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Status2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.Status2.Location = new System.Drawing.Point(0, 466);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(800, 22);
            this.Status2.TabIndex = 9;
            this.Status2.Text = "OK";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.tabPage1.Controls.Add(this.Landmarks);
            this.tabPage1.Controls.Add(this.Solid);
            this.tabPage1.Controls.Add(this.Textured);
            this.tabPage1.Controls.Add(this.OutOfRange);
            this.tabPage1.Controls.Add(this.FaceNotDetected);
            this.tabPage1.Controls.Add(this.TrackingLost);
            this.tabPage1.Controls.Add(this.TooClose);
            this.tabPage1.Controls.Add(this.TooFar);
            this.tabPage1.Controls.Add(this.OptionsLabel);
            this.tabPage1.Controls.Add(this.ModeLabel);
            this.tabPage1.Controls.Add(this.ScanningArea);
            this.tabPage1.Controls.Add(this.MainPanel);
            this.tabPage1.Controls.Add(this.flopPreviewImage);
            this.tabPage1.Controls.Add(this.Reconstruct);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "3D Reconstruction";
            // 
            // Landmarks
            // 
            this.Landmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Landmarks.AutoSize = true;
            this.Landmarks.BackColor = System.Drawing.Color.Transparent;
            this.Landmarks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Landmarks.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Landmarks.ForeColor = System.Drawing.Color.White;
            this.Landmarks.Location = new System.Drawing.Point(634, 38);
            this.Landmarks.Name = "Landmarks";
            this.Landmarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Landmarks.Size = new System.Drawing.Size(95, 23);
            this.Landmarks.TabIndex = 19;
            this.Landmarks.Text = "Landmarks";
            this.Landmarks.UseVisualStyleBackColor = false;
            this.Landmarks.CheckedChanged += new System.EventHandler(this.Landmarks_CheckedChanged);
            // 
            // Solid
            // 
            this.Solid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Solid.AutoSize = true;
            this.Solid.BackColor = System.Drawing.Color.Transparent;
            this.Solid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Solid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Solid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solid.ForeColor = System.Drawing.Color.White;
            this.Solid.Location = new System.Drawing.Point(634, 66);
            this.Solid.Name = "Solid";
            this.Solid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Solid.Size = new System.Drawing.Size(60, 23);
            this.Solid.TabIndex = 20;
            this.Solid.Text = "Solid";
            this.Solid.UseVisualStyleBackColor = false;
            // 
            // Textured
            // 
            this.Textured.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Textured.AutoSize = true;
            this.Textured.BackColor = System.Drawing.Color.Transparent;
            this.Textured.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Textured.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textured.ForeColor = System.Drawing.Color.White;
            this.Textured.Location = new System.Drawing.Point(634, 94);
            this.Textured.Name = "Textured";
            this.Textured.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Textured.Size = new System.Drawing.Size(74, 23);
            this.Textured.TabIndex = 21;
            this.Textured.Text = "Texture";
            this.Textured.UseVisualStyleBackColor = false;
            // 
            // OutOfRange
            // 
            this.OutOfRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutOfRange.AutoSize = true;
            this.OutOfRange.BackColor = System.Drawing.Color.Red;
            this.OutOfRange.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfRange.ForeColor = System.Drawing.Color.White;
            this.OutOfRange.Location = new System.Drawing.Point(512, 342);
            this.OutOfRange.Name = "OutOfRange";
            this.OutOfRange.Size = new System.Drawing.Size(89, 17);
            this.OutOfRange.TabIndex = 12;
            this.OutOfRange.Text = "Out of Range";
            this.OutOfRange.Visible = false;
            // 
            // FaceNotDetected
            // 
            this.FaceNotDetected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FaceNotDetected.AutoSize = true;
            this.FaceNotDetected.BackColor = System.Drawing.Color.Red;
            this.FaceNotDetected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaceNotDetected.ForeColor = System.Drawing.Color.White;
            this.FaceNotDetected.Location = new System.Drawing.Point(342, 342);
            this.FaceNotDetected.Name = "FaceNotDetected";
            this.FaceNotDetected.Size = new System.Drawing.Size(117, 17);
            this.FaceNotDetected.TabIndex = 13;
            this.FaceNotDetected.Text = "Face not detected";
            this.FaceNotDetected.Visible = false;
            // 
            // TrackingLost
            // 
            this.TrackingLost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackingLost.AutoSize = true;
            this.TrackingLost.BackColor = System.Drawing.Color.Red;
            this.TrackingLost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackingLost.ForeColor = System.Drawing.Color.White;
            this.TrackingLost.Location = new System.Drawing.Point(342, 370);
            this.TrackingLost.Name = "TrackingLost";
            this.TrackingLost.Size = new System.Drawing.Size(255, 17);
            this.TrackingLost.TabIndex = 14;
            this.TrackingLost.Text = "TRACKING LOST...align images to recover";
            this.TrackingLost.Visible = false;
            // 
            // TooClose
            // 
            this.TooClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TooClose.AutoSize = true;
            this.TooClose.BackColor = System.Drawing.Color.Red;
            this.TooClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TooClose.ForeColor = System.Drawing.Color.White;
            this.TooClose.Location = new System.Drawing.Point(224, 370);
            this.TooClose.Name = "TooClose";
            this.TooClose.Size = new System.Drawing.Size(74, 17);
            this.TooClose.TabIndex = 15;
            this.TooClose.Text = "Move back";
            this.TooClose.Visible = false;
            // 
            // TooFar
            // 
            this.TooFar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TooFar.AutoSize = true;
            this.TooFar.BackColor = System.Drawing.Color.Red;
            this.TooFar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TooFar.ForeColor = System.Drawing.Color.White;
            this.TooFar.Location = new System.Drawing.Point(224, 342);
            this.TooFar.Name = "TooFar";
            this.TooFar.Size = new System.Drawing.Size(91, 17);
            this.TooFar.TabIndex = 16;
            this.TooFar.Text = "Move Foward";
            this.TooFar.Visible = false;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.Color.White;
            this.OptionsLabel.Location = new System.Drawing.Point(621, 17);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(59, 19);
            this.OptionsLabel.TabIndex = 17;
            this.OptionsLabel.Text = "Options";
            // 
            // ModeLabel
            // 
            this.ModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.ForeColor = System.Drawing.Color.White;
            this.ModeLabel.Location = new System.Drawing.Point(621, 125);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(99, 19);
            this.ModeLabel.TabIndex = 18;
            this.ModeLabel.Text = "Scanning Area";
            // 
            // ScanningArea
            // 
            this.ScanningArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanningArea.BackColor = System.Drawing.SystemColors.Window;
            this.ScanningArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScanningArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanningArea.FormattingEnabled = true;
            this.ScanningArea.Items.AddRange(new object[] {
            "Object",
            "Face",
            "Head",
            "Body",
            "Full"});
            this.ScanningArea.Location = new System.Drawing.Point(624, 147);
            this.ScanningArea.Name = "ScanningArea";
            this.ScanningArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScanningArea.Size = new System.Drawing.Size(121, 21);
            this.ScanningArea.TabIndex = 10;
            this.ScanningArea.SelectedIndexChanged += new System.EventHandler(this.ScanningArea_SelectedIndexChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.ErrorImage = null;
            this.MainPanel.InitialImage = null;
            this.MainPanel.Location = new System.Drawing.Point(17, 17);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(590, 307);
            this.MainPanel.TabIndex = 9;
            this.MainPanel.TabStop = false;
            // 
            // flopPreviewImage
            // 
            this.flopPreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flopPreviewImage.AutoSize = true;
            this.flopPreviewImage.BackColor = System.Drawing.Color.Transparent;
            this.flopPreviewImage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flopPreviewImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flopPreviewImage.ForeColor = System.Drawing.Color.White;
            this.flopPreviewImage.Location = new System.Drawing.Point(631, 243);
            this.flopPreviewImage.Name = "flopPreviewImage";
            this.flopPreviewImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flopPreviewImage.Size = new System.Drawing.Size(108, 23);
            this.flopPreviewImage.TabIndex = 8;
            this.flopPreviewImage.Text = "Flop Preview";
            this.flopPreviewImage.UseVisualStyleBackColor = false;
            // 
            // Reconstruct
            // 
            this.Reconstruct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reconstruct.BackColor = System.Drawing.Color.DimGray;
            this.Reconstruct.FlatAppearance.BorderSize = 0;
            this.Reconstruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reconstruct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconstruct.ForeColor = System.Drawing.Color.White;
            this.Reconstruct.Location = new System.Drawing.Point(629, 184);
            this.Reconstruct.Name = "Reconstruct";
            this.Reconstruct.Size = new System.Drawing.Size(112, 53);
            this.Reconstruct.TabIndex = 11;
            this.Reconstruct.Text = "Start Scanning";
            this.Reconstruct.UseVisualStyleBackColor = false;
            this.Reconstruct.Click += new System.EventHandler(this.Reconstruct_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.DimGray;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(629, 271);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 53);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start Camera";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Web Asset";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 335);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(258, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Web Asset 1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(114, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Web Asset 2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D App Development";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status2.ResumeLayout(false);
            this.Status2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ColorMenu_Click(object sender, System.EventArgs e)
        {
            this.ColorMenu.ShowDropDown();
        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem DeviceMenu;
        private System.Windows.Forms.ToolStripMenuItem ColorMenu;
        private System.Windows.Forms.ToolStripMenuItem ColorNone;
        private System.Windows.Forms.ToolStripMenuItem DepthMenu;
        private System.Windows.Forms.ToolStripMenuItem DepthNone;
        private System.Windows.Forms.ToolStripMenuItem ModeMenu;
        private System.Windows.Forms.ToolStripMenuItem ModeLive;
        private System.Windows.Forms.ToolStripMenuItem ModePlayback;
        private System.Windows.Forms.ToolStripMenuItem ModeRecord;
        private System.Windows.Forms.StatusStrip Status2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox Landmarks;
        private System.Windows.Forms.CheckBox Solid;
        private System.Windows.Forms.CheckBox Textured;
        public System.Windows.Forms.Label OutOfRange;
        public System.Windows.Forms.Label FaceNotDetected;
        private System.Windows.Forms.Label TrackingLost;
        private System.Windows.Forms.Label TooClose;
        private System.Windows.Forms.Label TooFar;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ComboBox ScanningArea;
        private System.Windows.Forms.PictureBox MainPanel;
        private System.Windows.Forms.CheckBox flopPreviewImage;
        private System.Windows.Forms.Button Reconstruct;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

