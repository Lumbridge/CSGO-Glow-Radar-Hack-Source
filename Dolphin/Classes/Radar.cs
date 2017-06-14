using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;

using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.MapInfo;

namespace Dolphin.Classes
{
    class Radar
    {
        #region radar stuff
        public static bool RadarEnabled;
        public static int RadarSize, RadarBlipSize;
        public static float RadarOpacity;
        public static Vector2 RadarTopLeftPosition;
        public static RawRectangleF radarBounds = new RawRectangleF();
        public static Bitmap MapImage;
        #endregion

        public static void RadarImageUpdate()
        {
            // radar bounds 
            radarBounds = new RawRectangleF()
            {
                Top = RadarTopLeftPosition.Y,
                Bottom = RadarTopLeftPosition.Y + RadarSize,
                Left = RadarTopLeftPosition.X,
                Right = RadarTopLeftPosition.X + RadarSize
            };

            // get current mapname
            CurrentMapName = getCurrentMapName();

            // check for map change to change map image for radar
            if (CurrentMapName != LastMapName)
            {
                LastMapName = CurrentMapName;
                MapImage = Drawing2D.LoadFromFile(RenderDevice, MapInfo.getCurrentMapImage(CurrentMapName));
            }

            // Draw radar bounds and map image
            RenderDevice.DrawBitmap(MapImage, radarBounds, RadarOpacity, BitmapInterpolationMode.Linear);
            RenderDevice.DrawRectangle(radarBounds, Drawing2D.getBrush(Color.White));
        }

        public static void RadarLoop(Entity Entity, LocalEntity LE)
        {
            // translate entity 3d coords into 2d radar coords
            Vector3 normalisedRadarPos = Drawing2D.normaliseCoords((int)radarBounds.Left, (int)radarBounds.Right, (int)radarBounds.Top, (int)radarBounds.Bottom, MapInfo.getCurrentMapInfo(CurrentMapName), Entity.Entity_Position_3D);

            // draw radar blips
            if (Entity.Entity_isAlive())
            {
                if (Entity.Entity_Team != LE.LocalEntity_Team)
                    Drawing2D.DrawRadarBlip(new Vector2(normalisedRadarPos.X, normalisedRadarPos.Y), RadarBlipSize, Color.Red);
                else if (Entity.Entity_Base == LE.LocalEntity_Base)
                {
                    Drawing2D.DrawRadarBlip(new Vector2(normalisedRadarPos.X, normalisedRadarPos.Y), RadarBlipSize, Color.Yellow);
                    RenderDevice.DrawEllipse(new Ellipse(new Vector2(normalisedRadarPos.X, normalisedRadarPos.Y), 50, 50), Drawing2D.getBrush(Color.White));
                }
                else
                    Drawing2D.DrawRadarBlip(new Vector2(normalisedRadarPos.X, normalisedRadarPos.Y), RadarBlipSize, Color.LimeGreen);
            }
        }
    }
}
