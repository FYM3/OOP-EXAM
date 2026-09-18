using System;
using OOP_EXAM.Questions;

namespace OOP_EXAM.Exams
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public Exam() : this(60, 0)
        {
        }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Exam Time: {Time} mins | Questions Count: {NumberOfQuestions}";
        }

        public abstract object Clone();

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.Time.CompareTo(other.Time);
        }
    }
}