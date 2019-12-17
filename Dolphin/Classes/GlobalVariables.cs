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

using static Dolphin.Classes.Glow;
using static Dolphin.Classes.Triggerbot;
using System.Windows.Forms;
using System.Text;

namespace Dolphin.Classes
{
    public class GlobalVariables
    {
        public static bool IsRunning = false;

        #region Overlay Form Stuff
        public static IntPtr GameHandle;
        public static Process GameProcess;

        public static Int32 dwClient;
        public static Int32 dwEngine;

        public static ProcessMemory Mem = new ProcessMemory("csgo");
        
        public static Thread LoopThread = null;

        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
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
                var result = MessageBox.Show("Game not found, launch it and click retry.", "Game Not Found", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel)
                {
                    Environment.Exit(1);
                    Application.Exit();
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
                if (current.ModuleName == "client_panorama.dll")
                {
                    dwClient = (int)current.BaseAddress;
                }
            }
            return true;
        }

        #endregion

        #region Misc Tab Stuff
        public static bool
            IsEnabled_Noflash,
            IsEnabled_NoSmoke,
            IsEnabled_BunnyHop;
        #endregion

        #region Main Form Stuff
        // Hotkey controls
        public static int MOD_CONTROL = 0x0002;
        public static int MOD_SHIFT = 0x0004;
        public static int WM_HOTKEY = 0x0312;

        public enum VirtualKeyStates : int
        {
            //
            VK_KEY_A = 0x41,
            VK_KEY_B = 0x42,
            VK_KEY_C = 0x43,
            VK_KEY_D = 0x44,
            VK_KEY_E = 0x45,
            VK_KEY_F = 0x46,
            VK_KEY_G = 0x47,
            VK_KEY_H = 0x48,
            VK_KEY_I = 0x49,
            VK_KEY_J = 0x4A,
            VK_KEY_K = 0x4B,
            VK_KEY_L = 0x4C,
            VK_KEY_M = 0x4D,
            VK_KEY_N = 0x4E,
            VK_KEY_O = 0x4F,
            VK_KEY_P = 0x50,
            VK_KEY_Q = 0x51,
            VK_KEY_R = 0x52,
            VK_KEY_S = 0x53,
            VK_KEY_T = 0x54,
            VK_KEY_U = 0x55,
            VK_KEY_V = 0x56,
            VK_KEY_W = 0x57,
            VK_KEY_X = 0x58,
            VK_KEY_Y = 0x59,
            VK_KEY_Z = 0x5A,
            //
            VK_LBUTTON = 0x01,
            VK_RBUTTON = 0x02,
            VK_CANCEL = 0x03,
            VK_MBUTTON = 0x04,
            //
            VK_XBUTTON1 = 0x05,
            VK_XBUTTON2 = 0x06,
            //
            VK_BACK = 0x08,
            VK_TAB = 0x09,
            //
            VK_CLEAR = 0x0C,
            VK_RETURN = 0x0D,
            //
            VK_SHIFT = 0x10,
            VK_CONTROL = 0x11,
            VK_MENU = 0x12,
            VK_PAUSE = 0x13,
            VK_CAPITAL = 0x14,
            //
            VK_KANA = 0x15,
            VK_HANGEUL = 0x15,  /* old name - should be here for compatibility */
            VK_HANGUL = 0x15,
            VK_JUNJA = 0x17,
            VK_FINAL = 0x18,
            VK_HANJA = 0x19,
            VK_KANJI = 0x19,
            //
            VK_ESCAPE = 0x1B,
            //
            VK_CONVERT = 0x1C,
            VK_NONCONVERT = 0x1D,
            VK_ACCEPT = 0x1E,
            VK_MODECHANGE = 0x1F,
            //
            VK_SPACE = 0x20,
            VK_PRIOR = 0x21,
            VK_NEXT = 0x22,
            VK_END = 0x23,
            VK_HOME = 0x24,
            VK_LEFT = 0x25,
            VK_UP = 0x26,
            VK_RIGHT = 0x27,
            VK_DOWN = 0x28,
            VK_SELECT = 0x29,
            VK_PRINT = 0x2A,
            VK_EXECUTE = 0x2B,
            VK_SNAPSHOT = 0x2C,
            VK_INSERT = 0x2D,
            VK_DELETE = 0x2E,
            VK_HELP = 0x2F,
            //
            VK_LWIN = 0x5B,
            VK_RWIN = 0x5C,
            VK_APPS = 0x5D,
            //
            VK_SLEEP = 0x5F,
            //
            VK_NUMPAD0 = 0x60,
            VK_NUMPAD1 = 0x61,
            VK_NUMPAD2 = 0x62,
            VK_NUMPAD3 = 0x63,
            VK_NUMPAD4 = 0x64,
            VK_NUMPAD5 = 0x65,
            VK_NUMPAD6 = 0x66,
            VK_NUMPAD7 = 0x67,
            VK_NUMPAD8 = 0x68,
            VK_NUMPAD9 = 0x69,
            VK_MULTIPLY = 0x6A,
            VK_ADD = 0x6B,
            VK_SEPARATOR = 0x6C,
            VK_SUBTRACT = 0x6D,
            VK_DECIMAL = 0x6E,
            VK_DIVIDE = 0x6F,
            VK_F1 = 0x70,
            VK_F2 = 0x71,
            VK_F3 = 0x72,
            VK_F4 = 0x73,
            VK_F5 = 0x74,
            VK_F6 = 0x75,
            VK_F7 = 0x76,
            VK_F8 = 0x77,
            VK_F9 = 0x78,
            VK_F10 = 0x79,
            VK_F11 = 0x7A,
            VK_F12 = 0x7B,
            VK_F13 = 0x7C,
            VK_F14 = 0x7D,
            VK_F15 = 0x7E,
            VK_F16 = 0x7F,
            VK_F17 = 0x80,
            VK_F18 = 0x81,
            VK_F19 = 0x82,
            VK_F20 = 0x83,
            VK_F21 = 0x84,
            VK_F22 = 0x85,
            VK_F23 = 0x86,
            VK_F24 = 0x87,
            //
            VK_NUMLOCK = 0x90,
            VK_SCROLL = 0x91,
            //
            VK_OEM_NEC_EQUAL = 0x92,   // '=' key on numpad
                                       //
            VK_OEM_FJ_JISHO = 0x92,   // 'Dictionary' key
            VK_OEM_FJ_MASSHOU = 0x93,   // 'Unregister word' key
            VK_OEM_FJ_TOUROKU = 0x94,   // 'Register word' key
            VK_OEM_FJ_LOYA = 0x95,   // 'Left OYAYUBI' key
            VK_OEM_FJ_ROYA = 0x96,   // 'Right OYAYUBI' key
                                     //
            VK_LSHIFT = 0xA0,
            VK_RSHIFT = 0xA1,
            VK_LCONTROL = 0xA2,
            VK_RCONTROL = 0xA3,
            VK_LMENU = 0xA4,
            VK_RMENU = 0xA5,
            //
            VK_BROWSER_BACK = 0xA6,
            VK_BROWSER_FORWARD = 0xA7,
            VK_BROWSER_REFRESH = 0xA8,
            VK_BROWSER_STOP = 0xA9,
            VK_BROWSER_SEARCH = 0xAA,
            VK_BROWSER_FAVORITES = 0xAB,
            VK_BROWSER_HOME = 0xAC,
            //
            VK_VOLUME_MUTE = 0xAD,
            VK_VOLUME_DOWN = 0xAE,
            VK_VOLUME_UP = 0xAF,
            VK_MEDIA_NEXT_TRACK = 0xB0,
            VK_MEDIA_PREV_TRACK = 0xB1,
            VK_MEDIA_STOP = 0xB2,
            VK_MEDIA_PLAY_PAUSE = 0xB3,
            VK_LAUNCH_MAIL = 0xB4,
            VK_LAUNCH_MEDIA_SELECT = 0xB5,
            VK_LAUNCH_APP1 = 0xB6,
            VK_LAUNCH_APP2 = 0xB7,
            //
            VK_OEM_1 = 0xBA,   // ';:' for US
            VK_OEM_PLUS = 0xBB,   // '+' any country
            VK_OEM_COMMA = 0xBC,   // ',' any country
            VK_OEM_MINUS = 0xBD,   // '-' any country
            VK_OEM_PERIOD = 0xBE,   // '.' any country
            VK_OEM_2 = 0xBF,   // '/?' for US
            VK_OEM_3 = 0xC0,   // '`~' for US
                               //
            VK_OEM_4 = 0xDB,  //  '[{' for US
            VK_OEM_5 = 0xDC,  //  '\|' for US
            VK_OEM_6 = 0xDD,  //  ']}' for US
            VK_OEM_7 = 0xDE,  //  ''"' for US
            VK_OEM_8 = 0xDF,
            //
            VK_OEM_AX = 0xE1,  //  'AX' key on Japanese AX kbd
            VK_OEM_102 = 0xE2,  //  "<>" or "\|" on RT 102-key kbd.
            VK_ICO_HELP = 0xE3,  //  Help key on ICO
            VK_ICO_00 = 0xE4,  //  00 key on ICO
                               //
            VK_PROCESSKEY = 0xE5,
            //
            VK_ICO_CLEAR = 0xE6,
            //
            VK_PACKET = 0xE7,
            //
            VK_OEM_RESET = 0xE9,
            VK_OEM_JUMP = 0xEA,
            VK_OEM_PA1 = 0xEB,
            VK_OEM_PA2 = 0xEC,
            VK_OEM_PA3 = 0xED,
            VK_OEM_WSCTRL = 0xEE,
            VK_OEM_CUSEL = 0xEF,
            VK_OEM_ATTN = 0xF0,
            VK_OEM_FINISH = 0xF1,
            VK_OEM_COPY = 0xF2,
            VK_OEM_AUTO = 0xF3,
            VK_OEM_ENLW = 0xF4,
            VK_OEM_BACKTAB = 0xF5,
            //
            VK_ATTN = 0xF6,
            VK_CRSEL = 0xF7,
            VK_EXSEL = 0xF8,
            VK_EREOF = 0xF9,
            VK_PLAY = 0xFA,
            VK_ZOOM = 0xFB,
            VK_NONAME = 0xFC,
            VK_PA1 = 0xFD,
            VK_OEM_CLEAR = 0xFE,
        }

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
                "GLOW_RAINBOW_ENABLED_TEAM=" + RainbowGlowEnabledFriendly + Environment.NewLine +
                "GLOW_COLOUR_BASED_ON_HP_TEAM=" + HPToColourEnabledFriendly + Environment.NewLine +
                "GLOW_ENABLED_ENEMY=" + GlowEnabledOpposition + Environment.NewLine +
                "GLOW_ENEMY_ARGB=" + GlowEnemyARGB.ToArgb() + Environment.NewLine +
                "GLOW_RAINBOW_ENABLED_ENEMY=" + RainbowGlowEnabledOpposition + Environment.NewLine +
                "GLOW_COLOR_BASED_ON_HP_ENEMY=" + HPToColourEnabledOpposition + Environment.NewLine +
                "====ESP OPTIONS====" + Environment.NewLine +
                "====RADAR OPTIONS====" + Environment.NewLine +
                "====MISC OPTIONS====" + Environment.NewLine +
                "NO_FLASH_ENABLED=" + IsEnabled_Noflash + Environment.NewLine +
                "NO_SMOKE_ENABLED=" + IsEnabled_NoSmoke + Environment.NewLine +
                "TRIGGERBOT_ENABLED=" + IsEnabled_TriggerBot + Environment.NewLine +
                "BUNNYHOP_ENABLED=" + IsEnabled_BunnyHop + Environment.NewLine 
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

            // load and apply parsed config options

            // team glow options
            GlowEnabledFriendly = bool.Parse(results[0]);
            GlowTeamARGB = System.Drawing.Color.FromArgb(int.Parse(results[1]));
            RainbowGlowEnabledFriendly = bool.Parse(results[2]);
            HPToColourEnabledFriendly = bool.Parse(results[3]);

            // enemy glow options
            GlowEnabledOpposition = bool.Parse(results[4]);
            GlowEnemyARGB = System.Drawing.Color.FromArgb(int.Parse(results[5]));
            RainbowGlowEnabledOpposition = bool.Parse(results[6]);
            HPToColourEnabledOpposition = bool.Parse(results[7]);

            // misc options
            IsEnabled_Noflash = bool.Parse(results[8]);
            IsEnabled_NoSmoke = bool.Parse(results[9]);
            IsEnabled_TriggerBot = bool.Parse(results[10]);
            IsEnabled_BunnyHop = bool.Parse(results[11]);
        }

        #endregion

        #region Invoke DLLs
        [DllImport("USER32.dll")]
        public static extern short GetKeyState(VirtualKeyStates nVirtKey);

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
