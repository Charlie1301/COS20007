using System;

namespace Iteration_2
{

    public class IdentifiableObject
    {
        private List<string> _identifiers;


        public IdentifiableObject(string[] identifiers_array)
        {

            _identifiers = new List<string>(identifiers_array);


        }
        public void Add_Identifier(string new_identifier)
        {

            _identifiers.Add(new_identifier.ToLower());
        }

        public string First_id
        {

            get
            {

                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers[0];
                }
            }
        }

        public bool Are_You(string possible_id)
        {
            bool _are_You = false;

            foreach (string identifier in _identifiers)
            {
                if (identifier != null)
                {

                    if (possible_id.ToLower() == identifier.ToLower())
                    {
                        _are_You = true;
                    }
                }
            }

            return _are_You;
        }
    }
}