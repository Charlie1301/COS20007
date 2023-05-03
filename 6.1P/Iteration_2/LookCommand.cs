using System;

namespace Iteration_2
{
    internal class LookCommand : Command
    {

        LookCommand() : base(new string[] { "look" }) { }

        public string Execute(Player p, string[] text) { }

        public IHaveInventory FetchContainer(Player p, string containerId) { }

        public string LookAtIn(string thingId, IHaveInventory container) { }

    }
}
