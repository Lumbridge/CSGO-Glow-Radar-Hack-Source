using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using FontFactory = SharpDX.DirectWrite.Factory;
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
        public static void DrawLine(Vector2 p1, Vector2 p2, WindowRenderTarget device, Color color)
        {
            device.DrawLine(p1, p2, getBrush(color, device));
        }

        /// <summary>
        /// Draws a blip on the radar of using passed in position and size
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        /// <param name="device"></param>
        public static void DrawRadarBlip(Vector2 pos, int radius, Color color, WindowRenderTarget device)
        {
            device.DrawEllipse(new Ellipse(pos, radius, radius), getBrush(color, device));
            device.DrawEllipse(new Ellipse(pos, radius / 5, radius / 5), getBrush(Color.White, device));
        }

        /// <summary>
        /// Returns a brush object
        /// </summary>
        /// <param name="color"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static SolidColorBrush getBrush(Color color, WindowRenderTarget device)
        {
            return new SolidColorBrush(device, color);
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
        public static void DrawShadowText(float x, float y, float fontSize, Color fontColour, string text, WindowRenderTarget device, FontFactory fontFactory, Size2 screenSize)
        {
            string fontFamily = "Arial";

            SolidColorBrush textBrush = new SolidColorBrush(device, Color.Black);
            TextFormat textFormat = new TextFormat(fontFactory, fontFamily, fontSize);
            TextLayout textLayout = new TextLayout(fontFactory, text, textFormat, screenSize.Width, screenSize.Height);

            //black
            device.DrawTextLayout(new Vector2(x - 1, y + 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x - 1, y - 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x + 1, y + 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x + 1, y - 1), textLayout, textBrush);

            //coloured
            textBrush = new SolidColorBrush(device, fontColour);
            device.DrawTextLayout(new Vector2(x, y), textLayout, textBrush);
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
            }, getBrush(color, device));
        }

        /// <summary>
        /// Draws an entity's skeleton
        /// </summary>
        /// <param name="BoneBase"></param>
        /// <param name="Mem"></param>
        /// <param name="viewmatrix"></param>
        /// <param name="screenSize"></param>
        /// <param name="device"></param>
        /// <param name="color"></param>
        public static void DrawSkeleton(int BoneBase, ProcessMemory Mem, Matrix4x4 viewmatrix, Size2 screenSize, WindowRenderTarget device, Color color)
        {
            #region left arm
            //left shoulder to spine
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Shoulder, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine5, Mem, viewmatrix, screenSize),
            device, color);
            //left shoulder to left elbow
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Shoulder, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Left_Elbow, Mem, viewmatrix, screenSize),
            device, color);
            //left elbow to left hand
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Elbow, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Left_Hand, Mem, viewmatrix, screenSize),
            device, color);
            #endregion

            #region right arm
            //right shoulder to spine
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Shoulder, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine5, Mem, viewmatrix, screenSize),
            device, color);
            //right shoulder to right elbow
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Shoulder, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Right_Elbow, Mem, viewmatrix, screenSize),
            device, color);
            //right elbow to right hand
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Elbow, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Right_Hand, Mem, viewmatrix, screenSize),
            device, color);
            #endregion

            #region left leg
            //left hip to spine
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Hip, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine1, Mem, viewmatrix, screenSize),
            device, color);
            //left hip to left knee
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Hip, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Left_Knee, Mem, viewmatrix, screenSize),
            device, color);
            //left knee to left foot
            DrawLine(GetW2SBone(BoneBase, Bone.Left_Knee, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Left_Foot, Mem, viewmatrix, screenSize),
            device, color);
            #endregion

            #region right leg
            //left hip to spine
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Hip, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine1, Mem, viewmatrix, screenSize),
            device, color);
            //right hip to right knee
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Hip, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Right_Knee, Mem, viewmatrix, screenSize),
            device, color);
            //right knee to right foot
            DrawLine(GetW2SBone(BoneBase, Bone.Right_Knee, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Right_Foot, Mem, viewmatrix, screenSize),
            device, color);
            #endregion

            #region spine
            //1 - 2
            DrawLine(GetW2SBone(BoneBase, Bone.Spine1, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine2, Mem, viewmatrix, screenSize),
            device, color);
            //2 - 3
            DrawLine(GetW2SBone(BoneBase, Bone.Spine2, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine3, Mem, viewmatrix, screenSize),
            device, color);
            //3 - 4
            DrawLine(GetW2SBone(BoneBase, Bone.Spine3, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine4, Mem, viewmatrix, screenSize),
            device, color);
            //4 - 5
            DrawLine(GetW2SBone(BoneBase, Bone.Spine4, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Spine5, Mem, viewmatrix, screenSize),
            device, color);
            //5 - neck
            DrawLine(GetW2SBone(BoneBase, Bone.Spine5, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Neck, Mem, viewmatrix, screenSize),
            device, color);
            //neck - head
            DrawLine(GetW2SBone(BoneBase, Bone.Neck, Mem, viewmatrix, screenSize),
            GetW2SBone(BoneBase, Bone.Head, Mem, viewmatrix, screenSize),
            device, color);
            #endregion
        }
    }
}
