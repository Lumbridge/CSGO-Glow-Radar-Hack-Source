using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static hazedumper.netvars;

namespace Dolphin.Classes
{
    class NoFlash
    {
        public static void NoFlashLoop(LocalEntity LE, ProcessMemory Mem)
        {
            if(LE.LocalEntity_flashDuration > 0)
            {
                Mem.WriteFloat(LE.LocalEntity_Base + m_flFlashDuration, 0f);
            }
        } 
    }
}
