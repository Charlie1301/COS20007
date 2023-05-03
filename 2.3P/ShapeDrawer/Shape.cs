using System;
using SplashKitSDK;

namespace ShapeDrawer
{

        public class Shape {

            private Color _color = Color.Green;

            private float _x = 0;

            private float _y = 0;

            private int _width = 100;

            private int _height = 100;

            public Color Color { set{ _color = value;}  get { return _color; } }
            public float X { set { _x = value; } get { return _x; } }
            public float Y { set { _y = value; } get { return _y; } }
            public int Height {  get { return _height; } }
            public int Width { get { return _width; } }


            public void Draw() {

                SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            } 

            public bool IsAt(Point2D pt) {

                if (pt.X > _x && pt.X < (_x + _width) && pt.Y > _y && pt.Y < (_y + _height)) {
                        
                    return true;

                } else {

                    return false;

                }
            }
        }
}