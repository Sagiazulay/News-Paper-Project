using NewsCopany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    internal abstract class NewsTeam
    {
        protected Story story;

        internal abstract void CreateStory();
        internal Story GetStory()
        {
            return story;
        }
        internal virtual void AddStyle()
        {
            story.SetVS("Difault");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
