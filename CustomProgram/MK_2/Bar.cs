using SplashKitSDK;
using System;

namespace CustomProgram
{
    internal class Bar
    {

        private double _y;

        private double _x = 350;

        private string _name;

        private int _score = 0;

        private Color _color = Color.Black;


        public Bar(int y, string name)
        {
            _y = y;
            _name = name;
        }


        public double X { get { return _x; } set { _x = value; } }

        public double Y { get { return _y; } set { _y = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public int Score { get { return _score; } set { _score = value; } }

        public Color Color { get { return _color; } set { _color = value; } }

        public void Reset() { _score = 0; _x = 350; _color = Color.Black; }

    } 

}
