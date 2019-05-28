using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern.Models
{
    public class MizutakiFactory : Factory
    {
        public override Soup Soup { get => new ChickenBonesSoup(); }
        public override Protein Main { get => new Chicken(); }
        public override IEnumerable<Vegetable> Vegetables { get => new Vegetable[]
            {
                new ChineseCabbage(),
                new Leek(),
                new Chrysanthemum()
            };
        }
        public override IEnumerable<Ingredient> Ingredients { get => new Ingredient[]
            {
                new Tofu()
            };
        }
    }
}
