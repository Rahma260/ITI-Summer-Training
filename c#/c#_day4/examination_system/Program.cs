using System.Reflection.PortableExecutable;
using static examination_system.ChooseAll;

namespace examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("==========Enter Exam=========");
                Console.WriteLine("Enter subject type:");
                string sub = Console.ReadLine();
                Subject subject = new Subject(sub);
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Enter number of questions:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");
                question[] questions = new question[number];
                for (int i = 0; i < number; i++)
                {

                    Console.WriteLine("Choose question type:\n1. True or False\n2. Choose One\n3. Choose All");
                    int questionType = int.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Enter question header:");
                    string header = Console.ReadLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Enter question body:");
                    string body = Console.ReadLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Enter question mark:");
                    int mark = int.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------");

                    Console.WriteLine("Enter the number of choices:");
                    int numChoices = int.Parse(Console.ReadLine());
                    string[] choices = new string[numChoices];
                    Answer[] answers = new Answer[numChoices];

                    Console.WriteLine("Enter the choices:");
                    for (int j = 0; j < numChoices; j++)
                    {
                        Console.Write($"{j + 1}: ");
                        choices[j] = Console.ReadLine();
                    }
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Enter the correct answer(s) (comma-separated if multiple):");
                    string correctAnswers = Console.ReadLine();
                    string[] correctAnswerArray = correctAnswers.Split(',');

                    for (int k = 0; k < numChoices; k++)
                    {
                        bool isCorrect = Array.Exists(correctAnswerArray, answer => answer.Trim().Equals(choices[k], StringComparison.OrdinalIgnoreCase));
                        answers[k] = new Answer(choices[k], isCorrect);
                    }

                    switch (questionType)
                    {
                        case 1:
                            questions[i] = new TrueOrFalse(body, header, mark, new Answer[] { answers[0] }, choices);
                            break;
                        case 2:
                            questions[i] = new ChooseOne(body, header, mark, choices, answers);
                            break;
                        case 3:
                            questions[i] = new ChooseAll(body, header, mark, choices, answers);
                            break;
                        default:
                            Console.WriteLine("Invalid question type.");
                            i--;
                            break;
                    }
                    Console.WriteLine("-----------------------------");
                }

                Console.Clear();
                Console.WriteLine("==========Start Exam==========");
                exam exam = new exam(number, questions, subject);
                exam.Show();
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input format is incorrect. Please try again.");
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

