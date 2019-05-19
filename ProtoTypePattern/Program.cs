using System;
using Core.Extensions;
using ProtoTypePattern.Models;

namespace ProtoTypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Teacher();
            var papers = t1.CreateCrystals();
            papers.ConsoleLog("papers");
            var snow = PrototypeKeeper.GetClone("雪の結晶");
            snow.ConsoleLog("snow");
        }
    }
}
