using System;
using SingletonPattern.Models;
using Core.Extensions;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var rn1 = RegisterNote.GetInstance();
            var rn2 = RegisterNote.GetInstance();

            Console.WriteLine(rn1.Equals(rn2));

            rn1.Histories.Add("History1");

            rn1.ConsoleLog("rn1");
            rn1.ConsoleLog("rn2");
        }
    }
}
