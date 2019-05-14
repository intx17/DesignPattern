using System.Collections;

namespace Core.Models
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
