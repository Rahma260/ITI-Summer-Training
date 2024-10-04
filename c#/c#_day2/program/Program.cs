using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace c__day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region avg of subject in 2d array

            Console.WriteLine("enter the number of students: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of subjects: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] avg_subject = new int[rows, cols];
            int sum = 0;
            int avg;

            for (int i = 0; i < avg_subject.GetLength(0); i++)
            {
                for (int j = 0; j < avg_subject.GetLength(1); j++)
                {
                    Console.WriteLine($"enter sbject {j + 1} of student {i + 1}");
                    avg_subject[i, j] = int.Parse(Console.ReadLine());

                    sum += avg_subject[i, j];
                }
                avg = sum / cols;
                Console.WriteLine($"the average of subjects {i + 1} is {avg}");
            }
            #endregion

            #region max difference

            Console.WriteLine("enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int maxdiff = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter the {i + 1} element of the array");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    int x = array[i];
                    int y = array[j];
                    if (x == y)
                    {
                        int diff = j - i - 1;
                        if (diff > maxdiff)
                        {
                            maxdiff = diff;
                        }
                    }
                }
            }

            Console.WriteLine($"The longest distance between two occurrences of the same integer is {maxdiff} cells.");

            #endregion

            #region reverse string
            Console.WriteLine("Enter a string:");
            string string1 = Console.ReadLine();
            char[] separators = new char[] { ' ' };
            string[] strings2 = string1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strings2);
            string reversed = string.Join(" " , strings2);
            Console.WriteLine(reversed);
            #endregion
        }
    }
}

