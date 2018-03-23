using System;
using System.Windows.Forms;
using System.IO;

using static Dolphin.Classes.Glow;
using static Dolphin.Classes.Triggerbot;
using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.NoFlash;
using System.Threading;
using Dolphin.Classes;

namespace Dolphin
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
            IsRunning = GetProcessAndHandles();

            while (!IsRunning)
            {
                IsRunning = GetProcessAndHandles();
                Thread.Sleep(1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // default glow colours
            GlowTeamARGB = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            GlowEnemyARGB = System.Drawing.Color.FromArgb(255, 255, 0, 0);

            // default glow settings
            GlowEnabledFriendly = false;
            GlowEnabledOpposition = true;

            // default glow rainbow settings
            RainbowGlowEnabledFriendly = false;
            RainbowGlowEnabledOpposition = false;
            
            // default misc tab settings
            IsEnabled_Noflash = false;
            IsEnabled_NoSmoke = false;
            IsEnabled_TriggerBot = false;
            IsEnabled_BunnyHop = false;

            // set default glow tab UI button colours
            teamColourPickButton.BackColor = GlowTeamARGB;
            enemyColourPickButton.BackColor = GlowEnemyARGB;

            LoopThread = new Thread(new ParameterizedThreadStart(SDXThread));

            LoopThread.Priority = ThreadPriority.Highest;
            LoopThread.IsBackground = true;
            LoopThread.Start();
        }

        public void SDXThread(object sender)
        {
            float progress = 0.0f;

            // main loop, checks for game process & performs various hack updates
            //
            while (IsRunning)
            {
                GameHandle = GameProcess.MainWindowHandle;

                if (GameProcess.HasExited)
                    IsRunning = false;
                
                if (GetActiveWindowTitle() == "Counter-Strike: Global Offensive" || GetActiveWindowTitle() == "Dolphin")
                {
                    Mem.StartProcess();

                    // Create Local Entity
                    LocalEntity LE = new LocalEntity();

                    // perform this loop for every entity in the game
                    for (int i = 0; i < 32; i++)
                    {
                        // increment rainbow cycle colour
                        progress += 0.00001f;

                        // create new entity instance
                        Entity Entity = new Entity(i);

                        // Draw Glow if enabled on GUI
                        if (GlowEnabledOpposition || GlowEnabledFriendly)
                        {
                            DoGlow(Mem, Entity, LE, progress);
                        }

                        // Call trigger if enabled on GUI
                        if (IsEnabled_TriggerBot)
                            TriggerbotLoop(LE);

                        if (IsEnabled_Noflash)
                            NoFlashLoop(LE, Mem);
                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                throw ex;
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
        
        private void rainbowEnemyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowGlowEnabledOpposition = rainbowEnemyCheckBox.Checked;
        }

        private void rainbowTeamCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RainbowGlowEnabledFriendly = rainbowTeamCheckbox.Checked;
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
            rainbowTeamCheckbox.Checked = RainbowGlowEnabledFriendly;
            teamColourBasedOnHPCheckBox.Checked = HPToColourEnabledFriendly;
            teamColourPickButton.BackColor = GlowTeamARGB;

            glowEnabledEnemyCheckBox.Checked = GlowEnabledOpposition;
            rainbowEnemyCheckBox.Checked = RainbowGlowEnabledOpposition;
            enemyColourBasedOnHPCheckBox.Checked = HPToColourEnabledOpposition;
            enemyColourPickButton.BackColor = GlowEnemyARGB;
        }
        #endregion

        #region Misc Tab
        private void noFlashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabled_Noflash = noFlashCheckBox.Checked;
        }

        private void noSmokeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabled_NoSmoke = noSmokeCheckBox.Checked;
        }

        private void triggerBotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabled_TriggerBot = triggerBotCheckBox.Checked;
        }

        private void bunnyHopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            IsEnabled_BunnyHop = bunnyHopCheckbox.Checked;
        }
        #endregion
    }
}