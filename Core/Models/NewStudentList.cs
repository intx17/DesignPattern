using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Models
{
    public class NewStudentList
    {
        protected List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public Student GetStudentAt(int idx)
        {
            return students[idx];
        }
    }
}
