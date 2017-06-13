using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using FontFactory = SharpDX.DirectWrite.Factory;
using static Dolphin.Classes.Skeleton;

namespace Dolphin.Classes
{
    class drawing2d
    {
        public static Vector3 normaliseCoords(int minDX, int maxDX, int minDY, int maxDY, MapInfo.map m, Vector3 originalPos)
        {
            Vector3 norm = new Vector3();

            norm.X = minDX + (originalPos.X - m.topLeft.X) * (maxDX - minDX) / (m.bottomRight.X - m.topLeft.X);
            norm.Y = minDY + (originalPos.Y - m.topLeft.Y) * (maxDY - minDY) / (m.bottomRight.Y - m.topLeft.Y);

            return norm;
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

            SharpDX.DataStream stream = new SharpDX.DataStream(bmpData.Scan0, bmpData.Stride * bmpData.Height, true, false);
            SharpDX.Direct2D1.PixelFormat pFormat = new SharpDX.Direct2D1.PixelFormat(SharpDX.DXGI.Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied);
            SharpDX.Direct2D1.BitmapProperties bmpProps = new SharpDX.Direct2D1.BitmapProperties(pFormat);

            SharpDX.Direct2D1.Bitmap result =
                new SharpDX.Direct2D1.Bitmap(
                    m_renderTarget,
                    new SharpDX.Size2(bmp.Width, bmp.Height),
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

            SharpDX.DataStream stream = new SharpDX.DataStream(bmpData.Scan0, bmpData.Stride * bmpData.Height, true, false);
            SharpDX.Direct2D1.PixelFormat pFormat = new SharpDX.Direct2D1.PixelFormat(SharpDX.DXGI.Format.B8G8R8A8_UNorm, SharpDX.Direct2D1.AlphaMode.Premultiplied);
            SharpDX.Direct2D1.BitmapProperties bmpProps = new SharpDX.Direct2D1.BitmapProperties(pFormat);

            SharpDX.Direct2D1.Bitmap result =
                new SharpDX.Direct2D1.Bitmap(
                    m_renderTarget,
                    new SharpDX.Size2(bmp.Width, bmp.Height),
                    stream,
                    bmpData.Stride,
                    bmpProps);

            bmp.UnlockBits(bmpData);

            stream.Dispose();
            bmp.Dispose();

            return result;
        }

        public static void DrawLine(Vector2 p1, Vector2 p2, WindowRenderTarget device, Color color)
        {
            device.DrawLine(p1, p2, getBrush(color, device));
        }

        public static void DrawRadarBlip(Vector2 pos, int radius, Color color, WindowRenderTarget device)
        {
            device.DrawEllipse(new Ellipse(pos, radius, radius), getBrush(color, device));
            device.DrawEllipse(new Ellipse(pos, radius / 5, radius / 5), getBrush(Color.White, device));
        }

        public static SolidColorBrush getBrush(Color color, WindowRenderTarget device)
        {
            return new SolidColorBrush(device, color);
        }

        public static SolidColorBrush getTransparentBrush(Color color, WindowRenderTarget device, float opacity)
        {
            return new SolidColorBrush(device, color) { Opacity = opacity };
        }

        public static void DrawShadowText(int x, int y, float fontSize, Color fontColour, string text, WindowRenderTarget device, FontFactory fontFactory, Rectangle screenPos)
        {
            string fontFamily = "Arial";

            SolidColorBrush textBrush = new SolidColorBrush(device, Color.Black);
            TextFormat textFormat = new TextFormat(fontFactory, fontFamily, fontSize);
            TextLayout textLayout = new TextLayout(fontFactory, text, textFormat, screenPos.Width, screenPos.Height);

            //black
            device.DrawTextLayout(new Vector2(x - 1, y + 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x - 1, y - 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x + 1, y + 1), textLayout, textBrush);
            device.DrawTextLayout(new Vector2(x + 1, y - 1), textLayout, textBrush);

            //coloured
            textBrush = new SolidColorBrush(device, fontColour);
            device.DrawTextLayout(new Vector2(x, y), textLayout, textBrush);
        }

        public static void DrawESPBox(Vector2 headPos, Vector2 feetPos, Color color, WindowRenderTarget device)
        {
            int height = (int)(feetPos.Y - headPos.Y);

            device.DrawRectangle(new SharpDX.Mathematics.Interop.RawRectangleF()
            {
                Top = headPos.Y,
                Bottom = feetPos.Y - 5,
                Left = feetPos.X - (height/2 - 2),
                Right = feetPos.X + (height/2 - 2)
            }, getBrush(color,device));
        }

        public static void DrawSkeleton(int BoneBase, ProcessMemory Mem, Matrix4x4 viewmatrix, Size2 screenSize, WindowRenderTarget device, Color color)
        {
            #region left arm
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

        public static void DrawESPBox(Vector2[] points, Color color, WindowRenderTarget device)
        {
            //int height = (int)(feetPos.Y - headPos.Y);

            device.DrawRectangle(new SharpDX.Mathematics.Interop.RawRectangleF()
            {
                Top = points[0].Y,
                Bottom = points[2].Y,
                Left = points[0].X,
                Right = points[2].X
            }, getBrush(color, device));
        }
    }
}
