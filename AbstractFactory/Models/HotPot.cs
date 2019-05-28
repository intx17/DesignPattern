using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern.Models
{
    public class HotPot
    {
        public Pot Pot { get; set; }
        public Soup Soup { get; set; }
        public Protein Main { get; set; }
        public IEnumerable<Vegetable> Vegetables{ get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
