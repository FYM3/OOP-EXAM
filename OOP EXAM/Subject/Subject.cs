using OOP_EXAM.Answers;
using OOP_EXAM.Exams;
using OOP_EXAM.Questions;
using System;
using System.Timers;

namespace OOP_EXAM.Subjects
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.WriteLine($"\n--- Creating Exam for Subject: {SubjectName} ---");

            int examType;
            do
            {
                Console.Write("Please Choose Exam Type (1 for Practical, 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            int time;
            do
            {
                Console.Write("Enter the Time of Exam (30 to 180 minutes): ");
                if (!int.TryParse(Console.ReadLine(), out time) || time < 30 || time > 180)
                {
                    Console.WriteLine("Invalid input! Please enter a duration between 30 and 180 minutes.");
                }
            } while (time < 30 || time > 180);


            Console.Write("Enter the Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine()!);

            if (examType == 1)
                SubjectExam = new PracticalExam(time, numQuestions);
            else
                SubjectExam = new FinalExam(time, numQuestions);

            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine($"\n--- Entering Data for Question ({i + 1}) ---");

                int qType = 2;

                if (examType == 2)
                {
                    do
                    {
                        Console.Write("Please Choose Question Type (1 for True/False, 2 for MCQ): ");
                    } while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2));
                }

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine()!;

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine()!;

                Console.Write("Enter Question Mark: ");
                double mark = double.Parse(Console.ReadLine()!);

                if (qType == 1)
                {
                    var tfQuestion = new TFQuestion(header, body, mark);

                    Console.Write("Enter the Right Answer ID (1 for True, 2 for False): ");
                    int rightId = int.Parse(Console.ReadLine()!);

                    tfQuestion.RightAnswer = tfQuestion.AnswerList[rightId - 1];

                    SubjectExam.Questions[i] = tfQuestion;
                }
                else
                {
                    Console.Write("Enter the number of choices for this MCQ: ");
                    int numAnswers = int.Parse(Console.ReadLine()!);
                    Answer[] answers = new Answer[numAnswers];

                    for (int j = 0; j < numAnswers; j++)
                    {
                        Console.Write($"Enter Text for Choice ({j + 1}): ");
                        string ansText = Console.ReadLine()!;
                        answers[j] = new Answer(j + 1, ansText);
                    }

                    var mcqQuestion = new MCQQuestion(header, body, mark, answers);

                    Console.Write("Enter the Right Answer ID corresponding to the choices above: ");
                    int rightId = int.Parse(Console.ReadLine()!);

                    mcqQuestion.RightAnswer = answers[rightId - 1];

                    SubjectExam.Questions[i] = mcqQuestion;
                }
            }
        }
    }
}