using System;

namespace CustomProgram
{
    internal class Player : Bar
    {
        // Constructor allows a name variable to identify it and a 'y' variable allows two players
        public Player(int y, string name) : base(y, name) { }

        // Move left - note movement for players is slower than AI to create a more even game experience
        public override void MoveLeft(int x) { X -= 0.03; }

        public override void MoveRight(int x) { X += 0.03; }
        // Reset functionality allows to quickly reset the bar each round
        public override void Reset(int y) { X = 350; Y = y; }

    }
}
