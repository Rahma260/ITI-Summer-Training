using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace examination_system
{
    public class Answer
    {
        public string answer { get; set; }
        public bool correctAns { get; set; }
        public Answer()
        {
                
        }
        public Answer(string _answer, bool correctAns)
        {
            answer = _answer;    
            this.correctAns = correctAns;
        }
    }
    public abstract class question
    { 
        public string body { get; set; }
        public string header { get; set; }
        public int mark { get; set; }
        public Answer[] Answers { get; set; }
        public question(string _body, string _header, int _mark, Answer[] answers)
        {
            this.body = _body;
            this.header = _header;
            this.mark = _mark;
            Answers = answers;
        }
        public abstract void display();
        public abstract bool validanswer(string input_answer);
    }

    public class TrueOrFalse : question
    {
        string[] choices { get; set; }
        public TrueOrFalse(string body, string header, int mark, Answer[] answer, string[] choices) : base(body, header, mark, answer)
        {
            this.choices = choices;
        }

        public override void display()
        {
            Console.WriteLine($"{header}\tMarks: {mark}\n{body}\n");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{choices[i]}");
            }
        }
        public override bool validanswer(string input_answer)
        {
            if (Answers[0].answer.Equals(input_answer, StringComparison.OrdinalIgnoreCase))
                return true;
            else
                return false;
        }
    }
    public class ChooseOne : question
    {
        string[] choices { get; set; }
        public ChooseOne(string body, string header, int mark, string[] choices, Answer[] answer) : base(body, header, mark, answer)
        {
            this.choices = choices;
        }
        public override void display()
        {
            Console.WriteLine($"{header}\tMarks: {mark}\n{body}\n");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{choices[i]}");
            }
        }
        public override bool validanswer(string input_answer)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                if (Answers[i].correctAns && choices[i].Equals(input_answer, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

    }
    public class ChooseAll : question
    {
        string[] choices { get; set; }
        public ChooseAll(string body, string header, int mark, string[] choices, Answer[] answer) : base(body, header, mark, answer)
        {
            this.choices = choices;
        }
        public override void display()
        {
            Console.WriteLine($"{header}\tMarks: {mark}\n{body}\n");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{choices[i]}");
            }
            Console.WriteLine("choose all right answers");
        }
        public override bool validanswer(string input_answer)
        {
            string[] selectedOptions = input_answer.Split(',');
            foreach (string option in selectedOptions)
            {
                bool correct = false;
                for (int j = 0; j < choices.Length; j++)
                {
                    if (choices[j].Equals(option.Trim(), StringComparison.OrdinalIgnoreCase) && Answers[j].correctAns)
                    {
                        correct = true;
                        break;
                    }
                }
                if (!correct)
                    return false;
            }
            return true;

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
            public Answer Answer { get; set; }
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
            Console.WriteLine($"Subject: {subject.SubjectName}");
            for (int i = 0; i < NumOfQuestions; i++)
            {
                questions[i].display();
                Console.WriteLine("Enter your answer: ");
                string answer = Console.ReadLine();
                if (questions[i].validanswer(answer))
                    Console.WriteLine("Correct answer");
                else
                    Console.WriteLine($"Wrong answer");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
            }
        }
    }
    }


