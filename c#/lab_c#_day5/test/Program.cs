namespace test
{
    public class student : ICloneable, IComparable
    {
        public int id { get; set; }

        public string name { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string department { get; set; }

        public student (): this(0, "unknown", 0,"unknown")
        {

        }
        public student (int id , string name, int age,string department)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
        }
        public object Clone()
        {
            student st = new student();
            st.id = this.id;
            st.name = this.name;
            st.age = this.age;
            st.department = this.department;
            return st;
        }
        public int CompareTo(object? obj)
        {
            student st1 = (student)obj;
            if (st1.age > this.age) 
                return -1;
            else if (st1.age < this.age)
                return 1;
            else return 0;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student st1 = new student();
            student st2 = new student();
            st2 = (student)st1.Clone();
            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine("----------------------------");
            Console.WriteLine(st2.GetHashCode());
            Console.WriteLine("=============================");

            student[] st3 = new student[]
            {
                new student(1,"rahma",21,"IS"),
                new student(2,"alaa",20,"bio"),
                new student(3,"menna",24,"food"),
                new student(4,"ahmed",27,"chemistry"),
            };
            Array.Sort(st3);
            foreach (student st in st3)
            {
                Console.WriteLine(st.Age);
            }
        }
    }
}
