using System;
using System.Collections;

namespace Core.Models
{
    public class MyStudentList : IEnumerable
    {
        private Student[] _students;

        public MyStudentList(Student[] students)
        {
            _students = students;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public MyStudentListIterator GetEnumerator()
        {
            return new MyStudentListIterator(_students);
        }
    }
}
