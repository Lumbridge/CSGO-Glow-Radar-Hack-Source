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
            this.miscTab = new System.Windows.Forms.TabPage();
            this.bunnyHopCheckbox = new System.Windows.Forms.CheckBox();
            this.triggerBotCheckBox = new System.Windows.Forms.CheckBox();
            this.noSmokeCheckBox = new System.Windows.Forms.CheckBox();
            this.noFlashCheckBox = new System.Windows.Forms.CheckBox();
            this.configTab = new System.Windows.Forms.TabPage();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.loadConfigButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.glowTab.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.configTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.glowTab);
            this.tabControl1.Controls.Add(this.miscTab);
            this.tabControl1.Controls.Add(this.configTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 205);
            this.tabControl1.TabIndex = 39;
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
            // miscTab
            // 
            this.miscTab.Controls.Add(this.bunnyHopCheckbox);
            this.miscTab.Controls.Add(this.triggerBotCheckBox);
            this.miscTab.Controls.Add(this.noSmokeCheckBox);
            this.miscTab.Controls.Add(this.noFlashCheckBox);
            this.miscTab.Location = new System.Drawing.Point(4, 22);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(394, 179);
            this.miscTab.TabIndex = 4;
            this.miscTab.Text = "Misc";
            this.miscTab.UseVisualStyleBackColor = true;
            // 
            // bunnyHopCheckbox
            // 
            this.bunnyHopCheckbox.AutoSize = true;
            this.bunnyHopCheckbox.Location = new System.Drawing.Point(6, 75);
            this.bunnyHopCheckbox.Name = "bunnyHopCheckbox";
            this.bunnyHopCheckbox.Size = new System.Drawing.Size(79, 17);
            this.bunnyHopCheckbox.TabIndex = 3;
            this.bunnyHopCheckbox.Text = "Bunny Hop";
            this.bunnyHopCheckbox.UseVisualStyleBackColor = true;
            this.bunnyHopCheckbox.Visible = false;
            this.bunnyHopCheckbox.CheckedChanged += new System.EventHandler(this.bunnyHopCheckbox_CheckedChanged);
            // 
            // triggerBotCheckBox
            // 
            this.triggerBotCheckBox.AutoSize = true;
            this.triggerBotCheckBox.Location = new System.Drawing.Point(6, 29);
            this.triggerBotCheckBox.Name = "triggerBotCheckBox";
            this.triggerBotCheckBox.Size = new System.Drawing.Size(74, 17);
            this.triggerBotCheckBox.TabIndex = 2;
            this.triggerBotCheckBox.Text = "Triggerbot";
            this.triggerBotCheckBox.UseVisualStyleBackColor = true;
            this.triggerBotCheckBox.CheckedChanged += new System.EventHandler(this.triggerBotCheckBox_CheckedChanged);
            // 
            // noSmokeCheckBox
            // 
            this.noSmokeCheckBox.AutoSize = true;
            this.noSmokeCheckBox.Location = new System.Drawing.Point(6, 52);
            this.noSmokeCheckBox.Name = "noSmokeCheckBox";
            this.noSmokeCheckBox.Size = new System.Drawing.Size(76, 17);
            this.noSmokeCheckBox.TabIndex = 1;
            this.noSmokeCheckBox.Text = "No Smoke";
            this.noSmokeCheckBox.UseVisualStyleBackColor = true;
            this.noSmokeCheckBox.Visible = false;
            this.noSmokeCheckBox.CheckedChanged += new System.EventHandler(this.noSmokeCheckBox_CheckedChanged);
            // 
            // noFlashCheckBox
            // 
            this.noFlashCheckBox.AutoSize = true;
            this.noFlashCheckBox.Location = new System.Drawing.Point(6, 6);
            this.noFlashCheckBox.Name = "noFlashCheckBox";
            this.noFlashCheckBox.Size = new System.Drawing.Size(68, 17);
            this.noFlashCheckBox.TabIndex = 0;
            this.noFlashCheckBox.Text = "No Flash";
            this.noFlashCheckBox.UseVisualStyleBackColor = true;
            this.noFlashCheckBox.CheckedChanged += new System.EventHandler(this.noFlashCheckBox_CheckedChanged);
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
            this.miscTab.ResumeLayout(false);
            this.miscTab.PerformLayout();
            this.configTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage glowTab;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.CheckBox bunnyHopCheckbox;
        private System.Windows.Forms.CheckBox triggerBotCheckBox;
        private System.Windows.Forms.CheckBox noSmokeCheckBox;
        private System.Windows.Forms.CheckBox noFlashCheckBox;
    }
}