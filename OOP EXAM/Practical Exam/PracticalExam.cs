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
            // Not implementated yet
        }
    }
}
