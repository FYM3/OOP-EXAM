using System;

namespace OOP_EXAM.Answers
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public Answer() : this(0, "No Answer Text")
        {
        }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(this.AnswerId, this.AnswerText);
        }

        public int CompareTo(Answer other)
        {
            if (other == null) return 1;
            return this.AnswerId.CompareTo(other.AnswerId);
        }
    }
}