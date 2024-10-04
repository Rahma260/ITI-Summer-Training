using EFDay1.Contexts;
using EFDay1.Entities;

namespace EFDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (studdept_context context = new studdept_context())
            {
                List<Student> Students1 = new List<Student>
                {
                    new Student() { StudentName = "Rahma", Email = "Rahma@gmail.com", Age = 21 },
                    new Student() { StudentName = "Menna", Email = "Menna@gmail.com", Age = 24},
                    new Student() { StudentName = "Alaa", Email = "Alaa@gmail.com", Age = 20},
                    new Student() { StudentName = "Ahmed", Email = "Ahmed@gmail.com", Age = 27},
                };
                List<Student> Students2 = new List<Student>
                {
                    
                    new Student() { StudentName = "Khaled", Email = "Khaled@gmail.com", Age = 54},
                    new Student() { StudentName = "Hoda", Email = "Hoda@gmail.com", Age = 52},
                    new Student() { StudentName = "Mona", Email = "Mona@gmail.com", Age = 55},
                    new Student() { StudentName = "Noha", Email = "Noha@gmail.com", Age = 27},
                };
                List<Student> Students3 = new List<Student>
                {
                    new Student() { StudentName = "Rahma", Email = "Rahma@gmail.com", Age = 21 },
                    new Student() { StudentName = "Menna", Email = "Menna@gmail.com", Age = 24},
                    new Student() { StudentName = "Alaa", Email = "Alaa@gmail.com", Age = 20},
                    new Student() { StudentName = "Ahmed", Email = "Ahmed@gmail.com", Age = 27},
                };
                //foreach (Student student in Students1)
                //    context.Students.Add(student);
                //foreach (Student student in Students2)
                //    context.Students.Add(student);
                //context.SaveChanges();
                //var student_update = context.Students.Where(x => x.StudentId == 11).FirstOrDefault();
                //student_update.StudentName = "nora";
                //student_update.Email = "nora@gmail.com";
                //context.SaveChanges();
                Department department1 = new Department() { DepartmentName = "IS", DepartmentDescription = "information systems", students = Students1 };
                Department department2 = new Department() { DepartmentName = "CS" ,students = Students2};
                Department department3 = new Department() { DepartmentName = "IT", students = Students3 };
                //context.Departments.Add(department1);
                //context.Departments.Add(department2);
                //context.Departments.Add(department3);

                //context.SaveChanges();
                #region lab
                //var studentid = context.Students.Where(x => x.StudentId == 3).FirstOrDefault();
                //studentid.StudentName = "Noha";
                //var studentid1 = context.Students.Where(x => x.StudentId == 2).FirstOrDefault();
                //studentid.StudentName = "Hoda";
                //context.SaveChanges();
                //var studentid2 = context.Students.Where(x => x.StudentId == 1);
                //context.Students.Remove(studentid2);
                //context.SaveChanges();
                //Console.WriteLine("Students Information");

                //foreach (var student in context.Students)
                //{
                //    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Age: {student.Age}, Email: {student.Email}, dep_id: {student.DepartmentID}");
                //}
                //Console.WriteLine("----------------------------------------------------");
                //Console.WriteLine("Departments Information");
                //foreach (var depart in context.Departments)
                //{
                //    Console.WriteLine($"ID: {depart.DepartmentID}, Name: {depart.DepartmentName}");
                //}
                #endregion
                //var st = context.Students.Select(x => x.StudentName).ToList();
                //foreach (var item in Students3)
                //{
                //    Console.WriteLine(item.StudentName);
                //}


                //var st = context.Departments
                //    .Where(dep => dep.DepartmentName == "Is")
                //    .SelectMany(dep => dep.students)  // Flatten the students collection
                //    .ToList(); 
                //foreach (var item in st)
                //{
                //    Console.WriteLine($"{item.StudentName}, {item.StudentId}, {item.Email}");
                //}


                //var st = context.Departments
                //    .Where(dep => dep.DepartmentName == "Is")
                //    .SelectMany(dep => dep.students)
                //    // Flatten the students collection
                //    .ToList().FirstOrDefault();
                //    Console.WriteLine($"{st.StudentName}, {st.StudentId}, {st.Email} {st.DepartmentID}");


                //var st = context.Departments.Where(dep => dep.DepartmentName == "IT")
                //    .SelectMany(dep => dep.students)
                //    .Select(st => st.StudentName)
                //    .ToList();
                //foreach(var st1 in st)
                //    Console.WriteLine(st1);


                //var st = context.Students.Where(s => s.StudentName.Contains("h"))
                //    .Select(s => s.StudentName)
                //    .ToArray();
                //foreach (var st1 in st)
                //    Console.WriteLine(st1.ToLower());

                /* معناه هل فيه اسم يحتوي حرف l ولا لا*/
                //var st = context.Students.Where(s => s.StudentName.Contains("l"))
                //    .Select(s => s.StudentName).Any();
                //Console.WriteLine(st);

                /*معناه هل كل الاسماء تحتوي علي حرف a ولا لا*/
                //var st = context.Students
                //    .All(s => s.StudentName.Contains("a"));
                //Console.WriteLine(st);

                //var groupedStudents = context.Students
                //.Where(s => s.StudentName.Contains("n")).ToList() 
                //.GroupBy(s => s.Age)                   
                //.Where(g => g.Key > 23);
                //foreach (var group in groupedStudents)
                //{
                //    Console.WriteLine($"Age: {group.Key}");
                //    foreach (var student in group)
                //    {
                //        Console.WriteLine($"Student Name: {student.StudentName}, Email: {student.Email}, Age: {student.Age}");
                //    }
                //}

            }
        }
    }
}

