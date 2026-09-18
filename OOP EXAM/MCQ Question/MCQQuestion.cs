using OOP_EXAM.Answers;
using OOP_EXAM.Questions;
using System.Reflection.PortableExecutable;

public class MCQQuestion : Question
{
    public MCQQuestion(string header, string body, double mark, Answer[] answers)
        : base(header, body, mark)
    {
        AnswerList = answers;
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
        Answer[] clonedAnswers = new Answer[AnswerList.Length];
        for (int i = 0; i < AnswerList.Length; i++)
        {
            clonedAnswers[i] = (Answer)AnswerList[i].Clone();
        }

        return new MCQQuestion(Header, Body, Mark, clonedAnswers)
        {
            RightAnswer = RightAnswer != null ? (Answer)RightAnswer.Clone() : null,
            UserAnswer = UserAnswer != null ? (Answer)UserAnswer.Clone() : null
        };
    }
}