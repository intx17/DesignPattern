using FactoryMethodPattern.Models;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pcp = new PaulsCutPrint();
            pcp.CreateCutPrint();
        }
    }
}
