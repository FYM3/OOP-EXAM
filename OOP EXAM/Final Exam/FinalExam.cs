using System;
using OOP_EXAM.Questions;

namespace OOP_EXAM.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            double totalMarks = 0;
            double obtainedMarks = 0;

            Console.WriteLine("\n=== Starting Final Exam ===");

            for (int i = 0; i < Questions.Length; i++)
            {
                totalMarks += Questions[i].Mark;

                Console.WriteLine($"\nQuestion ({i + 1}):");
                Questions[i].Display();

                int choice;
                do
                {
                    Console.Write("Enter your answer number: ");
                }
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Questions[i].AnswerList.Length);

                Questions[i].UserAnswer = Questions[i].AnswerList[choice - 1];

                if (Questions[i].UserAnswer.AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    obtainedMarks += Questions[i].Mark;
                }
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Final Exam Results:");
            Console.WriteLine("==========================================\n");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine($"Your Grade: {obtainedMarks} / {totalMarks}");
        }

        public override object Clone()
        {
            FinalExam cloned = new FinalExam(this.Time, this.NumberOfQuestions);
            for (int i = 0; i < Questions.Length; i++)
            {
                cloned.Questions[i] = (Question)this.Questions[i].Clone();
            }
            return cloned;
        }
    }
}