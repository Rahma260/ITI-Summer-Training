using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace test_exam
{
        public abstract class question
        {
            public string body { get; set; }
            public string header { get; set; }
            public int mark { get; set; }
            public string  answer { get; set; }
            public question(string _body, string _header, int _mark, string Answer)
            {
                this.body = _body;
                this.header = _header;
                this.mark = _mark;
                this.answer = Answer;
            }
        }

        public class TrueOrFalse : question
        {
            public string[] choices { get; set; }
            public TrueOrFalse(string body, string header, int mark, string Answer, string[] choices) : base(body, header, mark, Answer)
            {
                this.choices = choices;
            }

    }
    public class ChooseOne : question
        {
            public string[] choices { get; set; }
            public ChooseOne(string body, string header, int mark, string[] choices, string answer) : base(body, header, mark, answer)
            {
                this.choices = choices;
            }
 
    }
    public class ChooseAll : question
        {
            public string[] choices { get; set; }
            public ChooseAll(string body, string header, int mark, string[] choices, string answer) : base(body, header, mark, answer)
            {
                this.choices = choices;
            }

    }
    public class Subject
        {
            public string SubjectName { get; set; }

            public Subject(string subjectName)
            {
                SubjectName = subjectName;
            }
        }

        public class exam
        {
            public int NumOfQuestions { get; set; }
            public question[] questions { get; set; }
            public Subject subject { get; set; }
            public string Answer { get; set; }

            public exam()
            {

            }
            public exam(int _NumOfQuestions, question[] _question, Subject _subject)
            {
                this.NumOfQuestions = _NumOfQuestions;
                this.questions = _question;
                this.subject = _subject;
             
            }
            public void Show()
            {
            Console.WriteLine("Do you want to start exam ? (if yes enter y, if no enter n)");
            string x = Console.ReadLine();
            if (x == "y" || x == "Y")
            {
                int totalmarks = 0;
                Console.WriteLine($"\nSubject: {subject.SubjectName}\n");
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    Console.WriteLine($"{questions[i].header}\tMarks: {questions[i].mark}\n{questions[i].body}\n");
                    string[] questionChoices = (questions[i] as dynamic).choices;
                    for (int j = 0; j < questionChoices.Length; j++)
                    {
                        Console.Write($"{j + 1}.{questionChoices[j]}\n");
                    }
                    Console.Write("Enter your answer:\n");
                    string answer = Console.ReadLine();
                    answer = answer.Replace(" ", "");
                    if (questions[i].answer.Trim().Equals(answer.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct answer\n");
                        totalmarks += questions[i].mark; 
                    }
                    else
                        Console.WriteLine($"Wrong answer the correct answer is {questions[i].answer}\n");
                }
                Console.WriteLine($"congrats! your total score is {totalmarks}");
            }
        }
   }
}
