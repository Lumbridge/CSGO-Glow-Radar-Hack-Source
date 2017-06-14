using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Dolphin.Classes.Glow;
using static Dolphin.Classes.GlobalVariables;

namespace Dolphin.Classes
{
    class ESP
    {
        #region ESP variables
        public static bool BoxESPEnabledFriendly, BoxESPEnabledOpposition;
        public static bool SkeletonsEnabledFriendly, SkeletonsEnabledOpposition;
        public static bool RainbowBoxESPEnabledFriendly, RainbowBoxESPEnabledOpposition;
        public static bool RainbowSkeletonESPEnabledFriendly, RainbowSkeletonESPEnabledOpposition;
        public static System.Drawing.Color BoxESPEnemyARGB, BoxESPTeamARGB;
        public static System.Drawing.Color SkeletonESPEnemyARGB, SkeletonESPTeamARGB;
        public static int ESPAlpha = 255;
        #endregion

        public static void ESPLoop(Entity Entity, LocalEntity LE, float progress)
    {
        // Do ESP
        if (Entity.Entity_isAlive() && Entity.Entity_Base != LE.LocalEntity_Base)
        {
            // friendly box esp
            if (BoxESPEnabledFriendly && Entity.Entity_Team == LE.LocalEntity_Team)
            {
                if (RainbowBoxESPEnabledFriendly)
                {
                    Drawing2D.DrawESPBox(
                        Skeleton.GetW2SBone(Entity.Entity_BoneBase, Skeleton.Bone.Head, Mem, ViewMatrix, WindowSize),
                        Entity.Entity_Position_W2S, Drawing2D.SystemColorToSharpColor(Rainbow(progress)), RenderDevice);
                }
                else
                {
                    Drawing2D.DrawESPBox(
                        Skeleton.GetW2SBone(Entity.Entity_BoneBase, Skeleton.Bone.Head, Mem, ViewMatrix, WindowSize),
                        Entity.Entity_Position_W2S, Drawing2D.SystemColorToSharpColor(BoxESPTeamARGB), RenderDevice);
                }
            }

            // friendly skeleton esp
            if (SkeletonsEnabledFriendly && Entity.Entity_Team == LE.LocalEntity_Team)
            {
                if (RainbowSkeletonESPEnabledFriendly)
                {
                    Drawing2D.DrawSkeleton(Entity, Drawing2D.SystemColorToSharpColor(Rainbow(progress)));
                }
                else
                {
                    Drawing2D.DrawSkeleton(Entity, Drawing2D.SystemColorToSharpColor(SkeletonESPTeamARGB));
                }
            }

            // enenmy box esp
            if (BoxESPEnabledOpposition && Entity.Entity_Team != LE.LocalEntity_Team)
            {
                if (RainbowBoxESPEnabledOpposition)
                {
                    Drawing2D.DrawESPBox(
                        Skeleton.GetW2SBone(Entity.Entity_BoneBase, Skeleton.Bone.Head, Mem, ViewMatrix, WindowSize),
                        Entity.Entity_Position_W2S, Drawing2D.SystemColorToSharpColor(Rainbow(progress)), RenderDevice);
                }
                else
                {
                    Drawing2D.DrawESPBox(
                        Skeleton.GetW2SBone(Entity.Entity_BoneBase, Skeleton.Bone.Head, Mem, ViewMatrix, WindowSize),
                        Entity.Entity_Position_W2S, Drawing2D.SystemColorToSharpColor(BoxESPEnemyARGB), RenderDevice);
                }
            }

            // enemy skeleton esp
            if (SkeletonsEnabledOpposition && Entity.Entity_Team != LE.LocalEntity_Team)
            {
                if (RainbowSkeletonESPEnabledOpposition)
                {
                    Drawing2D.DrawSkeleton(Entity, Drawing2D.SystemColorToSharpColor(Rainbow(progress)));
                }
                else
                {
                    Drawing2D.DrawSkeleton(Entity, Drawing2D.SystemColorToSharpColor(SkeletonESPEnemyARGB));
                }

            }
        }

    }
    }

}
