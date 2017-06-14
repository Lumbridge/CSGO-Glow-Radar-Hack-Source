using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using FontFactory = SharpDX.DirectWrite.Factory;

using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.Skeleton;

namespace Dolphin.Classes
{
    class Drawing2D
    {
        /// <summary>
        /// Converts a system.drawing.color to a sharpdx color
        /// </summary>
        /// <param name="inColor"></param>
        /// <returns></returns>
        public static Color SystemColorToSharpColor(System.Drawing.Color inColor)
        {
            return Color.FromBgra(inColor.ToArgb());
        }

        /// <summary>
        /// Normalises coordinates between a smaller range I.E. Takes XY 3D player coordinates and scales them into the boundaries of the radar
        /// </summary>
        /// <param name="minDX"></param>
        /// <param name="maxDX"></param>
        /// <param name="minDY"></param>
        /// <param name="maxDY"></param>
        /// <param name="m"></param>
        /// <param name="originalPos"></param>
        /// <returns></returns>
        public static Vector3 normaliseCoords(int minDX, int maxDX, int minDY, int maxDY, MapInfo.map m, Vector3 originalPos)
        {
            return new Vector3()
            {
                X = minDX + (originalPos.X - m.topLeft.X) * (maxDX - minDX) / (m.bottomRight.X - m.topLeft.X),
                Y = minDY + (originalPos.Y - m.topLeft.Y) * (maxDY - minDY) / (m.bottomRight.Y - m.topLeft.Y)
            };
        }

        /// <summary>
        /// Loads a Direct2D Bitmap from a file using System.Drawing.Image.FromFile(...)
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="file">The file.</param>
        /// <returns>A D2D1 Bitmap</returns>
        public static Bitmap LoadFromFile(RenderTarget m_renderTarget, string filename)
        {
            System.Drawing.Bitmap bmp = (System.Drawing.Bitmap)System.Drawing.Image.FromFile(filename);

            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(
                    new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            DataStream stream = new SharpDX.DataStream(bmpData.Scan0, bmpData.Stride * bmpData.Height, true, false);
            PixelFormat pFormat = new PixelFormat(SharpDX.DXGI.Format.B8G8R8A8_UNorm, AlphaMode.Premultiplied);
            BitmapProperties bmpProps = new BitmapProperties(pFormat);

            Bitmap result =
                new Bitmap(
                    m_renderTarget,
                    new Size2(bmp.Width, bmp.Height),
                    stream,
                    bmpData.Stride,
                    bmpProps);

            bmp.UnlockBits(bmpData);

            stream.Dispose();
            bmp.Dispose();

            return result;
        }

        /// <summary>
        /// Loads a Direct2D Bitmap from a file using System.Drawing.Image.FromFile(...)
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="file">The file.</param>
        /// <returns>A D2D1 Bitmap</returns>
        public static Bitmap LoadFromFile(RenderTarget m_renderTarget, System.Drawing.Bitmap image)
        {
            System.Drawing.Bitmap bmp = image;

            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(
                    new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            DataStream stream = new DataStream(bmpData.Scan0, bmpData.Stride * bmpData.Height, true, false);
            PixelFormat pFormat = new PixelFormat(SharpDX.DXGI.Format.B8G8R8A8_UNorm, AlphaMode.Premultiplied);
            BitmapProperties bmpProps = new BitmapProperties(pFormat);

            Bitmap result =
                new Bitmap(
                    m_renderTarget,
                    new Size2(bmp.Width, bmp.Height),
                    stream,
                    bmpData.Stride,
                    bmpProps);

            bmp.UnlockBits(bmpData);

            stream.Dispose();
            bmp.Dispose();

            return result;
        }

        /// <summary>
        /// Draws a line between point 1 and point 2
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="device"></param>
        /// <param name="color"></param>
        public static void DrawLine(Vector2 p1, Vector2 p2, Color color)
        {
            RenderDevice.DrawLine(p1, p2, getBrush(color));
        }

        /// <summary>
        /// Draws a blip on the radar of using passed in position and size
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        /// <param name="device"></param>
        public static void DrawRadarBlip(Vector2 pos, int radius, Color color)
        {
            RenderDevice.DrawEllipse(new Ellipse(pos, radius, radius), getBrush(color));
            RenderDevice.DrawEllipse(new Ellipse(pos, radius / 5, radius / 5), getBrush(Color.White));
        }

        /// <summary>
        /// Returns a brush object
        /// </summary>
        /// <param name="color"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static SolidColorBrush getBrush(Color color)
        {
            return new SolidColorBrush(RenderDevice, color);
        }

        /// <summary>
        /// Draws text with a black outline
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fontSize"></param>
        /// <param name="fontColour"></param>
        /// <param name="text"></param>
        /// <param name="device"></param>
        /// <param name="fontFactory"></param>
        /// <param name="screenSize"></param>
        public static void DrawShadowText(float x, float y, float fontSize, Color fontColour, string text)
        {
            string fontFamily = "Arial";

            SolidColorBrush textBrush = new SolidColorBrush(RenderDevice, Color.Black);
            TextFormat textFormat = new TextFormat(DXFontFactory, fontFamily, fontSize);
            TextLayout textLayout = new TextLayout(DXFontFactory, text, textFormat, WindowSize.Width, WindowSize.Height);

            //black
            RenderDevice.DrawTextLayout(new Vector2(x - 1, y + 1), textLayout, textBrush);
            RenderDevice.DrawTextLayout(new Vector2(x - 1, y - 1), textLayout, textBrush);
            RenderDevice.DrawTextLayout(new Vector2(x + 1, y + 1), textLayout, textBrush);
            RenderDevice.DrawTextLayout(new Vector2(x + 1, y - 1), textLayout, textBrush);

            //coloured
            textBrush = new SolidColorBrush(RenderDevice, fontColour);
            RenderDevice.DrawTextLayout(new Vector2(x, y), textLayout, textBrush);
        }

        /// <summary>
        /// Draws a box around an entity
        /// </summary>
        /// <param name="headPos"></param>
        /// <param name="feetPos"></param>
        /// <param name="color"></param>
        /// <param name="device"></param>
        public static void DrawESPBox(Vector2 headPos, Vector2 feetPos, Color color, WindowRenderTarget device)
        {
            float height = (feetPos.Y - headPos.Y);
            float width = height * (45.0f / 80.0f);

            device.DrawRectangle(new SharpDX.Mathematics.Interop.RawRectangleF()
            {
                Top = headPos.Y - 10.0f,
                Bottom = feetPos.Y,
                Left = feetPos.X - width / 2.0f,
                Right = feetPos.X + width / 2.0f
            }, getBrush(color));
        }

        /// <summary>
        /// Draws a line from bone to bone using bone IDs
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="bone1"></param>
        /// <param name="bone2"></param>
        /// <param name="color"></param>
        public static void DrawBone(Entity entity, int bone1, int bone2, Color color)
        {
            DrawLine(
                GetW2SBone(entity.Entity_BoneBase, bone1, Mem, ViewMatrix, WindowSize),
                GetW2SBone(entity.Entity_BoneBase, bone2, Mem, ViewMatrix, WindowSize),
                color);
        }

        /// <summary>
        /// Draws an entity's skeleton based on their model
        /// </summary>
        /// <param name="BoneBase"></param>
        /// <param name="Mem"></param>
        /// <param name="viewmatrix"></param>
        /// <param name="screenSize"></param>
        /// <param name="device"></param>
        /// <param name="color"></param>
        public static void DrawSkeleton(Entity entity, Color color)
        {
            if (entity.Entity_Model_Name.Contains("tm_separatist"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("tm_leet"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("tm_phoenix"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("tm_prof"))
            {
                DrawBone(entity, 72, 71, color);
                DrawBone(entity, 71, 0, color);
                DrawBone(entity, 0, 78, color);
                DrawBone(entity, 78, 79, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 11, color);
                DrawBone(entity, 11, 12, color);
                DrawBone(entity, 12, 13, color);

                DrawBone(entity, 7, 39, color);
                DrawBone(entity, 39, 40, color);
                DrawBone(entity, 40, 41, color);
            }
            else if (entity.Entity_Model_Name.Contains("tm_anar"))
            {
                DrawBone(entity, 69, 68, color);
                DrawBone(entity, 68, 0, color);
                DrawBone(entity, 0, 75, color);
                DrawBone(entity, 75, 76, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 12, color);
                DrawBone(entity, 12, 13, color);
                DrawBone(entity, 13, 14, color);

                DrawBone(entity, 7, 40, color);
                DrawBone(entity, 40, 41, color);
                DrawBone(entity, 41, 42, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_swat"))
            {
                DrawBone(entity, 69, 68, color);
                DrawBone(entity, 68, 0, color);
                DrawBone(entity, 0, 75, color);
                DrawBone(entity, 75, 76, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 12, color);
                DrawBone(entity, 12, 13, color);
                DrawBone(entity, 13, 14, color);

                DrawBone(entity, 7, 40, color);
                DrawBone(entity, 40, 41, color);
                DrawBone(entity, 41, 42, color);
            }

            else if (entity.Entity_Model_Name.Contains("CTM_SAS") || entity.Entity_Model_Name.Contains("ctm_sas"))
            {
                DrawBone(entity, 83, 82, color);
                DrawBone(entity, 82, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 11, color);
                DrawBone(entity, 11, 12, color);
                DrawBone(entity, 12, 13, color);

                DrawBone(entity, 7, 40, color);
                DrawBone(entity, 40, 41, color);
                DrawBone(entity, 41, 42, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_idf"))
            {
                DrawBone(entity, 72, 71, color);
                DrawBone(entity, 71, 0, color);
                DrawBone(entity, 0, 78, color);
                DrawBone(entity, 78, 79, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 11, color);
                DrawBone(entity, 11, 12, color);
                DrawBone(entity, 12, 13, color);

                DrawBone(entity, 7, 41, color);
                DrawBone(entity, 41, 42, color);
                DrawBone(entity, 42, 43, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_st6"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_fbi"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_gsg9"))
            {
                DrawBone(entity, 67, 66, color);
                DrawBone(entity, 66, 0, color);
                DrawBone(entity, 0, 73, color);
                DrawBone(entity, 73, 74, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 10, color);
                DrawBone(entity, 10, 11, color);
                DrawBone(entity, 11, 12, color);

                DrawBone(entity, 7, 38, color);
                DrawBone(entity, 38, 39, color);
                DrawBone(entity, 39, 40, color);
            }
            else if (entity.Entity_Model_Name.Contains("ctm_gign"))
            {
                DrawBone(entity, 71, 70, color);
                DrawBone(entity, 70, 0, color);
                DrawBone(entity, 0, 77, color);
                DrawBone(entity, 77, 79, color);

                DrawBone(entity, 0, 6, color);
                DrawBone(entity, 6, 7, color);
                DrawBone(entity, 7, 8, color);

                DrawBone(entity, 7, 11, color);
                DrawBone(entity, 11, 12, color);
                DrawBone(entity, 12, 13, color);

                DrawBone(entity, 7, 40, color);
                DrawBone(entity, 40, 41, color);
                DrawBone(entity, 41, 42, color);
            }
        }
    }
}
