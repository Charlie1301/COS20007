using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    internal class ai : bar
    {

        public ai(string name) : base(15, name) { }

        public void Movement(ball Ball) {

            if (X + 50 < Ball.X) { X += 0.05; }

            if (X + 50 > Ball.X) { X -= 0.05; }
        
        }

        public void Reset() { Y = 15; X = 350; }

    }
}
