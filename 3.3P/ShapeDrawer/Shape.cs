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

            private bool _selected;

            public Color color { set{ _color = value;}  }
            public float X { set { _x = value; } }
            public float Y { set { _y = value; } }

            public bool Selected { set { _selected = value; } get { return _selected; } }

            public void DrawOutline()
            {
                SplashKit.FillRectangle(Color.Black, (_x - 2), (_y - 2), (_width + 4), (_height + 4));
            }

            public void Draw() {
                if (_selected)
                {
                    DrawOutline();
                }
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