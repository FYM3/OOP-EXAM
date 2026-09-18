using System;
using OOP_EXAM.Answers; // Make sure this matches your Answer class namespace

namespace OOP_EXAM.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        public Question() : this("No Header", "No Body", 0.0)
        {
        }

        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;

            AnswerList = Array.Empty<Answer>();
        }

        public abstract void Display();

        public override string ToString()
        {
            return $"[{Header}] (Mark: {Mark})\n{Body}";
        }

        public abstract object Clone();

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }
    }
}