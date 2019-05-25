using System;
namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        void AddSolute(double soluteAmount);
        void AddSolvent(double solventAmount);
        void AbandonSolution(double solutionAmount);
        object GetResult();
    }
}
