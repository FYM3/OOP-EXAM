using System;
using System.Diagnostics;
using OOP_EXAM.Subjects;

namespace OOP_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q10)

            Subject subject = new Subject(101, "Object-Oriented Programming (C#)");

            subject.CreateExam();

            Console.Clear();
            Console.Write("Do you want to start the exam now? (Y/N): ");

            if (char.TryParse(Console.ReadLine(), out char startChoice) && (startChoice == 'Y' || startChoice == 'y'))
            {
                Console.Clear();

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                subject.SubjectExam.ShowExam();

                stopwatch.Stop();
                Console.WriteLine($"\nTime Elapsed: {stopwatch.Elapsed.Minutes} min(s) and {stopwatch.Elapsed.Seconds} sec(s).");
            }
            else
                Console.WriteLine("\nExam execution canceled.");

            #endregion
        }
    }
}