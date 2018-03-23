using System;
using System.Text;
using System.Windows.Forms;
using SharpDX.Direct2D1;
using Factory = SharpDX.Direct2D1.Factory;
using FontFactory = SharpDX.DirectWrite.Factory;
using Format = SharpDX.DXGI.Format;
using SharpDX;
using System.Threading;

using Dolphin.Classes;
using static Dolphin.Classes.GlobalVariables;
using static Dolphin.Classes.Glow;
using static Dolphin.Classes.ESP;
using static Dolphin.Classes.Radar;
using static Dolphin.Classes.Triggerbot;

using static hazedumper.signatures;

namespace Dolphin
{
    public partial class OverlayForm : Form
    {
        public OverlayForm()
        {
            InitializeComponent();
            IsRunning = GetProcessAndHandles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLayeredWindowAttributes(Handle, (uint)0, 255, 0x00000002);

            DoubleBuffered = true;
            Width = 64;
            Height = 64;
            Location = new System.Drawing.Point(0, 0);
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.Opaque |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            TopMost = true;
            Visible = true;

            DXFactory = new Factory();
            DXFontFactory = new FontFactory();

            while (!IsRunning)
            {
                IsRunning = GetProcessAndHandles();
                Thread.Sleep(1);
            }

            DeviceRenderProperties = new HwndRenderTargetProperties()
            {
                Hwnd = this.Handle,
                PixelSize = new Size2(1920, 1080),
                PresentOptions = PresentOptions.None
            };

            //Init DirectX
            RenderDevice = new WindowRenderTarget(DXFactory, new RenderTargetProperties(new PixelFormat(Format.B8G8R8A8_UNorm, AlphaMode.Premultiplied)), DeviceRenderProperties);

            LoopThread = new Thread(new ParameterizedThreadStart(SDXThread));

            LoopThread.Priority = ThreadPriority.Highest;
            LoopThread.IsBackground = true;
            LoopThread.Start();

            MainForm mf = new MainForm(this);
            mf.ShowDialog();
        }

        // draw the overlay
        protected override void OnPaint(PaintEventArgs e)
        {
            int[] marg = new int[] { 0, 0, Width, Height };
            DwmExtendFrameIntoClientArea(this.Handle, ref marg);
        }

        public void SDXThread(object sender)
        {
            float progress = 0.0f;

            while (IsRunning)
            {
                GameHandle = GameProcess.MainWindowHandle;

                if (GameProcess.HasExited)
                    IsRunning = false;

                // get the coords of the csgo window
                GetWindowRect(GameHandle, out WindowBounds);

                // set the location of the form overlay
                try
                {
                    if (WindowBounds.X != Location.X || WindowBounds.Width != Size.Width)
                    {
                        Location = new System.Drawing.Point(WindowBounds.X, WindowBounds.Y);
                        Size = new System.Drawing.Size(WindowBounds.Width, WindowBounds.Height);
                    }
                }
                catch { }
                
                // set the size of the form overlay
                WindowSize = new Size2(WindowBounds.Width, WindowBounds.Height);

                RenderDevice.BeginDraw();
                RenderDevice.Clear(Color.Transparent);
                RenderDevice.TextAntialiasMode = TextAntialiasMode.Aliased; // you can set another text mode
                
                //place your rendering things here
                if (GetActiveWindowTitle() == "Counter-Strike: Global Offensive" || GetActiveWindowTitle() == "Dolphin")
                {
                    Mem.StartProcess();

                    // Create Local Entity
                    LocalEntity LE = new LocalEntity();

                    // update viewmatrix
                    ViewMatrix = Matrix4x4.ReadMatrix(Mem, dwClient + dwViewMatrix);

                    // Update radar image (in case of map change)
                    if (RadarEnabled)
                        RadarImageUpdate();
                   
                    // perform this loop for every entity in the game
                    for (int i = 0; i < 32; i++)
                    {
                        // increment rainbow cycle colour
                        progress += 0.00001f;

                        // create new entity instance
                        Entity Entity = new Entity(i);

                        // Call Radar if enabled on GUI
                        if (RadarEnabled)
                        {
                            RadarLoop(Entity, LE);
                        }

                        // Call ESP if enabled on GUI
                        if (BoxESPEnabledFriendly || BoxESPEnabledOpposition || SkeletonsEnabledFriendly || SkeletonsEnabledOpposition)
                        {
                            ESPLoop(Entity, LE, progress);
                        }

                        // Draw HP Label if enabled on GUI
                        if (IsEnabled_EnemyHPLabel && Entity.Entity_Team != LE.LocalEntity_Team && Entity.Entity_isAlive())
                        {
                            Drawing2D.DrawShadowText(Entity.Entity_Position_W2S.X - 20, Entity.Entity_Position_W2S.Y, 12.0f, Color.Lime, ("《 ❤ " + Entity.Entity_Health + " 》"));
                        }

                        // Draw Glow if enabled on GUI
                        if (GlowEnabledOpposition || GlowEnabledFriendly)
                        {
                            DoGlow(Mem, Entity, LE, progress);
                        }

                        // Call trigger if enabled on GUI
                        if (IsEnabled_TriggerBot)
                            TriggerbotLoop(LE);
                    }
                    Thread.Sleep(1);
                }
                RenderDevice.EndDraw();
            }
        }
    }
}