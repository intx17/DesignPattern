using System;
using Core.Interfaces;

namespace Core.Models
{
    public abstract class WoodCutPrint
    {
        public abstract void Draw(Cuttable material);
        public abstract void Cut(Cuttable material);
        public abstract void Print(Cuttable material);

        public void CreateWoodCutPrint()
        {
            Wood material = new Wood();
            Draw(material);
            Cut(material);
            Print(material);
        }
    }
}
