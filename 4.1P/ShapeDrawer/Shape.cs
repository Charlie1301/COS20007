using System;
using SplashKitSDK;

namespace ShapeDrawer
{

        public abstract class Shape {

            private Color _color = Color.Green;

            private float _x = 0;

            private float _y = 0;

            private int _width = 100;

            private int _height = 100;

            private bool _selected = false;

            public Shape(Color clr) { _color = clr; }
            public Shape() : this(Color.Yellow) { }
            public Color color { set{ _color = value;}  get { return _color; } }
            public float X { set { _x = value; } get { return _x; } }
            public float Y { set { _y = value; } get { return _y; } }

            public bool Selected { set { _selected = value; } get { return _selected; } }

            public abstract void DrawOutline();

            public abstract void Draw();

            public abstract bool IsAt(Point2D pt);

            public virtual void SaveTo(StreamWriter writer)
            {
                writer.WriteColor(_color);
                writer.WriteLine(_x);
                writer.WriteLine(_y);

            }

            public virtual void LoadFrom(StreamReader reader)
            {
                _color = reader.ReadColor();
                _x = reader.ReadInteger();
                _y = reader.ReadInteger();
            }
        }

}