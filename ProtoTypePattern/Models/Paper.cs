using System;

namespace ProtoTypePattern.Models
{
    public class Paper : ICloneable
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        private static int Count = 0;

        public Paper(string name)
        {
            Name = name;
            Number = Count;
            Count += 1;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public Paper Clone()
        {
            return new Paper(Name);
        }
    }
}