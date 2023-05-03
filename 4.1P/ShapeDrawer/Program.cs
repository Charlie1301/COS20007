using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle, Circle, Line
        }

        private static Drawing myDrawing = new Drawing();
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;

            Window window = new Window("Shape Drawer", 800, 600);

            do {

                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myDrawing.Draw();
                if (SplashKit.MouseClicked(SplashKitSDK.MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle newRect = new MyRectangle();
                        newShape = newRect;
                    } else if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        newShape = newCircle;
                    } else
                    {
                        MyLine newLine = new MyLine();
                        newShape = newLine;
                    }
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(newShape);
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
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.SKey))
                {
                    myDrawing.Save("C:/users/charl/desktop");
                }
                if (SplashKit.KeyTyped(SplashKitSDK.KeyCode.OKey))
                {
                    try
                    {
                        myDrawing.Load("C:/users/charl/desktop/test_save.txt");
                    } catch (Exception e)
                    {
                        Console.Error.WriteLine("Error loading file: {0}", e.Message);
                    }
                }
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
