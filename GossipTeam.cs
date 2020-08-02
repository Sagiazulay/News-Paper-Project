using NewsCopany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    internal class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story = new Story("Title of Gossip Team", "Body of Gossip Team");           
        }

        internal override void AddStyle()
        {
            story.SetVS("Purple blurred");
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
