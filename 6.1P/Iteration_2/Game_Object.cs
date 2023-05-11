using System;
using System.Collections.Generic;
using Iteration_2;

namespace Iteration_2 {

    public class GameObject : IdentifiableObject{

        private string _name;

        private string _description;

        public GameObject(string[] identifiers, string name, string description) : base(identifiers) {

            _name = name;
            _description = description;

        }

        public String Name { get { return _name; } }

        public string ShortDescription { get { return $"a {_name} ({First_id})"; } }

        public virtual string FullDescription() { return _description; }

    }

}