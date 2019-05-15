using System;
using AdapterPatternCore.Models;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Teacher();
            t.AssignChairPersonExtended();
            t.AssignChairPersonDelegate();
        }
    }
}
