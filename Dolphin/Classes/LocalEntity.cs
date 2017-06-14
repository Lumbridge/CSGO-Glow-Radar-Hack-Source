using static hazedumper.netvars;
using static hazedumper.signatures;

using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.Geometry;

namespace Dolphin.Classes
{
    class LocalEntity
    {
        public int LocalEntity_Base
        {
            get { return Mem.ReadInt(dwClient + dwLocalPlayer); }
        }
        public int LocalEntity_Health
        {
            get { return Mem.ReadInt(LocalEntity_Base + m_iHealth); }
        }
        public int LocalEntity_Team
        {
            get { return Mem.ReadInt(LocalEntity_Base + m_iTeamNum); }
        }
        public int LocalEntity_CrosshairID
        {
            get { return Mem.ReadInt(LocalEntity_Base + m_iCrosshairId); }
        }
        public int LocalEntity_EntityInCrosshair
        {
            get { return Mem.ReadInt(dwClient + dwEntityList + ((LocalEntity_CrosshairID - 1) * 0x10)); }
        }
        public int LocalEntity_EntityInCrosshairHealth
        {
            get { return Mem.ReadInt(LocalEntity_EntityInCrosshair + m_iHealth); }
        }
        public int LocalEntity_EntityInCrosshairTeam
        {
            get { return Mem.ReadInt(LocalEntity_EntityInCrosshair + m_iTeamNum); }
        }
        public bool LocalEntity_isAlive()
        {
            if (LocalEntity_Health < 1)
                return false;
            else
                return true;
        }
        public SharpDX.Vector2 LocalEntity_Position_W2S
        {
            get
            {
                return WorldToScreen(ViewMatrix, WindowSize, LocalEntity_Position_3D);
            }
        }
        public SharpDX.Vector3 LocalEntity_Position_3D
        {
            get
            {
                float x = Mem.ReadFloat(LocalEntity_Base + m_vecOrigin + (0x4 * 0));
                float y = Mem.ReadFloat(LocalEntity_Base + m_vecOrigin + (0x4 * 1));
                float z = Mem.ReadFloat(LocalEntity_Base + m_vecOrigin + (0x4 * 2));

                return new SharpDX.Vector3()
                {
                    X = x,
                    Y = y,
                    Z = z
                };
            }
        }
    }
}
