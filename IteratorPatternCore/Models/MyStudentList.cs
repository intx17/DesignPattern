﻿using System.Collections;

namespace IteratorPatternCore.Models
{
    public class MyStudentList : StudentList, IEnumerable
    {
        public MyStudentList() { }

        public MyStudentList(int studentCount) : base(studentCount) { }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public MyStudentListIterator GetEnumerator()
        {
            return new MyStudentListIterator(this);
        }
    }
}
