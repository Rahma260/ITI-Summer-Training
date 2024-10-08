namespace test_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("do you want to enter new exam ? (if yes enter y, if no enter n)");
                string x = Console.ReadLine();
                if (x == "y" || x == "Y")
                {
                    Console.WriteLine("Enter subject type:");
                    string sub = Console.ReadLine();
                    if (string.IsNullOrEmpty(sub))
                    {
                        Console.WriteLine("Subject cannot be empty. Please try again.");
                        return;
                    }

                    Subject subject = new Subject(sub);

                    Console.WriteLine("Enter the number of questions:");
                    if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
                    {
                        Console.WriteLine("Invalid number of questions. Please enter a positive integer.");
                        return;
                    }

                    question[] questions = new question[number];

                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine("Choose question type:\n1. True or False\n2. Choose One\n3. Choose All");
                        if (!int.TryParse(Console.ReadLine(), out int questionType) || questionType < 1 || questionType > 3)
                        {
                            Console.WriteLine("Invalid question type. Please enter 1, 2, or 3.");
                            i--;
                            continue;
                        }

                        Console.WriteLine($"Enter question {i + 1} header:");
                        string header = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(header))
                        {
                            Console.WriteLine("Question header cannot be empty.");
                            i--;
                            continue;
                        }

                        Console.WriteLine($"Enter question {i + 1} body:");
                        string body = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(body))
                        {
                            Console.WriteLine("Question body cannot be empty.");
                            i--;
                            continue;
                        }

                        Console.WriteLine($"Enter question {i + 1} mark:");
                        if (!int.TryParse(Console.ReadLine(), out int mark) || mark <= 0)
                        {
                            Console.WriteLine("Invalid mark. Please enter a positive integer.");
                            i--;
                            continue;
                        }
                        Console.WriteLine($"Enter question {i + 1} number of choices:");
                        if (!int.TryParse(Console.ReadLine(), out int numberOfChoices) || numberOfChoices <= 0)
                        {
                            Console.WriteLine("Invalid number. Please enter a positive integer.");
                            i--;
                            continue;
                        }
                        string[] choices = new string[numberOfChoices];
                        Console.WriteLine($"Enter question {i + 1} choices:");
                        for (int j = 0; j < numberOfChoices; j++)
                        {
                            Console.Write($"{j + 1}. ");
                            choices[j] = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(choices[j]))
                            {
                                Console.WriteLine("Choice cannot be empty.");
                                j--;
                            }
                        }

                        Console.WriteLine("Enter the correct answer(s) (comma-separated if multiple):");
                        string correctAnswers = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(correctAnswers))
                        {
                            Console.WriteLine("Correct answer cannot be empty.");
                            i--;
                            continue;
                        }

                        switch (questionType)
                        {
                            case 1:
                                questions[i] = new TrueOrFalse(body, header, mark, correctAnswers, choices);
                                break;
                            case 2:
                                questions[i] = new ChooseOne(body, header, mark, choices, correctAnswers);
                                break;
                            case 3:
                                questions[i] = new ChooseAll(body, header, mark, choices, correctAnswers);
                                break;
                        }
                    }

                    Console.Clear();
                    exam exam = new exam(number, questions, subject);
                    exam.Show();

                }
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
