using System;
using System.Collections;
using System.Linq;
using Core.Enums;
using Core.Extensions;

namespace Core.Models
{
    public class MyTeacher : Teacher
    {
        public override void createStudentList()
        {
            var students = new Student[] {
                new Student("赤井亮太", Gender.Male),
                new Student("赤羽里美", Gender.Female),
                new Student("岡田美央", Gender.Female),
                new Student("西森俊介", Gender.Male),
                new Student("中ノ森玲菜", Gender.Female)
            };

            studentList = new MyStudentList(students);
        }

        public override void callStudents()
        {
            var idx = 0;
            var enumerator = studentList.GetEnumerator();
            while(enumerator.MoveNext())
            {
                enumerator.Current.ConsoleLog($"{idx}");
                idx++;
            }
        }
    }
}
