﻿using System;

namespace Laba1
{
    partial class mBox
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
            this.components = new System.ComponentModel.Container();
            this.WireBox = new System.Windows.Forms.CheckBox();
            this.figureBox = new System.Windows.Forms.ComboBox();
            this.figureLabel = new System.Windows.Forms.Label();
            this.axisLabel = new System.Windows.Forms.Label();
            this.axisBox = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Append = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ToCenter = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textComboBox = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.CheckBox();
            this.moved = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flexx = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WireBox
            // 
            this.WireBox.AutoSize = true;
            this.WireBox.Location = new System.Drawing.Point(13, 680);
            this.WireBox.Name = "WireBox";
            this.WireBox.Size = new System.Drawing.Size(48, 17);
            this.WireBox.TabIndex = 5;
            this.WireBox.Text = "Wire";
            this.WireBox.UseVisualStyleBackColor = true;
            this.WireBox.CheckedChanged += new System.EventHandler(this.WireBox_CheckedChanged);
            // 
            // figureBox
            // 
            this.figureBox.FormattingEnabled = true;
            this.figureBox.Items.AddRange(new object[] {
            "Cylinder",
            "Sphere",
            "Cube",
            "Cone",
            "Torus",
            "Tree",
            "Snowman",
            "Apple&Boxes",
            "Graph",
            "Crank Mechanism"});
            this.figureBox.Location = new System.Drawing.Point(14, 653);
            this.figureBox.Name = "figureBox";
            this.figureBox.Size = new System.Drawing.Size(116, 21);
            this.figureBox.TabIndex = 4;
            // 
            // figureLabel
            // 
            this.figureLabel.AutoSize = true;
            this.figureLabel.Location = new System.Drawing.Point(10, 637);
            this.figureLabel.Name = "figureLabel";
            this.figureLabel.Size = new System.Drawing.Size(36, 13);
            this.figureLabel.TabIndex = 6;
            this.figureLabel.Text = "Figure";
            // 
            // axisLabel
            // 
            this.axisLabel.AutoSize = true;
            this.axisLabel.Location = new System.Drawing.Point(11, 597);
            this.axisLabel.Name = "axisLabel";
            this.axisLabel.Size = new System.Drawing.Size(26, 13);
            this.axisLabel.TabIndex = 2;
            this.axisLabel.Text = "Axis";
            // 
            // axisBox
            // 
            this.axisBox.FormattingEnabled = true;
            this.axisBox.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.axisBox.Location = new System.Drawing.Point(13, 613);
            this.axisBox.Name = "axisBox";
            this.axisBox.Size = new System.Drawing.Size(117, 21);
            this.axisBox.TabIndex = 3;
            this.axisBox.SelectedIndexChanged += new System.EventHandler(this.axisBox_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(346, 604);
            this.trackBar1.Maximum = 20000;
            this.trackBar1.Minimum = -20000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(178, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "z";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Angle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zoom";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(346, 639);
            this.trackBar2.Maximum = 20000;
            this.trackBar2.Minimum = -20000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(178, 45);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(346, 674);
            this.trackBar3.Maximum = 10000;
            this.trackBar3.Minimum = -50000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(178, 45);
            this.trackBar3.TabIndex = 18;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(616, 645);
            this.trackBar5.Maximum = 5000;
            this.trackBar5.Minimum = 1000;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(154, 45);
            this.trackBar5.TabIndex = 20;
            this.trackBar5.Value = 1000;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Apple";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 645);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 664);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 682);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "d";
            // 
            // Append
            // 
            this.Append.Enabled = false;
            this.Append.Location = new System.Drawing.Point(206, 671);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(72, 24);
            this.Append.TabIndex = 30;
            this.Append.Text = "Применить";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(963, 611);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(59, 23);
            this.Up.TabIndex = 31;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(927, 639);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(42, 23);
            this.LeftButton.TabIndex = 32;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(1019, 639);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(51, 23);
            this.RightButton.TabIndex = 33;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(963, 671);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(59, 23);
            this.DownButton.TabIndex = 34;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(1028, 671);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(51, 41);
            this.StopButton.TabIndex = 35;
            this.StopButton.Text = "СТОП";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ToCenter
            // 
            this.ToCenter.Location = new System.Drawing.Point(989, 639);
            this.ToCenter.Name = "ToCenter";
            this.ToCenter.Size = new System.Drawing.Size(16, 23);
            this.ToCenter.TabIndex = 36;
            this.ToCenter.Text = "C";
            this.ToCenter.UseVisualStyleBackColor = true;
            this.ToCenter.Click += new System.EventHandler(this.ToCenter_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(157, 642);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(43, 20);
            this.nTextBox.TabIndex = 37;
            this.nTextBox.TextChanged += new System.EventHandler(this.nTextBox_TextChanged);
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(157, 661);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(43, 20);
            this.mTextBox.TabIndex = 38;
            this.mTextBox.TextChanged += new System.EventHandler(this.mTextBox_TextChanged);
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(157, 679);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(43, 20);
            this.dTextBox.TabIndex = 39;
            this.dTextBox.TextChanged += new System.EventHandler(this.dTextBox_TextChanged);
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 10;
            this.speedBar.Location = new System.Drawing.Point(1113, 604);
            this.speedBar.Maximum = 50;
            this.speedBar.Name = "speedBar";
            this.speedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedBar.Size = new System.Drawing.Size(45, 115);
            this.speedBar.TabIndex = 40;
            this.speedBar.Value = 5;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1054, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 599);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Texture";
            // 
            // textComboBox
            // 
            this.textComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple",
            "Stick",
            "Leave",
            "Floor",
            "Background"});
            this.textComboBox.FormattingEnabled = true;
            this.textComboBox.Items.AddRange(new object[] {
            "Apple",
            "Stick",
            "Leave",
            "Floor",
            "Snake"});
            this.textComboBox.Location = new System.Drawing.Point(157, 615);
            this.textComboBox.Name = "textComboBox";
            this.textComboBox.Size = new System.Drawing.Size(121, 21);
            this.textComboBox.TabIndex = 43;
            // 
            // loadButton
            // 
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(206, 642);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(72, 23);
            this.loadButton.TabIndex = 45;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(616, 610);
            this.trackBar4.Maximum = 360;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(154, 45);
            this.trackBar4.TabIndex = 19;
            this.trackBar4.Value = 180;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSize = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 58);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1132, 533);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 47;
            this.AnT.Load += new System.EventHandler(this.AnT_Load_1);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(796, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(796, 636);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(816, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(816, 636);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(816, 671);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(816, 690);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "label17";
            // 
            // center
            // 
            this.center.AutoSize = true;
            this.center.Location = new System.Drawing.Point(864, 671);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(57, 17);
            this.center.TabIndex = 54;
            this.center.Text = "Center";
            this.center.UseVisualStyleBackColor = true;
            // 
            // moved
            // 
            this.moved.AutoSize = true;
            this.moved.Location = new System.Drawing.Point(863, 688);
            this.moved.Name = "moved";
            this.moved.Size = new System.Drawing.Size(58, 17);
            this.moved.TabIndex = 55;
            this.moved.Text = "moved";
            this.moved.UseVisualStyleBackColor = true;
            this.moved.CheckedChanged += new System.EventHandler(this.Error_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(816, 710);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(880, 618);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(880, 636);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(880, 710);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "label21";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadImageToolStripMenuItem.Text = "LoadImage";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // flexx
            // 
            this.flexx.AutoSize = true;
            this.flexx.Location = new System.Drawing.Point(579, 677);
            this.flexx.Name = "flexx";
            this.flexx.Size = new System.Drawing.Size(58, 17);
            this.flexx.TabIndex = 61;
            this.flexx.Text = "Fle$$$";
            this.flexx.UseVisualStyleBackColor = true;
            this.flexx.CheckedChanged += new System.EventHandler(this.flexx_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "y = sin(x)"});
            this.comboBox1.Location = new System.Drawing.Point(389, 710);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 62;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(335, 718);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 64;
            this.label23.Text = "Function";
            // 
            // mBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1156, 762);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flexx);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.moved);
            this.Controls.Add(this.center);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.textComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.ToCenter);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.figureLabel);
            this.Controls.Add(this.WireBox);
            this.Controls.Add(this.figureBox);
            this.Controls.Add(this.axisBox);
            this.Controls.Add(this.axisLabel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "mBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.CheckBox WireBox;
        private System.Windows.Forms.ComboBox figureBox;
        private System.Windows.Forms.Label figureLabel;
        private System.Windows.Forms.Label axisLabel;
        private System.Windows.Forms.ComboBox axisBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ToCenter;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox textComboBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TrackBar trackBar4;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox center;
        private System.Windows.Forms.CheckBox moved;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.CheckBox flexx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label23;
    }
}

