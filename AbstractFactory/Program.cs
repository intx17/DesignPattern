using System;
using System.Collections.Generic;
using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.Models;
using Core.Extensions;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = HotPotNameEnum.Mizutaki.GetFactory();
            HotPot hotPot = new HotPot
            {
                Pot = new Pot(),
                Soup = factory.Soup,
                Main = factory.Main, 
                Vegetables = factory.Vegetables,
                Ingredients = factory.Ingredients
            };
            hotPot.ConsoleLog("hotpot");
        }
    }
}
