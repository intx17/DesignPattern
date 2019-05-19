using System;
using System.Linq;

namespace ProtoTypePattern.Models
{
    public class Teacher
    {
        public Paper[] CreateCrystals()
        {
            Paper protoType = new Paper("雪の結晶");
            DrawCrystal(protoType);
            CutAccordanceWithLine(protoType);

            PrototypeKeeper.AddICloneable(protoType.Name, protoType);

            // Cloneが1回だけ走る
            //Paper[] papers = Enumerable.Repeat(protoType.Clone(), 100)
            //.ToArray();
            // Cloneが100回走る
            Paper[] papers = (new int[100]).Select(v => protoType.Clone()).ToArray();

            return papers;
        }

        private void CutAccordanceWithLine(Paper p)
        {
            Console.WriteLine($"{p.Name}cut");
        }

        private void DrawCrystal(Paper p)
        {
            Console.WriteLine($"{p.Name}draw");
        }
    }
}
