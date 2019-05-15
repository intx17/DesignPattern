using System.Collections;

namespace IteratorPatternCore.Models
{
    public class NewVeteranStudentList : NewStudentList, IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public NewVeteranStudentListIterator GetEnumerator()
        {
            return new NewVeteranStudentListIterator(this);
        }
    }
}
