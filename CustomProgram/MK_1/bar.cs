using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    public class bar
    {
        private double _y;

        private double _x = 350;

        private string _name;

        private int _score = 0;

        public bar(int y, string name) { _y = y; _name = name; }

        public double X { get { return _x; } set { _x = value; } }

        public double Y { get { return _y; } set { _y = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public int Score { get { return _score; } set { _score = value; } }

    }
}
