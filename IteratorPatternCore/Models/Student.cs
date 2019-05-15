using IteratorPatternCore.Enums;

namespace IteratorPatternCore.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public Gender Sex { get; private set; }

        public Student(string name, Gender sex)
        {
            Name = name;
            Sex = sex;
        }
    }
}
