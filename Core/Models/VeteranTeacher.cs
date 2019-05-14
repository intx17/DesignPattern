using System;
using Core.Enums;
using Core.Extensions;

namespace Core.Models
{
    public class VeteranTeacher : Teacher
    {
        private new NewVeteranStudentList studentList;

        public override void createStudentList()
        {
            studentList = new NewVeteranStudentList();

            studentList.Add(new Student("赤井亮太", Gender.Male));
            studentList.Add(new Student("赤羽里美", Gender.Female));
            studentList.Add(new Student("岡田美央", Gender.Female));
            studentList.Add(new Student("西森俊介", Gender.Male));
            studentList.Add(new Student("中ノ森玲菜", Gender.Female));
        }

        public override void callStudents()
        {
            var enumerator = studentList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.ConsoleLog($"{enumerator.CurrentIdx}");
            }
        }
    }
}
