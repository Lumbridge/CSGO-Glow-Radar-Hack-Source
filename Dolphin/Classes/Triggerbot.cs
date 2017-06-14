using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Dolphin.Classes.GlobalVariables;

namespace Dolphin.Classes
{
    class Triggerbot
    {
        public static bool IsEnabled_TriggerBot;

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private static void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void TriggerbotLoop(LocalEntity LE)
        {
            if(GetKeyState(VirtualKeyStates.VK_MBUTTON) < 0 && LE.LocalEntity_EntityInCrosshairTeam != LE.LocalEntity_Team && LE.LocalEntity_EntityInCrosshairHealth > 0)
            {
                DoMouseClick();
                Thread.Sleep(1);
            }
        }
    }
}
