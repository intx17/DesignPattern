using System;
using Core.Interfaces;
using Core.Models;

namespace FactoryMethodPattern.Models
{
    public abstract class CutPrint
    {
        protected abstract void Draw(Cuttable material);
        protected abstract void Cut(Cuttable material);
        protected abstract void Print(Cuttable material);

        protected virtual Cuttable CreateCuttable()
        {
            return new Wood();
        }

        public void CreateCutPrint()
        {
            Cuttable material = CreateCuttable();
            Draw(material);
            Cut(material);
            Print(material);
        }
    }
}
