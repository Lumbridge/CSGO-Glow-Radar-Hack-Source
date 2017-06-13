using static hazedumper.netvars;
using static hazedumper.signatures;

using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.Geometry;
using System.Drawing;

namespace Dolphin.Classes
{
    class Entity
    {
        private int _Entity_Base;

        public Entity(int index)
        {
            Entity_Base = Mem.ReadInt(dwClient + dwEntityList + (index * 0x10));
        }
        public int Entity_Base
        {
            get { return _Entity_Base; }
            set { _Entity_Base = value; }
        }
        public int Entity_Health
        {
            get { return Mem.ReadInt(Entity_Base + m_iHealth); }
        }
        public int Entity_Team
        {
            get { return Mem.ReadInt(Entity_Base + m_iTeamNum); }
        }
        public int Entity_BoneBase
        {
            get { return Mem.ReadInt(Entity_Base + m_dwBoneMatrix); }
        }
        public int Entity_GlowIndex
        {
            get { return Mem.ReadInt(Entity_Base + m_iGlowIndex); }
        }
        public bool Entity_isAlive()
        {
            if (Entity_Health < 2) // 1hp = dead
                return false;
            else
                return true;
        }
        public SharpDX.Vector2 Entity_Position_W2S
        {
            get
            {
                return WorldToScreen(ViewMatrix, WindowSize, Entity_Position_3D);
            }
        }
        public SharpDX.Vector3 Entity_Position_3D
        {
            get
            {
                float x = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 0));
                float y = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 1));
                float z = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 2));

                SharpDX.Vector3 temp;

                temp.X = x;
                temp.Y = y;
                temp.Z = z;

                return temp;
            }
        }
    }
}
