using System;
using System.Collections.Generic;

namespace ProtoTypePattern.Models
{
    public class PrototypeKeeper
    {
        private static IDictionary<string, ICloneable> Dict = new Dictionary<string, ICloneable>();

        public static void AddICloneable(string key, ICloneable prototype)
        {
            Dict.Add(key, prototype);
        }

        public static ICloneable GetClone(string key)
        {
            ICloneable prototype = Dict?[key] ?? null;
            return prototype.Clone() as ICloneable;
        }
    }
}
