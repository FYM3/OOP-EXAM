using OOP_EXAM.answers;
using OOP_EXAM.exam;
using OOP_EXAM.subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.practical_Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeofexam, int numberofQuestions, Subject subject) : base(timeofexam, numberofQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Console.WriteLine(Questions[i].Body);

                Console.WriteLine($"Correct Answer => {Questions[i].RightAnswer?.AnswerText}");
                Console.WriteLine();
            }
        }
    }
}
