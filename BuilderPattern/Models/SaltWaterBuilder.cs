using BuilderPattern.Interfaces

namespace BuilderPattern.Models
{
    public class SaltWaterBuilder : IBuilder
    {
        private SaltWalter _saltWater = new SaltWalter
        {
            Salt = 0,
            Water = 0
        };

        public void AbandonSolution(double saltWaterAmount)
        {
            double saltDelta = saltWaterAmount *
                     (_saltWater.Salt / (_saltWater.Salt + _saltWater.Water));
            double waterDelta = saltWaterAmount *
                          (_saltWater.Water / (_saltWater.Salt + _saltWater.Water));
            _saltWater.Salt -= saltDelta;
            _saltWater.Water -= waterDelta;
        }

        public void AddSolute(double saltAmount)
        {
            _saltWater.Salt += saltAmount;
        }

        public void AddSolvent(double waterAmount)
        {
            _saltWater.Water += waterAmount;
        }

        object IBuilder.GetResult()
        {
            return GetResult();
        }


        public SaltWalter GetResult()
        {
            return _saltWater;
        }
    }
}
