using AdapterPatternCore.Interfaces;

namespace AdapterPatternCore.Models
{
    public class Beth : ChairPerson
    {
        private John john = new John();

        public void OrganizeClass()
        {
            john.enjoyWithAllClassmate();
        }
    }
}
