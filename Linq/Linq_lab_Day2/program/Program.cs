using static program.Program;

namespace program
{
    internal class Program
    {
        public class Subject
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public Subject()
            {

            }
            public Subject(int _code, string _name)
            {
                this.Code = _code;
                this.Name = _name;
            }
        }
        public class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<Subject> Subjects { get; set; }

            public Student()
            {

            }
            public Student(int id, string firstname, string lastname, List<Subject> subjects)
            {
                this.ID = id;
                this.FirstName = firstname;
                this.LastName = lastname;
                this.Subjects = subjects;
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var query1 = numbers.OrderBy(x => x).Distinct().ToList();
            foreach (var item1 in query1)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("-----------------------------------");
            foreach (var item2 in query1)
            {
                Console.WriteLine($"Number : {item2} , Multiplicity : {item2 * item2}");
            }
            Console.WriteLine("-----------------------------------");
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            var query2 = names.Where(x => x.Length == 3);
            foreach (var item in query2)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query22 = from n in names
                          where n.Length == 3
                          select n;
            foreach (var item in query22)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query3 = names.Where(x => x.ToLower().Contains("a")).OrderBy(x => x.Length);
            foreach (var item in query3)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query33 = (from n in names
                           where n.ToLower().Contains("a")
                           select n).OrderBy(x => x.Length);
            foreach (var item in query33)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query4 = names.Take(2);
            foreach (var item in query4)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query44 = (from n in names
                           select n).Take(2);
            foreach (var item in query44)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            List<Student> students = new List<Student>(){
            new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
            Subjects=new List<Subject>{
                new Subject(){ Code=22,Name="EF"},
                new Subject(){Code=33,Name="UML"}}},
            new Student(){ ID=2, FirstName="Mona", LastName="Gala",
            Subjects=new List<Subject>{
                new Subject(){ Code=22,Name="EF"},
                new Subject (){Code=34,Name="XML"},
                new Subject (){ Code=25, Name="JS"}}},
            new Student(){ ID=3, FirstName="Yara", LastName="Yousf",
            Subjects=new List<Subject>{
                new Subject (){ Code=22,Name="EF"},
                new Subject (){Code=25,Name="JS"}}},
            new Student(){ ID=1, FirstName="Ali", LastName="Ali",
            Subjects=new List<Subject> {
                new Subject (){ Code=33,Name="UML"}}},
            };

            var query5 = students
                        .Select(stud => new {
                            FullName = string.Concat(stud.FirstName + " " + stud.LastName),
                            NumOfSubjects = stud.Subjects.Count }).ToList();
            foreach (var item in query5)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query6 = students
                .Select(stu => new {stu.FirstName, stu.LastName })
                .OrderByDescending(stu => stu.FirstName)
                .ThenBy(stu => stu.LastName);
            foreach (var item in query6)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");
            var query7 = students
                .SelectMany(stud1 => stud1.Subjects, (stud1, name) => new
                {
                    stud1.Subjects,
                    StudentName = $"{stud1.FirstName} {stud1.LastName}"
                }).ToList();
            foreach (var student in query7)
            {
                Console.WriteLine($"{student.StudentName} ");
                foreach (var sub in student.Subjects)
                {
                    Console.WriteLine($"{sub.Name}");
                }
            }
            Console.WriteLine("-----------------------------------");
            var query8 = students
                .SelectMany(stud1 => stud1.Subjects, (stud1, subject) => new
                {
                    StudentName = $"{stud1.FirstName} {stud1.LastName}"
                    , subjectname = subject.Name
                })
                .GroupBy(s => s.StudentName).ToList();
            foreach (var studentGroup in query8)
            {
                Console.WriteLine($"{studentGroup.Key}:"); 
                foreach (var subject in studentGroup)
                {
                    Console.WriteLine($"  Subject: {subject.subjectname}"); 
                }
            }
            
        }
    }
}