using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System.Drawing;

namespace Oceano.Gui
{
    public class Graphics
    {
        static int[] cursor = new int[]
            {
                1,0,0,0,0,0,0,0,0,0,0,0,
                1,1,0,0,0,0,0,0,0,0,0,0,
                1,2,1,0,0,0,0,0,0,0,0,0,
                1,2,2,1,0,0,0,0,0,0,0,0,
                1,2,2,2,1,0,0,0,0,0,0,0,
                1,2,2,2,2,1,0,0,0,0,0,0,
                1,2,2,2,2,2,1,0,0,0,0,0,
                1,2,2,2,2,2,2,1,0,0,0,0,
                1,2,2,2,2,2,2,2,1,0,0,0,
                1,2,2,2,2,2,2,2,2,1,0,0,
                1,2,2,2,2,2,2,2,2,2,1,0,
                1,2,2,2,2,2,2,2,2,2,2,1,
                1,2,2,2,2,2,2,1,1,1,1,1,
                1,2,2,2,1,2,2,1,0,0,0,0,
                1,2,2,1,0,1,2,2,1,0,0,0,
                1,2,1,0,0,1,2,2,1,0,0,0,
                1,1,0,0,0,0,1,2,2,1,0,0,
                0,0,0,0,0,0,1,2,2,1,0,0,
                0,0,0,0,0,0,0,1,1,0,0,0};
        public static PCScreenFont font = PCScreenFont.LoadFont(Resources.font);

        public static void Init()
        {
            AppManager.RegisterApp(new Settings(300, 200, 30, 30), new(Resources.settings));
            AppManager.RegisterApp(new App(40, 40, 200, 200, "TestApp"), new(Resources.window));
            if (Drivers.BootManager.SVGAsupported == true)
            {
                Kernel.canvas = new SVGAIICanvas();
            }
            else
            {
                Kernel.canvas = FullScreenCanvas.GetFullScreenCanvas();
            }
            Kernel.canvas.Clear(Color.Black);
            MouseManager.ScreenWidth = (uint)Kernel.canvas.Mode.Columns;
            MouseManager.ScreenHeight = (uint)Kernel.canvas.Mode.Rows;
            MouseManager.X = (uint)Kernel.canvas.Mode.Columns / 2;
            MouseManager.Y = (uint)Kernel.canvas.Mode.Rows / 2;
            MouseManager.MouseSensitivity = 1;
            Update();
        }
        public static void Update()
        {
            Heap.Collect();
            Desktop.Update();
            DrawCursor(Kernel.canvas, (int)MouseManager.X, (int)MouseManager.Y);
            Kernel.canvas.Display();
            Kernel.canvas.Clear(Color.Black);
            Update();
        }
        public static void DrawCursor(Canvas canvas, int x, int y)
        {
            for (int h = 0; h < 19; h++)
            {
                for (int w = 0; w < 12; w++)
                {
                    if (cursor[h * 12 + w] == 1)
                    {
                        canvas.DrawPoint(Color.Black, w + x, h + y);
                    }
                    if (cursor[h * 12 + w] == 2)
                    {
                        canvas.DrawPoint(Color.White, w + x, h + y);
                    }
                }
            }
        }
    }
}