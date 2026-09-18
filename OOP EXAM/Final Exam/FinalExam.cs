using OOP_EXAM.exam;
using OOP_EXAM.subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.final_Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeofexam, int numberofQuestions, Subject subject) : base(timeofexam, numberofQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam Results:\n");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                Console.WriteLine("Answers:");
                for (int j = 0; j < Questions[i].AnswerList.Length; j++)

                    Console.WriteLine($"{Questions[i].AnswerList[j].AnswerId}. " + $"{Questions[i].AnswerList[j].AnswerText}");

                Console.WriteLine($"Grade: {Questions[i].Mark}\n");
            }
        }

    }
}
