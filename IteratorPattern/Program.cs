﻿using System;
using Core.Models;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher you = new MyTeacher();
            you.createStudentList();
            you.callStudents();
        }
    }
}
