using OOP_EXAM.Answers;
using OOP_EXAM.Questions;
using System.Reflection.PortableExecutable;

public class TFQuestion : Question
{
    public TFQuestion(string header, string body, double mark)
        : base(header, body, mark)
    {
        AnswerList = new Answer[]
        {
                new Answer(1, "True"),
                new Answer(2, "False")
        };
    }

    public override void Display()
    {
        Console.WriteLine(ToString());
        foreach (var answer in AnswerList)
        {
            Console.WriteLine(answer);
        }
    }

    public override object Clone()
    {
        return new TFQuestion(Header, Body, Mark)
        {
            RightAnswer = RightAnswer != null ? (Answer)RightAnswer.Clone() : null,
            UserAnswer = UserAnswer != null ? (Answer)UserAnswer.Clone() : null
        };
    }
}