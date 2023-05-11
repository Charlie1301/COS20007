using System;

namespace CustomProgram
{
    internal class Ai : Bar
    {

        public Ai(string name) : base(10, name) { }


        public override void MoveLeft(int x) { if ((X + 50) > x) { X -= 0.05; } }

        public override void MoveRight(int x) { if ((X + 50) < x) { X += 0.05; } }

        public override void Reset(int y)
        {

            Y = 15;

            X = 350;

        }

    }
}
