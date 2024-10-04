using enumeration1;
using System.Runtime.InteropServices;

namespace c__day3_2
{
    internal class Program
    {


        #region function calculate
        static int? calculate(int x, int y, enumeration.calc operation)
        {
            bool valid = true;
            int result = 0;
            switch (operation)
            {
                case enumeration.calc.sum:
                    result = x + y;
                    break;
                case enumeration.calc.sub:
                    result = x - y;
                    break;
                case enumeration.calc.mult:
                    result = x * y;
                    break;
                case enumeration.calc.div:
                    if (y != 0)
                    {
                        result = x / y;

                    }
                    else
                    {
                        Console.WriteLine("can not devided by 0");
                        valid = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    valid = false;
                    break;
            }
            return valid ? result : (int?)null;

        }
        #endregion
        static void Main(string[] args)
        {
            #region calculate with function
            string str;
            do
            {
                Console.WriteLine("Enter two values : ");

                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("if you want summetion enter 0");
                Console.WriteLine("if you want subtraction enter 1");
                Console.WriteLine("if you want multiplication enter 2");
                Console.WriteLine("if you want division enter 3");

                int operation = int.Parse(Console.ReadLine());
                
                enumeration.calc selected_operation = (enumeration.calc)operation;
                int? result = calculate(x, y, selected_operation);
                if (result.HasValue)
                {
                    Console.WriteLine($"The result is {result.Value}");
                }

                Console.WriteLine("do you want to enter 2 values again ? \n (if yes enter yes , if no enter no)");
                str = Console.ReadLine();
            }
            while (str == "yes");
            #endregion
            #region calculate without function
            string str;
            do
            {
                Console.WriteLine("Enter two values : ");

                decimal x = decimal.Parse(Console.ReadLine());
                decimal y = decimal.Parse(Console.ReadLine());

                Console.WriteLine("if you want summetion enter 0");
                Console.WriteLine("if you want subtraction enter 1");
                Console.WriteLine("if you want multiplication enter 2");
                Console.WriteLine("if you want division enter 3");

                int operation = int.Parse(Console.ReadLine());
                bool valid = true;
                enumeration.calc selected_operation = (enumeration.calc)operation;
                decimal result = 0;

                switch (selected_operation)
                {
                    case enumeration.calc.sum:
                        result = x + y;
                        break;
                    case enumeration.calc.sub:
                        result = x - y;
                        break;
                    case enumeration.calc.mult:
                        result = x * y;
                        break;
                    case enumeration.calc.div:
                        if (y != 0)
                        {
                            result = x / y;

                        }
                        else
                        {
                            Console.WriteLine("can not devided by 0");
                            valid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        valid = false;
                        break;
                }
                if (valid)
                {
                    Console.WriteLine($"the result is {result}");
                }
                Console.WriteLine("do you want to enter 2 values again ? \n (if yes enter yes , if no enter no)");
                str = Console.ReadLine();
            }
            while (str == "yes");

            #endregion

            #region employee struct
            employee[] emparr = new employee[3];
            emparr[0] = new employee(1, 0, 3000, enumeration.gender.female, new HireDate(1, 3, 2018));
            emparr[1] = new employee(2, 1, 5500, enumeration.gender.male, new HireDate(7, 8, 2022));
            emparr[2] = new employee(3, 2, 7000, enumeration.gender.male, new HireDate(26, 6, 2019));
            foreach (var i in emparr)
            {
                Console.WriteLine(i);
                Console.WriteLine("-----------------------------");
            }

            #endregion
        }
    }
}
