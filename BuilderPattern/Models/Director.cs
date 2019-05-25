using BuilderPattern.Interfaces

namespace BuilderPattern.Models
{
    public class Director
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            builder = builder;
        }

        public void Constract()
        {
            builder.AddSolvent(100);
            builder.AddSolute(40);
            builder.AbandonSolution(70);
            builder.AddSolvent(100);
            builder.AddSolute(15);
        }
    }
}
