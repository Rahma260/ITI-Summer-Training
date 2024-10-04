using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_day7
{
    public delegate int SumAge(List<student> students);
    public delegate string Print(student student);

    public class course
    {
        public int c_id { get; set; }
        public string c_name { get; set; }

        public course(int id, string name)
        {
            this.c_id = id;
            this.c_name = name;
        }
    }

    public class student
    {
        public int s_id { get; set; }
        public string s_name { get; set; }
        public int s_age { get; set; }
        public List<course> courses { get; set; } 

        public student(int id, string name, int age, List<course> course)
        {
            this.s_id = id;
            this.s_name = name;
            this.s_age = age;
            this.courses = course;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var course1 = new List<course>
            {
                new course(1, "Math"),
                new course(2, "Bio"),
            };
            var course2 = new List<course>
            {
                new course(3, "Programming"),
                new course(4, "Physics"),
            };
            var students = new List<student>
            {
                new student(1, "Rahma", 21, course1),
                new student(2, "Alaa", 20, course2),
            };

            SumAge sum = delegate (List<student> students)
            {
                int total = 0;
                foreach (var student in students)
                {
                    total += student.s_age;
                }
                return total;
            };
            Console.WriteLine($"total age: {sum.Invoke(students)}");
            Console.WriteLine("----------------------------------");

            Print printdata = student =>
            {
                string course = string.Join(", ", student.courses.Select(c => c.c_name));
                return $"Student Name: {student.s_name}, Courses: {course}";
            };

            foreach (var student in students)
            {
                Console.WriteLine(printdata(student));
            }
        }
    }
}
