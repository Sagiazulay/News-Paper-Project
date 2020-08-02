using NewsCopany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    internal class HealthTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story = new Story("Title of Health Team", "Body of Health Team");
        }
        internal override void AddStyle()
        {
            story.SetVS("White Frame");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, ";
        }
    }
}
