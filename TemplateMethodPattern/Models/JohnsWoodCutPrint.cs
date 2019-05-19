using System;
using Core.Interfaces;
using Core.Models;

namespace TemplateMethodPattern.Models
{
    public class JohnsWoodCutPrint : WoodCutPrint
    {
        public override void Cut(Cuttable material)
        {
            Console.WriteLine("Cut");
        }

        public override void Draw(Cuttable material)
        {
            Console.WriteLine("Draw");
        }

        public override void Print(Cuttable material)
        {
            Console.WriteLine("Print");
        }
    }
}
