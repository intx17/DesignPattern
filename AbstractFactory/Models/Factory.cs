using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern.Models
{
    public abstract class Factory
    {
        public abstract Soup Soup { get; }
        public abstract Protein Main { get; }
        public virtual IEnumerable<Vegetable> Vegetables { get => new Vegetable[] { }; }
        public virtual IEnumerable<Ingredient> Ingredients { get => new Ingredient[] { }; }
    }
}
