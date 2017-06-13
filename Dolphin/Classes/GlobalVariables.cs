using SharpDX;
using SharpDX.Direct2D1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

using FontFactory = SharpDX.DirectWrite.Factory;

namespace Dolphin.Classes
{
    public class GlobalVariables
    {
        public static bool IsRunning = false;
        
        public static List<Entity> Entities = new List<Entity>();

        #region radar stuff
        public static bool RadarEnabled;
        public static int RadarSize, RadarBlipSize;
        public static float RadarOpacity;
        public static Vector2 RadarTopLeftPosition;
        #endregion

        #region glow variables
        public static bool GlowEnabledFriendly, GlowEnabledOpposition;
        public static bool RainbowEnabledFriendly, RainbowEnabledOpposition;
        public static bool HPToColourEnabledFriendly, HPToColourEnabledOpposition;
        public static System.Drawing.Color GlowEnemyARGB, GlowTeamARGB;
        public static int GlowAlpha = 255;
        public static int GlowOppositionR = 255;
        public static int GlowOppositionG = 0;
        public static int GlowOppositionB = 0;
        public static int GlowFriendlyR = 0;
        public static int GlowFriendlyG = 255;
        public static int GlowFriendlyB = 0;
        #endregion

        #region ESP variables
        public static bool BoxESPEnabledFriendly, BoxESPEnabledOpposition;
        public static bool SkeletonsEnabledFriendly, SkeletonsEnabledOpposition;
        public static bool RainbowESPEnabledFriendly, RainbowESPEnabledOpposition;
        public static System.Drawing.Color ESPEnemyARGB, ESPTeamARGB;
        public static int ESPAlpha = 255;
        public static int ESPOppositionR = 255;
        public static int ESPOppositionG = 0;
        public static int ESPOppositionB = 0;
        public static int ESPFriendlyR = 0;
        public static int ESPFriendlyG = 255;
        public static int ESPFriendlyB = 0;
        #endregion

        #region Overlay Form Stuff
        public static Bitmap MapImage; // radar image
        public static string CurrentMapName = string.Empty, LastMapName = string.Empty;

        public static IntPtr GameHandle;
        public static Process GameProcess;

        public static Int32 dwClient;
        public static Int32 dwEngine;

        public static Matrix4x4 ViewMatrix;
        public static Size2 WindowSize;

        public static WindowRenderTarget Device;
        public static HwndRenderTargetProperties DeviceRenderProperties;

        public static Factory Factory;
        public static FontFactory FontFactory;

        public static ProcessMemory Mem = new ProcessMemory("csgo");

        public static Rectangle WindowBounds = new Rectangle();

        public static Thread LoopThread = null;

        //Styles
        public static UInt32 SWP_NOSIZE = 0x0001;
        public static UInt32 SWP_NOMOVE = 0x0002;
        public static UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        public static IntPtr HWND_TOPMOST = new IntPtr(-1);


        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            System.Text.StringBuilder Buff = new System.Text.StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        public static bool GetProcessAndHandles()
        {
            IEnumerator enumerator;
            try
            {
                GameProcess = Process.GetProcessesByName("csgo")[0];
                GameHandle = OpenProcess(PROCESS_ALL_ACCESS, false, GameProcess.Id);
            }
            catch (Exception)
            {
                var result = System.Windows.Forms.MessageBox.Show("Game not found, launch it and click retry.","Game not found",System.Windows.Forms.MessageBoxButtons.RetryCancel);

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Environment.Exit(1);
                    System.Windows.Forms.Application.Exit();
                }

                return false;
            }
            enumerator = GameProcess.Modules.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ProcessModule current = (ProcessModule)enumerator.Current;
                if (current.ModuleName == "engine.dll")
                {
                    dwEngine = (int)current.BaseAddress;
                }
                if (current.ModuleName == "client.dll")
                {
                    dwClient = (int)current.BaseAddress;
                }
            }
            GetWindowRect(GameHandle, out WindowBounds);

            return true;
        }

        #endregion

        #region Main Form Stuff
        public static int MOUSEEVENTF_LEFTDOWN = 0x02;
        public static int MOUSEEVENTF_LEFTUP = 0x04;
        public static int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public static int MOUSEEVENTF_RIGHTUP = 0x10;

        // Hotkey controls
        public static int MOD_CONTROL = 0x0002;
        public static int MOD_SHIFT = 0x0004;
        public static int WM_HOTKEY = 0x0312;

        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static string GetCurrentConfigString()
        {
            return (
                "====GLOW OPTIONS====" + Environment.NewLine +
                "GLOW_ENABLED_TEAM=" + GlowEnabledFriendly + Environment.NewLine +
                "GLOW_TEAM_R=" + GlowFriendlyR + Environment.NewLine +
                "GLOW_TEAM_G=" + GlowFriendlyG + Environment.NewLine +
                "GLOW_TEAM_B=" + GlowFriendlyB + Environment.NewLine +
                "GLOW_TEAM_ARGB=" + GlowTeamARGB.ToArgb() + Environment.NewLine +
                "GLOW_RAINBOW_ENABLED_TEAM=" + RainbowEnabledFriendly + Environment.NewLine +
                "GLOW_COLOUR_BASED_ON_HP_TEAM=" + HPToColourEnabledFriendly + Environment.NewLine +
                "GLOW_ENABLED_ENEMY=" + GlowEnabledOpposition + Environment.NewLine +
                "GLOW_ENEMY_R=" + GlowOppositionR + Environment.NewLine +
                "GLOW_ENEMY_G=" + GlowOppositionG + Environment.NewLine +
                "GLOW_ENEMY_B=" + GlowOppositionB + Environment.NewLine +
                "GLOW_ENEMY_ARGB=" + GlowEnemyARGB.ToArgb() + Environment.NewLine +
                "GLOW_RAINBOW_ENABLED_ENEMY=" + RainbowEnabledOpposition + Environment.NewLine +
                "GLOW_COLOR_BASED_ON_HP_ENEMY=" + HPToColourEnabledOpposition + Environment.NewLine +
                "====ESP OPTIONS====" + Environment.NewLine +
                "BOX_ESP_ENABLED_TEAM=" + BoxESPEnabledFriendly + Environment.NewLine +
                "SKELETONS_ENABLED_TEAM=" + SkeletonsEnabledFriendly + Environment.NewLine +
                "RAINBOW_ESP_ENABLED_TEAM=" + RainbowEnabledFriendly + Environment.NewLine +
                "ESP_TEAM_R=" + ESPFriendlyR + Environment.NewLine +
                "ESP_TEAM_G=" + ESPFriendlyG + Environment.NewLine +
                "ESP_TEAM_B=" + ESPFriendlyB + Environment.NewLine +
                "ESP_TEAM_ARGB=" + ESPTeamARGB.ToArgb() + Environment.NewLine +
                "BOX_ESP_ENABLED_ENEMY=" + BoxESPEnabledOpposition + Environment.NewLine +
                "SKELETONS_ENABLED_ENEMY=" + SkeletonsEnabledOpposition + Environment.NewLine +
                "RAINBOW_ESP_ENABLED_ENEMY=" + RainbowEnabledOpposition + Environment.NewLine +
                "ESP_ENEMY_R=" + ESPOppositionR + Environment.NewLine +
                "ESP_ENEMY_G=" + ESPOppositionG + Environment.NewLine +
                "ESP_ENEMY_B=" + ESPOppositionB + Environment.NewLine +
                "ESP_ENEMY_ARGB=" + ESPEnemyARGB.ToArgb() + Environment.NewLine +
                "====RADAR OPTIONS====" + Environment.NewLine +
                "RADAR_ENABLED=" + RadarEnabled + Environment.NewLine +
                "RADAR_SIZE=" + RadarSize + Environment.NewLine +
                "RADAR_BLIP_SIZE=" + RadarBlipSize + Environment.NewLine +
                "RADAR_TOP_LEFT_X=" + RadarTopLeftPosition.X + Environment.NewLine +
                "RADAR_TOP_LEFT_Y=" + RadarTopLeftPosition.Y + Environment.NewLine +
                "RADAR_OPACITY=" + RadarOpacity
                );
        }

        public static void LoadConfigFile(string filePath)
        {
            List<string> results = new List<string>();

            File.OpenRead(filePath);
            foreach (var line in File.ReadAllLines(filePath))
            {
                if(!line.Contains("===="))
                {
                    var index = line.IndexOf('=');
                    string temp = line.Substring(index + 1);
                    results.Add(temp);
                    Console.WriteLine(temp);
                }
            }

            // apply parsed config options

            // team glow options
            GlowEnabledFriendly = bool.Parse(results[0]);
            GlowFriendlyR = int.Parse(results[1]);
            GlowFriendlyG = int.Parse(results[2]);
            GlowFriendlyB = int.Parse(results[3]);
            GlowTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[4]));
            RainbowEnabledFriendly = bool.Parse(results[5]);
            HPToColourEnabledFriendly = bool.Parse(results[6]);

            // enemy glow options
            GlowEnabledOpposition = bool.Parse(results[7]);
            GlowOppositionR = int.Parse(results[8]);
            GlowOppositionG = int.Parse(results[9]);
            GlowOppositionB = int.Parse(results[10]);
            GlowEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[11]));
            RainbowEnabledOpposition = bool.Parse(results[12]);
            HPToColourEnabledOpposition = bool.Parse(results[13]);

            // team esp options
            BoxESPEnabledFriendly = bool.Parse(results[14]);
            SkeletonsEnabledFriendly = bool.Parse(results[15]);
            RainbowESPEnabledFriendly = bool.Parse(results[16]);
            ESPFriendlyR = int.Parse(results[17]);
            ESPFriendlyG = int.Parse(results[18]);
            ESPFriendlyB = int.Parse(results[19]);
            ESPTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[20]));

            // enemy esp options
            BoxESPEnabledOpposition = bool.Parse(results[21]);
            SkeletonsEnabledOpposition = bool.Parse(results[22]);
            RainbowESPEnabledOpposition = bool.Parse(results[23]);
            ESPOppositionR = int.Parse(results[24]);
            ESPOppositionG = int.Parse(results[25]);
            ESPOppositionB = int.Parse(results[26]);
            ESPEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[27]));

            // radar options
            RadarEnabled = bool.Parse(results[14]);
            RadarSize = int.Parse(results[15]);
            RadarBlipSize = int.Parse(results[16]);
            RadarTopLeftPosition.X = float.Parse(results[17]);
            RadarTopLeftPosition.Y = float.Parse(results[18]);
            RadarOpacity = float.Parse(results[19]);
        }

        #endregion

        #region Invoke DLLs
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr OpenProcess(uint dwDesiredAcess, bool bInheritHandle, int dwProcessId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);
        public static uint PROCESS_ALL_ACCESS = 0x1f0fff;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("dwmapi.dll")]
        public static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref int[] pMargins);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
        #endregion
    }
}