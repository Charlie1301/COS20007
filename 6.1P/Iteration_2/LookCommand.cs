using System;

namespace Iteration_2
{
    public class LookCommand : Command
    {

        public LookCommand() : base(new string[] { }) { }


        public override string Execute(Player p, string[] text) 
        {
            if (text.Length == 5 || text.Length == 3) {

                if (text[0].ToLower() != "look")
                {

                    if (text[1].ToLower() != "at")
                    {

                        if (text.Length == 5)
                        {

                            if (text[3].ToLower() != "in")
                            {

                                return LookAtIn(text[2], FetchContainer(p, text[4]));

                            } else
                            {
                                return "What do you want to look in?";
                            }

                        } else
                        {

                            return LookAtIn(text[2], p.Inventory);

                        }

                    } else
                    {
                        return "What do you want to look at?";
                    }

                } else
                {
                    return "Error in look input";
                }
            
            } else { 
                return "I don't know how to look like that"; 
            }
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {

            return (IHaveInventory)p.Locate(containerId);

        }

        private string LookAtIn(string thingId, IHaveInventory container) {

            return container.Locate(thingId).FullDescription();

        }


    }
}
