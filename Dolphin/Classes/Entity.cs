using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;

using static hazedumper.netvars;
using static hazedumper.signatures;

using static Dolphin.Classes.GlobalVariables;

namespace Dolphin.Classes
{
    public class Entity
    {
        int m_Dormant = 0xE9;

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
        public int Entity_Model_Base
        {
            get { return Mem.ReadInt(Entity_Base + 0x6C); }
        }
        public string Entity_Model_Name
        {
            get { return Mem.ReadStringAscii(Entity_Model_Base + 0x4, 64); }
        }
        public bool Entity_IsDormant
        {
            get { return Conversions.ToBoolean(Operators.NotObject(RuntimeHelpers.GetObjectValue(Mem.ReadBool(Conversions.ToInteger(Operators.AddObject(Entity_Base, m_Dormant)))))); }
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
            if (Entity_Health < 1)
                return false;
            else
                return true;
        }
        public SharpDX.Vector3 Entity_Position_3D
        {
            get
            {
                float x = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 0));
                float y = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 1));
                float z = Mem.ReadFloat(Entity_Base + m_vecOrigin + (0x4 * 2));

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
