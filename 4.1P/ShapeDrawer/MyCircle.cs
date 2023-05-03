using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{
    internal class MyCircle : Shape
    {

        int _radius;

        Color _color;

        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = 50;
            _color = clr;
        }

        public MyCircle() : this(Color.Blue, 50) { }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, (_radius + 2));
        }
        public override void Draw()
        {
            if (Selected) { DrawOutline(); }
            SplashKit.FillCircle(color, X, Y, _radius);
        }

        public override bool IsAt(Point2D pt)
        {
            Point2D circle_origin = SplashKit.PointAt(X, Y);
            return SplashKit.PointInCircle(pt, SplashKit.CircleAt(circle_origin, _radius));
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(_radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _radius = reader.ReadInteger();
        }
    }
}
