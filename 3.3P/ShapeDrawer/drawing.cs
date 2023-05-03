using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeDrawer {

    public class Drawing {

        private readonly List<Shape> _shapes;

        private SplashKitSDK.Color _background;

        public Drawing(SplashKitSDK.Color background) {
            _shapes = new List<Shape> { };
            _background = background;
        }

        public Drawing() : this(SplashKitSDK.Color.White) { }

        public List<Shape> Selected_Shapes
        {
            get
            {
                List<Shape> _selectedShapes = new List<Shape>();

                foreach (Shape shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        _selectedShapes.Add(shape);
                    }
                }

                return _selectedShapes;
            }
        }

        public SplashKitSDK.Color Background
        {
            get { return _background; }

            set { _background = value; }
             
        }

        public int ShapeCount
        {
            get { return _shapes.Count;}
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
        
        public void Draw()
        {
            SplashKit.ClearScreen();
            SplashKit.FillRectangle(_background, 0, 0, 800, 600);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
            
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.IsAt(pt))
                {
                    shape.Selected = true;
                } else
                {
                    shape.Selected = false;
                }
            }
        }

        public void RemoveShape(Shape shape)
        {
      
            foreach (Shape s in _shapes) {

                if (shape == s) {

                        _shapes.Remove(shape);
                }
            }
            
        }
    }
}