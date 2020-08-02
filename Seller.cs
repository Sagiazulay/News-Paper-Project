using NewsCopany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCopany
{
    public class Seller
    {
        private int _moneyEarned;
        public void SellNewsPaper(NewsPaper newsPaper)
        {
            _moneyEarned = (int)(_moneyEarned + newsPaper._price);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Total Sold Today : {_moneyEarned}";
        }
    }
}
