using System;
using System.Net.Security;
namespace day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            #region
            int xnum = int.Parse(Console.ReadLine()); ;
            Console.WriteLine(xnum);
            #endregion

            //2
            #region
            int ynum = int.Parse(Console.ReadLine());
            if (ynum % 3 == 0 || ynum % 4 == 0)
                Console.WriteLine("yes");
            Console.WriteLine("no");
            #endregion

            //3
            #region
            int num1 = int.Parse(Console.ReadLine()); ;
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);
            #endregion

            //4
            #region
            int num = int.Parse(Console.ReadLine()); ;
            if (num > 0)
                Console.WriteLine("positive");
            else
                Console.WriteLine("negatve");
            #endregion

            //5
                #region
            int x_1 = int.Parse(Console.ReadLine());
            int y_1= int.Parse(Console.ReadLine());
            int z_1= int.Parse(Console.ReadLine());

            int max = x_1;
            int min = y_1;

            if (max > y_1 && max > z_1)
                Console.WriteLine(max);
            else if (max < y_1 && max > z_1)
            {
                max = y_1;
                Console.WriteLine(max);
            }
            else if (max < z_1 && max > y_1)
            {
                max = z_1;
                Console.WriteLine(max);
            }

            if (min < x_1 && min < z_1)
                Console.WriteLine(min);
            else if (min > x_1 && min < z_1)
            {
                min = x_1;
                Console.WriteLine(min);
            }
            else if (min > z_1 && min < x_1)
            {
                min = z_1;
                Console.WriteLine(min);
            }
            #endregion

            //6
            #region
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + " is even");
            else
                Console.WriteLine(number + " is odd");
            #endregion

            //7
            #region
            char c1 = Console.ReadKey().KeyChar;

            if (c1 == 'e' || c1 == 'o' || c1 == 'i' || c1 == 'a' || c1 == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion

            //8
            #region
            int x11 = int.Parse(Console.ReadLine());
            int y22 = int.Parse(Console.ReadLine());
            double power = Math.Pow(x11, y22);
            Console.WriteLine(power);
            #endregion

            //9
            #region
            Console.WriteLine("enter marks of five subject: ");

            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());

            double total = x1 + x2 + x3 + x4 + x5;
            Console.WriteLine("total = " + total);
            double avg = total / 5;
            Console.WriteLine("average = " + avg);
            double percentage = (total / 500) * 100;
            Console.WriteLine("percentage = " + percentage);
            #endregion

            //10
            #region
            Console.WriteLine("enter marks of five subject: ");
            Console.WriteLine("physics");
            int x111 = int.Parse(Console.ReadLine());
            Console.WriteLine("biology");
            int x222 = int.Parse(Console.ReadLine());
            Console.WriteLine("chemistry");
            int x333 = int.Parse(Console.ReadLine());
            Console.WriteLine("math");
            int x444 = int.Parse(Console.ReadLine());
            Console.WriteLine("computer");
            int x555 = int.Parse(Console.ReadLine());

            double total1 = x111 + x222 + x333 + x444 + x555;
            double percentage1 = (total1 / 500) * 100;

            if (percentage1 >= 90)
                Console.WriteLine("grade A");
            else if (percentage1 >= 80)
                Console.WriteLine("grade B");
            else if (percentage1 >= 70)
                Console.WriteLine("grade C");
            else if (percentage1 >= 60)
                Console.WriteLine("grade D");
            else if (percentage1 >= 40)
                Console.WriteLine("grade E");
            else
                Console.WriteLine("grade F");
            #endregion

            //12
            #region
            int number1 = int.Parse(Console.ReadLine());
            switch (Math.Sign(number1))
            {
                case 1:
                    Console.WriteLine("positive");
                    break;
                case -1:
                    Console.WriteLine("negative");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
            #endregion

            //13
            #region
            int x = int.Parse(Console.ReadLine());
            char c = Console.ReadKey().KeyChar;
            int y = int.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine(x + "+" + y + "=" + (x + y));
                    break;
                case '-':
                    Console.WriteLine(x + "-" + y + "=" + (x - y));
                    break;
                case '*':
                    Console.WriteLine(x + "*" + y + "=" + (x * y));
                    break;
                case '/':
                    Console.WriteLine(x + "/" + y + "=" + (x / y));
                    break;
                case '%':
                    Console.WriteLine(x + "%" + y + "=" + (x % y));
                    break;
            }

            #endregion


        }
    }
}
