using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{
    internal class MyLine : Shape
    {
        double _X_start = 150;

        double _Y_start = 150;

        Color _color;

        public MyLine(Color clr) : base(clr)
        {
            _color = clr;
        }

        public MyLine() : this(Color.Green) { }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 10);
            SplashKit.FillCircle(Color.Black, _X_start, _Y_start, 5);
        }

        public override void Draw()
        {
            if (Selected) { DrawOutline(); }
            SplashKit.DrawLine(_color, _X_start, _Y_start, X, Y);
        }

        public override bool IsAt(Point2D pt)
        {
            Point2D line_start = SplashKit.PointAt(_X_start, _Y_start);
            Point2D line_end = SplashKit.PointAt(X, Y);
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(line_start, line_end));
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
            base.SaveTo(writer);
        }
    }
}
