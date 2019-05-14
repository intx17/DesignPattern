using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Models
{
    public class NewVeteranStudentListIterator : IEnumerator<Student>
    {
        private NewVeteranStudentList _students;
        public int CurrentIdx { get; private set; } = -1;
        public int Length { get; private set; } = 0;

        public NewVeteranStudentListIterator(NewVeteranStudentList studentList)
        {
            _students = studentList;
        }

        public Student Current
        {
            get
            {
                try
                {
                    return _students.GetStudentAt(CurrentIdx);
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
            CurrentIdx += 1;
            try
            {
                _students.GetStudentAt(CurrentIdx);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Reset()
        {
            CurrentIdx = -1;
        }
    }
}
