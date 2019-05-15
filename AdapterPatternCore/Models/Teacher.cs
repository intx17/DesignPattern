using System;
using AdapterPatternCore.Interfaces;

namespace AdapterPatternCore.Models
{
    public class Teacher
    {
        public void AssignChairPersonExtended()
        {
            ChairPerson cp = new JohnExtended();
            cp.OrganizeClass();
        }

        public void AssignChairPersonDelegate()
        {
            ChairPerson cp = new Beth();
            cp.OrganizeClass();
        }
    }
}
