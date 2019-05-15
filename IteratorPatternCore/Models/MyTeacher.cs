using IteratorPatternCore.Enums;
using Core.Extensions;

namespace IteratorPatternCore.Models
{
    public class MyTeacher : Teacher
    {
        private new MyStudentList studentList;

        public override void createStudentList()
        {
            studentList = new MyStudentList(5);

            studentList.Add(new Student("赤井亮太", Gender.Male));
            studentList.Add(new Student("赤羽里美", Gender.Female));
            studentList.Add(new Student("岡田美央", Gender.Female));
            studentList.Add(new Student("西森俊介", Gender.Male));
            studentList.Add(new Student("中ノ森玲菜", Gender.Female));
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
