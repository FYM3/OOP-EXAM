using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_EXAM.exam
{
    internal class Exam
    {
		private int _Timeofexam;
        private int _NumberofQuestions;

        public int Timeofexam
        {
			get { return _Timeofexam; }
			set
			{
				if (value >= 30 && value <= 180)
					_Timeofexam = value;
			}
		}
		
		public int NumberofQuestions
        {
			get { return _NumberofQuestions; }
			set
			{
				if (value > 0)
					_NumberofQuestions = value;
			}
		}


        public Exam(int timeofexam, int numberofQuestions)
        {
            Timeofexam = timeofexam;
            NumberofQuestions = numberofQuestions;
        }


		public virtual void ShowExam()
		{

		}
    }
}
