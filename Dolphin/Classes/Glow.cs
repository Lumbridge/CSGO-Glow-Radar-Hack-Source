using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;
using static Dolphin.Classes.GlobalVariables;

using static hazedumper.signatures;
using static hazedumper.netvars;
using System.Drawing;

namespace Dolphin.Classes
{
    class Glow
    {
        public static bool GlowEnabledFriendly, GlowEnabledOpposition;
        public static bool RainbowGlowEnabledFriendly, RainbowGlowEnabledOpposition;
        public static bool HPToColourEnabledFriendly, HPToColourEnabledOpposition;
        public static Color GlowEnemyARGB, GlowTeamARGB;
        public static int GlowAlpha = 255;

        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }

        public static Color HPtoColour(int health)
        {
            if (health >= 75)
                return Color.FromArgb(255, 0, 255, 0);
            else if (health < 75 && health >= 30)
                return Color.FromArgb(255, 255, 255, 0);
            else
                return Color.FromArgb(255, 255, 0, 0);
        }

        public static Color Rainbow(float progress)
        {
            float div = (System.Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }

        private static void DrawGlow(int glowAddress, GlowStruct colours, ProcessMemory Mem)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(Mem.ReadInt(dwClient + dwGlowObjectManager));
            Mem.WriteFloat(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 4)), colours.r);
            Mem.WriteFloat(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 8)), colours.g);
            Mem.WriteFloat(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 12)), colours.b);
            Mem.WriteFloat(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 0x10)), colours.a);
            Mem.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 0x24)), colours.rwo);
            Mem.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (glowAddress * 0x38) + 0x25)), colours.rwuo);
        }

        public static void DoGlow(ProcessMemory Mem, Entity cEntity, LocalEntity cLocalEntity, float rainbowProgress)
        {
            Color friTemp = GlowTeamARGB;
            Color oppTemp = GlowEnemyARGB;

            if(RainbowGlowEnabledOpposition)
            {
                oppTemp = Rainbow(rainbowProgress);
            }
            else if(HPToColourEnabledOpposition)
            {
                oppTemp = HPtoColour(cEntity.Entity_Health);
            }
            else
            {
                oppTemp = GlowEnemyARGB;
            }

            GlowStruct opposition = new GlowStruct
            {
                r = (float)((oppTemp.R) / 255.0),
                g = (float)((oppTemp.G) / 255.0),
                b = (float)((oppTemp.B) / 255.0),
                a = (float)((GlowAlpha) / 255.0),
                rwo = true,
                rwuo = false
            };

            if (RainbowGlowEnabledFriendly)
            {
                friTemp = Rainbow(rainbowProgress);
            }
            else if (HPToColourEnabledFriendly)
            {
                friTemp = HPtoColour(cEntity.Entity_Health);
            }
            else
            {
                friTemp = GlowTeamARGB;
            }

            GlowStruct team = new GlowStruct
            {
                r = (float)((friTemp.R) / 255.0),
                g = (float)((friTemp.G) / 255.0),
                b = (float)((friTemp.B) / 255.0),
                a = (float)((GlowAlpha) / 255.0),
                rwo = true,
                rwuo = false
            };
            if (GlowEnabledOpposition | GlowEnabledFriendly)
            {
                if (cEntity.Entity_isAlive() && cEntity.Entity_IsDormant)
                {
                    object right = Mem.ReadInt(cEntity.Entity_Base + m_iTeamNum);
                    if (cEntity.Entity_Team == cLocalEntity.LocalEntity_Team)
                    {
                        if (GlowEnabledFriendly)
                        {
                            DrawGlow(Conversions.ToInteger(cEntity.Entity_GlowIndex), team, Mem);
                        }
                    }
                    else
                    {
                        if (GlowEnabledOpposition)
                        {
                            DrawGlow(Conversions.ToInteger(cEntity.Entity_GlowIndex), opposition, Mem);
                        }
                    }
                }
            }
        }
    }
}
