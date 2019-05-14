using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Models
{
    public class MyStudentListIterator : IEnumerator<Student>
    {
        private readonly MyStudentList _students;
        private int _index = -1;

        public MyStudentListIterator(MyStudentList students)
        {
            _students = students;
        }

        public Student Current
        {
            get
            {
                try
                {
                    return _students.GetStudentAt(_index);
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _students.LastNum;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
