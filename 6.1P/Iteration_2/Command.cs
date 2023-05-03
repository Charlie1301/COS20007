using System;

namespace Iteration_2
{
    internal class Command : IdentifiableObject
    {

        public Command(string[] ids) : base(ids) { }

        public abstract string Execute(Player p, string[] text) { }

    }
}
