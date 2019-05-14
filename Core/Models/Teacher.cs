using System.Collections;

namespace Core.Models
{
    public abstract class Teacher
    {
        protected IEnumerable studentList;

        public abstract void createStudentList();
        public abstract void callStudents();
    }
}
