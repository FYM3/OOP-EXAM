using System;
using OOP_EXAM.Questions;

namespace OOP_EXAM.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("\n=== Starting Practical Exam ===");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion ({i + 1}):");

                Questions[i].Display();

                int choice;
                do
                {
                    Console.Write("Enter your answer number: ");
                }
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Questions[i].AnswerList.Length);

                Questions[i].UserAnswer = Questions[i].AnswerList[choice - 1];
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Exam Finished! Here are the Right Answers:");
            Console.WriteLine("==========================================\n");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine("------------------------------------------");
            }
        }

        public override object Clone()
        {
            PracticalExam cloned = new PracticalExam(this.Time, this.NumberOfQuestions);
            for (int i = 0; i < Questions.Length; i++)
            {
                cloned.Questions[i] = (Question)this.Questions[i].Clone();
            }
            return cloned;
        }
    }
}