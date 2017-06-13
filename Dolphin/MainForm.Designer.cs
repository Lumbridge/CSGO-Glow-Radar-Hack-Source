﻿namespace Dolphin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.glowTab = new System.Windows.Forms.TabPage();
            this.enemyColorPickButton = new System.Windows.Forms.Button();
            this.enemyColourBasedOnHPCheckBox = new System.Windows.Forms.CheckBox();
            this.teamColourBasedOnHPCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamBNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teamGNumberBox = new System.Windows.Forms.NumericUpDown();
            this.teamRNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.enemyBNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enemyGNumberBox = new System.Windows.Forms.NumericUpDown();
            this.enemyRNumberBox = new System.Windows.Forms.NumericUpDown();
            this.rainbowEnemyCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowTeamCheckbox = new System.Windows.Forms.CheckBox();
            this.glowEnabledEnemyCheckBox = new System.Windows.Forms.CheckBox();
            this.glowEnabledTeamCheckBox = new System.Windows.Forms.CheckBox();
            this.teamColorPickButton = new System.Windows.Forms.Button();
            this.radarTab = new System.Windows.Forms.TabPage();
            this.radarOpacityLabel = new System.Windows.Forms.Label();
            this.radarOpacityNumberBox = new System.Windows.Forms.NumericUpDown();
            this.radarRightButton = new System.Windows.Forms.Button();
            this.radarDownButton = new System.Windows.Forms.Button();
            this.radarUpButton = new System.Windows.Forms.Button();
            this.radarLeftButton = new System.Windows.Forms.Button();
            this.radarTopLeftYLabel = new System.Windows.Forms.Label();
            this.radarTopLeftXLabel = new System.Windows.Forms.Label();
            this.rdrTopLeftY = new System.Windows.Forms.NumericUpDown();
            this.rdrTopLeftX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radarBlipSizeNumberBox = new System.Windows.Forms.NumericUpDown();
            this.radarSizeNumberBox = new System.Windows.Forms.NumericUpDown();
            this.enableRadarCheckBox = new System.Windows.Forms.CheckBox();
            this.configTab = new System.Windows.Forms.TabPage();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.loadConfigButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.glowTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRNumberBox)).BeginInit();
            this.radarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarOpacityNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarBlipSizeNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarSizeNumberBox)).BeginInit();
            this.configTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.glowTab);
            this.tabControl1.Controls.Add(this.radarTab);
            this.tabControl1.Controls.Add(this.configTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 205);
            this.tabControl1.TabIndex = 39;
            // 
            // glowTab
            // 
            this.glowTab.Controls.Add(this.enemyColorPickButton);
            this.glowTab.Controls.Add(this.enemyColourBasedOnHPCheckBox);
            this.glowTab.Controls.Add(this.teamColourBasedOnHPCheckBox);
            this.glowTab.Controls.Add(this.label3);
            this.glowTab.Controls.Add(this.teamBNumberBox);
            this.glowTab.Controls.Add(this.label4);
            this.glowTab.Controls.Add(this.label5);
            this.glowTab.Controls.Add(this.teamGNumberBox);
            this.glowTab.Controls.Add(this.teamRNumberBox);
            this.glowTab.Controls.Add(this.label6);
            this.glowTab.Controls.Add(this.enemyBNumberBox);
            this.glowTab.Controls.Add(this.label7);
            this.glowTab.Controls.Add(this.label8);
            this.glowTab.Controls.Add(this.enemyGNumberBox);
            this.glowTab.Controls.Add(this.enemyRNumberBox);
            this.glowTab.Controls.Add(this.rainbowEnemyCheckBox);
            this.glowTab.Controls.Add(this.rainbowTeamCheckbox);
            this.glowTab.Controls.Add(this.glowEnabledEnemyCheckBox);
            this.glowTab.Controls.Add(this.glowEnabledTeamCheckBox);
            this.glowTab.Controls.Add(this.teamColorPickButton);
            this.glowTab.Location = new System.Drawing.Point(4, 22);
            this.glowTab.Name = "glowTab";
            this.glowTab.Padding = new System.Windows.Forms.Padding(3);
            this.glowTab.Size = new System.Drawing.Size(394, 179);
            this.glowTab.TabIndex = 0;
            this.glowTab.Text = "Glow Settings";
            this.glowTab.UseVisualStyleBackColor = true;
            // 
            // enemyColorPickButton
            // 
            this.enemyColorPickButton.Location = new System.Drawing.Point(325, 29);
            this.enemyColorPickButton.Name = "enemyColorPickButton";
            this.enemyColorPickButton.Size = new System.Drawing.Size(57, 72);
            this.enemyColorPickButton.TabIndex = 57;
            this.enemyColorPickButton.Text = "Custom Enemy Colour";
            this.enemyColorPickButton.UseVisualStyleBackColor = true;
            this.enemyColorPickButton.Click += new System.EventHandler(this.enemyColorPickButton_Click);
            // 
            // enemyColourBasedOnHPCheckBox
            // 
            this.enemyColourBasedOnHPCheckBox.AutoSize = true;
            this.enemyColourBasedOnHPCheckBox.Location = new System.Drawing.Point(208, 133);
            this.enemyColourBasedOnHPCheckBox.Name = "enemyColourBasedOnHPCheckBox";
            this.enemyColourBasedOnHPCheckBox.Size = new System.Drawing.Size(160, 17);
            this.enemyColourBasedOnHPCheckBox.TabIndex = 56;
            this.enemyColourBasedOnHPCheckBox.Text = " Enemy Colour Based on HP";
            this.enemyColourBasedOnHPCheckBox.UseVisualStyleBackColor = true;
            this.enemyColourBasedOnHPCheckBox.CheckedChanged += new System.EventHandler(this.enemyColourBasedOnHPCheckBox_CheckedChanged);
            // 
            // teamColourBasedOnHPCheckBox
            // 
            this.teamColourBasedOnHPCheckBox.AutoSize = true;
            this.teamColourBasedOnHPCheckBox.Location = new System.Drawing.Point(6, 133);
            this.teamColourBasedOnHPCheckBox.Name = "teamColourBasedOnHPCheckBox";
            this.teamColourBasedOnHPCheckBox.Size = new System.Drawing.Size(152, 17);
            this.teamColourBasedOnHPCheckBox.TabIndex = 55;
            this.teamColourBasedOnHPCheckBox.Text = "Team Colour Based on HP";
            this.teamColourBasedOnHPCheckBox.UseVisualStyleBackColor = true;
            this.teamColourBasedOnHPCheckBox.CheckedChanged += new System.EventHandler(this.teamColourBasedOnHPCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "B";
            // 
            // teamBNumberBox
            // 
            this.teamBNumberBox.Location = new System.Drawing.Point(6, 81);
            this.teamBNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.teamBNumberBox.Name = "teamBNumberBox";
            this.teamBNumberBox.Size = new System.Drawing.Size(91, 20);
            this.teamBNumberBox.TabIndex = 53;
            this.teamBNumberBox.ValueChanged += new System.EventHandler(this.teamBNumberBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "R";
            // 
            // teamGNumberBox
            // 
            this.teamGNumberBox.Location = new System.Drawing.Point(6, 55);
            this.teamGNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.teamGNumberBox.Name = "teamGNumberBox";
            this.teamGNumberBox.Size = new System.Drawing.Size(91, 20);
            this.teamGNumberBox.TabIndex = 50;
            this.teamGNumberBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.teamGNumberBox.ValueChanged += new System.EventHandler(this.teamGNumberBox_ValueChanged);
            // 
            // teamRNumberBox
            // 
            this.teamRNumberBox.Location = new System.Drawing.Point(6, 29);
            this.teamRNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.teamRNumberBox.Name = "teamRNumberBox";
            this.teamRNumberBox.Size = new System.Drawing.Size(91, 20);
            this.teamRNumberBox.TabIndex = 49;
            this.teamRNumberBox.ValueChanged += new System.EventHandler(this.teamRNumberBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "B";
            // 
            // enemyBNumberBox
            // 
            this.enemyBNumberBox.Location = new System.Drawing.Point(208, 81);
            this.enemyBNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.enemyBNumberBox.Name = "enemyBNumberBox";
            this.enemyBNumberBox.Size = new System.Drawing.Size(91, 20);
            this.enemyBNumberBox.TabIndex = 47;
            this.enemyBNumberBox.ValueChanged += new System.EventHandler(this.enemyBNumberBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "G";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "R";
            // 
            // enemyGNumberBox
            // 
            this.enemyGNumberBox.Location = new System.Drawing.Point(208, 55);
            this.enemyGNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.enemyGNumberBox.Name = "enemyGNumberBox";
            this.enemyGNumberBox.Size = new System.Drawing.Size(91, 20);
            this.enemyGNumberBox.TabIndex = 44;
            this.enemyGNumberBox.ValueChanged += new System.EventHandler(this.enemyGNumberBox_ValueChanged);
            // 
            // enemyRNumberBox
            // 
            this.enemyRNumberBox.Location = new System.Drawing.Point(208, 29);
            this.enemyRNumberBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.enemyRNumberBox.Name = "enemyRNumberBox";
            this.enemyRNumberBox.Size = new System.Drawing.Size(91, 20);
            this.enemyRNumberBox.TabIndex = 43;
            this.enemyRNumberBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.enemyRNumberBox.ValueChanged += new System.EventHandler(this.enemyRNumberBox_ValueChanged);
            // 
            // rainbowEnemyCheckBox
            // 
            this.rainbowEnemyCheckBox.AutoSize = true;
            this.rainbowEnemyCheckBox.Location = new System.Drawing.Point(208, 110);
            this.rainbowEnemyCheckBox.Name = "rainbowEnemyCheckBox";
            this.rainbowEnemyCheckBox.Size = new System.Drawing.Size(130, 17);
            this.rainbowEnemyCheckBox.TabIndex = 42;
            this.rainbowEnemyCheckBox.Text = "Rainbow Enemy Glow";
            this.rainbowEnemyCheckBox.UseVisualStyleBackColor = true;
            this.rainbowEnemyCheckBox.CheckedChanged += new System.EventHandler(this.rainbowEnemyCheckBox_CheckedChanged);
            // 
            // rainbowTeamCheckbox
            // 
            this.rainbowTeamCheckbox.AutoSize = true;
            this.rainbowTeamCheckbox.Location = new System.Drawing.Point(6, 110);
            this.rainbowTeamCheckbox.Name = "rainbowTeamCheckbox";
            this.rainbowTeamCheckbox.Size = new System.Drawing.Size(125, 17);
            this.rainbowTeamCheckbox.TabIndex = 41;
            this.rainbowTeamCheckbox.Text = "Rainbow Team Glow";
            this.rainbowTeamCheckbox.UseVisualStyleBackColor = true;
            this.rainbowTeamCheckbox.CheckedChanged += new System.EventHandler(this.rainbowTeamCheckbox_CheckedChanged);
            // 
            // glowEnabledEnemyCheckBox
            // 
            this.glowEnabledEnemyCheckBox.AutoSize = true;
            this.glowEnabledEnemyCheckBox.Checked = true;
            this.glowEnabledEnemyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.glowEnabledEnemyCheckBox.Location = new System.Drawing.Point(208, 6);
            this.glowEnabledEnemyCheckBox.Name = "glowEnabledEnemyCheckBox";
            this.glowEnabledEnemyCheckBox.Size = new System.Drawing.Size(121, 17);
            this.glowEnabledEnemyCheckBox.TabIndex = 40;
            this.glowEnabledEnemyCheckBox.Text = "Enable Enemy Glow";
            this.glowEnabledEnemyCheckBox.UseVisualStyleBackColor = true;
            this.glowEnabledEnemyCheckBox.CheckedChanged += new System.EventHandler(this.glowEnabledEnemyCheckBox_CheckedChanged);
            // 
            // glowEnabledTeamCheckBox
            // 
            this.glowEnabledTeamCheckBox.AutoSize = true;
            this.glowEnabledTeamCheckBox.Checked = true;
            this.glowEnabledTeamCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.glowEnabledTeamCheckBox.Location = new System.Drawing.Point(6, 6);
            this.glowEnabledTeamCheckBox.Name = "glowEnabledTeamCheckBox";
            this.glowEnabledTeamCheckBox.Size = new System.Drawing.Size(116, 17);
            this.glowEnabledTeamCheckBox.TabIndex = 39;
            this.glowEnabledTeamCheckBox.Text = "Enable Team Glow";
            this.glowEnabledTeamCheckBox.UseVisualStyleBackColor = true;
            this.glowEnabledTeamCheckBox.CheckedChanged += new System.EventHandler(this.glowEnabledTeamCheckBox_CheckedChanged);
            // 
            // teamColorPickButton
            // 
            this.teamColorPickButton.Location = new System.Drawing.Point(124, 29);
            this.teamColorPickButton.Name = "teamColorPickButton";
            this.teamColorPickButton.Size = new System.Drawing.Size(57, 72);
            this.teamColorPickButton.TabIndex = 58;
            this.teamColorPickButton.Text = "Custom Team Colour";
            this.teamColorPickButton.UseVisualStyleBackColor = true;
            this.teamColorPickButton.Click += new System.EventHandler(this.teamColorPickButton_Click);
            // 
            // radarTab
            // 
            this.radarTab.Controls.Add(this.radarOpacityLabel);
            this.radarTab.Controls.Add(this.radarOpacityNumberBox);
            this.radarTab.Controls.Add(this.radarRightButton);
            this.radarTab.Controls.Add(this.radarDownButton);
            this.radarTab.Controls.Add(this.radarUpButton);
            this.radarTab.Controls.Add(this.radarLeftButton);
            this.radarTab.Controls.Add(this.radarTopLeftYLabel);
            this.radarTab.Controls.Add(this.radarTopLeftXLabel);
            this.radarTab.Controls.Add(this.rdrTopLeftY);
            this.radarTab.Controls.Add(this.rdrTopLeftX);
            this.radarTab.Controls.Add(this.label2);
            this.radarTab.Controls.Add(this.label1);
            this.radarTab.Controls.Add(this.radarBlipSizeNumberBox);
            this.radarTab.Controls.Add(this.radarSizeNumberBox);
            this.radarTab.Controls.Add(this.enableRadarCheckBox);
            this.radarTab.Location = new System.Drawing.Point(4, 22);
            this.radarTab.Name = "radarTab";
            this.radarTab.Padding = new System.Windows.Forms.Padding(3);
            this.radarTab.Size = new System.Drawing.Size(394, 179);
            this.radarTab.TabIndex = 1;
            this.radarTab.Text = "Radar Settings";
            this.radarTab.UseVisualStyleBackColor = true;
            // 
            // radarOpacityLabel
            // 
            this.radarOpacityLabel.AutoSize = true;
            this.radarOpacityLabel.Location = new System.Drawing.Point(115, 141);
            this.radarOpacityLabel.Name = "radarOpacityLabel";
            this.radarOpacityLabel.Size = new System.Drawing.Size(75, 13);
            this.radarOpacityLabel.TabIndex = 30;
            this.radarOpacityLabel.Text = "Radar Opacity";
            // 
            // radarOpacityNumberBox
            // 
            this.radarOpacityNumberBox.DecimalPlaces = 1;
            this.radarOpacityNumberBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radarOpacityNumberBox.Location = new System.Drawing.Point(18, 139);
            this.radarOpacityNumberBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radarOpacityNumberBox.Name = "radarOpacityNumberBox";
            this.radarOpacityNumberBox.Size = new System.Drawing.Size(91, 20);
            this.radarOpacityNumberBox.TabIndex = 29;
            this.radarOpacityNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radarOpacityNumberBox.ValueChanged += new System.EventHandler(this.radarOpacityNumberBox_ValueChanged);
            // 
            // radarRightButton
            // 
            this.radarRightButton.Location = new System.Drawing.Point(327, 55);
            this.radarRightButton.Name = "radarRightButton";
            this.radarRightButton.Size = new System.Drawing.Size(50, 50);
            this.radarRightButton.TabIndex = 28;
            this.radarRightButton.Text = ">";
            this.radarRightButton.UseVisualStyleBackColor = true;
            this.radarRightButton.Click += new System.EventHandler(this.radarRightButton_Click);
            // 
            // radarDownButton
            // 
            this.radarDownButton.Location = new System.Drawing.Point(271, 82);
            this.radarDownButton.Name = "radarDownButton";
            this.radarDownButton.Size = new System.Drawing.Size(50, 50);
            this.radarDownButton.TabIndex = 27;
            this.radarDownButton.Text = "v";
            this.radarDownButton.UseVisualStyleBackColor = true;
            this.radarDownButton.Click += new System.EventHandler(this.radarDownButton_Click);
            // 
            // radarUpButton
            // 
            this.radarUpButton.Location = new System.Drawing.Point(271, 26);
            this.radarUpButton.Name = "radarUpButton";
            this.radarUpButton.Size = new System.Drawing.Size(50, 50);
            this.radarUpButton.TabIndex = 26;
            this.radarUpButton.Text = "^";
            this.radarUpButton.UseVisualStyleBackColor = true;
            this.radarUpButton.Click += new System.EventHandler(this.radarUpButton_Click);
            // 
            // radarLeftButton
            // 
            this.radarLeftButton.Location = new System.Drawing.Point(215, 55);
            this.radarLeftButton.Name = "radarLeftButton";
            this.radarLeftButton.Size = new System.Drawing.Size(50, 50);
            this.radarLeftButton.TabIndex = 25;
            this.radarLeftButton.Text = "<";
            this.radarLeftButton.UseVisualStyleBackColor = true;
            this.radarLeftButton.Click += new System.EventHandler(this.radarLeftButton_Click);
            // 
            // radarTopLeftYLabel
            // 
            this.radarTopLeftYLabel.AutoSize = true;
            this.radarTopLeftYLabel.Location = new System.Drawing.Point(115, 115);
            this.radarTopLeftYLabel.Name = "radarTopLeftYLabel";
            this.radarTopLeftYLabel.Size = new System.Drawing.Size(89, 13);
            this.radarTopLeftYLabel.TabIndex = 24;
            this.radarTopLeftYLabel.Text = "Radar Top Left Y";
            // 
            // radarTopLeftXLabel
            // 
            this.radarTopLeftXLabel.AutoSize = true;
            this.radarTopLeftXLabel.Location = new System.Drawing.Point(115, 89);
            this.radarTopLeftXLabel.Name = "radarTopLeftXLabel";
            this.radarTopLeftXLabel.Size = new System.Drawing.Size(89, 13);
            this.radarTopLeftXLabel.TabIndex = 23;
            this.radarTopLeftXLabel.Text = "Radar Top Left X";
            // 
            // rdrTopLeftY
            // 
            this.rdrTopLeftY.Location = new System.Drawing.Point(18, 113);
            this.rdrTopLeftY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rdrTopLeftY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rdrTopLeftY.Name = "rdrTopLeftY";
            this.rdrTopLeftY.Size = new System.Drawing.Size(91, 20);
            this.rdrTopLeftY.TabIndex = 22;
            this.rdrTopLeftY.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.rdrTopLeftY.ValueChanged += new System.EventHandler(this.rdrTopLeftY_ValueChanged);
            // 
            // rdrTopLeftX
            // 
            this.rdrTopLeftX.Location = new System.Drawing.Point(18, 87);
            this.rdrTopLeftX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rdrTopLeftX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rdrTopLeftX.Name = "rdrTopLeftX";
            this.rdrTopLeftX.Size = new System.Drawing.Size(91, 20);
            this.rdrTopLeftX.TabIndex = 21;
            this.rdrTopLeftX.Value = new decimal(new int[] {
            286,
            0,
            0,
            0});
            this.rdrTopLeftX.ValueChanged += new System.EventHandler(this.rdrTopLeftX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Radar Blip Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Radar Size";
            // 
            // radarBlipSizeNumberBox
            // 
            this.radarBlipSizeNumberBox.Location = new System.Drawing.Point(18, 61);
            this.radarBlipSizeNumberBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.radarBlipSizeNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radarBlipSizeNumberBox.Name = "radarBlipSizeNumberBox";
            this.radarBlipSizeNumberBox.Size = new System.Drawing.Size(91, 20);
            this.radarBlipSizeNumberBox.TabIndex = 18;
            this.radarBlipSizeNumberBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.radarBlipSizeNumberBox.ValueChanged += new System.EventHandler(this.radarBlipSizeNumberBox_ValueChanged);
            // 
            // radarSizeNumberBox
            // 
            this.radarSizeNumberBox.Location = new System.Drawing.Point(18, 35);
            this.radarSizeNumberBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.radarSizeNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radarSizeNumberBox.Name = "radarSizeNumberBox";
            this.radarSizeNumberBox.Size = new System.Drawing.Size(91, 20);
            this.radarSizeNumberBox.TabIndex = 17;
            this.radarSizeNumberBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.radarSizeNumberBox.ValueChanged += new System.EventHandler(this.radarSizeNumberBox_ValueChanged);
            // 
            // enableRadarCheckBox
            // 
            this.enableRadarCheckBox.AutoSize = true;
            this.enableRadarCheckBox.Checked = true;
            this.enableRadarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableRadarCheckBox.Location = new System.Drawing.Point(18, 12);
            this.enableRadarCheckBox.Name = "enableRadarCheckBox";
            this.enableRadarCheckBox.Size = new System.Drawing.Size(91, 17);
            this.enableRadarCheckBox.TabIndex = 16;
            this.enableRadarCheckBox.Text = "Enable Radar";
            this.enableRadarCheckBox.UseVisualStyleBackColor = true;
            this.enableRadarCheckBox.CheckedChanged += new System.EventHandler(this.enableRadarCheckBox_CheckedChanged);
            // 
            // configTab
            // 
            this.configTab.Controls.Add(this.saveConfigButton);
            this.configTab.Controls.Add(this.loadConfigButton);
            this.configTab.Location = new System.Drawing.Point(4, 22);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(394, 179);
            this.configTab.TabIndex = 2;
            this.configTab.Text = "Config";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(104, 74);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.saveConfigButton.TabIndex = 1;
            this.saveConfigButton.Text = "Save Config";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // loadConfigButton
            // 
            this.loadConfigButton.Location = new System.Drawing.Point(218, 74);
            this.loadConfigButton.Name = "loadConfigButton";
            this.loadConfigButton.Size = new System.Drawing.Size(75, 23);
            this.loadConfigButton.TabIndex = 0;
            this.loadConfigButton.Text = "Load Config";
            this.loadConfigButton.UseVisualStyleBackColor = true;
            this.loadConfigButton.Click += new System.EventHandler(this.loadConfigButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 217);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 217);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dolphin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.glowTab.ResumeLayout(false);
            this.glowTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRNumberBox)).EndInit();
            this.radarTab.ResumeLayout(false);
            this.radarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarOpacityNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarBlipSizeNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarSizeNumberBox)).EndInit();
            this.configTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage glowTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage radarTab;
        private System.Windows.Forms.Label radarOpacityLabel;
        private System.Windows.Forms.NumericUpDown radarOpacityNumberBox;
        private System.Windows.Forms.Button radarRightButton;
        private System.Windows.Forms.Button radarDownButton;
        private System.Windows.Forms.Button radarUpButton;
        private System.Windows.Forms.Button radarLeftButton;
        private System.Windows.Forms.Label radarTopLeftYLabel;
        private System.Windows.Forms.Label radarTopLeftXLabel;
        private System.Windows.Forms.NumericUpDown rdrTopLeftY;
        private System.Windows.Forms.NumericUpDown rdrTopLeftX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radarBlipSizeNumberBox;
        private System.Windows.Forms.NumericUpDown radarSizeNumberBox;
        private System.Windows.Forms.CheckBox enableRadarCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button enemyColorPickButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.NumericUpDown teamBNumberBox;
        public System.Windows.Forms.NumericUpDown teamGNumberBox;
        public System.Windows.Forms.NumericUpDown teamRNumberBox;
        public System.Windows.Forms.NumericUpDown enemyBNumberBox;
        public System.Windows.Forms.NumericUpDown enemyGNumberBox;
        public System.Windows.Forms.NumericUpDown enemyRNumberBox;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.Button loadConfigButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.CheckBox enemyColourBasedOnHPCheckBox;
        public System.Windows.Forms.CheckBox teamColourBasedOnHPCheckBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox rainbowEnemyCheckBox;
        public System.Windows.Forms.CheckBox rainbowTeamCheckbox;
        public System.Windows.Forms.CheckBox glowEnabledEnemyCheckBox;
        public System.Windows.Forms.CheckBox glowEnabledTeamCheckBox;
        public System.Windows.Forms.Button teamColorPickButton;
    }
}