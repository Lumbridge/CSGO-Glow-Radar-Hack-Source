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
        #endregion

        #region ESP variables
        public static bool BoxESPEnabledFriendly, BoxESPEnabledOpposition;
        public static bool SkeletonsEnabledFriendly, SkeletonsEnabledOpposition;
        public static bool RainbowBoxESPEnabledFriendly, RainbowBoxESPEnabledOpposition;
        public static bool RainbowSkeletonESPEnabledFriendly, RainbowSkeletonESPEnabledOpposition;
        public static System.Drawing.Color BoxESPEnemyARGB, BoxESPTeamARGB;
        public static System.Drawing.Color SkeletonESPEnemyARGB, SkeletonESPTeamARGB;
        public static int ESPAlpha = 255;
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
                "GLOW_TEAM_ARGB=" + GlowTeamARGB.ToArgb() + Environment.NewLine +
                "GLOW_RAINBOW_ENABLED_TEAM=" + RainbowEnabledFriendly + Environment.NewLine +
                "GLOW_COLOUR_BASED_ON_HP_TEAM=" + HPToColourEnabledFriendly + Environment.NewLine +
                "GLOW_ENABLED_ENEMY=" + GlowEnabledOpposition + Environment.NewLine +
                "GLOW_ENEMY_ARGB=" + GlowEnemyARGB.ToArgb() + Environment.NewLine +
                "GLOW_RAINBOW_ENABLED_ENEMY=" + RainbowEnabledOpposition + Environment.NewLine +
                "GLOW_COLOR_BASED_ON_HP_ENEMY=" + HPToColourEnabledOpposition + Environment.NewLine +
                "====ESP OPTIONS====" + Environment.NewLine +
                "BOX_ESP_ENABLED_TEAM=" + BoxESPEnabledFriendly + Environment.NewLine +
                "SKELETONS_ENABLED_TEAM=" + SkeletonsEnabledFriendly + Environment.NewLine +
                "RAINBOW_BOX_ESP_ENABLED_TEAM=" + RainbowBoxESPEnabledFriendly + Environment.NewLine +
                "RAINBOW_SKELETON_ESP_ENABLED_TEAM=" + RainbowSkeletonESPEnabledFriendly + Environment.NewLine +
                "Box_ESP_TEAM_ARGB=" + BoxESPTeamARGB.ToArgb() + Environment.NewLine +
                "Skeleton_ESP_TEAM_ARGB=" + SkeletonESPTeamARGB.ToArgb() + Environment.NewLine +
                "BOX_ESP_ENABLED_ENEMY=" + BoxESPEnabledOpposition + Environment.NewLine +
                "SKELETONS_ENABLED_ENEMY=" + SkeletonsEnabledOpposition + Environment.NewLine +
                "RAINBOW_BOX_ESP_ENABLED_ENEMY=" + RainbowBoxESPEnabledOpposition + Environment.NewLine +
                "RAINBOW_ENEMY_ESP_ENABLED_ENEMY=" + RainbowSkeletonESPEnabledOpposition + Environment.NewLine +
                "Box_ESP_ENEMY_ARGB=" + BoxESPEnemyARGB.ToArgb() + Environment.NewLine +
                "Skeleton_ESP_ENEMY_ARGB=" + SkeletonESPEnemyARGB.ToArgb() + Environment.NewLine +
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
            GlowTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[1]));
            RainbowEnabledFriendly = bool.Parse(results[2]);
            HPToColourEnabledFriendly = bool.Parse(results[3]);

            // enemy glow options
            GlowEnabledOpposition = bool.Parse(results[4]);
            GlowEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[5]));
            RainbowEnabledOpposition = bool.Parse(results[6]);
            HPToColourEnabledOpposition = bool.Parse(results[7]);

            // team esp options
            BoxESPEnabledFriendly = bool.Parse(results[8]);
            SkeletonsEnabledFriendly = bool.Parse(results[9]);
            RainbowBoxESPEnabledFriendly = bool.Parse(results[10]);
            RainbowSkeletonESPEnabledFriendly = bool.Parse(results[11]);
            BoxESPTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[12]));
            SkeletonESPTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[13]));

            // enemy esp options
            BoxESPEnabledOpposition = bool.Parse(results[14]);
            SkeletonsEnabledOpposition = bool.Parse(results[15]);
            RainbowBoxESPEnabledOpposition = bool.Parse(results[16]);
            RainbowSkeletonESPEnabledOpposition = bool.Parse(results[17]);
            BoxESPEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[18]));
            SkeletonESPEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[19]));

            // radar options
            RadarEnabled = bool.Parse(results[20]);
            RadarSize = int.Parse(results[21]);
            RadarBlipSize = int.Parse(results[22]);
            RadarTopLeftPosition.X = float.Parse(results[23]);
            RadarTopLeftPosition.Y = float.Parse(results[24]);
            RadarOpacity = float.Parse(results[25]);
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