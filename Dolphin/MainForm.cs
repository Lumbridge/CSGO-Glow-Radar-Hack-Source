using System;
using System.Windows.Forms;
using System.IO;

using static Dolphin.Classes.GlobalVariables;

namespace Dolphin
{
    public partial class MainForm : Form
    {        
        public MainForm(OverlayForm overlayForm)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // default team ESP colours
            BoxESPTeamARGB = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            SkeletonESPTeamARGB = System.Drawing.Color.FromArgb(255, 0, 255, 0);

            // default enenmy ESP colours
            BoxESPEnemyARGB = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            SkeletonESPEnemyARGB = System.Drawing.Color.FromArgb(255, 255, 0, 0);

            // default glow colours
            GlowTeamARGB = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            GlowEnemyARGB = System.Drawing.Color.FromArgb(255, 255, 0, 0);

            // default glow settings
            GlowEnabledFriendly = false;
            GlowEnabledOpposition = false;

            // default glow rainbow settings
            RainbowEnabledFriendly = false;
            RainbowEnabledOpposition = false;

            // default ESP rainbow settings
            RainbowBoxESPEnabledFriendly = false;
            RainbowSkeletonESPEnabledFriendly = false;
            RainbowBoxESPEnabledOpposition = false;
            RainbowSkeletonESPEnabledOpposition = false;

            // default box ESP settings
            BoxESPEnabledFriendly = false;
            BoxESPEnabledOpposition = true;

            // default skeleton ESP settings
            SkeletonsEnabledFriendly = false;
            SkeletonsEnabledOpposition = true;

            // default radar settings
            RadarEnabled = true;
            RadarSize = 300;
            RadarBlipSize = 5;
            RadarOpacity = 1.0f;
            RadarTopLeftPosition = new SharpDX.Vector2(286, 40);

            // set default glow tab UI button colours
            teamColourPickButton.BackColor = GlowTeamARGB;
            enemyColourPickButton.BackColor = GlowEnemyARGB;

            // set default box ESP tab UI button colours
            customBoxESPTeamColourButton.BackColor = BoxESPTeamARGB;
            customBoxESPEnemyColourButton.BackColor = BoxESPEnemyARGB;

            // set default skeleton ESP tab UI button colours
            customSkeletonESPTeamColourButton.BackColor = SkeletonESPTeamARGB;
            customSkeletonESPEnemyColourButton.BackColor = SkeletonESPEnemyARGB;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
            }
        }

        private void glowEnabledTeamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GlowEnabledFriendly = glowEnabledTeamCheckBox.Checked;
        }

        private void glowEnabledEnemyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GlowEnabledOpposition = glowEnabledEnemyCheckBox.Checked;
        }

        private void radarSizeNumberBox_ValueChanged(object sender, EventArgs e)
        {
            RadarSize = (int)radarSizeNumberBox.Value;
        }

        private void radarBlipSizeNumberBox_ValueChanged(object sender, EventArgs e)
        {
            RadarBlipSize = (int)radarBlipSizeNumberBox.Value;
        }

        private void rdrTopLeftX_ValueChanged(object sender, EventArgs e)
        {
            RadarTopLeftPosition.X = (float)rdrTopLeftX.Value;
        }

        private void rdrTopLeftY_ValueChanged(object sender, EventArgs e)
        {
            RadarTopLeftPosition.Y = (float)rdrTopLeftY.Value;
        }

        private void radarUpButton_Click(object sender, EventArgs e)
        {
            RadarTopLeftPosition.Y -= 40;

            if (RadarTopLeftPosition.Y < 1)
                RadarTopLeftPosition.Y = 1;

            rdrTopLeftY.Value = (int)RadarTopLeftPosition.Y;
        }

        private void radarRightButton_Click(object sender, EventArgs e)
        {
            RadarTopLeftPosition.X += 40;

            if (RadarTopLeftPosition.X > WindowBounds.Width - RadarSize)
                RadarTopLeftPosition.X = WindowBounds.Width - RadarSize;

            rdrTopLeftX.Value = (int)RadarTopLeftPosition.X;
        }

        private void radarDownButton_Click(object sender, EventArgs e)
        { 
            RadarTopLeftPosition.Y += 40;

            if (RadarTopLeftPosition.Y > WindowBounds.Height - RadarSize)
                RadarTopLeftPosition.Y = WindowBounds.Height - RadarSize;

            rdrTopLeftY.Value = (int)RadarTopLeftPosition.Y;
        }

        private void radarLeftButton_Click(object sender, EventArgs e)
        {
            RadarTopLeftPosition.X -= 40;

            if (RadarTopLeftPosition.X < 1)
                RadarTopLeftPosition.X = 1;

            rdrTopLeftX.Value = (int)RadarTopLeftPosition.X;
        }

        private void radarOpacityNumberBox_ValueChanged(object sender, EventArgs e)
        {
            RadarOpacity = (float)radarOpacityNumberBox.Value;
        }

        private void rainbowEnemyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowEnabledOpposition = rainbowEnemyCheckBox.Checked;
        }

        private void rainbowTeamCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowEnabledFriendly = rainbowTeamCheckbox.Checked;
        }

        private void enableRadarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RadarEnabled = enableRadarCheckBox.Checked;
        }

        private void teamColourBasedOnHPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HPToColourEnabledFriendly = teamColourBasedOnHPCheckBox.Checked;
        }

        private void enemyColourBasedOnHPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HPToColourEnabledOpposition = enemyColourBasedOnHPCheckBox.Checked;
        }

        private void enemyColorPickButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                GlowEnemyARGB = colorDialog.Color;
                enemyColourPickButton.BackColor = GlowEnemyARGB;
            }
        }

        private void teamColorPickButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                GlowTeamARGB = colorDialog.Color;
                teamColourPickButton.BackColor = GlowTeamARGB;
            }
        }

        #region ESP Tab

        #region ESP Team
        private void enableTeamBoxESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BoxESPEnabledFriendly = enableTeamBoxESPCheckBox.Checked;
        }

        private void enableTeamSkeletonsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SkeletonsEnabledFriendly = enableEnemySkeletonsCheckbox.Checked;
        }

        private void rainbowTeamESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowBoxESPEnabledFriendly = rainbowTeamCheckbox.Checked;
        }

        private void rainbowTeamSkeletonESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowSkeletonESPEnabledFriendly = rainbowTeamSkeletonESPCheckBox.Checked;
        }

        private void customBoxESPTeamColourButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BoxESPTeamARGB = colorDialog.Color;
                customBoxESPTeamColourButton.BackColor = BoxESPTeamARGB;
            }
        }

        private void customSkeletonESPTeamColourButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SkeletonESPTeamARGB = colorDialog.Color;
                customBoxESPEnemyColourButton.BackColor = BoxESPEnemyARGB;
            }
        }
        #endregion

        #region ESP Enemy
        private void enableEnemyBoxESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BoxESPEnabledOpposition = enableEnemyBoxESPCheckBox.Checked;
        }

        private void enableEnemySkeletonsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkeletonsEnabledOpposition = enableEnemySkeletonsCheckbox.Checked;
        }

        private void rainbowEnemyESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowBoxESPEnabledOpposition = rainbowEnemyBoxESPCheckBox.Checked;
        }

        private void rainbowEnemySkeletonESPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowSkeletonESPEnabledOpposition = rainbowEnemySkeletonESPCheckBox.Checked;
        }

        private void customBoxESPEnemyColourButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BoxESPEnemyARGB = colorDialog.Color;
                customBoxESPEnemyColourButton.BackColor = BoxESPEnemyARGB;
            }
        }

        private void customSkeletonESPEnemyColourButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SkeletonESPEnemyARGB = colorDialog.Color;
                customSkeletonESPEnemyColourButton.BackColor = SkeletonESPEnemyARGB;
            }
        }
        #endregion

        #endregion

        #region Config Tab
        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".cfg";
            saveFileDialog.AddExtension = true;

            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, GetCurrentConfigString());
            }
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadConfigFile(openFileDialog.FileName);
            }

            glowEnabledTeamCheckBox.Checked = GlowEnabledFriendly;
            rainbowTeamCheckbox.Checked = RainbowEnabledFriendly;
            teamColourBasedOnHPCheckBox.Checked = HPToColourEnabledFriendly;
            teamColourPickButton.BackColor = GlowTeamARGB;

            glowEnabledEnemyCheckBox.Checked = GlowEnabledOpposition;
            rainbowEnemyCheckBox.Checked = RainbowEnabledOpposition;
            enemyColourBasedOnHPCheckBox.Checked = HPToColourEnabledOpposition;
            enemyColourPickButton.BackColor = GlowEnemyARGB;

            enableTeamBoxESPCheckBox.Checked = BoxESPEnabledFriendly;
            enableTeamSkeletonsCheckBox.Checked = SkeletonsEnabledFriendly;
            rainbowTeamBoxESPCheckBox.Checked = RainbowBoxESPEnabledFriendly;
            rainbowEnemyBoxESPCheckBox.Checked = RainbowBoxESPEnabledOpposition;
            rainbowTeamSkeletonESPCheckBox.Checked = RainbowSkeletonESPEnabledFriendly;
            rainbowEnemyBoxESPCheckBox.Checked = RainbowSkeletonESPEnabledOpposition;

            enableEnemyBoxESPCheckBox.Checked = BoxESPEnabledOpposition;
            enableEnemySkeletonsCheckbox.Checked = SkeletonsEnabledOpposition;
            rainbowEnemyBoxESPCheckBox.Checked = RainbowEnabledOpposition;

            enableRadarCheckBox.Checked = RadarEnabled;
            radarSizeNumberBox.Value = RadarSize;
            radarBlipSizeNumberBox.Value = RadarBlipSize;
            rdrTopLeftX.Value = (decimal)RadarTopLeftPosition.X;
            rdrTopLeftY.Value = (decimal)RadarTopLeftPosition.Y;
            radarOpacityNumberBox.Value = (decimal)RadarOpacity;
        }
        #endregion
    }
}