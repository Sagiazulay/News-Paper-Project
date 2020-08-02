using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCopany
{
    public class NewsPaper
    {
        private Story[] stories;
        public float _price;

        public NewsPaper(Story[] stories, float price)
        {
            this.stories = stories;
            _price = price;
        }

        public Story[] GetStories()
        {
            return stories;
        }
        public void SetStories(Story[] stories)
        {
            this.stories = stories;
        }
        public float GetPrice()
        {
            return _price;
        }
        public void SetPrice(float price)
        {
            this._price = price;
        }
        public Story[] Stories()
        {
            return stories;
        }
        public override string ToString()
        {
            return $"Stories : {stories}, Price : {_price}, ToString : {ToString()}";
        }
    }
}
