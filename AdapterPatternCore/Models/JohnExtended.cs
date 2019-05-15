using System;
using AdapterPatternCore.Interfaces;

namespace AdapterPatternCore.Models
{
    public class JohnExtended : John, ChairPerson
    {
        public void OrganizeClass()
        {
            enjoyWithAllClassmate();
        }
    }
}
