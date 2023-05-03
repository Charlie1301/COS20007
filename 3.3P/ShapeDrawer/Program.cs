using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {

        private static Drawing myDrawing = new Drawing();
        public static void Main()
        {

            Window window = new Window("Shape Drawer", 800, 600);

            do {

                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(SplashKitSDK.MouseButton.LeftButton))
                {
                    Shape newShape = new Shape();
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();

                    myDrawing.AddShape(newShape);
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.SpaceKey)) {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }
                if (SplashKit.MouseClicked(SplashKitSDK.MouseButton.RightButton))
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.BackspaceKey) || SplashKit.KeyTyped(SplashKitSDK.KeyCode.DeleteKey))
                { 
                    foreach (Shape s in myDrawing.Selected_Shapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }
                myDrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
