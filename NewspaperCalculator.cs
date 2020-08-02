using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCopany
{
    internal static class NewspaperCalculator
    {       
        internal static int CalcNumberOfCharts(NewsPaper newsPaper)
        {
            int sum = 0;
            for (int i = 0; i < newsPaper.GetStories().Length; i++)
            {
                sum = sum + newsPaper.GetStories()[i].GetTitle().Length +
                newsPaper.GetStories()[i].GetBody().Length +
                newsPaper.GetStories()[i].GetVS().Length;
            }
            return sum;
        }
    }
}
