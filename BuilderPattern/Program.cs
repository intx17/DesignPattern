using BuilderPattern.Interfaces;
using BuilderPattern.Models;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SaltWaterBuilder builder = new SaltWaterBuilder();
            Director dir = new Director(builder);
            dir.Constract();
            SaltWater saltWater = builder.GetResult();
        }
    }
}
