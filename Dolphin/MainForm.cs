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
            GlowEnabledFriendly = true;
            GlowEnabledOpposition = true;
            RainbowEnabledFriendly = false;
            RainbowEnabledOpposition = false;

            GlowEnemyARGB = System.Drawing.Color.FromArgb(255, 255, 0, 0);
            GlowTeamARGB = System.Drawing.Color.FromArgb(255, 0, 255, 0);

            RadarEnabled = true;
            RadarSize = 300;
            RadarBlipSize = 5;
            RadarOpacity = 1.0f;

            RadarTopLeftPosition = new SharpDX.Vector2(286, 40);
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

        private void teamRNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowFriendlyR = (int)teamRNumberBox.Value;
        }

        private void teamGNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowFriendlyG = (int)teamGNumberBox.Value;
        }

        private void teamBNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowFriendlyB = (int)teamBNumberBox.Value;
        }

        private void enemyRNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowOppositionR = (int)enemyRNumberBox.Value;
        }

        private void enemyGNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowOppositionG = (int)enemyGNumberBox.Value;
        }

        private void enemyBNumberBox_ValueChanged(object sender, EventArgs e)
        {
            GlowOppositionB = (int)enemyBNumberBox.Value;
        }

        private void rainbowEnemyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowEnabledOpposition = rainbowEnemyCheckBox.Checked;

            if(!rainbowEnemyCheckBox.Checked)
            {
                GlowOppositionR = (int)enemyRNumberBox.Value;
                GlowOppositionG = (int)enemyGNumberBox.Value;
                GlowOppositionB = (int)enemyBNumberBox.Value;
            }
        }

        private void rainbowTeamCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowEnabledFriendly = rainbowTeamCheckbox.Checked;

            if (!rainbowTeamCheckbox.Checked)
            {
                GlowFriendlyR = (int)teamRNumberBox.Value;
                GlowFriendlyG = (int)teamGNumberBox.Value;
                GlowFriendlyB = (int)teamBNumberBox.Value;
            }
        }

        private void enableRadarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RadarEnabled = enableRadarCheckBox.Checked;
        }

        private void teamColourBasedOnHPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HPToColourEnabledFriendly = teamColourBasedOnHPCheckBox.Checked;

            if (!teamColourBasedOnHPCheckBox.Checked)
            {
                GlowOppositionR = (int)enemyRNumberBox.Value;
                GlowOppositionG = (int)enemyGNumberBox.Value;
                GlowOppositionB = (int)enemyBNumberBox.Value;
            }
        }

        private void enemyColourBasedOnHPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HPToColourEnabledOpposition = enemyColourBasedOnHPCheckBox.Checked;

            if (!enemyColourBasedOnHPCheckBox.Checked)
            {
                GlowOppositionR = (int)enemyRNumberBox.Value;
                GlowOppositionG = (int)enemyGNumberBox.Value;
                GlowOppositionB = (int)enemyBNumberBox.Value;
            }
        }

        private void enemyColorPickButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                GlowEnemyARGB = colorDialog.Color;
            }

            enemyRNumberBox.Value = GlowEnemyARGB.R;
            enemyGNumberBox.Value = GlowEnemyARGB.G;
            enemyBNumberBox.Value = GlowEnemyARGB.B;
        }

        private void teamColorPickButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                GlowTeamARGB = colorDialog.Color;
            }

            teamRNumberBox.Value = GlowTeamARGB.R;
            teamGNumberBox.Value = GlowTeamARGB.G;
            teamBNumberBox.Value = GlowTeamARGB.B;
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".cfg";
            saveFileDialog.AddExtension = true;

            var result = saveFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, GetCurrentConfigString());
            }
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                LoadConfigFile(openFileDialog.FileName);
            }

            glowEnabledTeamCheckBox.Checked = GlowEnabledFriendly;
            teamRNumberBox.Value = GlowFriendlyR;
            teamGNumberBox.Value = GlowFriendlyG;
            teamBNumberBox.Value = GlowFriendlyB;
            rainbowTeamCheckbox.Checked = RainbowEnabledFriendly;
            teamColourBasedOnHPCheckBox.Checked = HPToColourEnabledFriendly;

            glowEnabledEnemyCheckBox.Checked = GlowEnabledOpposition;
            enemyRNumberBox.Value = GlowOppositionR;
            enemyGNumberBox.Value = GlowOppositionG;
            enemyBNumberBox.Value = GlowOppositionB;
            rainbowEnemyCheckBox.Checked = RainbowEnabledOpposition;
            enemyColourBasedOnHPCheckBox.Checked = HPToColourEnabledOpposition;

            enableRadarCheckBox.Checked = RadarEnabled;
            radarSizeNumberBox.Value = RadarSize;
            radarBlipSizeNumberBox.Value = RadarBlipSize;
            rdrTopLeftX.Value = (decimal)RadarTopLeftPosition.X;
            rdrTopLeftY.Value = (decimal)RadarTopLeftPosition.Y;
            radarOpacityNumberBox.Value = (decimal)RadarOpacity;
        }
    }
}