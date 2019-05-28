using System;
namespace BridgePattern.Models
{
    public class Sorter
    {
        public SortImple SortImple { get; set; }
        public void Sort(object obj) => SortImple.Sort(obj);
    }
}
