using System;

namespace CustomProgram
{
    internal class Ai : Bar
    {

        public Ai(string name) : base(10, name) { }


        public void Movement(Ball ball)
        {

            if ((X + 50) < ball.X) { X += 0.05; }

            if ((X + 50) > ball.X) { X -= 0.05; }

        }

        public void Reset()
        {

            Y = 15;

            X = 350;

        }

    }
}
