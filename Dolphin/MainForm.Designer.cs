namespace Dolphin
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
            this.ESPTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customSkeletonESPEnemyColourButton = new System.Windows.Forms.Button();
            this.customSkeletonESPTeamColourButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customBoxESPEnemyColourButton = new System.Windows.Forms.Button();
            this.customBoxESPTeamColourButton = new System.Windows.Forms.Button();
            this.enableEnemySkeletonsCheckbox = new System.Windows.Forms.CheckBox();
            this.enableTeamSkeletonsCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowEnemyBoxESPCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowTeamBoxESPCheckBox = new System.Windows.Forms.CheckBox();
            this.enableEnemyBoxESPCheckBox = new System.Windows.Forms.CheckBox();
            this.enableTeamBoxESPCheckBox = new System.Windows.Forms.CheckBox();
            this.glowTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enemyColourPickButton = new System.Windows.Forms.Button();
            this.enemyColourBasedOnHPCheckBox = new System.Windows.Forms.CheckBox();
            this.teamColourBasedOnHPCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowEnemyCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowTeamCheckbox = new System.Windows.Forms.CheckBox();
            this.glowEnabledEnemyCheckBox = new System.Windows.Forms.CheckBox();
            this.glowEnabledTeamCheckBox = new System.Windows.Forms.CheckBox();
            this.teamColourPickButton = new System.Windows.Forms.Button();
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
            this.rainbowEnemySkeletonESPCheckBox = new System.Windows.Forms.CheckBox();
            this.rainbowTeamSkeletonESPCheckBox = new System.Windows.Forms.CheckBox();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.ESPTab.SuspendLayout();
            this.glowTab.SuspendLayout();
            this.radarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarOpacityNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarBlipSizeNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarSizeNumberBox)).BeginInit();
            this.configTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ESPTab);
            this.tabControl1.Controls.Add(this.glowTab);
            this.tabControl1.Controls.Add(this.radarTab);
            this.tabControl1.Controls.Add(this.miscTab);
            this.tabControl1.Controls.Add(this.configTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 205);
            this.tabControl1.TabIndex = 39;
            // 
            // ESPTab
            // 
            this.ESPTab.Controls.Add(this.rainbowEnemySkeletonESPCheckBox);
            this.ESPTab.Controls.Add(this.rainbowTeamSkeletonESPCheckBox);
            this.ESPTab.Controls.Add(this.label7);
            this.ESPTab.Controls.Add(this.label8);
            this.ESPTab.Controls.Add(this.customSkeletonESPEnemyColourButton);
            this.ESPTab.Controls.Add(this.customSkeletonESPTeamColourButton);
            this.ESPTab.Controls.Add(this.label5);
            this.ESPTab.Controls.Add(this.label6);
            this.ESPTab.Controls.Add(this.customBoxESPEnemyColourButton);
            this.ESPTab.Controls.Add(this.customBoxESPTeamColourButton);
            this.ESPTab.Controls.Add(this.enableEnemySkeletonsCheckbox);
            this.ESPTab.Controls.Add(this.enableTeamSkeletonsCheckBox);
            this.ESPTab.Controls.Add(this.rainbowEnemyBoxESPCheckBox);
            this.ESPTab.Controls.Add(this.rainbowTeamBoxESPCheckBox);
            this.ESPTab.Controls.Add(this.enableEnemyBoxESPCheckBox);
            this.ESPTab.Controls.Add(this.enableTeamBoxESPCheckBox);
            this.ESPTab.Location = new System.Drawing.Point(4, 22);
            this.ESPTab.Name = "ESPTab";
            this.ESPTab.Padding = new System.Windows.Forms.Padding(3);
            this.ESPTab.Size = new System.Drawing.Size(394, 179);
            this.ESPTab.TabIndex = 3;
            this.ESPTab.Text = "ESP";
            this.ESPTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Enemy Skeleton Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Team Skeleton Colour";
            // 
            // customSkeletonESPEnemyColourButton
            // 
            this.customSkeletonESPEnemyColourButton.Location = new System.Drawing.Point(317, 138);
            this.customSkeletonESPEnemyColourButton.Name = "customSkeletonESPEnemyColourButton";
            this.customSkeletonESPEnemyColourButton.Size = new System.Drawing.Size(52, 33);
            this.customSkeletonESPEnemyColourButton.TabIndex = 85;
            this.customSkeletonESPEnemyColourButton.UseVisualStyleBackColor = true;
            this.customSkeletonESPEnemyColourButton.Click += new System.EventHandler(this.customSkeletonESPEnemyColourButton_Click);
            // 
            // customSkeletonESPTeamColourButton
            // 
            this.customSkeletonESPTeamColourButton.Location = new System.Drawing.Point(128, 138);
            this.customSkeletonESPTeamColourButton.Name = "customSkeletonESPTeamColourButton";
            this.customSkeletonESPTeamColourButton.Size = new System.Drawing.Size(52, 33);
            this.customSkeletonESPTeamColourButton.TabIndex = 86;
            this.customSkeletonESPTeamColourButton.UseVisualStyleBackColor = true;
            this.customSkeletonESPTeamColourButton.Click += new System.EventHandler(this.customSkeletonESPTeamColourButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Enemy Box Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Team Box Colour";
            // 
            // customBoxESPEnemyColourButton
            // 
            this.customBoxESPEnemyColourButton.Location = new System.Drawing.Point(317, 99);
            this.customBoxESPEnemyColourButton.Name = "customBoxESPEnemyColourButton";
            this.customBoxESPEnemyColourButton.Size = new System.Drawing.Size(52, 33);
            this.customBoxESPEnemyColourButton.TabIndex = 81;
            this.customBoxESPEnemyColourButton.UseVisualStyleBackColor = true;
            this.customBoxESPEnemyColourButton.Click += new System.EventHandler(this.customBoxESPEnemyColourButton_Click);
            // 
            // customBoxESPTeamColourButton
            // 
            this.customBoxESPTeamColourButton.Location = new System.Drawing.Point(128, 99);
            this.customBoxESPTeamColourButton.Name = "customBoxESPTeamColourButton";
            this.customBoxESPTeamColourButton.Size = new System.Drawing.Size(52, 33);
            this.customBoxESPTeamColourButton.TabIndex = 82;
            this.customBoxESPTeamColourButton.UseVisualStyleBackColor = true;
            this.customBoxESPTeamColourButton.Click += new System.EventHandler(this.customBoxESPTeamColourButton_Click);
            // 
            // enableEnemySkeletonsCheckbox
            // 
            this.enableEnemySkeletonsCheckbox.AutoSize = true;
            this.enableEnemySkeletonsCheckbox.Checked = true;
            this.enableEnemySkeletonsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableEnemySkeletonsCheckbox.Location = new System.Drawing.Point(208, 29);
            this.enableEnemySkeletonsCheckbox.Name = "enableEnemySkeletonsCheckbox";
            this.enableEnemySkeletonsCheckbox.Size = new System.Drawing.Size(144, 17);
            this.enableEnemySkeletonsCheckbox.TabIndex = 80;
            this.enableEnemySkeletonsCheckbox.Text = "Enable Enemy Skeletons";
            this.enableEnemySkeletonsCheckbox.UseVisualStyleBackColor = true;
            this.enableEnemySkeletonsCheckbox.CheckedChanged += new System.EventHandler(this.enableEnemySkeletonsCheckbox_CheckedChanged);
            // 
            // enableTeamSkeletonsCheckBox
            // 
            this.enableTeamSkeletonsCheckBox.AutoSize = true;
            this.enableTeamSkeletonsCheckBox.Location = new System.Drawing.Point(6, 29);
            this.enableTeamSkeletonsCheckBox.Name = "enableTeamSkeletonsCheckBox";
            this.enableTeamSkeletonsCheckBox.Size = new System.Drawing.Size(139, 17);
            this.enableTeamSkeletonsCheckBox.TabIndex = 79;
            this.enableTeamSkeletonsCheckBox.Text = "Enable Team Skeletons";
            this.enableTeamSkeletonsCheckBox.UseVisualStyleBackColor = true;
            this.enableTeamSkeletonsCheckBox.CheckedChanged += new System.EventHandler(this.enableTeamSkeletonsCheckBox_CheckedChanged);
            // 
            // rainbowEnemyBoxESPCheckBox
            // 
            this.rainbowEnemyBoxESPCheckBox.AutoSize = true;
            this.rainbowEnemyBoxESPCheckBox.Location = new System.Drawing.Point(208, 52);
            this.rainbowEnemyBoxESPCheckBox.Name = "rainbowEnemyBoxESPCheckBox";
            this.rainbowEnemyBoxESPCheckBox.Size = new System.Drawing.Size(148, 17);
            this.rainbowEnemyBoxESPCheckBox.TabIndex = 62;
            this.rainbowEnemyBoxESPCheckBox.Text = "Rainbow Enemy Box ESP";
            this.rainbowEnemyBoxESPCheckBox.UseVisualStyleBackColor = true;
            this.rainbowEnemyBoxESPCheckBox.CheckedChanged += new System.EventHandler(this.rainbowEnemyESPCheckBox_CheckedChanged);
            // 
            // rainbowTeamBoxESPCheckBox
            // 
            this.rainbowTeamBoxESPCheckBox.AutoSize = true;
            this.rainbowTeamBoxESPCheckBox.Location = new System.Drawing.Point(6, 52);
            this.rainbowTeamBoxESPCheckBox.Name = "rainbowTeamBoxESPCheckBox";
            this.rainbowTeamBoxESPCheckBox.Size = new System.Drawing.Size(143, 17);
            this.rainbowTeamBoxESPCheckBox.TabIndex = 61;
            this.rainbowTeamBoxESPCheckBox.Text = "Rainbow Team Box ESP";
            this.rainbowTeamBoxESPCheckBox.UseVisualStyleBackColor = true;
            this.rainbowTeamBoxESPCheckBox.CheckedChanged += new System.EventHandler(this.rainbowTeamESPCheckBox_CheckedChanged);
            // 
            // enableEnemyBoxESPCheckBox
            // 
            this.enableEnemyBoxESPCheckBox.AutoSize = true;
            this.enableEnemyBoxESPCheckBox.Checked = true;
            this.enableEnemyBoxESPCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableEnemyBoxESPCheckBox.Location = new System.Drawing.Point(208, 6);
            this.enableEnemyBoxESPCheckBox.Name = "enableEnemyBoxESPCheckBox";
            this.enableEnemyBoxESPCheckBox.Size = new System.Drawing.Size(139, 17);
            this.enableEnemyBoxESPCheckBox.TabIndex = 60;
            this.enableEnemyBoxESPCheckBox.Text = "Enable Enemy Box ESP";
            this.enableEnemyBoxESPCheckBox.UseVisualStyleBackColor = true;
            this.enableEnemyBoxESPCheckBox.CheckedChanged += new System.EventHandler(this.enableEnemyBoxESPCheckBox_CheckedChanged);
            // 
            // enableTeamBoxESPCheckBox
            // 
            this.enableTeamBoxESPCheckBox.AutoSize = true;
            this.enableTeamBoxESPCheckBox.Location = new System.Drawing.Point(6, 6);
            this.enableTeamBoxESPCheckBox.Name = "enableTeamBoxESPCheckBox";
            this.enableTeamBoxESPCheckBox.Size = new System.Drawing.Size(134, 17);
            this.enableTeamBoxESPCheckBox.TabIndex = 59;
            this.enableTeamBoxESPCheckBox.Text = "Enable Team Box ESP";
            this.enableTeamBoxESPCheckBox.UseVisualStyleBackColor = true;
            this.enableTeamBoxESPCheckBox.CheckedChanged += new System.EventHandler(this.enableTeamBoxESPCheckBox_CheckedChanged);
            // 
            // glowTab
            // 
            this.glowTab.Controls.Add(this.label4);
            this.glowTab.Controls.Add(this.label3);
            this.glowTab.Controls.Add(this.enemyColourPickButton);
            this.glowTab.Controls.Add(this.enemyColourBasedOnHPCheckBox);
            this.glowTab.Controls.Add(this.teamColourBasedOnHPCheckBox);
            this.glowTab.Controls.Add(this.rainbowEnemyCheckBox);
            this.glowTab.Controls.Add(this.rainbowTeamCheckbox);
            this.glowTab.Controls.Add(this.glowEnabledEnemyCheckBox);
            this.glowTab.Controls.Add(this.glowEnabledTeamCheckBox);
            this.glowTab.Controls.Add(this.teamColourPickButton);
            this.glowTab.Location = new System.Drawing.Point(4, 22);
            this.glowTab.Name = "glowTab";
            this.glowTab.Padding = new System.Windows.Forms.Padding(3);
            this.glowTab.Size = new System.Drawing.Size(394, 179);
            this.glowTab.TabIndex = 0;
            this.glowTab.Text = "Glow";
            this.glowTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Enemy Glow Colour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Team Glow Colour";
            // 
            // enemyColourPickButton
            // 
            this.enemyColourPickButton.Location = new System.Drawing.Point(310, 75);
            this.enemyColourPickButton.Name = "enemyColourPickButton";
            this.enemyColourPickButton.Size = new System.Drawing.Size(52, 33);
            this.enemyColourPickButton.TabIndex = 57;
            this.enemyColourPickButton.UseVisualStyleBackColor = true;
            this.enemyColourPickButton.Click += new System.EventHandler(this.enemyColorPickButton_Click);
            // 
            // enemyColourBasedOnHPCheckBox
            // 
            this.enemyColourBasedOnHPCheckBox.AutoSize = true;
            this.enemyColourBasedOnHPCheckBox.Location = new System.Drawing.Point(208, 52);
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
            this.teamColourBasedOnHPCheckBox.Location = new System.Drawing.Point(6, 52);
            this.teamColourBasedOnHPCheckBox.Name = "teamColourBasedOnHPCheckBox";
            this.teamColourBasedOnHPCheckBox.Size = new System.Drawing.Size(152, 17);
            this.teamColourBasedOnHPCheckBox.TabIndex = 55;
            this.teamColourBasedOnHPCheckBox.Text = "Team Colour Based on HP";
            this.teamColourBasedOnHPCheckBox.UseVisualStyleBackColor = true;
            this.teamColourBasedOnHPCheckBox.CheckedChanged += new System.EventHandler(this.teamColourBasedOnHPCheckBox_CheckedChanged);
            // 
            // rainbowEnemyCheckBox
            // 
            this.rainbowEnemyCheckBox.AutoSize = true;
            this.rainbowEnemyCheckBox.Location = new System.Drawing.Point(208, 29);
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
            this.rainbowTeamCheckbox.Location = new System.Drawing.Point(6, 29);
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
            this.glowEnabledTeamCheckBox.Location = new System.Drawing.Point(6, 6);
            this.glowEnabledTeamCheckBox.Name = "glowEnabledTeamCheckBox";
            this.glowEnabledTeamCheckBox.Size = new System.Drawing.Size(116, 17);
            this.glowEnabledTeamCheckBox.TabIndex = 39;
            this.glowEnabledTeamCheckBox.Text = "Enable Team Glow";
            this.glowEnabledTeamCheckBox.UseVisualStyleBackColor = true;
            this.glowEnabledTeamCheckBox.CheckedChanged += new System.EventHandler(this.glowEnabledTeamCheckBox_CheckedChanged);
            // 
            // teamColourPickButton
            // 
            this.teamColourPickButton.Location = new System.Drawing.Point(106, 75);
            this.teamColourPickButton.Name = "teamColourPickButton";
            this.teamColourPickButton.Size = new System.Drawing.Size(52, 33);
            this.teamColourPickButton.TabIndex = 58;
            this.teamColourPickButton.UseVisualStyleBackColor = true;
            this.teamColourPickButton.Click += new System.EventHandler(this.teamColorPickButton_Click);
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
            this.radarTab.Text = "Radar";
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
            // rainbowEnemySkeletonESPCheckBox
            // 
            this.rainbowEnemySkeletonESPCheckBox.AutoSize = true;
            this.rainbowEnemySkeletonESPCheckBox.Location = new System.Drawing.Point(208, 75);
            this.rainbowEnemySkeletonESPCheckBox.Name = "rainbowEnemySkeletonESPCheckBox";
            this.rainbowEnemySkeletonESPCheckBox.Size = new System.Drawing.Size(172, 17);
            this.rainbowEnemySkeletonESPCheckBox.TabIndex = 90;
            this.rainbowEnemySkeletonESPCheckBox.Text = "Rainbow Enemy Skeleton ESP";
            this.rainbowEnemySkeletonESPCheckBox.UseVisualStyleBackColor = true;
            this.rainbowEnemySkeletonESPCheckBox.CheckedChanged += new System.EventHandler(this.rainbowEnemySkeletonESPCheckBox_CheckedChanged);
            // 
            // rainbowTeamSkeletonESPCheckBox
            // 
            this.rainbowTeamSkeletonESPCheckBox.AutoSize = true;
            this.rainbowTeamSkeletonESPCheckBox.Location = new System.Drawing.Point(6, 75);
            this.rainbowTeamSkeletonESPCheckBox.Name = "rainbowTeamSkeletonESPCheckBox";
            this.rainbowTeamSkeletonESPCheckBox.Size = new System.Drawing.Size(167, 17);
            this.rainbowTeamSkeletonESPCheckBox.TabIndex = 89;
            this.rainbowTeamSkeletonESPCheckBox.Text = "Rainbow Team Skeleton ESP";
            this.rainbowTeamSkeletonESPCheckBox.UseVisualStyleBackColor = true;
            this.rainbowTeamSkeletonESPCheckBox.CheckedChanged += new System.EventHandler(this.rainbowTeamSkeletonESPCheckBox_CheckedChanged);
            // 
            // miscTab
            // 
            this.miscTab.Controls.Add(this.checkBox4);
            this.miscTab.Controls.Add(this.checkBox3);
            this.miscTab.Controls.Add(this.checkBox2);
            this.miscTab.Controls.Add(this.checkBox1);
            this.miscTab.Location = new System.Drawing.Point(4, 22);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(394, 179);
            this.miscTab.TabIndex = 4;
            this.miscTab.Text = "Misc";
            this.miscTab.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "No Flash";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "No Smoke";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Triggerbot";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 75);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Bunny Hop";
            this.checkBox4.UseVisualStyleBackColor = true;
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
            this.ESPTab.ResumeLayout(false);
            this.ESPTab.PerformLayout();
            this.glowTab.ResumeLayout(false);
            this.glowTab.PerformLayout();
            this.radarTab.ResumeLayout(false);
            this.radarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarOpacityNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdrTopLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarBlipSizeNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radarSizeNumberBox)).EndInit();
            this.configTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.miscTab.ResumeLayout(false);
            this.miscTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage glowTab;
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
        private System.Windows.Forms.Button enemyColourPickButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.Button loadConfigButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.CheckBox enemyColourBasedOnHPCheckBox;
        public System.Windows.Forms.CheckBox teamColourBasedOnHPCheckBox;
        public System.Windows.Forms.CheckBox rainbowEnemyCheckBox;
        public System.Windows.Forms.CheckBox rainbowTeamCheckbox;
        public System.Windows.Forms.CheckBox glowEnabledEnemyCheckBox;
        public System.Windows.Forms.CheckBox glowEnabledTeamCheckBox;
        public System.Windows.Forms.Button teamColourPickButton;
        private System.Windows.Forms.TabPage ESPTab;
        public System.Windows.Forms.CheckBox rainbowEnemyBoxESPCheckBox;
        public System.Windows.Forms.CheckBox rainbowTeamBoxESPCheckBox;
        public System.Windows.Forms.CheckBox enableEnemyBoxESPCheckBox;
        public System.Windows.Forms.CheckBox enableTeamBoxESPCheckBox;
        public System.Windows.Forms.CheckBox enableEnemySkeletonsCheckbox;
        public System.Windows.Forms.CheckBox enableTeamSkeletonsCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button customBoxESPEnemyColourButton;
        public System.Windows.Forms.Button customBoxESPTeamColourButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button customSkeletonESPEnemyColourButton;
        public System.Windows.Forms.Button customSkeletonESPTeamColourButton;
        public System.Windows.Forms.CheckBox rainbowEnemySkeletonESPCheckBox;
        public System.Windows.Forms.CheckBox rainbowTeamSkeletonESPCheckBox;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}