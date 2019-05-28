using System;
using BridgePattern.Models;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorter = new Sorter
            {
                SortImple = new QuickSortImple()
            };

            var timeSorter = new TimeSorter
            {
                SortImple = new BubbleSortImple()
            }
        }
    }
}
