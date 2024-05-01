using LMSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public static class FakeDatabase
    {
        private static List<Student> students = new List<Student>();
        private static List<Course> courses = new List<Course>();
        public static List<Student> Student
        {
            get
            {
                return students;
            }
        }

        public static List<Course> Courses
        {
            get
            {
                return courses;
            }
        }
    }
}
