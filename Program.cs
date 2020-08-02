using NewsPaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCopany
{
    class Program
    {
        private static Story[] stories;

        static void Main(string[] args)
        {
            GossipTeam GT = new GossipTeam();
            HealthTeam HT = new HealthTeam();
            PoliticsTeam PT = new PoliticsTeam();

            GT.CreateStory();
            HT.CreateStory();
            PT.CreateStory();

            NewsPaper NP = new NewsPaper(stories, 11.0f);

        }
    }
}
