using System;
using TemplateMethodPattern.Models;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var jwcp = new JohnsWoodCutPrint();
            jwcp.CreateWoodCutPrint();
        }
    }
}
