using System;
using Core.Interfaces;

namespace FactoryMethodPattern.Models
{
    public class PaulsCutPrint : CutPrint
    {
        protected override void Draw(Cuttable material)
        {
            Console.WriteLine("マンガの絵を描く");
        }
        protected override void Cut(Cuttable material)
        {
            Console.WriteLine("彫刻刀を利用して器用に彫る");
        }
        protected override void Print(Cuttable material)
        {
            Console.WriteLine("インクとして、自分の血を使いプリントする");
        }
        protected override Cuttable CreateCuttable()
        {
            return new Potato();
        }
    }
}
