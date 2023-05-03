using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {

        private int _width = 100;

        private int _height = 100;

        public MyRectangle (Color clr, float x, float y, int width, int height) : base (clr)
        {
            color = clr;
            X = x;
            Y = y;
            _height = height;
            _width = width;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100) { }

        public override void DrawOutline()
        {
            if (Selected)
            {
                SplashKit.FillRectangle(Color.Black, (X - 2), (Y - 2), (_width + 4), (_height + 4));
            }
        }

        public override void Draw()
        {
            DrawOutline();
            SplashKit.FillRectangle(color, X, Y, _width, _height);
        }

        public override bool IsAt(Point2D pt)
        {
            if (pt.X > X && pt.X < (X + _width) && pt.Y > Y && pt.Y < (Y + _height))
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Rectangle");
            base.SaveTo(writer);
            writer.WriteLine(_width);
            writer.WriteLine(_height);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _width = reader.ReadInteger();
            _height = reader.ReadInteger();
        }
    }
}
