using System;

namespace Iteration_2
{
    public interface IHaveInventory
    {
        public GameObject Locate(string id);
        public string Name { get; }

    }
}