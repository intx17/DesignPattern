namespace Core.Models
{
    public class StudentList
    {
        protected Student[] students;
        public int LastNum { get; private set; } = 0;

        public StudentList()
        {
        }

        public StudentList(int studentCount)
        {
            students = new Student[studentCount];
        }

        public void Add(Student student)
        {
            students[LastNum] = student;
            LastNum += 1;
        }

        public Student GetStudentAt(int idx)
        {
            return students[idx];
        }
    }
}
