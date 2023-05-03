using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer {

    public class Drawing {

        private readonly List<Shape> _shapes;

        private Color _background;

        public Drawing(Color background) {
            _shapes = new List<Shape> { };
            _background = background;
        }

        public Drawing() : this(Color.White) { }

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

        public Color Background
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
            foreach (Shape s in _shapes)
            {
                if (shape == s)
                {
                    _shapes.Remove(s);
                }
            }
        }

        public void Save(string file_path)
        {
            StreamWriter writer = null;

            writer = new StreamWriter(file_path);

            writer.WriteColor(_background);

            writer.WriteLine(_shapes.Count());

            foreach(Shape s in _shapes)
            {
                s.SaveTo(writer);
            }

            writer.Close();
        }

        public void Load(string file_path)
        {
            StreamReader reader = new StreamReader(file_path);
            try {
                _background = reader.ReadColor();
                int count = reader.ReadInteger();
                _shapes.Clear();
                Shape s;

                for (int i = 0; i < count; i++)
                {
                    string kind = reader.ReadLine();
                    switch (kind)
                    {
                        case "Rectangle":
                            s = new MyRectangle();
                            break;
                        case "Circle":
                            s = new MyCircle();
                            break;
                        default:
                            throw new InvalidDataException("Uknown shape kind: " + kind);
                    }

                    s.LoadFrom(reader);

                    _shapes.Add(s);
                }
            } finally {

                reader.Close();
                
            }
        }
    }
}