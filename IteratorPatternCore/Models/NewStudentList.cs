using System.Collections.Generic;

namespace IteratorPatternCore.Models
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
