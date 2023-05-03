using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProgram
{
    internal class Player : bar
    {

        public Player(string name) : base(785, name) { }

        public void MoveLeft() { X -= 0.03; }

        public void MoveRight() { X += 0.03; }

        public void Reset() { X = 350; Y = 785; }

    }
}
