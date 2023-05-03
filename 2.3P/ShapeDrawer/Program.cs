using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {

        private static Shape myShape = new Shape();
        public static void Main()
        {

            Window window = new Window("Shape Drawer", 800, 600);

            do {

                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                if (SplashKit.MouseClicked(SplashKitSDK.MouseButton.LeftButton)) {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }
                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyReleased(SplashKitSDK.KeyCode.SpaceKey)) {
                    myShape.Color = SplashKit.RandomRGBColor(255);
                }
                myShape.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
