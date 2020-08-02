using NewsCopany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    internal class PoliticsTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story = new Story("Title of Politics Team", "Body of Politics Team");
        }
        internal override void AddStyle()
        {
            story.SetVS("Black Frame");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
