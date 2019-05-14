﻿using System.Collections;

namespace Core.Models
{
    public abstract class Teacher
    {
        protected StudentList studentList;

        public abstract void createStudentList();
        public abstract void callStudents();
    }
}
